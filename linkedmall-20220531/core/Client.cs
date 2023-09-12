// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Linkedmall20220531.Models;

namespace AlibabaCloud.SDK.Linkedmall20220531
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

        public ApplyCreateDistributionOrderResponse ApplyCreateDistributionOrderWithOptions(ApplyCreateDistributionOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyCreateDistributionOrderShrinkRequest request = new ApplyCreateDistributionOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemInfoLists))
            {
                request.ItemInfoListsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemInfoLists, "ItemInfoLists", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerId))
            {
                body["BuyerId"] = request.BuyerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionOutTradeId))
            {
                body["DistributionOutTradeId"] = request.DistributionOutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionSupplierId))
            {
                body["DistributionSupplierId"] = request.DistributionSupplierId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemInfoListsShrink))
            {
                body["ItemInfoLists"] = request.ItemInfoListsShrink;
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
                Action = "ApplyCreateDistributionOrder",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyCreateDistributionOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyCreateDistributionOrderResponse> ApplyCreateDistributionOrderWithOptionsAsync(ApplyCreateDistributionOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyCreateDistributionOrderShrinkRequest request = new ApplyCreateDistributionOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemInfoLists))
            {
                request.ItemInfoListsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemInfoLists, "ItemInfoLists", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerId))
            {
                body["BuyerId"] = request.BuyerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionOutTradeId))
            {
                body["DistributionOutTradeId"] = request.DistributionOutTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionSupplierId))
            {
                body["DistributionSupplierId"] = request.DistributionSupplierId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemInfoListsShrink))
            {
                body["ItemInfoLists"] = request.ItemInfoListsShrink;
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
                Action = "ApplyCreateDistributionOrder",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyCreateDistributionOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyCreateDistributionOrderResponse ApplyCreateDistributionOrder(ApplyCreateDistributionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyCreateDistributionOrderWithOptions(request, runtime);
        }

        public async Task<ApplyCreateDistributionOrderResponse> ApplyCreateDistributionOrderAsync(ApplyCreateDistributionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyCreateDistributionOrderWithOptionsAsync(request, runtime);
        }

        public ApplyRefund4DistributionResponse ApplyRefund4DistributionWithOptions(ApplyRefund4DistributionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyRefund4DistributionShrinkRequest request = new ApplyRefund4DistributionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LeavePictureLists))
            {
                request.LeavePictureListsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LeavePictureLists, "LeavePictureLists", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReasonTextId))
            {
                body["ApplyReasonTextId"] = request.ApplyReasonTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundCount))
            {
                body["ApplyRefundCount"] = request.ApplyRefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundFee))
            {
                body["ApplyRefundFee"] = request.ApplyRefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                body["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveMessage))
            {
                body["LeaveMessage"] = request.LeaveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeavePictureListsShrink))
            {
                body["LeavePictureLists"] = request.LeavePictureListsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "ApplyRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyRefund4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyRefund4DistributionResponse> ApplyRefund4DistributionWithOptionsAsync(ApplyRefund4DistributionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyRefund4DistributionShrinkRequest request = new ApplyRefund4DistributionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LeavePictureLists))
            {
                request.LeavePictureListsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LeavePictureLists, "LeavePictureLists", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReasonTextId))
            {
                body["ApplyReasonTextId"] = request.ApplyReasonTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundCount))
            {
                body["ApplyRefundCount"] = request.ApplyRefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundFee))
            {
                body["ApplyRefundFee"] = request.ApplyRefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                body["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveMessage))
            {
                body["LeaveMessage"] = request.LeaveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeavePictureListsShrink))
            {
                body["LeavePictureLists"] = request.LeavePictureListsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "ApplyRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyRefund4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyRefund4DistributionResponse ApplyRefund4Distribution(ApplyRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyRefund4DistributionWithOptions(request, runtime);
        }

        public async Task<ApplyRefund4DistributionResponse> ApplyRefund4DistributionAsync(ApplyRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyRefund4DistributionWithOptionsAsync(request, runtime);
        }

        public CancelDistributionTradeResponse CancelDistributionTradeWithOptions(CancelDistributionTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTradeId))
            {
                body["DistributionTradeId"] = request.DistributionTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "CancelDistributionTrade",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDistributionTradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelDistributionTradeResponse> CancelDistributionTradeWithOptionsAsync(CancelDistributionTradeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTradeId))
            {
                body["DistributionTradeId"] = request.DistributionTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "CancelDistributionTrade",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDistributionTradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelDistributionTradeResponse CancelDistributionTrade(CancelDistributionTradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDistributionTradeWithOptions(request, runtime);
        }

        public async Task<CancelDistributionTradeResponse> CancelDistributionTradeAsync(CancelDistributionTradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDistributionTradeWithOptionsAsync(request, runtime);
        }

        public CancelRefund4DistributionResponse CancelRefund4DistributionWithOptions(CancelRefund4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "CancelRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRefund4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelRefund4DistributionResponse> CancelRefund4DistributionWithOptionsAsync(CancelRefund4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "CancelRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRefund4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelRefund4DistributionResponse CancelRefund4Distribution(CancelRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRefund4DistributionWithOptions(request, runtime);
        }

        public async Task<CancelRefund4DistributionResponse> CancelRefund4DistributionAsync(CancelRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRefund4DistributionWithOptionsAsync(request, runtime);
        }

        public ConfirmDisburse4DistributionResponse ConfirmDisburse4DistributionWithOptions(ConfirmDisburse4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTradeId))
            {
                body["DistributionTradeId"] = request.DistributionTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainDistributionOrderId))
            {
                body["MainDistributionOrderId"] = request.MainDistributionOrderId;
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
                Action = "ConfirmDisburse4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDisburse4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmDisburse4DistributionResponse> ConfirmDisburse4DistributionWithOptionsAsync(ConfirmDisburse4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTradeId))
            {
                body["DistributionTradeId"] = request.DistributionTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainDistributionOrderId))
            {
                body["MainDistributionOrderId"] = request.MainDistributionOrderId;
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
                Action = "ConfirmDisburse4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmDisburse4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmDisburse4DistributionResponse ConfirmDisburse4Distribution(ConfirmDisburse4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmDisburse4DistributionWithOptions(request, runtime);
        }

        public async Task<ConfirmDisburse4DistributionResponse> ConfirmDisburse4DistributionAsync(ConfirmDisburse4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmDisburse4DistributionWithOptionsAsync(request, runtime);
        }

        public InitApplyRefund4DistributionResponse InitApplyRefund4DistributionWithOptions(InitApplyRefund4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                body["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "InitApplyRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitApplyRefund4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitApplyRefund4DistributionResponse> InitApplyRefund4DistributionWithOptionsAsync(InitApplyRefund4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                body["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "InitApplyRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitApplyRefund4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitApplyRefund4DistributionResponse InitApplyRefund4Distribution(InitApplyRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitApplyRefund4DistributionWithOptions(request, runtime);
        }

        public async Task<InitApplyRefund4DistributionResponse> InitApplyRefund4DistributionAsync(InitApplyRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitApplyRefund4DistributionWithOptionsAsync(request, runtime);
        }

        public InitModifyRefund4DistributionResponse InitModifyRefund4DistributionWithOptions(InitModifyRefund4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                body["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "InitModifyRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitModifyRefund4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitModifyRefund4DistributionResponse> InitModifyRefund4DistributionWithOptionsAsync(InitModifyRefund4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                body["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "InitModifyRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitModifyRefund4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitModifyRefund4DistributionResponse InitModifyRefund4Distribution(InitModifyRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitModifyRefund4DistributionWithOptions(request, runtime);
        }

        public async Task<InitModifyRefund4DistributionResponse> InitModifyRefund4DistributionAsync(InitModifyRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitModifyRefund4DistributionWithOptionsAsync(request, runtime);
        }

        public ListDistributionItemResponse ListDistributionItemWithOptions(ListDistributionItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemStatus))
            {
                body["ItemStatus"] = request.ItemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
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
                Action = "ListDistributionItem",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDistributionItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDistributionItemResponse> ListDistributionItemWithOptionsAsync(ListDistributionItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemStatus))
            {
                body["ItemStatus"] = request.ItemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
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
                Action = "ListDistributionItem",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDistributionItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDistributionItemResponse ListDistributionItem(ListDistributionItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDistributionItemWithOptions(request, runtime);
        }

        public async Task<ListDistributionItemResponse> ListDistributionItemAsync(ListDistributionItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDistributionItemWithOptionsAsync(request, runtime);
        }

        public ListDistributionItemWithoutCacheResponse ListDistributionItemWithoutCacheWithOptions(ListDistributionItemWithoutCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemStatus))
            {
                body["ItemStatus"] = request.ItemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
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
                Action = "ListDistributionItemWithoutCache",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDistributionItemWithoutCacheResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDistributionItemWithoutCacheResponse> ListDistributionItemWithoutCacheWithOptionsAsync(ListDistributionItemWithoutCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemStatus))
            {
                body["ItemStatus"] = request.ItemStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
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
                Action = "ListDistributionItemWithoutCache",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDistributionItemWithoutCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDistributionItemWithoutCacheResponse ListDistributionItemWithoutCache(ListDistributionItemWithoutCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDistributionItemWithoutCacheWithOptions(request, runtime);
        }

        public async Task<ListDistributionItemWithoutCacheResponse> ListDistributionItemWithoutCacheAsync(ListDistributionItemWithoutCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDistributionItemWithoutCacheWithOptionsAsync(request, runtime);
        }

        public ListDistributionMallResponse ListDistributionMallWithOptions(ListDistributionMallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelSupplierId))
            {
                body["ChannelSupplierId"] = request.ChannelSupplierId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallName))
            {
                body["DistributionMallName"] = request.DistributionMallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
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
                Action = "ListDistributionMall",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDistributionMallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDistributionMallResponse> ListDistributionMallWithOptionsAsync(ListDistributionMallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelSupplierId))
            {
                body["ChannelSupplierId"] = request.ChannelSupplierId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallName))
            {
                body["DistributionMallName"] = request.DistributionMallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
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
                Action = "ListDistributionMall",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDistributionMallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDistributionMallResponse ListDistributionMall(ListDistributionMallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDistributionMallWithOptions(request, runtime);
        }

        public async Task<ListDistributionMallResponse> ListDistributionMallAsync(ListDistributionMallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDistributionMallWithOptionsAsync(request, runtime);
        }

        public ModifyRefund4DistributionResponse ModifyRefund4DistributionWithOptions(ModifyRefund4DistributionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyRefund4DistributionShrinkRequest request = new ModifyRefund4DistributionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LeavePictureLists))
            {
                request.LeavePictureListsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LeavePictureLists, "LeavePictureLists", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReasonTextId))
            {
                body["ApplyReasonTextId"] = request.ApplyReasonTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundCount))
            {
                body["ApplyRefundCount"] = request.ApplyRefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundFee))
            {
                body["ApplyRefundFee"] = request.ApplyRefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                body["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveMessage))
            {
                body["LeaveMessage"] = request.LeaveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeavePictureListsShrink))
            {
                body["LeavePictureLists"] = request.LeavePictureListsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "ModifyRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRefund4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyRefund4DistributionResponse> ModifyRefund4DistributionWithOptionsAsync(ModifyRefund4DistributionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyRefund4DistributionShrinkRequest request = new ModifyRefund4DistributionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LeavePictureLists))
            {
                request.LeavePictureListsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LeavePictureLists, "LeavePictureLists", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReasonTextId))
            {
                body["ApplyReasonTextId"] = request.ApplyReasonTextId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundCount))
            {
                body["ApplyRefundCount"] = request.ApplyRefundCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRefundFee))
            {
                body["ApplyRefundFee"] = request.ApplyRefundFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizClaimType))
            {
                body["BizClaimType"] = request.BizClaimType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsStatus))
            {
                body["GoodsStatus"] = request.GoodsStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveMessage))
            {
                body["LeaveMessage"] = request.LeaveMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeavePictureListsShrink))
            {
                body["LeavePictureLists"] = request.LeavePictureListsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "ModifyRefund4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRefund4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyRefund4DistributionResponse ModifyRefund4Distribution(ModifyRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRefund4DistributionWithOptions(request, runtime);
        }

        public async Task<ModifyRefund4DistributionResponse> ModifyRefund4DistributionAsync(ModifyRefund4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRefund4DistributionWithOptionsAsync(request, runtime);
        }

        public QueryChildDivisionCodeByIdResponse QueryChildDivisionCodeByIdWithOptions(QueryChildDivisionCodeByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                body["DivisionCode"] = request.DivisionCode;
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
                Action = "QueryChildDivisionCodeById",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChildDivisionCodeByIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryChildDivisionCodeByIdResponse> QueryChildDivisionCodeByIdWithOptionsAsync(QueryChildDivisionCodeByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                body["DivisionCode"] = request.DivisionCode;
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
                Action = "QueryChildDivisionCodeById",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChildDivisionCodeByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryChildDivisionCodeByIdResponse QueryChildDivisionCodeById(QueryChildDivisionCodeByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChildDivisionCodeByIdWithOptions(request, runtime);
        }

        public async Task<QueryChildDivisionCodeByIdResponse> QueryChildDivisionCodeByIdAsync(QueryChildDivisionCodeByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChildDivisionCodeByIdWithOptionsAsync(request, runtime);
        }

        public QueryDistributionBillDetailResponse QueryDistributionBillDetailWithOptions(QueryDistributionBillDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallName))
            {
                body["DistributionMallName"] = request.DistributionMallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "QueryDistributionBillDetail",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDistributionBillDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDistributionBillDetailResponse> QueryDistributionBillDetailWithOptionsAsync(QueryDistributionBillDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallName))
            {
                body["DistributionMallName"] = request.DistributionMallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "QueryDistributionBillDetail",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDistributionBillDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDistributionBillDetailResponse QueryDistributionBillDetail(QueryDistributionBillDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDistributionBillDetailWithOptions(request, runtime);
        }

        public async Task<QueryDistributionBillDetailResponse> QueryDistributionBillDetailAsync(QueryDistributionBillDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDistributionBillDetailWithOptionsAsync(request, runtime);
        }

        public QueryDistributionMallResponse QueryDistributionMallWithOptions(QueryDistributionMallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
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
                Action = "QueryDistributionMall",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDistributionMallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDistributionMallResponse> QueryDistributionMallWithOptionsAsync(QueryDistributionMallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
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
                Action = "QueryDistributionMall",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDistributionMallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDistributionMallResponse QueryDistributionMall(QueryDistributionMallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDistributionMallWithOptions(request, runtime);
        }

        public async Task<QueryDistributionMallResponse> QueryDistributionMallAsync(QueryDistributionMallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDistributionMallWithOptionsAsync(request, runtime);
        }

        public QueryDistributionTradeStatusResponse QueryDistributionTradeStatusWithOptions(QueryDistributionTradeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionSupplierId))
            {
                body["DistributionSupplierId"] = request.DistributionSupplierId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTradeId))
            {
                body["DistributionTradeId"] = request.DistributionTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "QueryDistributionTradeStatus",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDistributionTradeStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDistributionTradeStatusResponse> QueryDistributionTradeStatusWithOptionsAsync(QueryDistributionTradeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionSupplierId))
            {
                body["DistributionSupplierId"] = request.DistributionSupplierId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTradeId))
            {
                body["DistributionTradeId"] = request.DistributionTradeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "QueryDistributionTradeStatus",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDistributionTradeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDistributionTradeStatusResponse QueryDistributionTradeStatus(QueryDistributionTradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDistributionTradeStatusWithOptions(request, runtime);
        }

        public async Task<QueryDistributionTradeStatusResponse> QueryDistributionTradeStatusAsync(QueryDistributionTradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDistributionTradeStatusWithOptionsAsync(request, runtime);
        }

        public QueryItemDetailResponse QueryItemDetailWithOptions(QueryItemDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
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
                Action = "QueryItemDetail",
                Version = "2022-05-31",
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
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
                Action = "QueryItemDetail",
                Version = "2022-05-31",
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

        public QueryItemDetailWithDivisionResponse QueryItemDetailWithDivisionWithOptions(QueryItemDetailWithDivisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                body["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
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
                Action = "QueryItemDetailWithDivision",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemDetailWithDivisionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemDetailWithDivisionResponse> QueryItemDetailWithDivisionWithOptionsAsync(QueryItemDetailWithDivisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DivisionCode))
            {
                body["DivisionCode"] = request.DivisionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemId))
            {
                body["LmItemId"] = request.LmItemId;
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
                Action = "QueryItemDetailWithDivision",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemDetailWithDivisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryItemDetailWithDivisionResponse QueryItemDetailWithDivision(QueryItemDetailWithDivisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemDetailWithDivisionWithOptions(request, runtime);
        }

        public async Task<QueryItemDetailWithDivisionResponse> QueryItemDetailWithDivisionAsync(QueryItemDetailWithDivisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemDetailWithDivisionWithOptionsAsync(request, runtime);
        }

        public QueryItemGuideRetailPriceResponse QueryItemGuideRetailPriceWithOptions(QueryItemGuideRetailPriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryItemGuideRetailPriceShrinkRequest request = new QueryItemGuideRetailPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                body["LmItemIds"] = request.LmItemIdsShrink;
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
                Action = "QueryItemGuideRetailPrice",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemGuideRetailPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryItemGuideRetailPriceResponse> QueryItemGuideRetailPriceWithOptionsAsync(QueryItemGuideRetailPriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryItemGuideRetailPriceShrinkRequest request = new QueryItemGuideRetailPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LmItemIds))
            {
                request.LmItemIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LmItemIds, "LmItemIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LmItemIdsShrink))
            {
                body["LmItemIds"] = request.LmItemIdsShrink;
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
                Action = "QueryItemGuideRetailPrice",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryItemGuideRetailPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryItemGuideRetailPriceResponse QueryItemGuideRetailPrice(QueryItemGuideRetailPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryItemGuideRetailPriceWithOptions(request, runtime);
        }

        public async Task<QueryItemGuideRetailPriceResponse> QueryItemGuideRetailPriceAsync(QueryItemGuideRetailPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryItemGuideRetailPriceWithOptionsAsync(request, runtime);
        }

        public QueryLogistics4DistributionResponse QueryLogistics4DistributionWithOptions(QueryLogistics4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainDistributionOrderId))
            {
                body["MainDistributionOrderId"] = request.MainDistributionOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
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
                Action = "QueryLogistics4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLogistics4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLogistics4DistributionResponse> QueryLogistics4DistributionWithOptionsAsync(QueryLogistics4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainDistributionOrderId))
            {
                body["MainDistributionOrderId"] = request.MainDistributionOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
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
                Action = "QueryLogistics4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLogistics4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLogistics4DistributionResponse QueryLogistics4Distribution(QueryLogistics4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLogistics4DistributionWithOptions(request, runtime);
        }

        public async Task<QueryLogistics4DistributionResponse> QueryLogistics4DistributionAsync(QueryLogistics4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLogistics4DistributionWithOptionsAsync(request, runtime);
        }

        public QueryMallCategoryListResponse QueryMallCategoryListWithOptions(QueryMallCategoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "QueryMallCategoryList",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMallCategoryListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMallCategoryListResponse> QueryMallCategoryListWithOptionsAsync(QueryMallCategoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionMallId))
            {
                body["DistributionMallId"] = request.DistributionMallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "QueryMallCategoryList",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMallCategoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMallCategoryListResponse QueryMallCategoryList(QueryMallCategoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMallCategoryListWithOptions(request, runtime);
        }

        public async Task<QueryMallCategoryListResponse> QueryMallCategoryListAsync(QueryMallCategoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMallCategoryListWithOptionsAsync(request, runtime);
        }

        public QueryOrderDetail4DistributionResponse QueryOrderDetail4DistributionWithOptions(QueryOrderDetail4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainDistributionOrderId))
            {
                body["MainDistributionOrderId"] = request.MainDistributionOrderId;
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
                Action = "QueryOrderDetail4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderDetail4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderDetail4DistributionResponse> QueryOrderDetail4DistributionWithOptionsAsync(QueryOrderDetail4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainDistributionOrderId))
            {
                body["MainDistributionOrderId"] = request.MainDistributionOrderId;
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
                Action = "QueryOrderDetail4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderDetail4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOrderDetail4DistributionResponse QueryOrderDetail4Distribution(QueryOrderDetail4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderDetail4DistributionWithOptions(request, runtime);
        }

        public async Task<QueryOrderDetail4DistributionResponse> QueryOrderDetail4DistributionAsync(QueryOrderDetail4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderDetail4DistributionWithOptionsAsync(request, runtime);
        }

        public QueryOrderList4DistributionResponse QueryOrderList4DistributionWithOptions(QueryOrderList4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "QueryOrderList4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderList4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryOrderList4DistributionResponse> QueryOrderList4DistributionWithOptionsAsync(QueryOrderList4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
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
                Action = "QueryOrderList4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderList4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryOrderList4DistributionResponse QueryOrderList4Distribution(QueryOrderList4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderList4DistributionWithOptions(request, runtime);
        }

        public async Task<QueryOrderList4DistributionResponse> QueryOrderList4DistributionAsync(QueryOrderList4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderList4DistributionWithOptionsAsync(request, runtime);
        }

        public QueryRefundApplicationDetail4DistributionResponse QueryRefundApplicationDetail4DistributionWithOptions(QueryRefundApplicationDetail4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "QueryRefundApplicationDetail4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRefundApplicationDetail4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRefundApplicationDetail4DistributionResponse> QueryRefundApplicationDetail4DistributionWithOptionsAsync(QueryRefundApplicationDetail4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "QueryRefundApplicationDetail4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRefundApplicationDetail4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRefundApplicationDetail4DistributionResponse QueryRefundApplicationDetail4Distribution(QueryRefundApplicationDetail4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRefundApplicationDetail4DistributionWithOptions(request, runtime);
        }

        public async Task<QueryRefundApplicationDetail4DistributionResponse> QueryRefundApplicationDetail4DistributionAsync(QueryRefundApplicationDetail4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRefundApplicationDetail4DistributionWithOptionsAsync(request, runtime);
        }

        public RenderDistributionOrderResponse RenderDistributionOrderWithOptions(RenderDistributionOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RenderDistributionOrderShrinkRequest request = new RenderDistributionOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemInfoLists))
            {
                request.ItemInfoListsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemInfoLists, "ItemInfoLists", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerId))
            {
                body["BuyerId"] = request.BuyerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionSupplierId))
            {
                body["DistributionSupplierId"] = request.DistributionSupplierId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemInfoListsShrink))
            {
                body["ItemInfoLists"] = request.ItemInfoListsShrink;
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
                Action = "RenderDistributionOrder",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderDistributionOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenderDistributionOrderResponse> RenderDistributionOrderWithOptionsAsync(RenderDistributionOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RenderDistributionOrderShrinkRequest request = new RenderDistributionOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ItemInfoLists))
            {
                request.ItemInfoListsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ItemInfoLists, "ItemInfoLists", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyerId))
            {
                body["BuyerId"] = request.BuyerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryAddress))
            {
                body["DeliveryAddress"] = request.DeliveryAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionSupplierId))
            {
                body["DistributionSupplierId"] = request.DistributionSupplierId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemInfoListsShrink))
            {
                body["ItemInfoLists"] = request.ItemInfoListsShrink;
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
                Action = "RenderDistributionOrder",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenderDistributionOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenderDistributionOrderResponse RenderDistributionOrder(RenderDistributionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenderDistributionOrderWithOptions(request, runtime);
        }

        public async Task<RenderDistributionOrderResponse> RenderDistributionOrderAsync(RenderDistributionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenderDistributionOrderWithOptionsAsync(request, runtime);
        }

        public SubmitReturnGoodLogistics4DistributionResponse SubmitReturnGoodLogistics4DistributionWithOptions(SubmitReturnGoodLogistics4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                body["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsNo))
            {
                body["LogisticsNo"] = request.LogisticsNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "SubmitReturnGoodLogistics4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReturnGoodLogistics4DistributionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitReturnGoodLogistics4DistributionResponse> SubmitReturnGoodLogistics4DistributionWithOptionsAsync(SubmitReturnGoodLogistics4DistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpCode))
            {
                body["CpCode"] = request.CpCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisputeId))
            {
                body["DisputeId"] = request.DisputeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributorId))
            {
                body["DistributorId"] = request.DistributorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogisticsNo))
            {
                body["LogisticsNo"] = request.LogisticsNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDistributionOrderId))
            {
                body["SubDistributionOrderId"] = request.SubDistributionOrderId;
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
                Action = "SubmitReturnGoodLogistics4Distribution",
                Version = "2022-05-31",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReturnGoodLogistics4DistributionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitReturnGoodLogistics4DistributionResponse SubmitReturnGoodLogistics4Distribution(SubmitReturnGoodLogistics4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitReturnGoodLogistics4DistributionWithOptions(request, runtime);
        }

        public async Task<SubmitReturnGoodLogistics4DistributionResponse> SubmitReturnGoodLogistics4DistributionAsync(SubmitReturnGoodLogistics4DistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitReturnGoodLogistics4DistributionWithOptionsAsync(request, runtime);
        }

    }
}
