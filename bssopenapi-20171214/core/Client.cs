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
                {"cn-hangzhou", "business.aliyuncs.com"},
                {"cn-shanghai", "business.aliyuncs.com"},
                {"ap-southeast-1", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-1", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2-pop", "business.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "business.ap-southeast-1.aliyuncs.com"},
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
                {"cn-huhehaote-nebula-1", "business.aliyuncs.com"},
                {"cn-north-2-gov-1", "business.aliyuncs.com"},
                {"cn-qingdao", "business.aliyuncs.com"},
                {"cn-qingdao-nebula", "business.aliyuncs.com"},
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
                {"cn-wulanchabu", "business.aliyuncs.com"},
                {"cn-yushanfang", "business.aliyuncs.com"},
                {"cn-zhangbei", "business.aliyuncs.com"},
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

        /**
         * @summary Creates a financial relationship.
         *
         * @description For more information about a financial relationship, see [Financial relationships](https://help.aliyun.com/document_detail/100376.html?spm=a2c4g.11186623.6.563.52a83908ypl4yE) or [Financial relationships](https://www.alibabacloud.com/help/en/doc-detail/116383.html). 
         * If enterprise names used by the management account and a member for real-name verification are the same, you do not need to call an API operation for confirmation. Otherwise, you must call the ConfirmRelation operation for confirmation.
         *
         * @param request AddAccountRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAccountRelationResponse
         */
        public AddAccountRelationResponse AddAccountRelationWithOptions(AddAccountRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildNick))
            {
                query["ChildNick"] = request.ChildNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildUserId))
            {
                query["ChildUserId"] = request.ChildUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserId))
            {
                query["ParentUserId"] = request.ParentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionCodes))
            {
                query["PermissionCodes"] = request.PermissionCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodes))
            {
                query["RoleCodes"] = request.RoleCodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAccountRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAccountRelationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a financial relationship.
         *
         * @description For more information about a financial relationship, see [Financial relationships](https://help.aliyun.com/document_detail/100376.html?spm=a2c4g.11186623.6.563.52a83908ypl4yE) or [Financial relationships](https://www.alibabacloud.com/help/en/doc-detail/116383.html). 
         * If enterprise names used by the management account and a member for real-name verification are the same, you do not need to call an API operation for confirmation. Otherwise, you must call the ConfirmRelation operation for confirmation.
         *
         * @param request AddAccountRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAccountRelationResponse
         */
        public async Task<AddAccountRelationResponse> AddAccountRelationWithOptionsAsync(AddAccountRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildNick))
            {
                query["ChildNick"] = request.ChildNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildUserId))
            {
                query["ChildUserId"] = request.ChildUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserId))
            {
                query["ParentUserId"] = request.ParentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionCodes))
            {
                query["PermissionCodes"] = request.PermissionCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodes))
            {
                query["RoleCodes"] = request.RoleCodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAccountRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAccountRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a financial relationship.
         *
         * @description For more information about a financial relationship, see [Financial relationships](https://help.aliyun.com/document_detail/100376.html?spm=a2c4g.11186623.6.563.52a83908ypl4yE) or [Financial relationships](https://www.alibabacloud.com/help/en/doc-detail/116383.html). 
         * If enterprise names used by the management account and a member for real-name verification are the same, you do not need to call an API operation for confirmation. Otherwise, you must call the ConfirmRelation operation for confirmation.
         *
         * @param request AddAccountRelationRequest
         * @return AddAccountRelationResponse
         */
        public AddAccountRelationResponse AddAccountRelation(AddAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAccountRelationWithOptions(request, runtime);
        }

        /**
         * @summary Creates a financial relationship.
         *
         * @description For more information about a financial relationship, see [Financial relationships](https://help.aliyun.com/document_detail/100376.html?spm=a2c4g.11186623.6.563.52a83908ypl4yE) or [Financial relationships](https://www.alibabacloud.com/help/en/doc-detail/116383.html). 
         * If enterprise names used by the management account and a member for real-name verification are the same, you do not need to call an API operation for confirmation. Otherwise, you must call the ConfirmRelation operation for confirmation.
         *
         * @param request AddAccountRelationRequest
         * @return AddAccountRelationResponse
         */
        public async Task<AddAccountRelationResponse> AddAccountRelationAsync(AddAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAccountRelationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Transfers resource instances from the source cost center to the destination cost center.
         *
         * @param request AllocateCostUnitResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocateCostUnitResourceResponse
         */
        public AllocateCostUnitResourceResponse AllocateCostUnitResourceWithOptions(AllocateCostUnitResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromUnitId))
            {
                query["FromUnitId"] = request.FromUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromUnitUserId))
            {
                query["FromUnitUserId"] = request.FromUnitUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceList))
            {
                query["ResourceInstanceList"] = request.ResourceInstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToUnitId))
            {
                query["ToUnitId"] = request.ToUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToUnitUserId))
            {
                query["ToUnitUserId"] = request.ToUnitUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocateCostUnitResource",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateCostUnitResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Transfers resource instances from the source cost center to the destination cost center.
         *
         * @param request AllocateCostUnitResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocateCostUnitResourceResponse
         */
        public async Task<AllocateCostUnitResourceResponse> AllocateCostUnitResourceWithOptionsAsync(AllocateCostUnitResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromUnitId))
            {
                query["FromUnitId"] = request.FromUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromUnitUserId))
            {
                query["FromUnitUserId"] = request.FromUnitUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceList))
            {
                query["ResourceInstanceList"] = request.ResourceInstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToUnitId))
            {
                query["ToUnitId"] = request.ToUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToUnitUserId))
            {
                query["ToUnitUserId"] = request.ToUnitUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocateCostUnitResource",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateCostUnitResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Transfers resource instances from the source cost center to the destination cost center.
         *
         * @param request AllocateCostUnitResourceRequest
         * @return AllocateCostUnitResourceResponse
         */
        public AllocateCostUnitResourceResponse AllocateCostUnitResource(AllocateCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateCostUnitResourceWithOptions(request, runtime);
        }

        /**
         * @summary Transfers resource instances from the source cost center to the destination cost center.
         *
         * @param request AllocateCostUnitResourceRequest
         * @return AllocateCostUnitResourceResponse
         */
        public async Task<AllocateCostUnitResourceResponse> AllocateCostUnitResourceAsync(AllocateCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateCostUnitResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits an application for an invoice.
         *
         * @param request ApplyInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyInvoiceResponse
         */
        public ApplyInvoiceResponse ApplyInvoiceWithOptions(ApplyInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressId))
            {
                query["AddressId"] = request.AddressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyUserNick))
            {
                query["ApplyUserNick"] = request.ApplyUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceAmount))
            {
                query["InvoiceAmount"] = request.InvoiceAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceByAmount))
            {
                query["InvoiceByAmount"] = request.InvoiceByAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoicingType))
            {
                query["InvoicingType"] = request.InvoicingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessWay))
            {
                query["ProcessWay"] = request.ProcessWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedIds))
            {
                query["SelectedIds"] = request.SelectedIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserRemark))
            {
                query["UserRemark"] = request.UserRemark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyInvoice",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyInvoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits an application for an invoice.
         *
         * @param request ApplyInvoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyInvoiceResponse
         */
        public async Task<ApplyInvoiceResponse> ApplyInvoiceWithOptionsAsync(ApplyInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressId))
            {
                query["AddressId"] = request.AddressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyUserNick))
            {
                query["ApplyUserNick"] = request.ApplyUserNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                query["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceAmount))
            {
                query["InvoiceAmount"] = request.InvoiceAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceByAmount))
            {
                query["InvoiceByAmount"] = request.InvoiceByAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoicingType))
            {
                query["InvoicingType"] = request.InvoicingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessWay))
            {
                query["ProcessWay"] = request.ProcessWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedIds))
            {
                query["SelectedIds"] = request.SelectedIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserRemark))
            {
                query["UserRemark"] = request.UserRemark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyInvoice",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits an application for an invoice.
         *
         * @param request ApplyInvoiceRequest
         * @return ApplyInvoiceResponse
         */
        public ApplyInvoiceResponse ApplyInvoice(ApplyInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyInvoiceWithOptions(request, runtime);
        }

        /**
         * @summary Submits an application for an invoice.
         *
         * @param request ApplyInvoiceRequest
         * @return ApplyInvoiceResponse
         */
        public async Task<ApplyInvoiceResponse> ApplyInvoiceAsync(ApplyInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyInvoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels an unpaid order.
         *
         * @param request CancelOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOrderResponse
         */
        public CancelOrderResponse CancelOrderWithOptions(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrder",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels an unpaid order.
         *
         * @param request CancelOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOrderResponse
         */
        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrder",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels an unpaid order.
         *
         * @param request CancelOrderRequest
         * @return CancelOrderResponse
         */
        public CancelOrderResponse CancelOrder(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOrderWithOptions(request, runtime);
        }

        /**
         * @summary Cancels an unpaid order.
         *
         * @param request CancelOrderRequest
         * @return CancelOrderResponse
         */
        public async Task<CancelOrderResponse> CancelOrderAsync(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ChangeResellerConsumeAmountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResellerConsumeAmountResponse
         */
        public ChangeResellerConsumeAmountResponse ChangeResellerConsumeAmountWithOptions(ChangeResellerConsumeAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustType))
            {
                query["AdjustType"] = request.AdjustType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendMap))
            {
                query["ExtendMap"] = request.ExtendMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ChangeResellerConsumeAmount",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResellerConsumeAmountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ChangeResellerConsumeAmountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResellerConsumeAmountResponse
         */
        public async Task<ChangeResellerConsumeAmountResponse> ChangeResellerConsumeAmountWithOptionsAsync(ChangeResellerConsumeAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdjustType))
            {
                query["AdjustType"] = request.AdjustType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendMap))
            {
                query["ExtendMap"] = request.ExtendMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "ChangeResellerConsumeAmount",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResellerConsumeAmountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ChangeResellerConsumeAmountRequest
         * @return ChangeResellerConsumeAmountResponse
         */
        public ChangeResellerConsumeAmountResponse ChangeResellerConsumeAmount(ChangeResellerConsumeAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResellerConsumeAmountWithOptions(request, runtime);
        }

        /**
         * @param request ChangeResellerConsumeAmountRequest
         * @return ChangeResellerConsumeAmountResponse
         */
        public async Task<ChangeResellerConsumeAmountResponse> ChangeResellerConsumeAmountAsync(ChangeResellerConsumeAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResellerConsumeAmountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Confirms the invitation initiated by the master account.
         *
         * @description 1\\. A member needs to confirm an invitation only if a financial management relationship is established between the management account and the member and enterprise names used by the management account and the member for real-name verification are different. 2. The permissions to be confirmed must be the same as those granted to the member when the management account initiates the invitation.
         *
         * @param request ConfirmRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmRelationResponse
         */
        public ConfirmRelationResponse ConfirmRelationWithOptions(ConfirmRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildUserId))
            {
                query["ChildUserId"] = request.ChildUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfirmCode))
            {
                query["ConfirmCode"] = request.ConfirmCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserId))
            {
                query["ParentUserId"] = request.ParentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionCodes))
            {
                query["PermissionCodes"] = request.PermissionCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["RelationId"] = request.RelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmRelationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Confirms the invitation initiated by the master account.
         *
         * @description 1\\. A member needs to confirm an invitation only if a financial management relationship is established between the management account and the member and enterprise names used by the management account and the member for real-name verification are different. 2. The permissions to be confirmed must be the same as those granted to the member when the management account initiates the invitation.
         *
         * @param request ConfirmRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmRelationResponse
         */
        public async Task<ConfirmRelationResponse> ConfirmRelationWithOptionsAsync(ConfirmRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildUserId))
            {
                query["ChildUserId"] = request.ChildUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfirmCode))
            {
                query["ConfirmCode"] = request.ConfirmCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserId))
            {
                query["ParentUserId"] = request.ParentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionCodes))
            {
                query["PermissionCodes"] = request.PermissionCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["RelationId"] = request.RelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Confirms the invitation initiated by the master account.
         *
         * @description 1\\. A member needs to confirm an invitation only if a financial management relationship is established between the management account and the member and enterprise names used by the management account and the member for real-name verification are different. 2. The permissions to be confirmed must be the same as those granted to the member when the management account initiates the invitation.
         *
         * @param request ConfirmRelationRequest
         * @return ConfirmRelationResponse
         */
        public ConfirmRelationResponse ConfirmRelation(ConfirmRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmRelationWithOptions(request, runtime);
        }

        /**
         * @summary Confirms the invitation initiated by the master account.
         *
         * @description 1\\. A member needs to confirm an invitation only if a financial management relationship is established between the management account and the member and enterprise names used by the management account and the member for real-name verification are different. 2. The permissions to be confirmed must be the same as those granted to the member when the management account initiates the invitation.
         *
         * @param request ConfirmRelationRequest
         * @return ConfirmRelationResponse
         */
        public async Task<ConfirmRelationResponse> ConfirmRelationAsync(ConfirmRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmRelationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the billing method of an instance. You can call this operation to switch the billing method from pay-as-you-go to subscription for Server Load Balancer (SLB) instances, elastic IP addresses (EIPs), and NAT gateways, and switch the billing method from subscription to pay-as-you-go for SLB instances and EIPs.
         *
         * @param request ConvertChargeTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConvertChargeTypeResponse
         */
        public ConvertChargeTypeResponse ConvertChargeTypeWithOptions(ConvertChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertChargeType",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertChargeTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the billing method of an instance. You can call this operation to switch the billing method from pay-as-you-go to subscription for Server Load Balancer (SLB) instances, elastic IP addresses (EIPs), and NAT gateways, and switch the billing method from subscription to pay-as-you-go for SLB instances and EIPs.
         *
         * @param request ConvertChargeTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConvertChargeTypeResponse
         */
        public async Task<ConvertChargeTypeResponse> ConvertChargeTypeWithOptionsAsync(ConvertChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertChargeType",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertChargeTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the billing method of an instance. You can call this operation to switch the billing method from pay-as-you-go to subscription for Server Load Balancer (SLB) instances, elastic IP addresses (EIPs), and NAT gateways, and switch the billing method from subscription to pay-as-you-go for SLB instances and EIPs.
         *
         * @param request ConvertChargeTypeRequest
         * @return ConvertChargeTypeResponse
         */
        public ConvertChargeTypeResponse ConvertChargeType(ConvertChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertChargeTypeWithOptions(request, runtime);
        }

        /**
         * @summary Changes the billing method of an instance. You can call this operation to switch the billing method from pay-as-you-go to subscription for Server Load Balancer (SLB) instances, elastic IP addresses (EIPs), and NAT gateways, and switch the billing method from subscription to pay-as-you-go for SLB instances and EIPs.
         *
         * @param request ConvertChargeTypeRequest
         * @return ConvertChargeTypeResponse
         */
        public async Task<ConvertChargeTypeResponse> ConvertChargeTypeAsync(ConvertChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertChargeTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an account to establish a financial relationship.
         *
         * @description You can call this operation to create an account so as to establish a master-member financial relationship.
         *
         * @param request CreateAgAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAgAccountResponse
         */
        public CreateAgAccountResponse CreateAgAccountWithOptions(CreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountAttr))
            {
                query["AccountAttr"] = request.AccountAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityName))
            {
                query["CityName"] = request.CityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseName))
            {
                query["EnterpriseName"] = request.EnterpriseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstName))
            {
                query["FirstName"] = request.FirstName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastName))
            {
                query["LastName"] = request.LastName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NationCode))
            {
                query["NationCode"] = request.NationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Postcode))
            {
                query["Postcode"] = request.Postcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceName))
            {
                query["ProvinceName"] = request.ProvinceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgAccount",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an account to establish a financial relationship.
         *
         * @description You can call this operation to create an account so as to establish a master-member financial relationship.
         *
         * @param request CreateAgAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAgAccountResponse
         */
        public async Task<CreateAgAccountResponse> CreateAgAccountWithOptionsAsync(CreateAgAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountAttr))
            {
                query["AccountAttr"] = request.AccountAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityName))
            {
                query["CityName"] = request.CityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseName))
            {
                query["EnterpriseName"] = request.EnterpriseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstName))
            {
                query["FirstName"] = request.FirstName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastName))
            {
                query["LastName"] = request.LastName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginEmail))
            {
                query["LoginEmail"] = request.LoginEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NationCode))
            {
                query["NationCode"] = request.NationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Postcode))
            {
                query["Postcode"] = request.Postcode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvinceName))
            {
                query["ProvinceName"] = request.ProvinceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgAccount",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an account to establish a financial relationship.
         *
         * @description You can call this operation to create an account so as to establish a master-member financial relationship.
         *
         * @param request CreateAgAccountRequest
         * @return CreateAgAccountResponse
         */
        public CreateAgAccountResponse CreateAgAccount(CreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgAccountWithOptions(request, runtime);
        }

        /**
         * @summary Creates an account to establish a financial relationship.
         *
         * @description You can call this operation to create an account so as to establish a master-member financial relationship.
         *
         * @param request CreateAgAccountRequest
         * @return CreateAgAccountResponse
         */
        public async Task<CreateAgAccountResponse> CreateAgAccountAsync(CreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a cost center. You can create multiple cost centers at a time.
         *
         * @param request CreateCostUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCostUnitResponse
         */
        public CreateCostUnitResponse CreateCostUnitWithOptions(CreateCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitEntityList))
            {
                query["UnitEntityList"] = request.UnitEntityList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCostUnit",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCostUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a cost center. You can create multiple cost centers at a time.
         *
         * @param request CreateCostUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCostUnitResponse
         */
        public async Task<CreateCostUnitResponse> CreateCostUnitWithOptionsAsync(CreateCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitEntityList))
            {
                query["UnitEntityList"] = request.UnitEntityList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCostUnit",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCostUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a cost center. You can create multiple cost centers at a time.
         *
         * @param request CreateCostUnitRequest
         * @return CreateCostUnitResponse
         */
        public CreateCostUnitResponse CreateCostUnit(CreateCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCostUnitWithOptions(request, runtime);
        }

        /**
         * @summary Creates a cost center. You can create multiple cost centers at a time.
         *
         * @param request CreateCostUnitRequest
         * @return CreateCostUnitResponse
         */
        public async Task<CreateCostUnitResponse> CreateCostUnitAsync(CreateCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCostUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an instance. If you call this operation, an order for a new instance is created and the order is automatically paid for. You cannot create Elastic Compute Service (ECS) instances or ApsaraDB RDS instances by calling the operation.
         *
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logistics))
            {
                query["Logistics"] = request.Logistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["Parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewPeriod))
            {
                query["RenewPeriod"] = request.RenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalStatus))
            {
                query["RenewalStatus"] = request.RenewalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an instance. If you call this operation, an order for a new instance is created and the order is automatically paid for. You cannot create Elastic Compute Service (ECS) instances or ApsaraDB RDS instances by calling the operation.
         *
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logistics))
            {
                query["Logistics"] = request.Logistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["Parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewPeriod))
            {
                query["RenewPeriod"] = request.RenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalStatus))
            {
                query["RenewalStatus"] = request.RenewalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an instance. If you call this operation, an order for a new instance is created and the order is automatically paid for. You cannot create Elastic Compute Service (ECS) instances or ApsaraDB RDS instances by calling the operation.
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Creates an instance. If you call this operation, an order for a new instance is created and the order is automatically paid for. You cannot create Elastic Compute Service (ECS) instances or ApsaraDB RDS instances by calling the operation.
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
         *
         * @param request CreateResellerUserQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResellerUserQuotaResponse
         */
        public CreateResellerUserQuotaResponse CreateResellerUserQuotaWithOptions(CreateResellerUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResellerUserQuota",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResellerUserQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
         *
         * @param request CreateResellerUserQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResellerUserQuotaResponse
         */
        public async Task<CreateResellerUserQuotaResponse> CreateResellerUserQuotaWithOptionsAsync(CreateResellerUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResellerUserQuota",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResellerUserQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
         *
         * @param request CreateResellerUserQuotaRequest
         * @return CreateResellerUserQuotaResponse
         */
        public CreateResellerUserQuotaResponse CreateResellerUserQuota(CreateResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResellerUserQuotaWithOptions(request, runtime);
        }

        /**
         * @summary Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
         *
         * @param request CreateResellerUserQuotaRequest
         * @return CreateResellerUserQuotaResponse
         */
        public async Task<CreateResellerUserQuotaResponse> CreateResellerUserQuotaAsync(CreateResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResellerUserQuotaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a resource plan.
         *
         * @param request CreateResourcePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourcePackageResponse
         */
        public CreateResourcePackageResponse CreateResourcePackageWithOptions(CreateResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourcePackage",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourcePackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a resource plan.
         *
         * @param request CreateResourcePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourcePackageResponse
         */
        public async Task<CreateResourcePackageResponse> CreateResourcePackageWithOptionsAsync(CreateResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourcePackage",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourcePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a resource plan.
         *
         * @param request CreateResourcePackageRequest
         * @return CreateResourcePackageResponse
         */
        public CreateResourcePackageResponse CreateResourcePackage(CreateResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourcePackageWithOptions(request, runtime);
        }

        /**
         * @summary Creates a resource plan.
         *
         * @param request CreateResourcePackageRequest
         * @return CreateResourcePackageResponse
         */
        public async Task<CreateResourcePackageResponse> CreateResourcePackageAsync(CreateResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourcePackageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a savings plan. After you call this operation, a savings plan is purchased and paid for.
         *
         * @param tmpReq CreateSavingsPlansInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSavingsPlansInstanceResponse
         */
        public CreateSavingsPlansInstanceResponse CreateSavingsPlansInstanceWithOptions(CreateSavingsPlansInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSavingsPlansInstanceShrinkRequest request = new CreateSavingsPlansInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendMap))
            {
                request.ExtendMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendMap, "ExtendMap", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendMapShrink))
            {
                query["ExtendMap"] = request.ExtendMapShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayMode))
            {
                query["PayMode"] = request.PayMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolValue))
            {
                query["PoolValue"] = request.PoolValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavingsPlansInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSavingsPlansInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a savings plan. After you call this operation, a savings plan is purchased and paid for.
         *
         * @param tmpReq CreateSavingsPlansInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSavingsPlansInstanceResponse
         */
        public async Task<CreateSavingsPlansInstanceResponse> CreateSavingsPlansInstanceWithOptionsAsync(CreateSavingsPlansInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSavingsPlansInstanceShrinkRequest request = new CreateSavingsPlansInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendMap))
            {
                request.ExtendMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendMap, "ExtendMap", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendMapShrink))
            {
                query["ExtendMap"] = request.ExtendMapShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayMode))
            {
                query["PayMode"] = request.PayMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolValue))
            {
                query["PoolValue"] = request.PoolValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavingsPlansInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSavingsPlansInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a savings plan. After you call this operation, a savings plan is purchased and paid for.
         *
         * @param request CreateSavingsPlansInstanceRequest
         * @return CreateSavingsPlansInstanceResponse
         */
        public CreateSavingsPlansInstanceResponse CreateSavingsPlansInstance(CreateSavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSavingsPlansInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Creates a savings plan. After you call this operation, a savings plan is purchased and paid for.
         *
         * @param request CreateSavingsPlansInstanceRequest
         * @return CreateSavingsPlansInstanceResponse
         */
        public async Task<CreateSavingsPlansInstanceResponse> CreateSavingsPlansInstanceAsync(CreateSavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSavingsPlansInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a cost center.
         *
         * @param request DeleteCostUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCostUnitResponse
         */
        public DeleteCostUnitResponse DeleteCostUnitWithOptions(DeleteCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitId))
            {
                query["UnitId"] = request.UnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCostUnit",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCostUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a cost center.
         *
         * @param request DeleteCostUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCostUnitResponse
         */
        public async Task<DeleteCostUnitResponse> DeleteCostUnitWithOptionsAsync(DeleteCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitId))
            {
                query["UnitId"] = request.UnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCostUnit",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCostUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a cost center.
         *
         * @param request DeleteCostUnitRequest
         * @return DeleteCostUnitResponse
         */
        public DeleteCostUnitResponse DeleteCostUnit(DeleteCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCostUnitWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a cost center.
         *
         * @param request DeleteCostUnitRequest
         * @return DeleteCostUnitResponse
         */
        public async Task<DeleteCostUnitResponse> DeleteCostUnitAsync(DeleteCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCostUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Query the summary information of the user "Cost Management-Budget".
         *
         * @description This operation is in beta testing and is only available for specific users in the whitelist. Excessive calls may result in performance issues. For example, the response times out.
         *
         * @param request DescribeCostBudgetsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCostBudgetsSummaryResponse
         */
        public DescribeCostBudgetsSummaryResponse DescribeCostBudgetsSummaryWithOptions(DescribeCostBudgetsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetName))
            {
                query["BudgetName"] = request.BudgetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetStatus))
            {
                query["BudgetStatus"] = request.BudgetStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetType))
            {
                query["BudgetType"] = request.BudgetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostBudgetsSummary",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCostBudgetsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Query the summary information of the user "Cost Management-Budget".
         *
         * @description This operation is in beta testing and is only available for specific users in the whitelist. Excessive calls may result in performance issues. For example, the response times out.
         *
         * @param request DescribeCostBudgetsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCostBudgetsSummaryResponse
         */
        public async Task<DescribeCostBudgetsSummaryResponse> DescribeCostBudgetsSummaryWithOptionsAsync(DescribeCostBudgetsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetName))
            {
                query["BudgetName"] = request.BudgetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetStatus))
            {
                query["BudgetStatus"] = request.BudgetStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetType))
            {
                query["BudgetType"] = request.BudgetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostBudgetsSummary",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCostBudgetsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Query the summary information of the user "Cost Management-Budget".
         *
         * @description This operation is in beta testing and is only available for specific users in the whitelist. Excessive calls may result in performance issues. For example, the response times out.
         *
         * @param request DescribeCostBudgetsSummaryRequest
         * @return DescribeCostBudgetsSummaryResponse
         */
        public DescribeCostBudgetsSummaryResponse DescribeCostBudgetsSummary(DescribeCostBudgetsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCostBudgetsSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Query the summary information of the user "Cost Management-Budget".
         *
         * @description This operation is in beta testing and is only available for specific users in the whitelist. Excessive calls may result in performance issues. For example, the response times out.
         *
         * @param request DescribeCostBudgetsSummaryRequest
         * @return DescribeCostBudgetsSummaryResponse
         */
        public async Task<DescribeCostBudgetsSummaryResponse> DescribeCostBudgetsSummaryAsync(DescribeCostBudgetsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCostBudgetsSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the monthly allocated costs of instances by allocation month.
         *
         * @description You can view and export the allocated costs of the current month after 10:00 on the fourth day of the next month. The allocated costs of a single allocation month may involve orders or bills in different billing cycles. If a historical allocated amount is incorrect, the historical allocated costs need to be adjusted. As a result, the allocated costs displayed for a single allocation month may be different at different time points.
         *
         * @param request DescribeInstanceAmortizedCostByAmortizationPeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceAmortizedCostByAmortizationPeriodResponse
         */
        public DescribeInstanceAmortizedCostByAmortizationPeriodResponse DescribeInstanceAmortizedCostByAmortizationPeriodWithOptions(DescribeInstanceAmortizedCostByAmortizationPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumePeriodFilter))
            {
                body["ConsumePeriodFilter"] = request.ConsumePeriodFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAmortizedCostByAmortizationPeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAmortizedCostByAmortizationPeriodResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the monthly allocated costs of instances by allocation month.
         *
         * @description You can view and export the allocated costs of the current month after 10:00 on the fourth day of the next month. The allocated costs of a single allocation month may involve orders or bills in different billing cycles. If a historical allocated amount is incorrect, the historical allocated costs need to be adjusted. As a result, the allocated costs displayed for a single allocation month may be different at different time points.
         *
         * @param request DescribeInstanceAmortizedCostByAmortizationPeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceAmortizedCostByAmortizationPeriodResponse
         */
        public async Task<DescribeInstanceAmortizedCostByAmortizationPeriodResponse> DescribeInstanceAmortizedCostByAmortizationPeriodWithOptionsAsync(DescribeInstanceAmortizedCostByAmortizationPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumePeriodFilter))
            {
                body["ConsumePeriodFilter"] = request.ConsumePeriodFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAmortizedCostByAmortizationPeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAmortizedCostByAmortizationPeriodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the monthly allocated costs of instances by allocation month.
         *
         * @description You can view and export the allocated costs of the current month after 10:00 on the fourth day of the next month. The allocated costs of a single allocation month may involve orders or bills in different billing cycles. If a historical allocated amount is incorrect, the historical allocated costs need to be adjusted. As a result, the allocated costs displayed for a single allocation month may be different at different time points.
         *
         * @param request DescribeInstanceAmortizedCostByAmortizationPeriodRequest
         * @return DescribeInstanceAmortizedCostByAmortizationPeriodResponse
         */
        public DescribeInstanceAmortizedCostByAmortizationPeriodResponse DescribeInstanceAmortizedCostByAmortizationPeriod(DescribeInstanceAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAmortizedCostByAmortizationPeriodWithOptions(request, runtime);
        }

        /**
         * @summary Queries the monthly allocated costs of instances by allocation month.
         *
         * @description You can view and export the allocated costs of the current month after 10:00 on the fourth day of the next month. The allocated costs of a single allocation month may involve orders or bills in different billing cycles. If a historical allocated amount is incorrect, the historical allocated costs need to be adjusted. As a result, the allocated costs displayed for a single allocation month may be different at different time points.
         *
         * @param request DescribeInstanceAmortizedCostByAmortizationPeriodRequest
         * @return DescribeInstanceAmortizedCostByAmortizationPeriodResponse
         */
        public async Task<DescribeInstanceAmortizedCostByAmortizationPeriodResponse> DescribeInstanceAmortizedCostByAmortizationPeriodAsync(DescribeInstanceAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAmortizedCostByAmortizationPeriodWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实例摊销日摊销成本
         *
         * @param request DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse
         */
        public DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse DescribeInstanceAmortizedCostByAmortizationPeriodDateWithOptions(DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmortizationDateEnd))
            {
                body["AmortizationDateEnd"] = request.AmortizationDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmortizationDateStart))
            {
                body["AmortizationDateStart"] = request.AmortizationDateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAmortizedCostByAmortizationPeriodDate",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实例摊销日摊销成本
         *
         * @param request DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse
         */
        public async Task<DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse> DescribeInstanceAmortizedCostByAmortizationPeriodDateWithOptionsAsync(DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmortizationDateEnd))
            {
                body["AmortizationDateEnd"] = request.AmortizationDateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmortizationDateStart))
            {
                body["AmortizationDateStart"] = request.AmortizationDateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAmortizedCostByAmortizationPeriodDate",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实例摊销日摊销成本
         *
         * @param request DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest
         * @return DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse
         */
        public DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse DescribeInstanceAmortizedCostByAmortizationPeriodDate(DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAmortizedCostByAmortizationPeriodDateWithOptions(request, runtime);
        }

        /**
         * @summary 实例摊销日摊销成本
         *
         * @param request DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest
         * @return DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse
         */
        public async Task<DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse> DescribeInstanceAmortizedCostByAmortizationPeriodDateAsync(DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAmortizedCostByAmortizationPeriodDateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实例账期月摊销成本
         *
         * @param request DescribeInstanceAmortizedCostByConsumePeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceAmortizedCostByConsumePeriodResponse
         */
        public DescribeInstanceAmortizedCostByConsumePeriodResponse DescribeInstanceAmortizedCostByConsumePeriodWithOptions(DescribeInstanceAmortizedCostByConsumePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmortizationPeriodFilter))
            {
                body["AmortizationPeriodFilter"] = request.AmortizationPeriodFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAmortizedCostByConsumePeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAmortizedCostByConsumePeriodResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实例账期月摊销成本
         *
         * @param request DescribeInstanceAmortizedCostByConsumePeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceAmortizedCostByConsumePeriodResponse
         */
        public async Task<DescribeInstanceAmortizedCostByConsumePeriodResponse> DescribeInstanceAmortizedCostByConsumePeriodWithOptionsAsync(DescribeInstanceAmortizedCostByConsumePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmortizationPeriodFilter))
            {
                body["AmortizationPeriodFilter"] = request.AmortizationPeriodFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAmortizedCostByConsumePeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAmortizedCostByConsumePeriodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实例账期月摊销成本
         *
         * @param request DescribeInstanceAmortizedCostByConsumePeriodRequest
         * @return DescribeInstanceAmortizedCostByConsumePeriodResponse
         */
        public DescribeInstanceAmortizedCostByConsumePeriodResponse DescribeInstanceAmortizedCostByConsumePeriod(DescribeInstanceAmortizedCostByConsumePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAmortizedCostByConsumePeriodWithOptions(request, runtime);
        }

        /**
         * @summary 实例账期月摊销成本
         *
         * @param request DescribeInstanceAmortizedCostByConsumePeriodRequest
         * @return DescribeInstanceAmortizedCostByConsumePeriodResponse
         */
        public async Task<DescribeInstanceAmortizedCostByConsumePeriodResponse> DescribeInstanceAmortizedCostByConsumePeriodAsync(DescribeInstanceAmortizedCostByConsumePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAmortizedCostByConsumePeriodWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the billing information about instances or billable items in a billing cycle.
         *
         * @description *   Instance bills are generated after the total bill is split. In most cases, the instance bills do not include data generated on the last day of the specified billing cycle.
         * *   The instance information may change during the billing cycle. The instance configurations and types in monthly bills are subject to the point in time when you query bills. For more information, see the corresponding bill details.
         * *   You can query data generated after June 2020 for Cloud Communications services. You can query data generated after November 2020 for Alibaba Cloud Domains.
         *
         * @param request DescribeInstanceBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceBillResponse
         */
        public DescribeInstanceBillResponse DescribeInstanceBillWithOptions(DescribeInstanceBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingDate))
            {
                query["BillingDate"] = request.BillingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceID))
            {
                query["InstanceID"] = request.InstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBillingItem))
            {
                query["IsBillingItem"] = request.IsBillingItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipCode))
            {
                query["PipCode"] = request.PipCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceBillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the billing information about instances or billable items in a billing cycle.
         *
         * @description *   Instance bills are generated after the total bill is split. In most cases, the instance bills do not include data generated on the last day of the specified billing cycle.
         * *   The instance information may change during the billing cycle. The instance configurations and types in monthly bills are subject to the point in time when you query bills. For more information, see the corresponding bill details.
         * *   You can query data generated after June 2020 for Cloud Communications services. You can query data generated after November 2020 for Alibaba Cloud Domains.
         *
         * @param request DescribeInstanceBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceBillResponse
         */
        public async Task<DescribeInstanceBillResponse> DescribeInstanceBillWithOptionsAsync(DescribeInstanceBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingDate))
            {
                query["BillingDate"] = request.BillingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceID))
            {
                query["InstanceID"] = request.InstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBillingItem))
            {
                query["IsBillingItem"] = request.IsBillingItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipCode))
            {
                query["PipCode"] = request.PipCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the billing information about instances or billable items in a billing cycle.
         *
         * @description *   Instance bills are generated after the total bill is split. In most cases, the instance bills do not include data generated on the last day of the specified billing cycle.
         * *   The instance information may change during the billing cycle. The instance configurations and types in monthly bills are subject to the point in time when you query bills. For more information, see the corresponding bill details.
         * *   You can query data generated after June 2020 for Cloud Communications services. You can query data generated after November 2020 for Alibaba Cloud Domains.
         *
         * @param request DescribeInstanceBillRequest
         * @return DescribeInstanceBillResponse
         */
        public DescribeInstanceBillResponse DescribeInstanceBill(DescribeInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceBillWithOptions(request, runtime);
        }

        /**
         * @summary Queries the billing information about instances or billable items in a billing cycle.
         *
         * @description *   Instance bills are generated after the total bill is split. In most cases, the instance bills do not include data generated on the last day of the specified billing cycle.
         * *   The instance information may change during the billing cycle. The instance configurations and types in monthly bills are subject to the point in time when you query bills. For more information, see the corresponding bill details.
         * *   You can query data generated after June 2020 for Cloud Communications services. You can query data generated after November 2020 for Alibaba Cloud Domains.
         *
         * @param request DescribeInstanceBillRequest
         * @return DescribeInstanceBillResponse
         */
        public async Task<DescribeInstanceBillResponse> DescribeInstanceBillAsync(DescribeInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceBillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实例摊销日抵扣还原摊销成本
         *
         * @param request DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse
         */
        public DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse DescribeInstanceDeductAmortizedCostByAmortizationPeriodWithOptions(DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDeductAmortizedCostByAmortizationPeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实例摊销日抵扣还原摊销成本
         *
         * @param request DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse
         */
        public async Task<DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse> DescribeInstanceDeductAmortizedCostByAmortizationPeriodWithOptionsAsync(DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDeductAmortizedCostByAmortizationPeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实例摊销日抵扣还原摊销成本
         *
         * @param request DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest
         * @return DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse
         */
        public DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse DescribeInstanceDeductAmortizedCostByAmortizationPeriod(DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDeductAmortizedCostByAmortizationPeriodWithOptions(request, runtime);
        }

        /**
         * @summary 实例摊销日抵扣还原摊销成本
         *
         * @param request DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest
         * @return DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse
         */
        public async Task<DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse> DescribeInstanceDeductAmortizedCostByAmortizationPeriodAsync(DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDeductAmortizedCostByAmortizationPeriodWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the pricing information about an Alibaba Cloud service.
         *
         * @param request DescribePricingModuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePricingModuleResponse
         */
        public DescribePricingModuleResponse DescribePricingModuleWithOptions(DescribePricingModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePricingModule",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePricingModuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the pricing information about an Alibaba Cloud service.
         *
         * @param request DescribePricingModuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePricingModuleResponse
         */
        public async Task<DescribePricingModuleResponse> DescribePricingModuleWithOptionsAsync(DescribePricingModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePricingModule",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePricingModuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the pricing information about an Alibaba Cloud service.
         *
         * @param request DescribePricingModuleRequest
         * @return DescribePricingModuleResponse
         */
        public DescribePricingModuleResponse DescribePricingModule(DescribePricingModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePricingModuleWithOptions(request, runtime);
        }

        /**
         * @summary Queries the pricing information about an Alibaba Cloud service.
         *
         * @param request DescribePricingModuleRequest
         * @return DescribePricingModuleResponse
         */
        public async Task<DescribePricingModuleResponse> DescribePricingModuleAsync(DescribePricingModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePricingModuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the allocated costs of services by allocation month.
         *
         * @description You can view and export the allocated costs of the current month after 10:00 on the fourth day of the next month. The allocated costs of a single allocation month may involve orders or bills in different billing cycles. If a historical allocated amount is incorrect, the historical allocated costs need to be adjusted. As a result, the allocated costs displayed for a single allocation month may be different at different time points.
         *
         * @param request DescribeProductAmortizedCostByAmortizationPeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProductAmortizedCostByAmortizationPeriodResponse
         */
        public DescribeProductAmortizedCostByAmortizationPeriodResponse DescribeProductAmortizedCostByAmortizationPeriodWithOptions(DescribeProductAmortizedCostByAmortizationPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumePeriodFilter))
            {
                body["ConsumePeriodFilter"] = request.ConsumePeriodFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProductAmortizedCostByAmortizationPeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductAmortizedCostByAmortizationPeriodResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the allocated costs of services by allocation month.
         *
         * @description You can view and export the allocated costs of the current month after 10:00 on the fourth day of the next month. The allocated costs of a single allocation month may involve orders or bills in different billing cycles. If a historical allocated amount is incorrect, the historical allocated costs need to be adjusted. As a result, the allocated costs displayed for a single allocation month may be different at different time points.
         *
         * @param request DescribeProductAmortizedCostByAmortizationPeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProductAmortizedCostByAmortizationPeriodResponse
         */
        public async Task<DescribeProductAmortizedCostByAmortizationPeriodResponse> DescribeProductAmortizedCostByAmortizationPeriodWithOptionsAsync(DescribeProductAmortizedCostByAmortizationPeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumePeriodFilter))
            {
                body["ConsumePeriodFilter"] = request.ConsumePeriodFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProductAmortizedCostByAmortizationPeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductAmortizedCostByAmortizationPeriodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the allocated costs of services by allocation month.
         *
         * @description You can view and export the allocated costs of the current month after 10:00 on the fourth day of the next month. The allocated costs of a single allocation month may involve orders or bills in different billing cycles. If a historical allocated amount is incorrect, the historical allocated costs need to be adjusted. As a result, the allocated costs displayed for a single allocation month may be different at different time points.
         *
         * @param request DescribeProductAmortizedCostByAmortizationPeriodRequest
         * @return DescribeProductAmortizedCostByAmortizationPeriodResponse
         */
        public DescribeProductAmortizedCostByAmortizationPeriodResponse DescribeProductAmortizedCostByAmortizationPeriod(DescribeProductAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductAmortizedCostByAmortizationPeriodWithOptions(request, runtime);
        }

        /**
         * @summary Queries the allocated costs of services by allocation month.
         *
         * @description You can view and export the allocated costs of the current month after 10:00 on the fourth day of the next month. The allocated costs of a single allocation month may involve orders or bills in different billing cycles. If a historical allocated amount is incorrect, the historical allocated costs need to be adjusted. As a result, the allocated costs displayed for a single allocation month may be different at different time points.
         *
         * @param request DescribeProductAmortizedCostByAmortizationPeriodRequest
         * @return DescribeProductAmortizedCostByAmortizationPeriodResponse
         */
        public async Task<DescribeProductAmortizedCostByAmortizationPeriodResponse> DescribeProductAmortizedCostByAmortizationPeriodAsync(DescribeProductAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductAmortizedCostByAmortizationPeriodWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 产品账期月摊销成本
         *
         * @param request DescribeProductAmortizedCostByConsumePeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProductAmortizedCostByConsumePeriodResponse
         */
        public DescribeProductAmortizedCostByConsumePeriodResponse DescribeProductAmortizedCostByConsumePeriodWithOptions(DescribeProductAmortizedCostByConsumePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmortizationPeriodFilter))
            {
                body["AmortizationPeriodFilter"] = request.AmortizationPeriodFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProductAmortizedCostByConsumePeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductAmortizedCostByConsumePeriodResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 产品账期月摊销成本
         *
         * @param request DescribeProductAmortizedCostByConsumePeriodRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProductAmortizedCostByConsumePeriodResponse
         */
        public async Task<DescribeProductAmortizedCostByConsumePeriodResponse> DescribeProductAmortizedCostByConsumePeriodWithOptionsAsync(DescribeProductAmortizedCostByConsumePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmortizationPeriodFilter))
            {
                body["AmortizationPeriodFilter"] = request.AmortizationPeriodFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerIdList))
            {
                body["BillOwnerIdList"] = request.BillOwnerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillUserIdList))
            {
                body["BillUserIdList"] = request.BillUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                body["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostUnitCode))
            {
                body["CostUnitCode"] = request.CostUnitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDetail))
            {
                body["ProductDetail"] = request.ProductDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                body["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProductAmortizedCostByConsumePeriod",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductAmortizedCostByConsumePeriodResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 产品账期月摊销成本
         *
         * @param request DescribeProductAmortizedCostByConsumePeriodRequest
         * @return DescribeProductAmortizedCostByConsumePeriodResponse
         */
        public DescribeProductAmortizedCostByConsumePeriodResponse DescribeProductAmortizedCostByConsumePeriod(DescribeProductAmortizedCostByConsumePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductAmortizedCostByConsumePeriodWithOptions(request, runtime);
        }

        /**
         * @summary 产品账期月摊销成本
         *
         * @param request DescribeProductAmortizedCostByConsumePeriodRequest
         * @return DescribeProductAmortizedCostByConsumePeriodResponse
         */
        public async Task<DescribeProductAmortizedCostByConsumePeriodResponse> DescribeProductAmortizedCostByConsumePeriodAsync(DescribeProductAmortizedCostByConsumePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductAmortizedCostByConsumePeriodWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the coverage details of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @description 1\\. The queried coverage details are the same as those displayed in the table on the Coverage tab of the Manage Reserved Instances page in the Billing Management console.
         * 2\\. You can call this operation to query the coverage details of RIs or SCUs.
         * 3\\. You can call this operation to query coverage details at an hourly, daily, or monthly granularity.
         *
         * @param request DescribeResourceCoverageDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceCoverageDetailResponse
         */
        public DescribeResourceCoverageDetailResponse DescribeResourceCoverageDetailWithOptions(DescribeResourceCoverageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceCoverageDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceCoverageDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the coverage details of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @description 1\\. The queried coverage details are the same as those displayed in the table on the Coverage tab of the Manage Reserved Instances page in the Billing Management console.
         * 2\\. You can call this operation to query the coverage details of RIs or SCUs.
         * 3\\. You can call this operation to query coverage details at an hourly, daily, or monthly granularity.
         *
         * @param request DescribeResourceCoverageDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceCoverageDetailResponse
         */
        public async Task<DescribeResourceCoverageDetailResponse> DescribeResourceCoverageDetailWithOptionsAsync(DescribeResourceCoverageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceCoverageDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceCoverageDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the coverage details of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @description 1\\. The queried coverage details are the same as those displayed in the table on the Coverage tab of the Manage Reserved Instances page in the Billing Management console.
         * 2\\. You can call this operation to query the coverage details of RIs or SCUs.
         * 3\\. You can call this operation to query coverage details at an hourly, daily, or monthly granularity.
         *
         * @param request DescribeResourceCoverageDetailRequest
         * @return DescribeResourceCoverageDetailResponse
         */
        public DescribeResourceCoverageDetailResponse DescribeResourceCoverageDetail(DescribeResourceCoverageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceCoverageDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the coverage details of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @description 1\\. The queried coverage details are the same as those displayed in the table on the Coverage tab of the Manage Reserved Instances page in the Billing Management console.
         * 2\\. You can call this operation to query the coverage details of RIs or SCUs.
         * 3\\. You can call this operation to query coverage details at an hourly, daily, or monthly granularity.
         *
         * @param request DescribeResourceCoverageDetailRequest
         * @return DescribeResourceCoverageDetailResponse
         */
        public async Task<DescribeResourceCoverageDetailResponse> DescribeResourceCoverageDetailAsync(DescribeResourceCoverageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceCoverageDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the total coverage data of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @description The queried total coverage data is the same as the aggregated data displayed on the Coverage tab of the Manage Reserved Instances page in the Billing Management console.
         * You can call this operation to query the total coverage data of RIs or SCUs.
         *
         * @param request DescribeResourceCoverageTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceCoverageTotalResponse
         */
        public DescribeResourceCoverageTotalResponse DescribeResourceCoverageTotalWithOptions(DescribeResourceCoverageTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceCoverageTotal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceCoverageTotalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the total coverage data of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @description The queried total coverage data is the same as the aggregated data displayed on the Coverage tab of the Manage Reserved Instances page in the Billing Management console.
         * You can call this operation to query the total coverage data of RIs or SCUs.
         *
         * @param request DescribeResourceCoverageTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceCoverageTotalResponse
         */
        public async Task<DescribeResourceCoverageTotalResponse> DescribeResourceCoverageTotalWithOptionsAsync(DescribeResourceCoverageTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceCoverageTotal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceCoverageTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the total coverage data of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @description The queried total coverage data is the same as the aggregated data displayed on the Coverage tab of the Manage Reserved Instances page in the Billing Management console.
         * You can call this operation to query the total coverage data of RIs or SCUs.
         *
         * @param request DescribeResourceCoverageTotalRequest
         * @return DescribeResourceCoverageTotalResponse
         */
        public DescribeResourceCoverageTotalResponse DescribeResourceCoverageTotal(DescribeResourceCoverageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceCoverageTotalWithOptions(request, runtime);
        }

        /**
         * @summary Queries the total coverage data of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @description The queried total coverage data is the same as the aggregated data displayed on the Coverage tab of the Manage Reserved Instances page in the Billing Management console.
         * You can call this operation to query the total coverage data of RIs or SCUs.
         *
         * @param request DescribeResourceCoverageTotalRequest
         * @return DescribeResourceCoverageTotalResponse
         */
        public async Task<DescribeResourceCoverageTotalResponse> DescribeResourceCoverageTotalAsync(DescribeResourceCoverageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceCoverageTotalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about resource plans of an Alibaba Cloud service.
         *
         * @param request DescribeResourcePackageProductRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourcePackageProductResponse
         */
        public DescribeResourcePackageProductResponse DescribeResourcePackageProductWithOptions(DescribeResourcePackageProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourcePackageProduct",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourcePackageProductResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about resource plans of an Alibaba Cloud service.
         *
         * @param request DescribeResourcePackageProductRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourcePackageProductResponse
         */
        public async Task<DescribeResourcePackageProductResponse> DescribeResourcePackageProductWithOptionsAsync(DescribeResourcePackageProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourcePackageProduct",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourcePackageProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about resource plans of an Alibaba Cloud service.
         *
         * @param request DescribeResourcePackageProductRequest
         * @return DescribeResourcePackageProductResponse
         */
        public DescribeResourcePackageProductResponse DescribeResourcePackageProduct(DescribeResourcePackageProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackageProductWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about resource plans of an Alibaba Cloud service.
         *
         * @param request DescribeResourcePackageProductRequest
         * @return DescribeResourcePackageProductResponse
         */
        public async Task<DescribeResourcePackageProductResponse> DescribeResourcePackageProductAsync(DescribeResourcePackageProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackageProductWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the usage details of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @param request DescribeResourceUsageDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceUsageDetailResponse
         */
        public DescribeResourceUsageDetailResponse DescribeResourceUsageDetailWithOptions(DescribeResourceUsageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceUsageDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceUsageDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the usage details of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @param request DescribeResourceUsageDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceUsageDetailResponse
         */
        public async Task<DescribeResourceUsageDetailResponse> DescribeResourceUsageDetailWithOptionsAsync(DescribeResourceUsageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceUsageDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceUsageDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the usage details of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @param request DescribeResourceUsageDetailRequest
         * @return DescribeResourceUsageDetailResponse
         */
        public DescribeResourceUsageDetailResponse DescribeResourceUsageDetail(DescribeResourceUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceUsageDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the usage details of reserved instances (RIs) or storage capacity units (SCUs).
         *
         * @param request DescribeResourceUsageDetailRequest
         * @return DescribeResourceUsageDetailResponse
         */
        public async Task<DescribeResourceUsageDetailResponse> DescribeResourceUsageDetailAsync(DescribeResourceUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceUsageDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the total usage data of reserved instances or storage capacity units (SCUs).
         *
         * @param request DescribeResourceUsageTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceUsageTotalResponse
         */
        public DescribeResourceUsageTotalResponse DescribeResourceUsageTotalWithOptions(DescribeResourceUsageTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceUsageTotal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceUsageTotalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the total usage data of reserved instances or storage capacity units (SCUs).
         *
         * @param request DescribeResourceUsageTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceUsageTotalResponse
         */
        public async Task<DescribeResourceUsageTotalResponse> DescribeResourceUsageTotalWithOptionsAsync(DescribeResourceUsageTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceUsageTotal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceUsageTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the total usage data of reserved instances or storage capacity units (SCUs).
         *
         * @param request DescribeResourceUsageTotalRequest
         * @return DescribeResourceUsageTotalResponse
         */
        public DescribeResourceUsageTotalResponse DescribeResourceUsageTotal(DescribeResourceUsageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceUsageTotalWithOptions(request, runtime);
        }

        /**
         * @summary Queries the total usage data of reserved instances or storage capacity units (SCUs).
         *
         * @param request DescribeResourceUsageTotalRequest
         * @return DescribeResourceUsageTotalResponse
         */
        public async Task<DescribeResourceUsageTotalResponse> DescribeResourceUsageTotalAsync(DescribeResourceUsageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceUsageTotalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the coverage details of savings plans.
         *
         * @param request DescribeSavingsPlansCoverageDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSavingsPlansCoverageDetailResponse
         */
        public DescribeSavingsPlansCoverageDetailResponse DescribeSavingsPlansCoverageDetailWithOptions(DescribeSavingsPlansCoverageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSavingsPlansCoverageDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSavingsPlansCoverageDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the coverage details of savings plans.
         *
         * @param request DescribeSavingsPlansCoverageDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSavingsPlansCoverageDetailResponse
         */
        public async Task<DescribeSavingsPlansCoverageDetailResponse> DescribeSavingsPlansCoverageDetailWithOptionsAsync(DescribeSavingsPlansCoverageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSavingsPlansCoverageDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSavingsPlansCoverageDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the coverage details of savings plans.
         *
         * @param request DescribeSavingsPlansCoverageDetailRequest
         * @return DescribeSavingsPlansCoverageDetailResponse
         */
        public DescribeSavingsPlansCoverageDetailResponse DescribeSavingsPlansCoverageDetail(DescribeSavingsPlansCoverageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSavingsPlansCoverageDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the coverage details of savings plans.
         *
         * @param request DescribeSavingsPlansCoverageDetailRequest
         * @return DescribeSavingsPlansCoverageDetailResponse
         */
        public async Task<DescribeSavingsPlansCoverageDetailResponse> DescribeSavingsPlansCoverageDetailAsync(DescribeSavingsPlansCoverageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSavingsPlansCoverageDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the coverage summary of savings plans.
         *
         * @param request DescribeSavingsPlansCoverageTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSavingsPlansCoverageTotalResponse
         */
        public DescribeSavingsPlansCoverageTotalResponse DescribeSavingsPlansCoverageTotalWithOptions(DescribeSavingsPlansCoverageTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSavingsPlansCoverageTotal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSavingsPlansCoverageTotalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the coverage summary of savings plans.
         *
         * @param request DescribeSavingsPlansCoverageTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSavingsPlansCoverageTotalResponse
         */
        public async Task<DescribeSavingsPlansCoverageTotalResponse> DescribeSavingsPlansCoverageTotalWithOptionsAsync(DescribeSavingsPlansCoverageTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSavingsPlansCoverageTotal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSavingsPlansCoverageTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the coverage summary of savings plans.
         *
         * @param request DescribeSavingsPlansCoverageTotalRequest
         * @return DescribeSavingsPlansCoverageTotalResponse
         */
        public DescribeSavingsPlansCoverageTotalResponse DescribeSavingsPlansCoverageTotal(DescribeSavingsPlansCoverageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSavingsPlansCoverageTotalWithOptions(request, runtime);
        }

        /**
         * @summary Queries the coverage summary of savings plans.
         *
         * @param request DescribeSavingsPlansCoverageTotalRequest
         * @return DescribeSavingsPlansCoverageTotalResponse
         */
        public async Task<DescribeSavingsPlansCoverageTotalResponse> DescribeSavingsPlansCoverageTotalAsync(DescribeSavingsPlansCoverageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSavingsPlansCoverageTotalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the usage details of savings plans.
         *
         * @param request DescribeSavingsPlansUsageDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSavingsPlansUsageDetailResponse
         */
        public DescribeSavingsPlansUsageDetailResponse DescribeSavingsPlansUsageDetailWithOptions(DescribeSavingsPlansUsageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSavingsPlansUsageDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSavingsPlansUsageDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the usage details of savings plans.
         *
         * @param request DescribeSavingsPlansUsageDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSavingsPlansUsageDetailResponse
         */
        public async Task<DescribeSavingsPlansUsageDetailResponse> DescribeSavingsPlansUsageDetailWithOptionsAsync(DescribeSavingsPlansUsageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSavingsPlansUsageDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSavingsPlansUsageDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the usage details of savings plans.
         *
         * @param request DescribeSavingsPlansUsageDetailRequest
         * @return DescribeSavingsPlansUsageDetailResponse
         */
        public DescribeSavingsPlansUsageDetailResponse DescribeSavingsPlansUsageDetail(DescribeSavingsPlansUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSavingsPlansUsageDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the usage details of savings plans.
         *
         * @param request DescribeSavingsPlansUsageDetailRequest
         * @return DescribeSavingsPlansUsageDetailResponse
         */
        public async Task<DescribeSavingsPlansUsageDetailResponse> DescribeSavingsPlansUsageDetailAsync(DescribeSavingsPlansUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSavingsPlansUsageDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the usage summary of savings plans.
         *
         * @param request DescribeSavingsPlansUsageTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSavingsPlansUsageTotalResponse
         */
        public DescribeSavingsPlansUsageTotalResponse DescribeSavingsPlansUsageTotalWithOptions(DescribeSavingsPlansUsageTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSavingsPlansUsageTotal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSavingsPlansUsageTotalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the usage summary of savings plans.
         *
         * @param request DescribeSavingsPlansUsageTotalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSavingsPlansUsageTotalResponse
         */
        public async Task<DescribeSavingsPlansUsageTotalResponse> DescribeSavingsPlansUsageTotalWithOptionsAsync(DescribeSavingsPlansUsageTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPeriod))
            {
                query["StartPeriod"] = request.StartPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSavingsPlansUsageTotal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSavingsPlansUsageTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the usage summary of savings plans.
         *
         * @param request DescribeSavingsPlansUsageTotalRequest
         * @return DescribeSavingsPlansUsageTotalResponse
         */
        public DescribeSavingsPlansUsageTotalResponse DescribeSavingsPlansUsageTotal(DescribeSavingsPlansUsageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSavingsPlansUsageTotalWithOptions(request, runtime);
        }

        /**
         * @summary Queries the usage summary of savings plans.
         *
         * @param request DescribeSavingsPlansUsageTotalRequest
         * @return DescribeSavingsPlansUsageTotalResponse
         */
        public async Task<DescribeSavingsPlansUsageTotalResponse> DescribeSavingsPlansUsageTotalAsync(DescribeSavingsPlansUsageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSavingsPlansUsageTotalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries split bills.
         *
         * @description *   The data that you query by calling this operation is the same as the data that is queried by billing cycles in the Split Bill module of Cost Allocation.
         * *   You can query split bills that were generated within the last 12 months by calling this operation.
         * *   You can query split bills only after you enable the [Split Bill](https://usercenter2.aliyun.com/finance/split-bill) service in the User Center console.
         *
         * @param request DescribeSplitItemBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSplitItemBillResponse
         */
        public DescribeSplitItemBillResponse DescribeSplitItemBillWithOptions(DescribeSplitItemBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingDate))
            {
                query["BillingDate"] = request.BillingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceID))
            {
                query["InstanceID"] = request.InstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipCode))
            {
                query["PipCode"] = request.PipCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SplitItemID))
            {
                query["SplitItemID"] = request.SplitItemID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSplitItemBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSplitItemBillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries split bills.
         *
         * @description *   The data that you query by calling this operation is the same as the data that is queried by billing cycles in the Split Bill module of Cost Allocation.
         * *   You can query split bills that were generated within the last 12 months by calling this operation.
         * *   You can query split bills only after you enable the [Split Bill](https://usercenter2.aliyun.com/finance/split-bill) service in the User Center console.
         *
         * @param request DescribeSplitItemBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSplitItemBillResponse
         */
        public async Task<DescribeSplitItemBillResponse> DescribeSplitItemBillWithOptionsAsync(DescribeSplitItemBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingDate))
            {
                query["BillingDate"] = request.BillingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceID))
            {
                query["InstanceID"] = request.InstanceID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipCode))
            {
                query["PipCode"] = request.PipCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SplitItemID))
            {
                query["SplitItemID"] = request.SplitItemID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSplitItemBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSplitItemBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries split bills.
         *
         * @description *   The data that you query by calling this operation is the same as the data that is queried by billing cycles in the Split Bill module of Cost Allocation.
         * *   You can query split bills that were generated within the last 12 months by calling this operation.
         * *   You can query split bills only after you enable the [Split Bill](https://usercenter2.aliyun.com/finance/split-bill) service in the User Center console.
         *
         * @param request DescribeSplitItemBillRequest
         * @return DescribeSplitItemBillResponse
         */
        public DescribeSplitItemBillResponse DescribeSplitItemBill(DescribeSplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSplitItemBillWithOptions(request, runtime);
        }

        /**
         * @summary Queries split bills.
         *
         * @description *   The data that you query by calling this operation is the same as the data that is queried by billing cycles in the Split Bill module of Cost Allocation.
         * *   You can query split bills that were generated within the last 12 months by calling this operation.
         * *   You can query split bills only after you enable the [Split Bill](https://usercenter2.aliyun.com/finance/split-bill) service in the User Center console.
         *
         * @param request DescribeSplitItemBillRequest
         * @return DescribeSplitItemBillResponse
         */
        public async Task<DescribeSplitItemBillResponse> DescribeSplitItemBillAsync(DescribeSplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSplitItemBillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a financial relationship.
         *
         * @param request GetAccountRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountRelationResponse
         */
        public GetAccountRelationResponse GetAccountRelationWithOptions(GetAccountRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountRelationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a financial relationship.
         *
         * @param request GetAccountRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountRelationResponse
         */
        public async Task<GetAccountRelationResponse> GetAccountRelationWithOptionsAsync(GetAccountRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a financial relationship.
         *
         * @param request GetAccountRelationRequest
         * @return GetAccountRelationResponse
         */
        public GetAccountRelationResponse GetAccountRelation(GetAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountRelationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a financial relationship.
         *
         * @param request GetAccountRelationRequest
         * @return GetAccountRelationResponse
         */
        public async Task<GetAccountRelationResponse> GetAccountRelationAsync(GetAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountRelationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the account information about a customer of a virtual network operator (VNO).
         *
         * @param request GetCustomerAccountInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomerAccountInfoResponse
         */
        public GetCustomerAccountInfoResponse GetCustomerAccountInfoWithOptions(GetCustomerAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerAccountInfo",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the account information about a customer of a virtual network operator (VNO).
         *
         * @param request GetCustomerAccountInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomerAccountInfoResponse
         */
        public async Task<GetCustomerAccountInfoResponse> GetCustomerAccountInfoWithOptionsAsync(GetCustomerAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerAccountInfo",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the account information about a customer of a virtual network operator (VNO).
         *
         * @param request GetCustomerAccountInfoRequest
         * @return GetCustomerAccountInfoResponse
         */
        public GetCustomerAccountInfoResponse GetCustomerAccountInfo(GetCustomerAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerAccountInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the account information about a customer of a virtual network operator (VNO).
         *
         * @param request GetCustomerAccountInfoRequest
         * @return GetCustomerAccountInfoResponse
         */
        public async Task<GetCustomerAccountInfoResponse> GetCustomerAccountInfoAsync(GetCustomerAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerAccountInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the IDs of customers of a virtual network operator (VNO).
         *
         * @description The system queries the IDs of customers of a VNO based on the AccessKey pair used in the request.
         *
         * @param request GetCustomerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomerListResponse
         */
        public GetCustomerListResponse GetCustomerListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the IDs of customers of a virtual network operator (VNO).
         *
         * @description The system queries the IDs of customers of a VNO based on the AccessKey pair used in the request.
         *
         * @param request GetCustomerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomerListResponse
         */
        public async Task<GetCustomerListResponse> GetCustomerListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the IDs of customers of a virtual network operator (VNO).
         *
         * @description The system queries the IDs of customers of a VNO based on the AccessKey pair used in the request.
         *
         * @return GetCustomerListResponse
         */
        public GetCustomerListResponse GetCustomerList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerListWithOptions(runtime);
        }

        /**
         * @summary Queries the IDs of customers of a virtual network operator (VNO).
         *
         * @description The system queries the IDs of customers of a VNO based on the AccessKey pair used in the request.
         *
         * @return GetCustomerListResponse
         */
        public async Task<GetCustomerListResponse> GetCustomerListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerListWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the details of an order that belongs to your Alibaba Cloud account or distributors.
         *
         * @param request GetOrderDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrderDetailResponse
         */
        public GetOrderDetailResponse GetOrderDetailWithOptions(GetOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrderDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an order that belongs to your Alibaba Cloud account or distributors.
         *
         * @param request GetOrderDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrderDetailResponse
         */
        public async Task<GetOrderDetailResponse> GetOrderDetailWithOptionsAsync(GetOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrderDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrderDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an order that belongs to your Alibaba Cloud account or distributors.
         *
         * @param request GetOrderDetailRequest
         * @return GetOrderDetailResponse
         */
        public GetOrderDetailResponse GetOrderDetail(GetOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrderDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an order that belongs to your Alibaba Cloud account or distributors.
         *
         * @param request GetOrderDetailRequest
         * @return GetOrderDetailResponse
         */
        public async Task<GetOrderDetailResponse> GetOrderDetailAsync(GetOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrderDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the pay-as-you-go price of an Alibaba Cloud service.
         *
         * @description ### Usage notes
         * 1.  Call the QueryProductList operation to obtain the code of the service. For more information, see [QueryProductList](https://help.aliyun.com/document_detail/95984.html).
         * 2.  Call the DescribePricingModule operation to obtain the configuration parameters of the service. For more information, see [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html).
         * 3.  Call the GetPayAsYouGoPrice operation to obtain the pay-as-you-go price of the service based on the returned configuration parameters.
         *
         * @param request GetPayAsYouGoPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPayAsYouGoPriceResponse
         */
        public GetPayAsYouGoPriceResponse GetPayAsYouGoPriceWithOptions(GetPayAsYouGoPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleList))
            {
                query["ModuleList"] = request.ModuleList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPayAsYouGoPrice",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPayAsYouGoPriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the pay-as-you-go price of an Alibaba Cloud service.
         *
         * @description ### Usage notes
         * 1.  Call the QueryProductList operation to obtain the code of the service. For more information, see [QueryProductList](https://help.aliyun.com/document_detail/95984.html).
         * 2.  Call the DescribePricingModule operation to obtain the configuration parameters of the service. For more information, see [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html).
         * 3.  Call the GetPayAsYouGoPrice operation to obtain the pay-as-you-go price of the service based on the returned configuration parameters.
         *
         * @param request GetPayAsYouGoPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPayAsYouGoPriceResponse
         */
        public async Task<GetPayAsYouGoPriceResponse> GetPayAsYouGoPriceWithOptionsAsync(GetPayAsYouGoPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleList))
            {
                query["ModuleList"] = request.ModuleList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPayAsYouGoPrice",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPayAsYouGoPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the pay-as-you-go price of an Alibaba Cloud service.
         *
         * @description ### Usage notes
         * 1.  Call the QueryProductList operation to obtain the code of the service. For more information, see [QueryProductList](https://help.aliyun.com/document_detail/95984.html).
         * 2.  Call the DescribePricingModule operation to obtain the configuration parameters of the service. For more information, see [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html).
         * 3.  Call the GetPayAsYouGoPrice operation to obtain the pay-as-you-go price of the service based on the returned configuration parameters.
         *
         * @param request GetPayAsYouGoPriceRequest
         * @return GetPayAsYouGoPriceResponse
         */
        public GetPayAsYouGoPriceResponse GetPayAsYouGoPrice(GetPayAsYouGoPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPayAsYouGoPriceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the pay-as-you-go price of an Alibaba Cloud service.
         *
         * @description ### Usage notes
         * 1.  Call the QueryProductList operation to obtain the code of the service. For more information, see [QueryProductList](https://help.aliyun.com/document_detail/95984.html).
         * 2.  Call the DescribePricingModule operation to obtain the configuration parameters of the service. For more information, see [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html).
         * 3.  Call the GetPayAsYouGoPrice operation to obtain the pay-as-you-go price of the service based on the returned configuration parameters.
         *
         * @param request GetPayAsYouGoPriceRequest
         * @return GetPayAsYouGoPriceResponse
         */
        public async Task<GetPayAsYouGoPriceResponse> GetPayAsYouGoPriceAsync(GetPayAsYouGoPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPayAsYouGoPriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the price of a resource plan.
         *
         * @param request GetResourcePackagePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourcePackagePriceResponse
         */
        public GetResourcePackagePriceResponse GetResourcePackagePriceWithOptions(GetResourcePackagePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourcePackagePrice",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcePackagePriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the price of a resource plan.
         *
         * @param request GetResourcePackagePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourcePackagePriceResponse
         */
        public async Task<GetResourcePackagePriceResponse> GetResourcePackagePriceWithOptionsAsync(GetResourcePackagePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourcePackagePrice",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcePackagePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the price of a resource plan.
         *
         * @param request GetResourcePackagePriceRequest
         * @return GetResourcePackagePriceResponse
         */
        public GetResourcePackagePriceResponse GetResourcePackagePrice(GetResourcePackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourcePackagePriceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the price of a resource plan.
         *
         * @param request GetResourcePackagePriceRequest
         * @return GetResourcePackagePriceResponse
         */
        public async Task<GetResourcePackagePriceResponse> GetResourcePackagePriceAsync(GetResourcePackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourcePackagePriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the subscription price of an Alibaba Cloud service.
         *
         * @description 1.  Call the QueryProductList operation to obtain the code of the service. For more information, see [QueryProductList](https://help.aliyun.com/document_detail/95984.html).
         * 2.  Call the DescribePricingModule operation to obtain the configuration parameters of the service. For more information, see [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html).
         * 3.  Call the GetSubscriptionPrice operation to obtain the pricing of the service based on the returned configuration parameters.
         *
         * @param request GetSubscriptionPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubscriptionPriceResponse
         */
        public GetSubscriptionPriceResponse GetSubscriptionPriceWithOptions(GetSubscriptionPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleList))
            {
                query["ModuleList"] = request.ModuleList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePeriodQuantity))
            {
                query["ServicePeriodQuantity"] = request.ServicePeriodQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePeriodUnit))
            {
                query["ServicePeriodUnit"] = request.ServicePeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionPrice",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionPriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the subscription price of an Alibaba Cloud service.
         *
         * @description 1.  Call the QueryProductList operation to obtain the code of the service. For more information, see [QueryProductList](https://help.aliyun.com/document_detail/95984.html).
         * 2.  Call the DescribePricingModule operation to obtain the configuration parameters of the service. For more information, see [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html).
         * 3.  Call the GetSubscriptionPrice operation to obtain the pricing of the service based on the returned configuration parameters.
         *
         * @param request GetSubscriptionPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubscriptionPriceResponse
         */
        public async Task<GetSubscriptionPriceResponse> GetSubscriptionPriceWithOptionsAsync(GetSubscriptionPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleList))
            {
                query["ModuleList"] = request.ModuleList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePeriodQuantity))
            {
                query["ServicePeriodQuantity"] = request.ServicePeriodQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicePeriodUnit))
            {
                query["ServicePeriodUnit"] = request.ServicePeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionPrice",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the subscription price of an Alibaba Cloud service.
         *
         * @description 1.  Call the QueryProductList operation to obtain the code of the service. For more information, see [QueryProductList](https://help.aliyun.com/document_detail/95984.html).
         * 2.  Call the DescribePricingModule operation to obtain the configuration parameters of the service. For more information, see [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html).
         * 3.  Call the GetSubscriptionPrice operation to obtain the pricing of the service based on the returned configuration parameters.
         *
         * @param request GetSubscriptionPriceRequest
         * @return GetSubscriptionPriceResponse
         */
        public GetSubscriptionPriceResponse GetSubscriptionPrice(GetSubscriptionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubscriptionPriceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the subscription price of an Alibaba Cloud service.
         *
         * @description 1.  Call the QueryProductList operation to obtain the code of the service. For more information, see [QueryProductList](https://help.aliyun.com/document_detail/95984.html).
         * 2.  Call the DescribePricingModule operation to obtain the configuration parameters of the service. For more information, see [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html).
         * 3.  Call the GetSubscriptionPrice operation to obtain the pricing of the service based on the returned configuration parameters.
         *
         * @param request GetSubscriptionPriceRequest
         * @return GetSubscriptionPriceResponse
         */
        public async Task<GetSubscriptionPriceResponse> GetSubscriptionPriceAsync(GetSubscriptionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubscriptionPriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the refundable amount for an instance from which you want to unsubscribe.
         *
         * @description 1.  **Check the information about unsubscription and confirm the unsubscription terms and refundable amount. The resource that is unsubscribed cannot be restored.**
         * 2.  Refunds are applicable only for the actual paid amount. Vouchers used for the purchase are non-refundable.
         * 3.  For more information, see [Rules for unsubscribing from resources](https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules).
         *
         * @param request InquiryPriceRefundInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InquiryPriceRefundInstanceResponse
         */
        public InquiryPriceRefundInstanceResponse InquiryPriceRefundInstanceWithOptions(InquiryPriceRefundInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InquiryPriceRefundInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InquiryPriceRefundInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the refundable amount for an instance from which you want to unsubscribe.
         *
         * @description 1.  **Check the information about unsubscription and confirm the unsubscription terms and refundable amount. The resource that is unsubscribed cannot be restored.**
         * 2.  Refunds are applicable only for the actual paid amount. Vouchers used for the purchase are non-refundable.
         * 3.  For more information, see [Rules for unsubscribing from resources](https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules).
         *
         * @param request InquiryPriceRefundInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InquiryPriceRefundInstanceResponse
         */
        public async Task<InquiryPriceRefundInstanceResponse> InquiryPriceRefundInstanceWithOptionsAsync(InquiryPriceRefundInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InquiryPriceRefundInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InquiryPriceRefundInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the refundable amount for an instance from which you want to unsubscribe.
         *
         * @description 1.  **Check the information about unsubscription and confirm the unsubscription terms and refundable amount. The resource that is unsubscribed cannot be restored.**
         * 2.  Refunds are applicable only for the actual paid amount. Vouchers used for the purchase are non-refundable.
         * 3.  For more information, see [Rules for unsubscribing from resources](https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules).
         *
         * @param request InquiryPriceRefundInstanceRequest
         * @return InquiryPriceRefundInstanceResponse
         */
        public InquiryPriceRefundInstanceResponse InquiryPriceRefundInstance(InquiryPriceRefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InquiryPriceRefundInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the refundable amount for an instance from which you want to unsubscribe.
         *
         * @description 1.  **Check the information about unsubscription and confirm the unsubscription terms and refundable amount. The resource that is unsubscribed cannot be restored.**
         * 2.  Refunds are applicable only for the actual paid amount. Vouchers used for the purchase are non-refundable.
         * 3.  For more information, see [Rules for unsubscribing from resources](https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules).
         *
         * @param request InquiryPriceRefundInstanceRequest
         * @return InquiryPriceRefundInstanceResponse
         */
        public async Task<InquiryPriceRefundInstanceResponse> InquiryPriceRefundInstanceAsync(InquiryPriceRefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InquiryPriceRefundInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds or removes permissions granted to a member in a financial relationship.
         *
         * @param request ModifyAccountRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccountRelationResponse
         */
        public ModifyAccountRelationResponse ModifyAccountRelationWithOptions(ModifyAccountRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildNick))
            {
                query["ChildNick"] = request.ChildNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildUserId))
            {
                query["ChildUserId"] = request.ChildUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserId))
            {
                query["ParentUserId"] = request.ParentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionCodes))
            {
                query["PermissionCodes"] = request.PermissionCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["RelationId"] = request.RelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationOperation))
            {
                query["RelationOperation"] = request.RelationOperation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodes))
            {
                query["RoleCodes"] = request.RoleCodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountRelationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds or removes permissions granted to a member in a financial relationship.
         *
         * @param request ModifyAccountRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccountRelationResponse
         */
        public async Task<ModifyAccountRelationResponse> ModifyAccountRelationWithOptionsAsync(ModifyAccountRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildNick))
            {
                query["ChildNick"] = request.ChildNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildUserId))
            {
                query["ChildUserId"] = request.ChildUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserId))
            {
                query["ParentUserId"] = request.ParentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionCodes))
            {
                query["PermissionCodes"] = request.PermissionCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["RelationId"] = request.RelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationOperation))
            {
                query["RelationOperation"] = request.RelationOperation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodes))
            {
                query["RoleCodes"] = request.RoleCodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds or removes permissions granted to a member in a financial relationship.
         *
         * @param request ModifyAccountRelationRequest
         * @return ModifyAccountRelationResponse
         */
        public ModifyAccountRelationResponse ModifyAccountRelation(ModifyAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountRelationWithOptions(request, runtime);
        }

        /**
         * @summary Adds or removes permissions granted to a member in a financial relationship.
         *
         * @param request ModifyAccountRelationRequest
         * @return ModifyAccountRelationResponse
         */
        public async Task<ModifyAccountRelationResponse> ModifyAccountRelationAsync(ModifyAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountRelationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies one or more cost centers.
         *
         * @param request ModifyCostUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyCostUnitResponse
         */
        public ModifyCostUnitResponse ModifyCostUnitWithOptions(ModifyCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitEntityList))
            {
                query["UnitEntityList"] = request.UnitEntityList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCostUnit",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCostUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies one or more cost centers.
         *
         * @param request ModifyCostUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyCostUnitResponse
         */
        public async Task<ModifyCostUnitResponse> ModifyCostUnitWithOptionsAsync(ModifyCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitEntityList))
            {
                query["UnitEntityList"] = request.UnitEntityList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCostUnit",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCostUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies one or more cost centers.
         *
         * @param request ModifyCostUnitRequest
         * @return ModifyCostUnitResponse
         */
        public ModifyCostUnitResponse ModifyCostUnit(ModifyCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCostUnitWithOptions(request, runtime);
        }

        /**
         * @summary Modifies one or more cost centers.
         *
         * @param request ModifyCostUnitRequest
         * @return ModifyCostUnitResponse
         */
        public async Task<ModifyCostUnitResponse> ModifyCostUnitAsync(ModifyCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCostUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an instance. When you call this operation, the system generates a modification order and automatically completes the payment. You cannot call this operation to modify the configurations of an Elastic Compute Service (ECS) instance or ApsaraDB RDS instance. To modify the configurations of an ECS or ApsaraDB RDS instance, call the dedicated operation of the corresponding service.
         *
         * @param request ModifyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceResponse
         */
        public ModifyInstanceResponse ModifyInstanceWithOptions(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                query["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["Parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an instance. When you call this operation, the system generates a modification order and automatically completes the payment. You cannot call this operation to modify the configurations of an Elastic Compute Service (ECS) instance or ApsaraDB RDS instance. To modify the configurations of an ECS or ApsaraDB RDS instance, call the dedicated operation of the corresponding service.
         *
         * @param request ModifyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceResponse
         */
        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(ModifyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                query["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["Parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an instance. When you call this operation, the system generates a modification order and automatically completes the payment. You cannot call this operation to modify the configurations of an Elastic Compute Service (ECS) instance or ApsaraDB RDS instance. To modify the configurations of an ECS or ApsaraDB RDS instance, call the dedicated operation of the corresponding service.
         *
         * @param request ModifyInstanceRequest
         * @return ModifyInstanceResponse
         */
        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an instance. When you call this operation, the system generates a modification order and automatically completes the payment. You cannot call this operation to modify the configurations of an Elastic Compute Service (ECS) instance or ApsaraDB RDS instance. To modify the configurations of an ECS or ApsaraDB RDS instance, call the dedicated operation of the corresponding service.
         *
         * @param request ModifyInstanceRequest
         * @return ModifyInstanceResponse
         */
        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the balance of your account.
         *
         * @param request QueryAccountBalanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccountBalanceResponse
         */
        public QueryAccountBalanceResponse QueryAccountBalanceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountBalance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountBalanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the balance of your account.
         *
         * @param request QueryAccountBalanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccountBalanceResponse
         */
        public async Task<QueryAccountBalanceResponse> QueryAccountBalanceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountBalance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the balance of your account.
         *
         * @return QueryAccountBalanceResponse
         */
        public QueryAccountBalanceResponse QueryAccountBalance()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountBalanceWithOptions(runtime);
        }

        /**
         * @summary Queries the balance of your account.
         *
         * @return QueryAccountBalanceResponse
         */
        public async Task<QueryAccountBalanceResponse> QueryAccountBalanceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountBalanceWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the bills of your Alibaba Cloud account within a billing cycle. You can summarize the bills by resource owner.
         *
         * @description Before you call this operation, take note of the following items:
         * *   Account bills are summarized based on instance bills. In most cases, the account bills do not include the data generated on the last day of the specified period.
         * *   You can query the data generated in June 2020 or later for Cloud Communications services. However, the query results do not include the data of Alibaba Cloud Domains.
         *
         * @param request QueryAccountBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccountBillResponse
         */
        public QueryAccountBillResponse QueryAccountBillWithOptions(QueryAccountBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingDate))
            {
                query["BillingDate"] = request.BillingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGroupByProduct))
            {
                query["IsGroupByProduct"] = request.IsGroupByProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerID))
            {
                query["OwnerID"] = request.OwnerID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountBillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the bills of your Alibaba Cloud account within a billing cycle. You can summarize the bills by resource owner.
         *
         * @description Before you call this operation, take note of the following items:
         * *   Account bills are summarized based on instance bills. In most cases, the account bills do not include the data generated on the last day of the specified period.
         * *   You can query the data generated in June 2020 or later for Cloud Communications services. However, the query results do not include the data of Alibaba Cloud Domains.
         *
         * @param request QueryAccountBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccountBillResponse
         */
        public async Task<QueryAccountBillResponse> QueryAccountBillWithOptionsAsync(QueryAccountBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingDate))
            {
                query["BillingDate"] = request.BillingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGroupByProduct))
            {
                query["IsGroupByProduct"] = request.IsGroupByProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerID))
            {
                query["OwnerID"] = request.OwnerID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the bills of your Alibaba Cloud account within a billing cycle. You can summarize the bills by resource owner.
         *
         * @description Before you call this operation, take note of the following items:
         * *   Account bills are summarized based on instance bills. In most cases, the account bills do not include the data generated on the last day of the specified period.
         * *   You can query the data generated in June 2020 or later for Cloud Communications services. However, the query results do not include the data of Alibaba Cloud Domains.
         *
         * @param request QueryAccountBillRequest
         * @return QueryAccountBillResponse
         */
        public QueryAccountBillResponse QueryAccountBill(QueryAccountBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountBillWithOptions(request, runtime);
        }

        /**
         * @summary Queries the bills of your Alibaba Cloud account within a billing cycle. You can summarize the bills by resource owner.
         *
         * @description Before you call this operation, take note of the following items:
         * *   Account bills are summarized based on instance bills. In most cases, the account bills do not include the data generated on the last day of the specified period.
         * *   You can query the data generated in June 2020 or later for Cloud Communications services. However, the query results do not include the data of Alibaba Cloud Domains.
         *
         * @param request QueryAccountBillRequest
         * @return QueryAccountBillResponse
         */
        public async Task<QueryAccountBillResponse> QueryAccountBillAsync(QueryAccountBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountBillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of transactions within your account.
         *
         * @param request QueryAccountTransactionDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccountTransactionDetailsResponse
         */
        public QueryAccountTransactionDetailsResponse QueryAccountTransactionDetailsWithOptions(QueryAccountTransactionDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordID))
            {
                query["RecordID"] = request.RecordID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannel))
            {
                query["TransactionChannel"] = request.TransactionChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannelSN))
            {
                query["TransactionChannelSN"] = request.TransactionChannelSN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionNumber))
            {
                query["TransactionNumber"] = request.TransactionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionType))
            {
                query["TransactionType"] = request.TransactionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountTransactionDetails",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountTransactionDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of transactions within your account.
         *
         * @param request QueryAccountTransactionDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccountTransactionDetailsResponse
         */
        public async Task<QueryAccountTransactionDetailsResponse> QueryAccountTransactionDetailsWithOptionsAsync(QueryAccountTransactionDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordID))
            {
                query["RecordID"] = request.RecordID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannel))
            {
                query["TransactionChannel"] = request.TransactionChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannelSN))
            {
                query["TransactionChannelSN"] = request.TransactionChannelSN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionNumber))
            {
                query["TransactionNumber"] = request.TransactionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionType))
            {
                query["TransactionType"] = request.TransactionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountTransactionDetails",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountTransactionDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of transactions within your account.
         *
         * @param request QueryAccountTransactionDetailsRequest
         * @return QueryAccountTransactionDetailsResponse
         */
        public QueryAccountTransactionDetailsResponse QueryAccountTransactionDetails(QueryAccountTransactionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountTransactionDetailsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of transactions within your account.
         *
         * @param request QueryAccountTransactionDetailsRequest
         * @return QueryAccountTransactionDetailsResponse
         */
        public async Task<QueryAccountTransactionDetailsResponse> QueryAccountTransactionDetailsAsync(QueryAccountTransactionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountTransactionDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries transactions within your Alibaba Cloud account.
         *
         * @param request QueryAccountTransactionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccountTransactionsResponse
         */
        public QueryAccountTransactionsResponse QueryAccountTransactionsWithOptions(QueryAccountTransactionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordID))
            {
                query["RecordID"] = request.RecordID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannel))
            {
                query["TransactionChannel"] = request.TransactionChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannelSN))
            {
                query["TransactionChannelSN"] = request.TransactionChannelSN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionFlow))
            {
                query["TransactionFlow"] = request.TransactionFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionNumber))
            {
                query["TransactionNumber"] = request.TransactionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionType))
            {
                query["TransactionType"] = request.TransactionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountTransactions",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountTransactionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries transactions within your Alibaba Cloud account.
         *
         * @param request QueryAccountTransactionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAccountTransactionsResponse
         */
        public async Task<QueryAccountTransactionsResponse> QueryAccountTransactionsWithOptionsAsync(QueryAccountTransactionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordID))
            {
                query["RecordID"] = request.RecordID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannel))
            {
                query["TransactionChannel"] = request.TransactionChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannelSN))
            {
                query["TransactionChannelSN"] = request.TransactionChannelSN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionFlow))
            {
                query["TransactionFlow"] = request.TransactionFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionNumber))
            {
                query["TransactionNumber"] = request.TransactionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionType))
            {
                query["TransactionType"] = request.TransactionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountTransactions",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountTransactionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries transactions within your Alibaba Cloud account.
         *
         * @param request QueryAccountTransactionsRequest
         * @return QueryAccountTransactionsResponse
         */
        public QueryAccountTransactionsResponse QueryAccountTransactions(QueryAccountTransactionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountTransactionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries transactions within your Alibaba Cloud account.
         *
         * @param request QueryAccountTransactionsRequest
         * @return QueryAccountTransactionsResponse
         */
        public async Task<QueryAccountTransactionsResponse> QueryAccountTransactionsAsync(QueryAccountTransactionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountTransactionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries available instances.
         *
         * @param request QueryAvailableInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAvailableInstancesResponse
         */
        public QueryAvailableInstancesResponse QueryAvailableInstancesWithOptions(QueryAvailableInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeEnd))
            {
                query["EndTimeEnd"] = request.EndTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeStart))
            {
                query["EndTimeStart"] = request.EndTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIDs))
            {
                query["InstanceIDs"] = request.InstanceIDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewStatus))
            {
                query["RenewStatus"] = request.RenewStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvailableInstances",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailableInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries available instances.
         *
         * @param request QueryAvailableInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAvailableInstancesResponse
         */
        public async Task<QueryAvailableInstancesResponse> QueryAvailableInstancesWithOptionsAsync(QueryAvailableInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeEnd))
            {
                query["EndTimeEnd"] = request.EndTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeStart))
            {
                query["EndTimeStart"] = request.EndTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIDs))
            {
                query["InstanceIDs"] = request.InstanceIDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewStatus))
            {
                query["RenewStatus"] = request.RenewStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvailableInstances",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailableInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries available instances.
         *
         * @param request QueryAvailableInstancesRequest
         * @return QueryAvailableInstancesResponse
         */
        public QueryAvailableInstancesResponse QueryAvailableInstances(QueryAvailableInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAvailableInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries available instances.
         *
         * @param request QueryAvailableInstancesRequest
         * @return QueryAvailableInstancesResponse
         */
        public async Task<QueryAvailableInstancesResponse> QueryAvailableInstancesAsync(QueryAvailableInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAvailableInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the bills in a billing cycle.
         *
         * @param request QueryBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBillResponse
         */
        public QueryBillResponse QueryBillWithOptions(QueryBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDisplayLocalCurrency))
            {
                query["IsDisplayLocalCurrency"] = request.IsDisplayLocalCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the bills in a billing cycle.
         *
         * @param request QueryBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBillResponse
         */
        public async Task<QueryBillResponse> QueryBillWithOptionsAsync(QueryBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDisplayLocalCurrency))
            {
                query["IsDisplayLocalCurrency"] = request.IsDisplayLocalCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the bills in a billing cycle.
         *
         * @param request QueryBillRequest
         * @return QueryBillResponse
         */
        public QueryBillResponse QueryBill(QueryBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillWithOptions(request, runtime);
        }

        /**
         * @summary Queries the bills in a billing cycle.
         *
         * @param request QueryBillRequest
         * @return QueryBillResponse
         */
        public async Task<QueryBillResponse> QueryBillAsync(QueryBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the bill overview information in a billing cycle.
         *
         * @param request QueryBillOverviewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBillOverviewResponse
         */
        public QueryBillOverviewResponse QueryBillOverviewWithOptions(QueryBillOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBillOverview",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBillOverviewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the bill overview information in a billing cycle.
         *
         * @param request QueryBillOverviewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBillOverviewResponse
         */
        public async Task<QueryBillOverviewResponse> QueryBillOverviewWithOptionsAsync(QueryBillOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBillOverview",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBillOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the bill overview information in a billing cycle.
         *
         * @param request QueryBillOverviewRequest
         * @return QueryBillOverviewResponse
         */
        public QueryBillOverviewResponse QueryBillOverview(QueryBillOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillOverviewWithOptions(request, runtime);
        }

        /**
         * @summary Queries the bill overview information in a billing cycle.
         *
         * @param request QueryBillOverviewRequest
         * @return QueryBillOverviewResponse
         */
        public async Task<QueryBillOverviewResponse> QueryBillOverviewAsync(QueryBillOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillOverviewWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the subscribed bills that are stored in Object Storage Service (OSS) bucket.
         *
         * @param request QueryBillToOSSSubscriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBillToOSSSubscriptionResponse
         */
        public QueryBillToOSSSubscriptionResponse QueryBillToOSSSubscriptionWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBillToOSSSubscription",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBillToOSSSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the subscribed bills that are stored in Object Storage Service (OSS) bucket.
         *
         * @param request QueryBillToOSSSubscriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBillToOSSSubscriptionResponse
         */
        public async Task<QueryBillToOSSSubscriptionResponse> QueryBillToOSSSubscriptionWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBillToOSSSubscription",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBillToOSSSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the subscribed bills that are stored in Object Storage Service (OSS) bucket.
         *
         * @return QueryBillToOSSSubscriptionResponse
         */
        public QueryBillToOSSSubscriptionResponse QueryBillToOSSSubscription()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillToOSSSubscriptionWithOptions(runtime);
        }

        /**
         * @summary Queries the subscribed bills that are stored in Object Storage Service (OSS) bucket.
         *
         * @return QueryBillToOSSSubscriptionResponse
         */
        public async Task<QueryBillToOSSSubscriptionResponse> QueryBillToOSSSubscriptionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillToOSSSubscriptionWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the information about vouchers.
         *
         * @param request QueryCashCouponsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCashCouponsResponse
         */
        public QueryCashCouponsResponse QueryCashCouponsWithOptions(QueryCashCouponsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveOrNot))
            {
                query["EffectiveOrNot"] = request.EffectiveOrNot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeEnd))
            {
                query["ExpiryTimeEnd"] = request.ExpiryTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeStart))
            {
                query["ExpiryTimeStart"] = request.ExpiryTimeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCashCoupons",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCashCouponsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about vouchers.
         *
         * @param request QueryCashCouponsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCashCouponsResponse
         */
        public async Task<QueryCashCouponsResponse> QueryCashCouponsWithOptionsAsync(QueryCashCouponsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveOrNot))
            {
                query["EffectiveOrNot"] = request.EffectiveOrNot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeEnd))
            {
                query["ExpiryTimeEnd"] = request.ExpiryTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeStart))
            {
                query["ExpiryTimeStart"] = request.ExpiryTimeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCashCoupons",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCashCouponsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about vouchers.
         *
         * @param request QueryCashCouponsRequest
         * @return QueryCashCouponsResponse
         */
        public QueryCashCouponsResponse QueryCashCoupons(QueryCashCouponsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCashCouponsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about vouchers.
         *
         * @param request QueryCashCouponsRequest
         * @return QueryCashCouponsResponse
         */
        public async Task<QueryCashCouponsResponse> QueryCashCouponsAsync(QueryCashCouponsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCashCouponsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a service based on the service code.
         *
         * @description You can call this operation to query the information about a service based on the service code.
         *
         * @param request QueryCommodityListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCommodityListResponse
         */
        public QueryCommodityListResponse QueryCommodityListWithOptions(QueryCommodityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCommodityList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCommodityListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a service based on the service code.
         *
         * @description You can call this operation to query the information about a service based on the service code.
         *
         * @param request QueryCommodityListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCommodityListResponse
         */
        public async Task<QueryCommodityListResponse> QueryCommodityListWithOptionsAsync(QueryCommodityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCommodityList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCommodityListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a service based on the service code.
         *
         * @description You can call this operation to query the information about a service based on the service code.
         *
         * @param request QueryCommodityListRequest
         * @return QueryCommodityListResponse
         */
        public QueryCommodityListResponse QueryCommodityList(QueryCommodityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCommodityListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a service based on the service code.
         *
         * @description You can call this operation to query the information about a service based on the service code.
         *
         * @param request QueryCommodityListRequest
         * @return QueryCommodityListResponse
         */
        public async Task<QueryCommodityListResponse> QueryCommodityListAsync(QueryCommodityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCommodityListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all cost centers within the current node of the cost center tree. If the ParentUnitId parameter is set to -1, all cost centers are queried.
         *
         * @param request QueryCostUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCostUnitResponse
         */
        public QueryCostUnitResponse QueryCostUnitWithOptions(QueryCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUnitId))
            {
                query["ParentUnitId"] = request.ParentUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCostUnit",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCostUnitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all cost centers within the current node of the cost center tree. If the ParentUnitId parameter is set to -1, all cost centers are queried.
         *
         * @param request QueryCostUnitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCostUnitResponse
         */
        public async Task<QueryCostUnitResponse> QueryCostUnitWithOptionsAsync(QueryCostUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUnitId))
            {
                query["ParentUnitId"] = request.ParentUnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCostUnit",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCostUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all cost centers within the current node of the cost center tree. If the ParentUnitId parameter is set to -1, all cost centers are queried.
         *
         * @param request QueryCostUnitRequest
         * @return QueryCostUnitResponse
         */
        public QueryCostUnitResponse QueryCostUnit(QueryCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCostUnitWithOptions(request, runtime);
        }

        /**
         * @summary Queries all cost centers within the current node of the cost center tree. If the ParentUnitId parameter is set to -1, all cost centers are queried.
         *
         * @param request QueryCostUnitRequest
         * @return QueryCostUnitResponse
         */
        public async Task<QueryCostUnitResponse> QueryCostUnitAsync(QueryCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCostUnitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the resource instances that are allocated to a cost center. If the unitId parameter is set to 0, the unallocated primary resource instances and sub-resource instances are queried.
         *
         * @param request QueryCostUnitResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCostUnitResourceResponse
         */
        public QueryCostUnitResourceResponse QueryCostUnitResourceWithOptions(QueryCostUnitResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitId))
            {
                query["UnitId"] = request.UnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCostUnitResource",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCostUnitResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the resource instances that are allocated to a cost center. If the unitId parameter is set to 0, the unallocated primary resource instances and sub-resource instances are queried.
         *
         * @param request QueryCostUnitResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCostUnitResourceResponse
         */
        public async Task<QueryCostUnitResourceResponse> QueryCostUnitResourceWithOptionsAsync(QueryCostUnitResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitId))
            {
                query["UnitId"] = request.UnitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCostUnitResource",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCostUnitResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the resource instances that are allocated to a cost center. If the unitId parameter is set to 0, the unallocated primary resource instances and sub-resource instances are queried.
         *
         * @param request QueryCostUnitResourceRequest
         * @return QueryCostUnitResourceResponse
         */
        public QueryCostUnitResourceResponse QueryCostUnitResource(QueryCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCostUnitResourceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the resource instances that are allocated to a cost center. If the unitId parameter is set to 0, the unallocated primary resource instances and sub-resource instances are queried.
         *
         * @param request QueryCostUnitResourceRequest
         * @return QueryCostUnitResourceResponse
         */
        public async Task<QueryCostUnitResourceResponse> QueryCostUnitResourceAsync(QueryCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCostUnitResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the addresses to which invoices are mailed.
         *
         * @param request QueryCustomerAddressListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomerAddressListResponse
         */
        public QueryCustomerAddressListResponse QueryCustomerAddressListWithOptions(QueryCustomerAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomerAddressList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerAddressListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the addresses to which invoices are mailed.
         *
         * @param request QueryCustomerAddressListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomerAddressListResponse
         */
        public async Task<QueryCustomerAddressListResponse> QueryCustomerAddressListWithOptionsAsync(QueryCustomerAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomerAddressList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerAddressListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the addresses to which invoices are mailed.
         *
         * @param request QueryCustomerAddressListRequest
         * @return QueryCustomerAddressListResponse
         */
        public QueryCustomerAddressListResponse QueryCustomerAddressList(QueryCustomerAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomerAddressListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the addresses to which invoices are mailed.
         *
         * @param request QueryCustomerAddressListRequest
         * @return QueryCustomerAddressListResponse
         */
        public async Task<QueryCustomerAddressListResponse> QueryCustomerAddressListAsync(QueryCustomerAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomerAddressListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the usage of resource plans, including reserved instances (RIs) and storage capacity units (SCUs).
         *
         * @description Limits:
         * *   Only the usage records within the past year can be queried.
         *
         * @param request QueryDPUtilizationDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDPUtilizationDetailResponse
         */
        public QueryDPUtilizationDetailResponse QueryDPUtilizationDetailWithOptions(QueryDPUtilizationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductedInstanceId))
            {
                query["DeductedInstanceId"] = request.DeductedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeShare))
            {
                query["IncludeShare"] = request.IncludeShare;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSpec))
            {
                query["InstanceSpec"] = request.InstanceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastToken))
            {
                query["LastToken"] = request.LastToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDPUtilizationDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDPUtilizationDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the usage of resource plans, including reserved instances (RIs) and storage capacity units (SCUs).
         *
         * @description Limits:
         * *   Only the usage records within the past year can be queried.
         *
         * @param request QueryDPUtilizationDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDPUtilizationDetailResponse
         */
        public async Task<QueryDPUtilizationDetailResponse> QueryDPUtilizationDetailWithOptionsAsync(QueryDPUtilizationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductedInstanceId))
            {
                query["DeductedInstanceId"] = request.DeductedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeShare))
            {
                query["IncludeShare"] = request.IncludeShare;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSpec))
            {
                query["InstanceSpec"] = request.InstanceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastToken))
            {
                query["LastToken"] = request.LastToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDPUtilizationDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDPUtilizationDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the usage of resource plans, including reserved instances (RIs) and storage capacity units (SCUs).
         *
         * @description Limits:
         * *   Only the usage records within the past year can be queried.
         *
         * @param request QueryDPUtilizationDetailRequest
         * @return QueryDPUtilizationDetailResponse
         */
        public QueryDPUtilizationDetailResponse QueryDPUtilizationDetail(QueryDPUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDPUtilizationDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the usage of resource plans, including reserved instances (RIs) and storage capacity units (SCUs).
         *
         * @description Limits:
         * *   Only the usage records within the past year can be queried.
         *
         * @param request QueryDPUtilizationDetailRequest
         * @return QueryDPUtilizationDetailResponse
         */
        public async Task<QueryDPUtilizationDetailResponse> QueryDPUtilizationDetailAsync(QueryDPUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDPUtilizationDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the orders for which you want to apply for invoices.
         *
         * @param request QueryEvaluateListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEvaluateListResponse
         */
        public QueryEvaluateListResponse QueryEvaluateListWithOptions(QueryEvaluateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillCycle))
            {
                query["BillCycle"] = request.BillCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypeList))
            {
                query["BizTypeList"] = request.BizTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndAmount))
            {
                query["EndAmount"] = request.EndAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndBizTime))
            {
                query["EndBizTime"] = request.EndBizTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndSearchTime))
            {
                query["EndSearchTime"] = request.EndSearchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartAmount))
            {
                query["StartAmount"] = request.StartAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartBizTime))
            {
                query["StartBizTime"] = request.StartBizTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSearchTime))
            {
                query["StartSearchTime"] = request.StartSearchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEvaluateList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEvaluateListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the orders for which you want to apply for invoices.
         *
         * @param request QueryEvaluateListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEvaluateListResponse
         */
        public async Task<QueryEvaluateListResponse> QueryEvaluateListWithOptionsAsync(QueryEvaluateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillCycle))
            {
                query["BillCycle"] = request.BillCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypeList))
            {
                query["BizTypeList"] = request.BizTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndAmount))
            {
                query["EndAmount"] = request.EndAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndBizTime))
            {
                query["EndBizTime"] = request.EndBizTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndSearchTime))
            {
                query["EndSearchTime"] = request.EndSearchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartAmount))
            {
                query["StartAmount"] = request.StartAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartBizTime))
            {
                query["StartBizTime"] = request.StartBizTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSearchTime))
            {
                query["StartSearchTime"] = request.StartSearchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEvaluateList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEvaluateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the orders for which you want to apply for invoices.
         *
         * @param request QueryEvaluateListRequest
         * @return QueryEvaluateListResponse
         */
        public QueryEvaluateListResponse QueryEvaluateList(QueryEvaluateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEvaluateListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the orders for which you want to apply for invoices.
         *
         * @param request QueryEvaluateListRequest
         * @return QueryEvaluateListResponse
         */
        public async Task<QueryEvaluateListResponse> QueryEvaluateListAsync(QueryEvaluateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEvaluateListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a financial account.
         *
         * @param request QueryFinancialAccountInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFinancialAccountInfoResponse
         */
        public QueryFinancialAccountInfoResponse QueryFinancialAccountInfoWithOptions(QueryFinancialAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFinancialAccountInfo",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFinancialAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a financial account.
         *
         * @param request QueryFinancialAccountInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFinancialAccountInfoResponse
         */
        public async Task<QueryFinancialAccountInfoResponse> QueryFinancialAccountInfoWithOptionsAsync(QueryFinancialAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFinancialAccountInfo",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFinancialAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a financial account.
         *
         * @param request QueryFinancialAccountInfoRequest
         * @return QueryFinancialAccountInfoResponse
         */
        public QueryFinancialAccountInfoResponse QueryFinancialAccountInfo(QueryFinancialAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFinancialAccountInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a financial account.
         *
         * @param request QueryFinancialAccountInfoRequest
         * @return QueryFinancialAccountInfoResponse
         */
        public async Task<QueryFinancialAccountInfoResponse> QueryFinancialAccountInfoAsync(QueryFinancialAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFinancialAccountInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the bills of instances or billable items in a billing cycle.
         *
         * @description ##
         * *   This API operation has been upgraded to DescribeInstanceBill. We recommend that you call the [DescribeInstanceBill](https://help.aliyun.com/document_detail/209402.html) operation to query the bills of instances or billable items in a billing cycle. You can call the QueryInstanceBill operation to query a maximum of 50,000 data rows in a bill.
         * *   Instance bills are generated after bills are split. In most cases, the instance bills do not include data generated on the last day of the specified period.
         * *   The instance information changes within a billing cycle. The instance configurations and specifications and the time when the instance was used in the billing cycle are all recorded. For more information, see the corresponding bill details.
         * *   You can query the data generated in June 2020 or later for Cloud Communications services, and the data generated in November 2020 or later for Alibaba Cloud Domains.
         *
         * @param request QueryInstanceBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstanceBillResponse
         */
        public QueryInstanceBillResponse QueryInstanceBillWithOptions(QueryInstanceBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingDate))
            {
                query["BillingDate"] = request.BillingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBillingItem))
            {
                query["IsBillingItem"] = request.IsBillingItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceBillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the bills of instances or billable items in a billing cycle.
         *
         * @description ##
         * *   This API operation has been upgraded to DescribeInstanceBill. We recommend that you call the [DescribeInstanceBill](https://help.aliyun.com/document_detail/209402.html) operation to query the bills of instances or billable items in a billing cycle. You can call the QueryInstanceBill operation to query a maximum of 50,000 data rows in a bill.
         * *   Instance bills are generated after bills are split. In most cases, the instance bills do not include data generated on the last day of the specified period.
         * *   The instance information changes within a billing cycle. The instance configurations and specifications and the time when the instance was used in the billing cycle are all recorded. For more information, see the corresponding bill details.
         * *   You can query the data generated in June 2020 or later for Cloud Communications services, and the data generated in November 2020 or later for Alibaba Cloud Domains.
         *
         * @param request QueryInstanceBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstanceBillResponse
         */
        public async Task<QueryInstanceBillResponse> QueryInstanceBillWithOptionsAsync(QueryInstanceBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingDate))
            {
                query["BillingDate"] = request.BillingDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBillingItem))
            {
                query["IsBillingItem"] = request.IsBillingItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the bills of instances or billable items in a billing cycle.
         *
         * @description ##
         * *   This API operation has been upgraded to DescribeInstanceBill. We recommend that you call the [DescribeInstanceBill](https://help.aliyun.com/document_detail/209402.html) operation to query the bills of instances or billable items in a billing cycle. You can call the QueryInstanceBill operation to query a maximum of 50,000 data rows in a bill.
         * *   Instance bills are generated after bills are split. In most cases, the instance bills do not include data generated on the last day of the specified period.
         * *   The instance information changes within a billing cycle. The instance configurations and specifications and the time when the instance was used in the billing cycle are all recorded. For more information, see the corresponding bill details.
         * *   You can query the data generated in June 2020 or later for Cloud Communications services, and the data generated in November 2020 or later for Alibaba Cloud Domains.
         *
         * @param request QueryInstanceBillRequest
         * @return QueryInstanceBillResponse
         */
        public QueryInstanceBillResponse QueryInstanceBill(QueryInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceBillWithOptions(request, runtime);
        }

        /**
         * @summary Queries the bills of instances or billable items in a billing cycle.
         *
         * @description ##
         * *   This API operation has been upgraded to DescribeInstanceBill. We recommend that you call the [DescribeInstanceBill](https://help.aliyun.com/document_detail/209402.html) operation to query the bills of instances or billable items in a billing cycle. You can call the QueryInstanceBill operation to query a maximum of 50,000 data rows in a bill.
         * *   Instance bills are generated after bills are split. In most cases, the instance bills do not include data generated on the last day of the specified period.
         * *   The instance information changes within a billing cycle. The instance configurations and specifications and the time when the instance was used in the billing cycle are all recorded. For more information, see the corresponding bill details.
         * *   You can query the data generated in June 2020 or later for Cloud Communications services, and the data generated in November 2020 or later for Alibaba Cloud Domains.
         *
         * @param request QueryInstanceBillRequest
         * @return QueryInstanceBillResponse
         */
        public async Task<QueryInstanceBillResponse> QueryInstanceBillAsync(QueryInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceBillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries instances by tag.
         *
         * @param request QueryInstanceByTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstanceByTagResponse
         */
        public QueryInstanceByTagResponse QueryInstanceByTagWithOptions(QueryInstanceByTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceByTag",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceByTagResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries instances by tag.
         *
         * @param request QueryInstanceByTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstanceByTagResponse
         */
        public async Task<QueryInstanceByTagResponse> QueryInstanceByTagWithOptionsAsync(QueryInstanceByTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceByTag",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceByTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries instances by tag.
         *
         * @param request QueryInstanceByTagRequest
         * @return QueryInstanceByTagResponse
         */
        public QueryInstanceByTagResponse QueryInstanceByTag(QueryInstanceByTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceByTagWithOptions(request, runtime);
        }

        /**
         * @summary Queries instances by tag.
         *
         * @param request QueryInstanceByTagRequest
         * @return QueryInstanceByTagResponse
         */
        public async Task<QueryInstanceByTagResponse> QueryInstanceByTagAsync(QueryInstanceByTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceByTagWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The code of the service.
         *
         * @param request QueryInstanceGaapCostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstanceGaapCostResponse
         */
        public QueryInstanceGaapCostResponse QueryInstanceGaapCostWithOptions(QueryInstanceGaapCostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceGaapCost",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceGaapCostResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The code of the service.
         *
         * @param request QueryInstanceGaapCostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstanceGaapCostResponse
         */
        public async Task<QueryInstanceGaapCostResponse> QueryInstanceGaapCostWithOptionsAsync(QueryInstanceGaapCostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInstanceGaapCost",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceGaapCostResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The code of the service.
         *
         * @param request QueryInstanceGaapCostRequest
         * @return QueryInstanceGaapCostResponse
         */
        public QueryInstanceGaapCostResponse QueryInstanceGaapCost(QueryInstanceGaapCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceGaapCostWithOptions(request, runtime);
        }

        /**
         * @summary The code of the service.
         *
         * @param request QueryInstanceGaapCostRequest
         * @return QueryInstanceGaapCostResponse
         */
        public async Task<QueryInstanceGaapCostResponse> QueryInstanceGaapCostAsync(QueryInstanceGaapCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceGaapCostWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about invoice titles.
         *
         * @param request QueryInvoicingCustomerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInvoicingCustomerListResponse
         */
        public QueryInvoicingCustomerListResponse QueryInvoicingCustomerListWithOptions(QueryInvoicingCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInvoicingCustomerList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInvoicingCustomerListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about invoice titles.
         *
         * @param request QueryInvoicingCustomerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInvoicingCustomerListResponse
         */
        public async Task<QueryInvoicingCustomerListResponse> QueryInvoicingCustomerListWithOptionsAsync(QueryInvoicingCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInvoicingCustomerList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInvoicingCustomerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about invoice titles.
         *
         * @param request QueryInvoicingCustomerListRequest
         * @return QueryInvoicingCustomerListResponse
         */
        public QueryInvoicingCustomerListResponse QueryInvoicingCustomerList(QueryInvoicingCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInvoicingCustomerListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about invoice titles.
         *
         * @param request QueryInvoicingCustomerListRequest
         * @return QueryInvoicingCustomerListResponse
         */
        public async Task<QueryInvoicingCustomerListResponse> QueryInvoicingCustomerListAsync(QueryInvoicingCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInvoicingCustomerListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the orders of your Alibaba Cloud account or distributors. By default, orders within the last hour are queried. To query earlier orders, specify the CreateTimeStart and CreateTimeEnd parameters.
         *
         * @param request QueryOrdersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrdersResponse
         */
        public QueryOrdersResponse QueryOrdersWithOptions(QueryOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentStatus))
            {
                query["PaymentStatus"] = request.PaymentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrders",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrdersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the orders of your Alibaba Cloud account or distributors. By default, orders within the last hour are queried. To query earlier orders, specify the CreateTimeStart and CreateTimeEnd parameters.
         *
         * @param request QueryOrdersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOrdersResponse
         */
        public async Task<QueryOrdersResponse> QueryOrdersWithOptionsAsync(QueryOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                query["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentStatus))
            {
                query["PaymentStatus"] = request.PaymentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrders",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the orders of your Alibaba Cloud account or distributors. By default, orders within the last hour are queried. To query earlier orders, specify the CreateTimeStart and CreateTimeEnd parameters.
         *
         * @param request QueryOrdersRequest
         * @return QueryOrdersResponse
         */
        public QueryOrdersResponse QueryOrders(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrdersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the orders of your Alibaba Cloud account or distributors. By default, orders within the last hour are queried. To query earlier orders, specify the CreateTimeStart and CreateTimeEnd parameters.
         *
         * @param request QueryOrdersRequest
         * @return QueryOrdersResponse
         */
        public async Task<QueryOrdersResponse> QueryOrdersAsync(QueryOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrdersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries, by relationship ID, permissions granted to accounts between which a management-member relationship is established.
         *
         * @param request QueryPermissionListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPermissionListResponse
         */
        public QueryPermissionListResponse QueryPermissionListWithOptions(QueryPermissionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["RelationId"] = request.RelationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPermissionList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPermissionListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries, by relationship ID, permissions granted to accounts between which a management-member relationship is established.
         *
         * @param request QueryPermissionListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPermissionListResponse
         */
        public async Task<QueryPermissionListResponse> QueryPermissionListWithOptionsAsync(QueryPermissionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["RelationId"] = request.RelationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPermissionList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPermissionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries, by relationship ID, permissions granted to accounts between which a management-member relationship is established.
         *
         * @param request QueryPermissionListRequest
         * @return QueryPermissionListResponse
         */
        public QueryPermissionListResponse QueryPermissionList(QueryPermissionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPermissionListWithOptions(request, runtime);
        }

        /**
         * @summary Queries, by relationship ID, permissions granted to accounts between which a management-member relationship is established.
         *
         * @param request QueryPermissionListRequest
         * @return QueryPermissionListResponse
         */
        public async Task<QueryPermissionListResponse> QueryPermissionListAsync(QueryPermissionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPermissionListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries prepaid cards.
         *
         * @param request QueryPrepaidCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPrepaidCardsResponse
         */
        public QueryPrepaidCardsResponse QueryPrepaidCardsWithOptions(QueryPrepaidCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveOrNot))
            {
                query["EffectiveOrNot"] = request.EffectiveOrNot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeEnd))
            {
                query["ExpiryTimeEnd"] = request.ExpiryTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeStart))
            {
                query["ExpiryTimeStart"] = request.ExpiryTimeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPrepaidCards",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPrepaidCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries prepaid cards.
         *
         * @param request QueryPrepaidCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPrepaidCardsResponse
         */
        public async Task<QueryPrepaidCardsResponse> QueryPrepaidCardsWithOptionsAsync(QueryPrepaidCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveOrNot))
            {
                query["EffectiveOrNot"] = request.EffectiveOrNot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeEnd))
            {
                query["ExpiryTimeEnd"] = request.ExpiryTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeStart))
            {
                query["ExpiryTimeStart"] = request.ExpiryTimeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPrepaidCards",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPrepaidCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries prepaid cards.
         *
         * @param request QueryPrepaidCardsRequest
         * @return QueryPrepaidCardsResponse
         */
        public QueryPrepaidCardsResponse QueryPrepaidCards(QueryPrepaidCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPrepaidCardsWithOptions(request, runtime);
        }

        /**
         * @summary Queries prepaid cards.
         *
         * @param request QueryPrepaidCardsRequest
         * @return QueryPrepaidCardsResponse
         */
        public async Task<QueryPrepaidCardsResponse> QueryPrepaidCardsAsync(QueryPrepaidCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPrepaidCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the billable items of a service.
         *
         * @description You can call this operation to query the billable items of a service. A billable item is the minimum unit used to calculate costs.
         *
         * @param request QueryPriceEntityListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPriceEntityListResponse
         */
        public QueryPriceEntityListResponse QueryPriceEntityListWithOptions(QueryPriceEntityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPriceEntityList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPriceEntityListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the billable items of a service.
         *
         * @description You can call this operation to query the billable items of a service. A billable item is the minimum unit used to calculate costs.
         *
         * @param request QueryPriceEntityListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPriceEntityListResponse
         */
        public async Task<QueryPriceEntityListResponse> QueryPriceEntityListWithOptionsAsync(QueryPriceEntityListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPriceEntityList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPriceEntityListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the billable items of a service.
         *
         * @description You can call this operation to query the billable items of a service. A billable item is the minimum unit used to calculate costs.
         *
         * @param request QueryPriceEntityListRequest
         * @return QueryPriceEntityListResponse
         */
        public QueryPriceEntityListResponse QueryPriceEntityList(QueryPriceEntityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPriceEntityListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the billable items of a service.
         *
         * @description You can call this operation to query the billable items of a service. A billable item is the minimum unit used to calculate costs.
         *
         * @param request QueryPriceEntityListRequest
         * @return QueryPriceEntityListResponse
         */
        public async Task<QueryPriceEntityListResponse> QueryPriceEntityListAsync(QueryPriceEntityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPriceEntityListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about all Alibaba Cloud services.
         *
         * @param request QueryProductListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProductListResponse
         */
        public QueryProductListResponse QueryProductListWithOptions(QueryProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTotalCount))
            {
                query["QueryTotalCount"] = request.QueryTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProductList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProductListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all Alibaba Cloud services.
         *
         * @param request QueryProductListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProductListResponse
         */
        public async Task<QueryProductListResponse> QueryProductListWithOptionsAsync(QueryProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTotalCount))
            {
                query["QueryTotalCount"] = request.QueryTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProductList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProductListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all Alibaba Cloud services.
         *
         * @param request QueryProductListRequest
         * @return QueryProductListResponse
         */
        public QueryProductListResponse QueryProductList(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about all Alibaba Cloud services.
         *
         * @param request QueryProductListRequest
         * @return QueryProductListResponse
         */
        public async Task<QueryProductListResponse> QueryProductListAsync(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the usage details of a reserved instance (RI).
         *
         * @param request QueryRIUtilizationDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRIUtilizationDetailResponse
         */
        public QueryRIUtilizationDetailResponse QueryRIUtilizationDetailWithOptions(QueryRIUtilizationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductedInstanceId))
            {
                query["DeductedInstanceId"] = request.DeductedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSpec))
            {
                query["InstanceSpec"] = request.InstanceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RICommodityCode))
            {
                query["RICommodityCode"] = request.RICommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RIInstanceId))
            {
                query["RIInstanceId"] = request.RIInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRIUtilizationDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRIUtilizationDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the usage details of a reserved instance (RI).
         *
         * @param request QueryRIUtilizationDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRIUtilizationDetailResponse
         */
        public async Task<QueryRIUtilizationDetailResponse> QueryRIUtilizationDetailWithOptionsAsync(QueryRIUtilizationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductedInstanceId))
            {
                query["DeductedInstanceId"] = request.DeductedInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceSpec))
            {
                query["InstanceSpec"] = request.InstanceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RICommodityCode))
            {
                query["RICommodityCode"] = request.RICommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RIInstanceId))
            {
                query["RIInstanceId"] = request.RIInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRIUtilizationDetail",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRIUtilizationDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the usage details of a reserved instance (RI).
         *
         * @param request QueryRIUtilizationDetailRequest
         * @return QueryRIUtilizationDetailResponse
         */
        public QueryRIUtilizationDetailResponse QueryRIUtilizationDetail(QueryRIUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRIUtilizationDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the usage details of a reserved instance (RI).
         *
         * @param request QueryRIUtilizationDetailRequest
         * @return QueryRIUtilizationDetailResponse
         */
        public async Task<QueryRIUtilizationDetailResponse> QueryRIUtilizationDetailAsync(QueryRIUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRIUtilizationDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a redemption coupon.
         *
         * @param request QueryRedeemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRedeemResponse
         */
        public QueryRedeemResponse QueryRedeemWithOptions(QueryRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRedeem",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRedeemResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a redemption coupon.
         *
         * @param request QueryRedeemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRedeemResponse
         */
        public async Task<QueryRedeemResponse> QueryRedeemWithOptionsAsync(QueryRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRedeem",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRedeemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a redemption coupon.
         *
         * @param request QueryRedeemRequest
         * @return QueryRedeemResponse
         */
        public QueryRedeemResponse QueryRedeem(QueryRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRedeemWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a redemption coupon.
         *
         * @param request QueryRedeemRequest
         * @return QueryRedeemResponse
         */
        public async Task<QueryRedeemResponse> QueryRedeemAsync(QueryRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRedeemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the members of a management account.
         *
         * @param request QueryRelationListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRelationListResponse
         */
        public QueryRelationListResponse QueryRelationListWithOptions(QueryRelationListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRelationList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRelationListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the members of a management account.
         *
         * @param request QueryRelationListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRelationListResponse
         */
        public async Task<QueryRelationListResponse> QueryRelationListWithOptionsAsync(QueryRelationListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRelationList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRelationListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the members of a management account.
         *
         * @param request QueryRelationListRequest
         * @return QueryRelationListResponse
         */
        public QueryRelationListResponse QueryRelationList(QueryRelationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRelationListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the members of a management account.
         *
         * @param request QueryRelationListRequest
         * @return QueryRelationListResponse
         */
        public async Task<QueryRelationListResponse> QueryRelationListAsync(QueryRelationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRelationListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
         *
         * @param request QueryResellerAvailableQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryResellerAvailableQuotaResponse
         */
        public QueryResellerAvailableQuotaResponse QueryResellerAvailableQuotaWithOptions(QueryResellerAvailableQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCodes))
            {
                query["ItemCodes"] = request.ItemCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResellerAvailableQuota",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResellerAvailableQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
         *
         * @param request QueryResellerAvailableQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryResellerAvailableQuotaResponse
         */
        public async Task<QueryResellerAvailableQuotaResponse> QueryResellerAvailableQuotaWithOptionsAsync(QueryResellerAvailableQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCodes))
            {
                query["ItemCodes"] = request.ItemCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResellerAvailableQuota",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResellerAvailableQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
         *
         * @param request QueryResellerAvailableQuotaRequest
         * @return QueryResellerAvailableQuotaResponse
         */
        public QueryResellerAvailableQuotaResponse QueryResellerAvailableQuota(QueryResellerAvailableQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryResellerAvailableQuotaWithOptions(request, runtime);
        }

        /**
         * @summary Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call failed.
         *
         * @param request QueryResellerAvailableQuotaRequest
         * @return QueryResellerAvailableQuotaResponse
         */
        public async Task<QueryResellerAvailableQuotaResponse> QueryResellerAvailableQuotaAsync(QueryResellerAvailableQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryResellerAvailableQuotaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户的信控预警阀值,该接口暂未测试启用
         *
         * @param request QueryResellerUserAlarmThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryResellerUserAlarmThresholdResponse
         */
        public QueryResellerUserAlarmThresholdResponse QueryResellerUserAlarmThresholdWithOptions(QueryResellerUserAlarmThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmType))
            {
                query["AlarmType"] = request.AlarmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResellerUserAlarmThreshold",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResellerUserAlarmThresholdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询用户的信控预警阀值,该接口暂未测试启用
         *
         * @param request QueryResellerUserAlarmThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryResellerUserAlarmThresholdResponse
         */
        public async Task<QueryResellerUserAlarmThresholdResponse> QueryResellerUserAlarmThresholdWithOptionsAsync(QueryResellerUserAlarmThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmType))
            {
                query["AlarmType"] = request.AlarmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResellerUserAlarmThreshold",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResellerUserAlarmThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户的信控预警阀值,该接口暂未测试启用
         *
         * @param request QueryResellerUserAlarmThresholdRequest
         * @return QueryResellerUserAlarmThresholdResponse
         */
        public QueryResellerUserAlarmThresholdResponse QueryResellerUserAlarmThreshold(QueryResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryResellerUserAlarmThresholdWithOptions(request, runtime);
        }

        /**
         * @summary 查询用户的信控预警阀值,该接口暂未测试启用
         *
         * @param request QueryResellerUserAlarmThresholdRequest
         * @return QueryResellerUserAlarmThresholdResponse
         */
        public async Task<QueryResellerUserAlarmThresholdResponse> QueryResellerUserAlarmThresholdAsync(QueryResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryResellerUserAlarmThresholdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the instances of a resource plan. You can query the resource plans that are expired within one year.
         *
         * @param request QueryResourcePackageInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryResourcePackageInstancesResponse
         */
        public QueryResourcePackageInstancesResponse QueryResourcePackageInstancesWithOptions(QueryResourcePackageInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeEnd))
            {
                query["ExpiryTimeEnd"] = request.ExpiryTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeStart))
            {
                query["ExpiryTimeStart"] = request.ExpiryTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePartner))
            {
                query["IncludePartner"] = request.IncludePartner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResourcePackageInstances",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourcePackageInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the instances of a resource plan. You can query the resource plans that are expired within one year.
         *
         * @param request QueryResourcePackageInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryResourcePackageInstancesResponse
         */
        public async Task<QueryResourcePackageInstancesResponse> QueryResourcePackageInstancesWithOptionsAsync(QueryResourcePackageInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeEnd))
            {
                query["ExpiryTimeEnd"] = request.ExpiryTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiryTimeStart))
            {
                query["ExpiryTimeStart"] = request.ExpiryTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePartner))
            {
                query["IncludePartner"] = request.IncludePartner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResourcePackageInstances",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourcePackageInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the instances of a resource plan. You can query the resource plans that are expired within one year.
         *
         * @param request QueryResourcePackageInstancesRequest
         * @return QueryResourcePackageInstancesResponse
         */
        public QueryResourcePackageInstancesResponse QueryResourcePackageInstances(QueryResourcePackageInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryResourcePackageInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the instances of a resource plan. You can query the resource plans that are expired within one year.
         *
         * @param request QueryResourcePackageInstancesRequest
         * @return QueryResourcePackageInstancesResponse
         */
        public async Task<QueryResourcePackageInstancesResponse> QueryResourcePackageInstancesAsync(QueryResourcePackageInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryResourcePackageInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the deduction details of savings plans.
         *
         * @param request QuerySavingsPlansDeductLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySavingsPlansDeductLogResponse
         */
        public QuerySavingsPlansDeductLogResponse QuerySavingsPlansDeductLogWithOptions(QuerySavingsPlansDeductLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySavingsPlansDeductLog",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySavingsPlansDeductLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the deduction details of savings plans.
         *
         * @param request QuerySavingsPlansDeductLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySavingsPlansDeductLogResponse
         */
        public async Task<QuerySavingsPlansDeductLogResponse> QuerySavingsPlansDeductLogWithOptionsAsync(QuerySavingsPlansDeductLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySavingsPlansDeductLog",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySavingsPlansDeductLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the deduction details of savings plans.
         *
         * @param request QuerySavingsPlansDeductLogRequest
         * @return QuerySavingsPlansDeductLogResponse
         */
        public QuerySavingsPlansDeductLogResponse QuerySavingsPlansDeductLog(QuerySavingsPlansDeductLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySavingsPlansDeductLogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the deduction details of savings plans.
         *
         * @param request QuerySavingsPlansDeductLogRequest
         * @return QuerySavingsPlansDeductLogResponse
         */
        public async Task<QuerySavingsPlansDeductLogResponse> QuerySavingsPlansDeductLogAsync(QuerySavingsPlansDeductLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySavingsPlansDeductLogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries discounts on savings plans.
         *
         * @param request QuerySavingsPlansDiscountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySavingsPlansDiscountResponse
         */
        public QuerySavingsPlansDiscountResponse QuerySavingsPlansDiscountWithOptions(QuerySavingsPlansDiscountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySavingsPlansDiscount",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySavingsPlansDiscountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries discounts on savings plans.
         *
         * @param request QuerySavingsPlansDiscountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySavingsPlansDiscountResponse
         */
        public async Task<QuerySavingsPlansDiscountResponse> QuerySavingsPlansDiscountWithOptionsAsync(QuerySavingsPlansDiscountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySavingsPlansDiscount",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySavingsPlansDiscountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries discounts on savings plans.
         *
         * @param request QuerySavingsPlansDiscountRequest
         * @return QuerySavingsPlansDiscountResponse
         */
        public QuerySavingsPlansDiscountResponse QuerySavingsPlansDiscount(QuerySavingsPlansDiscountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySavingsPlansDiscountWithOptions(request, runtime);
        }

        /**
         * @summary Queries discounts on savings plans.
         *
         * @param request QuerySavingsPlansDiscountRequest
         * @return QuerySavingsPlansDiscountResponse
         */
        public async Task<QuerySavingsPlansDiscountResponse> QuerySavingsPlansDiscountAsync(QuerySavingsPlansDiscountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySavingsPlansDiscountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about savings plan instances of the current user.
         *
         * @param request QuerySavingsPlansInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySavingsPlansInstanceResponse
         */
        public QuerySavingsPlansInstanceResponse QuerySavingsPlansInstanceWithOptions(QuerySavingsPlansInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySavingsPlansInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySavingsPlansInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about savings plan instances of the current user.
         *
         * @param request QuerySavingsPlansInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySavingsPlansInstanceResponse
         */
        public async Task<QuerySavingsPlansInstanceResponse> QuerySavingsPlansInstanceWithOptionsAsync(QuerySavingsPlansInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locale))
            {
                query["Locale"] = request.Locale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySavingsPlansInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySavingsPlansInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about savings plan instances of the current user.
         *
         * @param request QuerySavingsPlansInstanceRequest
         * @return QuerySavingsPlansInstanceResponse
         */
        public QuerySavingsPlansInstanceResponse QuerySavingsPlansInstance(QuerySavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySavingsPlansInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about savings plan instances of the current user.
         *
         * @param request QuerySavingsPlansInstanceRequest
         * @return QuerySavingsPlansInstanceResponse
         */
        public async Task<QuerySavingsPlansInstanceResponse> QuerySavingsPlansInstanceAsync(QuerySavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySavingsPlansInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The code of the service.
         *
         * @param request QuerySettleBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySettleBillResponse
         */
        public QuerySettleBillResponse QuerySettleBillWithOptions(QuerySettleBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDisplayLocalCurrency))
            {
                query["IsDisplayLocalCurrency"] = request.IsDisplayLocalCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordID))
            {
                query["RecordID"] = request.RecordID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySettleBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySettleBillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The code of the service.
         *
         * @param request QuerySettleBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySettleBillResponse
         */
        public async Task<QuerySettleBillResponse> QuerySettleBillWithOptionsAsync(QuerySettleBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDisplayLocalCurrency))
            {
                query["IsDisplayLocalCurrency"] = request.IsDisplayLocalCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHideZeroCharge))
            {
                query["IsHideZeroCharge"] = request.IsHideZeroCharge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordID))
            {
                query["RecordID"] = request.RecordID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySettleBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySettleBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The code of the service.
         *
         * @param request QuerySettleBillRequest
         * @return QuerySettleBillResponse
         */
        public QuerySettleBillResponse QuerySettleBill(QuerySettleBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySettleBillWithOptions(request, runtime);
        }

        /**
         * @summary The code of the service.
         *
         * @param request QuerySettleBillRequest
         * @return QuerySettleBillResponse
         */
        public async Task<QuerySettleBillResponse> QuerySettleBillAsync(QuerySettleBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySettleBillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the stock keeping units (SKUs) of a service. In most cases, a service has one or more SKUs. A service may even have tens of thousands of SKUs. You can call this operation to query the SKUs of a specific service and the prices of the SKUs. You can configure request parameters to query the specified SKUs based on the configurations of the SKUs.
         *
         * @param tmpReq QuerySkuPriceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySkuPriceListResponse
         */
        public QuerySkuPriceListResponse QuerySkuPriceListWithOptions(QuerySkuPriceListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySkuPriceListShrinkRequest request = new QuerySkuPriceListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PriceFactorConditionMap))
            {
                request.PriceFactorConditionMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PriceFactorConditionMap, "PriceFactorConditionMap", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySkuPriceList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySkuPriceListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the stock keeping units (SKUs) of a service. In most cases, a service has one or more SKUs. A service may even have tens of thousands of SKUs. You can call this operation to query the SKUs of a specific service and the prices of the SKUs. You can configure request parameters to query the specified SKUs based on the configurations of the SKUs.
         *
         * @param tmpReq QuerySkuPriceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySkuPriceListResponse
         */
        public async Task<QuerySkuPriceListResponse> QuerySkuPriceListWithOptionsAsync(QuerySkuPriceListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySkuPriceListShrinkRequest request = new QuerySkuPriceListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PriceFactorConditionMap))
            {
                request.PriceFactorConditionMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PriceFactorConditionMap, "PriceFactorConditionMap", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySkuPriceList",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySkuPriceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the stock keeping units (SKUs) of a service. In most cases, a service has one or more SKUs. A service may even have tens of thousands of SKUs. You can call this operation to query the SKUs of a specific service and the prices of the SKUs. You can configure request parameters to query the specified SKUs based on the configurations of the SKUs.
         *
         * @param request QuerySkuPriceListRequest
         * @return QuerySkuPriceListResponse
         */
        public QuerySkuPriceListResponse QuerySkuPriceList(QuerySkuPriceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySkuPriceListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the stock keeping units (SKUs) of a service. In most cases, a service has one or more SKUs. A service may even have tens of thousands of SKUs. You can call this operation to query the SKUs of a specific service and the prices of the SKUs. You can configure request parameters to query the specified SKUs based on the configurations of the SKUs.
         *
         * @param request QuerySkuPriceListRequest
         * @return QuerySkuPriceListResponse
         */
        public async Task<QuerySkuPriceListResponse> QuerySkuPriceListAsync(QuerySkuPriceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySkuPriceListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries split bills.
         *
         * @description *   This API operation has been upgraded to DescribeSplitItemBill. We recommend that you call the [DescribeSplitItemBill](https://help.aliyun.com/document_detail/208169.html) operation to query split bills. You can call the QuerySplitItemBill operation to query a maximum of 50,000 data rows in a bill.
         * *   The data queried by calling the QuerySplitItemBill operation is consistent with the data that is displayed for the specified billing cycle on the Split Bill page in User Center.
         * *   You can call this operation to query split bills generated within the last 12 months.
         * *   This operation returns split bills only after you activate the [Split Bill](https://usercenter2.aliyun.com/finance/split-bill) service in User Center.
         *
         * @param request QuerySplitItemBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySplitItemBillResponse
         */
        public QuerySplitItemBillResponse QuerySplitItemBillWithOptions(QuerySplitItemBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySplitItemBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySplitItemBillResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries split bills.
         *
         * @description *   This API operation has been upgraded to DescribeSplitItemBill. We recommend that you call the [DescribeSplitItemBill](https://help.aliyun.com/document_detail/208169.html) operation to query split bills. You can call the QuerySplitItemBill operation to query a maximum of 50,000 data rows in a bill.
         * *   The data queried by calling the QuerySplitItemBill operation is consistent with the data that is displayed for the specified billing cycle on the Split Bill page in User Center.
         * *   You can call this operation to query split bills generated within the last 12 months.
         * *   This operation returns split bills only after you activate the [Split Bill](https://usercenter2.aliyun.com/finance/split-bill) service in User Center.
         *
         * @param request QuerySplitItemBillRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySplitItemBillResponse
         */
        public async Task<QuerySplitItemBillResponse> QuerySplitItemBillWithOptionsAsync(QuerySplitItemBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySplitItemBill",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySplitItemBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries split bills.
         *
         * @description *   This API operation has been upgraded to DescribeSplitItemBill. We recommend that you call the [DescribeSplitItemBill](https://help.aliyun.com/document_detail/208169.html) operation to query split bills. You can call the QuerySplitItemBill operation to query a maximum of 50,000 data rows in a bill.
         * *   The data queried by calling the QuerySplitItemBill operation is consistent with the data that is displayed for the specified billing cycle on the Split Bill page in User Center.
         * *   You can call this operation to query split bills generated within the last 12 months.
         * *   This operation returns split bills only after you activate the [Split Bill](https://usercenter2.aliyun.com/finance/split-bill) service in User Center.
         *
         * @param request QuerySplitItemBillRequest
         * @return QuerySplitItemBillResponse
         */
        public QuerySplitItemBillResponse QuerySplitItemBill(QuerySplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySplitItemBillWithOptions(request, runtime);
        }

        /**
         * @summary Queries split bills.
         *
         * @description *   This API operation has been upgraded to DescribeSplitItemBill. We recommend that you call the [DescribeSplitItemBill](https://help.aliyun.com/document_detail/208169.html) operation to query split bills. You can call the QuerySplitItemBill operation to query a maximum of 50,000 data rows in a bill.
         * *   The data queried by calling the QuerySplitItemBill operation is consistent with the data that is displayed for the specified billing cycle on the Split Bill page in User Center.
         * *   You can call this operation to query split bills generated within the last 12 months.
         * *   This operation returns split bills only after you activate the [Split Bill](https://usercenter2.aliyun.com/finance/split-bill) service in User Center.
         *
         * @param request QuerySplitItemBillRequest
         * @return QuerySplitItemBillResponse
         */
        public async Task<QuerySplitItemBillResponse> QuerySplitItemBillAsync(QuerySplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySplitItemBillWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the usage data of an Alibaba Cloud service.
         *
         * @description You can call this operation to query the usage data of an Alibaba Cloud service. Take note of the following items:
         * *   The service code that you specify for querying the usage data of a specific Alibaba Cloud service must be valid. You can query the usage data by hour or by day.
         * *   The time that you specify must follow the ISO8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
         *     *   Latency exists in data pushes. Therefore, if you set the DataType parameter to Hour, the integrity of usage data recorded in the last 24 hours can be ensured. If you set the DataType parameter to Day, the integrity of usage data recorded in the last two days can be ensured.
         *     *   You can query the usage data that is recorded in the last quarter.
         *
         * @param request QueryUserOmsDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserOmsDataResponse
         */
        public QueryUserOmsDataResponse QueryUserOmsDataWithOptions(QueryUserOmsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["Table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserOmsData",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserOmsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the usage data of an Alibaba Cloud service.
         *
         * @description You can call this operation to query the usage data of an Alibaba Cloud service. Take note of the following items:
         * *   The service code that you specify for querying the usage data of a specific Alibaba Cloud service must be valid. You can query the usage data by hour or by day.
         * *   The time that you specify must follow the ISO8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
         *     *   Latency exists in data pushes. Therefore, if you set the DataType parameter to Hour, the integrity of usage data recorded in the last 24 hours can be ensured. If you set the DataType parameter to Day, the integrity of usage data recorded in the last two days can be ensured.
         *     *   You can query the usage data that is recorded in the last quarter.
         *
         * @param request QueryUserOmsDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserOmsDataResponse
         */
        public async Task<QueryUserOmsDataResponse> QueryUserOmsDataWithOptionsAsync(QueryUserOmsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["Table"] = request.Table;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserOmsData",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserOmsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the usage data of an Alibaba Cloud service.
         *
         * @description You can call this operation to query the usage data of an Alibaba Cloud service. Take note of the following items:
         * *   The service code that you specify for querying the usage data of a specific Alibaba Cloud service must be valid. You can query the usage data by hour or by day.
         * *   The time that you specify must follow the ISO8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
         *     *   Latency exists in data pushes. Therefore, if you set the DataType parameter to Hour, the integrity of usage data recorded in the last 24 hours can be ensured. If you set the DataType parameter to Day, the integrity of usage data recorded in the last two days can be ensured.
         *     *   You can query the usage data that is recorded in the last quarter.
         *
         * @param request QueryUserOmsDataRequest
         * @return QueryUserOmsDataResponse
         */
        public QueryUserOmsDataResponse QueryUserOmsData(QueryUserOmsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserOmsDataWithOptions(request, runtime);
        }

        /**
         * @summary Queries the usage data of an Alibaba Cloud service.
         *
         * @description You can call this operation to query the usage data of an Alibaba Cloud service. Take note of the following items:
         * *   The service code that you specify for querying the usage data of a specific Alibaba Cloud service must be valid. You can query the usage data by hour or by day.
         * *   The time that you specify must follow the ISO8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.
         *     *   Latency exists in data pushes. Therefore, if you set the DataType parameter to Hour, the integrity of usage data recorded in the last 24 hours can be ensured. If you set the DataType parameter to Day, the integrity of usage data recorded in the last two days can be ensured.
         *     *   You can query the usage data that is recorded in the last quarter.
         *
         * @param request QueryUserOmsDataRequest
         * @return QueryUserOmsDataResponse
         */
        public async Task<QueryUserOmsDataResponse> QueryUserOmsDataAsync(QueryUserOmsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserOmsDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unsubscribes from an instance that is no longer needed.
         *
         * @description 1.  Refunds are applicable only for the actual paid amount. Vouchers used for the purchase are non-refundable.
         * 2.  Check the information about unsubscription and confirm the unsubscription terms and refundable amount. The resource that is unsubscribed cannot be restored.
         * 3.  For more information, see [Rules for unsubscribing from resources](https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules).
         *
         * @param request RefundInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefundInstanceResponse
         */
        public RefundInstanceResponse RefundInstanceWithOptions(RefundInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediatelyRelease))
            {
                query["ImmediatelyRelease"] = request.ImmediatelyRelease;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unsubscribes from an instance that is no longer needed.
         *
         * @description 1.  Refunds are applicable only for the actual paid amount. Vouchers used for the purchase are non-refundable.
         * 2.  Check the information about unsubscription and confirm the unsubscription terms and refundable amount. The resource that is unsubscribed cannot be restored.
         * 3.  For more information, see [Rules for unsubscribing from resources](https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules).
         *
         * @param request RefundInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefundInstanceResponse
         */
        public async Task<RefundInstanceResponse> RefundInstanceWithOptionsAsync(RefundInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediatelyRelease))
            {
                query["ImmediatelyRelease"] = request.ImmediatelyRelease;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unsubscribes from an instance that is no longer needed.
         *
         * @description 1.  Refunds are applicable only for the actual paid amount. Vouchers used for the purchase are non-refundable.
         * 2.  Check the information about unsubscription and confirm the unsubscription terms and refundable amount. The resource that is unsubscribed cannot be restored.
         * 3.  For more information, see [Rules for unsubscribing from resources](https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules).
         *
         * @param request RefundInstanceRequest
         * @return RefundInstanceResponse
         */
        public RefundInstanceResponse RefundInstance(RefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefundInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Unsubscribes from an instance that is no longer needed.
         *
         * @description 1.  Refunds are applicable only for the actual paid amount. Vouchers used for the purchase are non-refundable.
         * 2.  Check the information about unsubscription and confirm the unsubscription terms and refundable amount. The resource that is unsubscribed cannot be restored.
         * 3.  For more information, see [Rules for unsubscribing from resources](https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules).
         *
         * @param request RefundInstanceRequest
         * @return RefundInstanceResponse
         */
        public async Task<RefundInstanceResponse> RefundInstanceAsync(RefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefundInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases instances by Virtual Network Operators (VNOs).
         *
         * @description This operation is provided for only VNOs to release instances. If a non-specific VNO calls this operation, the request is blocked.
         *
         * @param request ReleaseInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseInstanceResponse
         */
        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewStatus))
            {
                query["RenewStatus"] = request.RenewStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases instances by Virtual Network Operators (VNOs).
         *
         * @description This operation is provided for only VNOs to release instances. If a non-specific VNO calls this operation, the request is blocked.
         *
         * @param request ReleaseInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseInstanceResponse
         */
        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewStatus))
            {
                query["RenewStatus"] = request.RenewStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases instances by Virtual Network Operators (VNOs).
         *
         * @description This operation is provided for only VNOs to release instances. If a non-specific VNO calls this operation, the request is blocked.
         *
         * @param request ReleaseInstanceRequest
         * @return ReleaseInstanceResponse
         */
        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Releases instances by Virtual Network Operators (VNOs).
         *
         * @description This operation is provided for only VNOs to release instances. If a non-specific VNO calls this operation, the request is blocked.
         *
         * @param request ReleaseInstanceRequest
         * @return ReleaseInstanceResponse
         */
        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Terminates a financial relationship between the management account and a member.
         *
         * @param request RelieveAccountRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RelieveAccountRelationResponse
         */
        public RelieveAccountRelationResponse RelieveAccountRelationWithOptions(RelieveAccountRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildUserId))
            {
                query["ChildUserId"] = request.ChildUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserId))
            {
                query["ParentUserId"] = request.ParentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["RelationId"] = request.RelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RelieveAccountRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelieveAccountRelationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Terminates a financial relationship between the management account and a member.
         *
         * @param request RelieveAccountRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RelieveAccountRelationResponse
         */
        public async Task<RelieveAccountRelationResponse> RelieveAccountRelationWithOptionsAsync(RelieveAccountRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildUserId))
            {
                query["ChildUserId"] = request.ChildUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentUserId))
            {
                query["ParentUserId"] = request.ParentUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationId))
            {
                query["RelationId"] = request.RelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["RelationType"] = request.RelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RelieveAccountRelation",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelieveAccountRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Terminates a financial relationship between the management account and a member.
         *
         * @param request RelieveAccountRelationRequest
         * @return RelieveAccountRelationResponse
         */
        public RelieveAccountRelationResponse RelieveAccountRelation(RelieveAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RelieveAccountRelationWithOptions(request, runtime);
        }

        /**
         * @summary Terminates a financial relationship between the management account and a member.
         *
         * @param request RelieveAccountRelationRequest
         * @return RelieveAccountRelationResponse
         */
        public async Task<RelieveAccountRelationResponse> RelieveAccountRelationAsync(RelieveAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RelieveAccountRelationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 续费变配接口
         *
         * @param request RenewChangeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewChangeInstanceResponse
         */
        public RenewChangeInstanceResponse RenewChangeInstanceWithOptions(RenewChangeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["Parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewPeriod))
            {
                query["RenewPeriod"] = request.RenewPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewChangeInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewChangeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 续费变配接口
         *
         * @param request RenewChangeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewChangeInstanceResponse
         */
        public async Task<RenewChangeInstanceResponse> RenewChangeInstanceWithOptionsAsync(RenewChangeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["Parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewPeriod))
            {
                query["RenewPeriod"] = request.RenewPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewChangeInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewChangeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 续费变配接口
         *
         * @param request RenewChangeInstanceRequest
         * @return RenewChangeInstanceResponse
         */
        public RenewChangeInstanceResponse RenewChangeInstance(RenewChangeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewChangeInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 续费变配接口
         *
         * @param request RenewChangeInstanceRequest
         * @return RenewChangeInstanceResponse
         */
        public async Task<RenewChangeInstanceResponse> RenewChangeInstanceAsync(RenewChangeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewChangeInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Renews a specified instance. You cannot call this operation to renew Elastic Compute Service (ECS) instances, ApsaraDB RDS instances, or ApsaraDB for Redis instances. To renew these types of instances, call the dedicated operation of the corresponding service.
         *
         * @param request RenewInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewInstanceResponse
         */
        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewPeriod))
            {
                query["RenewPeriod"] = request.RenewPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Renews a specified instance. You cannot call this operation to renew Elastic Compute Service (ECS) instances, ApsaraDB RDS instances, or ApsaraDB for Redis instances. To renew these types of instances, call the dedicated operation of the corresponding service.
         *
         * @param request RenewInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewInstanceResponse
         */
        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewPeriod))
            {
                query["RenewPeriod"] = request.RenewPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Renews a specified instance. You cannot call this operation to renew Elastic Compute Service (ECS) instances, ApsaraDB RDS instances, or ApsaraDB for Redis instances. To renew these types of instances, call the dedicated operation of the corresponding service.
         *
         * @param request RenewInstanceRequest
         * @return RenewInstanceResponse
         */
        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Renews a specified instance. You cannot call this operation to renew Elastic Compute Service (ECS) instances, ApsaraDB RDS instances, or ApsaraDB for Redis instances. To renew these types of instances, call the dedicated operation of the corresponding service.
         *
         * @param request RenewInstanceRequest
         * @return RenewInstanceResponse
         */
        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Renews a resource plan.
         *
         * @param request RenewResourcePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewResourcePackageResponse
         */
        public RenewResourcePackageResponse RenewResourcePackageWithOptions(RenewResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewResourcePackage",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewResourcePackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Renews a resource plan.
         *
         * @param request RenewResourcePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewResourcePackageResponse
         */
        public async Task<RenewResourcePackageResponse> RenewResourcePackageWithOptionsAsync(RenewResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewResourcePackage",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewResourcePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Renews a resource plan.
         *
         * @param request RenewResourcePackageRequest
         * @return RenewResourcePackageResponse
         */
        public RenewResourcePackageResponse RenewResourcePackage(RenewResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewResourcePackageWithOptions(request, runtime);
        }

        /**
         * @summary Renews a resource plan.
         *
         * @param request RenewResourcePackageRequest
         * @return RenewResourcePackageResponse
         */
        public async Task<RenewResourcePackageResponse> RenewResourcePackageAsync(RenewResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewResourcePackageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets an expiration date for all Elastic Compute Service (ECS) instances.
         *
         * @param request SetAllExpirationDayRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAllExpirationDayResponse
         */
        public SetAllExpirationDayResponse SetAllExpirationDayWithOptions(SetAllExpirationDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnifyExpireDay))
            {
                query["UnifyExpireDay"] = request.UnifyExpireDay;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAllExpirationDay",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAllExpirationDayResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets an expiration date for all Elastic Compute Service (ECS) instances.
         *
         * @param request SetAllExpirationDayRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAllExpirationDayResponse
         */
        public async Task<SetAllExpirationDayResponse> SetAllExpirationDayWithOptionsAsync(SetAllExpirationDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnifyExpireDay))
            {
                query["UnifyExpireDay"] = request.UnifyExpireDay;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAllExpirationDay",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAllExpirationDayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets an expiration date for all Elastic Compute Service (ECS) instances.
         *
         * @param request SetAllExpirationDayRequest
         * @return SetAllExpirationDayResponse
         */
        public SetAllExpirationDayResponse SetAllExpirationDay(SetAllExpirationDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAllExpirationDayWithOptions(request, runtime);
        }

        /**
         * @summary Sets an expiration date for all Elastic Compute Service (ECS) instances.
         *
         * @param request SetAllExpirationDayRequest
         * @return SetAllExpirationDayResponse
         */
        public async Task<SetAllExpirationDayResponse> SetAllExpirationDayAsync(SetAllExpirationDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAllExpirationDayWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables auto-renewal for an instance.
         *
         * @param request SetRenewalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRenewalResponse
         */
        public SetRenewalResponse SetRenewalWithOptions(SetRenewalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIDs))
            {
                query["InstanceIDs"] = request.InstanceIDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalPeriod))
            {
                query["RenewalPeriod"] = request.RenewalPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalPeriodUnit))
            {
                query["RenewalPeriodUnit"] = request.RenewalPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalStatus))
            {
                query["RenewalStatus"] = request.RenewalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRenewal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRenewalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables auto-renewal for an instance.
         *
         * @param request SetRenewalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRenewalResponse
         */
        public async Task<SetRenewalResponse> SetRenewalWithOptionsAsync(SetRenewalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIDs))
            {
                query["InstanceIDs"] = request.InstanceIDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalPeriod))
            {
                query["RenewalPeriod"] = request.RenewalPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalPeriodUnit))
            {
                query["RenewalPeriodUnit"] = request.RenewalPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalStatus))
            {
                query["RenewalStatus"] = request.RenewalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionType))
            {
                query["SubscriptionType"] = request.SubscriptionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRenewal",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRenewalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables auto-renewal for an instance.
         *
         * @param request SetRenewalRequest
         * @return SetRenewalResponse
         */
        public SetRenewalResponse SetRenewal(SetRenewalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRenewalWithOptions(request, runtime);
        }

        /**
         * @summary Enables auto-renewal for an instance.
         *
         * @param request SetRenewalRequest
         * @return SetRenewalResponse
         */
        public async Task<SetRenewalResponse> SetRenewalAsync(SetRenewalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRenewalWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SetResellerUserAlarmThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetResellerUserAlarmThresholdResponse
         */
        public SetResellerUserAlarmThresholdResponse SetResellerUserAlarmThresholdWithOptions(SetResellerUserAlarmThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmThresholds))
            {
                query["AlarmThresholds"] = request.AlarmThresholds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmType))
            {
                query["AlarmType"] = request.AlarmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetResellerUserAlarmThreshold",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetResellerUserAlarmThresholdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SetResellerUserAlarmThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetResellerUserAlarmThresholdResponse
         */
        public async Task<SetResellerUserAlarmThresholdResponse> SetResellerUserAlarmThresholdWithOptionsAsync(SetResellerUserAlarmThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmThresholds))
            {
                query["AlarmThresholds"] = request.AlarmThresholds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmType))
            {
                query["AlarmType"] = request.AlarmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetResellerUserAlarmThreshold",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetResellerUserAlarmThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SetResellerUserAlarmThresholdRequest
         * @return SetResellerUserAlarmThresholdResponse
         */
        public SetResellerUserAlarmThresholdResponse SetResellerUserAlarmThreshold(SetResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserAlarmThresholdWithOptions(request, runtime);
        }

        /**
         * @param request SetResellerUserAlarmThresholdRequest
         * @return SetResellerUserAlarmThresholdResponse
         */
        public async Task<SetResellerUserAlarmThresholdResponse> SetResellerUserAlarmThresholdAsync(SetResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserAlarmThresholdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modify the quota ledger and consumption ledger.
         *
         * @param request SetResellerUserQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetResellerUserQuotaResponse
         */
        public SetResellerUserQuotaResponse SetResellerUserQuotaWithOptions(SetResellerUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetResellerUserQuota",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetResellerUserQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modify the quota ledger and consumption ledger.
         *
         * @param request SetResellerUserQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetResellerUserQuotaResponse
         */
        public async Task<SetResellerUserQuotaResponse> SetResellerUserQuotaWithOptionsAsync(SetResellerUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetResellerUserQuota",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetResellerUserQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modify the quota ledger and consumption ledger.
         *
         * @param request SetResellerUserQuotaRequest
         * @return SetResellerUserQuotaResponse
         */
        public SetResellerUserQuotaResponse SetResellerUserQuota(SetResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserQuotaWithOptions(request, runtime);
        }

        /**
         * @summary Modify the quota ledger and consumption ledger.
         *
         * @param request SetResellerUserQuotaRequest
         * @return SetResellerUserQuotaResponse
         */
        public async Task<SetResellerUserQuotaResponse> SetResellerUserQuotaAsync(SetResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserQuotaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SetResellerUserStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetResellerUserStatusResponse
         */
        public SetResellerUserStatusResponse SetResellerUserStatusWithOptions(SetResellerUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopMode))
            {
                query["StopMode"] = request.StopMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetResellerUserStatus",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetResellerUserStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SetResellerUserStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetResellerUserStatusResponse
         */
        public async Task<SetResellerUserStatusResponse> SetResellerUserStatusWithOptionsAsync(SetResellerUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopMode))
            {
                query["StopMode"] = request.StopMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetResellerUserStatus",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetResellerUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SetResellerUserStatusRequest
         * @return SetResellerUserStatusResponse
         */
        public SetResellerUserStatusResponse SetResellerUserStatus(SetResellerUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserStatusWithOptions(request, runtime);
        }

        /**
         * @param request SetResellerUserStatusRequest
         * @return SetResellerUserStatusResponse
         */
        public async Task<SetResellerUserStatusResponse> SetResellerUserStatusAsync(SetResellerUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Subscribes to the bills that are stored in Object Storage Service (OSS) buckets.
         *
         * @description Before you call this operation, take note of the following items:
         * *   You can subscribe to only one type of bill at a time.
         * *   The bills generated on the previous day are pushed on a daily basis the next day after you subscribe to the bills. The full-data bills for the previous month are pushed on the fourth day of each month. The monthly bills in the PDF format for the previous month are pushed on the fourth day of each month.
         * *   The daily bills may be delayed. The delayed bills are pushed the next day after they are generated. The delayed bills may include the bills that should have been pushed on the previous day. We recommend that you query the full-data bills for the previous month at the beginning of each month.
         * *   The bill subscriber must have the [AliyunConsumeDump2OSSRole](https://ram.console.aliyun.com/#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D) permission.
         * *   The SubscribeBillToOSS operation has the same functionality as the Save Expense Details to OSS Bucket feature in User Center.
         * *   To subscribe to the bills stored in an OSS bucket, make sure that the directory name specified for the OSS bucket conforms to the following naming rules:
         * 1.  1.  The directory name can contain only UTF-8 characters and cannot contain emoticons.
         * 2.  2.  Forward slashes (/) are used to separate paths and can be used to create subdirectories with ease. The directory name cannot start with a forward slash (/), a backslash (\\\\), or consecutive forward slashes (/).
         * 3.  3.  The name of a subdirectory cannot be set to two consecutive periods (..).
         * 4.  4.  The directory name must be 1 to 254 characters in length.
         * *   File names:
         *     *   **BillingItemDetailForBillingPeriod** (Detailed bills of billable items)
         *         *   File name format for a daily push: `UID_BillingItemDetail_YYYYMMDD`. Example: `169**_BillingItemDetail_20190310`.
         *         *   File name format for a full-data push at the beginning of the next month: `UID_BillingItemDetail_YYYYMM`. Example: `169**_BillingItemDetail_201903`.
         *     *   **InstanceDetailForBillingPeriod** (Detailed bills of instances)
         *         *   File name format for a daily push: `UID_InstanceDetail_YYYYMMDD`. Example: `169**_InstanceDetail_20190310`.
         *         *   File name format for a full-data push at the beginning of the next month: `UID_InstanceDetail_YYYYMM`. Example: `169**_InstanceDetail_201903`.
         *     *   **InstanceDetailMonthly** (Instance-based bills summarized by billing cycle)
         *         *   File name format for a daily push: `UID_InstanceDetailMonthly_YYYYMM`. Example: `169**_InstanceDetailMonthly_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **BillingItemDetailMonthly** (Billable item-based bills summarized by billing cycle)
         *         *   File name format for a daily push: `UID_BillingItemDetailMonthly_YYYYMM`. Example: `169**_BillingItemDetailMonthly_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **SplitItemDetailDaily** (Split bills summarized by day)
         *         *   File name format for a daily push: `UID_SplitItemDetailDaily_YYYYMM`. Example: `169**_SplitItemDetailDaily_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **MonthBill** (Monthly bill in the PDF format)
         *         *   File name format for a monthly push: `UID_MonthBill_YYYYMM`. Example: `169**_MonthBill_201903`. The bill for the previous month is pushed on the fourth day of each month.
         * *   The bills of the MonthBill type are PDF files, whereas the bills of other types are CSV files. If the number of data rows in a bill exceeds a threshold, the bill is automatically split into multiple CSV files. Then, the multiple CSV files are automatically merged and compressed into a ZIP file that has the same name format as the original file.
         *
         * @param request SubscribeBillToOSSRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubscribeBillToOSSResponse
         */
        public SubscribeBillToOSSResponse SubscribeBillToOSSWithOptions(SubscribeBillToOSSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginBillingCycle))
            {
                query["BeginBillingCycle"] = request.BeginBillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketOwnerId))
            {
                query["BucketOwnerId"] = request.BucketOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketPath))
            {
                query["BucketPath"] = request.BucketPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultAccountRelSubscribe))
            {
                query["MultAccountRelSubscribe"] = request.MultAccountRelSubscribe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowLimitPerFile))
            {
                query["RowLimitPerFile"] = request.RowLimitPerFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeBucket))
            {
                query["SubscribeBucket"] = request.SubscribeBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeType))
            {
                query["SubscribeType"] = request.SubscribeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsingSsl))
            {
                query["UsingSsl"] = request.UsingSsl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubscribeBillToOSS",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeBillToOSSResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Subscribes to the bills that are stored in Object Storage Service (OSS) buckets.
         *
         * @description Before you call this operation, take note of the following items:
         * *   You can subscribe to only one type of bill at a time.
         * *   The bills generated on the previous day are pushed on a daily basis the next day after you subscribe to the bills. The full-data bills for the previous month are pushed on the fourth day of each month. The monthly bills in the PDF format for the previous month are pushed on the fourth day of each month.
         * *   The daily bills may be delayed. The delayed bills are pushed the next day after they are generated. The delayed bills may include the bills that should have been pushed on the previous day. We recommend that you query the full-data bills for the previous month at the beginning of each month.
         * *   The bill subscriber must have the [AliyunConsumeDump2OSSRole](https://ram.console.aliyun.com/#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D) permission.
         * *   The SubscribeBillToOSS operation has the same functionality as the Save Expense Details to OSS Bucket feature in User Center.
         * *   To subscribe to the bills stored in an OSS bucket, make sure that the directory name specified for the OSS bucket conforms to the following naming rules:
         * 1.  1.  The directory name can contain only UTF-8 characters and cannot contain emoticons.
         * 2.  2.  Forward slashes (/) are used to separate paths and can be used to create subdirectories with ease. The directory name cannot start with a forward slash (/), a backslash (\\\\), or consecutive forward slashes (/).
         * 3.  3.  The name of a subdirectory cannot be set to two consecutive periods (..).
         * 4.  4.  The directory name must be 1 to 254 characters in length.
         * *   File names:
         *     *   **BillingItemDetailForBillingPeriod** (Detailed bills of billable items)
         *         *   File name format for a daily push: `UID_BillingItemDetail_YYYYMMDD`. Example: `169**_BillingItemDetail_20190310`.
         *         *   File name format for a full-data push at the beginning of the next month: `UID_BillingItemDetail_YYYYMM`. Example: `169**_BillingItemDetail_201903`.
         *     *   **InstanceDetailForBillingPeriod** (Detailed bills of instances)
         *         *   File name format for a daily push: `UID_InstanceDetail_YYYYMMDD`. Example: `169**_InstanceDetail_20190310`.
         *         *   File name format for a full-data push at the beginning of the next month: `UID_InstanceDetail_YYYYMM`. Example: `169**_InstanceDetail_201903`.
         *     *   **InstanceDetailMonthly** (Instance-based bills summarized by billing cycle)
         *         *   File name format for a daily push: `UID_InstanceDetailMonthly_YYYYMM`. Example: `169**_InstanceDetailMonthly_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **BillingItemDetailMonthly** (Billable item-based bills summarized by billing cycle)
         *         *   File name format for a daily push: `UID_BillingItemDetailMonthly_YYYYMM`. Example: `169**_BillingItemDetailMonthly_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **SplitItemDetailDaily** (Split bills summarized by day)
         *         *   File name format for a daily push: `UID_SplitItemDetailDaily_YYYYMM`. Example: `169**_SplitItemDetailDaily_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **MonthBill** (Monthly bill in the PDF format)
         *         *   File name format for a monthly push: `UID_MonthBill_YYYYMM`. Example: `169**_MonthBill_201903`. The bill for the previous month is pushed on the fourth day of each month.
         * *   The bills of the MonthBill type are PDF files, whereas the bills of other types are CSV files. If the number of data rows in a bill exceeds a threshold, the bill is automatically split into multiple CSV files. Then, the multiple CSV files are automatically merged and compressed into a ZIP file that has the same name format as the original file.
         *
         * @param request SubscribeBillToOSSRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubscribeBillToOSSResponse
         */
        public async Task<SubscribeBillToOSSResponse> SubscribeBillToOSSWithOptionsAsync(SubscribeBillToOSSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginBillingCycle))
            {
                query["BeginBillingCycle"] = request.BeginBillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketOwnerId))
            {
                query["BucketOwnerId"] = request.BucketOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketPath))
            {
                query["BucketPath"] = request.BucketPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultAccountRelSubscribe))
            {
                query["MultAccountRelSubscribe"] = request.MultAccountRelSubscribe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowLimitPerFile))
            {
                query["RowLimitPerFile"] = request.RowLimitPerFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeBucket))
            {
                query["SubscribeBucket"] = request.SubscribeBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeType))
            {
                query["SubscribeType"] = request.SubscribeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsingSsl))
            {
                query["UsingSsl"] = request.UsingSsl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubscribeBillToOSS",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeBillToOSSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Subscribes to the bills that are stored in Object Storage Service (OSS) buckets.
         *
         * @description Before you call this operation, take note of the following items:
         * *   You can subscribe to only one type of bill at a time.
         * *   The bills generated on the previous day are pushed on a daily basis the next day after you subscribe to the bills. The full-data bills for the previous month are pushed on the fourth day of each month. The monthly bills in the PDF format for the previous month are pushed on the fourth day of each month.
         * *   The daily bills may be delayed. The delayed bills are pushed the next day after they are generated. The delayed bills may include the bills that should have been pushed on the previous day. We recommend that you query the full-data bills for the previous month at the beginning of each month.
         * *   The bill subscriber must have the [AliyunConsumeDump2OSSRole](https://ram.console.aliyun.com/#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D) permission.
         * *   The SubscribeBillToOSS operation has the same functionality as the Save Expense Details to OSS Bucket feature in User Center.
         * *   To subscribe to the bills stored in an OSS bucket, make sure that the directory name specified for the OSS bucket conforms to the following naming rules:
         * 1.  1.  The directory name can contain only UTF-8 characters and cannot contain emoticons.
         * 2.  2.  Forward slashes (/) are used to separate paths and can be used to create subdirectories with ease. The directory name cannot start with a forward slash (/), a backslash (\\\\), or consecutive forward slashes (/).
         * 3.  3.  The name of a subdirectory cannot be set to two consecutive periods (..).
         * 4.  4.  The directory name must be 1 to 254 characters in length.
         * *   File names:
         *     *   **BillingItemDetailForBillingPeriod** (Detailed bills of billable items)
         *         *   File name format for a daily push: `UID_BillingItemDetail_YYYYMMDD`. Example: `169**_BillingItemDetail_20190310`.
         *         *   File name format for a full-data push at the beginning of the next month: `UID_BillingItemDetail_YYYYMM`. Example: `169**_BillingItemDetail_201903`.
         *     *   **InstanceDetailForBillingPeriod** (Detailed bills of instances)
         *         *   File name format for a daily push: `UID_InstanceDetail_YYYYMMDD`. Example: `169**_InstanceDetail_20190310`.
         *         *   File name format for a full-data push at the beginning of the next month: `UID_InstanceDetail_YYYYMM`. Example: `169**_InstanceDetail_201903`.
         *     *   **InstanceDetailMonthly** (Instance-based bills summarized by billing cycle)
         *         *   File name format for a daily push: `UID_InstanceDetailMonthly_YYYYMM`. Example: `169**_InstanceDetailMonthly_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **BillingItemDetailMonthly** (Billable item-based bills summarized by billing cycle)
         *         *   File name format for a daily push: `UID_BillingItemDetailMonthly_YYYYMM`. Example: `169**_BillingItemDetailMonthly_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **SplitItemDetailDaily** (Split bills summarized by day)
         *         *   File name format for a daily push: `UID_SplitItemDetailDaily_YYYYMM`. Example: `169**_SplitItemDetailDaily_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **MonthBill** (Monthly bill in the PDF format)
         *         *   File name format for a monthly push: `UID_MonthBill_YYYYMM`. Example: `169**_MonthBill_201903`. The bill for the previous month is pushed on the fourth day of each month.
         * *   The bills of the MonthBill type are PDF files, whereas the bills of other types are CSV files. If the number of data rows in a bill exceeds a threshold, the bill is automatically split into multiple CSV files. Then, the multiple CSV files are automatically merged and compressed into a ZIP file that has the same name format as the original file.
         *
         * @param request SubscribeBillToOSSRequest
         * @return SubscribeBillToOSSResponse
         */
        public SubscribeBillToOSSResponse SubscribeBillToOSS(SubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscribeBillToOSSWithOptions(request, runtime);
        }

        /**
         * @summary Subscribes to the bills that are stored in Object Storage Service (OSS) buckets.
         *
         * @description Before you call this operation, take note of the following items:
         * *   You can subscribe to only one type of bill at a time.
         * *   The bills generated on the previous day are pushed on a daily basis the next day after you subscribe to the bills. The full-data bills for the previous month are pushed on the fourth day of each month. The monthly bills in the PDF format for the previous month are pushed on the fourth day of each month.
         * *   The daily bills may be delayed. The delayed bills are pushed the next day after they are generated. The delayed bills may include the bills that should have been pushed on the previous day. We recommend that you query the full-data bills for the previous month at the beginning of each month.
         * *   The bill subscriber must have the [AliyunConsumeDump2OSSRole](https://ram.console.aliyun.com/#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D) permission.
         * *   The SubscribeBillToOSS operation has the same functionality as the Save Expense Details to OSS Bucket feature in User Center.
         * *   To subscribe to the bills stored in an OSS bucket, make sure that the directory name specified for the OSS bucket conforms to the following naming rules:
         * 1.  1.  The directory name can contain only UTF-8 characters and cannot contain emoticons.
         * 2.  2.  Forward slashes (/) are used to separate paths and can be used to create subdirectories with ease. The directory name cannot start with a forward slash (/), a backslash (\\\\), or consecutive forward slashes (/).
         * 3.  3.  The name of a subdirectory cannot be set to two consecutive periods (..).
         * 4.  4.  The directory name must be 1 to 254 characters in length.
         * *   File names:
         *     *   **BillingItemDetailForBillingPeriod** (Detailed bills of billable items)
         *         *   File name format for a daily push: `UID_BillingItemDetail_YYYYMMDD`. Example: `169**_BillingItemDetail_20190310`.
         *         *   File name format for a full-data push at the beginning of the next month: `UID_BillingItemDetail_YYYYMM`. Example: `169**_BillingItemDetail_201903`.
         *     *   **InstanceDetailForBillingPeriod** (Detailed bills of instances)
         *         *   File name format for a daily push: `UID_InstanceDetail_YYYYMMDD`. Example: `169**_InstanceDetail_20190310`.
         *         *   File name format for a full-data push at the beginning of the next month: `UID_InstanceDetail_YYYYMM`. Example: `169**_InstanceDetail_201903`.
         *     *   **InstanceDetailMonthly** (Instance-based bills summarized by billing cycle)
         *         *   File name format for a daily push: `UID_InstanceDetailMonthly_YYYYMM`. Example: `169**_InstanceDetailMonthly_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **BillingItemDetailMonthly** (Billable item-based bills summarized by billing cycle)
         *         *   File name format for a daily push: `UID_BillingItemDetailMonthly_YYYYMM`. Example: `169**_BillingItemDetailMonthly_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **SplitItemDetailDaily** (Split bills summarized by day)
         *         *   File name format for a daily push: `UID_SplitItemDetailDaily_YYYYMM`. Example: `169**_SplitItemDetailDaily_201903`. A bill of this type contains the full data generated from the beginning of the month to the current day, and is updated every day until the fourth day of the next month.
         *     *   **MonthBill** (Monthly bill in the PDF format)
         *         *   File name format for a monthly push: `UID_MonthBill_YYYYMM`. Example: `169**_MonthBill_201903`. The bill for the previous month is pushed on the fourth day of each month.
         * *   The bills of the MonthBill type are PDF files, whereas the bills of other types are CSV files. If the number of data rows in a bill exceeds a threshold, the bill is automatically split into multiple CSV files. Then, the multiple CSV files are automatically merged and compressed into a ZIP file that has the same name format as the original file.
         *
         * @param request SubscribeBillToOSSRequest
         * @return SubscribeBillToOSSResponse
         */
        public async Task<SubscribeBillToOSSResponse> SubscribeBillToOSSAsync(SubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscribeBillToOSSWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Add tags to resources.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Add tags to resources.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Add tags to resources.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Add tags to resources.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unsubscribes from the bills that are stored in Object Storage Service (OSS) buckets.
         *
         * @param request UnsubscribeBillToOSSRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnsubscribeBillToOSSResponse
         */
        public UnsubscribeBillToOSSResponse UnsubscribeBillToOSSWithOptions(UnsubscribeBillToOSSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultAccountRelSubscribe))
            {
                query["MultAccountRelSubscribe"] = request.MultAccountRelSubscribe;
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
                Action = "UnsubscribeBillToOSS",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeBillToOSSResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unsubscribes from the bills that are stored in Object Storage Service (OSS) buckets.
         *
         * @param request UnsubscribeBillToOSSRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnsubscribeBillToOSSResponse
         */
        public async Task<UnsubscribeBillToOSSResponse> UnsubscribeBillToOSSWithOptionsAsync(UnsubscribeBillToOSSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultAccountRelSubscribe))
            {
                query["MultAccountRelSubscribe"] = request.MultAccountRelSubscribe;
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
                Action = "UnsubscribeBillToOSS",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeBillToOSSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unsubscribes from the bills that are stored in Object Storage Service (OSS) buckets.
         *
         * @param request UnsubscribeBillToOSSRequest
         * @return UnsubscribeBillToOSSResponse
         */
        public UnsubscribeBillToOSSResponse UnsubscribeBillToOSS(UnsubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnsubscribeBillToOSSWithOptions(request, runtime);
        }

        /**
         * @summary Unsubscribes from the bills that are stored in Object Storage Service (OSS) buckets.
         *
         * @param request UnsubscribeBillToOSSRequest
         * @return UnsubscribeBillToOSSResponse
         */
        public async Task<UnsubscribeBillToOSSResponse> UnsubscribeBillToOSSAsync(UnsubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnsubscribeBillToOSSWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes tags from resources.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes tags from resources.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes tags from resources.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Removes tags from resources.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Upgrades a resource plan.
         *
         * @param request UpgradeResourcePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeResourcePackageResponse
         */
        public UpgradeResourcePackageResponse UpgradeResourcePackageWithOptions(UpgradeResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeResourcePackage",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeResourcePackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Upgrades a resource plan.
         *
         * @param request UpgradeResourcePackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeResourcePackageResponse
         */
        public async Task<UpgradeResourcePackageResponse> UpgradeResourcePackageWithOptionsAsync(UpgradeResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDate))
            {
                query["EffectiveDate"] = request.EffectiveDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeResourcePackage",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeResourcePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Upgrades a resource plan.
         *
         * @param request UpgradeResourcePackageRequest
         * @return UpgradeResourcePackageResponse
         */
        public UpgradeResourcePackageResponse UpgradeResourcePackage(UpgradeResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeResourcePackageWithOptions(request, runtime);
        }

        /**
         * @summary Upgrades a resource plan.
         *
         * @param request UpgradeResourcePackageRequest
         * @return UpgradeResourcePackageResponse
         */
        public async Task<UpgradeResourcePackageResponse> UpgradeResourcePackageAsync(UpgradeResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeResourcePackageWithOptionsAsync(request, runtime);
        }

    }
}
