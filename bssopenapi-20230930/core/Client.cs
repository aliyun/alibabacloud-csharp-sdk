// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.BssOpenApi20230930.Models;

namespace AlibabaCloud.SDK.BssOpenApi20230930
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
        /// <para>添加优惠券抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddCouponDeductTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCouponDeductTagResponse
        /// </returns>
        public AddCouponDeductTagResponse AddCouponDeductTagWithOptions(AddCouponDeductTagRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddCouponDeductTagShrinkRequest request = new AddCouponDeductTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponId))
            {
                query["CouponId"] = request.CouponId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCouponDeductTag",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCouponDeductTagResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCouponDeductTagResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加优惠券抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddCouponDeductTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCouponDeductTagResponse
        /// </returns>
        public async Task<AddCouponDeductTagResponse> AddCouponDeductTagWithOptionsAsync(AddCouponDeductTagRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddCouponDeductTagShrinkRequest request = new AddCouponDeductTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponId))
            {
                query["CouponId"] = request.CouponId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCouponDeductTag",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCouponDeductTagResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCouponDeductTagResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加优惠券抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCouponDeductTagRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCouponDeductTagResponse
        /// </returns>
        public AddCouponDeductTagResponse AddCouponDeductTag(AddCouponDeductTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCouponDeductTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加优惠券抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCouponDeductTagRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCouponDeductTagResponse
        /// </returns>
        public async Task<AddCouponDeductTagResponse> AddCouponDeductTagAsync(AddCouponDeductTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCouponDeductTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public CancelFundAccountLowAvailableAmountAlarmResponse CancelFundAccountLowAvailableAmountAlarmWithOptions(CancelFundAccountLowAvailableAmountAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelFundAccountLowAvailableAmountAlarm",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelFundAccountLowAvailableAmountAlarmResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelFundAccountLowAvailableAmountAlarmResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public async Task<CancelFundAccountLowAvailableAmountAlarmResponse> CancelFundAccountLowAvailableAmountAlarmWithOptionsAsync(CancelFundAccountLowAvailableAmountAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelFundAccountLowAvailableAmountAlarm",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelFundAccountLowAvailableAmountAlarmResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelFundAccountLowAvailableAmountAlarmResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public CancelFundAccountLowAvailableAmountAlarmResponse CancelFundAccountLowAvailableAmountAlarm(CancelFundAccountLowAvailableAmountAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelFundAccountLowAvailableAmountAlarmWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public async Task<CancelFundAccountLowAvailableAmountAlarmResponse> CancelFundAccountLowAvailableAmountAlarmAsync(CancelFundAccountLowAvailableAmountAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelFundAccountLowAvailableAmountAlarmWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资金账户划拨/回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFundAccountTransferRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFundAccountTransferResponse
        /// </returns>
        public CreateFundAccountTransferResponse CreateFundAccountTransferWithOptions(CreateFundAccountTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceType))
            {
                body["FinanceType"] = request.FinanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromFundAccountId))
            {
                body["FromFundAccountId"] = request.FromFundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToFundAccountId))
            {
                body["ToFundAccountId"] = request.ToFundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferType))
            {
                body["TransferType"] = request.TransferType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFundAccountTransfer",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFundAccountTransferResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFundAccountTransferResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资金账户划拨/回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFundAccountTransferRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFundAccountTransferResponse
        /// </returns>
        public async Task<CreateFundAccountTransferResponse> CreateFundAccountTransferWithOptionsAsync(CreateFundAccountTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceType))
            {
                body["FinanceType"] = request.FinanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromFundAccountId))
            {
                body["FromFundAccountId"] = request.FromFundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToFundAccountId))
            {
                body["ToFundAccountId"] = request.ToFundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferType))
            {
                body["TransferType"] = request.TransferType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFundAccountTransfer",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFundAccountTransferResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFundAccountTransferResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资金账户划拨/回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFundAccountTransferRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFundAccountTransferResponse
        /// </returns>
        public CreateFundAccountTransferResponse CreateFundAccountTransfer(CreateFundAccountTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFundAccountTransferWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资金账户划拨/回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFundAccountTransferRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFundAccountTransferResponse
        /// </returns>
        public async Task<CreateFundAccountTransferResponse> CreateFundAccountTransferAsync(CreateFundAccountTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFundAccountTransferWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除优惠券的抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteCouponDeductTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCouponDeductTagResponse
        /// </returns>
        public DeleteCouponDeductTagResponse DeleteCouponDeductTagWithOptions(DeleteCouponDeductTagRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteCouponDeductTagShrinkRequest request = new DeleteCouponDeductTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponId))
            {
                query["CouponId"] = request.CouponId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["TagKeys"] = request.TagKeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCouponDeductTag",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCouponDeductTagResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCouponDeductTagResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除优惠券的抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteCouponDeductTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCouponDeductTagResponse
        /// </returns>
        public async Task<DeleteCouponDeductTagResponse> DeleteCouponDeductTagWithOptionsAsync(DeleteCouponDeductTagRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteCouponDeductTagShrinkRequest request = new DeleteCouponDeductTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponId))
            {
                query["CouponId"] = request.CouponId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["TagKeys"] = request.TagKeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCouponDeductTag",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCouponDeductTagResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCouponDeductTagResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除优惠券的抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCouponDeductTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCouponDeductTagResponse
        /// </returns>
        public DeleteCouponDeductTagResponse DeleteCouponDeductTag(DeleteCouponDeductTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCouponDeductTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除优惠券的抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCouponDeductTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCouponDeductTagResponse
        /// </returns>
        public async Task<DeleteCouponDeductTagResponse> DeleteCouponDeductTagAsync(DeleteCouponDeductTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCouponDeductTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCouponRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCouponResponse
        /// </returns>
        public DescribeCouponResponse DescribeCouponWithOptions(DescribeCouponRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCouponShrinkRequest request = new DescribeCouponShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCoupon",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCouponResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCouponResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCouponRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCouponResponse
        /// </returns>
        public async Task<DescribeCouponResponse> DescribeCouponWithOptionsAsync(DescribeCouponRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCouponShrinkRequest request = new DescribeCouponShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCoupon",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCouponResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCouponResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCouponRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCouponResponse
        /// </returns>
        public DescribeCouponResponse DescribeCoupon(DescribeCouponRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCouponWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCouponRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCouponResponse
        /// </returns>
        public async Task<DescribeCouponResponse> DescribeCouponAsync(DescribeCouponRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCouponWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券可用商品列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCouponItemListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCouponItemListResponse
        /// </returns>
        public DescribeCouponItemListResponse DescribeCouponItemListWithOptions(DescribeCouponItemListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCouponItemListShrinkRequest request = new DescribeCouponItemListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCouponItemList",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCouponItemListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCouponItemListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券可用商品列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCouponItemListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCouponItemListResponse
        /// </returns>
        public async Task<DescribeCouponItemListResponse> DescribeCouponItemListWithOptionsAsync(DescribeCouponItemListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCouponItemListShrinkRequest request = new DescribeCouponItemListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCouponItemList",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCouponItemListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCouponItemListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券可用商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCouponItemListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCouponItemListResponse
        /// </returns>
        public DescribeCouponItemListResponse DescribeCouponItemList(DescribeCouponItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCouponItemListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券可用商品列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCouponItemListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCouponItemListResponse
        /// </returns>
        public async Task<DescribeCouponItemListResponse> DescribeCouponItemListAsync(DescribeCouponItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCouponItemListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可用金</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountAvailableAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountAvailableAmountResponse
        /// </returns>
        public GetFundAccountAvailableAmountResponse GetFundAccountAvailableAmountWithOptions(GetFundAccountAvailableAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountAvailableAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountAvailableAmountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountAvailableAmountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可用金</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountAvailableAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountAvailableAmountResponse
        /// </returns>
        public async Task<GetFundAccountAvailableAmountResponse> GetFundAccountAvailableAmountWithOptionsAsync(GetFundAccountAvailableAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountAvailableAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountAvailableAmountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountAvailableAmountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可用金</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountAvailableAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountAvailableAmountResponse
        /// </returns>
        public GetFundAccountAvailableAmountResponse GetFundAccountAvailableAmount(GetFundAccountAvailableAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFundAccountAvailableAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可用金</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountAvailableAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountAvailableAmountResponse
        /// </returns>
        public async Task<GetFundAccountAvailableAmountResponse> GetFundAccountAvailableAmountAsync(GetFundAccountAvailableAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFundAccountAvailableAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可分配信控额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanAllocateCreditAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanAllocateCreditAmountResponse
        /// </returns>
        public GetFundAccountCanAllocateCreditAmountResponse GetFundAccountCanAllocateCreditAmountWithOptions(GetFundAccountCanAllocateCreditAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountCanAllocateCreditAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountCanAllocateCreditAmountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountCanAllocateCreditAmountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可分配信控额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanAllocateCreditAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanAllocateCreditAmountResponse
        /// </returns>
        public async Task<GetFundAccountCanAllocateCreditAmountResponse> GetFundAccountCanAllocateCreditAmountWithOptionsAsync(GetFundAccountCanAllocateCreditAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountCanAllocateCreditAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountCanAllocateCreditAmountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountCanAllocateCreditAmountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可分配信控额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanAllocateCreditAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanAllocateCreditAmountResponse
        /// </returns>
        public GetFundAccountCanAllocateCreditAmountResponse GetFundAccountCanAllocateCreditAmount(GetFundAccountCanAllocateCreditAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFundAccountCanAllocateCreditAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可分配信控额度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanAllocateCreditAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanAllocateCreditAmountResponse
        /// </returns>
        public async Task<GetFundAccountCanAllocateCreditAmountResponse> GetFundAccountCanAllocateCreditAmountAsync(GetFundAccountCanAllocateCreditAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFundAccountCanAllocateCreditAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可回收金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanRecycleAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanRecycleAmountResponse
        /// </returns>
        public GetFundAccountCanRecycleAmountResponse GetFundAccountCanRecycleAmountWithOptions(GetFundAccountCanRecycleAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleFromFundAccountId))
            {
                body["RecycleFromFundAccountId"] = request.RecycleFromFundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountCanRecycleAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountCanRecycleAmountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountCanRecycleAmountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可回收金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanRecycleAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanRecycleAmountResponse
        /// </returns>
        public async Task<GetFundAccountCanRecycleAmountResponse> GetFundAccountCanRecycleAmountWithOptionsAsync(GetFundAccountCanRecycleAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleFromFundAccountId))
            {
                body["RecycleFromFundAccountId"] = request.RecycleFromFundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountCanRecycleAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountCanRecycleAmountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountCanRecycleAmountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可回收金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanRecycleAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanRecycleAmountResponse
        /// </returns>
        public GetFundAccountCanRecycleAmountResponse GetFundAccountCanRecycleAmount(GetFundAccountCanRecycleAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFundAccountCanRecycleAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可回收金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanRecycleAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanRecycleAmountResponse
        /// </returns>
        public async Task<GetFundAccountCanRecycleAmountResponse> GetFundAccountCanRecycleAmountAsync(GetFundAccountCanRecycleAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFundAccountCanRecycleAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户的可转出金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanTransferAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanTransferAmountResponse
        /// </returns>
        public GetFundAccountCanTransferAmountResponse GetFundAccountCanTransferAmountWithOptions(GetFundAccountCanTransferAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountCanTransferAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountCanTransferAmountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountCanTransferAmountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户的可转出金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanTransferAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanTransferAmountResponse
        /// </returns>
        public async Task<GetFundAccountCanTransferAmountResponse> GetFundAccountCanTransferAmountWithOptionsAsync(GetFundAccountCanTransferAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountCanTransferAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountCanTransferAmountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountCanTransferAmountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户的可转出金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanTransferAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanTransferAmountResponse
        /// </returns>
        public GetFundAccountCanTransferAmountResponse GetFundAccountCanTransferAmount(GetFundAccountCanTransferAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFundAccountCanTransferAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户的可转出金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanTransferAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanTransferAmountResponse
        /// </returns>
        public async Task<GetFundAccountCanTransferAmountResponse> GetFundAccountCanTransferAmountAsync(GetFundAccountCanTransferAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFundAccountCanTransferAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可提现金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanWithdrawAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanWithdrawAmountResponse
        /// </returns>
        public GetFundAccountCanWithdrawAmountResponse GetFundAccountCanWithdrawAmountWithOptions(GetFundAccountCanWithdrawAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountCanWithdrawAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountCanWithdrawAmountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountCanWithdrawAmountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可提现金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanWithdrawAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanWithdrawAmountResponse
        /// </returns>
        public async Task<GetFundAccountCanWithdrawAmountResponse> GetFundAccountCanWithdrawAmountWithOptionsAsync(GetFundAccountCanWithdrawAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountCanWithdrawAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountCanWithdrawAmountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountCanWithdrawAmountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可提现金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanWithdrawAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanWithdrawAmountResponse
        /// </returns>
        public GetFundAccountCanWithdrawAmountResponse GetFundAccountCanWithdrawAmount(GetFundAccountCanWithdrawAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFundAccountCanWithdrawAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户可提现金额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountCanWithdrawAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountCanWithdrawAmountResponse
        /// </returns>
        public async Task<GetFundAccountCanWithdrawAmountResponse> GetFundAccountCanWithdrawAmountAsync(GetFundAccountCanWithdrawAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFundAccountCanWithdrawAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public GetFundAccountLowAvailableAmountAlarmResponse GetFundAccountLowAvailableAmountAlarmWithOptions(GetFundAccountLowAvailableAmountAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountLowAvailableAmountAlarm",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountLowAvailableAmountAlarmResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountLowAvailableAmountAlarmResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public async Task<GetFundAccountLowAvailableAmountAlarmResponse> GetFundAccountLowAvailableAmountAlarmWithOptionsAsync(GetFundAccountLowAvailableAmountAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountLowAvailableAmountAlarm",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountLowAvailableAmountAlarmResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountLowAvailableAmountAlarmResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public GetFundAccountLowAvailableAmountAlarmResponse GetFundAccountLowAvailableAmountAlarm(GetFundAccountLowAvailableAmountAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFundAccountLowAvailableAmountAlarmWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public async Task<GetFundAccountLowAvailableAmountAlarmResponse> GetFundAccountLowAvailableAmountAlarmAsync(GetFundAccountLowAvailableAmountAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFundAccountLowAvailableAmountAlarmWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户收支明细</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetFundAccountTransactionDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountTransactionDetailsResponse
        /// </returns>
        public GetFundAccountTransactionDetailsResponse GetFundAccountTransactionDetailsWithOptions(GetFundAccountTransactionDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetFundAccountTransactionDetailsShrinkRequest request = new GetFundAccountTransactionDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TransactionChannelList))
            {
                request.TransactionChannelListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TransactionChannelList, "TransactionChannelList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TransactionTypeList))
            {
                request.TransactionTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TransactionTypeList, "TransactionTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillNumber))
            {
                body["BillNumber"] = request.BillNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTransactionNumber))
            {
                body["ChannelTransactionNumber"] = request.ChannelTransactionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannelListShrink))
            {
                body["TransactionChannelList"] = request.TransactionChannelListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionDirection))
            {
                body["TransactionDirection"] = request.TransactionDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionNumber))
            {
                body["TransactionNumber"] = request.TransactionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionType))
            {
                body["TransactionType"] = request.TransactionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionTypeListShrink))
            {
                body["TransactionTypeList"] = request.TransactionTypeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountTransactionDetails",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountTransactionDetailsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountTransactionDetailsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户收支明细</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetFundAccountTransactionDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountTransactionDetailsResponse
        /// </returns>
        public async Task<GetFundAccountTransactionDetailsResponse> GetFundAccountTransactionDetailsWithOptionsAsync(GetFundAccountTransactionDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetFundAccountTransactionDetailsShrinkRequest request = new GetFundAccountTransactionDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TransactionChannelList))
            {
                request.TransactionChannelListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TransactionChannelList, "TransactionChannelList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TransactionTypeList))
            {
                request.TransactionTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TransactionTypeList, "TransactionTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillNumber))
            {
                body["BillNumber"] = request.BillNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelTransactionNumber))
            {
                body["ChannelTransactionNumber"] = request.ChannelTransactionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionChannelListShrink))
            {
                body["TransactionChannelList"] = request.TransactionChannelListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionDirection))
            {
                body["TransactionDirection"] = request.TransactionDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionNumber))
            {
                body["TransactionNumber"] = request.TransactionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionType))
            {
                body["TransactionType"] = request.TransactionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionTypeListShrink))
            {
                body["TransactionTypeList"] = request.TransactionTypeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFundAccountTransactionDetails",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetFundAccountTransactionDetailsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetFundAccountTransactionDetailsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户收支明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountTransactionDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountTransactionDetailsResponse
        /// </returns>
        public GetFundAccountTransactionDetailsResponse GetFundAccountTransactionDetails(GetFundAccountTransactionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFundAccountTransactionDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户收支明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFundAccountTransactionDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFundAccountTransactionDetailsResponse
        /// </returns>
        public async Task<GetFundAccountTransactionDetailsResponse> GetFundAccountTransactionDetailsAsync(GetFundAccountTransactionDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFundAccountTransactionDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券设置的抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCouponDeductTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCouponDeductTagResponse
        /// </returns>
        public ListCouponDeductTagResponse ListCouponDeductTagWithOptions(ListCouponDeductTagRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCouponDeductTagShrinkRequest request = new ListCouponDeductTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponId))
            {
                query["CouponId"] = request.CouponId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCouponDeductTag",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCouponDeductTagResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCouponDeductTagResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券设置的抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCouponDeductTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCouponDeductTagResponse
        /// </returns>
        public async Task<ListCouponDeductTagResponse> ListCouponDeductTagWithOptionsAsync(ListCouponDeductTagRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCouponDeductTagShrinkRequest request = new ListCouponDeductTagShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponId))
            {
                query["CouponId"] = request.CouponId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCouponDeductTag",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCouponDeductTagResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCouponDeductTagResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券设置的抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCouponDeductTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCouponDeductTagResponse
        /// </returns>
        public ListCouponDeductTagResponse ListCouponDeductTag(ListCouponDeductTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCouponDeductTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询优惠券设置的抵扣标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCouponDeductTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCouponDeductTagResponse
        /// </returns>
        public async Task<ListCouponDeductTagResponse> ListCouponDeductTagAsync(ListCouponDeductTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCouponDeductTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFundAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFundAccountResponse
        /// </returns>
        public ListFundAccountResponse ListFundAccountWithOptions(ListFundAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryOnlyInUse))
            {
                body["QueryOnlyInUse"] = request.QueryOnlyInUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryOnlyManage))
            {
                body["QueryOnlyManage"] = request.QueryOnlyManage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFundAccount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListFundAccountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListFundAccountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFundAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFundAccountResponse
        /// </returns>
        public async Task<ListFundAccountResponse> ListFundAccountWithOptionsAsync(ListFundAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryOnlyInUse))
            {
                body["QueryOnlyInUse"] = request.QueryOnlyInUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryOnlyManage))
            {
                body["QueryOnlyManage"] = request.QueryOnlyManage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFundAccount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListFundAccountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListFundAccountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFundAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFundAccountResponse
        /// </returns>
        public ListFundAccountResponse ListFundAccount(ListFundAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFundAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFundAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFundAccountResponse
        /// </returns>
        public async Task<ListFundAccountResponse> ListFundAccountAsync(ListFundAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFundAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户的付款关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFundAccountPayRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFundAccountPayRelationResponse
        /// </returns>
        public ListFundAccountPayRelationResponse ListFundAccountPayRelationWithOptions(ListFundAccountPayRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFundAccountPayRelation",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListFundAccountPayRelationResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListFundAccountPayRelationResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户的付款关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFundAccountPayRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFundAccountPayRelationResponse
        /// </returns>
        public async Task<ListFundAccountPayRelationResponse> ListFundAccountPayRelationWithOptionsAsync(ListFundAccountPayRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFundAccountPayRelation",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListFundAccountPayRelationResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListFundAccountPayRelationResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户的付款关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFundAccountPayRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFundAccountPayRelationResponse
        /// </returns>
        public ListFundAccountPayRelationResponse ListFundAccountPayRelation(ListFundAccountPayRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFundAccountPayRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资金账户的付款关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFundAccountPayRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFundAccountPayRelationResponse
        /// </returns>
        public async Task<ListFundAccountPayRelationResponse> ListFundAccountPayRelationAsync(ListFundAccountPayRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFundAccountPayRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置资金账户的信控限额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetFundAccountCreditAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFundAccountCreditAmountResponse
        /// </returns>
        public SetFundAccountCreditAmountResponse SetFundAccountCreditAmountWithOptions(SetFundAccountCreditAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditAmount))
            {
                body["CreditAmount"] = request.CreditAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFundAccountCreditAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SetFundAccountCreditAmountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetFundAccountCreditAmountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置资金账户的信控限额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetFundAccountCreditAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFundAccountCreditAmountResponse
        /// </returns>
        public async Task<SetFundAccountCreditAmountResponse> SetFundAccountCreditAmountWithOptionsAsync(SetFundAccountCreditAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditAmount))
            {
                body["CreditAmount"] = request.CreditAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFundAccountCreditAmount",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SetFundAccountCreditAmountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetFundAccountCreditAmountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置资金账户的信控限额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetFundAccountCreditAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFundAccountCreditAmountResponse
        /// </returns>
        public SetFundAccountCreditAmountResponse SetFundAccountCreditAmount(SetFundAccountCreditAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetFundAccountCreditAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置资金账户的信控限额</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetFundAccountCreditAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFundAccountCreditAmountResponse
        /// </returns>
        public async Task<SetFundAccountCreditAmountResponse> SetFundAccountCreditAmountAsync(SetFundAccountCreditAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetFundAccountCreditAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public SetFundAccountLowAvailableAmountAlarmResponse SetFundAccountLowAvailableAmountAlarmWithOptions(SetFundAccountLowAvailableAmountAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdAmount))
            {
                body["ThresholdAmount"] = request.ThresholdAmount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFundAccountLowAvailableAmountAlarm",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SetFundAccountLowAvailableAmountAlarmResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetFundAccountLowAvailableAmountAlarmResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public async Task<SetFundAccountLowAvailableAmountAlarmResponse> SetFundAccountLowAvailableAmountAlarmWithOptionsAsync(SetFundAccountLowAvailableAmountAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThresholdAmount))
            {
                body["ThresholdAmount"] = request.ThresholdAmount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetFundAccountLowAvailableAmountAlarm",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SetFundAccountLowAvailableAmountAlarmResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetFundAccountLowAvailableAmountAlarmResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public SetFundAccountLowAvailableAmountAlarmResponse SetFundAccountLowAvailableAmountAlarm(SetFundAccountLowAvailableAmountAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetFundAccountLowAvailableAmountAlarmWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置资金账户低额预警</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetFundAccountLowAvailableAmountAlarmRequest
        /// </param>
        /// 
        /// <returns>
        /// SetFundAccountLowAvailableAmountAlarmResponse
        /// </returns>
        public async Task<SetFundAccountLowAvailableAmountAlarmResponse> SetFundAccountLowAvailableAmountAlarmAsync(SetFundAccountLowAvailableAmountAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetFundAccountLowAvailableAmountAlarmWithOptionsAsync(request, runtime);
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
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SetSavingPlanUserDeductRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetSavingPlanUserDeductRuleResponse>(Execute(params_, req, runtime));
            }
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
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SetSavingPlanUserDeductRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetSavingPlanUserDeductRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
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

    }
}
