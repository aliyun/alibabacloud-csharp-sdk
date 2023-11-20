// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Linkvisual20230630.Models;

namespace AlibabaCloud.SDK.Linkvisual20230630
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "linkvisual.aliyuncs.com"},
                {"ap-northeast-2-pop", "linkvisual.aliyuncs.com"},
                {"ap-south-1", "linkvisual.aliyuncs.com"},
                {"ap-southeast-1", "linkvisual.aliyuncs.com"},
                {"ap-southeast-2", "linkvisual.aliyuncs.com"},
                {"ap-southeast-3", "linkvisual.aliyuncs.com"},
                {"ap-southeast-5", "linkvisual.aliyuncs.com"},
                {"cn-beijing", "linkvisual.aliyuncs.com"},
                {"cn-beijing-finance-1", "linkvisual.aliyuncs.com"},
                {"cn-beijing-finance-pop", "linkvisual.aliyuncs.com"},
                {"cn-beijing-gov-1", "linkvisual.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "linkvisual.aliyuncs.com"},
                {"cn-chengdu", "linkvisual.aliyuncs.com"},
                {"cn-edge-1", "linkvisual.aliyuncs.com"},
                {"cn-fujian", "linkvisual.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "linkvisual.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "linkvisual.aliyuncs.com"},
                {"cn-hangzhou-finance", "linkvisual.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "linkvisual.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "linkvisual.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "linkvisual.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "linkvisual.aliyuncs.com"},
                {"cn-hangzhou-test-306", "linkvisual.aliyuncs.com"},
                {"cn-hongkong", "linkvisual.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "linkvisual.aliyuncs.com"},
                {"cn-huhehaote", "linkvisual.aliyuncs.com"},
                {"cn-north-2-gov-1", "linkvisual.aliyuncs.com"},
                {"cn-qingdao", "linkvisual.aliyuncs.com"},
                {"cn-qingdao-nebula", "linkvisual.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "linkvisual.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "linkvisual.aliyuncs.com"},
                {"cn-shanghai-finance-1", "linkvisual.aliyuncs.com"},
                {"cn-shanghai-inner", "linkvisual.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "linkvisual.aliyuncs.com"},
                {"cn-shenzhen", "linkvisual.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "linkvisual.aliyuncs.com"},
                {"cn-shenzhen-inner", "linkvisual.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "linkvisual.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "linkvisual.aliyuncs.com"},
                {"cn-wuhan", "linkvisual.aliyuncs.com"},
                {"cn-yushanfang", "linkvisual.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "linkvisual.aliyuncs.com"},
                {"cn-zhangjiakou", "linkvisual.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "linkvisual.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "linkvisual.aliyuncs.com"},
                {"eu-central-1", "linkvisual.aliyuncs.com"},
                {"eu-west-1", "linkvisual.aliyuncs.com"},
                {"eu-west-1-oxs", "linkvisual.aliyuncs.com"},
                {"me-east-1", "linkvisual.aliyuncs.com"},
                {"rus-west-1-pop", "linkvisual.aliyuncs.com"},
                {"us-east-1", "linkvisual.aliyuncs.com"},
                {"us-west-1", "linkvisual.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("linkvisual", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public BatchBindDeviceResponse BatchBindDeviceWithOptions(BatchBindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceList))
            {
                query["DeviceList"] = request.DeviceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenId))
            {
                query["OpenId"] = request.OpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIdAppKey))
            {
                query["OpenIdAppKey"] = request.OpenIdAppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchBindDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchBindDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchBindDeviceResponse> BatchBindDeviceWithOptionsAsync(BatchBindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceList))
            {
                query["DeviceList"] = request.DeviceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenId))
            {
                query["OpenId"] = request.OpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIdAppKey))
            {
                query["OpenIdAppKey"] = request.OpenIdAppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchBindDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchBindDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchBindDeviceResponse BatchBindDevice(BatchBindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindDeviceWithOptions(request, runtime);
        }

        public async Task<BatchBindDeviceResponse> BatchBindDeviceAsync(BatchBindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindDeviceWithOptionsAsync(request, runtime);
        }

        public BindStorageOrderResponse BindStorageOrderWithOptions(BindStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultPlan))
            {
                query["EnableDefaultPlan"] = request.EnableDefaultPlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordDuration))
            {
                query["EventRecordDuration"] = request.EventRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordProlong))
            {
                query["EventRecordProlong"] = request.EventRecordProlong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRecordFileDuration))
            {
                query["MaxRecordFileDuration"] = request.MaxRecordFileDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindStorageOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindStorageOrderResponse> BindStorageOrderWithOptionsAsync(BindStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultPlan))
            {
                query["EnableDefaultPlan"] = request.EnableDefaultPlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordDuration))
            {
                query["EventRecordDuration"] = request.EventRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordProlong))
            {
                query["EventRecordProlong"] = request.EventRecordProlong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRecordFileDuration))
            {
                query["MaxRecordFileDuration"] = request.MaxRecordFileDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindStorageOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindStorageOrderResponse BindStorageOrder(BindStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindStorageOrderWithOptions(request, runtime);
        }

        public async Task<BindStorageOrderResponse> BindStorageOrderAsync(BindStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindStorageOrderWithOptionsAsync(request, runtime);
        }

        public CheckFreeStorageValidResponse CheckFreeStorageValidWithOptions(CheckFreeStorageValidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckFreeStorageValid",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFreeStorageValidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckFreeStorageValidResponse> CheckFreeStorageValidWithOptionsAsync(CheckFreeStorageValidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckFreeStorageValid",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFreeStorageValidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckFreeStorageValidResponse CheckFreeStorageValid(CheckFreeStorageValidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFreeStorageValidWithOptions(request, runtime);
        }

        public async Task<CheckFreeStorageValidResponse> CheckFreeStorageValidAsync(CheckFreeStorageValidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFreeStorageValidWithOptionsAsync(request, runtime);
        }

        public ConsumeFreeStorageResponse ConsumeFreeStorageWithOptions(ConsumeFreeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultPlan))
            {
                query["EnableDefaultPlan"] = request.EnableDefaultPlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordDuration))
            {
                query["EventRecordDuration"] = request.EventRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordProlong))
            {
                query["EventRecordProlong"] = request.EventRecordProlong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateUse))
            {
                query["ImmediateUse"] = request.ImmediateUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["Quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConsumeFreeStorage",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsumeFreeStorageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConsumeFreeStorageResponse> ConsumeFreeStorageWithOptionsAsync(ConsumeFreeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultPlan))
            {
                query["EnableDefaultPlan"] = request.EnableDefaultPlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordDuration))
            {
                query["EventRecordDuration"] = request.EventRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordProlong))
            {
                query["EventRecordProlong"] = request.EventRecordProlong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateUse))
            {
                query["ImmediateUse"] = request.ImmediateUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["Quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConsumeFreeStorage",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsumeFreeStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConsumeFreeStorageResponse ConsumeFreeStorage(ConsumeFreeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConsumeFreeStorageWithOptions(request, runtime);
        }

        public async Task<ConsumeFreeStorageResponse> ConsumeFreeStorageAsync(ConsumeFreeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConsumeFreeStorageWithOptionsAsync(request, runtime);
        }

        public CreateAndPayStorageOrderResponse CreateAndPayStorageOrderWithOptions(CreateAndPayStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Copies))
            {
                query["Copies"] = request.Copies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNoOwner))
            {
                query["DeviceNoOwner"] = request.DeviceNoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultPlan))
            {
                query["EnableDefaultPlan"] = request.EnableDefaultPlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordDuration))
            {
                query["EventRecordDuration"] = request.EventRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordProlong))
            {
                query["EventRecordProlong"] = request.EventRecordProlong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateUse))
            {
                query["ImmediateUse"] = request.ImmediateUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRecordFileDuration))
            {
                query["MaxRecordFileDuration"] = request.MaxRecordFileDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndPayStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndPayStorageOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAndPayStorageOrderResponse> CreateAndPayStorageOrderWithOptionsAsync(CreateAndPayStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Copies))
            {
                query["Copies"] = request.Copies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNoOwner))
            {
                query["DeviceNoOwner"] = request.DeviceNoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultPlan))
            {
                query["EnableDefaultPlan"] = request.EnableDefaultPlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordDuration))
            {
                query["EventRecordDuration"] = request.EventRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordProlong))
            {
                query["EventRecordProlong"] = request.EventRecordProlong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateUse))
            {
                query["ImmediateUse"] = request.ImmediateUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRecordFileDuration))
            {
                query["MaxRecordFileDuration"] = request.MaxRecordFileDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndPayStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndPayStorageOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAndPayStorageOrderResponse CreateAndPayStorageOrder(CreateAndPayStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAndPayStorageOrderWithOptions(request, runtime);
        }

        public async Task<CreateAndPayStorageOrderResponse> CreateAndPayStorageOrderAsync(CreateAndPayStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAndPayStorageOrderWithOptionsAsync(request, runtime);
        }

        public EnableFreeStorageResponse EnableFreeStorageWithOptions(EnableFreeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableFreeStorage",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableFreeStorageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableFreeStorageResponse> EnableFreeStorageWithOptionsAsync(EnableFreeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableFreeStorage",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableFreeStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableFreeStorageResponse EnableFreeStorage(EnableFreeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableFreeStorageWithOptions(request, runtime);
        }

        public async Task<EnableFreeStorageResponse> EnableFreeStorageAsync(EnableFreeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableFreeStorageWithOptionsAsync(request, runtime);
        }

        public EnableStorageOrderResponse EnableStorageOrderWithOptions(EnableStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableStorageOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableStorageOrderResponse> EnableStorageOrderWithOptionsAsync(EnableStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableStorageOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableStorageOrderResponse EnableStorageOrder(EnableStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableStorageOrderWithOptions(request, runtime);
        }

        public async Task<EnableStorageOrderResponse> EnableStorageOrderAsync(EnableStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableStorageOrderWithOptionsAsync(request, runtime);
        }

        public FreezeFreeStorageResponse FreezeFreeStorageWithOptions(FreezeFreeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FreezeFreeStorage",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeFreeStorageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FreezeFreeStorageResponse> FreezeFreeStorageWithOptionsAsync(FreezeFreeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FreezeFreeStorage",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeFreeStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FreezeFreeStorageResponse FreezeFreeStorage(FreezeFreeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FreezeFreeStorageWithOptions(request, runtime);
        }

        public async Task<FreezeFreeStorageResponse> FreezeFreeStorageAsync(FreezeFreeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FreezeFreeStorageWithOptionsAsync(request, runtime);
        }

        public FreezeStorageOrderResponse FreezeStorageOrderWithOptions(FreezeStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNoOwner))
            {
                query["DeviceNoOwner"] = request.DeviceNoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FreezeStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeStorageOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FreezeStorageOrderResponse> FreezeStorageOrderWithOptionsAsync(FreezeStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNoOwner))
            {
                query["DeviceNoOwner"] = request.DeviceNoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FreezeStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FreezeStorageOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FreezeStorageOrderResponse FreezeStorageOrder(FreezeStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FreezeStorageOrderWithOptions(request, runtime);
        }

        public async Task<FreezeStorageOrderResponse> FreezeStorageOrderAsync(FreezeStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FreezeStorageOrderWithOptionsAsync(request, runtime);
        }

        public GenerateDeviceResponse GenerateDeviceWithOptions(GenerateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateDeviceResponse> GenerateDeviceWithOptionsAsync(GenerateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateDeviceResponse GenerateDevice(GenerateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDeviceWithOptions(request, runtime);
        }

        public async Task<GenerateDeviceResponse> GenerateDeviceAsync(GenerateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDeviceWithOptionsAsync(request, runtime);
        }

        public GenerateDeviceByBatchIdResponse GenerateDeviceByBatchIdWithOptions(GenerateDeviceByBatchIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDeviceByBatchId",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDeviceByBatchIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateDeviceByBatchIdResponse> GenerateDeviceByBatchIdWithOptionsAsync(GenerateDeviceByBatchIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDeviceByBatchId",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDeviceByBatchIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateDeviceByBatchIdResponse GenerateDeviceByBatchId(GenerateDeviceByBatchIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDeviceByBatchIdWithOptions(request, runtime);
        }

        public async Task<GenerateDeviceByBatchIdResponse> GenerateDeviceByBatchIdAsync(GenerateDeviceByBatchIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDeviceByBatchIdWithOptionsAsync(request, runtime);
        }

        public GetAccountByIdResponse GetAccountByIdWithOptions(GetAccountByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenId))
            {
                query["OpenId"] = request.OpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIdAppKey))
            {
                query["OpenIdAppKey"] = request.OpenIdAppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountById",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountByIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAccountByIdResponse> GetAccountByIdWithOptionsAsync(GetAccountByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenId))
            {
                query["OpenId"] = request.OpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIdAppKey))
            {
                query["OpenIdAppKey"] = request.OpenIdAppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountById",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAccountByIdResponse GetAccountById(GetAccountByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountByIdWithOptions(request, runtime);
        }

        public async Task<GetAccountByIdResponse> GetAccountByIdAsync(GetAccountByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountByIdWithOptionsAsync(request, runtime);
        }

        public GetDeviceStatusResponse GetDeviceStatusWithOptions(GetDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceStatus",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDeviceStatusResponse> GetDeviceStatusWithOptionsAsync(GetDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceStatus",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDeviceStatusResponse GetDeviceStatus(GetDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceStatusWithOptions(request, runtime);
        }

        public async Task<GetDeviceStatusResponse> GetDeviceStatusAsync(GetDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceStatusWithOptionsAsync(request, runtime);
        }

        public GetSubDeviceListResponse GetSubDeviceListWithOptions(GetSubDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubDeviceList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubDeviceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSubDeviceListResponse> GetSubDeviceListWithOptionsAsync(GetSubDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubDeviceList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubDeviceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSubDeviceListResponse GetSubDeviceList(GetSubDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubDeviceListWithOptions(request, runtime);
        }

        public async Task<GetSubDeviceListResponse> GetSubDeviceListAsync(GetSubDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubDeviceListWithOptionsAsync(request, runtime);
        }

        public GetThingEventSnapshotResponse GetThingEventSnapshotWithOptions(GetThingEventSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetThingEventSnapshot",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThingEventSnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetThingEventSnapshotResponse> GetThingEventSnapshotWithOptionsAsync(GetThingEventSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetThingEventSnapshot",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThingEventSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetThingEventSnapshotResponse GetThingEventSnapshot(GetThingEventSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingEventSnapshotWithOptions(request, runtime);
        }

        public async Task<GetThingEventSnapshotResponse> GetThingEventSnapshotAsync(GetThingEventSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingEventSnapshotWithOptionsAsync(request, runtime);
        }

        public GetThingPropertySnapshotResponse GetThingPropertySnapshotWithOptions(GetThingPropertySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetThingPropertySnapshot",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThingPropertySnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetThingPropertySnapshotResponse> GetThingPropertySnapshotWithOptionsAsync(GetThingPropertySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetThingPropertySnapshot",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThingPropertySnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetThingPropertySnapshotResponse GetThingPropertySnapshot(GetThingPropertySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingPropertySnapshotWithOptions(request, runtime);
        }

        public async Task<GetThingPropertySnapshotResponse> GetThingPropertySnapshotAsync(GetThingPropertySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingPropertySnapshotWithOptionsAsync(request, runtime);
        }

        public InvokeThingServiceResponse InvokeThingServiceWithOptions(InvokeThingServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                query["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeThingService",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeThingServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InvokeThingServiceResponse> InvokeThingServiceWithOptionsAsync(InvokeThingServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                query["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeThingService",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeThingServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InvokeThingServiceResponse InvokeThingService(InvokeThingServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeThingServiceWithOptions(request, runtime);
        }

        public async Task<InvokeThingServiceResponse> InvokeThingServiceAsync(InvokeThingServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeThingServiceWithOptionsAsync(request, runtime);
        }

        public ListBindingAccountByDeviceResponse ListBindingAccountByDeviceWithOptions(ListBindingAccountByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owned))
            {
                query["Owned"] = request.Owned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindingAccountByDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingAccountByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBindingAccountByDeviceResponse> ListBindingAccountByDeviceWithOptionsAsync(ListBindingAccountByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owned))
            {
                query["Owned"] = request.Owned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindingAccountByDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingAccountByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBindingAccountByDeviceResponse ListBindingAccountByDevice(ListBindingAccountByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindingAccountByDeviceWithOptions(request, runtime);
        }

        public async Task<ListBindingAccountByDeviceResponse> ListBindingAccountByDeviceAsync(ListBindingAccountByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindingAccountByDeviceWithOptionsAsync(request, runtime);
        }

        public ListBindingDeviceByAccountResponse ListBindingDeviceByAccountWithOptions(ListBindingDeviceByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenId))
            {
                query["OpenId"] = request.OpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIdAppKey))
            {
                query["OpenIdAppKey"] = request.OpenIdAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDevice))
            {
                query["SubDevice"] = request.SubDevice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindingDeviceByAccount",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingDeviceByAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBindingDeviceByAccountResponse> ListBindingDeviceByAccountWithOptionsAsync(ListBindingDeviceByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenId))
            {
                query["OpenId"] = request.OpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIdAppKey))
            {
                query["OpenIdAppKey"] = request.OpenIdAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDevice))
            {
                query["SubDevice"] = request.SubDevice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindingDeviceByAccount",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingDeviceByAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBindingDeviceByAccountResponse ListBindingDeviceByAccount(ListBindingDeviceByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindingDeviceByAccountWithOptions(request, runtime);
        }

        public async Task<ListBindingDeviceByAccountResponse> ListBindingDeviceByAccountAsync(ListBindingDeviceByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindingDeviceByAccountWithOptionsAsync(request, runtime);
        }

        public QueryBatchStatusResponse QueryBatchStatusWithOptions(QueryBatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBatchStatus",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryBatchStatusResponse> QueryBatchStatusWithOptionsAsync(QueryBatchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBatchStatus",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryBatchStatusResponse QueryBatchStatus(QueryBatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBatchStatusWithOptions(request, runtime);
        }

        public async Task<QueryBatchStatusResponse> QueryBatchStatusAsync(QueryBatchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBatchStatusWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDetailResponse QueryDeviceDetailWithOptions(QueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceDetail",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceDetailResponse> QueryDeviceDetailWithOptionsAsync(QueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceDetail",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceDetailResponse QueryDeviceDetail(QueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDetailWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDetailResponse> QueryDeviceDetailAsync(QueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDetailWithOptionsAsync(request, runtime);
        }

        public QueryDevicesDownloadUrlResponse QueryDevicesDownloadUrlWithOptions(QueryDevicesDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesDownloadUrl",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDevicesDownloadUrlResponse> QueryDevicesDownloadUrlWithOptionsAsync(QueryDevicesDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesDownloadUrl",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDevicesDownloadUrlResponse QueryDevicesDownloadUrl(QueryDevicesDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesDownloadUrlWithOptions(request, runtime);
        }

        public async Task<QueryDevicesDownloadUrlResponse> QueryDevicesDownloadUrlAsync(QueryDevicesDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesDownloadUrlWithOptionsAsync(request, runtime);
        }

        public QueryFreeStorageResponse QueryFreeStorageWithOptions(QueryFreeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFreeStorage",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFreeStorageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFreeStorageResponse> QueryFreeStorageWithOptionsAsync(QueryFreeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFreeStorage",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFreeStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFreeStorageResponse QueryFreeStorage(QueryFreeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFreeStorageWithOptions(request, runtime);
        }

        public async Task<QueryFreeStorageResponse> QueryFreeStorageAsync(QueryFreeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFreeStorageWithOptionsAsync(request, runtime);
        }

        public QueryGenerateDevicesInfoListResponse QueryGenerateDevicesInfoListWithOptions(QueryGenerateDevicesInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGenerateDevicesInfoList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGenerateDevicesInfoListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryGenerateDevicesInfoListResponse> QueryGenerateDevicesInfoListWithOptionsAsync(QueryGenerateDevicesInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGenerateDevicesInfoList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGenerateDevicesInfoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryGenerateDevicesInfoListResponse QueryGenerateDevicesInfoList(QueryGenerateDevicesInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryGenerateDevicesInfoListWithOptions(request, runtime);
        }

        public async Task<QueryGenerateDevicesInfoListResponse> QueryGenerateDevicesInfoListAsync(QueryGenerateDevicesInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryGenerateDevicesInfoListWithOptionsAsync(request, runtime);
        }

        public QueryGenerateDevicesRecordResponse QueryGenerateDevicesRecordWithOptions(QueryGenerateDevicesRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGenerateDevicesRecord",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGenerateDevicesRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryGenerateDevicesRecordResponse> QueryGenerateDevicesRecordWithOptionsAsync(QueryGenerateDevicesRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGenerateDevicesRecord",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGenerateDevicesRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryGenerateDevicesRecordResponse QueryGenerateDevicesRecord(QueryGenerateDevicesRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryGenerateDevicesRecordWithOptions(request, runtime);
        }

        public async Task<QueryGenerateDevicesRecordResponse> QueryGenerateDevicesRecordAsync(QueryGenerateDevicesRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryGenerateDevicesRecordWithOptionsAsync(request, runtime);
        }

        public QueryStorageCommodityListResponse QueryStorageCommodityListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStorageCommodityList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStorageCommodityListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryStorageCommodityListResponse> QueryStorageCommodityListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStorageCommodityList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStorageCommodityListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryStorageCommodityListResponse QueryStorageCommodityList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStorageCommodityListWithOptions(runtime);
        }

        public async Task<QueryStorageCommodityListResponse> QueryStorageCommodityListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStorageCommodityListWithOptionsAsync(runtime);
        }

        public QueryStorageOrderResponse QueryStorageOrderWithOptions(QueryStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNoOwner))
            {
                query["DeviceNoOwner"] = request.DeviceNoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStorageOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryStorageOrderResponse> QueryStorageOrderWithOptionsAsync(QueryStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNoOwner))
            {
                query["DeviceNoOwner"] = request.DeviceNoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStorageOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryStorageOrderResponse QueryStorageOrder(QueryStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStorageOrderWithOptions(request, runtime);
        }

        public async Task<QueryStorageOrderResponse> QueryStorageOrderAsync(QueryStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStorageOrderWithOptionsAsync(request, runtime);
        }

        public QueryStorageOrderListResponse QueryStorageOrderListWithOptions(QueryStorageOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNoOwner))
            {
                query["DeviceNoOwner"] = request.DeviceNoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStorageOrderList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStorageOrderListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryStorageOrderListResponse> QueryStorageOrderListWithOptionsAsync(QueryStorageOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNoOwner))
            {
                query["DeviceNoOwner"] = request.DeviceNoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStorageOrderList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStorageOrderListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryStorageOrderListResponse QueryStorageOrderList(QueryStorageOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStorageOrderListWithOptions(request, runtime);
        }

        public async Task<QueryStorageOrderListResponse> QueryStorageOrderListAsync(QueryStorageOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStorageOrderListWithOptionsAsync(request, runtime);
        }

        public SetThingPropertyResponse SetThingPropertyWithOptions(SetThingPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                query["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetThingProperty",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetThingPropertyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetThingPropertyResponse> SetThingPropertyWithOptionsAsync(SetThingPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Args))
            {
                query["Args"] = request.Args;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetThingProperty",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetThingPropertyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetThingPropertyResponse SetThingProperty(SetThingPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetThingPropertyWithOptions(request, runtime);
        }

        public async Task<SetThingPropertyResponse> SetThingPropertyAsync(SetThingPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetThingPropertyWithOptionsAsync(request, runtime);
        }

        public TransferStorageOrderResponse TransferStorageOrderWithOptions(TransferStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIotId))
            {
                query["DstIotId"] = request.DstIotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultPlan))
            {
                query["EnableDefaultPlan"] = request.EnableDefaultPlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordDuration))
            {
                query["EventRecordDuration"] = request.EventRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordProlong))
            {
                query["EventRecordProlong"] = request.EventRecordProlong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateUse))
            {
                query["ImmediateUse"] = request.ImmediateUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIotId))
            {
                query["SrcIotId"] = request.SrcIotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcOrderId))
            {
                query["SrcOrderId"] = request.SrcOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportCrossIdentityTransfer))
            {
                query["SupportCrossIdentityTransfer"] = request.SupportCrossIdentityTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferStorageOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferStorageOrderResponse> TransferStorageOrderWithOptionsAsync(TransferStorageOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIotId))
            {
                query["DstIotId"] = request.DstIotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultPlan))
            {
                query["EnableDefaultPlan"] = request.EnableDefaultPlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordDuration))
            {
                query["EventRecordDuration"] = request.EventRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventRecordProlong))
            {
                query["EventRecordProlong"] = request.EventRecordProlong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateUse))
            {
                query["ImmediateUse"] = request.ImmediateUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIotId))
            {
                query["SrcIotId"] = request.SrcIotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcOrderId))
            {
                query["SrcOrderId"] = request.SrcOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportCrossIdentityTransfer))
            {
                query["SupportCrossIdentityTransfer"] = request.SupportCrossIdentityTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferStorageOrder",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferStorageOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferStorageOrderResponse TransferStorageOrder(TransferStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferStorageOrderWithOptions(request, runtime);
        }

        public async Task<TransferStorageOrderResponse> TransferStorageOrderAsync(TransferStorageOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferStorageOrderWithOptionsAsync(request, runtime);
        }

        public UnbindAllUserByDeviceResponse UnbindAllUserByDeviceWithOptions(UnbindAllUserByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindSubDevice))
            {
                query["UnbindSubDevice"] = request.UnbindSubDevice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAllUserByDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAllUserByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindAllUserByDeviceResponse> UnbindAllUserByDeviceWithOptionsAsync(UnbindAllUserByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindSubDevice))
            {
                query["UnbindSubDevice"] = request.UnbindSubDevice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAllUserByDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAllUserByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindAllUserByDeviceResponse UnbindAllUserByDevice(UnbindAllUserByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAllUserByDeviceWithOptions(request, runtime);
        }

        public async Task<UnbindAllUserByDeviceResponse> UnbindAllUserByDeviceAsync(UnbindAllUserByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAllUserByDeviceWithOptionsAsync(request, runtime);
        }

        public UnbindDeviceResponse UnbindDeviceWithOptions(UnbindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenId))
            {
                query["OpenId"] = request.OpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIdAppKey))
            {
                query["OpenIdAppKey"] = request.OpenIdAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindSubDevice))
            {
                query["UnbindSubDevice"] = request.UnbindSubDevice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindDeviceResponse> UnbindDeviceWithOptionsAsync(UnbindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityId))
            {
                query["IdentityId"] = request.IdentityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenId))
            {
                query["OpenId"] = request.OpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenIdAppKey))
            {
                query["OpenIdAppKey"] = request.OpenIdAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindSubDevice))
            {
                query["UnbindSubDevice"] = request.UnbindSubDevice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindDevice",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindDeviceResponse UnbindDevice(UnbindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDeviceWithOptions(request, runtime);
        }

        public async Task<UnbindDeviceResponse> UnbindDeviceAsync(UnbindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDeviceWithOptionsAsync(request, runtime);
        }

        public UploadDeviceNameListResponse UploadDeviceNameListWithOptions(UploadDeviceNameListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNames))
            {
                body["DeviceNames"] = request.DeviceNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDeviceNameList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDeviceNameListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadDeviceNameListResponse> UploadDeviceNameListWithOptionsAsync(UploadDeviceNameListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNames))
            {
                body["DeviceNames"] = request.DeviceNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDeviceNameList",
                Version = "2023-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDeviceNameListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadDeviceNameListResponse UploadDeviceNameList(UploadDeviceNameListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDeviceNameListWithOptions(request, runtime);
        }

        public async Task<UploadDeviceNameListResponse> UploadDeviceNameListAsync(UploadDeviceNameListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDeviceNameListWithOptionsAsync(request, runtime);
        }

    }
}
