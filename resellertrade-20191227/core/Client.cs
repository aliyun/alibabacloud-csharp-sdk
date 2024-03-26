// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ResellerTrade20191227.Models;

namespace AlibabaCloud.SDK.ResellerTrade20191227
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "resellertrade.aliyuncs.com"},
                {"ap-northeast-2-pop", "resellertrade.aliyuncs.com"},
                {"ap-south-1", "resellertrade.aliyuncs.com"},
                {"ap-southeast-1", "resellertrade.aliyuncs.com"},
                {"ap-southeast-2", "resellertrade.aliyuncs.com"},
                {"ap-southeast-3", "resellertrade.aliyuncs.com"},
                {"ap-southeast-5", "resellertrade.aliyuncs.com"},
                {"cn-beijing", "resellertrade.aliyuncs.com"},
                {"cn-beijing-finance-1", "resellertrade.aliyuncs.com"},
                {"cn-beijing-finance-pop", "resellertrade.aliyuncs.com"},
                {"cn-beijing-gov-1", "resellertrade.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "resellertrade.aliyuncs.com"},
                {"cn-chengdu", "resellertrade.aliyuncs.com"},
                {"cn-edge-1", "resellertrade.aliyuncs.com"},
                {"cn-fujian", "resellertrade.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "resellertrade.aliyuncs.com"},
                {"cn-hangzhou", "resellertrade.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "resellertrade.aliyuncs.com"},
                {"cn-hangzhou-finance", "resellertrade.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "resellertrade.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "resellertrade.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "resellertrade.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "resellertrade.aliyuncs.com"},
                {"cn-hangzhou-test-306", "resellertrade.aliyuncs.com"},
                {"cn-hongkong", "resellertrade.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "resellertrade.aliyuncs.com"},
                {"cn-huhehaote", "resellertrade.aliyuncs.com"},
                {"cn-north-2-gov-1", "resellertrade.aliyuncs.com"},
                {"cn-qingdao", "resellertrade.aliyuncs.com"},
                {"cn-qingdao-nebula", "resellertrade.aliyuncs.com"},
                {"cn-shanghai", "resellertrade.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "resellertrade.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "resellertrade.aliyuncs.com"},
                {"cn-shanghai-finance-1", "resellertrade.aliyuncs.com"},
                {"cn-shanghai-inner", "resellertrade.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "resellertrade.aliyuncs.com"},
                {"cn-shenzhen", "resellertrade.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "resellertrade.aliyuncs.com"},
                {"cn-shenzhen-inner", "resellertrade.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "resellertrade.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "resellertrade.aliyuncs.com"},
                {"cn-wuhan", "resellertrade.aliyuncs.com"},
                {"cn-yushanfang", "resellertrade.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "resellertrade.aliyuncs.com"},
                {"cn-zhangjiakou", "resellertrade.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "resellertrade.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "resellertrade.aliyuncs.com"},
                {"eu-central-1", "resellertrade.aliyuncs.com"},
                {"eu-west-1", "resellertrade.aliyuncs.com"},
                {"eu-west-1-oxs", "resellertrade.aliyuncs.com"},
                {"me-east-1", "resellertrade.aliyuncs.com"},
                {"rus-west-1-pop", "resellertrade.aliyuncs.com"},
                {"us-east-1", "resellertrade.aliyuncs.com"},
                {"us-west-1", "resellertrade.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("resellertrade", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateCouponTemplateResponse CreateCouponTemplateWithOptions(CreateCouponTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivitySite))
            {
                body["ActivitySite"] = request.ActivitySite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                body["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertainMoney))
            {
                body["CertainMoney"] = request.CertainMoney;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["CommodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["ControlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponAmount))
            {
                body["CouponAmount"] = request.CouponAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponEndTime))
            {
                body["CouponEndTime"] = request.CouponEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponFixedType))
            {
                body["CouponFixedType"] = request.CouponFixedType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponStartTime))
            {
                body["CouponStartTime"] = request.CouponStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponType))
            {
                body["CouponType"] = request.CouponType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                bodyFlat["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscountRate))
            {
                body["DiscountRate"] = request.DiscountRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendsMap))
            {
                bodyFlat["ExtendsMap"] = request.ExtendsMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                body["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCodeSet))
            {
                body["ItemCodeSet"] = request.ItemCodeSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Market))
            {
                body["Market"] = request.Market;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketType))
            {
                body["MarketType"] = request.MarketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRelease))
            {
                body["MaxRelease"] = request.MaxRelease;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderTypeSet))
            {
                body["OrderTypeSet"] = request.OrderTypeSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerLimitNum))
            {
                body["PerLimitNum"] = request.PerLimitNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelativeSecond))
            {
                body["RelativeSecond"] = request.RelativeSecond;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionIdSet))
            {
                body["SelectionIdSet"] = request.SelectionIdSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Site))
            {
                body["Site"] = request.Site;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpId))
            {
                body["SpId"] = request.SpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniversalType))
            {
                body["UniversalType"] = request.UniversalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperLimit))
            {
                body["UpperLimit"] = request.UpperLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageCount))
            {
                body["UsageCount"] = request.UsageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                body["UseScene"] = request.UseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPkAmount))
            {
                body["UserPkAmount"] = request.UserPkAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityType))
            {
                body["ValidityType"] = request.ValidityType;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCouponTemplate",
                Version = "2019-12-27",
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

        public async Task<CreateCouponTemplateResponse> CreateCouponTemplateWithOptionsAsync(CreateCouponTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivitySite))
            {
                body["ActivitySite"] = request.ActivitySite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                body["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertainMoney))
            {
                body["CertainMoney"] = request.CertainMoney;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                body["CommodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["ControlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponAmount))
            {
                body["CouponAmount"] = request.CouponAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponEndTime))
            {
                body["CouponEndTime"] = request.CouponEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponFixedType))
            {
                body["CouponFixedType"] = request.CouponFixedType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponStartTime))
            {
                body["CouponStartTime"] = request.CouponStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponType))
            {
                body["CouponType"] = request.CouponType;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                bodyFlat["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscountRate))
            {
                body["DiscountRate"] = request.DiscountRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendsMap))
            {
                bodyFlat["ExtendsMap"] = request.ExtendsMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                body["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCodeSet))
            {
                body["ItemCodeSet"] = request.ItemCodeSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Market))
            {
                body["Market"] = request.Market;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketType))
            {
                body["MarketType"] = request.MarketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRelease))
            {
                body["MaxRelease"] = request.MaxRelease;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderTypeSet))
            {
                body["OrderTypeSet"] = request.OrderTypeSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerLimitNum))
            {
                body["PerLimitNum"] = request.PerLimitNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelativeSecond))
            {
                body["RelativeSecond"] = request.RelativeSecond;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionIdSet))
            {
                body["SelectionIdSet"] = request.SelectionIdSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Site))
            {
                body["Site"] = request.Site;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpId))
            {
                body["SpId"] = request.SpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniversalType))
            {
                body["UniversalType"] = request.UniversalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperLimit))
            {
                body["UpperLimit"] = request.UpperLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageCount))
            {
                body["UsageCount"] = request.UsageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                body["UseScene"] = request.UseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPkAmount))
            {
                body["UserPkAmount"] = request.UserPkAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityType))
            {
                body["ValidityType"] = request.ValidityType;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCouponTemplate",
                Version = "2019-12-27",
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

        public CreateCouponTemplateResponse CreateCouponTemplate(CreateCouponTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCouponTemplateWithOptions(request, runtime);
        }

        public async Task<CreateCouponTemplateResponse> CreateCouponTemplateAsync(CreateCouponTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCouponTemplateWithOptionsAsync(request, runtime);
        }

        public DiscardCouponListResponse DiscardCouponListWithOptions(DiscardCouponListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponList))
            {
                body["CouponList"] = request.CouponList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiscardCouponList",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiscardCouponListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DiscardCouponListResponse> DiscardCouponListWithOptionsAsync(DiscardCouponListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponList))
            {
                body["CouponList"] = request.CouponList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiscardCouponList",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiscardCouponListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DiscardCouponListResponse DiscardCouponList(DiscardCouponListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DiscardCouponListWithOptions(request, runtime);
        }

        public async Task<DiscardCouponListResponse> DiscardCouponListAsync(DiscardCouponListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DiscardCouponListWithOptionsAsync(request, runtime);
        }

        public GetCouponPageResponse GetCouponPageWithOptions(GetCouponPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCouponPage",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCouponPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCouponPageResponse> GetCouponPageWithOptionsAsync(GetCouponPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCouponPage",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCouponPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCouponPageResponse GetCouponPage(GetCouponPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCouponPageWithOptions(request, runtime);
        }

        public async Task<GetCouponPageResponse> GetCouponPageAsync(GetCouponPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCouponPageWithOptionsAsync(request, runtime);
        }

        public GetCustomerListResponse GetCustomerListWithOptions(GetCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerList",
                Version = "2019-12-27",
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

        public async Task<GetCustomerListResponse> GetCustomerListWithOptionsAsync(GetCustomerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomerList",
                Version = "2019-12-27",
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

        public GetCustomerListResponse GetCustomerList(GetCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomerListWithOptions(request, runtime);
        }

        public async Task<GetCustomerListResponse> GetCustomerListAsync(GetCustomerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomerListWithOptionsAsync(request, runtime);
        }

        public GetRelationResponse GetRelationWithOptions(GetRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRelation",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRelationResponse> GetRelationWithOptionsAsync(GetRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRelation",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRelationResponse GetRelation(GetRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRelationWithOptions(request, runtime);
        }

        public async Task<GetRelationResponse> GetRelationAsync(GetRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRelationWithOptionsAsync(request, runtime);
        }

        public GetResellerPayOrderResponse GetResellerPayOrderWithOptions(GetResellerPayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
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
                Action = "GetResellerPayOrder",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResellerPayOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResellerPayOrderResponse> GetResellerPayOrderWithOptionsAsync(GetResellerPayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
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
                Action = "GetResellerPayOrder",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResellerPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResellerPayOrderResponse GetResellerPayOrder(GetResellerPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResellerPayOrderWithOptions(request, runtime);
        }

        public async Task<GetResellerPayOrderResponse> GetResellerPayOrderAsync(GetResellerPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResellerPayOrderWithOptionsAsync(request, runtime);
        }

        public LabelPartnerUserResponse LabelPartnerUserWithOptions(LabelPartnerUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPK))
            {
                body["UserPK"] = request.UserPK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTag))
            {
                body["UserTag"] = request.UserTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LabelPartnerUser",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LabelPartnerUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LabelPartnerUserResponse> LabelPartnerUserWithOptionsAsync(LabelPartnerUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPK))
            {
                body["UserPK"] = request.UserPK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTag))
            {
                body["UserTag"] = request.UserTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LabelPartnerUser",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LabelPartnerUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LabelPartnerUserResponse LabelPartnerUser(LabelPartnerUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LabelPartnerUserWithOptions(request, runtime);
        }

        public async Task<LabelPartnerUserResponse> LabelPartnerUserAsync(LabelPartnerUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LabelPartnerUserWithOptionsAsync(request, runtime);
        }

        public MigrateResourceResponse MigrateResourceWithOptions(MigrateResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCode))
            {
                body["ActionCode"] = request.ActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateResource",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MigrateResourceResponse> MigrateResourceWithOptionsAsync(MigrateResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCode))
            {
                body["ActionCode"] = request.ActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateResource",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MigrateResourceResponse MigrateResource(MigrateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateResourceWithOptions(request, runtime);
        }

        public async Task<MigrateResourceResponse> MigrateResourceAsync(MigrateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateResourceWithOptionsAsync(request, runtime);
        }

        public OfflineActivityResponse OfflineActivityWithOptions(OfflineActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityList))
            {
                body["ActivityList"] = request.ActivityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineActivity",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OfflineActivityResponse> OfflineActivityWithOptionsAsync(OfflineActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityList))
            {
                body["ActivityList"] = request.ActivityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineActivity",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OfflineActivityResponse OfflineActivity(OfflineActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OfflineActivityWithOptions(request, runtime);
        }

        public async Task<OfflineActivityResponse> OfflineActivityAsync(OfflineActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OfflineActivityWithOptionsAsync(request, runtime);
        }

        public PayResultCallbackResponse PayResultCallbackWithOptions(PayResultCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayStatus))
            {
                query["PayStatus"] = request.PayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayTime))
            {
                query["PayTime"] = request.PayTime;
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
                Action = "PayResultCallback",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PayResultCallbackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PayResultCallbackResponse> PayResultCallbackWithOptionsAsync(PayResultCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayStatus))
            {
                query["PayStatus"] = request.PayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayTime))
            {
                query["PayTime"] = request.PayTime;
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
                Action = "PayResultCallback",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PayResultCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PayResultCallbackResponse PayResultCallback(PayResultCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PayResultCallbackWithOptions(request, runtime);
        }

        public async Task<PayResultCallbackResponse> PayResultCallbackAsync(PayResultCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PayResultCallbackWithOptionsAsync(request, runtime);
        }

        public PublicActivityResponse PublicActivityWithOptions(PublicActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityList))
            {
                body["ActivityList"] = request.ActivityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapType))
            {
                body["SnapType"] = request.SnapType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublicActivity",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublicActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PublicActivityResponse> PublicActivityWithOptionsAsync(PublicActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityList))
            {
                body["ActivityList"] = request.ActivityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapType))
            {
                body["SnapType"] = request.SnapType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublicActivity",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublicActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PublicActivityResponse PublicActivity(PublicActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublicActivityWithOptions(request, runtime);
        }

        public async Task<PublicActivityResponse> PublicActivityAsync(PublicActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublicActivityWithOptionsAsync(request, runtime);
        }

        public QueryActivityResponse QueryActivityWithOptions(QueryActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapType))
            {
                body["SnapType"] = request.SnapType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryActivity",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryActivityResponse> QueryActivityWithOptionsAsync(QueryActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapType))
            {
                body["SnapType"] = request.SnapType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryActivity",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryActivityResponse QueryActivity(QueryActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryActivityWithOptions(request, runtime);
        }

        public async Task<QueryActivityResponse> QueryActivityAsync(QueryActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryActivityWithOptionsAsync(request, runtime);
        }

        public QueryEcoRelationResponse QueryEcoRelationWithOptions(QueryEcoRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationTime))
            {
                body["RelationTime"] = request.RelationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEcoRelation",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEcoRelationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryEcoRelationResponse> QueryEcoRelationWithOptionsAsync(QueryEcoRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationTime))
            {
                body["RelationTime"] = request.RelationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEcoRelation",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEcoRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryEcoRelationResponse QueryEcoRelation(QueryEcoRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEcoRelationWithOptions(request, runtime);
        }

        public async Task<QueryEcoRelationResponse> QueryEcoRelationAsync(QueryEcoRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEcoRelationWithOptionsAsync(request, runtime);
        }

        public SaveActivityResponse SaveActivityWithOptions(SaveActivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveActivityShrinkRequest request = new SaveActivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendMap))
            {
                request.ExtendMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendMap, "ExtendMap", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityName))
            {
                body["ActivityName"] = request.ActivityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackUidList))
            {
                body["BlackUidList"] = request.BlackUidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendMapShrink))
            {
                body["ExtendMap"] = request.ExtendMapShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FusionPromotionParamList))
            {
                body["FusionPromotionParamList"] = request.FusionPromotionParamList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishTag))
            {
                body["PublishTag"] = request.PublishTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestAccountUidList))
            {
                body["TestAccountUidList"] = request.TestAccountUidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteUidList))
            {
                body["WhiteUidList"] = request.WhiteUidList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveActivity",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveActivityResponse> SaveActivityWithOptionsAsync(SaveActivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveActivityShrinkRequest request = new SaveActivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendMap))
            {
                request.ExtendMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendMap, "ExtendMap", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityName))
            {
                body["ActivityName"] = request.ActivityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlackUidList))
            {
                body["BlackUidList"] = request.BlackUidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendMapShrink))
            {
                body["ExtendMap"] = request.ExtendMapShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FusionPromotionParamList))
            {
                body["FusionPromotionParamList"] = request.FusionPromotionParamList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishTag))
            {
                body["PublishTag"] = request.PublishTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestAccountUidList))
            {
                body["TestAccountUidList"] = request.TestAccountUidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteUidList))
            {
                body["WhiteUidList"] = request.WhiteUidList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveActivity",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveActivityResponse SaveActivity(SaveActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveActivityWithOptions(request, runtime);
        }

        public async Task<SaveActivityResponse> SaveActivityAsync(SaveActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveActivityWithOptionsAsync(request, runtime);
        }

        public SendCouponResponse SendCouponWithOptions(SendCouponRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                body["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                body["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAmountModelList))
            {
                body["UserAmountModelList"] = request.UserAmountModelList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendCoupon",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCouponResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendCouponResponse> SendCouponWithOptionsAsync(SendCouponRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                body["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                body["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAmountModelList))
            {
                body["UserAmountModelList"] = request.UserAmountModelList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendCoupon",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCouponResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendCouponResponse SendCoupon(SendCouponRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCouponWithOptions(request, runtime);
        }

        public async Task<SendCouponResponse> SendCouponAsync(SendCouponRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCouponWithOptionsAsync(request, runtime);
        }

        public TransferResourceResponse TransferResourceWithOptions(TransferResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCode))
            {
                body["ActionCode"] = request.ActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferResource",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferResourceResponse> TransferResourceWithOptionsAsync(TransferResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCode))
            {
                body["ActionCode"] = request.ActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferResource",
                Version = "2019-12-27",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferResourceResponse TransferResource(TransferResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferResourceWithOptions(request, runtime);
        }

        public async Task<TransferResourceResponse> TransferResourceAsync(TransferResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferResourceWithOptionsAsync(request, runtime);
        }

    }
}
