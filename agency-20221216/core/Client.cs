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

        /**
          * Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
          * You can call this operation to cancel the subscription to only one type of bill at a time.
          * After the subscription to a type of bill is canceled, bills of this type are no longer pushed to the specified Object Storage Service (OSS) bucket.
          * **This topic is published only on the international site (alibabacloud.com).
          *
          * @param request CancelSubscriptionBillRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CancelSubscriptionBillResponse
         */
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

        /**
          * Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
          * You can call this operation to cancel the subscription to only one type of bill at a time.
          * After the subscription to a type of bill is canceled, bills of this type are no longer pushed to the specified Object Storage Service (OSS) bucket.
          * **This topic is published only on the international site (alibabacloud.com).
          *
          * @param request CancelSubscriptionBillRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CancelSubscriptionBillResponse
         */
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

        /**
          * Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
          * You can call this operation to cancel the subscription to only one type of bill at a time.
          * After the subscription to a type of bill is canceled, bills of this type are no longer pushed to the specified Object Storage Service (OSS) bucket.
          * **This topic is published only on the international site (alibabacloud.com).
          *
          * @param request CancelSubscriptionBillRequest
          * @return CancelSubscriptionBillResponse
         */
        public CancelSubscriptionBillResponse CancelSubscriptionBill(CancelSubscriptionBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelSubscriptionBillWithOptions(request, runtime);
        }

        /**
          * Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
          * You can call this operation to cancel the subscription to only one type of bill at a time.
          * After the subscription to a type of bill is canceled, bills of this type are no longer pushed to the specified Object Storage Service (OSS) bucket.
          * **This topic is published only on the international site (alibabacloud.com).
          *
          * @param request CancelSubscriptionBillRequest
          * @return CancelSubscriptionBillResponse
         */
        public async Task<CancelSubscriptionBillResponse> CancelSubscriptionBillAsync(CancelSubscriptionBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelSubscriptionBillWithOptionsAsync(request, runtime);
        }

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

        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomerWithOptions(request, runtime);
        }

        public async Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomerWithOptionsAsync(request, runtime);
        }

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

        public CustomerQuotaRecordListResponse CustomerQuotaRecordList(CustomerQuotaRecordListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CustomerQuotaRecordListWithOptions(request, runtime);
        }

        public async Task<CustomerQuotaRecordListResponse> CustomerQuotaRecordListAsync(CustomerQuotaRecordListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CustomerQuotaRecordListWithOptionsAsync(request, runtime);
        }

        /**
          * Note that sometimes you may find that the customer\\"s Used Credit is negative. This indicates that there is no need to restore the Used Credit, and its ready for customer\\"s usage. This phenomenon occurs because a refund is generated while the customer\\"s credit is full, thereby triggered additional increasing on the customer\\"s credit.
          * For example, if the customer\\"s maximum Available Credit is 1000 with no usage, and a refund of 300 occurs, the Used Credit will become -300.
          *
          * @param request DeductOutstandingBalanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeductOutstandingBalanceResponse
         */
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

        /**
          * Note that sometimes you may find that the customer\\"s Used Credit is negative. This indicates that there is no need to restore the Used Credit, and its ready for customer\\"s usage. This phenomenon occurs because a refund is generated while the customer\\"s credit is full, thereby triggered additional increasing on the customer\\"s credit.
          * For example, if the customer\\"s maximum Available Credit is 1000 with no usage, and a refund of 300 occurs, the Used Credit will become -300.
          *
          * @param request DeductOutstandingBalanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeductOutstandingBalanceResponse
         */
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

        /**
          * Note that sometimes you may find that the customer\\"s Used Credit is negative. This indicates that there is no need to restore the Used Credit, and its ready for customer\\"s usage. This phenomenon occurs because a refund is generated while the customer\\"s credit is full, thereby triggered additional increasing on the customer\\"s credit.
          * For example, if the customer\\"s maximum Available Credit is 1000 with no usage, and a refund of 300 occurs, the Used Credit will become -300.
          *
          * @param request DeductOutstandingBalanceRequest
          * @return DeductOutstandingBalanceResponse
         */
        public DeductOutstandingBalanceResponse DeductOutstandingBalance(DeductOutstandingBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeductOutstandingBalanceWithOptions(request, runtime);
        }

        /**
          * Note that sometimes you may find that the customer\\"s Used Credit is negative. This indicates that there is no need to restore the Used Credit, and its ready for customer\\"s usage. This phenomenon occurs because a refund is generated while the customer\\"s credit is full, thereby triggered additional increasing on the customer\\"s credit.
          * For example, if the customer\\"s maximum Available Credit is 1000 with no usage, and a refund of 300 occurs, the Used Credit will become -300.
          *
          * @param request DeductOutstandingBalanceRequest
          * @return DeductOutstandingBalanceResponse
         */
        public async Task<DeductOutstandingBalanceResponse> DeductOutstandingBalanceAsync(DeductOutstandingBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeductOutstandingBalanceWithOptionsAsync(request, runtime);
        }

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditEndUserStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EditEndUserStatusResponse
         */
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

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditEndUserStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EditEndUserStatusResponse
         */
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

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditEndUserStatusRequest
          * @return EditEndUserStatusResponse
         */
        public EditEndUserStatusResponse EditEndUserStatus(EditEndUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditEndUserStatusWithOptions(request, runtime);
        }

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditEndUserStatusRequest
          * @return EditEndUserStatusResponse
         */
        public async Task<EditEndUserStatusResponse> EditEndUserStatusAsync(EditEndUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditEndUserStatusWithOptionsAsync(request, runtime);
        }

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditNewBuyStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EditNewBuyStatusResponse
         */
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

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditNewBuyStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EditNewBuyStatusResponse
         */
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

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditNewBuyStatusRequest
          * @return EditNewBuyStatusResponse
         */
        public EditNewBuyStatusResponse EditNewBuyStatus(EditNewBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditNewBuyStatusWithOptions(request, runtime);
        }

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditNewBuyStatusRequest
          * @return EditNewBuyStatusResponse
         */
        public async Task<EditNewBuyStatusResponse> EditNewBuyStatusAsync(EditNewBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditNewBuyStatusWithOptionsAsync(request, runtime);
        }

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditZeroCreditShutdownRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EditZeroCreditShutdownResponse
         */
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

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditZeroCreditShutdownRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EditZeroCreditShutdownResponse
         */
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

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditZeroCreditShutdownRequest
          * @return EditZeroCreditShutdownResponse
         */
        public EditZeroCreditShutdownResponse EditZeroCreditShutdown(EditZeroCreditShutdownRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditZeroCreditShutdownWithOptions(request, runtime);
        }

        /**
          * The caller should be the Partner as identified in the Alibaba Cloud distribution model. </br>
          * **This content is only published on the international site. **
          *
          * @param request EditZeroCreditShutdownRequest
          * @return EditZeroCreditShutdownResponse
         */
        public async Task<EditZeroCreditShutdownResponse> EditZeroCreditShutdownAsync(EditZeroCreditShutdownRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditZeroCreditShutdownWithOptionsAsync(request, runtime);
        }

        /**
          * Caller must be a Partner from International Site, either Distribution or Reseller will do.
          *
          * @param request ExportCustomerQuotaRecordRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ExportCustomerQuotaRecordResponse
         */
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

        /**
          * Caller must be a Partner from International Site, either Distribution or Reseller will do.
          *
          * @param request ExportCustomerQuotaRecordRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ExportCustomerQuotaRecordResponse
         */
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

        /**
          * Caller must be a Partner from International Site, either Distribution or Reseller will do.
          *
          * @param request ExportCustomerQuotaRecordRequest
          * @return ExportCustomerQuotaRecordResponse
         */
        public ExportCustomerQuotaRecordResponse ExportCustomerQuotaRecord(ExportCustomerQuotaRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportCustomerQuotaRecordWithOptions(request, runtime);
        }

        /**
          * Caller must be a Partner from International Site, either Distribution or Reseller will do.
          *
          * @param request ExportCustomerQuotaRecordRequest
          * @return ExportCustomerQuotaRecordResponse
         */
        public async Task<ExportCustomerQuotaRecordResponse> ExportCustomerQuotaRecordAsync(ExportCustomerQuotaRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportCustomerQuotaRecordWithOptionsAsync(request, runtime);
        }

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

        public GetAccountInfoResponse GetAccountInfo(GetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountInfoWithOptions(request, runtime);
        }

        public async Task<GetAccountInfoResponse> GetAccountInfoAsync(GetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountInfoWithOptionsAsync(request, runtime);
        }

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

        public GetCreditInfoResponse GetCreditInfo(GetCreditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCreditInfoWithOptions(request, runtime);
        }

        public async Task<GetCreditInfoResponse> GetCreditInfoAsync(GetCreditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCreditInfoWithOptionsAsync(request, runtime);
        }

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

        public GetDailyBillResponse GetDailyBill(GetDailyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDailyBillWithOptions(request, runtime);
        }

        public async Task<GetDailyBillResponse> GetDailyBillAsync(GetDailyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDailyBillWithOptionsAsync(request, runtime);
        }

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

        public GetInviteStatusResponse GetInviteStatus(GetInviteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInviteStatusWithOptions(request, runtime);
        }

        public async Task<GetInviteStatusResponse> GetInviteStatusAsync(GetInviteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInviteStatusWithOptionsAsync(request, runtime);
        }

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

        public GetMonthlyBillResponse GetMonthlyBill(GetMonthlyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonthlyBillWithOptions(request, runtime);
        }

        public async Task<GetMonthlyBillResponse> GetMonthlyBillAsync(GetMonthlyBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonthlyBillWithOptionsAsync(request, runtime);
        }

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

        public GetUnassociatedCustomerResponse GetUnassociatedCustomer(GetUnassociatedCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUnassociatedCustomerWithOptions(request, runtime);
        }

        public async Task<GetUnassociatedCustomerResponse> GetUnassociatedCustomerAsync(GetUnassociatedCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUnassociatedCustomerWithOptionsAsync(request, runtime);
        }

        /**
          * The current API request rate for the Cloud Product has not been disclosed.
          *
          * @param request InviteSubAccountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return InviteSubAccountResponse
         */
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

        /**
          * The current API request rate for the Cloud Product has not been disclosed.
          *
          * @param request InviteSubAccountRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return InviteSubAccountResponse
         */
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

        /**
          * The current API request rate for the Cloud Product has not been disclosed.
          *
          * @param request InviteSubAccountRequest
          * @return InviteSubAccountResponse
         */
        public InviteSubAccountResponse InviteSubAccount(InviteSubAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InviteSubAccountWithOptions(request, runtime);
        }

        /**
          * The current API request rate for the Cloud Product has not been disclosed.
          *
          * @param request InviteSubAccountRequest
          * @return InviteSubAccountResponse
         */
        public async Task<InviteSubAccountResponse> InviteSubAccountAsync(InviteSubAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InviteSubAccountWithOptionsAsync(request, runtime);
        }

        /**
          * The current API request rate for cloud products has not been disclosed.
          *
          * @param request ListCountriesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListCountriesResponse
         */
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

        /**
          * The current API request rate for cloud products has not been disclosed.
          *
          * @param request ListCountriesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListCountriesResponse
         */
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

        /**
          * The current API request rate for cloud products has not been disclosed.
          *
          * @return ListCountriesResponse
         */
        public ListCountriesResponse ListCountries()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCountriesWithOptions(runtime);
        }

        /**
          * The current API request rate for cloud products has not been disclosed.
          *
          * @return ListCountriesResponse
         */
        public async Task<ListCountriesResponse> ListCountriesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCountriesWithOptionsAsync(runtime);
        }

        /**
          * Caller must be a Partner from International Site, either Distribution or Reseller will do.
          *
          * @param request QuotaListExportPagedRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QuotaListExportPagedResponse
         */
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

        /**
          * Caller must be a Partner from International Site, either Distribution or Reseller will do.
          *
          * @param request QuotaListExportPagedRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QuotaListExportPagedResponse
         */
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

        /**
          * Caller must be a Partner from International Site, either Distribution or Reseller will do.
          *
          * @param request QuotaListExportPagedRequest
          * @return QuotaListExportPagedResponse
         */
        public QuotaListExportPagedResponse QuotaListExportPaged(QuotaListExportPagedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuotaListExportPagedWithOptions(request, runtime);
        }

        /**
          * Caller must be a Partner from International Site, either Distribution or Reseller will do.
          *
          * @param request QuotaListExportPagedRequest
          * @return QuotaListExportPagedResponse
         */
        public async Task<QuotaListExportPagedResponse> QuotaListExportPagedAsync(QuotaListExportPagedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuotaListExportPagedWithOptionsAsync(request, runtime);
        }

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

        public ResendEmailResponse ResendEmail(ResendEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendEmailWithOptions(request, runtime);
        }

        public async Task<ResendEmailResponse> ResendEmailAsync(ResendEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendEmailWithOptionsAsync(request, runtime);
        }

        public SetAccountInfoResponse SetAccountInfoWithOptions(SetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNickname))
            {
                query["AccountNickname"] = request.AccountNickname;
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

        public async Task<SetAccountInfoResponse> SetAccountInfoWithOptionsAsync(SetAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNickname))
            {
                query["AccountNickname"] = request.AccountNickname;
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

        public SetAccountInfoResponse SetAccountInfo(SetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccountInfoWithOptions(request, runtime);
        }

        public async Task<SetAccountInfoResponse> SetAccountInfoAsync(SetAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccountInfoWithOptionsAsync(request, runtime);
        }

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

        public SetCreditLineResponse SetCreditLine(SetCreditLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCreditLineWithOptions(request, runtime);
        }

        public async Task<SetCreditLineResponse> SetCreditLineAsync(SetCreditLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCreditLineWithOptionsAsync(request, runtime);
        }

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

        public SetWarningThresholdResponse SetWarningThreshold(SetWarningThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWarningThresholdWithOptions(request, runtime);
        }

        public async Task<SetWarningThresholdResponse> SetWarningThresholdAsync(SetWarningThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWarningThresholdWithOptionsAsync(request, runtime);
        }

        /**
          * *   Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
          * *   You can call this operation to subscribe to only one type of bill at a time.
          * *   After the subscription to a type of bill is generated, the bill for the previous day is pushed on a daily basis from the next day. On the fifth day of each month, the full-data bill for the previous month is pushed.
          * *   A daily bill may be delayed. The delayed bill is pushed the next day after it is generated. The delayed bill may contain the bill data that is delayed until the previous day. We recommend that you query the full-data bill for the previous month at the beginning of each month.
          * *   Your account must be granted the [AliyunConsumeDump2OSSRole](https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D) permission.
          * *   The following file name formats are supported for bills:
          * ```
          * BillingItemDetailForBillingPeriod
          *   
          * File name format of a daily bill: UID_PartnerBillingItemDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_BillingItemDetail_20190310_0001_01. 
          *   
          * File name format of a monthly full-data bill: UID_PartnerBillingItemDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetail_201903_0001_01. 
          * InstanceDetailForBillingPeriod
          *  
          *  File name format of a daily bill: UID_PartnerInstanceDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_InstanceDetail_20190310_0001_01. 
          *   
          * File name format of a monthly full-data bill: UID_PartnerInstanceDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetail_201903_1999-0001_01. 
          * BillingItemDetailMonthly
          *   
          * File name format of a daily bill: UID_PartnerBillingItemDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
          * InstanceDetailMonthly
          *   
          * File name format of a daily bill: UID_PartnerInstanceDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
          * The fileNo field exists only when the number of bill rows reaches the maximum rows in a single bill file and the bill is split into multiple files.
          * ```
          * **This topic is published only on the international site (alibabacloud.com).
          *
          * @param request SubscriptionBillRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubscriptionBillResponse
         */
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

        /**
          * *   Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
          * *   You can call this operation to subscribe to only one type of bill at a time.
          * *   After the subscription to a type of bill is generated, the bill for the previous day is pushed on a daily basis from the next day. On the fifth day of each month, the full-data bill for the previous month is pushed.
          * *   A daily bill may be delayed. The delayed bill is pushed the next day after it is generated. The delayed bill may contain the bill data that is delayed until the previous day. We recommend that you query the full-data bill for the previous month at the beginning of each month.
          * *   Your account must be granted the [AliyunConsumeDump2OSSRole](https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D) permission.
          * *   The following file name formats are supported for bills:
          * ```
          * BillingItemDetailForBillingPeriod
          *   
          * File name format of a daily bill: UID_PartnerBillingItemDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_BillingItemDetail_20190310_0001_01. 
          *   
          * File name format of a monthly full-data bill: UID_PartnerBillingItemDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetail_201903_0001_01. 
          * InstanceDetailForBillingPeriod
          *  
          *  File name format of a daily bill: UID_PartnerInstanceDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_InstanceDetail_20190310_0001_01. 
          *   
          * File name format of a monthly full-data bill: UID_PartnerInstanceDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetail_201903_1999-0001_01. 
          * BillingItemDetailMonthly
          *   
          * File name format of a daily bill: UID_PartnerBillingItemDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
          * InstanceDetailMonthly
          *   
          * File name format of a daily bill: UID_PartnerInstanceDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
          * The fileNo field exists only when the number of bill rows reaches the maximum rows in a single bill file and the bill is split into multiple files.
          * ```
          * **This topic is published only on the international site (alibabacloud.com).
          *
          * @param request SubscriptionBillRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubscriptionBillResponse
         */
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

        /**
          * *   Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
          * *   You can call this operation to subscribe to only one type of bill at a time.
          * *   After the subscription to a type of bill is generated, the bill for the previous day is pushed on a daily basis from the next day. On the fifth day of each month, the full-data bill for the previous month is pushed.
          * *   A daily bill may be delayed. The delayed bill is pushed the next day after it is generated. The delayed bill may contain the bill data that is delayed until the previous day. We recommend that you query the full-data bill for the previous month at the beginning of each month.
          * *   Your account must be granted the [AliyunConsumeDump2OSSRole](https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D) permission.
          * *   The following file name formats are supported for bills:
          * ```
          * BillingItemDetailForBillingPeriod
          *   
          * File name format of a daily bill: UID_PartnerBillingItemDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_BillingItemDetail_20190310_0001_01. 
          *   
          * File name format of a monthly full-data bill: UID_PartnerBillingItemDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetail_201903_0001_01. 
          * InstanceDetailForBillingPeriod
          *  
          *  File name format of a daily bill: UID_PartnerInstanceDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_InstanceDetail_20190310_0001_01. 
          *   
          * File name format of a monthly full-data bill: UID_PartnerInstanceDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetail_201903_1999-0001_01. 
          * BillingItemDetailMonthly
          *   
          * File name format of a daily bill: UID_PartnerBillingItemDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
          * InstanceDetailMonthly
          *   
          * File name format of a daily bill: UID_PartnerInstanceDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
          * The fileNo field exists only when the number of bill rows reaches the maximum rows in a single bill file and the bill is split into multiple files.
          * ```
          * **This topic is published only on the international site (alibabacloud.com).
          *
          * @param request SubscriptionBillRequest
          * @return SubscriptionBillResponse
         */
        public SubscriptionBillResponse SubscriptionBill(SubscriptionBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscriptionBillWithOptions(request, runtime);
        }

        /**
          * *   Make sure that you are a distributor of the Alibaba Cloud international ecosystem.
          * *   You can call this operation to subscribe to only one type of bill at a time.
          * *   After the subscription to a type of bill is generated, the bill for the previous day is pushed on a daily basis from the next day. On the fifth day of each month, the full-data bill for the previous month is pushed.
          * *   A daily bill may be delayed. The delayed bill is pushed the next day after it is generated. The delayed bill may contain the bill data that is delayed until the previous day. We recommend that you query the full-data bill for the previous month at the beginning of each month.
          * *   Your account must be granted the [AliyunConsumeDump2OSSRole](https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D) permission.
          * *   The following file name formats are supported for bills:
          * ```
          * BillingItemDetailForBillingPeriod
          *   
          * File name format of a daily bill: UID_PartnerBillingItemDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_BillingItemDetail_20190310_0001_01. 
          *   
          * File name format of a monthly full-data bill: UID_PartnerBillingItemDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetail_201903_0001_01. 
          * InstanceDetailForBillingPeriod
          *  
          *  File name format of a daily bill: UID_PartnerInstanceDetail_YYYYMMDD_SquenceNo_fileNo. Example: 169**_InstanceDetail_20190310_0001_01. 
          *   
          * File name format of a monthly full-data bill: UID_PartnerInstanceDetail_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetail_201903_1999-0001_01. 
          * BillingItemDetailMonthly
          *   
          * File name format of a daily bill: UID_PartnerBillingItemDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_BillingItemDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
          * InstanceDetailMonthly
          *   
          * File name format of a daily bill: UID_PartnerInstanceDetailMonthly_YYYYMM_SquenceNo_fileNo. Example: 169**_InstanceDetailMonthly_201903_0001_01. This bill contains the bill data that is generated from the beginning of the current month to the fifth day of the next month. 
          * The fileNo field exists only when the number of bill rows reaches the maximum rows in a single bill file and the bill is split into multiple files.
          * ```
          * **This topic is published only on the international site (alibabacloud.com).
          *
          * @param request SubscriptionBillRequest
          * @return SubscriptionBillResponse
         */
        public async Task<SubscriptionBillResponse> SubscriptionBillAsync(SubscriptionBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscriptionBillWithOptionsAsync(request, runtime);
        }

    }
}
