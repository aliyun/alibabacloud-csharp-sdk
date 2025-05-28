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
            return TeaModel.ToObject<AddCouponDeductTagResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<AddCouponDeductTagResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<CancelFundAccountLowAvailableAmountAlarmResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<CancelFundAccountLowAvailableAmountAlarmResponse>(await CallApiAsync(params_, req, runtime));
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
        /// <para>创建财务单元</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCostCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCostCenterResponse
        /// </returns>
        public CreateCostCenterResponse CreateCostCenterWithOptions(CreateCostCenterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCostCenterShrinkRequest request = new CreateCostCenterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CostCenterEntityList))
            {
                request.CostCenterEntityListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CostCenterEntityList, "CostCenterEntityList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterEntityListShrink))
            {
                query["CostCenterEntityList"] = request.CostCenterEntityListShrink;
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
                Action = "CreateCostCenter",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCostCenterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财务单元</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCostCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCostCenterResponse
        /// </returns>
        public async Task<CreateCostCenterResponse> CreateCostCenterWithOptionsAsync(CreateCostCenterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCostCenterShrinkRequest request = new CreateCostCenterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CostCenterEntityList))
            {
                request.CostCenterEntityListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CostCenterEntityList, "CostCenterEntityList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterEntityListShrink))
            {
                query["CostCenterEntityList"] = request.CostCenterEntityListShrink;
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
                Action = "CreateCostCenter",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCostCenterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCostCenterResponse
        /// </returns>
        public CreateCostCenterResponse CreateCostCenter(CreateCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCostCenterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCostCenterResponse
        /// </returns>
        public async Task<CreateCostCenterResponse> CreateCostCenterAsync(CreateCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCostCenterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资金账户付款关系</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateFundAccountPayRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFundAccountPayRelationResponse
        /// </returns>
        public CreateFundAccountPayRelationResponse CreateFundAccountPayRelationWithOptions(CreateFundAccountPayRelationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFundAccountPayRelationShrinkRequest request = new CreateFundAccountPayRelationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFundAccountPayRelation",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFundAccountPayRelationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资金账户付款关系</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateFundAccountPayRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFundAccountPayRelationResponse
        /// </returns>
        public async Task<CreateFundAccountPayRelationResponse> CreateFundAccountPayRelationWithOptionsAsync(CreateFundAccountPayRelationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFundAccountPayRelationShrinkRequest request = new CreateFundAccountPayRelationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FundAccountId))
            {
                body["FundAccountId"] = request.FundAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFundAccountPayRelation",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFundAccountPayRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资金账户付款关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFundAccountPayRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFundAccountPayRelationResponse
        /// </returns>
        public CreateFundAccountPayRelationResponse CreateFundAccountPayRelation(CreateFundAccountPayRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFundAccountPayRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资金账户付款关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFundAccountPayRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFundAccountPayRelationResponse
        /// </returns>
        public async Task<CreateFundAccountPayRelationResponse> CreateFundAccountPayRelationAsync(CreateFundAccountPayRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFundAccountPayRelationWithOptionsAsync(request, runtime);
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
            return TeaModel.ToObject<CreateFundAccountTransferResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<CreateFundAccountTransferResponse>(await CallApiAsync(params_, req, runtime));
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
        /// <para>创建账单订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReportDefinitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateReportDefinitionResponse
        /// </returns>
        public CreateReportDefinitionResponse CreateReportDefinitionWithOptions(CreateReportDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginBillingCycle))
            {
                query["BeginBillingCycle"] = request.BeginBillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketOwnerAccountId))
            {
                query["OssBucketOwnerAccountId"] = request.OssBucketOwnerAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketPath))
            {
                query["OssBucketPath"] = request.OssBucketPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McProject))
            {
                body["McProject"] = request.McProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McTableName))
            {
                body["McTableName"] = request.McTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportSourceType))
            {
                body["ReportSourceType"] = request.ReportSourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReportDefinition",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReportDefinitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建账单订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReportDefinitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateReportDefinitionResponse
        /// </returns>
        public async Task<CreateReportDefinitionResponse> CreateReportDefinitionWithOptionsAsync(CreateReportDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginBillingCycle))
            {
                query["BeginBillingCycle"] = request.BeginBillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketOwnerAccountId))
            {
                query["OssBucketOwnerAccountId"] = request.OssBucketOwnerAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketPath))
            {
                query["OssBucketPath"] = request.OssBucketPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McProject))
            {
                body["McProject"] = request.McProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McTableName))
            {
                body["McTableName"] = request.McTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportSourceType))
            {
                body["ReportSourceType"] = request.ReportSourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReportDefinition",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReportDefinitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建账单订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReportDefinitionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateReportDefinitionResponse
        /// </returns>
        public CreateReportDefinitionResponse CreateReportDefinition(CreateReportDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReportDefinitionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建账单订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReportDefinitionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateReportDefinitionResponse
        /// </returns>
        public async Task<CreateReportDefinitionResponse> CreateReportDefinitionAsync(CreateReportDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReportDefinitionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCostCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCostCenterResponse
        /// </returns>
        public DeleteCostCenterResponse DeleteCostCenterWithOptions(DeleteCostCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                query["CostCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccountId))
            {
                query["OwnerAccountId"] = request.OwnerAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCostCenter",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCostCenterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCostCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCostCenterResponse
        /// </returns>
        public async Task<DeleteCostCenterResponse> DeleteCostCenterWithOptionsAsync(DeleteCostCenterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                query["CostCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccountId))
            {
                query["OwnerAccountId"] = request.OwnerAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCostCenter",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCostCenterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCostCenterResponse
        /// </returns>
        public DeleteCostCenterResponse DeleteCostCenter(DeleteCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCostCenterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCostCenterResponse
        /// </returns>
        public async Task<DeleteCostCenterResponse> DeleteCostCenterAsync(DeleteCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCostCenterWithOptionsAsync(request, runtime);
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
            return TeaModel.ToObject<DeleteCouponDeductTagResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<DeleteCouponDeductTagResponse>(await CallApiAsync(params_, req, runtime));
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
        /// <para>取消账单订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteReportDefinitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteReportDefinitionResponse
        /// </returns>
        public DeleteReportDefinitionResponse DeleteReportDefinitionWithOptions(DeleteReportDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportTaskId))
            {
                query["ReportTaskId"] = request.ReportTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteReportDefinition",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteReportDefinitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消账单订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteReportDefinitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteReportDefinitionResponse
        /// </returns>
        public async Task<DeleteReportDefinitionResponse> DeleteReportDefinitionWithOptionsAsync(DeleteReportDefinitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportTaskId))
            {
                query["ReportTaskId"] = request.ReportTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteReportDefinition",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteReportDefinitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消账单订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteReportDefinitionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteReportDefinitionResponse
        /// </returns>
        public DeleteReportDefinitionResponse DeleteReportDefinition(DeleteReportDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteReportDefinitionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消账单订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteReportDefinitionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteReportDefinitionResponse
        /// </returns>
        public async Task<DeleteReportDefinitionResponse> DeleteReportDefinitionAsync(DeleteReportDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteReportDefinitionWithOptionsAsync(request, runtime);
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
            return TeaModel.ToObject<DescribeCouponResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<DescribeCouponResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<DescribeCouponItemListResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<DescribeCouponItemListResponse>(await CallApiAsync(params_, req, runtime));
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
        /// <para>获取客户使用SPN的概述信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeUserSpnSummaryInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserSpnSummaryInfoResponse
        /// </returns>
        public DescribeUserSpnSummaryInfoResponse DescribeUserSpnSummaryInfoWithOptions(DescribeUserSpnSummaryInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeUserSpnSummaryInfoShrinkRequest request = new DescribeUserSpnSummaryInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserSpnSummaryInfo",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserSpnSummaryInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取客户使用SPN的概述信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeUserSpnSummaryInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserSpnSummaryInfoResponse
        /// </returns>
        public async Task<DescribeUserSpnSummaryInfoResponse> DescribeUserSpnSummaryInfoWithOptionsAsync(DescribeUserSpnSummaryInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeUserSpnSummaryInfoShrinkRequest request = new DescribeUserSpnSummaryInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserSpnSummaryInfo",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserSpnSummaryInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取客户使用SPN的概述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserSpnSummaryInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserSpnSummaryInfoResponse
        /// </returns>
        public DescribeUserSpnSummaryInfoResponse DescribeUserSpnSummaryInfo(DescribeUserSpnSummaryInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserSpnSummaryInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取客户使用SPN的概述信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserSpnSummaryInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserSpnSummaryInfoResponse
        /// </returns>
        public async Task<DescribeUserSpnSummaryInfoResponse> DescribeUserSpnSummaryInfoAsync(DescribeUserSpnSummaryInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserSpnSummaryInfoWithOptionsAsync(request, runtime);
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
            return TeaModel.ToObject<GetFundAccountAvailableAmountResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountAvailableAmountResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountCanAllocateCreditAmountResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountCanAllocateCreditAmountResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountCanRecycleAmountResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountCanRecycleAmountResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountCanTransferAmountResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountCanTransferAmountResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountCanWithdrawAmountResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountCanWithdrawAmountResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountLowAvailableAmountAlarmResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountLowAvailableAmountAlarmResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountTransactionDetailsResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<GetFundAccountTransactionDetailsResponse>(await CallApiAsync(params_, req, runtime));
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
        /// <para>获取节省计划及可抵扣商品信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSavingPlanDeductableCommodityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanDeductableCommodityResponse
        /// </returns>
        public GetSavingPlanDeductableCommodityResponse GetSavingPlanDeductableCommodityWithOptions(GetSavingPlanDeductableCommodityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSavingPlanDeductableCommodityShrinkRequest request = new GetSavingPlanDeductableCommodityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavingPlanDeductableCommodity",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavingPlanDeductableCommodityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划及可抵扣商品信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSavingPlanDeductableCommodityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanDeductableCommodityResponse
        /// </returns>
        public async Task<GetSavingPlanDeductableCommodityResponse> GetSavingPlanDeductableCommodityWithOptionsAsync(GetSavingPlanDeductableCommodityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSavingPlanDeductableCommodityShrinkRequest request = new GetSavingPlanDeductableCommodityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavingPlanDeductableCommodity",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavingPlanDeductableCommodityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划及可抵扣商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavingPlanDeductableCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanDeductableCommodityResponse
        /// </returns>
        public GetSavingPlanDeductableCommodityResponse GetSavingPlanDeductableCommodity(GetSavingPlanDeductableCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSavingPlanDeductableCommodityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划及可抵扣商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavingPlanDeductableCommodityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanDeductableCommodityResponse
        /// </returns>
        public async Task<GetSavingPlanDeductableCommodityResponse> GetSavingPlanDeductableCommodityAsync(GetSavingPlanDeductableCommodityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSavingPlanDeductableCommodityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划实例共享账号信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSavingPlanShareAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanShareAccountsResponse
        /// </returns>
        public GetSavingPlanShareAccountsResponse GetSavingPlanShareAccountsWithOptions(GetSavingPlanShareAccountsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSavingPlanShareAccountsShrinkRequest request = new GetSavingPlanShareAccountsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpnInstanceCode))
            {
                query["SpnInstanceCode"] = request.SpnInstanceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavingPlanShareAccounts",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavingPlanShareAccountsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划实例共享账号信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSavingPlanShareAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanShareAccountsResponse
        /// </returns>
        public async Task<GetSavingPlanShareAccountsResponse> GetSavingPlanShareAccountsWithOptionsAsync(GetSavingPlanShareAccountsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSavingPlanShareAccountsShrinkRequest request = new GetSavingPlanShareAccountsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpnInstanceCode))
            {
                query["SpnInstanceCode"] = request.SpnInstanceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavingPlanShareAccounts",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavingPlanShareAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划实例共享账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavingPlanShareAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanShareAccountsResponse
        /// </returns>
        public GetSavingPlanShareAccountsResponse GetSavingPlanShareAccounts(GetSavingPlanShareAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSavingPlanShareAccountsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划实例共享账号信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavingPlanShareAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanShareAccountsResponse
        /// </returns>
        public async Task<GetSavingPlanShareAccountsResponse> GetSavingPlanShareAccountsAsync(GetSavingPlanShareAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSavingPlanShareAccountsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划实例客户自定义规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSavingPlanUserDeductRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanUserDeductRuleResponse
        /// </returns>
        public GetSavingPlanUserDeductRuleResponse GetSavingPlanUserDeductRuleWithOptions(GetSavingPlanUserDeductRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSavingPlanUserDeductRuleShrinkRequest request = new GetSavingPlanUserDeductRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpnInstanceCode))
            {
                query["SpnInstanceCode"] = request.SpnInstanceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavingPlanUserDeductRule",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavingPlanUserDeductRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划实例客户自定义规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSavingPlanUserDeductRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanUserDeductRuleResponse
        /// </returns>
        public async Task<GetSavingPlanUserDeductRuleResponse> GetSavingPlanUserDeductRuleWithOptionsAsync(GetSavingPlanUserDeductRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSavingPlanUserDeductRuleShrinkRequest request = new GetSavingPlanUserDeductRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpnInstanceCode))
            {
                query["SpnInstanceCode"] = request.SpnInstanceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavingPlanUserDeductRule",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavingPlanUserDeductRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划实例客户自定义规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavingPlanUserDeductRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanUserDeductRuleResponse
        /// </returns>
        public GetSavingPlanUserDeductRuleResponse GetSavingPlanUserDeductRule(GetSavingPlanUserDeductRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSavingPlanUserDeductRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取节省计划实例客户自定义规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavingPlanUserDeductRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSavingPlanUserDeductRuleResponse
        /// </returns>
        public async Task<GetSavingPlanUserDeductRuleResponse> GetSavingPlanUserDeductRuleAsync(GetSavingPlanUserDeductRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSavingPlanUserDeductRuleWithOptionsAsync(request, runtime);
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
            return TeaModel.ToObject<ListCouponDeductTagResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<ListCouponDeductTagResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<ListFundAccountResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<ListFundAccountResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<ListFundAccountPayRelationResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<ListFundAccountPayRelationResponse>(await CallApiAsync(params_, req, runtime));
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
        /// <para>查看已订阅的报告列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReportDefinitionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReportDefinitionsResponse
        /// </returns>
        public ListReportDefinitionsResponse ListReportDefinitionsWithOptions(ListReportDefinitionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListReportDefinitions",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReportDefinitionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看已订阅的报告列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReportDefinitionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReportDefinitionsResponse
        /// </returns>
        public async Task<ListReportDefinitionsResponse> ListReportDefinitionsWithOptionsAsync(ListReportDefinitionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListReportDefinitions",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReportDefinitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看已订阅的报告列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReportDefinitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReportDefinitionsResponse
        /// </returns>
        public ListReportDefinitionsResponse ListReportDefinitions(ListReportDefinitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListReportDefinitionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看已订阅的报告列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReportDefinitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReportDefinitionsResponse
        /// </returns>
        public async Task<ListReportDefinitionsResponse> ListReportDefinitionsAsync(ListReportDefinitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListReportDefinitionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改财务单元</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyCostCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCostCenterResponse
        /// </returns>
        public ModifyCostCenterResponse ModifyCostCenterWithOptions(ModifyCostCenterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyCostCenterShrinkRequest request = new ModifyCostCenterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CostCenterEntityList))
            {
                request.CostCenterEntityListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CostCenterEntityList, "CostCenterEntityList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterEntityListShrink))
            {
                query["CostCenterEntityList"] = request.CostCenterEntityListShrink;
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
                Action = "ModifyCostCenter",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCostCenterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改财务单元</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyCostCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCostCenterResponse
        /// </returns>
        public async Task<ModifyCostCenterResponse> ModifyCostCenterWithOptionsAsync(ModifyCostCenterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyCostCenterShrinkRequest request = new ModifyCostCenterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CostCenterEntityList))
            {
                request.CostCenterEntityListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CostCenterEntityList, "CostCenterEntityList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterEntityListShrink))
            {
                query["CostCenterEntityList"] = request.CostCenterEntityListShrink;
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
                Action = "ModifyCostCenter",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCostCenterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCostCenterResponse
        /// </returns>
        public ModifyCostCenterResponse ModifyCostCenter(ModifyCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCostCenterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCostCenterResponse
        /// </returns>
        public async Task<ModifyCostCenterResponse> ModifyCostCenterAsync(ModifyCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCostCenterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询财务单元</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryCostCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCostCenterResponse
        /// </returns>
        public QueryCostCenterResponse QueryCostCenterWithOptions(QueryCostCenterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCostCenterShrinkRequest request = new QueryCostCenterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccountId))
            {
                query["OwnerAccountId"] = request.OwnerAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCostCenterId))
            {
                query["ParentCostCenterId"] = request.ParentCostCenterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCostCenter",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCostCenterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询财务单元</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryCostCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCostCenterResponse
        /// </returns>
        public async Task<QueryCostCenterResponse> QueryCostCenterWithOptionsAsync(QueryCostCenterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryCostCenterShrinkRequest request = new QueryCostCenterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EcIdAccountIds))
            {
                request.EcIdAccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EcIdAccountIds, "EcIdAccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIdsShrink))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccountId))
            {
                query["OwnerAccountId"] = request.OwnerAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCostCenterId))
            {
                query["ParentCostCenterId"] = request.ParentCostCenterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCostCenter",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCostCenterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCostCenterResponse
        /// </returns>
        public QueryCostCenterResponse QueryCostCenter(QueryCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCostCenterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询财务单元</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostCenterRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCostCenterResponse
        /// </returns>
        public async Task<QueryCostCenterResponse> QueryCostCenterAsync(QueryCostCenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCostCenterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询财务单元下资源信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostCenterResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCostCenterResourceResponse
        /// </returns>
        public QueryCostCenterResourceResponse QueryCostCenterResourceWithOptions(QueryCostCenterResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIds))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                body["CostCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccountId))
            {
                body["OwnerAccountId"] = request.OwnerAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCostCenterResource",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCostCenterResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询财务单元下资源信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostCenterResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCostCenterResourceResponse
        /// </returns>
        public async Task<QueryCostCenterResourceResponse> QueryCostCenterResourceWithOptionsAsync(QueryCostCenterResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcIdAccountIds))
            {
                query["EcIdAccountIds"] = request.EcIdAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nbid))
            {
                query["Nbid"] = request.Nbid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CostCenterId))
            {
                body["CostCenterId"] = request.CostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccountId))
            {
                body["OwnerAccountId"] = request.OwnerAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCostCenterResource",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCostCenterResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询财务单元下资源信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostCenterResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCostCenterResourceResponse
        /// </returns>
        public QueryCostCenterResourceResponse QueryCostCenterResource(QueryCostCenterResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCostCenterResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询财务单元下资源信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCostCenterResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCostCenterResourceResponse
        /// </returns>
        public async Task<QueryCostCenterResourceResponse> QueryCostCenterResourceAsync(QueryCostCenterResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCostCenterResourceWithOptionsAsync(request, runtime);
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
            return TeaModel.ToObject<SetFundAccountCreditAmountResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<SetFundAccountCreditAmountResponse>(await CallApiAsync(params_, req, runtime));
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
            return TeaModel.ToObject<SetFundAccountLowAvailableAmountAlarmResponse>(CallApi(params_, req, runtime));
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
            return TeaModel.ToObject<SetFundAccountLowAvailableAmountAlarmResponse>(await CallApiAsync(params_, req, runtime));
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
                Version = "2023-09-30",
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

    }
}
