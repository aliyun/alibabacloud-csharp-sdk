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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a financial relationship.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about a financial relationship, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/116383.html">Usage notes on the trusteeship</a>. 
        /// If enterprise names used by the management account and a member for real-name verification are the same, you do not need to call an API operation for confirmation. Otherwise, you must call the ConfirmRelation operation for confirmation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAccountRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAccountRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a financial relationship.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about a financial relationship, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/116383.html">Usage notes on the trusteeship</a>. 
        /// If enterprise names used by the management account and a member for real-name verification are the same, you do not need to call an API operation for confirmation. Otherwise, you must call the ConfirmRelation operation for confirmation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAccountRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAccountRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a financial relationship.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about a financial relationship, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/116383.html">Usage notes on the trusteeship</a>. 
        /// If enterprise names used by the management account and a member for real-name verification are the same, you do not need to call an API operation for confirmation. Otherwise, you must call the ConfirmRelation operation for confirmation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAccountRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAccountRelationResponse
        /// </returns>
        public AddAccountRelationResponse AddAccountRelation(AddAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAccountRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a financial relationship.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about a financial relationship, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/116383.html">Usage notes on the trusteeship</a>. 
        /// If enterprise names used by the management account and a member for real-name verification are the same, you do not need to call an API operation for confirmation. Otherwise, you must call the ConfirmRelation operation for confirmation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddAccountRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// AddAccountRelationResponse
        /// </returns>
        public async Task<AddAccountRelationResponse> AddAccountRelationAsync(AddAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAccountRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Allocates resource instances (instance-based and attached-resource-based) from a source financial unit to a destination financial unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateCostUnitResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllocateCostUnitResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Allocates resource instances (instance-based and attached-resource-based) from a source financial unit to a destination financial unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateCostUnitResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllocateCostUnitResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Allocates resource instances (instance-based and attached-resource-based) from a source financial unit to a destination financial unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateCostUnitResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// AllocateCostUnitResourceResponse
        /// </returns>
        public AllocateCostUnitResourceResponse AllocateCostUnitResource(AllocateCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateCostUnitResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Allocates resource instances (instance-based and attached-resource-based) from a source financial unit to a destination financial unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateCostUnitResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// AllocateCostUnitResourceResponse
        /// </returns>
        public async Task<AllocateCostUnitResourceResponse> AllocateCostUnitResourceAsync(AllocateCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateCostUnitResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an invoice application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyInvoiceResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Emails))
            {
                query["emails"] = request.Emails;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an invoice application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyInvoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyInvoiceResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Emails))
            {
                query["emails"] = request.Emails;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an invoice application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyInvoiceResponse
        /// </returns>
        public ApplyInvoiceResponse ApplyInvoice(ApplyInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyInvoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an invoice application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyInvoiceResponse
        /// </returns>
        public async Task<ApplyInvoiceResponse> ApplyInvoiceAsync(ApplyInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyInvoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an unpaid order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an unpaid order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an unpaid order.</para>
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
            return CancelOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an unpaid order.</para>
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
            return await CancelOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deducts user quota consumption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deducts user quota consumption.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeResellerConsumeAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResellerConsumeAmountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deducts user quota consumption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deducts user quota consumption.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeResellerConsumeAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResellerConsumeAmountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deducts user quota consumption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deducts user quota consumption.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeResellerConsumeAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResellerConsumeAmountResponse
        /// </returns>
        public ChangeResellerConsumeAmountResponse ChangeResellerConsumeAmount(ChangeResellerConsumeAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResellerConsumeAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deducts user quota consumption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deducts user quota consumption.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeResellerConsumeAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResellerConsumeAmountResponse
        /// </returns>
        public async Task<ChangeResellerConsumeAmountResponse> ChangeResellerConsumeAmountAsync(ChangeResellerConsumeAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResellerConsumeAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms an invitation initiated by the main account for a linked account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Currently, only financial management linking is supported. The linked account needs to confirm the invitation only when the real-name verification information of the main account and the linked account is inconsistent.</description></item>
        /// <item><description>The permissions to be confirmed must be exactly the same as the permissions specified in the invitation initiated by the main account for the confirmation to succeed.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfirmRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms an invitation initiated by the main account for a linked account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Currently, only financial management linking is supported. The linked account needs to confirm the invitation only when the real-name verification information of the main account and the linked account is inconsistent.</description></item>
        /// <item><description>The permissions to be confirmed must be exactly the same as the permissions specified in the invitation initiated by the main account for the confirmation to succeed.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfirmRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms an invitation initiated by the main account for a linked account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Currently, only financial management linking is supported. The linked account needs to confirm the invitation only when the real-name verification information of the main account and the linked account is inconsistent.</description></item>
        /// <item><description>The permissions to be confirmed must be exactly the same as the permissions specified in the invitation initiated by the main account for the confirmation to succeed.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfirmRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmRelationResponse
        /// </returns>
        public ConfirmRelationResponse ConfirmRelation(ConfirmRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Confirms an invitation initiated by the main account for a linked account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Currently, only financial management linking is supported. The linked account needs to confirm the invitation only when the real-name verification information of the main account and the linked account is inconsistent.</description></item>
        /// <item><description>The permissions to be confirmed must be exactly the same as the permissions specified in the invitation initiated by the main account for the confirmation to succeed.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfirmRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmRelationResponse
        /// </returns>
        public async Task<ConfirmRelationResponse> ConfirmRelationAsync(ConfirmRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the subscription type for an instance. Currently, this operation supports converting pay-as-you-go instances of SLB, EIP, and NAT Gateway to subscription instances, and converting subscription instances of SLB and EIP to pay-as-you-go instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertChargeTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertChargeTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the subscription type for an instance. Currently, this operation supports converting pay-as-you-go instances of SLB, EIP, and NAT Gateway to subscription instances, and converting subscription instances of SLB and EIP to pay-as-you-go instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertChargeTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertChargeTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the subscription type for an instance. Currently, this operation supports converting pay-as-you-go instances of SLB, EIP, and NAT Gateway to subscription instances, and converting subscription instances of SLB and EIP to pay-as-you-go instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertChargeTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertChargeTypeResponse
        /// </returns>
        public ConvertChargeTypeResponse ConvertChargeType(ConvertChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertChargeTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the subscription type for an instance. Currently, this operation supports converting pay-as-you-go instances of SLB, EIP, and NAT Gateway to subscription instances, and converting subscription instances of SLB and EIP to pay-as-you-go instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConvertChargeTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertChargeTypeResponse
        /// </returns>
        public async Task<ConvertChargeTypeResponse> ConvertChargeTypeAsync(ConvertChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertChargeTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an account linking relationship.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a master-member relationship for financial management.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgAccountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an account linking relationship.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a master-member relationship for financial management.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgAccountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an account linking relationship.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a master-member relationship for financial management.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgAccountResponse
        /// </returns>
        public CreateAgAccountResponse CreateAgAccount(CreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an account linking relationship.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a master-member relationship for financial management.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgAccountResponse
        /// </returns>
        public async Task<CreateAgAccountResponse> CreateAgAccountAsync(CreateAgAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates financial units. Batch creation is supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCostUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCostUnitResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates financial units. Batch creation is supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCostUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCostUnitResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates financial units. Batch creation is supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCostUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCostUnitResponse
        /// </returns>
        public CreateCostUnitResponse CreateCostUnit(CreateCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCostUnitWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates financial units. Batch creation is supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCostUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCostUnitResponse
        /// </returns>
        public async Task<CreateCostUnitResponse> CreateCostUnitAsync(CreateCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCostUnitWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance resource. This operation creates an order for a new instance resource and completes automatic payment. ECS and RDS product series are not supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance resource. This operation creates an order for a new instance resource and completes automatic payment. ECS and RDS product series are not supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance resource. This operation creates an order for a new instance resource and completes automatic payment. ECS and RDS product series are not supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an instance resource. This operation creates an order for a new instance resource and completes automatic payment. ECS and RDS product series are not supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user quota ledger and a quota consumption ledger.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResellerUserQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResellerUserQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user quota ledger and a quota consumption ledger.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResellerUserQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResellerUserQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user quota ledger and a quota consumption ledger.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResellerUserQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResellerUserQuotaResponse
        /// </returns>
        public CreateResellerUserQuotaResponse CreateResellerUserQuota(CreateResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResellerUserQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user quota ledger and a quota consumption ledger.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResellerUserQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResellerUserQuotaResponse
        /// </returns>
        public async Task<CreateResellerUserQuotaResponse> CreateResellerUserQuotaAsync(CreateResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResellerUserQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourcePackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourcePackageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourcePackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourcePackageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourcePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourcePackageResponse
        /// </returns>
        public CreateResourcePackageResponse CreateResourcePackage(CreateResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourcePackageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourcePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourcePackageResponse
        /// </returns>
        public async Task<CreateResourcePackageResponse> CreateResourcePackageAsync(CreateResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourcePackageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建节省计划实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSavingsPlansInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSavingsPlansInstanceResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建节省计划实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSavingsPlansInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSavingsPlansInstanceResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建节省计划实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavingsPlansInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSavingsPlansInstanceResponse
        /// </returns>
        public CreateSavingsPlansInstanceResponse CreateSavingsPlansInstance(CreateSavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSavingsPlansInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建节省计划实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavingsPlansInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSavingsPlansInstanceResponse
        /// </returns>
        public async Task<CreateSavingsPlansInstanceResponse> CreateSavingsPlansInstanceAsync(CreateSavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSavingsPlansInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a financial unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCostUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCostUnitResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a financial unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCostUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCostUnitResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a financial unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCostUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCostUnitResponse
        /// </returns>
        public DeleteCostUnitResponse DeleteCostUnit(DeleteCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCostUnitWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a financial unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCostUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCostUnitResponse
        /// </returns>
        public async Task<DeleteCostUnitResponse> DeleteCostUnitAsync(DeleteCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCostUnitWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a summary of cost budgets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This OpenAPI is in beta and available only to whitelisted users. Excessive calls may cause performance issues, such as response timeouts.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCostBudgetsSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostBudgetsSummaryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a summary of cost budgets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This OpenAPI is in beta and available only to whitelisted users. Excessive calls may cause performance issues, such as response timeouts.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCostBudgetsSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostBudgetsSummaryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a summary of cost budgets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This OpenAPI is in beta and available only to whitelisted users. Excessive calls may cause performance issues, such as response timeouts.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCostBudgetsSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostBudgetsSummaryResponse
        /// </returns>
        public DescribeCostBudgetsSummaryResponse DescribeCostBudgetsSummary(DescribeCostBudgetsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCostBudgetsSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a summary of cost budgets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This OpenAPI is in beta and available only to whitelisted users. Excessive calls may cause performance issues, such as response timeouts.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCostBudgetsSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostBudgetsSummaryResponse
        /// </returns>
        public async Task<DescribeCostBudgetsSummaryResponse> DescribeCostBudgetsSummaryAsync(DescribeCostBudgetsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCostBudgetsSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized costs of instances for a specified amortization month.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs cannot be used for settlement or reconciliation. They are used to allocate your subscription and pay-as-you-go fees based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. The reason for this delay is that scenarios such as delayed billing, refunds, bill adjustments, and overdue payment write-offs can occur during the month. The data for the current month does not include unsettled pay-as-you-go fees for which bills have not yet been generated.</description></item>
        /// <item><description>Amortized cost data from the last 12 months is available.</description></item>
        /// <item><description>Data for attached resources is reflected in the amortized costs 48 hours after the split bill is generated. To use this feature, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data for items that are not attached resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs are not updated intra-month. They are updated only after 12:00 on the sixth day of the following month. Consequently, specific costs for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available for these months.</description></item>
        /// <item><description>Amortized cost data is available for querying 48 hours after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByAmortizationPeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized costs of instances for a specified amortization month.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs cannot be used for settlement or reconciliation. They are used to allocate your subscription and pay-as-you-go fees based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. The reason for this delay is that scenarios such as delayed billing, refunds, bill adjustments, and overdue payment write-offs can occur during the month. The data for the current month does not include unsettled pay-as-you-go fees for which bills have not yet been generated.</description></item>
        /// <item><description>Amortized cost data from the last 12 months is available.</description></item>
        /// <item><description>Data for attached resources is reflected in the amortized costs 48 hours after the split bill is generated. To use this feature, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data for items that are not attached resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs are not updated intra-month. They are updated only after 12:00 on the sixth day of the following month. Consequently, specific costs for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available for these months.</description></item>
        /// <item><description>Amortized cost data is available for querying 48 hours after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByAmortizationPeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized costs of instances for a specified amortization month.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs cannot be used for settlement or reconciliation. They are used to allocate your subscription and pay-as-you-go fees based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. The reason for this delay is that scenarios such as delayed billing, refunds, bill adjustments, and overdue payment write-offs can occur during the month. The data for the current month does not include unsettled pay-as-you-go fees for which bills have not yet been generated.</description></item>
        /// <item><description>Amortized cost data from the last 12 months is available.</description></item>
        /// <item><description>Data for attached resources is reflected in the amortized costs 48 hours after the split bill is generated. To use this feature, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data for items that are not attached resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs are not updated intra-month. They are updated only after 12:00 on the sixth day of the following month. Consequently, specific costs for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available for these months.</description></item>
        /// <item><description>Amortized cost data is available for querying 48 hours after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByAmortizationPeriodResponse
        /// </returns>
        public DescribeInstanceAmortizedCostByAmortizationPeriodResponse DescribeInstanceAmortizedCostByAmortizationPeriod(DescribeInstanceAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAmortizedCostByAmortizationPeriodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized costs of instances for a specified amortization month.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs cannot be used for settlement or reconciliation. They are used to allocate your subscription and pay-as-you-go fees based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. The reason for this delay is that scenarios such as delayed billing, refunds, bill adjustments, and overdue payment write-offs can occur during the month. The data for the current month does not include unsettled pay-as-you-go fees for which bills have not yet been generated.</description></item>
        /// <item><description>Amortized cost data from the last 12 months is available.</description></item>
        /// <item><description>Data for attached resources is reflected in the amortized costs 48 hours after the split bill is generated. To use this feature, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data for items that are not attached resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs are not updated intra-month. They are updated only after 12:00 on the sixth day of the following month. Consequently, specific costs for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available for these months.</description></item>
        /// <item><description>Amortized cost data is available for querying 48 hours after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByAmortizationPeriodResponse
        /// </returns>
        public async Task<DescribeInstanceAmortizedCostByAmortizationPeriodResponse> DescribeInstanceAmortizedCostByAmortizationPeriodAsync(DescribeInstanceAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAmortizedCostByAmortizationPeriodWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例摊销日摊销成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例摊销日摊销成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例摊销日摊销成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse
        /// </returns>
        public DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse DescribeInstanceAmortizedCostByAmortizationPeriodDate(DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAmortizedCostByAmortizationPeriodDateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例摊销日摊销成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse
        /// </returns>
        public async Task<DescribeInstanceAmortizedCostByAmortizationPeriodDateResponse> DescribeInstanceAmortizedCostByAmortizationPeriodDateAsync(DescribeInstanceAmortizedCostByAmortizationPeriodDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAmortizedCostByAmortizationPeriodDateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of an instance by billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are not used for settlement or reconciliation. They are used to allocate your cloud expenses, including both subscription and pay-as-you-go fees, based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. This delay accounts for events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs. Data for the current month does not include unsettled pay-as-you-go fees.</description></item>
        /// <item><description>Amortized cost data is available for the past 12 months.</description></item>
        /// <item><description>Data for attached resources in the amortized costs is updated 48 hours after the split bill is generated. To view the costs of attached resources, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data for other resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs are not updated mid-month. They are updated only after 12:00 on the sixth day of the following month. In addition, specific costs for attached resources, such as domain names, buckets, and EIPs, of products such as CDN, OSS, and Internet Shared Bandwidth, are not provided for this period.</description></item>
        /// <item><description>Amortized cost data is available only after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Costs</a> feature. The data becomes available 48 hours after enablement.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByConsumePeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByConsumePeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of an instance by billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are not used for settlement or reconciliation. They are used to allocate your cloud expenses, including both subscription and pay-as-you-go fees, based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. This delay accounts for events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs. Data for the current month does not include unsettled pay-as-you-go fees.</description></item>
        /// <item><description>Amortized cost data is available for the past 12 months.</description></item>
        /// <item><description>Data for attached resources in the amortized costs is updated 48 hours after the split bill is generated. To view the costs of attached resources, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data for other resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs are not updated mid-month. They are updated only after 12:00 on the sixth day of the following month. In addition, specific costs for attached resources, such as domain names, buckets, and EIPs, of products such as CDN, OSS, and Internet Shared Bandwidth, are not provided for this period.</description></item>
        /// <item><description>Amortized cost data is available only after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Costs</a> feature. The data becomes available 48 hours after enablement.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByConsumePeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByConsumePeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of an instance by billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are not used for settlement or reconciliation. They are used to allocate your cloud expenses, including both subscription and pay-as-you-go fees, based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. This delay accounts for events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs. Data for the current month does not include unsettled pay-as-you-go fees.</description></item>
        /// <item><description>Amortized cost data is available for the past 12 months.</description></item>
        /// <item><description>Data for attached resources in the amortized costs is updated 48 hours after the split bill is generated. To view the costs of attached resources, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data for other resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs are not updated mid-month. They are updated only after 12:00 on the sixth day of the following month. In addition, specific costs for attached resources, such as domain names, buckets, and EIPs, of products such as CDN, OSS, and Internet Shared Bandwidth, are not provided for this period.</description></item>
        /// <item><description>Amortized cost data is available only after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Costs</a> feature. The data becomes available 48 hours after enablement.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByConsumePeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByConsumePeriodResponse
        /// </returns>
        public DescribeInstanceAmortizedCostByConsumePeriodResponse DescribeInstanceAmortizedCostByConsumePeriod(DescribeInstanceAmortizedCostByConsumePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAmortizedCostByConsumePeriodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of an instance by billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are not used for settlement or reconciliation. They are used to allocate your cloud expenses, including both subscription and pay-as-you-go fees, based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. This delay accounts for events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs. Data for the current month does not include unsettled pay-as-you-go fees.</description></item>
        /// <item><description>Amortized cost data is available for the past 12 months.</description></item>
        /// <item><description>Data for attached resources in the amortized costs is updated 48 hours after the split bill is generated. To view the costs of attached resources, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data for other resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs are not updated mid-month. They are updated only after 12:00 on the sixth day of the following month. In addition, specific costs for attached resources, such as domain names, buckets, and EIPs, of products such as CDN, OSS, and Internet Shared Bandwidth, are not provided for this period.</description></item>
        /// <item><description>Amortized cost data is available only after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Costs</a> feature. The data becomes available 48 hours after enablement.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAmortizedCostByConsumePeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAmortizedCostByConsumePeriodResponse
        /// </returns>
        public async Task<DescribeInstanceAmortizedCostByConsumePeriodResponse> DescribeInstanceAmortizedCostByConsumePeriodAsync(DescribeInstanceAmortizedCostByConsumePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAmortizedCostByConsumePeriodWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the consumption summary of all product instances or billable items for a user within a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month are for reference only and cannot be used as the basis for reconciliation. The final bill for the current month can be viewed or exported after 12:00 on the 3rd day of the next month. During the month, a few scenarios may occur, including but not limited to delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>The bill data for the current month does not include unsettled pay-as-you-go data that is unbilled or accumulating.</description></item>
        /// <item><description>Data for the last 18 months is supported. </description></item>
        /// <item><description>Bill data is updated with a 24-hour delay compared to actual consumption. Information related to the instance ID, such as instance configuration, instance type, instance alias, resource group, public IP address, private IP address, and zone, is updated with a 48-hour delay.  </description></item>
        /// <item><description>Bill data does not provide the specific costs of individual split items, such as domain names, buckets, and EIPs, for split-type cloud services, such as CDN, OSS, and Internet Shared Bandwidth. To view data that includes split items, go to the split bill page.</description></item>
        /// <item><description>For cloud communication products, only detail data from June 2020 onwards is supported. For HiChina products, including domain names and trademarks, only detail data from November 2020 onwards is supported.</description></item>
        /// <item><description>The rate limit is 10 requests per second per user. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the consumption summary of all product instances or billable items for a user within a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month are for reference only and cannot be used as the basis for reconciliation. The final bill for the current month can be viewed or exported after 12:00 on the 3rd day of the next month. During the month, a few scenarios may occur, including but not limited to delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>The bill data for the current month does not include unsettled pay-as-you-go data that is unbilled or accumulating.</description></item>
        /// <item><description>Data for the last 18 months is supported. </description></item>
        /// <item><description>Bill data is updated with a 24-hour delay compared to actual consumption. Information related to the instance ID, such as instance configuration, instance type, instance alias, resource group, public IP address, private IP address, and zone, is updated with a 48-hour delay.  </description></item>
        /// <item><description>Bill data does not provide the specific costs of individual split items, such as domain names, buckets, and EIPs, for split-type cloud services, such as CDN, OSS, and Internet Shared Bandwidth. To view data that includes split items, go to the split bill page.</description></item>
        /// <item><description>For cloud communication products, only detail data from June 2020 onwards is supported. For HiChina products, including domain names and trademarks, only detail data from November 2020 onwards is supported.</description></item>
        /// <item><description>The rate limit is 10 requests per second per user. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the consumption summary of all product instances or billable items for a user within a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month are for reference only and cannot be used as the basis for reconciliation. The final bill for the current month can be viewed or exported after 12:00 on the 3rd day of the next month. During the month, a few scenarios may occur, including but not limited to delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>The bill data for the current month does not include unsettled pay-as-you-go data that is unbilled or accumulating.</description></item>
        /// <item><description>Data for the last 18 months is supported. </description></item>
        /// <item><description>Bill data is updated with a 24-hour delay compared to actual consumption. Information related to the instance ID, such as instance configuration, instance type, instance alias, resource group, public IP address, private IP address, and zone, is updated with a 48-hour delay.  </description></item>
        /// <item><description>Bill data does not provide the specific costs of individual split items, such as domain names, buckets, and EIPs, for split-type cloud services, such as CDN, OSS, and Internet Shared Bandwidth. To view data that includes split items, go to the split bill page.</description></item>
        /// <item><description>For cloud communication products, only detail data from June 2020 onwards is supported. For HiChina products, including domain names and trademarks, only detail data from November 2020 onwards is supported.</description></item>
        /// <item><description>The rate limit is 10 requests per second per user. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceBillRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceBillResponse
        /// </returns>
        public DescribeInstanceBillResponse DescribeInstanceBill(DescribeInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the consumption summary of all product instances or billable items for a user within a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month are for reference only and cannot be used as the basis for reconciliation. The final bill for the current month can be viewed or exported after 12:00 on the 3rd day of the next month. During the month, a few scenarios may occur, including but not limited to delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>The bill data for the current month does not include unsettled pay-as-you-go data that is unbilled or accumulating.</description></item>
        /// <item><description>Data for the last 18 months is supported. </description></item>
        /// <item><description>Bill data is updated with a 24-hour delay compared to actual consumption. Information related to the instance ID, such as instance configuration, instance type, instance alias, resource group, public IP address, private IP address, and zone, is updated with a 48-hour delay.  </description></item>
        /// <item><description>Bill data does not provide the specific costs of individual split items, such as domain names, buckets, and EIPs, for split-type cloud services, such as CDN, OSS, and Internet Shared Bandwidth. To view data that includes split items, go to the split bill page.</description></item>
        /// <item><description>For cloud communication products, only detail data from June 2020 onwards is supported. For HiChina products, including domain names and trademarks, only detail data from November 2020 onwards is supported.</description></item>
        /// <item><description>The rate limit is 10 requests per second per user. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceBillRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceBillResponse
        /// </returns>
        public async Task<DescribeInstanceBillResponse> DescribeInstanceBillAsync(DescribeInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例摊销日抵扣还原摊销成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例摊销日抵扣还原摊销成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例摊销日抵扣还原摊销成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse
        /// </returns>
        public DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse DescribeInstanceDeductAmortizedCostByAmortizationPeriod(DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDeductAmortizedCostByAmortizationPeriodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实例摊销日抵扣还原摊销成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse
        /// </returns>
        public async Task<DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponse> DescribeInstanceDeductAmortizedCostByAmortizationPeriodAsync(DescribeInstanceDeductAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDeductAmortizedCostByAmortizationPeriodWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the module information of a specific Alibaba Cloud product.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePricingModuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePricingModuleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the module information of a specific Alibaba Cloud product.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePricingModuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePricingModuleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the module information of a specific Alibaba Cloud product.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePricingModuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePricingModuleResponse
        /// </returns>
        public DescribePricingModuleResponse DescribePricingModule(DescribePricingModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePricingModuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the module information of a specific Alibaba Cloud product.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePricingModuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePricingModuleResponse
        /// </returns>
        public async Task<DescribePricingModuleResponse> DescribePricingModuleAsync(DescribePricingModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePricingModuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of products for a specified month.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are for cost allocation purposes only and cannot be used for settlement or reconciliation. This feature allocates your cloud expenses, including both subscription and pay-as-you-go fees, based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. Data for the current month is not final. This is because it does not include unsettled pay-as-you-go fees and may change due to events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Amortized cost data for the past 12 months is available.</description></item>
        /// <item><description>Data for attached resources, which requires you to enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>, is updated 48 hours after the split bill is generated. Data for other resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs were not updated during the month. They were updated only after 12:00 on the sixth day of the following month. In addition, cost details for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available for this period.</description></item>
        /// <item><description>Amortized cost data becomes available 48 hours after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProductAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductAmortizedCostByAmortizationPeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of products for a specified month.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are for cost allocation purposes only and cannot be used for settlement or reconciliation. This feature allocates your cloud expenses, including both subscription and pay-as-you-go fees, based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. Data for the current month is not final. This is because it does not include unsettled pay-as-you-go fees and may change due to events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Amortized cost data for the past 12 months is available.</description></item>
        /// <item><description>Data for attached resources, which requires you to enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>, is updated 48 hours after the split bill is generated. Data for other resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs were not updated during the month. They were updated only after 12:00 on the sixth day of the following month. In addition, cost details for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available for this period.</description></item>
        /// <item><description>Amortized cost data becomes available 48 hours after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProductAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductAmortizedCostByAmortizationPeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of products for a specified month.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are for cost allocation purposes only and cannot be used for settlement or reconciliation. This feature allocates your cloud expenses, including both subscription and pay-as-you-go fees, based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. Data for the current month is not final. This is because it does not include unsettled pay-as-you-go fees and may change due to events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Amortized cost data for the past 12 months is available.</description></item>
        /// <item><description>Data for attached resources, which requires you to enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>, is updated 48 hours after the split bill is generated. Data for other resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs were not updated during the month. They were updated only after 12:00 on the sixth day of the following month. In addition, cost details for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available for this period.</description></item>
        /// <item><description>Amortized cost data becomes available 48 hours after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProductAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductAmortizedCostByAmortizationPeriodResponse
        /// </returns>
        public DescribeProductAmortizedCostByAmortizationPeriodResponse DescribeProductAmortizedCostByAmortizationPeriod(DescribeProductAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductAmortizedCostByAmortizationPeriodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of products for a specified month.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are for cost allocation purposes only and cannot be used for settlement or reconciliation. This feature allocates your cloud expenses, including both subscription and pay-as-you-go fees, based on specified allocation rules.</description></item>
        /// <item><description>The final data for a month is available after 12:00 on the sixth day of the following month. Data for the current month is not final. This is because it does not include unsettled pay-as-you-go fees and may change due to events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Amortized cost data for the past 12 months is available.</description></item>
        /// <item><description>Data for attached resources, which requires you to enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>, is updated 48 hours after the split bill is generated. Data for other resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs were not updated during the month. They were updated only after 12:00 on the sixth day of the following month. In addition, cost details for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available for this period.</description></item>
        /// <item><description>Amortized cost data becomes available 48 hours after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProductAmortizedCostByAmortizationPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductAmortizedCostByAmortizationPeriodResponse
        /// </returns>
        public async Task<DescribeProductAmortizedCostByAmortizationPeriodResponse> DescribeProductAmortizedCostByAmortizationPeriodAsync(DescribeProductAmortizedCostByAmortizationPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductAmortizedCostByAmortizationPeriodWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of a product for a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are used for cost allocation and cannot be used for settlement or reconciliation. This feature allocates your cloud expenses, including both subscription and pay-as-you-go fees, based on specified rules.</description></item>
        /// <item><description>The final data for a given month is available after 12:00 on the sixth day of the following month. This delay ensures that potential mid-month events, such as delayed billing, refunds, bill adjustments, and overdue payment write-offs, are included. Data for the current month does not include unsettled pay-as-you-go fees that have not yet been billed or are still accumulating.</description></item>
        /// <item><description>Amortized cost data for the past 12 months is available.</description></item>
        /// <item><description>Data related to attached resources is updated in the amortized costs 48 hours after the corresponding split bill is generated. To view the costs of attached resources, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data that is not related to attached resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs were not updated mid-month and were only updated after 12:00 on the sixth day of the following month. Additionally, for this period, specific costs for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available.</description></item>
        /// <item><description>Amortized cost data is provided only after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature. The data is available 48 hours after you enable it.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProductAmortizedCostByConsumePeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductAmortizedCostByConsumePeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of a product for a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are used for cost allocation and cannot be used for settlement or reconciliation. This feature allocates your cloud expenses, including both subscription and pay-as-you-go fees, based on specified rules.</description></item>
        /// <item><description>The final data for a given month is available after 12:00 on the sixth day of the following month. This delay ensures that potential mid-month events, such as delayed billing, refunds, bill adjustments, and overdue payment write-offs, are included. Data for the current month does not include unsettled pay-as-you-go fees that have not yet been billed or are still accumulating.</description></item>
        /// <item><description>Amortized cost data for the past 12 months is available.</description></item>
        /// <item><description>Data related to attached resources is updated in the amortized costs 48 hours after the corresponding split bill is generated. To view the costs of attached resources, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data that is not related to attached resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs were not updated mid-month and were only updated after 12:00 on the sixth day of the following month. Additionally, for this period, specific costs for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available.</description></item>
        /// <item><description>Amortized cost data is provided only after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature. The data is available 48 hours after you enable it.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProductAmortizedCostByConsumePeriodRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductAmortizedCostByConsumePeriodResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of a product for a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are used for cost allocation and cannot be used for settlement or reconciliation. This feature allocates your cloud expenses, including both subscription and pay-as-you-go fees, based on specified rules.</description></item>
        /// <item><description>The final data for a given month is available after 12:00 on the sixth day of the following month. This delay ensures that potential mid-month events, such as delayed billing, refunds, bill adjustments, and overdue payment write-offs, are included. Data for the current month does not include unsettled pay-as-you-go fees that have not yet been billed or are still accumulating.</description></item>
        /// <item><description>Amortized cost data for the past 12 months is available.</description></item>
        /// <item><description>Data related to attached resources is updated in the amortized costs 48 hours after the corresponding split bill is generated. To view the costs of attached resources, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data that is not related to attached resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs were not updated mid-month and were only updated after 12:00 on the sixth day of the following month. Additionally, for this period, specific costs for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available.</description></item>
        /// <item><description>Amortized cost data is provided only after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature. The data is available 48 hours after you enable it.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProductAmortizedCostByConsumePeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductAmortizedCostByConsumePeriodResponse
        /// </returns>
        public DescribeProductAmortizedCostByConsumePeriodResponse DescribeProductAmortizedCostByConsumePeriod(DescribeProductAmortizedCostByConsumePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductAmortizedCostByConsumePeriodWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monthly amortized cost of a product for a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Amortized costs are used for cost allocation and cannot be used for settlement or reconciliation. This feature allocates your cloud expenses, including both subscription and pay-as-you-go fees, based on specified rules.</description></item>
        /// <item><description>The final data for a given month is available after 12:00 on the sixth day of the following month. This delay ensures that potential mid-month events, such as delayed billing, refunds, bill adjustments, and overdue payment write-offs, are included. Data for the current month does not include unsettled pay-as-you-go fees that have not yet been billed or are still accumulating.</description></item>
        /// <item><description>Amortized cost data for the past 12 months is available.</description></item>
        /// <item><description>Data related to attached resources is updated in the amortized costs 48 hours after the corresponding split bill is generated. To view the costs of attached resources, you must first enable <a href="https://usercenter2.aliyun.com/finance/split-bill">split bills</a>. Data that is not related to attached resources is updated 48 hours after the detailed bill is generated.</description></item>
        /// <item><description>For months before August 2021, amortized costs were not updated mid-month and were only updated after 12:00 on the sixth day of the following month. Additionally, for this period, specific costs for attached resources, such as domain names, buckets, and EIPs, for products such as CDN, OSS, and Internet Shared Bandwidth are not available.</description></item>
        /// <item><description>Amortized cost data is provided only after you enable the <a href="https://usercenter2.aliyun.com/finance/amortized-costs">Amortized Cost</a> feature. The data is available 48 hours after you enable it.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeProductAmortizedCostByConsumePeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProductAmortizedCostByConsumePeriodResponse
        /// </returns>
        public async Task<DescribeProductAmortizedCostByConsumePeriodResponse> DescribeProductAmortizedCostByConsumePeriodAsync(DescribeProductAmortizedCostByConsumePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductAmortizedCostByConsumePeriodWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage details of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>The data is consistent with the list data in the Coverage Overview section of the Resource Instance Management menu in the User Center.</description></item>
        /// <item><description>Currently, coverage queries are supported for reserved instances (RIs) and storage capacity units (SCUs).</description></item>
        /// <item><description>Coverage queries are provided in three dimensions: hour, day, and month.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeResourceCoverageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceCoverageDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage details of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>The data is consistent with the list data in the Coverage Overview section of the Resource Instance Management menu in the User Center.</description></item>
        /// <item><description>Currently, coverage queries are supported for reserved instances (RIs) and storage capacity units (SCUs).</description></item>
        /// <item><description>Coverage queries are provided in three dimensions: hour, day, and month.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeResourceCoverageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceCoverageDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage details of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>The data is consistent with the list data in the Coverage Overview section of the Resource Instance Management menu in the User Center.</description></item>
        /// <item><description>Currently, coverage queries are supported for reserved instances (RIs) and storage capacity units (SCUs).</description></item>
        /// <item><description>Coverage queries are provided in three dimensions: hour, day, and month.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeResourceCoverageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceCoverageDetailResponse
        /// </returns>
        public DescribeResourceCoverageDetailResponse DescribeResourceCoverageDetail(DescribeResourceCoverageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceCoverageDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage details of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>The data is consistent with the list data in the Coverage Overview section of the Resource Instance Management menu in the User Center.</description></item>
        /// <item><description>Currently, coverage queries are supported for reserved instances (RIs) and storage capacity units (SCUs).</description></item>
        /// <item><description>Coverage queries are provided in three dimensions: hour, day, and month.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeResourceCoverageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceCoverageDetailResponse
        /// </returns>
        public async Task<DescribeResourceCoverageDetailResponse> DescribeResourceCoverageDetailAsync(DescribeResourceCoverageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceCoverageDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage summary of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns the same summary data as the Coverage Overview in the Resource Instance Management menu of the User Center.
        /// Currently, coverage queries are supported for two resource types: reserved instances (RIs) and storage capacity units (SCUs).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeResourceCoverageTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceCoverageTotalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage summary of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns the same summary data as the Coverage Overview in the Resource Instance Management menu of the User Center.
        /// Currently, coverage queries are supported for two resource types: reserved instances (RIs) and storage capacity units (SCUs).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeResourceCoverageTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceCoverageTotalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage summary of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns the same summary data as the Coverage Overview in the Resource Instance Management menu of the User Center.
        /// Currently, coverage queries are supported for two resource types: reserved instances (RIs) and storage capacity units (SCUs).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeResourceCoverageTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceCoverageTotalResponse
        /// </returns>
        public DescribeResourceCoverageTotalResponse DescribeResourceCoverageTotal(DescribeResourceCoverageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceCoverageTotalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage summary of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns the same summary data as the Coverage Overview in the Resource Instance Management menu of the User Center.
        /// Currently, coverage queries are supported for two resource types: reserved instances (RIs) and storage capacity units (SCUs).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeResourceCoverageTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceCoverageTotalResponse
        /// </returns>
        public async Task<DescribeResourceCoverageTotalResponse> DescribeResourceCoverageTotalAsync(DescribeResourceCoverageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceCoverageTotalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about resource plans of an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourcePackageProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourcePackageProductResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about resource plans of an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourcePackageProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourcePackageProductResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about resource plans of an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourcePackageProductRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourcePackageProductResponse
        /// </returns>
        public DescribeResourcePackageProductResponse DescribeResourcePackageProduct(DescribeResourcePackageProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePackageProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about resource plans of an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourcePackageProductRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourcePackageProductResponse
        /// </returns>
        public async Task<DescribeResourcePackageProductResponse> DescribeResourcePackageProductAsync(DescribeResourcePackageProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePackageProductWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage details of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceUsageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceUsageDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage details of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceUsageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceUsageDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage details of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceUsageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceUsageDetailResponse
        /// </returns>
        public DescribeResourceUsageDetailResponse DescribeResourceUsageDetail(DescribeResourceUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceUsageDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage details of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceUsageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceUsageDetailResponse
        /// </returns>
        public async Task<DescribeResourceUsageDetailResponse> DescribeResourceUsageDetailAsync(DescribeResourceUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceUsageDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceUsageTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceUsageTotalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceUsageTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceUsageTotalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceUsageTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceUsageTotalResponse
        /// </returns>
        public DescribeResourceUsageTotalResponse DescribeResourceUsageTotal(DescribeResourceUsageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceUsageTotalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of reserved instances and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeResourceUsageTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceUsageTotalResponse
        /// </returns>
        public async Task<DescribeResourceUsageTotalResponse> DescribeResourceUsageTotalAsync(DescribeResourceUsageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceUsageTotalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage details of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSavingsPlansCoverageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansCoverageDetailResponse
        /// </returns>
        public DescribeSavingsPlansCoverageDetailResponse DescribeSavingsPlansCoverageDetailWithOptions(DescribeSavingsPlansCoverageDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSavingsPlansCoverageDetailShrinkRequest request = new DescribeSavingsPlansCoverageDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterParam))
            {
                request.FilterParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterParam, "FilterParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterParamShrink))
            {
                query["FilterParam"] = request.FilterParamShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage details of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSavingsPlansCoverageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansCoverageDetailResponse
        /// </returns>
        public async Task<DescribeSavingsPlansCoverageDetailResponse> DescribeSavingsPlansCoverageDetailWithOptionsAsync(DescribeSavingsPlansCoverageDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSavingsPlansCoverageDetailShrinkRequest request = new DescribeSavingsPlansCoverageDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterParam))
            {
                request.FilterParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterParam, "FilterParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterParamShrink))
            {
                query["FilterParam"] = request.FilterParamShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage details of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSavingsPlansCoverageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansCoverageDetailResponse
        /// </returns>
        public DescribeSavingsPlansCoverageDetailResponse DescribeSavingsPlansCoverageDetail(DescribeSavingsPlansCoverageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSavingsPlansCoverageDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the coverage details of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSavingsPlansCoverageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansCoverageDetailResponse
        /// </returns>
        public async Task<DescribeSavingsPlansCoverageDetailResponse> DescribeSavingsPlansCoverageDetailAsync(DescribeSavingsPlansCoverageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSavingsPlansCoverageDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the summary of savings plan coverage.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSavingsPlansCoverageTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansCoverageTotalResponse
        /// </returns>
        public DescribeSavingsPlansCoverageTotalResponse DescribeSavingsPlansCoverageTotalWithOptions(DescribeSavingsPlansCoverageTotalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSavingsPlansCoverageTotalShrinkRequest request = new DescribeSavingsPlansCoverageTotalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterParam))
            {
                request.FilterParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterParam, "FilterParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterParamShrink))
            {
                query["FilterParam"] = request.FilterParamShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the summary of savings plan coverage.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSavingsPlansCoverageTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansCoverageTotalResponse
        /// </returns>
        public async Task<DescribeSavingsPlansCoverageTotalResponse> DescribeSavingsPlansCoverageTotalWithOptionsAsync(DescribeSavingsPlansCoverageTotalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSavingsPlansCoverageTotalShrinkRequest request = new DescribeSavingsPlansCoverageTotalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterParam))
            {
                request.FilterParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterParam, "FilterParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterParamShrink))
            {
                query["FilterParam"] = request.FilterParamShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the summary of savings plan coverage.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSavingsPlansCoverageTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansCoverageTotalResponse
        /// </returns>
        public DescribeSavingsPlansCoverageTotalResponse DescribeSavingsPlansCoverageTotal(DescribeSavingsPlansCoverageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSavingsPlansCoverageTotalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the summary of savings plan coverage.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSavingsPlansCoverageTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansCoverageTotalResponse
        /// </returns>
        public async Task<DescribeSavingsPlansCoverageTotalResponse> DescribeSavingsPlansCoverageTotalAsync(DescribeSavingsPlansCoverageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSavingsPlansCoverageTotalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage details of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSavingsPlansUsageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansUsageDetailResponse
        /// </returns>
        public DescribeSavingsPlansUsageDetailResponse DescribeSavingsPlansUsageDetailWithOptions(DescribeSavingsPlansUsageDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSavingsPlansUsageDetailShrinkRequest request = new DescribeSavingsPlansUsageDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterParam))
            {
                request.FilterParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterParam, "FilterParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterParamShrink))
            {
                query["FilterParam"] = request.FilterParamShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage details of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSavingsPlansUsageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansUsageDetailResponse
        /// </returns>
        public async Task<DescribeSavingsPlansUsageDetailResponse> DescribeSavingsPlansUsageDetailWithOptionsAsync(DescribeSavingsPlansUsageDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSavingsPlansUsageDetailShrinkRequest request = new DescribeSavingsPlansUsageDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterParam))
            {
                request.FilterParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterParam, "FilterParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterParamShrink))
            {
                query["FilterParam"] = request.FilterParamShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage details of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSavingsPlansUsageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansUsageDetailResponse
        /// </returns>
        public DescribeSavingsPlansUsageDetailResponse DescribeSavingsPlansUsageDetail(DescribeSavingsPlansUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSavingsPlansUsageDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage details of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSavingsPlansUsageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansUsageDetailResponse
        /// </returns>
        public async Task<DescribeSavingsPlansUsageDetailResponse> DescribeSavingsPlansUsageDetailAsync(DescribeSavingsPlansUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSavingsPlansUsageDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSavingsPlansUsageTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansUsageTotalResponse
        /// </returns>
        public DescribeSavingsPlansUsageTotalResponse DescribeSavingsPlansUsageTotalWithOptions(DescribeSavingsPlansUsageTotalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSavingsPlansUsageTotalShrinkRequest request = new DescribeSavingsPlansUsageTotalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterParam))
            {
                request.FilterParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterParam, "FilterParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterParamShrink))
            {
                query["FilterParam"] = request.FilterParamShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSavingsPlansUsageTotalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansUsageTotalResponse
        /// </returns>
        public async Task<DescribeSavingsPlansUsageTotalResponse> DescribeSavingsPlansUsageTotalWithOptionsAsync(DescribeSavingsPlansUsageTotalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSavingsPlansUsageTotalShrinkRequest request = new DescribeSavingsPlansUsageTotalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterParam))
            {
                request.FilterParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterParam, "FilterParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillOwnerId))
            {
                query["BillOwnerId"] = request.BillOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPeriod))
            {
                query["EndPeriod"] = request.EndPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterParamShrink))
            {
                query["FilterParam"] = request.FilterParamShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSavingsPlansUsageTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansUsageTotalResponse
        /// </returns>
        public DescribeSavingsPlansUsageTotalResponse DescribeSavingsPlansUsageTotal(DescribeSavingsPlansUsageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSavingsPlansUsageTotalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSavingsPlansUsageTotalRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSavingsPlansUsageTotalResponse
        /// </returns>
        public async Task<DescribeSavingsPlansUsageTotalResponse> DescribeSavingsPlansUsageTotalAsync(DescribeSavingsPlansUsageTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSavingsPlansUsageTotalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries split bills.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month\&quot;s split bills are for reference only and cannot be used as the basis for reconciliation. The final bill for the current month can be queried after 12:00 on the 4th day of the next month. The split bill data for the current month does not include unsettled pay-as-you-go data (unbilled or being accumulated).</description></item>
        /// <item><description>Split bill data is available for the last 12 months.</description></item>
        /// <item><description>Split bill data is updated with a 48-hour delay compared to actual expenses. For split cloud services (such as CDN, OSS, and Internet Shared Bandwidth), the specific expenses for each attached resource (such as domain names, buckets, and EIPs) are updated with a 72-hour delay.</description></item>
        /// <item><description>Split bill data is available only after you enable the feature on the &lt;props=&quot;china&quot;&gt;<a href="https://usercenter2.aliyun.com/finance/split-bill">Split Bill</a>&lt;props=&quot;intl&quot;&gt;<a href="https://usercenter2-intl.aliyun.com/finance/split-bill">Split Bill</a> page in the console. The data becomes available 24 hours after you enable the feature.</description></item>
        /// <item><description>The rate limit is 10 requests per second per user. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSplitItemBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSplitItemBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries split bills.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month\&quot;s split bills are for reference only and cannot be used as the basis for reconciliation. The final bill for the current month can be queried after 12:00 on the 4th day of the next month. The split bill data for the current month does not include unsettled pay-as-you-go data (unbilled or being accumulated).</description></item>
        /// <item><description>Split bill data is available for the last 12 months.</description></item>
        /// <item><description>Split bill data is updated with a 48-hour delay compared to actual expenses. For split cloud services (such as CDN, OSS, and Internet Shared Bandwidth), the specific expenses for each attached resource (such as domain names, buckets, and EIPs) are updated with a 72-hour delay.</description></item>
        /// <item><description>Split bill data is available only after you enable the feature on the &lt;props=&quot;china&quot;&gt;<a href="https://usercenter2.aliyun.com/finance/split-bill">Split Bill</a>&lt;props=&quot;intl&quot;&gt;<a href="https://usercenter2-intl.aliyun.com/finance/split-bill">Split Bill</a> page in the console. The data becomes available 24 hours after you enable the feature.</description></item>
        /// <item><description>The rate limit is 10 requests per second per user. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSplitItemBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSplitItemBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries split bills.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month\&quot;s split bills are for reference only and cannot be used as the basis for reconciliation. The final bill for the current month can be queried after 12:00 on the 4th day of the next month. The split bill data for the current month does not include unsettled pay-as-you-go data (unbilled or being accumulated).</description></item>
        /// <item><description>Split bill data is available for the last 12 months.</description></item>
        /// <item><description>Split bill data is updated with a 48-hour delay compared to actual expenses. For split cloud services (such as CDN, OSS, and Internet Shared Bandwidth), the specific expenses for each attached resource (such as domain names, buckets, and EIPs) are updated with a 72-hour delay.</description></item>
        /// <item><description>Split bill data is available only after you enable the feature on the &lt;props=&quot;china&quot;&gt;<a href="https://usercenter2.aliyun.com/finance/split-bill">Split Bill</a>&lt;props=&quot;intl&quot;&gt;<a href="https://usercenter2-intl.aliyun.com/finance/split-bill">Split Bill</a> page in the console. The data becomes available 24 hours after you enable the feature.</description></item>
        /// <item><description>The rate limit is 10 requests per second per user. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSplitItemBillRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSplitItemBillResponse
        /// </returns>
        public DescribeSplitItemBillResponse DescribeSplitItemBill(DescribeSplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSplitItemBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries split bills.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month\&quot;s split bills are for reference only and cannot be used as the basis for reconciliation. The final bill for the current month can be queried after 12:00 on the 4th day of the next month. The split bill data for the current month does not include unsettled pay-as-you-go data (unbilled or being accumulated).</description></item>
        /// <item><description>Split bill data is available for the last 12 months.</description></item>
        /// <item><description>Split bill data is updated with a 48-hour delay compared to actual expenses. For split cloud services (such as CDN, OSS, and Internet Shared Bandwidth), the specific expenses for each attached resource (such as domain names, buckets, and EIPs) are updated with a 72-hour delay.</description></item>
        /// <item><description>Split bill data is available only after you enable the feature on the &lt;props=&quot;china&quot;&gt;<a href="https://usercenter2.aliyun.com/finance/split-bill">Split Bill</a>&lt;props=&quot;intl&quot;&gt;<a href="https://usercenter2-intl.aliyun.com/finance/split-bill">Split Bill</a> page in the console. The data becomes available 24 hours after you enable the feature.</description></item>
        /// <item><description>The rate limit is 10 requests per second per user. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSplitItemBillRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSplitItemBillResponse
        /// </returns>
        public async Task<DescribeSplitItemBillResponse> DescribeSplitItemBillAsync(DescribeSplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSplitItemBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an account linking.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an account linking.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an account linking.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccountRelationResponse
        /// </returns>
        public GetAccountRelationResponse GetAccountRelation(GetAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an account linking.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccountRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccountRelationResponse
        /// </returns>
        public async Task<GetAccountRelationResponse> GetAccountRelationAsync(GetAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the account information of an end customer under a partner.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerAccountInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the account information of an end customer under a partner.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerAccountInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the account information of an end customer under a partner.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerAccountInfoResponse
        /// </returns>
        public GetCustomerAccountInfoResponse GetCustomerAccountInfo(GetCustomerAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerAccountInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the account information of an end customer under a partner.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerAccountInfoResponse
        /// </returns>
        public async Task<GetCustomerAccountInfoResponse> GetCustomerAccountInfoAsync(GetCustomerAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerAccountInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of end customer UIDs under a partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The system queries the list of associated end customer UIDs based on the AccessKey pair in the request.</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of end customer UIDs under a partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The system queries the list of associated end customer UIDs based on the AccessKey pair in the request.</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of end customer UIDs under a partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The system queries the list of associated end customer UIDs based on the AccessKey pair in the request.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetCustomerListResponse
        /// </returns>
        public GetCustomerListResponse GetCustomerList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerListWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of end customer UIDs under a partner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The system queries the list of associated end customer UIDs based on the AccessKey pair in the request.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetCustomerListResponse
        /// </returns>
        public async Task<GetCustomerListResponse> GetCustomerListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerListWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific order for a user or a distribution customer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrderDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrderDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific order for a user or a distribution customer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrderDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrderDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific order for a user or a distribution customer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrderDetailResponse
        /// </returns>
        public GetOrderDetailResponse GetOrderDetail(GetOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOrderDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific order for a user or a distribution customer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrderDetailResponse
        /// </returns>
        public async Task<GetOrderDetailResponse> GetOrderDetailAsync(GetOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOrderDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of a pay-as-you-go product.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Operation description</h3>
        /// <ol>
        /// <item><description>Call QueryProductList to obtain the product code. For more information, see <a href="https://help.aliyun.com/document_detail/95984.html">Query product information</a>.</description></item>
        /// <item><description>Call the DescribePricingModule operation to obtain the configuration parameters of a product. For more information, see <a href="https://help.aliyun.com/document_detail/96469.html">Query pricing module information</a>.</description></item>
        /// <item><description>Call this operation with the obtained product configuration parameters to query the price of a pay-as-you-go product.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPayAsYouGoPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPayAsYouGoPriceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of a pay-as-you-go product.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Operation description</h3>
        /// <ol>
        /// <item><description>Call QueryProductList to obtain the product code. For more information, see <a href="https://help.aliyun.com/document_detail/95984.html">Query product information</a>.</description></item>
        /// <item><description>Call the DescribePricingModule operation to obtain the configuration parameters of a product. For more information, see <a href="https://help.aliyun.com/document_detail/96469.html">Query pricing module information</a>.</description></item>
        /// <item><description>Call this operation with the obtained product configuration parameters to query the price of a pay-as-you-go product.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPayAsYouGoPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPayAsYouGoPriceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of a pay-as-you-go product.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Operation description</h3>
        /// <ol>
        /// <item><description>Call QueryProductList to obtain the product code. For more information, see <a href="https://help.aliyun.com/document_detail/95984.html">Query product information</a>.</description></item>
        /// <item><description>Call the DescribePricingModule operation to obtain the configuration parameters of a product. For more information, see <a href="https://help.aliyun.com/document_detail/96469.html">Query pricing module information</a>.</description></item>
        /// <item><description>Call this operation with the obtained product configuration parameters to query the price of a pay-as-you-go product.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPayAsYouGoPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPayAsYouGoPriceResponse
        /// </returns>
        public GetPayAsYouGoPriceResponse GetPayAsYouGoPrice(GetPayAsYouGoPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPayAsYouGoPriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of a pay-as-you-go product.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Operation description</h3>
        /// <ol>
        /// <item><description>Call QueryProductList to obtain the product code. For more information, see <a href="https://help.aliyun.com/document_detail/95984.html">Query product information</a>.</description></item>
        /// <item><description>Call the DescribePricingModule operation to obtain the configuration parameters of a product. For more information, see <a href="https://help.aliyun.com/document_detail/96469.html">Query pricing module information</a>.</description></item>
        /// <item><description>Call this operation with the obtained product configuration parameters to query the price of a pay-as-you-go product.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPayAsYouGoPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPayAsYouGoPriceResponse
        /// </returns>
        public async Task<GetPayAsYouGoPriceResponse> GetPayAsYouGoPriceAsync(GetPayAsYouGoPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPayAsYouGoPriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of a resource plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePackagePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePackagePriceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of a resource plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePackagePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePackagePriceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of a resource plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePackagePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePackagePriceResponse
        /// </returns>
        public GetResourcePackagePriceResponse GetResourcePackagePrice(GetResourcePackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourcePackagePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of a resource plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePackagePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePackagePriceResponse
        /// </returns>
        public async Task<GetResourcePackagePriceResponse> GetResourcePackagePriceAsync(GetResourcePackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourcePackagePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the prices of subscription products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Call QueryProductList to obtain the product code. For more information, see <a href="https://help.aliyun.com/document_detail/95984.html">Query product information</a>.</description></item>
        /// <item><description>Call the DescribePricingModule operation to obtain the configuration parameters of the product. For more information, see <a href="https://help.aliyun.com/document_detail/96469.html">Query product module information</a>.</description></item>
        /// <item><description>Call this operation to query the prices of subscription products based on the obtained product configuration parameters.</description></item>
        /// <item><description>Concatenate the Config parameter under ModuleList based on the config parameter returned by the DescribePricingModule operation. Do not omit any parameters. Otherwise, an error occurs during the price inquiry.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSubscriptionPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionPriceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the prices of subscription products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Call QueryProductList to obtain the product code. For more information, see <a href="https://help.aliyun.com/document_detail/95984.html">Query product information</a>.</description></item>
        /// <item><description>Call the DescribePricingModule operation to obtain the configuration parameters of the product. For more information, see <a href="https://help.aliyun.com/document_detail/96469.html">Query product module information</a>.</description></item>
        /// <item><description>Call this operation to query the prices of subscription products based on the obtained product configuration parameters.</description></item>
        /// <item><description>Concatenate the Config parameter under ModuleList based on the config parameter returned by the DescribePricingModule operation. Do not omit any parameters. Otherwise, an error occurs during the price inquiry.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSubscriptionPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionPriceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the prices of subscription products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Call QueryProductList to obtain the product code. For more information, see <a href="https://help.aliyun.com/document_detail/95984.html">Query product information</a>.</description></item>
        /// <item><description>Call the DescribePricingModule operation to obtain the configuration parameters of the product. For more information, see <a href="https://help.aliyun.com/document_detail/96469.html">Query product module information</a>.</description></item>
        /// <item><description>Call this operation to query the prices of subscription products based on the obtained product configuration parameters.</description></item>
        /// <item><description>Concatenate the Config parameter under ModuleList based on the config parameter returned by the DescribePricingModule operation. Do not omit any parameters. Otherwise, an error occurs during the price inquiry.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSubscriptionPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionPriceResponse
        /// </returns>
        public GetSubscriptionPriceResponse GetSubscriptionPrice(GetSubscriptionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubscriptionPriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the prices of subscription products.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Call QueryProductList to obtain the product code. For more information, see <a href="https://help.aliyun.com/document_detail/95984.html">Query product information</a>.</description></item>
        /// <item><description>Call the DescribePricingModule operation to obtain the configuration parameters of the product. For more information, see <a href="https://help.aliyun.com/document_detail/96469.html">Query product module information</a>.</description></item>
        /// <item><description>Call this operation to query the prices of subscription products based on the obtained product configuration parameters.</description></item>
        /// <item><description>Concatenate the Config parameter under ModuleList based on the config parameter returned by the DescribePricingModule operation. Do not omit any parameters. Otherwise, an error occurs during the price inquiry.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSubscriptionPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubscriptionPriceResponse
        /// </returns>
        public async Task<GetSubscriptionPriceResponse> GetSubscriptionPriceAsync(GetSubscriptionPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubscriptionPriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the refund amount for an instance that you want to unsubscribe from.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description><b>Carefully verify the information about the resource to be unsubscribed, and confirm the unsubscription terms and refund amount. Resources cannot be recovered after unsubscription.</b></description></item>
        /// <item><description>Only the actual paid amount is refunded. Used vouchers are not refunded.</description></item>
        /// <item><description>For other questions, refer to: &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/knowledge_detail/116043.html?spm=a2c81.e1d666e.app.2.62ae11271Kd6iM">Refund rules</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules">Refund rules for Alibaba Cloud International Website</a></description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// InquiryPriceRefundInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InquiryPriceRefundInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the refund amount for an instance that you want to unsubscribe from.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description><b>Carefully verify the information about the resource to be unsubscribed, and confirm the unsubscription terms and refund amount. Resources cannot be recovered after unsubscription.</b></description></item>
        /// <item><description>Only the actual paid amount is refunded. Used vouchers are not refunded.</description></item>
        /// <item><description>For other questions, refer to: &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/knowledge_detail/116043.html?spm=a2c81.e1d666e.app.2.62ae11271Kd6iM">Refund rules</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules">Refund rules for Alibaba Cloud International Website</a></description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// InquiryPriceRefundInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InquiryPriceRefundInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the refund amount for an instance that you want to unsubscribe from.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description><b>Carefully verify the information about the resource to be unsubscribed, and confirm the unsubscription terms and refund amount. Resources cannot be recovered after unsubscription.</b></description></item>
        /// <item><description>Only the actual paid amount is refunded. Used vouchers are not refunded.</description></item>
        /// <item><description>For other questions, refer to: &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/knowledge_detail/116043.html?spm=a2c81.e1d666e.app.2.62ae11271Kd6iM">Refund rules</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules">Refund rules for Alibaba Cloud International Website</a></description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// InquiryPriceRefundInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// InquiryPriceRefundInstanceResponse
        /// </returns>
        public InquiryPriceRefundInstanceResponse InquiryPriceRefundInstance(InquiryPriceRefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InquiryPriceRefundInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the refund amount for an instance that you want to unsubscribe from.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description><b>Carefully verify the information about the resource to be unsubscribed, and confirm the unsubscription terms and refund amount. Resources cannot be recovered after unsubscription.</b></description></item>
        /// <item><description>Only the actual paid amount is refunded. Used vouchers are not refunded.</description></item>
        /// <item><description>For other questions, refer to: &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/knowledge_detail/116043.html?spm=a2c81.e1d666e.app.2.62ae11271Kd6iM">Refund rules</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules">Refund rules for Alibaba Cloud International Website</a></description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// InquiryPriceRefundInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// InquiryPriceRefundInstanceResponse
        /// </returns>
        public async Task<InquiryPriceRefundInstanceResponse> InquiryPriceRefundInstanceAsync(InquiryPriceRefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InquiryPriceRefundInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or deletes permissions for an account linking relationship.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAccountRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccountRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or deletes permissions for an account linking relationship.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAccountRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccountRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or deletes permissions for an account linking relationship.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAccountRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccountRelationResponse
        /// </returns>
        public ModifyAccountRelationResponse ModifyAccountRelation(ModifyAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or deletes permissions for an account linking relationship.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAccountRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccountRelationResponse
        /// </returns>
        public async Task<ModifyAccountRelationResponse> ModifyAccountRelationAsync(ModifyAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies financial units. Batch modification is supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCostUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCostUnitResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies financial units. Batch modification is supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCostUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCostUnitResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies financial units. Batch modification is supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCostUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCostUnitResponse
        /// </returns>
        public ModifyCostUnitResponse ModifyCostUnit(ModifyCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCostUnitWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies financial units. Batch modification is supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCostUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCostUnitResponse
        /// </returns>
        public async Task<ModifyCostUnitResponse> ModifyCostUnitAsync(ModifyCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCostUnitWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource configuration of an instance. Invoking this operation creates an order for the Upgrade/Downgrade of instance resources and processes automatic payment. This operation does not support configuration changes for ECS or RDS products. Use the dedicated API of the corresponding product to execute the Upgrade/Downgrade.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource configuration of an instance. Invoking this operation creates an order for the Upgrade/Downgrade of instance resources and processes automatic payment. This operation does not support configuration changes for ECS or RDS products. Use the dedicated API of the corresponding product to execute the Upgrade/Downgrade.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource configuration of an instance. Invoking this operation creates an order for the Upgrade/Downgrade of instance resources and processes automatic payment. This operation does not support configuration changes for ECS or RDS products. Use the dedicated API of the corresponding product to execute the Upgrade/Downgrade.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public ModifyInstanceResponse ModifyInstance(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource configuration of an instance. Invoking this operation creates an order for the Upgrade/Downgrade of instance resources and processes automatic payment. This operation does not support configuration changes for ECS or RDS products. Use the dedicated API of the corresponding product to execute the Upgrade/Downgrade.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(ModifyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对客订单支付接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PayOrderResponse
        /// </returns>
        public PayOrderResponse PayOrderWithOptions(PayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerId))
            {
                query["BuyerId"] = request.BuyerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIds))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaySubmitUid))
            {
                query["PaySubmitUid"] = request.PaySubmitUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerId))
            {
                query["PayerId"] = request.PayerId;
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
                Action = "PayOrder",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PayOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对客订单支付接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PayOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PayOrderResponse
        /// </returns>
        public async Task<PayOrderResponse> PayOrderWithOptionsAsync(PayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerId))
            {
                query["BuyerId"] = request.BuyerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIds))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaySubmitUid))
            {
                query["PaySubmitUid"] = request.PaySubmitUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerId))
            {
                query["PayerId"] = request.PayerId;
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
                Action = "PayOrder",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对客订单支付接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// PayOrderResponse
        /// </returns>
        public PayOrderResponse PayOrder(PayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PayOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对客订单支付接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PayOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// PayOrderResponse
        /// </returns>
        public async Task<PayOrderResponse> PayOrderAsync(PayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PayOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the user\&quot;s account balance.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountBalanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the user\&quot;s account balance.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountBalanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the user\&quot;s account balance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryAccountBalanceResponse
        /// </returns>
        public QueryAccountBalanceResponse QueryAccountBalance()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountBalanceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the user\&quot;s account balance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryAccountBalanceResponse
        /// </returns>
        public async Task<QueryAccountBalanceResponse> QueryAccountBalanceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountBalanceWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries account spending within a billing cycle and aggregates the data by resource owner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Data for the current month is for reference only. Do not use it for reconciliation. The final bill for the current month is available to view or export after 12:00 on the third day of the next month. This delay accounts for mid-month events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Data from the last 18 months is available.</description></item>
        /// <item><description>Billing data is updated 24 hours after actual resource consumption. Information related to instance IDs, such as instance configurations, instance types, instance nicknames, resource groups, public IP addresses, private IP addresses, and zones, is updated with a 48-hour delay.</description></item>
        /// <item><description>Billing data does not include the costs of attached resources, such as domain names, buckets, and elastic IP addresses (EIPs), for products such as CDN, OSS, and Internet Shared Bandwidth. To view statistics that include data for attached resources, go to Split Bill.</description></item>
        /// <item><description>For Alibaba Cloud Communications products, detailed data is available only from June 2020 onwards. For HiChina products, such as Domain Names and trademarks, detailed data is available only from November 2020 onwards.</description></item>
        /// <item><description>Each account is limited to 10 queries per second. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryAccountBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries account spending within a billing cycle and aggregates the data by resource owner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Data for the current month is for reference only. Do not use it for reconciliation. The final bill for the current month is available to view or export after 12:00 on the third day of the next month. This delay accounts for mid-month events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Data from the last 18 months is available.</description></item>
        /// <item><description>Billing data is updated 24 hours after actual resource consumption. Information related to instance IDs, such as instance configurations, instance types, instance nicknames, resource groups, public IP addresses, private IP addresses, and zones, is updated with a 48-hour delay.</description></item>
        /// <item><description>Billing data does not include the costs of attached resources, such as domain names, buckets, and elastic IP addresses (EIPs), for products such as CDN, OSS, and Internet Shared Bandwidth. To view statistics that include data for attached resources, go to Split Bill.</description></item>
        /// <item><description>For Alibaba Cloud Communications products, detailed data is available only from June 2020 onwards. For HiChina products, such as Domain Names and trademarks, detailed data is available only from November 2020 onwards.</description></item>
        /// <item><description>Each account is limited to 10 queries per second. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryAccountBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries account spending within a billing cycle and aggregates the data by resource owner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Data for the current month is for reference only. Do not use it for reconciliation. The final bill for the current month is available to view or export after 12:00 on the third day of the next month. This delay accounts for mid-month events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Data from the last 18 months is available.</description></item>
        /// <item><description>Billing data is updated 24 hours after actual resource consumption. Information related to instance IDs, such as instance configurations, instance types, instance nicknames, resource groups, public IP addresses, private IP addresses, and zones, is updated with a 48-hour delay.</description></item>
        /// <item><description>Billing data does not include the costs of attached resources, such as domain names, buckets, and elastic IP addresses (EIPs), for products such as CDN, OSS, and Internet Shared Bandwidth. To view statistics that include data for attached resources, go to Split Bill.</description></item>
        /// <item><description>For Alibaba Cloud Communications products, detailed data is available only from June 2020 onwards. For HiChina products, such as Domain Names and trademarks, detailed data is available only from November 2020 onwards.</description></item>
        /// <item><description>Each account is limited to 10 queries per second. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryAccountBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountBillResponse
        /// </returns>
        public QueryAccountBillResponse QueryAccountBill(QueryAccountBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries account spending within a billing cycle and aggregates the data by resource owner.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Data for the current month is for reference only. Do not use it for reconciliation. The final bill for the current month is available to view or export after 12:00 on the third day of the next month. This delay accounts for mid-month events such as delayed billing, refunds, bill adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Data from the last 18 months is available.</description></item>
        /// <item><description>Billing data is updated 24 hours after actual resource consumption. Information related to instance IDs, such as instance configurations, instance types, instance nicknames, resource groups, public IP addresses, private IP addresses, and zones, is updated with a 48-hour delay.</description></item>
        /// <item><description>Billing data does not include the costs of attached resources, such as domain names, buckets, and elastic IP addresses (EIPs), for products such as CDN, OSS, and Internet Shared Bandwidth. To view statistics that include data for attached resources, go to Split Bill.</description></item>
        /// <item><description>For Alibaba Cloud Communications products, detailed data is available only from June 2020 onwards. For HiChina products, such as Domain Names and trademarks, detailed data is available only from November 2020 onwards.</description></item>
        /// <item><description>Each account is limited to 10 queries per second. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryAccountBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountBillResponse
        /// </returns>
        public async Task<QueryAccountBillResponse> QueryAccountBillAsync(QueryAccountBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the income and expenditure details of account transactions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTransactionDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTransactionDetailsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the income and expenditure details of account transactions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTransactionDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTransactionDetailsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the income and expenditure details of account transactions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTransactionDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTransactionDetailsResponse
        /// </returns>
        public QueryAccountTransactionDetailsResponse QueryAccountTransactionDetails(QueryAccountTransactionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountTransactionDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the income and expenditure details of account transactions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTransactionDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTransactionDetailsResponse
        /// </returns>
        public async Task<QueryAccountTransactionDetailsResponse> QueryAccountTransactionDetailsAsync(QueryAccountTransactionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountTransactionDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the transaction records of a user account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTransactionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTransactionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the transaction records of a user account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTransactionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTransactionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the transaction records of a user account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTransactionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTransactionsResponse
        /// </returns>
        public QueryAccountTransactionsResponse QueryAccountTransactions(QueryAccountTransactionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountTransactionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the transaction records of a user account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTransactionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTransactionsResponse
        /// </returns>
        public async Task<QueryAccountTransactionsResponse> QueryAccountTransactionsAsync(QueryAccountTransactionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountTransactionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available instances for the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available instances for the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available instances for the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableInstancesResponse
        /// </returns>
        public QueryAvailableInstancesResponse QueryAvailableInstances(QueryAvailableInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAvailableInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available instances for the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableInstancesResponse
        /// </returns>
        public async Task<QueryAvailableInstancesResponse> QueryAvailableInstancesAsync(QueryAvailableInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAvailableInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settlement bills of a user within a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settlement bills of a user within a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settlement bills of a user within a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBillResponse
        /// </returns>
        public QueryBillResponse QueryBill(QueryBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settlement bills of a user within a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBillResponse
        /// </returns>
        public async Task<QueryBillResponse> QueryBillAsync(QueryBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bill overview of a user for a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBillOverviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBillOverviewResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bill overview of a user for a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBillOverviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBillOverviewResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bill overview of a user for a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBillOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBillOverviewResponse
        /// </returns>
        public QueryBillOverviewResponse QueryBillOverview(QueryBillOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillOverviewWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bill overview of a user for a specific billing cycle.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBillOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBillOverviewResponse
        /// </returns>
        public async Task<QueryBillOverviewResponse> QueryBillOverviewAsync(QueryBillOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillOverviewWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the records of bill subscriptions to OSS buckets.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBillToOSSSubscriptionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the records of bill subscriptions to OSS buckets.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBillToOSSSubscriptionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the records of bill subscriptions to OSS buckets.</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryBillToOSSSubscriptionResponse
        /// </returns>
        public QueryBillToOSSSubscriptionResponse QueryBillToOSSSubscription()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBillToOSSSubscriptionWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the records of bill subscriptions to OSS buckets.</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryBillToOSSSubscriptionResponse
        /// </returns>
        public async Task<QueryBillToOSSSubscriptionResponse> QueryBillToOSSSubscriptionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBillToOSSSubscriptionWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user voucher information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCashCouponsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCashCouponsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user voucher information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCashCouponsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCashCouponsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user voucher information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCashCouponsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCashCouponsResponse
        /// </returns>
        public QueryCashCouponsResponse QueryCashCoupons(QueryCashCouponsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCashCouponsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user voucher information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCashCouponsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCashCouponsResponse
        /// </returns>
        public async Task<QueryCashCouponsResponse> QueryCashCouponsAsync(QueryCashCouponsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCashCouponsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of commodity information based on a product code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of commodity information based on a product code.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCommodityListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCommodityListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of commodity information based on a product code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of commodity information based on a product code.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCommodityListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCommodityListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of commodity information based on a product code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of commodity information based on a product code.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCommodityListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCommodityListResponse
        /// </returns>
        public QueryCommodityListResponse QueryCommodityList(QueryCommodityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCommodityListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of commodity information based on a product code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of commodity information based on a product code.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCommodityListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCommodityListResponse
        /// </returns>
        public async Task<QueryCommodityListResponse> QueryCommodityListAsync(QueryCommodityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCommodityListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all financial unit nodes under the current node of the financial unit tree. If ParentUnitId is set to -1, all financial units are queried.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCostUnitResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all financial unit nodes under the current node of the financial unit tree. If ParentUnitId is set to -1, all financial units are queried.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostUnitRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCostUnitResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all financial unit nodes under the current node of the financial unit tree. If ParentUnitId is set to -1, all financial units are queried.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCostUnitResponse
        /// </returns>
        public QueryCostUnitResponse QueryCostUnit(QueryCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCostUnitWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all financial unit nodes under the current node of the financial unit tree. If ParentUnitId is set to -1, all financial units are queried.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCostUnitResponse
        /// </returns>
        public async Task<QueryCostUnitResponse> QueryCostUnitAsync(QueryCostUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCostUnitWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource instances that belong to a financial unit of a user. When UnitId is set to 0, the query returns unallocated primary and sub-resource instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostUnitResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCostUnitResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource instances that belong to a financial unit of a user. When UnitId is set to 0, the query returns unallocated primary and sub-resource instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostUnitResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCostUnitResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource instances that belong to a financial unit of a user. When UnitId is set to 0, the query returns unallocated primary and sub-resource instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostUnitResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCostUnitResourceResponse
        /// </returns>
        public QueryCostUnitResourceResponse QueryCostUnitResource(QueryCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCostUnitResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource instances that belong to a financial unit of a user. When UnitId is set to 0, the query returns unallocated primary and sub-resource instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostUnitResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCostUnitResourceResponse
        /// </returns>
        public async Task<QueryCostUnitResourceResponse> QueryCostUnitResourceAsync(QueryCostUnitResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCostUnitResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Alibaba Cloud invoice mailing address information service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerAddressListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerAddressListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Alibaba Cloud invoice mailing address information service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerAddressListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerAddressListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Alibaba Cloud invoice mailing address information service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerAddressListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerAddressListResponse
        /// </returns>
        public QueryCustomerAddressListResponse QueryCustomerAddressList(QueryCustomerAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomerAddressListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Alibaba Cloud invoice mailing address information service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerAddressListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerAddressListResponse
        /// </returns>
        public async Task<QueryCustomerAddressListResponse> QueryCustomerAddressListAsync(QueryCustomerAddressListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomerAddressListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of resource plans, including reserved instances (RIs) and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>Only usage records from the past year are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDPUtilizationDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDPUtilizationDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of resource plans, including reserved instances (RIs) and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>Only usage records from the past year are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDPUtilizationDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDPUtilizationDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of resource plans, including reserved instances (RIs) and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>Only usage records from the past year are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDPUtilizationDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDPUtilizationDetailResponse
        /// </returns>
        public QueryDPUtilizationDetailResponse QueryDPUtilizationDetail(QueryDPUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDPUtilizationDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of resource plans, including reserved instances (RIs) and storage capacity units (SCUs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>Only usage records from the past year are supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDPUtilizationDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDPUtilizationDetailResponse
        /// </returns>
        public async Task<QueryDPUtilizationDetailResponse> QueryDPUtilizationDetailAsync(QueryDPUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDPUtilizationDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of objects that are eligible for invoicing.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEvaluateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEvaluateListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of objects that are eligible for invoicing.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEvaluateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEvaluateListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of objects that are eligible for invoicing.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEvaluateListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEvaluateListResponse
        /// </returns>
        public QueryEvaluateListResponse QueryEvaluateList(QueryEvaluateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEvaluateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of objects that are eligible for invoicing.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEvaluateListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEvaluateListResponse
        /// </returns>
        public async Task<QueryEvaluateListResponse> QueryEvaluateListAsync(QueryEvaluateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEvaluateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the enterprise financial account information of an account that has primary-subsidiary relationship permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFinancialAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFinancialAccountInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the enterprise financial account information of an account that has primary-subsidiary relationship permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFinancialAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFinancialAccountInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the enterprise financial account information of an account that has primary-subsidiary relationship permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFinancialAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFinancialAccountInfoResponse
        /// </returns>
        public QueryFinancialAccountInfoResponse QueryFinancialAccountInfo(QueryFinancialAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFinancialAccountInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the enterprise financial account information of an account that has primary-subsidiary relationship permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFinancialAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFinancialAccountInfoResponse
        /// </returns>
        public async Task<QueryFinancialAccountInfoResponse> QueryFinancialAccountInfoAsync(QueryFinancialAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFinancialAccountInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of all product instances or billable items for an account in a billing cycle. This operation has been upgraded to DescribeInstanceBill. This operation no longer queries data beyond the 50,000th row.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>API description</h2>
        /// <para>Note the following when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The API for instance bills has been upgraded. We recommend that you use the new operation <a href="https://help.aliyun.com/document_detail/209402.html">DescribeInstanceBill</a>. This operation no longer supports querying data beyond the 50,000th row.</description></item>
        /// <item><description>Instance bills are generated based on split billing data. A delay of about one day may occur.</description></item>
        /// <item><description>Instance information may change within a billing cycle. The instance Config and Spec in the monthly summary reflect the information at the time the record was generated. For more information, see the corresponding detailed bill.</description></item>
        /// <item><description>Data for Alibaba Cloud Communications products is available from June 2020. Data for HiChina products is available from November 2020.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description>For the international site (alibabacloud.com), select Singapore as the endpoint.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryInstanceBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of all product instances or billable items for an account in a billing cycle. This operation has been upgraded to DescribeInstanceBill. This operation no longer queries data beyond the 50,000th row.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>API description</h2>
        /// <para>Note the following when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The API for instance bills has been upgraded. We recommend that you use the new operation <a href="https://help.aliyun.com/document_detail/209402.html">DescribeInstanceBill</a>. This operation no longer supports querying data beyond the 50,000th row.</description></item>
        /// <item><description>Instance bills are generated based on split billing data. A delay of about one day may occur.</description></item>
        /// <item><description>Instance information may change within a billing cycle. The instance Config and Spec in the monthly summary reflect the information at the time the record was generated. For more information, see the corresponding detailed bill.</description></item>
        /// <item><description>Data for Alibaba Cloud Communications products is available from June 2020. Data for HiChina products is available from November 2020.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description>For the international site (alibabacloud.com), select Singapore as the endpoint.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryInstanceBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of all product instances or billable items for an account in a billing cycle. This operation has been upgraded to DescribeInstanceBill. This operation no longer queries data beyond the 50,000th row.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>API description</h2>
        /// <para>Note the following when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The API for instance bills has been upgraded. We recommend that you use the new operation <a href="https://help.aliyun.com/document_detail/209402.html">DescribeInstanceBill</a>. This operation no longer supports querying data beyond the 50,000th row.</description></item>
        /// <item><description>Instance bills are generated based on split billing data. A delay of about one day may occur.</description></item>
        /// <item><description>Instance information may change within a billing cycle. The instance Config and Spec in the monthly summary reflect the information at the time the record was generated. For more information, see the corresponding detailed bill.</description></item>
        /// <item><description>Data for Alibaba Cloud Communications products is available from June 2020. Data for HiChina products is available from November 2020.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description>For the international site (alibabacloud.com), select Singapore as the endpoint.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryInstanceBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceBillResponse
        /// </returns>
        public QueryInstanceBillResponse QueryInstanceBill(QueryInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage summary of all product instances or billable items for an account in a billing cycle. This operation has been upgraded to DescribeInstanceBill. This operation no longer queries data beyond the 50,000th row.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>API description</h2>
        /// <para>Note the following when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The API for instance bills has been upgraded. We recommend that you use the new operation <a href="https://help.aliyun.com/document_detail/209402.html">DescribeInstanceBill</a>. This operation no longer supports querying data beyond the 50,000th row.</description></item>
        /// <item><description>Instance bills are generated based on split billing data. A delay of about one day may occur.</description></item>
        /// <item><description>Instance information may change within a billing cycle. The instance Config and Spec in the monthly summary reflect the information at the time the record was generated. For more information, see the corresponding detailed bill.</description></item>
        /// <item><description>Data for Alibaba Cloud Communications products is available from June 2020. Data for HiChina products is available from November 2020.
        /// &lt;props=&quot;intl&quot;&gt;</description></item>
        /// <item><description>For the international site (alibabacloud.com), select Singapore as the endpoint.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryInstanceBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceBillResponse
        /// </returns>
        public async Task<QueryInstanceBillResponse> QueryInstanceBillAsync(QueryInstanceBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances by tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceByTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceByTagResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances by tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceByTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceByTagResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances by tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceByTagRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceByTagResponse
        /// </returns>
        public QueryInstanceByTagResponse QueryInstanceByTag(QueryInstanceByTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceByTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances by tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceByTagRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceByTagResponse
        /// </returns>
        public async Task<QueryInstanceByTagResponse> QueryInstanceByTagAsync(QueryInstanceByTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceByTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is deprecated. Use the following APIs to retrieve the amortized cost: <c>DescribeInstanceAmortizedCostByAmortizationPeriod</c> - retrieves instance costs by amortization period; <c>DescribeProductAmortizedCostByAmortizationPeriod</c> - retrieves product costs by amortization period; <c>DescribeInstanceAmortizedCostByConsumePeriod</c> - retrieves instance costs by consume period; <c>DescribeProductAmortizedCostByConsumePeriod</c> - retrieves product costs by consume period.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceGaapCostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceGaapCostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is deprecated. Use the following APIs to retrieve the amortized cost: <c>DescribeInstanceAmortizedCostByAmortizationPeriod</c> - retrieves instance costs by amortization period; <c>DescribeProductAmortizedCostByAmortizationPeriod</c> - retrieves product costs by amortization period; <c>DescribeInstanceAmortizedCostByConsumePeriod</c> - retrieves instance costs by consume period; <c>DescribeProductAmortizedCostByConsumePeriod</c> - retrieves product costs by consume period.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceGaapCostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceGaapCostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is deprecated. Use the following APIs to retrieve the amortized cost: <c>DescribeInstanceAmortizedCostByAmortizationPeriod</c> - retrieves instance costs by amortization period; <c>DescribeProductAmortizedCostByAmortizationPeriod</c> - retrieves product costs by amortization period; <c>DescribeInstanceAmortizedCostByConsumePeriod</c> - retrieves instance costs by consume period; <c>DescribeProductAmortizedCostByConsumePeriod</c> - retrieves product costs by consume period.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceGaapCostRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceGaapCostResponse
        /// </returns>
        public QueryInstanceGaapCostResponse QueryInstanceGaapCost(QueryInstanceGaapCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceGaapCostWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is deprecated. Use the following APIs to retrieve the amortized cost: <c>DescribeInstanceAmortizedCostByAmortizationPeriod</c> - retrieves instance costs by amortization period; <c>DescribeProductAmortizedCostByAmortizationPeriod</c> - retrieves product costs by amortization period; <c>DescribeInstanceAmortizedCostByConsumePeriod</c> - retrieves instance costs by consume period; <c>DescribeProductAmortizedCostByConsumePeriod</c> - retrieves product costs by consume period.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstanceGaapCostRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceGaapCostResponse
        /// </returns>
        public async Task<QueryInstanceGaapCostResponse> QueryInstanceGaapCostAsync(QueryInstanceGaapCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceGaapCostWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the invoicing information of an Alibaba Cloud user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInvoicingCustomerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoicingCustomerListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the invoicing information of an Alibaba Cloud user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInvoicingCustomerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoicingCustomerListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the invoicing information of an Alibaba Cloud user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInvoicingCustomerListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoicingCustomerListResponse
        /// </returns>
        public QueryInvoicingCustomerListResponse QueryInvoicingCustomerList(QueryInvoicingCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInvoicingCustomerListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the invoicing information of an Alibaba Cloud user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInvoicingCustomerListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoicingCustomerListResponse
        /// </returns>
        public async Task<QueryInvoicingCustomerListResponse> QueryInvoicingCustomerListAsync(QueryInvoicingCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInvoicingCustomerListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the orders of users or distribution customers. By default, this operation queries orders created within the last hour. To query orders over a longer period, specify the CreateTimeStart and CreateTimeEnd parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrdersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrdersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the orders of users or distribution customers. By default, this operation queries orders created within the last hour. To query orders over a longer period, specify the CreateTimeStart and CreateTimeEnd parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrdersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrdersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the orders of users or distribution customers. By default, this operation queries orders created within the last hour. To query orders over a longer period, specify the CreateTimeStart and CreateTimeEnd parameters.</para>
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
            return QueryOrdersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the orders of users or distribution customers. By default, this operation queries orders created within the last hour. To query orders over a longer period, specify the CreateTimeStart and CreateTimeEnd parameters.</para>
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
            return await QueryOrdersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions for a master-member relationship based on the relationship ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions for a master-member relationship based on the relationship ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions for a master-member relationship based on the relationship ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionListResponse
        /// </returns>
        public QueryPermissionListResponse QueryPermissionList(QueryPermissionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPermissionListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions for a master-member relationship based on the relationship ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionListResponse
        /// </returns>
        public async Task<QueryPermissionListResponse> QueryPermissionListAsync(QueryPermissionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPermissionListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user card package information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPrepaidCardsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPrepaidCardsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user card package information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPrepaidCardsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPrepaidCardsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user card package information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPrepaidCardsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPrepaidCardsResponse
        /// </returns>
        public QueryPrepaidCardsResponse QueryPrepaidCards(QueryPrepaidCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPrepaidCardsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user card package information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPrepaidCardsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPrepaidCardsResponse
        /// </returns>
        public async Task<QueryPrepaidCardsResponse> QueryPrepaidCardsAsync(QueryPrepaidCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPrepaidCardsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing entities under a commodity. A pricing entity is the smallest product capability used for metering and cost calculation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the pricing entities under a commodity. A pricing entity is the smallest product capability used for metering and cost calculation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPriceEntityListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPriceEntityListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing entities under a commodity. A pricing entity is the smallest product capability used for metering and cost calculation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the pricing entities under a commodity. A pricing entity is the smallest product capability used for metering and cost calculation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPriceEntityListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPriceEntityListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing entities under a commodity. A pricing entity is the smallest product capability used for metering and cost calculation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the pricing entities under a commodity. A pricing entity is the smallest product capability used for metering and cost calculation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPriceEntityListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPriceEntityListResponse
        /// </returns>
        public QueryPriceEntityListResponse QueryPriceEntityList(QueryPriceEntityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPriceEntityListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing entities under a commodity. A pricing entity is the smallest product capability used for metering and cost calculation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the pricing entities under a commodity. A pricing entity is the smallest product capability used for metering and cost calculation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryPriceEntityListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPriceEntityListResponse
        /// </returns>
        public async Task<QueryPriceEntityListResponse> QueryPriceEntityListAsync(QueryPriceEntityListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPriceEntityListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of products available for the current account to order. The response includes the product code, product name, and subscription type (subscription or pay-as-you-go).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProductListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of products available for the current account to order. The response includes the product code, product name, and subscription type (subscription or pay-as-you-go).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProductListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of products available for the current account to order. The response includes the product code, product name, and subscription type (subscription or pay-as-you-go).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProductListResponse
        /// </returns>
        public QueryProductListResponse QueryProductList(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of products available for the current account to order. The response includes the product code, product name, and subscription type (subscription or pay-as-you-go).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProductListResponse
        /// </returns>
        public async Task<QueryProductListResponse> QueryProductListAsync(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of reserved instances (RIs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRIUtilizationDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRIUtilizationDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of reserved instances (RIs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRIUtilizationDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRIUtilizationDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of reserved instances (RIs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRIUtilizationDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRIUtilizationDetailResponse
        /// </returns>
        public QueryRIUtilizationDetailResponse QueryRIUtilizationDetail(QueryRIUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRIUtilizationDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of reserved instances (RIs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRIUtilizationDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRIUtilizationDetailResponse
        /// </returns>
        public async Task<QueryRIUtilizationDetailResponse> QueryRIUtilizationDetailAsync(QueryRIUtilizationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRIUtilizationDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the redemption ticket information of a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedeemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRedeemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the redemption ticket information of a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedeemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRedeemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the redemption ticket information of a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedeemRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRedeemResponse
        /// </returns>
        public QueryRedeemResponse QueryRedeem(QueryRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRedeemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the redemption ticket information of a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedeemRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRedeemResponse
        /// </returns>
        public async Task<QueryRedeemResponse> QueryRedeemAsync(QueryRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRedeemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of the relationships of member accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRelationListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRelationListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of the relationships of member accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRelationListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRelationListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of the relationships of member accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRelationListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRelationListResponse
        /// </returns>
        public QueryRelationListResponse QueryRelationList(QueryRelationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRelationListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of the relationships of member accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRelationListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRelationListResponse
        /// </returns>
        public async Task<QueryRelationListResponse> QueryRelationListAsync(QueryRelationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRelationListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available quota for a user in a reseller payment scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResellerAvailableQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResellerAvailableQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available quota for a user in a reseller payment scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResellerAvailableQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResellerAvailableQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available quota for a user in a reseller payment scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResellerAvailableQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResellerAvailableQuotaResponse
        /// </returns>
        public QueryResellerAvailableQuotaResponse QueryResellerAvailableQuota(QueryResellerAvailableQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryResellerAvailableQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available quota for a user in a reseller payment scenario.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResellerAvailableQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResellerAvailableQuotaResponse
        /// </returns>
        public async Task<QueryResellerAvailableQuotaResponse> QueryResellerAvailableQuotaAsync(QueryResellerAvailableQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryResellerAvailableQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the alarm thresholds for low quotas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryResellerUserAlarmThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResellerUserAlarmThresholdResponse
        /// </returns>
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

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the alarm thresholds for low quotas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryResellerUserAlarmThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResellerUserAlarmThresholdResponse
        /// </returns>
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

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the alarm thresholds for low quotas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryResellerUserAlarmThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResellerUserAlarmThresholdResponse
        /// </returns>
        public QueryResellerUserAlarmThresholdResponse QueryResellerUserAlarmThreshold(QueryResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryResellerUserAlarmThresholdWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the alarm thresholds for low quotas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryResellerUserAlarmThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResellerUserAlarmThresholdResponse
        /// </returns>
        public async Task<QueryResellerUserAlarmThresholdResponse> QueryResellerUserAlarmThresholdAsync(QueryResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryResellerUserAlarmThresholdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the instances of a specific resource plan for a user. Only valid resource plans are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourcePackageInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResourcePackageInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the instances of a specific resource plan for a user. Only valid resource plans are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourcePackageInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResourcePackageInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the instances of a specific resource plan for a user. Only valid resource plans are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourcePackageInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResourcePackageInstancesResponse
        /// </returns>
        public QueryResourcePackageInstancesResponse QueryResourcePackageInstances(QueryResourcePackageInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryResourcePackageInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the instances of a specific resource plan for a user. Only valid resource plans are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourcePackageInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResourcePackageInstancesResponse
        /// </returns>
        public async Task<QueryResourcePackageInstancesResponse> QueryResourcePackageInstancesAsync(QueryResourcePackageInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryResourcePackageInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of savings plan deductions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansDeductLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansDeductLogResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of savings plan deductions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansDeductLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansDeductLogResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of savings plan deductions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansDeductLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansDeductLogResponse
        /// </returns>
        public QuerySavingsPlansDeductLogResponse QuerySavingsPlansDeductLog(QuerySavingsPlansDeductLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySavingsPlansDeductLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of savings plan deductions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansDeductLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansDeductLogResponse
        /// </returns>
        public async Task<QuerySavingsPlansDeductLogResponse> QuerySavingsPlansDeductLogAsync(QuerySavingsPlansDeductLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySavingsPlansDeductLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the discount information for savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansDiscountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansDiscountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the discount information for savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansDiscountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansDiscountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the discount information for savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansDiscountRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansDiscountResponse
        /// </returns>
        public QuerySavingsPlansDiscountResponse QuerySavingsPlansDiscount(QuerySavingsPlansDiscountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySavingsPlansDiscountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the discount information for savings plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansDiscountRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansDiscountResponse
        /// </returns>
        public async Task<QuerySavingsPlansDiscountResponse> QuerySavingsPlansDiscountAsync(QuerySavingsPlansDiscountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySavingsPlansDiscountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about your savings plan instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about your savings plan instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about your savings plan instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansInstanceResponse
        /// </returns>
        public QuerySavingsPlansInstanceResponse QuerySavingsPlansInstance(QuerySavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySavingsPlansInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about your savings plan instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySavingsPlansInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySavingsPlansInstanceResponse
        /// </returns>
        public async Task<QuerySavingsPlansInstanceResponse> QuerySavingsPlansInstanceAsync(QuerySavingsPlansInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySavingsPlansInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settlement bills of a user for a specific billing cycle. Supports domestic accounts with more than 50,000 bill entries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month are for reference only and cannot be used for reconciliation. The final bill for the current month is available for viewing or export after 12:00 on the 2nd of the following month. During the month, a few scenarios may occur, including but not limited to delayed billing, refunds, adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Bill data is updated with a 5-hour delay relative to actual cost consumption.</description></item>
        /// <item><description>For bills in the &quot;Unsettled&quot; state in historical billing cycles, the status is updated to settled 5 hours after payment. For bills in the &quot;Unsettled&quot; state in the current month, the status is updated to settled when the bill is generated at 12:00 on the 2nd of the following month.</description></item>
        /// <item><description>This API supports graceful backoff with a request rate of 600/60(s).</description></item>
        /// <item><description>The rate limit per user is 10 requests per second. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySettleBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySettleBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settlement bills of a user for a specific billing cycle. Supports domestic accounts with more than 50,000 bill entries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month are for reference only and cannot be used for reconciliation. The final bill for the current month is available for viewing or export after 12:00 on the 2nd of the following month. During the month, a few scenarios may occur, including but not limited to delayed billing, refunds, adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Bill data is updated with a 5-hour delay relative to actual cost consumption.</description></item>
        /// <item><description>For bills in the &quot;Unsettled&quot; state in historical billing cycles, the status is updated to settled 5 hours after payment. For bills in the &quot;Unsettled&quot; state in the current month, the status is updated to settled when the bill is generated at 12:00 on the 2nd of the following month.</description></item>
        /// <item><description>This API supports graceful backoff with a request rate of 600/60(s).</description></item>
        /// <item><description>The rate limit per user is 10 requests per second. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySettleBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySettleBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settlement bills of a user for a specific billing cycle. Supports domestic accounts with more than 50,000 bill entries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month are for reference only and cannot be used for reconciliation. The final bill for the current month is available for viewing or export after 12:00 on the 2nd of the following month. During the month, a few scenarios may occur, including but not limited to delayed billing, refunds, adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Bill data is updated with a 5-hour delay relative to actual cost consumption.</description></item>
        /// <item><description>For bills in the &quot;Unsettled&quot; state in historical billing cycles, the status is updated to settled 5 hours after payment. For bills in the &quot;Unsettled&quot; state in the current month, the status is updated to settled when the bill is generated at 12:00 on the 2nd of the following month.</description></item>
        /// <item><description>This API supports graceful backoff with a request rate of 600/60(s).</description></item>
        /// <item><description>The rate limit per user is 10 requests per second. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySettleBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySettleBillResponse
        /// </returns>
        public QuerySettleBillResponse QuerySettleBill(QuerySettleBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySettleBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settlement bills of a user for a specific billing cycle. Supports domestic accounts with more than 50,000 bill entries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The query results for the current month are for reference only and cannot be used for reconciliation. The final bill for the current month is available for viewing or export after 12:00 on the 2nd of the following month. During the month, a few scenarios may occur, including but not limited to delayed billing, refunds, adjustments, and overdue payment write-offs.</description></item>
        /// <item><description>Bill data is updated with a 5-hour delay relative to actual cost consumption.</description></item>
        /// <item><description>For bills in the &quot;Unsettled&quot; state in historical billing cycles, the status is updated to settled 5 hours after payment. For bills in the &quot;Unsettled&quot; state in the current month, the status is updated to settled when the bill is generated at 12:00 on the 2nd of the following month.</description></item>
        /// <item><description>This API supports graceful backoff with a request rate of 600/60(s).</description></item>
        /// <item><description>The rate limit per user is 10 requests per second. If a timeout occurs, retry the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySettleBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySettleBillResponse
        /// </returns>
        public async Task<QuerySettleBillResponse> QuerySettleBillAsync(QuerySettleBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySettleBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of SKUs and their list prices under a specified pricing entity of a commodity. A product feature typically has 1 to multiple SKUs, and some products can have tens of thousands of SKUs. The request parameters support filtered queries based on specific SKU configuration conditions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QuerySkuPriceListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySkuPriceListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of SKUs and their list prices under a specified pricing entity of a commodity. A product feature typically has 1 to multiple SKUs, and some products can have tens of thousands of SKUs. The request parameters support filtered queries based on specific SKU configuration conditions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QuerySkuPriceListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySkuPriceListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of SKUs and their list prices under a specified pricing entity of a commodity. A product feature typically has 1 to multiple SKUs, and some products can have tens of thousands of SKUs. The request parameters support filtered queries based on specific SKU configuration conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySkuPriceListRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySkuPriceListResponse
        /// </returns>
        public QuerySkuPriceListResponse QuerySkuPriceList(QuerySkuPriceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySkuPriceListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of SKUs and their list prices under a specified pricing entity of a commodity. A product feature typically has 1 to multiple SKUs, and some products can have tens of thousands of SKUs. The request parameters support filtered queries based on specific SKU configuration conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySkuPriceListRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySkuPriceListResponse
        /// </returns>
        public async Task<QuerySkuPriceListResponse> QuerySkuPriceListAsync(QuerySkuPriceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySkuPriceListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries split bills. This API has been upgraded. We recommend that you use the new DescribeSplitItemBill operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The API for split bills is upgraded. We recommend that you use the new <a href="https://help.aliyun.com/document_detail/208169.html">DescribeSplitItemBill</a> operation. This operation no longer supports querying more than 50,000 rows of data.</description></item>
        /// <item><description>The data is consistent with the split bill data for the specified billing cycle in the User Center.</description></item>
        /// <item><description>You can query split bills that were generated within the last 12 months.</description></item>
        /// <item><description>To use this feature, you must first enable it on the <a href="https://usercenter2.aliyun.com/finance/split-bill">Split Bill</a> page in the console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySplitItemBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySplitItemBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries split bills. This API has been upgraded. We recommend that you use the new DescribeSplitItemBill operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The API for split bills is upgraded. We recommend that you use the new <a href="https://help.aliyun.com/document_detail/208169.html">DescribeSplitItemBill</a> operation. This operation no longer supports querying more than 50,000 rows of data.</description></item>
        /// <item><description>The data is consistent with the split bill data for the specified billing cycle in the User Center.</description></item>
        /// <item><description>You can query split bills that were generated within the last 12 months.</description></item>
        /// <item><description>To use this feature, you must first enable it on the <a href="https://usercenter2.aliyun.com/finance/split-bill">Split Bill</a> page in the console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySplitItemBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySplitItemBillResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries split bills. This API has been upgraded. We recommend that you use the new DescribeSplitItemBill operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The API for split bills is upgraded. We recommend that you use the new <a href="https://help.aliyun.com/document_detail/208169.html">DescribeSplitItemBill</a> operation. This operation no longer supports querying more than 50,000 rows of data.</description></item>
        /// <item><description>The data is consistent with the split bill data for the specified billing cycle in the User Center.</description></item>
        /// <item><description>You can query split bills that were generated within the last 12 months.</description></item>
        /// <item><description>To use this feature, you must first enable it on the <a href="https://usercenter2.aliyun.com/finance/split-bill">Split Bill</a> page in the console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySplitItemBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySplitItemBillResponse
        /// </returns>
        public QuerySplitItemBillResponse QuerySplitItemBill(QuerySplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySplitItemBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries split bills. This API has been upgraded. We recommend that you use the new DescribeSplitItemBill operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The API for split bills is upgraded. We recommend that you use the new <a href="https://help.aliyun.com/document_detail/208169.html">DescribeSplitItemBill</a> operation. This operation no longer supports querying more than 50,000 rows of data.</description></item>
        /// <item><description>The data is consistent with the split bill data for the specified billing cycle in the User Center.</description></item>
        /// <item><description>You can query split bills that were generated within the last 12 months.</description></item>
        /// <item><description>To use this feature, you must first enable it on the <a href="https://usercenter2.aliyun.com/finance/split-bill">Split Bill</a> page in the console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySplitItemBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySplitItemBillResponse
        /// </returns>
        public async Task<QuerySplitItemBillResponse> QuerySplitItemBillAsync(QuerySplitItemBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySplitItemBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metering records for the specified cloud service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>API description</h2>
        /// <list type="bullet">
        /// <item><description>The specified cloud service parameter must be one of the following cloud service codes. The metering data types include hourly and daily.</description></item>
        /// <item><description>The time format must comply with the ISO 8601 standard. Time specification constraints:<list type="bullet">
        /// <item><description>   Due to delays in data push, the data integrity of hourly metering data is guaranteed for the past 24 hours, and the data integrity of daily metering data is guaranteed for the past 2 days.</description></item>
        /// <item><description>   The time span can cover the metering data of the most recent quarter.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryUserOmsDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserOmsDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metering records for the specified cloud service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>API description</h2>
        /// <list type="bullet">
        /// <item><description>The specified cloud service parameter must be one of the following cloud service codes. The metering data types include hourly and daily.</description></item>
        /// <item><description>The time format must comply with the ISO 8601 standard. Time specification constraints:<list type="bullet">
        /// <item><description>   Due to delays in data push, the data integrity of hourly metering data is guaranteed for the past 24 hours, and the data integrity of daily metering data is guaranteed for the past 2 days.</description></item>
        /// <item><description>   The time span can cover the metering data of the most recent quarter.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryUserOmsDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserOmsDataResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metering records for the specified cloud service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>API description</h2>
        /// <list type="bullet">
        /// <item><description>The specified cloud service parameter must be one of the following cloud service codes. The metering data types include hourly and daily.</description></item>
        /// <item><description>The time format must comply with the ISO 8601 standard. Time specification constraints:<list type="bullet">
        /// <item><description>   Due to delays in data push, the data integrity of hourly metering data is guaranteed for the past 24 hours, and the data integrity of daily metering data is guaranteed for the past 2 days.</description></item>
        /// <item><description>   The time span can cover the metering data of the most recent quarter.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryUserOmsDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserOmsDataResponse
        /// </returns>
        public QueryUserOmsDataResponse QueryUserOmsData(QueryUserOmsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserOmsDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metering records for the specified cloud service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>API description</h2>
        /// <list type="bullet">
        /// <item><description>The specified cloud service parameter must be one of the following cloud service codes. The metering data types include hourly and daily.</description></item>
        /// <item><description>The time format must comply with the ISO 8601 standard. Time specification constraints:<list type="bullet">
        /// <item><description>   Due to delays in data push, the data integrity of hourly metering data is guaranteed for the past 24 hours, and the data integrity of daily metering data is guaranteed for the past 2 days.</description></item>
        /// <item><description>   The time span can cover the metering data of the most recent quarter.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryUserOmsDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserOmsDataResponse
        /// </returns>
        public async Task<QueryUserOmsDataResponse> QueryUserOmsDataAsync(QueryUserOmsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserOmsDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unsubscribes from an instance that is no longer needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Only the actual paid amount is refunded. Used vouchers are not refunded.</description></item>
        /// <item><description>Carefully verify the information about the resource to be unsubscribed, and confirm the unsubscription terms and refund amount. Resources cannot be recovered after unsubscription.</description></item>
        /// <item><description>This operation can be called only by direct customers. Reseller customers cannot use this operation.</description></item>
        /// <item><description>For other questions, refer to: &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/knowledge_detail/116043.html?spm=a2c81.e1d666e.app.2.62ae11271Kd6iM">Refund policy</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules">Refund rules for Alibaba Cloud International site</a></description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// RefundInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unsubscribes from an instance that is no longer needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Only the actual paid amount is refunded. Used vouchers are not refunded.</description></item>
        /// <item><description>Carefully verify the information about the resource to be unsubscribed, and confirm the unsubscription terms and refund amount. Resources cannot be recovered after unsubscription.</description></item>
        /// <item><description>This operation can be called only by direct customers. Reseller customers cannot use this operation.</description></item>
        /// <item><description>For other questions, refer to: &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/knowledge_detail/116043.html?spm=a2c81.e1d666e.app.2.62ae11271Kd6iM">Refund policy</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules">Refund rules for Alibaba Cloud International site</a></description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// RefundInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefundInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unsubscribes from an instance that is no longer needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Only the actual paid amount is refunded. Used vouchers are not refunded.</description></item>
        /// <item><description>Carefully verify the information about the resource to be unsubscribed, and confirm the unsubscription terms and refund amount. Resources cannot be recovered after unsubscription.</description></item>
        /// <item><description>This operation can be called only by direct customers. Reseller customers cannot use this operation.</description></item>
        /// <item><description>For other questions, refer to: &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/knowledge_detail/116043.html?spm=a2c81.e1d666e.app.2.62ae11271Kd6iM">Refund policy</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules">Refund rules for Alibaba Cloud International site</a></description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// RefundInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundInstanceResponse
        /// </returns>
        public RefundInstanceResponse RefundInstance(RefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefundInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unsubscribes from an instance that is no longer needed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>Only the actual paid amount is refunded. Used vouchers are not refunded.</description></item>
        /// <item><description>Carefully verify the information about the resource to be unsubscribed, and confirm the unsubscription terms and refund amount. Resources cannot be recovered after unsubscription.</description></item>
        /// <item><description>This operation can be called only by direct customers. Reseller customers cannot use this operation.</description></item>
        /// <item><description>For other questions, refer to: &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/knowledge_detail/116043.html?spm=a2c81.e1d666e.app.2.62ae11271Kd6iM">Refund policy</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/user-center/user-guide/refund-rules">Refund rules for Alibaba Cloud International site</a></description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// RefundInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RefundInstanceResponse
        /// </returns>
        public async Task<RefundInstanceResponse> RefundInstanceAsync(RefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefundInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases instances by Virtual Network Operators (VNOs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is provided for only VNOs to release instances. If a non-specific VNO calls this operation, the request is blocked.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases instances by Virtual Network Operators (VNOs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is provided for only VNOs to release instances. If a non-specific VNO calls this operation, the request is blocked.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases instances by Virtual Network Operators (VNOs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is provided for only VNOs to release instances. If a non-specific VNO calls this operation, the request is blocked.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases instances by Virtual Network Operators (VNOs).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is provided for only VNOs to release instances. If a non-specific VNO calls this operation, the request is blocked.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a RAM user from an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RelieveAccountRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RelieveAccountRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a RAM user from an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RelieveAccountRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RelieveAccountRelationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a RAM user from an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RelieveAccountRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// RelieveAccountRelationResponse
        /// </returns>
        public RelieveAccountRelationResponse RelieveAccountRelation(RelieveAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RelieveAccountRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a RAM user from an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RelieveAccountRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// RelieveAccountRelationResponse
        /// </returns>
        public async Task<RelieveAccountRelationResponse> RelieveAccountRelationAsync(RelieveAccountRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RelieveAccountRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews an instance and changes its configuration. The configuration change is applied after the renewal order takes effect. Payment is processed automatically. This operation cannot be used to create ECS or RDS instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewChangeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewChangeInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews an instance and changes its configuration. The configuration change is applied after the renewal order takes effect. Payment is processed automatically. This operation cannot be used to create ECS or RDS instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewChangeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewChangeInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews an instance and changes its configuration. The configuration change is applied after the renewal order takes effect. Payment is processed automatically. This operation cannot be used to create ECS or RDS instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewChangeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewChangeInstanceResponse
        /// </returns>
        public RenewChangeInstanceResponse RenewChangeInstance(RenewChangeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewChangeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews an instance and changes its configuration. The configuration change is applied after the renewal order takes effect. Payment is processed automatically. This operation cannot be used to create ECS or RDS instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewChangeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewChangeInstanceResponse
        /// </returns>
        public async Task<RenewChangeInstanceResponse> RenewChangeInstanceAsync(RenewChangeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewChangeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a specified instance. This operation does not support renewing ECS, RDS, or Redis instances. To renew these instances, call the dedicated renewal API of the corresponding service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a specified instance. This operation does not support renewing ECS, RDS, or Redis instances. To renew these instances, call the dedicated renewal API of the corresponding service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a specified instance. This operation does not support renewing ECS, RDS, or Redis instances. To renew these instances, call the dedicated renewal API of the corresponding service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a specified instance. This operation does not support renewing ECS, RDS, or Redis instances. To renew these instances, call the dedicated renewal API of the corresponding service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewInstanceResponse
        /// </returns>
        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a resource package instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewResourcePackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewResourcePackageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a resource package instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewResourcePackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewResourcePackageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a resource package instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewResourcePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewResourcePackageResponse
        /// </returns>
        public RenewResourcePackageResponse RenewResourcePackage(RenewResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewResourcePackageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a resource package instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenewResourcePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewResourcePackageResponse
        /// </returns>
        public async Task<RenewResourcePackageResponse> RenewResourcePackageAsync(RenewResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewResourcePackageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets an expiration date for all Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAllExpirationDayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAllExpirationDayResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets an expiration date for all Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAllExpirationDayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAllExpirationDayResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets an expiration date for all Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAllExpirationDayRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAllExpirationDayResponse
        /// </returns>
        public SetAllExpirationDayResponse SetAllExpirationDay(SetAllExpirationDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAllExpirationDayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets an expiration date for all Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAllExpirationDayRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAllExpirationDayResponse
        /// </returns>
        public async Task<SetAllExpirationDayResponse> SetAllExpirationDayAsync(SetAllExpirationDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAllExpirationDayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables auto-renewal for an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRenewalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRenewalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables auto-renewal for an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRenewalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRenewalResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables auto-renewal for an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRenewalRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRenewalResponse
        /// </returns>
        public SetRenewalResponse SetRenewal(SetRenewalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRenewalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables auto-renewal for an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRenewalRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRenewalResponse
        /// </returns>
        public async Task<SetRenewalResponse> SetRenewalAsync(SetRenewalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRenewalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures low-balance alert rules for quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configures low-balance alert rules for quotas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserAlarmThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserAlarmThresholdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures low-balance alert rules for quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configures low-balance alert rules for quotas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserAlarmThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserAlarmThresholdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures low-balance alert rules for quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configures low-balance alert rules for quotas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserAlarmThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserAlarmThresholdResponse
        /// </returns>
        public SetResellerUserAlarmThresholdResponse SetResellerUserAlarmThreshold(SetResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserAlarmThresholdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures low-balance alert rules for quotas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configures low-balance alert rules for quotas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserAlarmThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserAlarmThresholdResponse
        /// </returns>
        public async Task<SetResellerUserAlarmThresholdResponse> SetResellerUserAlarmThresholdAsync(SetResellerUserAlarmThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserAlarmThresholdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the quota ledger and consumption ledger.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>设置用户配额账本的Quota额度</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the quota ledger and consumption ledger.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>设置用户配额账本的Quota额度</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserQuotaResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the quota ledger and consumption ledger.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>设置用户配额账本的Quota额度</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserQuotaResponse
        /// </returns>
        public SetResellerUserQuotaResponse SetResellerUserQuota(SetResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the quota ledger and consumption ledger.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>设置用户配额账本的Quota额度</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserQuotaResponse
        /// </returns>
        public async Task<SetResellerUserQuotaResponse> SetResellerUserQuotaAsync(SetResellerUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the SQL audit feature for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the status of a reseller\&quot;s user account, such as frozen or hosted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the SQL audit feature for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the status of a reseller\&quot;s user account, such as frozen or hosted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the SQL audit feature for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the status of a reseller\&quot;s user account, such as frozen or hosted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserStatusResponse
        /// </returns>
        public SetResellerUserStatusResponse SetResellerUserStatus(SetResellerUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResellerUserStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the SQL audit feature for users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the status of a reseller\&quot;s user account, such as frozen or hosted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetResellerUserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// SetResellerUserStatusResponse
        /// </returns>
        public async Task<SetResellerUserStatusResponse> SetResellerUserStatusAsync(SetResellerUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResellerUserStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置节省计划用户级抵扣规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SetSavingPlanUserDeductRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSavingPlanUserDeductRuleResponse
        /// </returns>
        public SetSavingPlanUserDeductRuleResponse SetSavingPlanUserDeductRuleWithOptions(SetSavingPlanUserDeductRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetSavingPlanUserDeductRuleShrinkRequest request = new SetSavingPlanUserDeductRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserDeductRules))
            {
                request.UserDeductRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserDeductRules, "UserDeductRules", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpnInstanceCode))
            {
                body["SpnInstanceCode"] = request.SpnInstanceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDeductRulesShrink))
            {
                body["UserDeductRules"] = request.UserDeductRulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSavingPlanUserDeductRule",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSavingPlanUserDeductRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置节省计划用户级抵扣规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SetSavingPlanUserDeductRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSavingPlanUserDeductRuleResponse
        /// </returns>
        public async Task<SetSavingPlanUserDeductRuleResponse> SetSavingPlanUserDeductRuleWithOptionsAsync(SetSavingPlanUserDeductRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SetSavingPlanUserDeductRuleShrinkRequest request = new SetSavingPlanUserDeductRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserDeductRules))
            {
                request.UserDeductRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserDeductRules, "UserDeductRules", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpnInstanceCode))
            {
                body["SpnInstanceCode"] = request.SpnInstanceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDeductRulesShrink))
            {
                body["UserDeductRules"] = request.UserDeductRulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSavingPlanUserDeductRule",
                Version = "2017-12-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSavingPlanUserDeductRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置节省计划用户级抵扣规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSavingPlanUserDeductRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSavingPlanUserDeductRuleResponse
        /// </returns>
        public SetSavingPlanUserDeductRuleResponse SetSavingPlanUserDeductRule(SetSavingPlanUserDeductRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSavingPlanUserDeductRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置节省计划用户级抵扣规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSavingPlanUserDeductRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSavingPlanUserDeductRuleResponse
        /// </returns>
        public async Task<SetSavingPlanUserDeductRuleResponse> SetSavingPlanUserDeductRuleAsync(SetSavingPlanUserDeductRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSavingPlanUserDeductRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Subscribes to bill files by using Object Storage Service (OSS), which stores billing data in a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, note the following information:</para>
        /// <list type="bullet">
        /// <item><description>You can subscribe to one type of bill file at a time.</description></item>
        /// <item><description>After subscription, the bill file generated on the previous day is pushed daily starting from the next day. On the 4th of each month, the full bill files for the entire billing cycle of the previous month are pushed. The monthly bill PDF is pushed on the 4th of each month for the previous month.</description></item>
        /// <item><description>Bill files generated on a daily basis may be delayed. Delayed bills are pushed the day after they are generated and may include bills from earlier days that were delayed until the previous day. Pull the full files for the previous month at the beginning of each month.<remarks>
        /// <para>To use OSS subscription for the first time, grant the <a href="https://ram.console.aliyun.com/#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission to the subscribing user. If the authorization is revoked, the system stops pushing files, and the user must re-authorize.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>This subscription is the same feature as &quot;Bill Data Storage&quot; in the Expenses and Costs console. Subscriptions are synchronized between the two.</description></item>
        /// <item><description>When subscribing to a directory under a bucket, follow the directory naming conventions:<list type="bullet">
        /// <item><description>Emojis are not allowed. Use valid UTF-8 characters.</description></item>
        /// <item><description>Use / to separate paths and quickly create subdirectories. Do not start with / or \, and do not use consecutive / characters.</description></item>
        /// <item><description>A subdirectory named .. is not allowed.</description></item>
        /// <item><description>The total length must be 1 to 254 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>File names:<list type="bullet">
        /// <item><description><para><b>BillingItemDetailForBillingPeriod</b> (billing item details)</para>
        /// <list type="bullet">
        /// <item><description><para>Daily push file name format: <c>UID_BillingItemDetail_YYYYMMDD</c>, for example, <c>169**_BillingItemDetail_20190310</c>.</para>
        /// </description></item>
        /// <item><description><para>Full file name format at the beginning of the next month: <c>UID_BillingItemDetail_YYYYMM</c>, for example, <c>169**_BillingItemDetail_201903</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>InstanceDetailForBillingPeriod</b> (instance bill details)</para>
        /// <list type="bullet">
        /// <item><description><para>Daily push file name format: <c>UID_InstanceDetail_YYYYMMDD</c>, for example, <c>169**_InstanceDetail_20190310</c>.</para>
        /// </description></item>
        /// <item><description><para>Full file name format at the beginning of the next month: <c>UID_InstanceDetail_YYYYMM</c>, for example, <c>169**_InstanceDetail_201903</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>InstanceDetailMonthly</b> (instance bill summary by billing cycle)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_InstanceDetailMonthly_YYYYMM</c>, for example, <c>169**_InstanceDetailMonthly_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>BillingItemDetailMonthly</b> (billing item summary by billing cycle)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_BillingItemDetailMonthly_YYYYMM</c>, for example, <c>169**_BillingItemDetailMonthly_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SplitItemDetailDaily</b> (split bill daily summary)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_SplitItemDetailDaily_YYYYMM</c>, for example, <c>169**_SplitItemDetailDaily_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>MonthBill</b> (monthly bill PDF)</para>
        /// <list type="bullet">
        /// <item><description>Monthly push file name format: <c>UID_MonthBill_YYYYMM</c>, for example, <c>169**_MonthBill_201903</c>. The file for the previous month is pushed on the 4th of each month.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Except for MonthBill, which is a PDF file, all other file types are CSV files. If the number of rows in a bill file exceeds a certain threshold, the file is automatically split into multiple CSV files, which are then compressed into a single ZIP file. The ZIP file name follows the same format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubscribeBillToOSSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscribeBillToOSSResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Subscribes to bill files by using Object Storage Service (OSS), which stores billing data in a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, note the following information:</para>
        /// <list type="bullet">
        /// <item><description>You can subscribe to one type of bill file at a time.</description></item>
        /// <item><description>After subscription, the bill file generated on the previous day is pushed daily starting from the next day. On the 4th of each month, the full bill files for the entire billing cycle of the previous month are pushed. The monthly bill PDF is pushed on the 4th of each month for the previous month.</description></item>
        /// <item><description>Bill files generated on a daily basis may be delayed. Delayed bills are pushed the day after they are generated and may include bills from earlier days that were delayed until the previous day. Pull the full files for the previous month at the beginning of each month.<remarks>
        /// <para>To use OSS subscription for the first time, grant the <a href="https://ram.console.aliyun.com/#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission to the subscribing user. If the authorization is revoked, the system stops pushing files, and the user must re-authorize.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>This subscription is the same feature as &quot;Bill Data Storage&quot; in the Expenses and Costs console. Subscriptions are synchronized between the two.</description></item>
        /// <item><description>When subscribing to a directory under a bucket, follow the directory naming conventions:<list type="bullet">
        /// <item><description>Emojis are not allowed. Use valid UTF-8 characters.</description></item>
        /// <item><description>Use / to separate paths and quickly create subdirectories. Do not start with / or \, and do not use consecutive / characters.</description></item>
        /// <item><description>A subdirectory named .. is not allowed.</description></item>
        /// <item><description>The total length must be 1 to 254 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>File names:<list type="bullet">
        /// <item><description><para><b>BillingItemDetailForBillingPeriod</b> (billing item details)</para>
        /// <list type="bullet">
        /// <item><description><para>Daily push file name format: <c>UID_BillingItemDetail_YYYYMMDD</c>, for example, <c>169**_BillingItemDetail_20190310</c>.</para>
        /// </description></item>
        /// <item><description><para>Full file name format at the beginning of the next month: <c>UID_BillingItemDetail_YYYYMM</c>, for example, <c>169**_BillingItemDetail_201903</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>InstanceDetailForBillingPeriod</b> (instance bill details)</para>
        /// <list type="bullet">
        /// <item><description><para>Daily push file name format: <c>UID_InstanceDetail_YYYYMMDD</c>, for example, <c>169**_InstanceDetail_20190310</c>.</para>
        /// </description></item>
        /// <item><description><para>Full file name format at the beginning of the next month: <c>UID_InstanceDetail_YYYYMM</c>, for example, <c>169**_InstanceDetail_201903</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>InstanceDetailMonthly</b> (instance bill summary by billing cycle)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_InstanceDetailMonthly_YYYYMM</c>, for example, <c>169**_InstanceDetailMonthly_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>BillingItemDetailMonthly</b> (billing item summary by billing cycle)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_BillingItemDetailMonthly_YYYYMM</c>, for example, <c>169**_BillingItemDetailMonthly_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SplitItemDetailDaily</b> (split bill daily summary)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_SplitItemDetailDaily_YYYYMM</c>, for example, <c>169**_SplitItemDetailDaily_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>MonthBill</b> (monthly bill PDF)</para>
        /// <list type="bullet">
        /// <item><description>Monthly push file name format: <c>UID_MonthBill_YYYYMM</c>, for example, <c>169**_MonthBill_201903</c>. The file for the previous month is pushed on the 4th of each month.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Except for MonthBill, which is a PDF file, all other file types are CSV files. If the number of rows in a bill file exceeds a certain threshold, the file is automatically split into multiple CSV files, which are then compressed into a single ZIP file. The ZIP file name follows the same format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubscribeBillToOSSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubscribeBillToOSSResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Subscribes to bill files by using Object Storage Service (OSS), which stores billing data in a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, note the following information:</para>
        /// <list type="bullet">
        /// <item><description>You can subscribe to one type of bill file at a time.</description></item>
        /// <item><description>After subscription, the bill file generated on the previous day is pushed daily starting from the next day. On the 4th of each month, the full bill files for the entire billing cycle of the previous month are pushed. The monthly bill PDF is pushed on the 4th of each month for the previous month.</description></item>
        /// <item><description>Bill files generated on a daily basis may be delayed. Delayed bills are pushed the day after they are generated and may include bills from earlier days that were delayed until the previous day. Pull the full files for the previous month at the beginning of each month.<remarks>
        /// <para>To use OSS subscription for the first time, grant the <a href="https://ram.console.aliyun.com/#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission to the subscribing user. If the authorization is revoked, the system stops pushing files, and the user must re-authorize.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>This subscription is the same feature as &quot;Bill Data Storage&quot; in the Expenses and Costs console. Subscriptions are synchronized between the two.</description></item>
        /// <item><description>When subscribing to a directory under a bucket, follow the directory naming conventions:<list type="bullet">
        /// <item><description>Emojis are not allowed. Use valid UTF-8 characters.</description></item>
        /// <item><description>Use / to separate paths and quickly create subdirectories. Do not start with / or \, and do not use consecutive / characters.</description></item>
        /// <item><description>A subdirectory named .. is not allowed.</description></item>
        /// <item><description>The total length must be 1 to 254 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>File names:<list type="bullet">
        /// <item><description><para><b>BillingItemDetailForBillingPeriod</b> (billing item details)</para>
        /// <list type="bullet">
        /// <item><description><para>Daily push file name format: <c>UID_BillingItemDetail_YYYYMMDD</c>, for example, <c>169**_BillingItemDetail_20190310</c>.</para>
        /// </description></item>
        /// <item><description><para>Full file name format at the beginning of the next month: <c>UID_BillingItemDetail_YYYYMM</c>, for example, <c>169**_BillingItemDetail_201903</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>InstanceDetailForBillingPeriod</b> (instance bill details)</para>
        /// <list type="bullet">
        /// <item><description><para>Daily push file name format: <c>UID_InstanceDetail_YYYYMMDD</c>, for example, <c>169**_InstanceDetail_20190310</c>.</para>
        /// </description></item>
        /// <item><description><para>Full file name format at the beginning of the next month: <c>UID_InstanceDetail_YYYYMM</c>, for example, <c>169**_InstanceDetail_201903</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>InstanceDetailMonthly</b> (instance bill summary by billing cycle)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_InstanceDetailMonthly_YYYYMM</c>, for example, <c>169**_InstanceDetailMonthly_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>BillingItemDetailMonthly</b> (billing item summary by billing cycle)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_BillingItemDetailMonthly_YYYYMM</c>, for example, <c>169**_BillingItemDetailMonthly_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SplitItemDetailDaily</b> (split bill daily summary)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_SplitItemDetailDaily_YYYYMM</c>, for example, <c>169**_SplitItemDetailDaily_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>MonthBill</b> (monthly bill PDF)</para>
        /// <list type="bullet">
        /// <item><description>Monthly push file name format: <c>UID_MonthBill_YYYYMM</c>, for example, <c>169**_MonthBill_201903</c>. The file for the previous month is pushed on the 4th of each month.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Except for MonthBill, which is a PDF file, all other file types are CSV files. If the number of rows in a bill file exceeds a certain threshold, the file is automatically split into multiple CSV files, which are then compressed into a single ZIP file. The ZIP file name follows the same format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubscribeBillToOSSRequest
        /// </param>
        /// 
        /// <returns>
        /// SubscribeBillToOSSResponse
        /// </returns>
        public SubscribeBillToOSSResponse SubscribeBillToOSS(SubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscribeBillToOSSWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Subscribes to bill files by using Object Storage Service (OSS), which stores billing data in a specified OSS bucket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before calling this operation, note the following information:</para>
        /// <list type="bullet">
        /// <item><description>You can subscribe to one type of bill file at a time.</description></item>
        /// <item><description>After subscription, the bill file generated on the previous day is pushed daily starting from the next day. On the 4th of each month, the full bill files for the entire billing cycle of the previous month are pushed. The monthly bill PDF is pushed on the 4th of each month for the previous month.</description></item>
        /// <item><description>Bill files generated on a daily basis may be delayed. Delayed bills are pushed the day after they are generated and may include bills from earlier days that were delayed until the previous day. Pull the full files for the previous month at the beginning of each month.<remarks>
        /// <para>To use OSS subscription for the first time, grant the <a href="https://ram.console.aliyun.com/#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission to the subscribing user. If the authorization is revoked, the system stops pushing files, and the user must re-authorize.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>This subscription is the same feature as &quot;Bill Data Storage&quot; in the Expenses and Costs console. Subscriptions are synchronized between the two.</description></item>
        /// <item><description>When subscribing to a directory under a bucket, follow the directory naming conventions:<list type="bullet">
        /// <item><description>Emojis are not allowed. Use valid UTF-8 characters.</description></item>
        /// <item><description>Use / to separate paths and quickly create subdirectories. Do not start with / or \, and do not use consecutive / characters.</description></item>
        /// <item><description>A subdirectory named .. is not allowed.</description></item>
        /// <item><description>The total length must be 1 to 254 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>File names:<list type="bullet">
        /// <item><description><para><b>BillingItemDetailForBillingPeriod</b> (billing item details)</para>
        /// <list type="bullet">
        /// <item><description><para>Daily push file name format: <c>UID_BillingItemDetail_YYYYMMDD</c>, for example, <c>169**_BillingItemDetail_20190310</c>.</para>
        /// </description></item>
        /// <item><description><para>Full file name format at the beginning of the next month: <c>UID_BillingItemDetail_YYYYMM</c>, for example, <c>169**_BillingItemDetail_201903</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>InstanceDetailForBillingPeriod</b> (instance bill details)</para>
        /// <list type="bullet">
        /// <item><description><para>Daily push file name format: <c>UID_InstanceDetail_YYYYMMDD</c>, for example, <c>169**_InstanceDetail_20190310</c>.</para>
        /// </description></item>
        /// <item><description><para>Full file name format at the beginning of the next month: <c>UID_InstanceDetail_YYYYMM</c>, for example, <c>169**_InstanceDetail_201903</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>InstanceDetailMonthly</b> (instance bill summary by billing cycle)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_InstanceDetailMonthly_YYYYMM</c>, for example, <c>169**_InstanceDetailMonthly_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>BillingItemDetailMonthly</b> (billing item summary by billing cycle)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_BillingItemDetailMonthly_YYYYMM</c>, for example, <c>169**_BillingItemDetailMonthly_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SplitItemDetailDaily</b> (split bill daily summary)</para>
        /// <list type="bullet">
        /// <item><description>Daily push file name format: <c>UID_SplitItemDetailDaily_YYYYMM</c>, for example, <c>169**_SplitItemDetailDaily_201903</c>. This file is updated daily with full data from the beginning of the month to the current day, until the 4th of the next month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>MonthBill</b> (monthly bill PDF)</para>
        /// <list type="bullet">
        /// <item><description>Monthly push file name format: <c>UID_MonthBill_YYYYMM</c>, for example, <c>169**_MonthBill_201903</c>. The file for the previous month is pushed on the 4th of each month.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Except for MonthBill, which is a PDF file, all other file types are CSV files. If the number of rows in a bill file exceeds a certain threshold, the file is automatically split into multiple CSV files, which are then compressed into a single ZIP file. The ZIP file name follows the same format.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SubscribeBillToOSSRequest
        /// </param>
        /// 
        /// <returns>
        /// SubscribeBillToOSSResponse
        /// </returns>
        public async Task<SubscribeBillToOSSResponse> SubscribeBillToOSSAsync(SubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscribeBillToOSSWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a detailed list export subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnsubscribeBillToOSSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeBillToOSSResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a detailed list export subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnsubscribeBillToOSSRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeBillToOSSResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a detailed list export subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnsubscribeBillToOSSRequest
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeBillToOSSResponse
        /// </returns>
        public UnsubscribeBillToOSSResponse UnsubscribeBillToOSS(UnsubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnsubscribeBillToOSSWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a detailed list export subscription.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnsubscribeBillToOSSRequest
        /// </param>
        /// 
        /// <returns>
        /// UnsubscribeBillToOSSResponse
        /// </returns>
        public async Task<UnsubscribeBillToOSSResponse> UnsubscribeBillToOSSAsync(UnsubscribeBillToOSSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnsubscribeBillToOSSWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a resource plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeResourcePackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeResourcePackageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a resource plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeResourcePackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeResourcePackageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a resource plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeResourcePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeResourcePackageResponse
        /// </returns>
        public UpgradeResourcePackageResponse UpgradeResourcePackage(UpgradeResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeResourcePackageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades a resource plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeResourcePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeResourcePackageResponse
        /// </returns>
        public async Task<UpgradeResourcePackageResponse> UpgradeResourcePackageAsync(UpgradeResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeResourcePackageWithOptionsAsync(request, runtime);
        }

    }
}
