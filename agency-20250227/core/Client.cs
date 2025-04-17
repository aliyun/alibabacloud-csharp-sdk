// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Agency20250227.Models;

namespace AlibabaCloud.SDK.Agency20250227
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
        /// <para>查询账单导出文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBillDetailFileListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBillDetailFileListResponse
        /// </returns>
        public GetBillDetailFileListResponse GetBillDetailFileListWithOptions(GetBillDetailFileListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillMonth))
            {
                query["BillMonth"] = request.BillMonth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAccessKeyId))
            {
                query["OssAccessKeyId"] = request.OssAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAccessKeySecret))
            {
                query["OssAccessKeySecret"] = request.OssAccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssRegion))
            {
                query["OssRegion"] = request.OssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssSecurityToken))
            {
                query["OssSecurityToken"] = request.OssSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBillDetailFileList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBillDetailFileListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账单导出文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBillDetailFileListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBillDetailFileListResponse
        /// </returns>
        public async Task<GetBillDetailFileListResponse> GetBillDetailFileListWithOptionsAsync(GetBillDetailFileListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillMonth))
            {
                query["BillMonth"] = request.BillMonth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAccessKeyId))
            {
                query["OssAccessKeyId"] = request.OssAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAccessKeySecret))
            {
                query["OssAccessKeySecret"] = request.OssAccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssRegion))
            {
                query["OssRegion"] = request.OssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssSecurityToken))
            {
                query["OssSecurityToken"] = request.OssSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBillDetailFileList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBillDetailFileListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账单导出文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBillDetailFileListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBillDetailFileListResponse
        /// </returns>
        public GetBillDetailFileListResponse GetBillDetailFileList(GetBillDetailFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBillDetailFileListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账单导出文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBillDetailFileListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBillDetailFileListResponse
        /// </returns>
        public async Task<GetBillDetailFileListResponse> GetBillDetailFileListAsync(GetBillDetailFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBillDetailFileListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴佣金明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommissionDetailFileListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCommissionDetailFileListResponse
        /// </returns>
        public GetCommissionDetailFileListResponse GetCommissionDetailFileListWithOptions(GetCommissionDetailFileListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillMonth))
            {
                query["BillMonth"] = request.BillMonth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCommissionDetailFileList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCommissionDetailFileListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴佣金明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommissionDetailFileListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCommissionDetailFileListResponse
        /// </returns>
        public async Task<GetCommissionDetailFileListResponse> GetCommissionDetailFileListWithOptionsAsync(GetCommissionDetailFileListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillMonth))
            {
                query["BillMonth"] = request.BillMonth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCommissionDetailFileList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCommissionDetailFileListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴佣金明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommissionDetailFileListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCommissionDetailFileListResponse
        /// </returns>
        public GetCommissionDetailFileListResponse GetCommissionDetailFileList(GetCommissionDetailFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCommissionDetailFileListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴佣金明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommissionDetailFileListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCommissionDetailFileListResponse
        /// </returns>
        public async Task<GetCommissionDetailFileListResponse> GetCommissionDetailFileListAsync(GetCommissionDetailFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCommissionDetailFileListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴拓客订单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCustomerOrderListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerOrderListResponse
        /// </returns>
        public GetCustomerOrderListResponse GetCustomerOrderListWithOptions(GetCustomerOrderListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCustomerOrderListShrinkRequest request = new GetCustomerOrderListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderTypeList))
            {
                request.OrderTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderTypeList, "OrderTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerAccount))
            {
                query["CustomerAccount"] = request.CustomerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerUid))
            {
                query["CustomerUid"] = request.CustomerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateAfter))
            {
                query["OrderCreateAfter"] = request.OrderCreateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateBefore))
            {
                query["OrderCreateBefore"] = request.OrderCreateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPayAfter))
            {
                query["OrderPayAfter"] = request.OrderPayAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPayBefore))
            {
                query["OrderPayBefore"] = request.OrderPayBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderTypeListShrink))
            {
                query["OrderTypeList"] = request.OrderTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayAmountAfter))
            {
                query["PayAmountAfter"] = request.PayAmountAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayAmountBefore))
            {
                query["PayAmountBefore"] = request.PayAmountBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamAccountForCustomerManager))
            {
                query["RamAccountForCustomerManager"] = request.RamAccountForCustomerManager;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerOrderList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerOrderListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴拓客订单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCustomerOrderListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerOrderListResponse
        /// </returns>
        public async Task<GetCustomerOrderListResponse> GetCustomerOrderListWithOptionsAsync(GetCustomerOrderListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCustomerOrderListShrinkRequest request = new GetCustomerOrderListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderTypeList))
            {
                request.OrderTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderTypeList, "OrderTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerAccount))
            {
                query["CustomerAccount"] = request.CustomerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerUid))
            {
                query["CustomerUid"] = request.CustomerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateAfter))
            {
                query["OrderCreateAfter"] = request.OrderCreateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateBefore))
            {
                query["OrderCreateBefore"] = request.OrderCreateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPayAfter))
            {
                query["OrderPayAfter"] = request.OrderPayAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPayBefore))
            {
                query["OrderPayBefore"] = request.OrderPayBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderTypeListShrink))
            {
                query["OrderTypeList"] = request.OrderTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayAmountAfter))
            {
                query["PayAmountAfter"] = request.PayAmountAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayAmountBefore))
            {
                query["PayAmountBefore"] = request.PayAmountBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamAccountForCustomerManager))
            {
                query["RamAccountForCustomerManager"] = request.RamAccountForCustomerManager;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerOrderList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerOrderListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴拓客订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerOrderListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerOrderListResponse
        /// </returns>
        public GetCustomerOrderListResponse GetCustomerOrderList(GetCustomerOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerOrderListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴拓客订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerOrderListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerOrderListResponse
        /// </returns>
        public async Task<GetCustomerOrderListResponse> GetCustomerOrderListAsync(GetCustomerOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerOrderListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴续费率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRenewalRateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRenewalRateListResponse
        /// </returns>
        public GetRenewalRateListResponse GetRenewalRateListWithOptions(GetRenewalRateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FiscalYearAndQuarter))
            {
                query["FiscalYearAndQuarter"] = request.FiscalYearAndQuarter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRenewalRateList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRenewalRateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴续费率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRenewalRateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRenewalRateListResponse
        /// </returns>
        public async Task<GetRenewalRateListResponse> GetRenewalRateListWithOptionsAsync(GetRenewalRateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FiscalYearAndQuarter))
            {
                query["FiscalYearAndQuarter"] = request.FiscalYearAndQuarter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRenewalRateList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRenewalRateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴续费率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRenewalRateListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRenewalRateListResponse
        /// </returns>
        public GetRenewalRateListResponse GetRenewalRateList(GetRenewalRateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRenewalRateListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询伙伴续费率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRenewalRateListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRenewalRateListResponse
        /// </returns>
        public async Task<GetRenewalRateListResponse> GetRenewalRateListAsync(GetRenewalRateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRenewalRateListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询二级分销商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubPartnerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubPartnerListResponse
        /// </returns>
        public GetSubPartnerListResponse GetSubPartnerListWithOptions(GetSubPartnerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPartnerCompanyName))
            {
                query["SubPartnerCompanyName"] = request.SubPartnerCompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPartnerPid))
            {
                query["SubPartnerPid"] = request.SubPartnerPid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubPartnerList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubPartnerListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询二级分销商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubPartnerListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubPartnerListResponse
        /// </returns>
        public async Task<GetSubPartnerListResponse> GetSubPartnerListWithOptionsAsync(GetSubPartnerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPartnerCompanyName))
            {
                query["SubPartnerCompanyName"] = request.SubPartnerCompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPartnerPid))
            {
                query["SubPartnerPid"] = request.SubPartnerPid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubPartnerList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubPartnerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询二级分销商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubPartnerListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubPartnerListResponse
        /// </returns>
        public GetSubPartnerListResponse GetSubPartnerList(GetSubPartnerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubPartnerListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询二级分销商列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubPartnerListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubPartnerListResponse
        /// </returns>
        public async Task<GetSubPartnerListResponse> GetSubPartnerListAsync(GetSubPartnerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubPartnerListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询拓渠订单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSubPartnerOrderListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubPartnerOrderListResponse
        /// </returns>
        public GetSubPartnerOrderListResponse GetSubPartnerOrderListWithOptions(GetSubPartnerOrderListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSubPartnerOrderListShrinkRequest request = new GetSubPartnerOrderListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderTypeList))
            {
                request.OrderTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderTypeList, "OrderTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateAfter))
            {
                query["OrderCreateAfter"] = request.OrderCreateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateBefore))
            {
                query["OrderCreateBefore"] = request.OrderCreateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPayAfter))
            {
                query["OrderPayAfter"] = request.OrderPayAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPayBefore))
            {
                query["OrderPayBefore"] = request.OrderPayBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderTypeListShrink))
            {
                query["OrderTypeList"] = request.OrderTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayAmountAfter))
            {
                query["PayAmountAfter"] = request.PayAmountAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayAmountBefore))
            {
                query["PayAmountBefore"] = request.PayAmountBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPartnerName))
            {
                query["SubPartnerName"] = request.SubPartnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPartnerUid))
            {
                query["SubPartnerUid"] = request.SubPartnerUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubPartnerOrderList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubPartnerOrderListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询拓渠订单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSubPartnerOrderListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubPartnerOrderListResponse
        /// </returns>
        public async Task<GetSubPartnerOrderListResponse> GetSubPartnerOrderListWithOptionsAsync(GetSubPartnerOrderListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSubPartnerOrderListShrinkRequest request = new GetSubPartnerOrderListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OrderTypeList))
            {
                request.OrderTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OrderTypeList, "OrderTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateAfter))
            {
                query["OrderCreateAfter"] = request.OrderCreateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateBefore))
            {
                query["OrderCreateBefore"] = request.OrderCreateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPayAfter))
            {
                query["OrderPayAfter"] = request.OrderPayAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderPayBefore))
            {
                query["OrderPayBefore"] = request.OrderPayBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                query["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderTypeListShrink))
            {
                query["OrderTypeList"] = request.OrderTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayAmountAfter))
            {
                query["PayAmountAfter"] = request.PayAmountAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayAmountBefore))
            {
                query["PayAmountBefore"] = request.PayAmountBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPartnerName))
            {
                query["SubPartnerName"] = request.SubPartnerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPartnerUid))
            {
                query["SubPartnerUid"] = request.SubPartnerUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubPartnerOrderList",
                Version = "2025-02-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubPartnerOrderListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询拓渠订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubPartnerOrderListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubPartnerOrderListResponse
        /// </returns>
        public GetSubPartnerOrderListResponse GetSubPartnerOrderList(GetSubPartnerOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubPartnerOrderListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询拓渠订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubPartnerOrderListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubPartnerOrderListResponse
        /// </returns>
        public async Task<GetSubPartnerOrderListResponse> GetSubPartnerOrderListAsync(GetSubPartnerOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubPartnerOrderListWithOptionsAsync(request, runtime);
        }

    }
}
