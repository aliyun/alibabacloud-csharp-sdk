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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressInfo))
            {
                body["AddressInfo"] = request.AddressInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddAddressResponse> AddAddressWithOptionsAsync(AddAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressInfo))
            {
                body["AddressInfo"] = request.AddressInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAddressResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmActivityId))
            {
                query["LmActivityId"] = request.LmActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizCode))
            {
                query["SubBizCode"] = request.SubBizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperNum))
            {
                query["UpperNum"] = request.UpperNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddItemLimitRule",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddItemLimitRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddItemLimitRuleResponse> AddItemLimitRuleWithOptionsAsync(AddItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmActivityId))
            {
                query["LmActivityId"] = request.LmActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizCode))
            {
                query["SubBizCode"] = request.SubBizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperNum))
            {
                query["UpperNum"] = request.UpperNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddItemLimitRule",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddItemLimitRuleResponse>(await CallApiAsync(params_, req, runtime));
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

        public AddItemToSubBizsResponse AddItemToSubBizsWithOptions(AddItemToSubBizsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddItemToSubBizsShrinkRequest request = new AddItemToSubBizsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubBizIds))
            {
                request.SubBizIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubBizIds, "SubBizIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizIdsShrink))
            {
                body["SubBizIds"] = request.SubBizIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddItemToSubBizs",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddItemToSubBizsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddItemToSubBizsResponse> AddItemToSubBizsWithOptionsAsync(AddItemToSubBizsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddItemToSubBizsShrinkRequest request = new AddItemToSubBizsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubBizIds))
            {
                request.SubBizIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubBizIds, "SubBizIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizIdsShrink))
            {
                body["SubBizIds"] = request.SubBizIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddItemToSubBizs",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddItemToSubBizsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddItemToSubBizsResponse AddItemToSubBizs(AddItemToSubBizsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddItemToSubBizsWithOptions(request, runtime);
        }

        public async Task<AddItemToSubBizsResponse> AddItemToSubBizsAsync(AddItemToSubBizsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddItemToSubBizsWithOptionsAsync(request, runtime);
        }

        public AddSupplierNewItemsResponse AddSupplierNewItemsWithOptions(AddSupplierNewItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSupplierNewItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSupplierNewItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddSupplierNewItemsResponse> AddSupplierNewItemsWithOptionsAsync(AddSupplierNewItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSupplierNewItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSupplierNewItemsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReasonTextId))
            {
                query["ApplyReasonTextId"] = request.ApplyReasonTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundCount))
            {
                query["ApplyRefundCount"] = request.ApplyRefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundFee))
            {
                query["ApplyRefundFee"] = request.ApplyRefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                query["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                query["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveMessage))
            {
                body["LeaveMessage"] = request.LeaveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeavePictureList))
            {
                body["LeavePictureList"] = request.LeavePictureList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyRefundResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyRefundResponse> ApplyRefundWithOptionsAsync(ApplyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReasonTextId))
            {
                query["ApplyReasonTextId"] = request.ApplyReasonTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundCount))
            {
                query["ApplyRefundCount"] = request.ApplyRefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundFee))
            {
                query["ApplyRefundFee"] = request.ApplyRefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                query["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                query["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveMessage))
            {
                body["LeaveMessage"] = request.LeaveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeavePictureList))
            {
                body["LeavePictureList"] = request.LeavePictureList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyRefundResponse>(await CallApiAsync(params_, req, runtime));
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

        public ApplyRefundWithDesignatedTbUidResponse ApplyRefundWithDesignatedTbUidWithOptions(ApplyRefundWithDesignatedTbUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyRefundWithDesignatedTbUidShrinkRequest request = new ApplyRefundWithDesignatedTbUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Proofs))
            {
                request.ProofsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Proofs, "Proofs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProofsShrink))
            {
                body["Proofs"] = request.ProofsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonId))
            {
                body["ReasonId"] = request.ReasonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCode))
            {
                body["RefundCode"] = request.RefundCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCount))
            {
                body["RefundCount"] = request.RefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundFee))
            {
                body["RefundFee"] = request.RefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyRefundWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyRefundWithDesignatedTbUidResponse> ApplyRefundWithDesignatedTbUidWithOptionsAsync(ApplyRefundWithDesignatedTbUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyRefundWithDesignatedTbUidShrinkRequest request = new ApplyRefundWithDesignatedTbUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Proofs))
            {
                request.ProofsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Proofs, "Proofs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProofsShrink))
            {
                body["Proofs"] = request.ProofsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonId))
            {
                body["ReasonId"] = request.ReasonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCode))
            {
                body["RefundCode"] = request.RefundCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCount))
            {
                body["RefundCount"] = request.RefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundFee))
            {
                body["RefundFee"] = request.RefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyRefundWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyRefundWithDesignatedTbUidResponse ApplyRefundWithDesignatedTbUid(ApplyRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyRefundWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<ApplyRefundWithDesignatedTbUidResponse> ApplyRefundWithDesignatedTbUidAsync(ApplyRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyRefundWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public BatchRegistAnonymousTbAccountResponse BatchRegistAnonymousTbAccountWithOptions(BatchRegistAnonymousTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdJsonList))
            {
                query["IdJsonList"] = request.IdJsonList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRegistAnonymousTbAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRegistAnonymousTbAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchRegistAnonymousTbAccountResponse> BatchRegistAnonymousTbAccountWithOptionsAsync(BatchRegistAnonymousTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdJsonList))
            {
                query["IdJsonList"] = request.IdJsonList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRegistAnonymousTbAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRegistAnonymousTbAccountResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrder",
                Version = "2018-01-16",
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

        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrder",
                Version = "2018-01-16",
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

        public CancelOrderWithDesignatedTbUidResponse CancelOrderWithDesignatedTbUidWithOptions(CancelOrderWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelOrderWithDesignatedTbUidResponse> CancelOrderWithDesignatedTbUidWithOptionsAsync(CancelOrderWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelOrderWithDesignatedTbUidResponse CancelOrderWithDesignatedTbUid(CancelOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOrderWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<CancelOrderWithDesignatedTbUidResponse> CancelOrderWithDesignatedTbUidAsync(CancelOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOrderWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public CancelRealTbAccountSupportResponse CancelRealTbAccountSupportWithOptions(CancelRealTbAccountSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRealTbAccountSupport",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRealTbAccountSupportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelRealTbAccountSupportResponse> CancelRealTbAccountSupportWithOptionsAsync(CancelRealTbAccountSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRealTbAccountSupport",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRealTbAccountSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelRealTbAccountSupportResponse CancelRealTbAccountSupport(CancelRealTbAccountSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRealTbAccountSupportWithOptions(request, runtime);
        }

        public async Task<CancelRealTbAccountSupportResponse> CancelRealTbAccountSupportAsync(CancelRealTbAccountSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRealTbAccountSupportWithOptionsAsync(request, runtime);
        }

        public CancelRefundResponse CancelRefundWithOptions(CancelRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                query["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRefundResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelRefundResponse> CancelRefundWithOptionsAsync(CancelRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                query["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRefundResponse>(await CallApiAsync(params_, req, runtime));
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

        public CancelRefundWithDesignatedTbUidResponse CancelRefundWithDesignatedTbUidWithOptions(CancelRefundWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRefundWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelRefundWithDesignatedTbUidResponse> CancelRefundWithDesignatedTbUidWithOptionsAsync(CancelRefundWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRefundWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelRefundWithDesignatedTbUidResponse CancelRefundWithDesignatedTbUid(CancelRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRefundWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<CancelRefundWithDesignatedTbUidResponse> CancelRefundWithDesignatedTbUidAsync(CancelRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRefundWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public ConfirmDisburseResponse ConfirmDisburseWithOptions(ConfirmDisburseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmDisburse",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDisburseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmDisburseResponse> ConfirmDisburseWithOptionsAsync(ConfirmDisburseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmDisburse",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDisburseResponse>(await CallApiAsync(params_, req, runtime));
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

        public ConfirmDisburseWithDesignatedTbUidResponse ConfirmDisburseWithDesignatedTbUidWithOptions(ConfirmDisburseWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmDisburseWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDisburseWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmDisburseWithDesignatedTbUidResponse> ConfirmDisburseWithDesignatedTbUidWithOptionsAsync(ConfirmDisburseWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmDisburseWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDisburseWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmDisburseWithDesignatedTbUidResponse ConfirmDisburseWithDesignatedTbUid(ConfirmDisburseWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmDisburseWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<ConfirmDisburseWithDesignatedTbUidResponse> ConfirmDisburseWithDesignatedTbUidAsync(ConfirmDisburseWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmDisburseWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public CreateMovieTicketOrderResponse CreateMovieTicketOrderWithOptions(CreateMovieTicketOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMovieTicketOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMovieTicketOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMovieTicketOrderResponse> CreateMovieTicketOrderWithOptionsAsync(CreateMovieTicketOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMovieTicketOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMovieTicketOrderResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerMessageMap))
            {
                query["BuyerMessageMap"] = request.BuyerMessageMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                query["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                query["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                query["TotalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOrderResponse> CreateOrderWithOptionsAsync(CreateOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerMessageMap))
            {
                query["BuyerMessageMap"] = request.BuyerMessageMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                query["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                query["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                query["TotalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateOrderPayUrlForOutDiscountResponse CreateOrderPayUrlForOutDiscountWithOptions(CreateOrderPayUrlForOutDiscountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyInfo))
            {
                body["BuyInfo"] = request.BuyInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderPayUrlForOutDiscount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderPayUrlForOutDiscountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOrderPayUrlForOutDiscountResponse> CreateOrderPayUrlForOutDiscountWithOptionsAsync(CreateOrderPayUrlForOutDiscountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyInfo))
            {
                body["BuyInfo"] = request.BuyInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderPayUrlForOutDiscount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderPayUrlForOutDiscountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOrderPayUrlForOutDiscountResponse CreateOrderPayUrlForOutDiscount(CreateOrderPayUrlForOutDiscountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderPayUrlForOutDiscountWithOptions(request, runtime);
        }

        public async Task<CreateOrderPayUrlForOutDiscountResponse> CreateOrderPayUrlForOutDiscountAsync(CreateOrderPayUrlForOutDiscountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderPayUrlForOutDiscountWithOptionsAsync(request, runtime);
        }

        public CreateOrderTransactionDetailFileResponse CreateOrderTransactionDetailFileWithOptions(CreateOrderTransactionDetailFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelName))
            {
                body["ChannelName"] = request.ChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                body["CreateEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                body["CreateStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                body["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                body["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayStatus))
            {
                body["PayStatus"] = request.PayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentEndTime))
            {
                body["PaymentEndTime"] = request.PaymentEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentStartTime))
            {
                body["PaymentStartTime"] = request.PaymentStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoCode))
            {
                body["PoCode"] = request.PoCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundEndTime))
            {
                body["RefundEndTime"] = request.RefundEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundStartTime))
            {
                body["RefundStartTime"] = request.RefundStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerName))
            {
                body["SellerName"] = request.SellerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettlementNode))
            {
                body["SettlementNode"] = request.SettlementNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopName))
            {
                body["ShopName"] = request.ShopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbMainOrderId))
            {
                body["TbMainOrderId"] = request.TbMainOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderTransactionDetailFile",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderTransactionDetailFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOrderTransactionDetailFileResponse> CreateOrderTransactionDetailFileWithOptionsAsync(CreateOrderTransactionDetailFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelName))
            {
                body["ChannelName"] = request.ChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                body["CreateEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                body["CreateStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                body["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStatus))
            {
                body["OrderStatus"] = request.OrderStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayStatus))
            {
                body["PayStatus"] = request.PayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentEndTime))
            {
                body["PaymentEndTime"] = request.PaymentEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentStartTime))
            {
                body["PaymentStartTime"] = request.PaymentStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoCode))
            {
                body["PoCode"] = request.PoCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundEndTime))
            {
                body["RefundEndTime"] = request.RefundEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundStartTime))
            {
                body["RefundStartTime"] = request.RefundStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerName))
            {
                body["SellerName"] = request.SellerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettlementNode))
            {
                body["SettlementNode"] = request.SettlementNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopName))
            {
                body["ShopName"] = request.ShopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbMainOrderId))
            {
                body["TbMainOrderId"] = request.TbMainOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderTransactionDetailFile",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderTransactionDetailFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOrderTransactionDetailFileResponse CreateOrderTransactionDetailFile(CreateOrderTransactionDetailFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderTransactionDetailFileWithOptions(request, runtime);
        }

        public async Task<CreateOrderTransactionDetailFileResponse> CreateOrderTransactionDetailFileAsync(CreateOrderTransactionDetailFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderTransactionDetailFileWithOptionsAsync(request, runtime);
        }

        public CreateOrderV2Response CreateOrderV2WithOptions(CreateOrderV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerMessageMap))
            {
                query["BuyerMessageMap"] = request.BuyerMessageMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                query["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                query["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                query["TotalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderV2",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOrderV2Response> CreateOrderV2WithOptionsAsync(CreateOrderV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerMessageMap))
            {
                query["BuyerMessageMap"] = request.BuyerMessageMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                query["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                query["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                query["TotalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderV2",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderV2Response>(await CallApiAsync(params_, req, runtime));
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

        public CreateOrderWithDesignatedTbUidResponse CreateOrderWithDesignatedTbUidWithOptions(CreateOrderWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerMessages))
            {
                body["BuyerMessages"] = request.BuyerMessages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryInfo))
            {
                body["DeliveryInfo"] = request.DeliveryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                body["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderItems))
            {
                body["OrderItems"] = request.OrderItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                body["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOrderWithDesignatedTbUidResponse> CreateOrderWithDesignatedTbUidWithOptionsAsync(CreateOrderWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerMessages))
            {
                body["BuyerMessages"] = request.BuyerMessages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryInfo))
            {
                body["DeliveryInfo"] = request.DeliveryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                body["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderItems))
            {
                body["OrderItems"] = request.OrderItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                body["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrderWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOrderWithDesignatedTbUidResponse CreateOrderWithDesignatedTbUid(CreateOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrderWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<CreateOrderWithDesignatedTbUidResponse> CreateOrderWithDesignatedTbUidAsync(CreateOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrderWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public CreateOutDiscountOrderWithDesignatedTbUidResponse CreateOutDiscountOrderWithDesignatedTbUidWithOptions(CreateOutDiscountOrderWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerMessages))
            {
                body["BuyerMessages"] = request.BuyerMessages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryInfo))
            {
                body["DeliveryInfo"] = request.DeliveryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                body["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderItems))
            {
                body["OrderItems"] = request.OrderItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutDiscountInfos))
            {
                body["OutDiscountInfos"] = request.OutDiscountInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                body["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOutDiscountOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOutDiscountOrderWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOutDiscountOrderWithDesignatedTbUidResponse> CreateOutDiscountOrderWithDesignatedTbUidWithOptionsAsync(CreateOutDiscountOrderWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerMessages))
            {
                body["BuyerMessages"] = request.BuyerMessages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryInfo))
            {
                body["DeliveryInfo"] = request.DeliveryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                body["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderItems))
            {
                body["OrderItems"] = request.OrderItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutDiscountInfos))
            {
                body["OutDiscountInfos"] = request.OutDiscountInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                body["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOutDiscountOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOutDiscountOrderWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOutDiscountOrderWithDesignatedTbUidResponse CreateOutDiscountOrderWithDesignatedTbUid(CreateOutDiscountOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOutDiscountOrderWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<CreateOutDiscountOrderWithDesignatedTbUidResponse> CreateOutDiscountOrderWithDesignatedTbUidAsync(CreateOutDiscountOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOutDiscountOrderWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public CreatePayUrlResponse CreatePayUrlWithOptions(CreatePayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyInfo))
            {
                body["BuyInfo"] = request.BuyInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePayUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePayUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePayUrlResponse> CreatePayUrlWithOptionsAsync(CreatePayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyInfo))
            {
                body["BuyInfo"] = request.BuyInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePayUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePayUrlResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateSettleConfirmResponse CreateSettleConfirmWithOptions(CreateSettleConfirmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo))
            {
                body["SettleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["TradeNo"] = request.TradeNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSettleConfirm",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSettleConfirmResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSettleConfirmResponse> CreateSettleConfirmWithOptionsAsync(CreateSettleConfirmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo))
            {
                body["SettleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["TradeNo"] = request.TradeNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSettleConfirm",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSettleConfirmResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSettleConfirmResponse CreateSettleConfirm(CreateSettleConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSettleConfirmWithOptions(request, runtime);
        }

        public async Task<CreateSettleConfirmResponse> CreateSettleConfirmAsync(CreateSettleConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSettleConfirmWithOptionsAsync(request, runtime);
        }

        public CreateVirtualProductOrderResponse CreateVirtualProductOrderWithOptions(CreateVirtualProductOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                query["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                query["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                query["TotalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualProductOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualProductOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVirtualProductOrderResponse> CreateVirtualProductOrderWithOptionsAsync(CreateVirtualProductOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderExpireTime))
            {
                query["OrderExpireTime"] = request.OrderExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                query["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                query["TotalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualProductOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualProductOrderResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementNo))
            {
                body["AgreementNo"] = request.AgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerId))
            {
                body["BuyerId"] = request.BuyerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsDetail))
            {
                body["GoodsDetail"] = request.GoodsDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleMode))
            {
                body["SettleMode"] = request.SettleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["TotalAmount"] = request.TotalAmount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWithholdTrade",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWithholdTradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateWithholdTradeResponse> CreateWithholdTradeWithOptionsAsync(CreateWithholdTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementNo))
            {
                body["AgreementNo"] = request.AgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerId))
            {
                body["BuyerId"] = request.BuyerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsDetail))
            {
                body["GoodsDetail"] = request.GoodsDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleMode))
            {
                body["SettleMode"] = request.SettleMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["TotalAmount"] = request.TotalAmount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWithholdTrade",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWithholdTradeResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeductUserPointResponse DeductUserPointWithOptions(DeductUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeductUserPointShrinkRequest request = new DeductUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeductUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeductUserPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeductUserPointResponse> DeductUserPointWithOptionsAsync(DeductUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeductUserPointShrinkRequest request = new DeductUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeductUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeductUserPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeductUserPointResponse DeductUserPoint(DeductUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeductUserPointWithOptions(request, runtime);
        }

        public async Task<DeductUserPointResponse> DeductUserPointAsync(DeductUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeductUserPointWithOptionsAsync(request, runtime);
        }

        public DeleteBizItemsResponse DeleteBizItemsWithOptions(DeleteBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdList))
            {
                query["ItemIdList"] = request.ItemIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBizItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBizItemsResponse> DeleteBizItemsWithOptionsAsync(DeleteBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdList))
            {
                query["ItemIdList"] = request.ItemIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBizItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBizItemsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmActivityId))
            {
                query["LmActivityId"] = request.LmActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizCode))
            {
                query["SubBizCode"] = request.SubBizCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteItemLimitRule",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteItemLimitRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteItemLimitRuleResponse> DeleteItemLimitRuleWithOptionsAsync(DeleteItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmActivityId))
            {
                query["LmActivityId"] = request.LmActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizCode))
            {
                query["SubBizCode"] = request.SubBizCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteItemLimitRule",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteItemLimitRuleResponse>(await CallApiAsync(params_, req, runtime));
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

        public DownloadCpsBillFileResponse DownloadCpsBillFileWithOptions(DownloadCpsBillFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                body["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadCpsBillFile",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadCpsBillFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DownloadCpsBillFileResponse> DownloadCpsBillFileWithOptionsAsync(DownloadCpsBillFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                body["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadCpsBillFile",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadCpsBillFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DownloadCpsBillFileResponse DownloadCpsBillFile(DownloadCpsBillFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadCpsBillFileWithOptions(request, runtime);
        }

        public async Task<DownloadCpsBillFileResponse> DownloadCpsBillFileAsync(DownloadCpsBillFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadCpsBillFileWithOptionsAsync(request, runtime);
        }

        public DownloadItemBillFileResponse DownloadItemBillFileWithOptions(DownloadItemBillFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                body["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadItemBillFile",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadItemBillFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DownloadItemBillFileResponse> DownloadItemBillFileWithOptionsAsync(DownloadItemBillFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                body["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadItemBillFile",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadItemBillFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DownloadItemBillFileResponse DownloadItemBillFile(DownloadItemBillFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadItemBillFileWithOptions(request, runtime);
        }

        public async Task<DownloadItemBillFileResponse> DownloadItemBillFileAsync(DownloadItemBillFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadItemBillFileWithOptionsAsync(request, runtime);
        }

        public DownloadOrderTransactionDetailFileResponse DownloadOrderTransactionDetailFileWithOptions(DownloadOrderTransactionDetailFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                body["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadOrderTransactionDetailFile",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadOrderTransactionDetailFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DownloadOrderTransactionDetailFileResponse> DownloadOrderTransactionDetailFileWithOptionsAsync(DownloadOrderTransactionDetailFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                body["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadOrderTransactionDetailFile",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadOrderTransactionDetailFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DownloadOrderTransactionDetailFileResponse DownloadOrderTransactionDetailFile(DownloadOrderTransactionDetailFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadOrderTransactionDetailFileWithOptions(request, runtime);
        }

        public async Task<DownloadOrderTransactionDetailFileResponse> DownloadOrderTransactionDetailFileAsync(DownloadOrderTransactionDetailFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadOrderTransactionDetailFileWithOptionsAsync(request, runtime);
        }

        public EnableOrderResponse EnableOrderWithOptions(EnableOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                query["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableOrderResponse> EnableOrderWithOptionsAsync(EnableOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeId))
            {
                query["OutTradeId"] = request.OutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableOrderResponse>(await CallApiAsync(params_, req, runtime));
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

        public EnableOrderWithDesignatedTbUidResponse EnableOrderWithDesignatedTbUidWithOptions(EnableOrderWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableOrderWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableOrderWithDesignatedTbUidResponse> EnableOrderWithDesignatedTbUidWithOptionsAsync(EnableOrderWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableOrderWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableOrderWithDesignatedTbUidResponse EnableOrderWithDesignatedTbUid(EnableOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableOrderWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<EnableOrderWithDesignatedTbUidResponse> EnableOrderWithDesignatedTbUidAsync(EnableOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableOrderWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public ExecuteNodeResponse ExecuteNodeWithOptions(ExecuteNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceId))
            {
                query["NodeInstanceId"] = request.NodeInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                query["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["ProcessInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestData))
            {
                query["RequestData"] = request.RequestData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteNode",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteNodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExecuteNodeResponse> ExecuteNodeWithOptionsAsync(ExecuteNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceId))
            {
                query["NodeInstanceId"] = request.NodeInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                query["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["ProcessInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestData))
            {
                query["RequestData"] = request.RequestData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteNode",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExecuteNodeResponse ExecuteNode(ExecuteNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteNodeWithOptions(request, runtime);
        }

        public async Task<ExecuteNodeResponse> ExecuteNodeAsync(ExecuteNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteNodeWithOptionsAsync(request, runtime);
        }

        public FreezeUserPointResponse FreezeUserPointWithOptions(FreezeUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FreezeUserPointShrinkRequest request = new FreezeUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FreezeUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeUserPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FreezeUserPointResponse> FreezeUserPointWithOptionsAsync(FreezeUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FreezeUserPointShrinkRequest request = new FreezeUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FreezeUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeUserPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FreezeUserPointResponse FreezeUserPoint(FreezeUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FreezeUserPointWithOptions(request, runtime);
        }

        public async Task<FreezeUserPointResponse> FreezeUserPointAsync(FreezeUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FreezeUserPointWithOptionsAsync(request, runtime);
        }

        public GetActivityGameInfoResponse GetActivityGameInfoWithOptions(GetActivityGameInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetActivityGameInfoShrinkRequest request = new GetActivityGameInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GameId))
            {
                query["GameId"] = request.GameId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetActivityGameInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActivityGameInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetActivityGameInfoResponse> GetActivityGameInfoWithOptionsAsync(GetActivityGameInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetActivityGameInfoShrinkRequest request = new GetActivityGameInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GameId))
            {
                query["GameId"] = request.GameId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetActivityGameInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActivityGameInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetActivityGameInfoResponse GetActivityGameInfo(GetActivityGameInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetActivityGameInfoWithOptions(request, runtime);
        }

        public async Task<GetActivityGameInfoResponse> GetActivityGameInfoAsync(GetActivityGameInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetActivityGameInfoWithOptionsAsync(request, runtime);
        }

        public GetCategoryChainResponse GetCategoryChainWithOptions(GetCategoryChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCategoryChain",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoryChainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCategoryChainResponse> GetCategoryChainWithOptionsAsync(GetCategoryChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCategoryChain",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoryChainResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCategoryList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoryListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCategoryListResponse> GetCategoryListWithOptionsAsync(GetCategoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCategoryList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoryListResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cuid))
            {
                query["Cuid"] = request.Cuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                query["Nick"] = request.Nick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                query["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomServiceUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomServiceUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCustomServiceUrlResponse> GetCustomServiceUrlWithOptionsAsync(GetCustomServiceUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cuid))
            {
                query["Cuid"] = request.Cuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                query["Nick"] = request.Nick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                query["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomServiceUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomServiceUrlResponse>(await CallApiAsync(params_, req, runtime));
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGuidePage",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGuidePageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGuidePageResponse> GetGuidePageWithOptionsAsync(GetGuidePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGuidePage",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGuidePageResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetItemPromotion",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetItemPromotionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetItemPromotionResponse> GetItemPromotionWithOptionsAsync(GetItemPromotionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetItemPromotion",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetItemPromotionResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailUrl))
            {
                body["FailUrl"] = request.FailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUrl))
            {
                body["TargetUrl"] = request.TargetUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginPage",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLoginPageResponse> GetLoginPageWithOptionsAsync(GetLoginPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailUrl))
            {
                body["FailUrl"] = request.FailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUrl))
            {
                body["TargetUrl"] = request.TargetUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginPage",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginPageResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSwitchUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwitchUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSwitchUrlResponse> GetSwitchUrlWithOptionsAsync(GetSwitchUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSwitchUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwitchUrlResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFlag))
            {
                query["UserFlag"] = request.UserFlag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryJson))
            {
                body["QueryJson"] = request.QueryJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(GetUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFlag))
            {
                query["UserFlag"] = request.UserFlag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryJson))
            {
                body["QueryJson"] = request.QueryJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await CallApiAsync(params_, req, runtime));
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

        public GetUserTokenPageResponse GetUserTokenPageWithOptions(GetUserTokenPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserTokenPage",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserTokenPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserTokenPageResponse> GetUserTokenPageWithOptionsAsync(GetUserTokenPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserTokenPage",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserTokenPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserTokenPageResponse GetUserTokenPage(GetUserTokenPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserTokenPageWithOptions(request, runtime);
        }

        public async Task<GetUserTokenPageResponse> GetUserTokenPageAsync(GetUserTokenPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserTokenPageWithOptionsAsync(request, runtime);
        }

        public GetWithholdSignPageUrlResponse GetWithholdSignPageUrlWithOptions(GetWithholdSignPageUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalAgreementNo))
            {
                body["ExternalAgreementNo"] = request.ExternalAgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityParameters))
            {
                body["IdentityParameters"] = request.IdentityParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantServiceDescription))
            {
                body["MerchantServiceDescription"] = request.MerchantServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantServiceName))
            {
                body["MerchantServiceName"] = request.MerchantServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                body["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                body["ReturnUrl"] = request.ReturnUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWithholdSignPageUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWithholdSignPageUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWithholdSignPageUrlResponse> GetWithholdSignPageUrlWithOptionsAsync(GetWithholdSignPageUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalAgreementNo))
            {
                body["ExternalAgreementNo"] = request.ExternalAgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityParameters))
            {
                body["IdentityParameters"] = request.IdentityParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantServiceDescription))
            {
                body["MerchantServiceDescription"] = request.MerchantServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantServiceName))
            {
                body["MerchantServiceName"] = request.MerchantServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                body["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                body["ReturnUrl"] = request.ReturnUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWithholdSignPageUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWithholdSignPageUrlResponse>(await CallApiAsync(params_, req, runtime));
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

        public GiveUserPointResponse GiveUserPointWithOptions(GiveUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GiveUserPointShrinkRequest request = new GiveUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetBizUid))
            {
                query["TargetBizUid"] = request.TargetBizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GiveUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GiveUserPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GiveUserPointResponse> GiveUserPointWithOptionsAsync(GiveUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GiveUserPointShrinkRequest request = new GiveUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetBizUid))
            {
                query["TargetBizUid"] = request.TargetBizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GiveUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GiveUserPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GiveUserPointResponse GiveUserPoint(GiveUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GiveUserPointWithOptions(request, runtime);
        }

        public async Task<GiveUserPointResponse> GiveUserPointAsync(GiveUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GiveUserPointWithOptionsAsync(request, runtime);
        }

        public GrantPromotionToUserResponse GrantPromotionToUserWithOptions(GrantPromotionToUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantPromotionToUserShrinkRequest request = new GrantPromotionToUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSeconds))
            {
                query["ExpireSeconds"] = request.ExpireSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantMode))
            {
                query["GrantMode"] = request.GrantMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantWay))
            {
                query["GrantWay"] = request.GrantWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                query["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityCode))
            {
                query["SecurityCode"] = request.SecurityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPromotionToUser",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantPromotionToUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantPromotionToUserResponse> GrantPromotionToUserWithOptionsAsync(GrantPromotionToUserRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantPromotionToUserShrinkRequest request = new GrantPromotionToUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSeconds))
            {
                query["ExpireSeconds"] = request.ExpireSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantMode))
            {
                query["GrantMode"] = request.GrantMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantWay))
            {
                query["GrantWay"] = request.GrantWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                query["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityCode))
            {
                query["SecurityCode"] = request.SecurityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPromotionToUser",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantPromotionToUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantPromotionToUserResponse GrantPromotionToUser(GrantPromotionToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantPromotionToUserWithOptions(request, runtime);
        }

        public async Task<GrantPromotionToUserResponse> GrantPromotionToUserAsync(GrantPromotionToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantPromotionToUserWithOptionsAsync(request, runtime);
        }

        public GrantUserPointResponse GrantUserPointWithOptions(GrantUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantUserPointShrinkRequest request = new GrantUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantUserPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantUserPointResponse> GrantUserPointWithOptionsAsync(GrantUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantUserPointShrinkRequest request = new GrantUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantUserPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantUserPointResponse GrantUserPoint(GrantUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantUserPointWithOptions(request, runtime);
        }

        public async Task<GrantUserPointResponse> GrantUserPointAsync(GrantUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantUserPointWithOptionsAsync(request, runtime);
        }

        public InitApplyRefundResponse InitApplyRefundWithOptions(InitApplyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                query["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                query["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitApplyRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitApplyRefundResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitApplyRefundResponse> InitApplyRefundWithOptionsAsync(InitApplyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                query["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                query["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitApplyRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitApplyRefundResponse>(await CallApiAsync(params_, req, runtime));
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

        public InitApplyRefundWithDesignatedTbUidResponse InitApplyRefundWithDesignatedTbUidWithOptions(InitApplyRefundWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCode))
            {
                body["RefundCode"] = request.RefundCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitApplyRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitApplyRefundWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitApplyRefundWithDesignatedTbUidResponse> InitApplyRefundWithDesignatedTbUidWithOptionsAsync(InitApplyRefundWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCode))
            {
                body["RefundCode"] = request.RefundCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitApplyRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitApplyRefundWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitApplyRefundWithDesignatedTbUidResponse InitApplyRefundWithDesignatedTbUid(InitApplyRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitApplyRefundWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<InitApplyRefundWithDesignatedTbUidResponse> InitApplyRefundWithDesignatedTbUidAsync(InitApplyRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitApplyRefundWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public InitModifyRefundResponse InitModifyRefundWithOptions(InitModifyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                query["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                query["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                query["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitModifyRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitModifyRefundResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitModifyRefundResponse> InitModifyRefundWithOptionsAsync(InitModifyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                query["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                query["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                query["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitModifyRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitModifyRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitModifyRefundResponse InitModifyRefund(InitModifyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitModifyRefundWithOptions(request, runtime);
        }

        public async Task<InitModifyRefundResponse> InitModifyRefundAsync(InitModifyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitModifyRefundWithOptionsAsync(request, runtime);
        }

        public InitModifyRefundWithDesignatedTbUidResponse InitModifyRefundWithDesignatedTbUidWithOptions(InitModifyRefundWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCode))
            {
                body["RefundCode"] = request.RefundCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitModifyRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitModifyRefundWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitModifyRefundWithDesignatedTbUidResponse> InitModifyRefundWithDesignatedTbUidWithOptionsAsync(InitModifyRefundWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCode))
            {
                body["RefundCode"] = request.RefundCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitModifyRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitModifyRefundWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitModifyRefundWithDesignatedTbUidResponse InitModifyRefundWithDesignatedTbUid(InitModifyRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitModifyRefundWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<InitModifyRefundWithDesignatedTbUidResponse> InitModifyRefundWithDesignatedTbUidAsync(InitModifyRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitModifyRefundWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public ListActivityAtmosphereResponse ListActivityAtmosphereWithOptions(ListActivityAtmosphereRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListActivityAtmosphere",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListActivityAtmosphereResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListActivityAtmosphereResponse> ListActivityAtmosphereWithOptionsAsync(ListActivityAtmosphereRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListActivityAtmosphere",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListActivityAtmosphereResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListActivityAtmosphereResponse ListActivityAtmosphere(ListActivityAtmosphereRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListActivityAtmosphereWithOptions(request, runtime);
        }

        public async Task<ListActivityAtmosphereResponse> ListActivityAtmosphereAsync(ListActivityAtmosphereRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListActivityAtmosphereWithOptionsAsync(request, runtime);
        }

        public ListActivityGameInfoResponse ListActivityGameInfoWithOptions(ListActivityGameInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListActivityGameInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListActivityGameInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListActivityGameInfoResponse> ListActivityGameInfoWithOptionsAsync(ListActivityGameInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListActivityGameInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListActivityGameInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListActivityGameInfoResponse ListActivityGameInfo(ListActivityGameInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListActivityGameInfoWithOptions(request, runtime);
        }

        public async Task<ListActivityGameInfoResponse> ListActivityGameInfoAsync(ListActivityGameInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListActivityGameInfoWithOptionsAsync(request, runtime);
        }

        public ListItemActivitiesResponse ListItemActivitiesWithOptions(ListItemActivitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListItemActivitiesShrinkRequest request = new ListItemActivitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListItemActivities",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListItemActivitiesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListItemActivitiesResponse> ListItemActivitiesWithOptionsAsync(ListItemActivitiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListItemActivitiesShrinkRequest request = new ListItemActivitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListItemActivities",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListItemActivitiesResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListUserGameProcessResponse ListUserGameProcessWithOptions(ListUserGameProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGameProcess",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGameProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserGameProcessResponse> ListUserGameProcessWithOptionsAsync(ListUserGameProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGameProcess",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGameProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserGameProcessResponse ListUserGameProcess(ListUserGameProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGameProcessWithOptions(request, runtime);
        }

        public async Task<ListUserGameProcessResponse> ListUserGameProcessAsync(ListUserGameProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGameProcessWithOptionsAsync(request, runtime);
        }

        public ListUserPointRecordsResponse ListUserPointRecordsWithOptions(ListUserPointRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPointRecords",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPointRecordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserPointRecordsResponse> ListUserPointRecordsWithOptionsAsync(ListUserPointRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPointRecords",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPointRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserPointRecordsResponse ListUserPointRecords(ListUserPointRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserPointRecordsWithOptions(request, runtime);
        }

        public async Task<ListUserPointRecordsResponse> ListUserPointRecordsAsync(ListUserPointRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserPointRecordsWithOptionsAsync(request, runtime);
        }

        public ModifyBasicAndBizItemsResponse ModifyBasicAndBizItemsWithOptions(ModifyBasicAndBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                body["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBasicAndBizItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBasicAndBizItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyBasicAndBizItemsResponse> ModifyBasicAndBizItemsWithOptionsAsync(ModifyBasicAndBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                body["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBasicAndBizItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBasicAndBizItemsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ModifyBasicItemSupplierPriceResponse ModifyBasicItemSupplierPriceWithOptions(ModifyBasicItemSupplierPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                query["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                query["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierPrice))
            {
                query["SupplierPrice"] = request.SupplierPrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBasicItemSupplierPrice",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBasicItemSupplierPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyBasicItemSupplierPriceResponse> ModifyBasicItemSupplierPriceWithOptionsAsync(ModifyBasicItemSupplierPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                query["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                query["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierPrice))
            {
                query["SupplierPrice"] = request.SupplierPrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBasicItemSupplierPrice",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBasicItemSupplierPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyBasicItemSupplierPriceResponse ModifyBasicItemSupplierPrice(ModifyBasicItemSupplierPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBasicItemSupplierPriceWithOptions(request, runtime);
        }

        public async Task<ModifyBasicItemSupplierPriceResponse> ModifyBasicItemSupplierPriceAsync(ModifyBasicItemSupplierPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBasicItemSupplierPriceWithOptionsAsync(request, runtime);
        }

        public ModifyBizItemsResponse ModifyBizItemsWithOptions(ModifyBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                body["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBizItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBizItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyBizItemsResponse> ModifyBizItemsWithOptionsAsync(ModifyBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                body["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBizItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBizItemsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmActivityId))
            {
                query["LmActivityId"] = request.LmActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizCode))
            {
                query["SubBizCode"] = request.SubBizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperNum))
            {
                query["UpperNum"] = request.UpperNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyItemLimitRule",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyItemLimitRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyItemLimitRuleResponse> ModifyItemLimitRuleWithOptionsAsync(ModifyItemLimitRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmActivityId))
            {
                query["LmActivityId"] = request.LmActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizCode))
            {
                query["SubBizCode"] = request.SubBizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpperNum))
            {
                query["UpperNum"] = request.UpperNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyItemLimitRule",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyItemLimitRuleResponse>(await CallApiAsync(params_, req, runtime));
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

        public ModifyOrderDeliveryAddressResponse ModifyOrderDeliveryAddressWithOptions(ModifyOrderDeliveryAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOrderDeliveryAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOrderDeliveryAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyOrderDeliveryAddressResponse> ModifyOrderDeliveryAddressWithOptionsAsync(ModifyOrderDeliveryAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOrderDeliveryAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOrderDeliveryAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyOrderDeliveryAddressResponse ModifyOrderDeliveryAddress(ModifyOrderDeliveryAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOrderDeliveryAddressWithOptions(request, runtime);
        }

        public async Task<ModifyOrderDeliveryAddressResponse> ModifyOrderDeliveryAddressAsync(ModifyOrderDeliveryAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOrderDeliveryAddressWithOptionsAsync(request, runtime);
        }

        public ModifyRefundResponse ModifyRefundWithOptions(ModifyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReasonTextId))
            {
                query["ApplyReasonTextId"] = request.ApplyReasonTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundCount))
            {
                query["ApplyRefundCount"] = request.ApplyRefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundFee))
            {
                query["ApplyRefundFee"] = request.ApplyRefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                query["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                query["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                query["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveMessage))
            {
                body["LeaveMessage"] = request.LeaveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeavePictureList))
            {
                body["LeavePictureList"] = request.LeavePictureList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRefundResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyRefundResponse> ModifyRefundWithOptionsAsync(ModifyRefundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReasonTextId))
            {
                query["ApplyReasonTextId"] = request.ApplyReasonTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundCount))
            {
                query["ApplyRefundCount"] = request.ApplyRefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundFee))
            {
                query["ApplyRefundFee"] = request.ApplyRefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                query["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                query["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                query["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveMessage))
            {
                body["LeaveMessage"] = request.LeaveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeavePictureList))
            {
                body["LeavePictureList"] = request.LeavePictureList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRefund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyRefundResponse ModifyRefund(ModifyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRefundWithOptions(request, runtime);
        }

        public async Task<ModifyRefundResponse> ModifyRefundAsync(ModifyRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRefundWithOptionsAsync(request, runtime);
        }

        public ModifyRefundWithDesignatedTbUidResponse ModifyRefundWithDesignatedTbUidWithOptions(ModifyRefundWithDesignatedTbUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyRefundWithDesignatedTbUidShrinkRequest request = new ModifyRefundWithDesignatedTbUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Proofs))
            {
                request.ProofsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Proofs, "Proofs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProofsShrink))
            {
                body["Proofs"] = request.ProofsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonId))
            {
                body["ReasonId"] = request.ReasonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCode))
            {
                body["RefundCode"] = request.RefundCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCount))
            {
                body["RefundCount"] = request.RefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundFee))
            {
                body["RefundFee"] = request.RefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRefundWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyRefundWithDesignatedTbUidResponse> ModifyRefundWithDesignatedTbUidWithOptionsAsync(ModifyRefundWithDesignatedTbUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyRefundWithDesignatedTbUidShrinkRequest request = new ModifyRefundWithDesignatedTbUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Proofs))
            {
                request.ProofsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Proofs, "Proofs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProofsShrink))
            {
                body["Proofs"] = request.ProofsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasonId))
            {
                body["ReasonId"] = request.ReasonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCode))
            {
                body["RefundCode"] = request.RefundCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundCount))
            {
                body["RefundCount"] = request.RefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundFee))
            {
                body["RefundFee"] = request.RefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRefundWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRefundWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyRefundWithDesignatedTbUidResponse ModifyRefundWithDesignatedTbUid(ModifyRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRefundWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<ModifyRefundWithDesignatedTbUidResponse> ModifyRefundWithDesignatedTbUidAsync(ModifyRefundWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRefundWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public ModifySettleAccountResponse ModifySettleAccountWithOptions(ModifySettleAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountChannel))
            {
                body["AccountChannel"] = request.AccountChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPayType))
            {
                body["AccountPayType"] = request.AccountPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryOrAreaCode))
            {
                body["CountryOrAreaCode"] = request.CountryOrAreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                body["IdempotentId"] = request.IdempotentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySettleAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySettleAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySettleAccountResponse> ModifySettleAccountWithOptionsAsync(ModifySettleAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountChannel))
            {
                body["AccountChannel"] = request.AccountChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPayType))
            {
                body["AccountPayType"] = request.AccountPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryOrAreaCode))
            {
                body["CountryOrAreaCode"] = request.CountryOrAreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                body["IdempotentId"] = request.IdempotentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySettleAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySettleAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySettleAccountResponse ModifySettleAccount(ModifySettleAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySettleAccountWithOptions(request, runtime);
        }

        public async Task<ModifySettleAccountResponse> ModifySettleAccountAsync(ModifySettleAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySettleAccountWithOptionsAsync(request, runtime);
        }

        public ModifySupplierPriceAndPriceCentResponse ModifySupplierPriceAndPriceCentWithOptions(ModifySupplierPriceAndPriceCentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                query["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceCent))
            {
                query["PriceCent"] = request.PriceCent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                query["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierPrice))
            {
                query["SupplierPrice"] = request.SupplierPrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySupplierPriceAndPriceCent",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySupplierPriceAndPriceCentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySupplierPriceAndPriceCentResponse> ModifySupplierPriceAndPriceCentWithOptionsAsync(ModifySupplierPriceAndPriceCentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                query["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceCent))
            {
                query["PriceCent"] = request.PriceCent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                query["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierPrice))
            {
                query["SupplierPrice"] = request.SupplierPrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySupplierPriceAndPriceCent",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySupplierPriceAndPriceCentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySupplierPriceAndPriceCentResponse ModifySupplierPriceAndPriceCent(ModifySupplierPriceAndPriceCentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySupplierPriceAndPriceCentWithOptions(request, runtime);
        }

        public async Task<ModifySupplierPriceAndPriceCentResponse> ModifySupplierPriceAndPriceCentAsync(ModifySupplierPriceAndPriceCentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySupplierPriceAndPriceCentWithOptionsAsync(request, runtime);
        }

        public NotifyPayOrderStatusResponse NotifyPayOrderStatusWithOptions(NotifyPayOrderStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDate))
            {
                query["OperationDate"] = request.OperationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayTypes))
            {
                query["PayTypes"] = request.PayTypes;
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
                Action = "NotifyPayOrderStatus",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyPayOrderStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<NotifyPayOrderStatusResponse> NotifyPayOrderStatusWithOptionsAsync(NotifyPayOrderStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDate))
            {
                query["OperationDate"] = request.OperationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayTypes))
            {
                query["PayTypes"] = request.PayTypes;
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
                Action = "NotifyPayOrderStatus",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyPayOrderStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDate))
            {
                query["OperationDate"] = request.OperationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayTypes))
            {
                query["PayTypes"] = request.PayTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantOrderId))
            {
                query["TenantOrderId"] = request.TenantOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NotifyWithholdFund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyWithholdFundResponse>(CallApi(params_, req, runtime));
        }

        public async Task<NotifyWithholdFundResponse> NotifyWithholdFundWithOptionsAsync(NotifyWithholdFundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDate))
            {
                query["OperationDate"] = request.OperationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayTypes))
            {
                query["PayTypes"] = request.PayTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantOrderId))
            {
                query["TenantOrderId"] = request.TenantOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NotifyWithholdFund",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyWithholdFundResponse>(await CallApiAsync(params_, req, runtime));
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

        public OpenRealTbAccountSupportResponse OpenRealTbAccountSupportWithOptions(OpenRealTbAccountSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenRealTbAccountSupport",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenRealTbAccountSupportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenRealTbAccountSupportResponse> OpenRealTbAccountSupportWithOptionsAsync(OpenRealTbAccountSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenRealTbAccountSupport",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenRealTbAccountSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenRealTbAccountSupportResponse OpenRealTbAccountSupport(OpenRealTbAccountSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenRealTbAccountSupportWithOptions(request, runtime);
        }

        public async Task<OpenRealTbAccountSupportResponse> OpenRealTbAccountSupportAsync(OpenRealTbAccountSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenRealTbAccountSupportWithOptionsAsync(request, runtime);
        }

        public PushUserGameProcessResponse PushUserGameProcessWithOptions(PushUserGameProcessRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushUserGameProcessShrinkRequest request = new PushUserGameProcessShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentStepId))
            {
                query["CurrentStepId"] = request.CurrentStepId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                query["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushUserGameProcess",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushUserGameProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushUserGameProcessResponse> PushUserGameProcessWithOptionsAsync(PushUserGameProcessRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushUserGameProcessShrinkRequest request = new PushUserGameProcessShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentStepId))
            {
                query["CurrentStepId"] = request.CurrentStepId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                query["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushUserGameProcess",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushUserGameProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushUserGameProcessResponse PushUserGameProcess(PushUserGameProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushUserGameProcessWithOptions(request, runtime);
        }

        public async Task<PushUserGameProcessResponse> PushUserGameProcessAsync(PushUserGameProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushUserGameProcessWithOptionsAsync(request, runtime);
        }

        public QueryActivityItemsResponse QueryActivityItemsWithOptions(QueryActivityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmActivityId))
            {
                query["LmActivityId"] = request.LmActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "QueryActivityItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActivityItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryActivityItemsResponse> QueryActivityItemsWithOptionsAsync(QueryActivityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmActivityId))
            {
                query["LmActivityId"] = request.LmActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "QueryActivityItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActivityItemsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAddressResponse> QueryAddressWithOptionsAsync(QueryAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAddressResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressInfo))
            {
                query["AddressInfo"] = request.AddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAddressDetail",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAddressDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAddressDetailResponse> QueryAddressDetailWithOptionsAsync(QueryAddressDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressInfo))
            {
                query["AddressInfo"] = request.AddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAddressDetail",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAddressDetailResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAddressList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAddressListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAddressListResponse> QueryAddressListWithOptionsAsync(QueryAddressListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAddressList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAddressListResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryAdvertisementSettleInfoResponse QueryAdvertisementSettleInfoWithOptions(QueryAdvertisementSettleInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaSettleDetailId))
            {
                query["MediaSettleDetailId"] = request.MediaSettleDetailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleNo))
            {
                query["SettleNo"] = request.SettleNo;
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
                Action = "QueryAdvertisementSettleInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAdvertisementSettleInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAdvertisementSettleInfoResponse> QueryAdvertisementSettleInfoWithOptionsAsync(QueryAdvertisementSettleInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaSettleDetailId))
            {
                query["MediaSettleDetailId"] = request.MediaSettleDetailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleNo))
            {
                query["SettleNo"] = request.SettleNo;
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
                Action = "QueryAdvertisementSettleInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAdvertisementSettleInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryAdvertisementSettleInfoResponse QueryAdvertisementSettleInfo(QueryAdvertisementSettleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAdvertisementSettleInfoWithOptions(request, runtime);
        }

        public async Task<QueryAdvertisementSettleInfoResponse> QueryAdvertisementSettleInfoAsync(QueryAdvertisementSettleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAdvertisementSettleInfoWithOptionsAsync(request, runtime);
        }

        public QueryAgreementResponse QueryAgreementWithOptions(QueryAgreementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementNo))
            {
                body["AgreementNo"] = request.AgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalAgreementNo))
            {
                body["ExternalAgreementNo"] = request.ExternalAgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAgreement",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAgreementResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAgreementResponse> QueryAgreementWithOptionsAsync(QueryAgreementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementNo))
            {
                body["AgreementNo"] = request.AgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalAgreementNo))
            {
                body["ExternalAgreementNo"] = request.ExternalAgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAgreement",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAgreementResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAllCinemas",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllCinemasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAllCinemasResponse> QueryAllCinemasWithOptionsAsync(QueryAllCinemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAllCinemas",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllCinemasResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJsonShrink))
            {
                query["ExtJson"] = request.ExtJsonShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAllCities",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllCitiesResponse>(CallApi(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJsonShrink))
            {
                query["ExtJson"] = request.ExtJsonShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAllCities",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllCitiesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBatchRegistAnonymousTbAccountResult",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchRegistAnonymousTbAccountResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBatchRegistAnonymousTbAccountResultResponse> QueryBatchRegistAnonymousTbAccountResultWithOptionsAsync(QueryBatchRegistAnonymousTbAccountResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBatchRegistAnonymousTbAccountResult",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchRegistAnonymousTbAccountResultResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBestSession4Items",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBestSession4ItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBestSession4ItemsResponse> QueryBestSession4ItemsWithOptionsAsync(QueryBestSession4ItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBestSession4ItemsShrinkRequest request = new QueryBestSession4ItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBestSession4Items",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBestSession4ItemsResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
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
                Action = "QueryBizItemList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBizItemListResponse> QueryBizItemListWithOptionsAsync(QueryBizItemListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemListShrinkRequest request = new QueryBizItemListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
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
                Action = "QueryBizItemList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemListResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryBizItemListV2Response QueryBizItemListV2WithOptions(QueryBizItemListV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemListV2ShrinkRequest request = new QueryBizItemListV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
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
                Action = "QueryBizItemListV2",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemListV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBizItemListV2Response> QueryBizItemListV2WithOptionsAsync(QueryBizItemListV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemListV2ShrinkRequest request = new QueryBizItemListV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
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
                Action = "QueryBizItemListV2",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemListV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public QueryBizItemListV2Response QueryBizItemListV2(QueryBizItemListV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBizItemListV2WithOptions(request, runtime);
        }

        public async Task<QueryBizItemListV2Response> QueryBizItemListV2Async(QueryBizItemListV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBizItemListV2WithOptionsAsync(request, runtime);
        }

        public QueryBizItemListWithCacheResponse QueryBizItemListWithCacheWithOptions(QueryBizItemListWithCacheRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemListWithCacheShrinkRequest request = new QueryBizItemListWithCacheShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBizItemListWithCache",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemListWithCacheResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBizItemListWithCacheResponse> QueryBizItemListWithCacheWithOptionsAsync(QueryBizItemListWithCacheRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemListWithCacheShrinkRequest request = new QueryBizItemListWithCacheShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBizItemListWithCache",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemListWithCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryBizItemListWithCacheResponse QueryBizItemListWithCache(QueryBizItemListWithCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBizItemListWithCacheWithOptions(request, runtime);
        }

        public async Task<QueryBizItemListWithCacheResponse> QueryBizItemListWithCacheAsync(QueryBizItemListWithCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBizItemListWithCacheWithOptionsAsync(request, runtime);
        }

        public QueryBizItemsResponse QueryBizItemsWithOptions(QueryBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
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
                Action = "QueryBizItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBizItemsResponse> QueryBizItemsWithOptionsAsync(QueryBizItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
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
                Action = "QueryBizItems",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemsResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBizItemsWithActivity",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemsWithActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBizItemsWithActivityResponse> QueryBizItemsWithActivityWithOptionsAsync(QueryBizItemsWithActivityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBizItemsWithActivityShrinkRequest request = new QueryBizItemsWithActivityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBizItemsWithActivity",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizItemsWithActivityResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryBudgetTicketItemListByBizIdResponse QueryBudgetTicketItemListByBizIdWithOptions(QueryBudgetTicketItemListByBizIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetTicketNo))
            {
                query["BudgetTicketNo"] = request.BudgetTicketNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "QueryBudgetTicketItemListByBizId",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBudgetTicketItemListByBizIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBudgetTicketItemListByBizIdResponse> QueryBudgetTicketItemListByBizIdWithOptionsAsync(QueryBudgetTicketItemListByBizIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BudgetTicketNo))
            {
                query["BudgetTicketNo"] = request.BudgetTicketNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "QueryBudgetTicketItemListByBizId",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBudgetTicketItemListByBizIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryBudgetTicketItemListByBizIdResponse QueryBudgetTicketItemListByBizId(QueryBudgetTicketItemListByBizIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBudgetTicketItemListByBizIdWithOptions(request, runtime);
        }

        public async Task<QueryBudgetTicketItemListByBizIdResponse> QueryBudgetTicketItemListByBizIdAsync(QueryBudgetTicketItemListByBizIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBudgetTicketItemListByBizIdWithOptionsAsync(request, runtime);
        }

        public QueryChannelItemBillDownloadUrlResponse QueryChannelItemBillDownloadUrlWithOptions(QueryChannelItemBillDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                body["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillPeriod))
            {
                body["BillPeriod"] = request.BillPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillStatus))
            {
                body["BillStatus"] = request.BillStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                body["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopName))
            {
                body["LmShopName"] = request.LmShopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChannelItemBillDownloadUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChannelItemBillDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryChannelItemBillDownloadUrlResponse> QueryChannelItemBillDownloadUrlWithOptionsAsync(QueryChannelItemBillDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                body["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillPeriod))
            {
                body["BillPeriod"] = request.BillPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillStatus))
            {
                body["BillStatus"] = request.BillStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                body["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopName))
            {
                body["LmShopName"] = request.LmShopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChannelItemBillDownloadUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChannelItemBillDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryChannelItemBillDownloadUrlResponse QueryChannelItemBillDownloadUrl(QueryChannelItemBillDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChannelItemBillDownloadUrlWithOptions(request, runtime);
        }

        public async Task<QueryChannelItemBillDownloadUrlResponse> QueryChannelItemBillDownloadUrlAsync(QueryChannelItemBillDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChannelItemBillDownloadUrlWithOptionsAsync(request, runtime);
        }

        public QueryGuideItemGroupResponse QueryGuideItemGroupWithOptions(QueryGuideItemGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemState))
            {
                query["ItemState"] = request.ItemState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "QueryGuideItemGroup",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGuideItemGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryGuideItemGroupResponse> QueryGuideItemGroupWithOptionsAsync(QueryGuideItemGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemState))
            {
                query["ItemState"] = request.ItemState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "QueryGuideItemGroup",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGuideItemGroupResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryGuideItemGroupForCrowdOperationResponse QueryGuideItemGroupForCrowdOperationWithOptions(QueryGuideItemGroupForCrowdOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemState))
            {
                query["ItemState"] = request.ItemState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFlag))
            {
                query["UserFlag"] = request.UserFlag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGuideItemGroupForCrowdOperation",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGuideItemGroupForCrowdOperationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryGuideItemGroupForCrowdOperationResponse> QueryGuideItemGroupForCrowdOperationWithOptionsAsync(QueryGuideItemGroupForCrowdOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemState))
            {
                query["ItemState"] = request.ItemState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFlag))
            {
                query["UserFlag"] = request.UserFlag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGuideItemGroupForCrowdOperation",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGuideItemGroupForCrowdOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryGuideItemGroupForCrowdOperationResponse QueryGuideItemGroupForCrowdOperation(QueryGuideItemGroupForCrowdOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryGuideItemGroupForCrowdOperationWithOptions(request, runtime);
        }

        public async Task<QueryGuideItemGroupForCrowdOperationResponse> QueryGuideItemGroupForCrowdOperationAsync(QueryGuideItemGroupForCrowdOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryGuideItemGroupForCrowdOperationWithOptionsAsync(request, runtime);
        }

        public QueryGuideItemGroupWithOutInventoryResponse QueryGuideItemGroupWithOutInventoryWithOptions(QueryGuideItemGroupWithOutInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGuideItemGroupWithOutInventory",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGuideItemGroupWithOutInventoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryGuideItemGroupWithOutInventoryResponse> QueryGuideItemGroupWithOutInventoryWithOptionsAsync(QueryGuideItemGroupWithOutInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGuideItemGroupWithOutInventory",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGuideItemGroupWithOutInventoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryGuideItemGroupWithOutInventoryResponse QueryGuideItemGroupWithOutInventory(QueryGuideItemGroupWithOutInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryGuideItemGroupWithOutInventoryWithOptions(request, runtime);
        }

        public async Task<QueryGuideItemGroupWithOutInventoryResponse> QueryGuideItemGroupWithOutInventoryAsync(QueryGuideItemGroupWithOutInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryGuideItemGroupWithOutInventoryWithOptionsAsync(request, runtime);
        }

        public QueryHotMoviesResponse QueryHotMoviesWithOptions(QueryHotMoviesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotMovies",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotMoviesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryHotMoviesResponse> QueryHotMoviesWithOptionsAsync(QueryHotMoviesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHotMovies",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHotMoviesResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryInventoryOfItemsInBizItemGroupResponse QueryInventoryOfItemsInBizItemGroupWithOptions(QueryInventoryOfItemsInBizItemGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryInventoryOfItemsInBizItemGroupShrinkRequest request = new QueryInventoryOfItemsInBizItemGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInventoryOfItemsInBizItemGroup",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInventoryOfItemsInBizItemGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryInventoryOfItemsInBizItemGroupResponse> QueryInventoryOfItemsInBizItemGroupWithOptionsAsync(QueryInventoryOfItemsInBizItemGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryInventoryOfItemsInBizItemGroupShrinkRequest request = new QueryInventoryOfItemsInBizItemGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInventoryOfItemsInBizItemGroup",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInventoryOfItemsInBizItemGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryInventoryOfItemsInBizItemGroupResponse QueryInventoryOfItemsInBizItemGroup(QueryInventoryOfItemsInBizItemGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInventoryOfItemsInBizItemGroupWithOptions(request, runtime);
        }

        public async Task<QueryInventoryOfItemsInBizItemGroupResponse> QueryInventoryOfItemsInBizItemGroupAsync(QueryInventoryOfItemsInBizItemGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInventoryOfItemsInBizItemGroupWithOptionsAsync(request, runtime);
        }

        public QueryItemDetailResponse QueryItemDetailWithOptions(QueryItemDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemDetail",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemDetailResponse> QueryItemDetailWithOptionsAsync(QueryItemDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemDetail",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemDetailResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemDetailInner",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemDetailInnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemDetailInnerResponse> QueryItemDetailInnerWithOptionsAsync(QueryItemDetailInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemDetailInner",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemDetailInnerResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryItemDetailTeaResponse QueryItemDetailTeaWithOptions(QueryItemDetailTeaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemDetailTea",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemDetailTeaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemDetailTeaResponse> QueryItemDetailTeaWithOptionsAsync(QueryItemDetailTeaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemDetailTea",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemDetailTeaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryItemDetailTeaResponse QueryItemDetailTea(QueryItemDetailTeaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemDetailTeaWithOptions(request, runtime);
        }

        public async Task<QueryItemDetailTeaResponse> QueryItemDetailTeaAsync(QueryItemDetailTeaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemDetailTeaWithOptionsAsync(request, runtime);
        }

        public QueryItemInSubBizsResponse QueryItemInSubBizsWithOptions(QueryItemInSubBizsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryItemInSubBizsShrinkRequest request = new QueryItemInSubBizsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubBizIds))
            {
                request.SubBizIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubBizIds, "SubBizIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemInSubBizs",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemInSubBizsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemInSubBizsResponse> QueryItemInSubBizsWithOptionsAsync(QueryItemInSubBizsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryItemInSubBizsShrinkRequest request = new QueryItemInSubBizsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubBizIds))
            {
                request.SubBizIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubBizIds, "SubBizIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemInSubBizs",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemInSubBizsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryItemInSubBizsResponse QueryItemInSubBizs(QueryItemInSubBizsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemInSubBizsWithOptions(request, runtime);
        }

        public async Task<QueryItemInSubBizsResponse> QueryItemInSubBizsAsync(QueryItemInSubBizsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemInSubBizsWithOptionsAsync(request, runtime);
        }

        public QueryItemInventoryResponse QueryItemInventoryWithOptions(QueryItemInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemInventory",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemInventoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemInventoryResponse> QueryItemInventoryWithOptionsAsync(QueryItemInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemInventory",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemInventoryResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryItemInventoryV2Response QueryItemInventoryV2WithOptions(QueryItemInventoryV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemInventoryV2",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemInventoryV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemInventoryV2Response> QueryItemInventoryV2WithOptionsAsync(QueryItemInventoryV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                query["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemInventoryV2",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemInventoryV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public QueryItemInventoryV2Response QueryItemInventoryV2(QueryItemInventoryV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemInventoryV2WithOptions(request, runtime);
        }

        public async Task<QueryItemInventoryV2Response> QueryItemInventoryV2Async(QueryItemInventoryV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemInventoryV2WithOptionsAsync(request, runtime);
        }

        public QueryItemNextCycleRestrictionResponse QueryItemNextCycleRestrictionWithOptions(QueryItemNextCycleRestrictionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryItemNextCycleRestrictionShrinkRequest request = new QueryItemNextCycleRestrictionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemId))
            {
                request.LmItemIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemId, "LmItemId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdShrink))
            {
                body["LmItemId"] = request.LmItemIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemNextCycleRestriction",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemNextCycleRestrictionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemNextCycleRestrictionResponse> QueryItemNextCycleRestrictionWithOptionsAsync(QueryItemNextCycleRestrictionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryItemNextCycleRestrictionShrinkRequest request = new QueryItemNextCycleRestrictionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemId))
            {
                request.LmItemIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemId, "LmItemId", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizId))
            {
                query["SubBizId"] = request.SubBizId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdShrink))
            {
                body["LmItemId"] = request.LmItemIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryItemNextCycleRestriction",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemNextCycleRestrictionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryItemNextCycleRestrictionResponse QueryItemNextCycleRestriction(QueryItemNextCycleRestrictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemNextCycleRestrictionWithOptions(request, runtime);
        }

        public async Task<QueryItemNextCycleRestrictionResponse> QueryItemNextCycleRestrictionAsync(QueryItemNextCycleRestrictionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemNextCycleRestrictionWithOptionsAsync(request, runtime);
        }

        public QueryLogisticsResponse QueryLogisticsWithOptions(QueryLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLogistics",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLogisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLogisticsResponse> QueryLogisticsWithOptionsAsync(QueryLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLogistics",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLogisticsResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryMediaSettleInfoResponse QueryMediaSettleInfoWithOptions(QueryMediaSettleInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaName))
            {
                query["MediaName"] = request.MediaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleNo))
            {
                query["SettleNo"] = request.SettleNo;
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
                Action = "QueryMediaSettleInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaSettleInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMediaSettleInfoResponse> QueryMediaSettleInfoWithOptionsAsync(QueryMediaSettleInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaName))
            {
                query["MediaName"] = request.MediaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleNo))
            {
                query["SettleNo"] = request.SettleNo;
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
                Action = "QueryMediaSettleInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaSettleInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMediaSettleInfoResponse QueryMediaSettleInfo(QueryMediaSettleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaSettleInfoWithOptions(request, runtime);
        }

        public async Task<QueryMediaSettleInfoResponse> QueryMediaSettleInfoAsync(QueryMediaSettleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaSettleInfoWithOptionsAsync(request, runtime);
        }

        public QueryMessagesResponse QueryMessagesWithOptions(QueryMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMessages",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMessagesResponse> QueryMessagesWithOptionsAsync(QueryMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMessages",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessagesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MovieId))
            {
                query["MovieId"] = request.MovieId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMovieComments",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMovieCommentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMovieCommentsResponse> QueryMovieCommentsWithOptionsAsync(QueryMovieCommentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MovieId))
            {
                query["MovieId"] = request.MovieId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMovieComments",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMovieCommentsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CinemaId))
            {
                query["CinemaId"] = request.CinemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMovieSchedules",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMovieSchedulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMovieSchedulesResponse> QueryMovieSchedulesWithOptionsAsync(QueryMovieSchedulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CinemaId))
            {
                query["CinemaId"] = request.CinemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMovieSchedules",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMovieSchedulesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleId))
            {
                query["ScheduleId"] = request.ScheduleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMovieSeats",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMovieSeatsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMovieSeatsResponse> QueryMovieSeatsWithOptionsAsync(QueryMovieSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleId))
            {
                query["ScheduleId"] = request.ScheduleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMovieSeats",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMovieSeatsResponse>(await CallApiAsync(params_, req, runtime));
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMovieTickets",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMovieTicketsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMovieTicketsResponse> QueryMovieTicketsWithOptionsAsync(QueryMovieTicketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMovieTickets",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMovieTicketsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                query["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderAndPaymentList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderAndPaymentListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderAndPaymentListResponse> QueryOrderAndPaymentListWithOptionsAsync(QueryOrderAndPaymentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                query["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderAndPaymentList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderAndPaymentListResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryOrderAndPaymentListWithDesignatedTbUidResponse QueryOrderAndPaymentListWithDesignatedTbUidWithOptions(QueryOrderAndPaymentListWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                body["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderAndPaymentListWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderAndPaymentListWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderAndPaymentListWithDesignatedTbUidResponse> QueryOrderAndPaymentListWithDesignatedTbUidWithOptionsAsync(QueryOrderAndPaymentListWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                body["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderAndPaymentListWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderAndPaymentListWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOrderAndPaymentListWithDesignatedTbUidResponse QueryOrderAndPaymentListWithDesignatedTbUid(QueryOrderAndPaymentListWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderAndPaymentListWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<QueryOrderAndPaymentListWithDesignatedTbUidResponse> QueryOrderAndPaymentListWithDesignatedTbUidAsync(QueryOrderAndPaymentListWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderAndPaymentListWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public QueryOrderCommissionRateResponse QueryOrderCommissionRateWithOptions(QueryOrderCommissionRateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderCommissionRate",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderCommissionRateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderCommissionRateResponse> QueryOrderCommissionRateWithOptionsAsync(QueryOrderCommissionRateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderCommissionRate",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderCommissionRateResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                query["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderDetailInner",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderDetailInnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderDetailInnerResponse> QueryOrderDetailInnerWithOptionsAsync(QueryOrderDetailInnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                query["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderDetailInner",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderDetailInnerResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentId))
            {
                query["PaymentId"] = request.PaymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderIdByPayId",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderIdByPayIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderIdByPayIdResponse> QueryOrderIdByPayIdWithOptionsAsync(QueryOrderIdByPayIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentId))
            {
                query["PaymentId"] = request.PaymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderIdByPayId",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderIdByPayIdResponse>(await CallApiAsync(params_, req, runtime));
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderInfoAfterSale",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderInfoAfterSaleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderInfoAfterSaleResponse> QueryOrderInfoAfterSaleWithOptionsAsync(QueryOrderInfoAfterSaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderInfoAfterSale",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderInfoAfterSaleResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentId))
            {
                query["PaymentId"] = request.PaymentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderItemInfoByPaymentIdForAiZhanYou",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse> QueryOrderItemInfoByPaymentIdForAiZhanYouWithOptionsAsync(QueryOrderItemInfoByPaymentIdForAiZhanYouRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentId))
            {
                query["PaymentId"] = request.PaymentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderItemInfoByPaymentIdForAiZhanYou",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderItemInfoByPaymentIdForAiZhanYouResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                query["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderListResponse> QueryOrderListWithOptionsAsync(QueryOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                query["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderList",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderListResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryOrderListWithDesignatedTbUidResponse QueryOrderListWithDesignatedTbUidWithOptions(QueryOrderListWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                body["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderListWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderListWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderListWithDesignatedTbUidResponse> QueryOrderListWithDesignatedTbUidWithOptionsAsync(QueryOrderListWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOption))
            {
                body["FilterOption"] = request.FilterOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderListWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderListWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOrderListWithDesignatedTbUidResponse QueryOrderListWithDesignatedTbUid(QueryOrderListWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderListWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<QueryOrderListWithDesignatedTbUidResponse> QueryOrderListWithDesignatedTbUidAsync(QueryOrderListWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderListWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public QueryOrderLogisticsResponse QueryOrderLogisticsWithOptions(QueryOrderLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderLogistics",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderLogisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderLogisticsResponse> QueryOrderLogisticsWithOptionsAsync(QueryOrderLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderLogistics",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderLogisticsResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryOrderLogisticsWithDesignatedTbUidResponse QueryOrderLogisticsWithDesignatedTbUidWithOptions(QueryOrderLogisticsWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderLogisticsWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderLogisticsWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderLogisticsWithDesignatedTbUidResponse> QueryOrderLogisticsWithDesignatedTbUidWithOptionsAsync(QueryOrderLogisticsWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderLogisticsWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderLogisticsWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOrderLogisticsWithDesignatedTbUidResponse QueryOrderLogisticsWithDesignatedTbUid(QueryOrderLogisticsWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderLogisticsWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<QueryOrderLogisticsWithDesignatedTbUidResponse> QueryOrderLogisticsWithDesignatedTbUidAsync(QueryOrderLogisticsWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderLogisticsWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public QueryRealTbAccountSupportResponse QueryRealTbAccountSupportWithOptions(QueryRealTbAccountSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRealTbAccountSupport",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRealTbAccountSupportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRealTbAccountSupportResponse> QueryRealTbAccountSupportWithOptionsAsync(QueryRealTbAccountSupportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRealTbAccountSupport",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRealTbAccountSupportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRealTbAccountSupportResponse QueryRealTbAccountSupport(QueryRealTbAccountSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRealTbAccountSupportWithOptions(request, runtime);
        }

        public async Task<QueryRealTbAccountSupportResponse> QueryRealTbAccountSupportAsync(QueryRealTbAccountSupportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRealTbAccountSupportWithOptionsAsync(request, runtime);
        }

        public QueryRefundApplicationDetailResponse QueryRefundApplicationDetailWithOptions(QueryRefundApplicationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRefundApplicationDetail",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRefundApplicationDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRefundApplicationDetailResponse> QueryRefundApplicationDetailWithOptionsAsync(QueryRefundApplicationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRefundApplicationDetail",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRefundApplicationDetailResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryRefundApplyWithDesignatedTbUidResponse QueryRefundApplyWithDesignatedTbUidWithOptions(QueryRefundApplyWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRefundApplyWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRefundApplyWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRefundApplyWithDesignatedTbUidResponse> QueryRefundApplyWithDesignatedTbUidWithOptionsAsync(QueryRefundApplyWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRefundApplyWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRefundApplyWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRefundApplyWithDesignatedTbUidResponse QueryRefundApplyWithDesignatedTbUid(QueryRefundApplyWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRefundApplyWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<QueryRefundApplyWithDesignatedTbUidResponse> QueryRefundApplyWithDesignatedTbUidAsync(QueryRefundApplyWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRefundApplyWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public QuerySellerLicenseResponse QuerySellerLicenseWithOptions(QuerySellerLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySellerLicense",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySellerLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySellerLicenseResponse> QuerySellerLicenseWithOptionsAsync(QuerySellerLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                body["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySellerLicense",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySellerLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySellerLicenseResponse QuerySellerLicense(QuerySellerLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySellerLicenseWithOptions(request, runtime);
        }

        public async Task<QuerySellerLicenseResponse> QuerySellerLicenseAsync(QuerySellerLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySellerLicenseWithOptionsAsync(request, runtime);
        }

        public QueryStatementsResponse QueryStatementsWithOptions(QueryStatementsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayeeIds))
            {
                query["PayeeIds"] = request.PayeeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleNoes))
            {
                query["SettleNoes"] = request.SettleNoes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleStatus))
            {
                query["SettleStatus"] = request.SettleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleType))
            {
                query["SettleType"] = request.SettleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStatements",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStatementsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryStatementsResponse> QueryStatementsWithOptionsAsync(QueryStatementsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayeeIds))
            {
                query["PayeeIds"] = request.PayeeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleNoes))
            {
                query["SettleNoes"] = request.SettleNoes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleStatus))
            {
                query["SettleStatus"] = request.SettleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleType))
            {
                query["SettleType"] = request.SettleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStatements",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStatementsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryStatementsResponse QueryStatements(QueryStatementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStatementsWithOptions(request, runtime);
        }

        public async Task<QueryStatementsResponse> QueryStatementsAsync(QueryStatementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStatementsWithOptionsAsync(request, runtime);
        }

        public QuerySupplierItemBillDownloadUrlResponse QuerySupplierItemBillDownloadUrlWithOptions(QuerySupplierItemBillDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                body["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillPeriod))
            {
                body["BillPeriod"] = request.BillPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillStatus))
            {
                body["BillStatus"] = request.BillStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                body["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopName))
            {
                body["LmShopName"] = request.LmShopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySupplierItemBillDownloadUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySupplierItemBillDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySupplierItemBillDownloadUrlResponse> QuerySupplierItemBillDownloadUrlWithOptionsAsync(QuerySupplierItemBillDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillId))
            {
                body["BillId"] = request.BillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillPeriod))
            {
                body["BillPeriod"] = request.BillPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillStatus))
            {
                body["BillStatus"] = request.BillStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopId))
            {
                body["LmShopId"] = request.LmShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmShopName))
            {
                body["LmShopName"] = request.LmShopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySupplierItemBillDownloadUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySupplierItemBillDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySupplierItemBillDownloadUrlResponse QuerySupplierItemBillDownloadUrl(QuerySupplierItemBillDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySupplierItemBillDownloadUrlWithOptions(request, runtime);
        }

        public async Task<QuerySupplierItemBillDownloadUrlResponse> QuerySupplierItemBillDownloadUrlAsync(QuerySupplierItemBillDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySupplierItemBillDownloadUrlWithOptionsAsync(request, runtime);
        }

        public QueryUnfinishedActivitiesResponse QueryUnfinishedActivitiesWithOptions(QueryUnfinishedActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "QueryUnfinishedActivities",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfinishedActivitiesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnfinishedActivitiesResponse> QueryUnfinishedActivitiesWithOptionsAsync(QueryUnfinishedActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "QueryUnfinishedActivities",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfinishedActivitiesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTime))
            {
                query["QueryTime"] = request.QueryTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnfinishedSessions",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfinishedSessionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnfinishedSessionsResponse> QueryUnfinishedSessionsWithOptionsAsync(QueryUnfinishedSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTime))
            {
                query["QueryTime"] = request.QueryTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnfinishedSessions",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfinishedSessionsResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTime))
            {
                query["QueryTime"] = request.QueryTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnfinishedSessions4Items",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfinishedSessions4ItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUnfinishedSessions4ItemsResponse> QueryUnfinishedSessions4ItemsWithOptionsAsync(QueryUnfinishedSessions4ItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUnfinishedSessions4ItemsShrinkRequest request = new QueryUnfinishedSessions4ItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemIds))
            {
                request.ItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemIds, "ItemIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdsShrink))
            {
                query["ItemIds"] = request.ItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                query["LmItemIds"] = request.LmItemIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTime))
            {
                query["QueryTime"] = request.QueryTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUnfinishedSessions4Items",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfinishedSessions4ItemsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJsonShrink))
            {
                query["ExtJson"] = request.ExtJsonShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUpcomingMovies",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUpcomingMoviesResponse>(CallApi(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJsonShrink))
            {
                query["ExtJson"] = request.ExtJsonShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUpcomingMovies",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUpcomingMoviesResponse>(await CallApiAsync(params_, req, runtime));
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

        public QueryUserAccountResponse QueryUserAccountWithOptions(QueryUserAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUserAccountResponse> QueryUserAccountWithOptionsAsync(QueryUserAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUserAccountResponse QueryUserAccount(QueryUserAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserAccountWithOptions(request, runtime);
        }

        public async Task<QueryUserAccountResponse> QueryUserAccountAsync(QueryUserAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserAccountWithOptionsAsync(request, runtime);
        }

        public QueryUserGameProcessResponse QueryUserGameProcessWithOptions(QueryUserGameProcessRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUserGameProcessShrinkRequest request = new QueryUserGameProcessShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                query["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserGameProcess",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserGameProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUserGameProcessResponse> QueryUserGameProcessWithOptionsAsync(QueryUserGameProcessRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUserGameProcessShrinkRequest request = new QueryUserGameProcessShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                query["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserGameProcess",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserGameProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUserGameProcessResponse QueryUserGameProcess(QueryUserGameProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserGameProcessWithOptions(request, runtime);
        }

        public async Task<QueryUserGameProcessResponse> QueryUserGameProcessAsync(QueryUserGameProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserGameProcessWithOptionsAsync(request, runtime);
        }

        public QueryUserPointResponse QueryUserPointWithOptions(QueryUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUserPointShrinkRequest request = new QueryUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUserPointResponse> QueryUserPointWithOptionsAsync(QueryUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryUserPointShrinkRequest request = new QueryUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUserPointResponse QueryUserPoint(QueryUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserPointWithOptions(request, runtime);
        }

        public async Task<QueryUserPointResponse> QueryUserPointAsync(QueryUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserPointWithOptionsAsync(request, runtime);
        }

        public QueryWithholdTradeResponse QueryWithholdTradeWithOptions(QueryWithholdTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["TradeNo"] = request.TradeNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWithholdTrade",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWithholdTradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryWithholdTradeResponse> QueryWithholdTradeWithOptionsAsync(QueryWithholdTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["TradeNo"] = request.TradeNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWithholdTrade",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWithholdTradeResponse>(await CallApiAsync(params_, req, runtime));
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

        public RebindTbAccountResponse RebindTbAccountWithOptions(RebindTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebindTbAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebindTbAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RebindTbAccountResponse> RebindTbAccountWithOptionsAsync(RebindTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebindTbAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebindTbAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RebindTbAccountResponse RebindTbAccount(RebindTbAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebindTbAccountWithOptions(request, runtime);
        }

        public async Task<RebindTbAccountResponse> RebindTbAccountAsync(RebindTbAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebindTbAccountWithOptionsAsync(request, runtime);
        }

        public RefreshSettlementOrderAccountResponse RefreshSettlementOrderAccountWithOptions(RefreshSettlementOrderAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshSettlementOrderAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshSettlementOrderAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefreshSettlementOrderAccountResponse> RefreshSettlementOrderAccountWithOptionsAsync(RefreshSettlementOrderAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshSettlementOrderAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshSettlementOrderAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefreshSettlementOrderAccountResponse RefreshSettlementOrderAccount(RefreshSettlementOrderAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshSettlementOrderAccountWithOptions(request, runtime);
        }

        public async Task<RefreshSettlementOrderAccountResponse> RefreshSettlementOrderAccountAsync(RefreshSettlementOrderAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshSettlementOrderAccountWithOptionsAsync(request, runtime);
        }

        public RefundOrderResponse RefundOrderWithOptions(RefundOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["RefundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundRoyaltyParameters))
            {
                body["RefundRoyaltyParameters"] = request.RefundRoyaltyParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["TradeNo"] = request.TradeNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefundOrderResponse> RefundOrderWithOptionsAsync(RefundOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["RefundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundReason))
            {
                body["RefundReason"] = request.RefundReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundRoyaltyParameters))
            {
                body["RefundRoyaltyParameters"] = request.RefundRoyaltyParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["TradeNo"] = request.TradeNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundOrderResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                query["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefundPointResponse> RefundPointWithOptionsAsync(RefundPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerId))
            {
                query["SellerId"] = request.SellerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundPointResponse>(await CallApiAsync(params_, req, runtime));
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

        public RefundUserPointResponse RefundUserPointWithOptions(RefundUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefundUserPointShrinkRequest request = new RefundUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginRecordId))
            {
                query["OriginRecordId"] = request.OriginRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundUserPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefundUserPointResponse> RefundUserPointWithOptionsAsync(RefundUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefundUserPointShrinkRequest request = new RefundUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginRecordId))
            {
                query["OriginRecordId"] = request.OriginRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefundUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefundUserPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefundUserPointResponse RefundUserPoint(RefundUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefundUserPointWithOptions(request, runtime);
        }

        public async Task<RefundUserPointResponse> RefundUserPointAsync(RefundUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefundUserPointWithOptionsAsync(request, runtime);
        }

        public RefuseMerchantSyncTaskResponse RefuseMerchantSyncTaskWithOptions(RefuseMerchantSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerNick))
            {
                query["SellerNick"] = request.SellerNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStamp))
            {
                query["TimeStamp"] = request.TimeStamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseMerchantSyncTask",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseMerchantSyncTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefuseMerchantSyncTaskResponse> RefuseMerchantSyncTaskWithOptionsAsync(RefuseMerchantSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerNick))
            {
                query["SellerNick"] = request.SellerNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStamp))
            {
                query["TimeStamp"] = request.TimeStamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseMerchantSyncTask",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseMerchantSyncTaskResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegistAnonymousTbAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegistAnonymousTbAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegistAnonymousTbAccountResponse> RegistAnonymousTbAccountWithOptionsAsync(RegistAnonymousTbAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegistAnonymousTbAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegistAnonymousTbAccountResponse>(await CallApiAsync(params_, req, runtime));
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

        public RegisterSettleAccountResponse RegisterSettleAccountWithOptions(RegisterSettleAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountChannel))
            {
                body["AccountChannel"] = request.AccountChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPayType))
            {
                body["AccountPayType"] = request.AccountPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryOrAreaCode))
            {
                body["CountryOrAreaCode"] = request.CountryOrAreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                body["IdempotentId"] = request.IdempotentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterSettleAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterSettleAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterSettleAccountResponse> RegisterSettleAccountWithOptionsAsync(RegisterSettleAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountChannel))
            {
                body["AccountChannel"] = request.AccountChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["AccountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPayType))
            {
                body["AccountPayType"] = request.AccountPayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountryOrAreaCode))
            {
                body["CountryOrAreaCode"] = request.CountryOrAreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                body["IdempotentId"] = request.IdempotentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterSettleAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterSettleAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterSettleAccountResponse RegisterSettleAccount(RegisterSettleAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterSettleAccountWithOptions(request, runtime);
        }

        public async Task<RegisterSettleAccountResponse> RegisterSettleAccountAsync(RegisterSettleAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterSettleAccountWithOptionsAsync(request, runtime);
        }

        public RegisterUserAccountResponse RegisterUserAccountWithOptions(RegisterUserAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterUserAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterUserAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterUserAccountResponse> RegisterUserAccountWithOptionsAsync(RegisterUserAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterUserAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterUserAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterUserAccountResponse RegisterUserAccount(RegisterUserAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterUserAccountWithOptions(request, runtime);
        }

        public async Task<RegisterUserAccountResponse> RegisterUserAccountAsync(RegisterUserAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterUserAccountWithOptionsAsync(request, runtime);
        }

        public ReleaseMovieSeatResponse ReleaseMovieSeatWithOptions(ReleaseMovieSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockSeatApplyKey))
            {
                query["LockSeatApplyKey"] = request.LockSeatApplyKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseMovieSeat",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseMovieSeatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseMovieSeatResponse> ReleaseMovieSeatWithOptionsAsync(ReleaseMovieSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockSeatApplyKey))
            {
                query["LockSeatApplyKey"] = request.LockSeatApplyKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseMovieSeat",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseMovieSeatResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressInfo))
            {
                body["AddressInfo"] = request.AddressInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveAddressResponse> RemoveAddressWithOptionsAsync(RemoveAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressInfo))
            {
                body["AddressInfo"] = request.AddressInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAddressResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageIds))
            {
                query["MessageIds"] = request.MessageIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveMessages",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMessagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveMessagesResponse> RemoveMessagesWithOptionsAsync(RemoveMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageIds))
            {
                query["MessageIds"] = request.MessageIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveMessages",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMessagesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyOrderRequestModel))
            {
                query["BuyOrderRequestModel"] = request.BuyOrderRequestModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderH5Order",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderH5OrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenderH5OrderResponse> RenderH5OrderWithOptionsAsync(RenderH5OrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyOrderRequestModel))
            {
                query["BuyOrderRequestModel"] = request.BuyOrderRequestModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderH5Order",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderH5OrderResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenderOrderResponse> RenderOrderWithOptionsAsync(RenderOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                query["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                query["ItemList"] = request.ItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                query["LmItemId"] = request.LmItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderOrderResponse>(await CallApiAsync(params_, req, runtime));
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

        public RenderOrderWithDesignatedTbUidResponse RenderOrderWithDesignatedTbUidWithOptions(RenderOrderWithDesignatedTbUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RenderOrderWithDesignatedTbUidShrinkRequest request = new RenderOrderWithDesignatedTbUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemList))
            {
                request.ItemListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemList, "ItemList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemListShrink))
            {
                body["ItemList"] = request.ItemListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderOrderWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenderOrderWithDesignatedTbUidResponse> RenderOrderWithDesignatedTbUidWithOptionsAsync(RenderOrderWithDesignatedTbUidRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RenderOrderWithDesignatedTbUidShrinkRequest request = new RenderOrderWithDesignatedTbUidShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemList))
            {
                request.ItemListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemList, "ItemList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemListShrink))
            {
                body["ItemList"] = request.ItemListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderOrderWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderOrderWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenderOrderWithDesignatedTbUidResponse RenderOrderWithDesignatedTbUid(RenderOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenderOrderWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<RenderOrderWithDesignatedTbUidResponse> RenderOrderWithDesignatedTbUidAsync(RenderOrderWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenderOrderWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public RepayForPayUrlResponse RepayForPayUrlWithOptions(RepayForPayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepayForPayUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepayForPayUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RepayForPayUrlResponse> RepayForPayUrlWithOptionsAsync(RepayForPayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepayForPayUrl",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepayForPayUrlResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepayOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepayOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RepayOrderResponse> RepayOrderWithOptionsAsync(RepayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                query["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepayOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepayOrderResponse>(await CallApiAsync(params_, req, runtime));
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

        public RepayWithDesignatedTbUidResponse RepayWithDesignatedTbUidWithOptions(RepayWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                body["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepayWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepayWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RepayWithDesignatedTbUidResponse> RepayWithDesignatedTbUidWithOptionsAsync(RepayWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                body["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmOrderId))
            {
                body["LmOrderId"] = request.LmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepayWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepayWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RepayWithDesignatedTbUidResponse RepayWithDesignatedTbUid(RepayWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RepayWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<RepayWithDesignatedTbUidResponse> RepayWithDesignatedTbUidAsync(RepayWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RepayWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public ReserveMovieSeatResponse ReserveMovieSeatWithOptions(ReserveMovieSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleId))
            {
                query["ScheduleId"] = request.ScheduleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatIds))
            {
                query["SeatIds"] = request.SeatIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatNames))
            {
                query["SeatNames"] = request.SeatNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveMovieSeat",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveMovieSeatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReserveMovieSeatResponse> ReserveMovieSeatWithOptionsAsync(ReserveMovieSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleId))
            {
                query["ScheduleId"] = request.ScheduleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatIds))
            {
                query["SeatIds"] = request.SeatIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatNames))
            {
                query["SeatNames"] = request.SeatNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveMovieSeat",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveMovieSeatResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoyaltyParameters))
            {
                body["RoyaltyParameters"] = request.RoyaltyParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["TradeNo"] = request.TradeNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SettleOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SettleOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SettleOrderResponse> SettleOrderWithOptionsAsync(SettleOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["OutTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoyaltyParameters))
            {
                body["RoyaltyParameters"] = request.RoyaltyParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["TradeNo"] = request.TradeNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SettleOrder",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SettleOrderResponse>(await CallApiAsync(params_, req, runtime));
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

        public StartUserGameResponse StartUserGameWithOptions(StartUserGameRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartUserGameShrinkRequest request = new StartUserGameShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GameId))
            {
                query["GameId"] = request.GameId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteId))
            {
                query["RouteId"] = request.RouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserApp))
            {
                query["UserApp"] = request.UserApp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartUserGame",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartUserGameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartUserGameResponse> StartUserGameWithOptionsAsync(StartUserGameRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartUserGameShrinkRequest request = new StartUserGameShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GameId))
            {
                query["GameId"] = request.GameId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteId))
            {
                query["RouteId"] = request.RouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserApp))
            {
                query["UserApp"] = request.UserApp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartUserGame",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartUserGameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartUserGameResponse StartUserGame(StartUserGameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartUserGameWithOptions(request, runtime);
        }

        public async Task<StartUserGameResponse> StartUserGameAsync(StartUserGameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartUserGameWithOptionsAsync(request, runtime);
        }

        public SubmitReturnGoodLogisticsResponse SubmitReturnGoodLogisticsWithOptions(SubmitReturnGoodLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                query["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                query["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsNo))
            {
                query["LogisticsNo"] = request.LogisticsNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitReturnGoodLogistics",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReturnGoodLogisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitReturnGoodLogisticsResponse> SubmitReturnGoodLogisticsWithOptionsAsync(SubmitReturnGoodLogisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                query["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                query["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsNo))
            {
                query["LogisticsNo"] = request.LogisticsNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                query["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitReturnGoodLogistics",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReturnGoodLogisticsResponse>(await CallApiAsync(params_, req, runtime));
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

        public SubmitReturnGoodLogisticsWithDesignatedTbUidResponse SubmitReturnGoodLogisticsWithDesignatedTbUidWithOptions(SubmitReturnGoodLogisticsWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                body["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsNo))
            {
                body["LogisticsNo"] = request.LogisticsNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitReturnGoodLogisticsWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReturnGoodLogisticsWithDesignatedTbUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitReturnGoodLogisticsWithDesignatedTbUidResponse> SubmitReturnGoodLogisticsWithDesignatedTbUidWithOptionsAsync(SubmitReturnGoodLogisticsWithDesignatedTbUidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                body["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsNo))
            {
                body["LogisticsNo"] = request.LogisticsNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubLmOrderId))
            {
                body["SubLmOrderId"] = request.SubLmOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbAccountType))
            {
                body["TbAccountType"] = request.TbAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserId))
            {
                body["TbUserId"] = request.TbUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                body["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitReturnGoodLogisticsWithDesignatedTbUid",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReturnGoodLogisticsWithDesignatedTbUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitReturnGoodLogisticsWithDesignatedTbUidResponse SubmitReturnGoodLogisticsWithDesignatedTbUid(SubmitReturnGoodLogisticsWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitReturnGoodLogisticsWithDesignatedTbUidWithOptions(request, runtime);
        }

        public async Task<SubmitReturnGoodLogisticsWithDesignatedTbUidResponse> SubmitReturnGoodLogisticsWithDesignatedTbUidAsync(SubmitReturnGoodLogisticsWithDesignatedTbUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitReturnGoodLogisticsWithDesignatedTbUidWithOptionsAsync(request, runtime);
        }

        public SyncMerchantInfoResponse SyncMerchantInfoWithOptions(SyncMerchantInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerNick))
            {
                query["SellerNick"] = request.SellerNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStamp))
            {
                query["TimeStamp"] = request.TimeStamp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                body["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncMerchantInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncMerchantInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SyncMerchantInfoResponse> SyncMerchantInfoWithOptionsAsync(SyncMerchantInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerNick))
            {
                query["SellerNick"] = request.SellerNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStamp))
            {
                query["TimeStamp"] = request.TimeStamp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemList))
            {
                body["ItemList"] = request.ItemList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncMerchantInfo",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncMerchantInfoResponse>(await CallApiAsync(params_, req, runtime));
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

        public UnFreezeUserPointResponse UnFreezeUserPointWithOptions(UnFreezeUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnFreezeUserPointShrinkRequest request = new UnFreezeUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnFreezeUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnFreezeUserPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnFreezeUserPointResponse> UnFreezeUserPointWithOptionsAsync(UnFreezeUserPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnFreezeUserPointShrinkRequest request = new UnFreezeUserPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "ExtInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                body["ExtInfo"] = request.ExtInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnFreezeUserPoint",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnFreezeUserPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnFreezeUserPointResponse UnFreezeUserPoint(UnFreezeUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnFreezeUserPointWithOptions(request, runtime);
        }

        public async Task<UnFreezeUserPointResponse> UnFreezeUserPointAsync(UnFreezeUserPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnFreezeUserPointWithOptionsAsync(request, runtime);
        }

        public UnsignWithholdAgreementResponse UnsignWithholdAgreementWithOptions(UnsignWithholdAgreementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementNo))
            {
                body["AgreementNo"] = request.AgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalAgreementNo))
            {
                body["ExternalAgreementNo"] = request.ExternalAgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnsignWithholdAgreement",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsignWithholdAgreementResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnsignWithholdAgreementResponse> UnsignWithholdAgreementWithOptionsAsync(UnsignWithholdAgreementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementNo))
            {
                body["AgreementNo"] = request.AgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalAgreementNo))
            {
                body["ExternalAgreementNo"] = request.ExternalAgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["MerchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRequestNo))
            {
                body["OutRequestNo"] = request.OutRequestNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnsignWithholdAgreement",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsignWithholdAgreementResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressInfo))
            {
                body["AddressInfo"] = request.AddressInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAddressResponse> UpdateAddressWithOptionsAsync(UpdateAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyUserId))
            {
                query["ThirdPartyUserId"] = request.ThirdPartyUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAnonymousTbAccount))
            {
                query["UseAnonymousTbAccount"] = request.UseAnonymousTbAccount;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressInfo))
            {
                body["AddressInfo"] = request.AddressInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAddress",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAddressResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNo))
            {
                query["MobileNo"] = request.MobileNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserNick))
            {
                query["TbUserNick"] = request.TbUserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateTaobaoAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateTaobaoAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ValidateTaobaoAccountResponse> ValidateTaobaoAccountWithOptionsAsync(ValidateTaobaoAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizUid))
            {
                query["BizUid"] = request.BizUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtJson))
            {
                query["ExtJson"] = request.ExtJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNo))
            {
                query["MobileNo"] = request.MobileNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TbUserNick))
            {
                query["TbUserNick"] = request.TbUserNick;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateTaobaoAccount",
                Version = "2018-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateTaobaoAccountResponse>(await CallApiAsync(params_, req, runtime));
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
