// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Linkvisual20180120.Models;

namespace AlibabaCloud.SDK.Linkvisual20180120
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

        public AddEventRecordPlanDeviceResponse AddEventRecordPlanDeviceWithOptions(AddEventRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEventRecordPlanDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEventRecordPlanDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddEventRecordPlanDeviceResponse> AddEventRecordPlanDeviceWithOptionsAsync(AddEventRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEventRecordPlanDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEventRecordPlanDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddEventRecordPlanDeviceResponse AddEventRecordPlanDevice(AddEventRecordPlanDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEventRecordPlanDeviceWithOptions(request, runtime);
        }

        public async Task<AddEventRecordPlanDeviceResponse> AddEventRecordPlanDeviceAsync(AddEventRecordPlanDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEventRecordPlanDeviceWithOptionsAsync(request, runtime);
        }

        public AddFaceDeviceGroupResponse AddFaceDeviceGroupWithOptions(AddFaceDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupName))
            {
                query["DeviceGroupName"] = request.DeviceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaceDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFaceDeviceGroupResponse> AddFaceDeviceGroupWithOptionsAsync(AddFaceDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupName))
            {
                query["DeviceGroupName"] = request.DeviceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaceDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFaceDeviceGroupResponse AddFaceDeviceGroup(AddFaceDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFaceDeviceGroupWithOptions(request, runtime);
        }

        public async Task<AddFaceDeviceGroupResponse> AddFaceDeviceGroupAsync(AddFaceDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFaceDeviceGroupWithOptionsAsync(request, runtime);
        }

        public AddFaceDeviceToDeviceGroupResponse AddFaceDeviceToDeviceGroupWithOptions(AddFaceDeviceToDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "AddFaceDeviceToDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceDeviceToDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFaceDeviceToDeviceGroupResponse> AddFaceDeviceToDeviceGroupWithOptionsAsync(AddFaceDeviceToDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "AddFaceDeviceToDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceDeviceToDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFaceDeviceToDeviceGroupResponse AddFaceDeviceToDeviceGroup(AddFaceDeviceToDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFaceDeviceToDeviceGroupWithOptions(request, runtime);
        }

        public async Task<AddFaceDeviceToDeviceGroupResponse> AddFaceDeviceToDeviceGroupAsync(AddFaceDeviceToDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFaceDeviceToDeviceGroupWithOptionsAsync(request, runtime);
        }

        public AddFaceUserResponse AddFaceUserWithOptions(AddFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                query["FacePicUrl"] = request.FacePicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaceUser",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFaceUserResponse> AddFaceUserWithOptionsAsync(AddFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                query["FacePicUrl"] = request.FacePicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaceUser",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFaceUserResponse AddFaceUser(AddFaceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFaceUserWithOptions(request, runtime);
        }

        public async Task<AddFaceUserResponse> AddFaceUserAsync(AddFaceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFaceUserWithOptionsAsync(request, runtime);
        }

        public AddFaceUserGroupResponse AddFaceUserGroupWithOptions(AddFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupName))
            {
                query["UserGroupName"] = request.UserGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaceUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFaceUserGroupResponse> AddFaceUserGroupWithOptionsAsync(AddFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupName))
            {
                query["UserGroupName"] = request.UserGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaceUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFaceUserGroupResponse AddFaceUserGroup(AddFaceUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFaceUserGroupWithOptions(request, runtime);
        }

        public async Task<AddFaceUserGroupResponse> AddFaceUserGroupAsync(AddFaceUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFaceUserGroupWithOptionsAsync(request, runtime);
        }

        public AddFaceUserGroupAndDeviceGroupRelationResponse AddFaceUserGroupAndDeviceGroupRelationWithOptions(AddFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Relation))
            {
                query["Relation"] = request.Relation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaceUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserGroupAndDeviceGroupRelationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFaceUserGroupAndDeviceGroupRelationResponse> AddFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(AddFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Relation))
            {
                query["Relation"] = request.Relation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFaceUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserGroupAndDeviceGroupRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFaceUserGroupAndDeviceGroupRelationResponse AddFaceUserGroupAndDeviceGroupRelation(AddFaceUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFaceUserGroupAndDeviceGroupRelationWithOptions(request, runtime);
        }

        public async Task<AddFaceUserGroupAndDeviceGroupRelationResponse> AddFaceUserGroupAndDeviceGroupRelationAsync(AddFaceUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(request, runtime);
        }

        public AddFaceUserPictureResponse AddFaceUserPictureWithOptions(AddFaceUserPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                query["FacePicUrl"] = request.FacePicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "AddFaceUserPicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserPictureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFaceUserPictureResponse> AddFaceUserPictureWithOptionsAsync(AddFaceUserPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                query["FacePicUrl"] = request.FacePicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "AddFaceUserPicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserPictureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFaceUserPictureResponse AddFaceUserPicture(AddFaceUserPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFaceUserPictureWithOptions(request, runtime);
        }

        public async Task<AddFaceUserPictureResponse> AddFaceUserPictureAsync(AddFaceUserPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFaceUserPictureWithOptionsAsync(request, runtime);
        }

        public AddFaceUserToUserGroupResponse AddFaceUserToUserGroupWithOptions(AddFaceUserToUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
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
                Action = "AddFaceUserToUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserToUserGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFaceUserToUserGroupResponse> AddFaceUserToUserGroupWithOptionsAsync(AddFaceUserToUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
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
                Action = "AddFaceUserToUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFaceUserToUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFaceUserToUserGroupResponse AddFaceUserToUserGroup(AddFaceUserToUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFaceUserToUserGroupWithOptions(request, runtime);
        }

        public async Task<AddFaceUserToUserGroupResponse> AddFaceUserToUserGroupAsync(AddFaceUserToUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFaceUserToUserGroupWithOptionsAsync(request, runtime);
        }

        public AddRecordPlanDeviceResponse AddRecordPlanDeviceWithOptions(AddRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRecordPlanDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRecordPlanDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddRecordPlanDeviceResponse> AddRecordPlanDeviceWithOptionsAsync(AddRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRecordPlanDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRecordPlanDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddRecordPlanDeviceResponse AddRecordPlanDevice(AddRecordPlanDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRecordPlanDeviceWithOptions(request, runtime);
        }

        public async Task<AddRecordPlanDeviceResponse> AddRecordPlanDeviceAsync(AddRecordPlanDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRecordPlanDeviceWithOptionsAsync(request, runtime);
        }

        public BatchQueryVisionDeviceInfoResponse BatchQueryVisionDeviceInfoWithOptions(BatchQueryVisionDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNameList))
            {
                query["DeviceNameList"] = request.DeviceNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdList))
            {
                query["IotIdList"] = request.IotIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "BatchQueryVisionDeviceInfo",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryVisionDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchQueryVisionDeviceInfoResponse> BatchQueryVisionDeviceInfoWithOptionsAsync(BatchQueryVisionDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNameList))
            {
                query["DeviceNameList"] = request.DeviceNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotIdList))
            {
                query["IotIdList"] = request.IotIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "BatchQueryVisionDeviceInfo",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryVisionDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchQueryVisionDeviceInfoResponse BatchQueryVisionDeviceInfo(BatchQueryVisionDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQueryVisionDeviceInfoWithOptions(request, runtime);
        }

        public async Task<BatchQueryVisionDeviceInfoResponse> BatchQueryVisionDeviceInfoAsync(BatchQueryVisionDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQueryVisionDeviceInfoWithOptionsAsync(request, runtime);
        }

        public BindPictureSearchAppWithDevicesResponse BindPictureSearchAppWithDevicesWithOptions(BindPictureSearchAppWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIotIds))
            {
                query["DeviceIotIds"] = request.DeviceIotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPictureSearchAppWithDevices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPictureSearchAppWithDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindPictureSearchAppWithDevicesResponse> BindPictureSearchAppWithDevicesWithOptionsAsync(BindPictureSearchAppWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIotIds))
            {
                query["DeviceIotIds"] = request.DeviceIotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPictureSearchAppWithDevices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPictureSearchAppWithDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindPictureSearchAppWithDevicesResponse BindPictureSearchAppWithDevices(BindPictureSearchAppWithDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPictureSearchAppWithDevicesWithOptions(request, runtime);
        }

        public async Task<BindPictureSearchAppWithDevicesResponse> BindPictureSearchAppWithDevicesAsync(BindPictureSearchAppWithDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPictureSearchAppWithDevicesWithOptionsAsync(request, runtime);
        }

        public CheckFaceUserDoExistOnDeviceResponse CheckFaceUserDoExistOnDeviceWithOptions(CheckFaceUserDoExistOnDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
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
                Action = "CheckFaceUserDoExistOnDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFaceUserDoExistOnDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckFaceUserDoExistOnDeviceResponse> CheckFaceUserDoExistOnDeviceWithOptionsAsync(CheckFaceUserDoExistOnDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
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
                Action = "CheckFaceUserDoExistOnDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckFaceUserDoExistOnDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckFaceUserDoExistOnDeviceResponse CheckFaceUserDoExistOnDevice(CheckFaceUserDoExistOnDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFaceUserDoExistOnDeviceWithOptions(request, runtime);
        }

        public async Task<CheckFaceUserDoExistOnDeviceResponse> CheckFaceUserDoExistOnDeviceAsync(CheckFaceUserDoExistOnDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFaceUserDoExistOnDeviceWithOptionsAsync(request, runtime);
        }

        public ClearFaceDeviceDBResponse ClearFaceDeviceDBWithOptions(ClearFaceDeviceDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "ClearFaceDeviceDB",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearFaceDeviceDBResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ClearFaceDeviceDBResponse> ClearFaceDeviceDBWithOptionsAsync(ClearFaceDeviceDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "ClearFaceDeviceDB",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearFaceDeviceDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ClearFaceDeviceDBResponse ClearFaceDeviceDB(ClearFaceDeviceDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearFaceDeviceDBWithOptions(request, runtime);
        }

        public async Task<ClearFaceDeviceDBResponse> ClearFaceDeviceDBAsync(ClearFaceDeviceDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearFaceDeviceDBWithOptionsAsync(request, runtime);
        }

        public CreateEventRecordPlanResponse CreateEventRecordPlanWithOptions(CreateEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypes))
            {
                query["EventTypes"] = request.EventTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordDuration))
            {
                query["RecordDuration"] = request.RecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventRecordPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEventRecordPlanResponse> CreateEventRecordPlanWithOptionsAsync(CreateEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypes))
            {
                query["EventTypes"] = request.EventTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordDuration))
            {
                query["RecordDuration"] = request.RecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventRecordPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEventRecordPlanResponse CreateEventRecordPlan(CreateEventRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventRecordPlanWithOptions(request, runtime);
        }

        public async Task<CreateEventRecordPlanResponse> CreateEventRecordPlanAsync(CreateEventRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventRecordPlanWithOptionsAsync(request, runtime);
        }

        public CreateGbDeviceResponse CreateGbDeviceWithOptions(CreateGbDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GbId))
            {
                query["GbId"] = request.GbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNetProtocol))
            {
                query["MediaNetProtocol"] = request.MediaNetProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubProductKey))
            {
                query["SubProductKey"] = request.SubProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGbDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGbDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGbDeviceResponse> CreateGbDeviceWithOptionsAsync(CreateGbDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GbId))
            {
                query["GbId"] = request.GbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaNetProtocol))
            {
                query["MediaNetProtocol"] = request.MediaNetProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubProductKey))
            {
                query["SubProductKey"] = request.SubProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGbDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGbDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGbDeviceResponse CreateGbDevice(CreateGbDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGbDeviceWithOptions(request, runtime);
        }

        public async Task<CreateGbDeviceResponse> CreateGbDeviceAsync(CreateGbDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGbDeviceWithOptionsAsync(request, runtime);
        }

        public CreateLocalFileUploadJobResponse CreateLocalFileUploadJobWithOptions(CreateLocalFileUploadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSlot))
            {
                query["TimeSlot"] = request.TimeSlot;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLocalFileUploadJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLocalFileUploadJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLocalFileUploadJobResponse> CreateLocalFileUploadJobWithOptionsAsync(CreateLocalFileUploadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSlot))
            {
                query["TimeSlot"] = request.TimeSlot;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLocalFileUploadJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLocalFileUploadJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLocalFileUploadJobResponse CreateLocalFileUploadJob(CreateLocalFileUploadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLocalFileUploadJobWithOptions(request, runtime);
        }

        public async Task<CreateLocalFileUploadJobResponse> CreateLocalFileUploadJobAsync(CreateLocalFileUploadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLocalFileUploadJobWithOptionsAsync(request, runtime);
        }

        public CreateLocalRecordDownloadByTimeJobResponse CreateLocalRecordDownloadByTimeJobWithOptions(CreateLocalRecordDownloadByTimeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLocalRecordDownloadByTimeJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLocalRecordDownloadByTimeJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLocalRecordDownloadByTimeJobResponse> CreateLocalRecordDownloadByTimeJobWithOptionsAsync(CreateLocalRecordDownloadByTimeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLocalRecordDownloadByTimeJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLocalRecordDownloadByTimeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLocalRecordDownloadByTimeJobResponse CreateLocalRecordDownloadByTimeJob(CreateLocalRecordDownloadByTimeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLocalRecordDownloadByTimeJobWithOptions(request, runtime);
        }

        public async Task<CreateLocalRecordDownloadByTimeJobResponse> CreateLocalRecordDownloadByTimeJobAsync(CreateLocalRecordDownloadByTimeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLocalRecordDownloadByTimeJobWithOptionsAsync(request, runtime);
        }

        public CreatePictureSearchAppResponse CreatePictureSearchAppWithOptions(CreatePictureSearchAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePictureSearchApp",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePictureSearchAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePictureSearchAppResponse> CreatePictureSearchAppWithOptionsAsync(CreatePictureSearchAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                query["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePictureSearchApp",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePictureSearchAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreatePictureSearchAppResponse CreatePictureSearchApp(CreatePictureSearchAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePictureSearchAppWithOptions(request, runtime);
        }

        public async Task<CreatePictureSearchAppResponse> CreatePictureSearchAppAsync(CreatePictureSearchAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePictureSearchAppWithOptionsAsync(request, runtime);
        }

        public CreatePictureSearchJobResponse CreatePictureSearchJobWithOptions(CreatePictureSearchJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyThreshold))
            {
                query["BodyThreshold"] = request.BodyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSearchType))
            {
                query["PictureSearchType"] = request.PictureSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPicUrl))
            {
                query["SearchPicUrl"] = request.SearchPicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePictureSearchJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePictureSearchJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePictureSearchJobResponse> CreatePictureSearchJobWithOptionsAsync(CreatePictureSearchJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyThreshold))
            {
                query["BodyThreshold"] = request.BodyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSearchType))
            {
                query["PictureSearchType"] = request.PictureSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPicUrl))
            {
                query["SearchPicUrl"] = request.SearchPicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePictureSearchJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePictureSearchJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreatePictureSearchJobResponse CreatePictureSearchJob(CreatePictureSearchJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePictureSearchJobWithOptions(request, runtime);
        }

        public async Task<CreatePictureSearchJobResponse> CreatePictureSearchJobAsync(CreatePictureSearchJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePictureSearchJobWithOptionsAsync(request, runtime);
        }

        public CreateRecordDownloadByTimeJobResponse CreateRecordDownloadByTimeJobWithOptions(CreateRecordDownloadByTimeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordType))
            {
                query["RecordType"] = request.RecordType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecordDownloadByTimeJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecordDownloadByTimeJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRecordDownloadByTimeJobResponse> CreateRecordDownloadByTimeJobWithOptionsAsync(CreateRecordDownloadByTimeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordType))
            {
                query["RecordType"] = request.RecordType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecordDownloadByTimeJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecordDownloadByTimeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRecordDownloadByTimeJobResponse CreateRecordDownloadByTimeJob(CreateRecordDownloadByTimeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecordDownloadByTimeJobWithOptions(request, runtime);
        }

        public async Task<CreateRecordDownloadByTimeJobResponse> CreateRecordDownloadByTimeJobAsync(CreateRecordDownloadByTimeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecordDownloadByTimeJobWithOptionsAsync(request, runtime);
        }

        public CreateRecordPlanResponse CreateRecordPlanWithOptions(CreateRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecordPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRecordPlanResponse> CreateRecordPlanWithOptionsAsync(CreateRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecordPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRecordPlanResponse CreateRecordPlan(CreateRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecordPlanWithOptions(request, runtime);
        }

        public async Task<CreateRecordPlanResponse> CreateRecordPlanAsync(CreateRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecordPlanWithOptionsAsync(request, runtime);
        }

        public CreateRtmpDeviceResponse CreateRtmpDeviceWithOptions(CreateRtmpDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullAuthKey))
            {
                query["PullAuthKey"] = request.PullAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullKeyExpireTime))
            {
                query["PullKeyExpireTime"] = request.PullKeyExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAuthKey))
            {
                query["PushAuthKey"] = request.PushAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushKeyExpireTime))
            {
                query["PushKeyExpireTime"] = request.PushKeyExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubStreamName))
            {
                query["SubStreamName"] = request.SubStreamName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRtmpDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRtmpDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRtmpDeviceResponse> CreateRtmpDeviceWithOptionsAsync(CreateRtmpDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullAuthKey))
            {
                query["PullAuthKey"] = request.PullAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullKeyExpireTime))
            {
                query["PullKeyExpireTime"] = request.PullKeyExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAuthKey))
            {
                query["PushAuthKey"] = request.PushAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushKeyExpireTime))
            {
                query["PushKeyExpireTime"] = request.PushKeyExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubStreamName))
            {
                query["SubStreamName"] = request.SubStreamName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRtmpDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRtmpDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRtmpDeviceResponse CreateRtmpDevice(CreateRtmpDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRtmpDeviceWithOptions(request, runtime);
        }

        public async Task<CreateRtmpDeviceResponse> CreateRtmpDeviceAsync(CreateRtmpDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRtmpDeviceWithOptionsAsync(request, runtime);
        }

        public CreateTimeTemplateResponse CreateTimeTemplateWithOptions(CreateTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDay))
            {
                query["AllDay"] = request.AllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSections))
            {
                query["TimeSections"] = request.TimeSections;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTimeTemplate",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTimeTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTimeTemplateResponse> CreateTimeTemplateWithOptionsAsync(CreateTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDay))
            {
                query["AllDay"] = request.AllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSections))
            {
                query["TimeSections"] = request.TimeSections;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTimeTemplate",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTimeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTimeTemplateResponse CreateTimeTemplate(CreateTimeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTimeTemplateWithOptions(request, runtime);
        }

        public async Task<CreateTimeTemplateResponse> CreateTimeTemplateAsync(CreateTimeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTimeTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteEventRecordPlanResponse DeleteEventRecordPlanWithOptions(DeleteEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventRecordPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEventRecordPlanResponse> DeleteEventRecordPlanWithOptionsAsync(DeleteEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventRecordPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEventRecordPlanResponse DeleteEventRecordPlan(DeleteEventRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventRecordPlanWithOptions(request, runtime);
        }

        public async Task<DeleteEventRecordPlanResponse> DeleteEventRecordPlanAsync(DeleteEventRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventRecordPlanWithOptionsAsync(request, runtime);
        }

        public DeleteEventRecordPlanDeviceResponse DeleteEventRecordPlanDeviceWithOptions(DeleteEventRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventRecordPlanDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventRecordPlanDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEventRecordPlanDeviceResponse> DeleteEventRecordPlanDeviceWithOptionsAsync(DeleteEventRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventRecordPlanDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventRecordPlanDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEventRecordPlanDeviceResponse DeleteEventRecordPlanDevice(DeleteEventRecordPlanDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventRecordPlanDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteEventRecordPlanDeviceResponse> DeleteEventRecordPlanDeviceAsync(DeleteEventRecordPlanDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventRecordPlanDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteFaceDeviceGroupResponse DeleteFaceDeviceGroupWithOptions(DeleteFaceDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFaceDeviceGroupResponse> DeleteFaceDeviceGroupWithOptionsAsync(DeleteFaceDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFaceDeviceGroupResponse DeleteFaceDeviceGroup(DeleteFaceDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceDeviceGroupWithOptions(request, runtime);
        }

        public async Task<DeleteFaceDeviceGroupResponse> DeleteFaceDeviceGroupAsync(DeleteFaceDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceDeviceGroupWithOptionsAsync(request, runtime);
        }

        public DeleteFaceUserResponse DeleteFaceUserWithOptions(DeleteFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "DeleteFaceUser",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFaceUserResponse> DeleteFaceUserWithOptionsAsync(DeleteFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "DeleteFaceUser",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFaceUserResponse DeleteFaceUser(DeleteFaceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceUserWithOptions(request, runtime);
        }

        public async Task<DeleteFaceUserResponse> DeleteFaceUserAsync(DeleteFaceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceUserWithOptionsAsync(request, runtime);
        }

        public DeleteFaceUserGroupResponse DeleteFaceUserGroupWithOptions(DeleteFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceUserGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFaceUserGroupResponse> DeleteFaceUserGroupWithOptionsAsync(DeleteFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFaceUserGroupResponse DeleteFaceUserGroup(DeleteFaceUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceUserGroupWithOptions(request, runtime);
        }

        public async Task<DeleteFaceUserGroupResponse> DeleteFaceUserGroupAsync(DeleteFaceUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceUserGroupWithOptionsAsync(request, runtime);
        }

        public DeleteFaceUserGroupAndDeviceGroupRelationResponse DeleteFaceUserGroupAndDeviceGroupRelationWithOptions(DeleteFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlId))
            {
                query["ControlId"] = request.ControlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceUserGroupAndDeviceGroupRelationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFaceUserGroupAndDeviceGroupRelationResponse> DeleteFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(DeleteFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlId))
            {
                query["ControlId"] = request.ControlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFaceUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceUserGroupAndDeviceGroupRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFaceUserGroupAndDeviceGroupRelationResponse DeleteFaceUserGroupAndDeviceGroupRelation(DeleteFaceUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceUserGroupAndDeviceGroupRelationWithOptions(request, runtime);
        }

        public async Task<DeleteFaceUserGroupAndDeviceGroupRelationResponse> DeleteFaceUserGroupAndDeviceGroupRelationAsync(DeleteFaceUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(request, runtime);
        }

        public DeleteFaceUserPictureResponse DeleteFaceUserPictureWithOptions(DeleteFaceUserPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicMd5))
            {
                query["FacePicMd5"] = request.FacePicMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "DeleteFaceUserPicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceUserPictureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFaceUserPictureResponse> DeleteFaceUserPictureWithOptionsAsync(DeleteFaceUserPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicMd5))
            {
                query["FacePicMd5"] = request.FacePicMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "DeleteFaceUserPicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFaceUserPictureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFaceUserPictureResponse DeleteFaceUserPicture(DeleteFaceUserPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFaceUserPictureWithOptions(request, runtime);
        }

        public async Task<DeleteFaceUserPictureResponse> DeleteFaceUserPictureAsync(DeleteFaceUserPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFaceUserPictureWithOptionsAsync(request, runtime);
        }

        public DeleteLocalFileUploadJobResponse DeleteLocalFileUploadJobWithOptions(DeleteLocalFileUploadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLocalFileUploadJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLocalFileUploadJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteLocalFileUploadJobResponse> DeleteLocalFileUploadJobWithOptionsAsync(DeleteLocalFileUploadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLocalFileUploadJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLocalFileUploadJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteLocalFileUploadJobResponse DeleteLocalFileUploadJob(DeleteLocalFileUploadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLocalFileUploadJobWithOptions(request, runtime);
        }

        public async Task<DeleteLocalFileUploadJobResponse> DeleteLocalFileUploadJobAsync(DeleteLocalFileUploadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLocalFileUploadJobWithOptionsAsync(request, runtime);
        }

        public DeletePictureResponse DeletePictureWithOptions(DeletePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureIdList))
            {
                query["PictureIdList"] = request.PictureIdList;
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
                Action = "DeletePicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePictureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePictureResponse> DeletePictureWithOptionsAsync(DeletePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureIdList))
            {
                query["PictureIdList"] = request.PictureIdList;
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
                Action = "DeletePicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePictureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeletePictureResponse DeletePicture(DeletePictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePictureWithOptions(request, runtime);
        }

        public async Task<DeletePictureResponse> DeletePictureAsync(DeletePictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePictureWithOptionsAsync(request, runtime);
        }

        public DeleteRecordResponse DeleteRecordWithOptions(DeleteRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameList))
            {
                query["FileNameList"] = request.FileNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "DeleteRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRecordResponse> DeleteRecordWithOptionsAsync(DeleteRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameList))
            {
                query["FileNameList"] = request.FileNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "DeleteRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRecordResponse DeleteRecord(DeleteRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordWithOptions(request, runtime);
        }

        public async Task<DeleteRecordResponse> DeleteRecordAsync(DeleteRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordWithOptionsAsync(request, runtime);
        }

        public DeleteRecordPlanResponse DeleteRecordPlanWithOptions(DeleteRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRecordPlanResponse> DeleteRecordPlanWithOptionsAsync(DeleteRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRecordPlanResponse DeleteRecordPlan(DeleteRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordPlanWithOptions(request, runtime);
        }

        public async Task<DeleteRecordPlanResponse> DeleteRecordPlanAsync(DeleteRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordPlanWithOptionsAsync(request, runtime);
        }

        public DeleteRecordPlanDeviceResponse DeleteRecordPlanDeviceWithOptions(DeleteRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecordPlanDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordPlanDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRecordPlanDeviceResponse> DeleteRecordPlanDeviceWithOptionsAsync(DeleteRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecordPlanDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordPlanDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRecordPlanDeviceResponse DeleteRecordPlanDevice(DeleteRecordPlanDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecordPlanDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteRecordPlanDeviceResponse> DeleteRecordPlanDeviceAsync(DeleteRecordPlanDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecordPlanDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteRtmpDeviceResponse DeleteRtmpDeviceWithOptions(DeleteRtmpDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "DeleteRtmpDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRtmpDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRtmpDeviceResponse> DeleteRtmpDeviceWithOptionsAsync(DeleteRtmpDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "DeleteRtmpDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRtmpDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRtmpDeviceResponse DeleteRtmpDevice(DeleteRtmpDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRtmpDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteRtmpDeviceResponse> DeleteRtmpDeviceAsync(DeleteRtmpDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRtmpDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteRtmpKeyResponse DeleteRtmpKeyWithOptions(DeleteRtmpKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
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
                Action = "DeleteRtmpKey",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRtmpKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRtmpKeyResponse> DeleteRtmpKeyWithOptionsAsync(DeleteRtmpKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
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
                Action = "DeleteRtmpKey",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRtmpKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRtmpKeyResponse DeleteRtmpKey(DeleteRtmpKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRtmpKeyWithOptions(request, runtime);
        }

        public async Task<DeleteRtmpKeyResponse> DeleteRtmpKeyAsync(DeleteRtmpKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRtmpKeyWithOptionsAsync(request, runtime);
        }

        public DeleteTimeTemplateResponse DeleteTimeTemplateWithOptions(DeleteTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTimeTemplate",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTimeTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTimeTemplateResponse> DeleteTimeTemplateWithOptionsAsync(DeleteTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTimeTemplate",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTimeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTimeTemplateResponse DeleteTimeTemplate(DeleteTimeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTimeTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteTimeTemplateResponse> DeleteTimeTemplateAsync(DeleteTimeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTimeTemplateWithOptionsAsync(request, runtime);
        }

        public DetectUserFaceByUrlResponse DetectUserFaceByUrlWithOptions(DetectUserFaceByUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                query["FacePicUrl"] = request.FacePicUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectUserFaceByUrl",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectUserFaceByUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectUserFaceByUrlResponse> DetectUserFaceByUrlWithOptionsAsync(DetectUserFaceByUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                query["FacePicUrl"] = request.FacePicUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectUserFaceByUrl",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectUserFaceByUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectUserFaceByUrlResponse DetectUserFaceByUrl(DetectUserFaceByUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectUserFaceByUrlWithOptions(request, runtime);
        }

        public async Task<DetectUserFaceByUrlResponse> DetectUserFaceByUrlAsync(DetectUserFaceByUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectUserFaceByUrlWithOptionsAsync(request, runtime);
        }

        public GetPictureSearchJobStatusResponse GetPictureSearchJobStatusWithOptions(GetPictureSearchJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPictureSearchJobStatus",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPictureSearchJobStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPictureSearchJobStatusResponse> GetPictureSearchJobStatusWithOptionsAsync(GetPictureSearchJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPictureSearchJobStatus",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPictureSearchJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPictureSearchJobStatusResponse GetPictureSearchJobStatus(GetPictureSearchJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPictureSearchJobStatusWithOptions(request, runtime);
        }

        public async Task<GetPictureSearchJobStatusResponse> GetPictureSearchJobStatusAsync(GetPictureSearchJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPictureSearchJobStatusWithOptionsAsync(request, runtime);
        }

        public PictureSearchPictureResponse PictureSearchPictureWithOptions(PictureSearchPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainPicUrl))
            {
                query["ContainPicUrl"] = request.ContainPicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSearchType))
            {
                query["PictureSearchType"] = request.PictureSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPicUrl))
            {
                query["SearchPicUrl"] = request.SearchPicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PictureSearchPicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PictureSearchPictureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PictureSearchPictureResponse> PictureSearchPictureWithOptionsAsync(PictureSearchPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainPicUrl))
            {
                query["ContainPicUrl"] = request.ContainPicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSearchType))
            {
                query["PictureSearchType"] = request.PictureSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchPicUrl))
            {
                query["SearchPicUrl"] = request.SearchPicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PictureSearchPicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PictureSearchPictureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PictureSearchPictureResponse PictureSearchPicture(PictureSearchPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PictureSearchPictureWithOptions(request, runtime);
        }

        public async Task<PictureSearchPictureResponse> PictureSearchPictureAsync(PictureSearchPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PictureSearchPictureWithOptionsAsync(request, runtime);
        }

        public QueryCarProcessEventsResponse QueryCarProcessEventsWithOptions(QueryCarProcessEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaIndex))
            {
                query["AreaIndex"] = request.AreaIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlateNo))
            {
                query["PlateNo"] = request.PlateNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDeviceName))
            {
                query["SubDeviceName"] = request.SubDeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubIotId))
            {
                query["SubIotId"] = request.SubIotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubProductKey))
            {
                query["SubProductKey"] = request.SubProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCarProcessEvents",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCarProcessEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryCarProcessEventsResponse> QueryCarProcessEventsWithOptionsAsync(QueryCarProcessEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaIndex))
            {
                query["AreaIndex"] = request.AreaIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlateNo))
            {
                query["PlateNo"] = request.PlateNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDeviceName))
            {
                query["SubDeviceName"] = request.SubDeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubIotId))
            {
                query["SubIotId"] = request.SubIotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubProductKey))
            {
                query["SubProductKey"] = request.SubProductKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCarProcessEvents",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCarProcessEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryCarProcessEventsResponse QueryCarProcessEvents(QueryCarProcessEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCarProcessEventsWithOptions(request, runtime);
        }

        public async Task<QueryCarProcessEventsResponse> QueryCarProcessEventsAsync(QueryCarProcessEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCarProcessEventsWithOptionsAsync(request, runtime);
        }

        public QueryDeviceEventResponse QueryDeviceEventWithOptions(QueryDeviceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryDeviceEvent",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceEventResponse> QueryDeviceEventWithOptionsAsync(QueryDeviceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryDeviceEvent",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceEventResponse QueryDeviceEvent(QueryDeviceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceEventWithOptions(request, runtime);
        }

        public async Task<QueryDeviceEventResponse> QueryDeviceEventAsync(QueryDeviceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceEventWithOptionsAsync(request, runtime);
        }

        public QueryDeviceEventPictureResponse QueryDeviceEventPictureWithOptions(QueryDeviceEventPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryDeviceEventPicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceEventPictureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceEventPictureResponse> QueryDeviceEventPictureWithOptionsAsync(QueryDeviceEventPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryDeviceEventPicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceEventPictureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceEventPictureResponse QueryDeviceEventPicture(QueryDeviceEventPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceEventPictureWithOptions(request, runtime);
        }

        public async Task<QueryDeviceEventPictureResponse> QueryDeviceEventPictureAsync(QueryDeviceEventPictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceEventPictureWithOptionsAsync(request, runtime);
        }

        public QueryDeviceEventRecordResponse QueryDeviceEventRecordWithOptions(QueryDeviceEventRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryDeviceEventRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceEventRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceEventRecordResponse> QueryDeviceEventRecordWithOptionsAsync(QueryDeviceEventRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryDeviceEventRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceEventRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceEventRecordResponse QueryDeviceEventRecord(QueryDeviceEventRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceEventRecordWithOptions(request, runtime);
        }

        public async Task<QueryDeviceEventRecordResponse> QueryDeviceEventRecordAsync(QueryDeviceEventRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceEventRecordWithOptionsAsync(request, runtime);
        }

        public QueryDevicePictureByListResponse QueryDevicePictureByListWithOptions(QueryDevicePictureByListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureIdList))
            {
                query["PictureIdList"] = request.PictureIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureType))
            {
                query["PictureType"] = request.PictureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbWidth))
            {
                query["ThumbWidth"] = request.ThumbWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicePictureByList",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePictureByListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDevicePictureByListResponse> QueryDevicePictureByListWithOptionsAsync(QueryDevicePictureByListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureIdList))
            {
                query["PictureIdList"] = request.PictureIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureType))
            {
                query["PictureType"] = request.PictureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbWidth))
            {
                query["ThumbWidth"] = request.ThumbWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicePictureByList",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePictureByListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDevicePictureByListResponse QueryDevicePictureByList(QueryDevicePictureByListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePictureByListWithOptions(request, runtime);
        }

        public async Task<QueryDevicePictureByListResponse> QueryDevicePictureByListAsync(QueryDevicePictureByListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePictureByListWithOptionsAsync(request, runtime);
        }

        public QueryDevicePictureFileResponse QueryDevicePictureFileWithOptions(QueryDevicePictureFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaptureId))
            {
                query["CaptureId"] = request.CaptureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureType))
            {
                query["PictureType"] = request.PictureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbWidth))
            {
                query["ThumbWidth"] = request.ThumbWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicePictureFile",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePictureFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDevicePictureFileResponse> QueryDevicePictureFileWithOptionsAsync(QueryDevicePictureFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaptureId))
            {
                query["CaptureId"] = request.CaptureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureType))
            {
                query["PictureType"] = request.PictureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbWidth))
            {
                query["ThumbWidth"] = request.ThumbWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicePictureFile",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePictureFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDevicePictureFileResponse QueryDevicePictureFile(QueryDevicePictureFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePictureFileWithOptions(request, runtime);
        }

        public async Task<QueryDevicePictureFileResponse> QueryDevicePictureFileAsync(QueryDevicePictureFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePictureFileWithOptionsAsync(request, runtime);
        }

        public QueryDevicePictureLifeCycleResponse QueryDevicePictureLifeCycleWithOptions(QueryDevicePictureLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicePictureLifeCycle",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePictureLifeCycleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDevicePictureLifeCycleResponse> QueryDevicePictureLifeCycleWithOptionsAsync(QueryDevicePictureLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicePictureLifeCycle",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePictureLifeCycleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDevicePictureLifeCycleResponse QueryDevicePictureLifeCycle(QueryDevicePictureLifeCycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePictureLifeCycleWithOptions(request, runtime);
        }

        public async Task<QueryDevicePictureLifeCycleResponse> QueryDevicePictureLifeCycleAsync(QueryDevicePictureLifeCycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePictureLifeCycleWithOptionsAsync(request, runtime);
        }

        public QueryDeviceRecordLifeCycleResponse QueryDeviceRecordLifeCycleWithOptions(QueryDeviceRecordLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceList))
            {
                query["DeviceList"] = request.DeviceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceRecordLifeCycle",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceRecordLifeCycleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceRecordLifeCycleResponse> QueryDeviceRecordLifeCycleWithOptionsAsync(QueryDeviceRecordLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceList))
            {
                query["DeviceList"] = request.DeviceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceRecordLifeCycle",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceRecordLifeCycleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceRecordLifeCycleResponse QueryDeviceRecordLifeCycle(QueryDeviceRecordLifeCycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceRecordLifeCycleWithOptions(request, runtime);
        }

        public async Task<QueryDeviceRecordLifeCycleResponse> QueryDeviceRecordLifeCycleAsync(QueryDeviceRecordLifeCycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceRecordLifeCycleWithOptionsAsync(request, runtime);
        }

        public QueryDeviceVodUrlResponse QueryDeviceVodUrlWithOptions(QueryDeviceVodUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStun))
            {
                query["EnableStun"] = request.EnableStun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayUnLimited))
            {
                query["PlayUnLimited"] = request.PlayUnLimited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                query["Scheme"] = request.Scheme;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeekTime))
            {
                query["SeekTime"] = request.SeekTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldEncrypt))
            {
                query["ShouldEncrypt"] = request.ShouldEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceVodUrl",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceVodUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceVodUrlResponse> QueryDeviceVodUrlWithOptionsAsync(QueryDeviceVodUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStun))
            {
                query["EnableStun"] = request.EnableStun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayUnLimited))
            {
                query["PlayUnLimited"] = request.PlayUnLimited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                query["Scheme"] = request.Scheme;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeekTime))
            {
                query["SeekTime"] = request.SeekTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldEncrypt))
            {
                query["ShouldEncrypt"] = request.ShouldEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceVodUrl",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceVodUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceVodUrlResponse QueryDeviceVodUrl(QueryDeviceVodUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceVodUrlWithOptions(request, runtime);
        }

        public async Task<QueryDeviceVodUrlResponse> QueryDeviceVodUrlAsync(QueryDeviceVodUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceVodUrlWithOptionsAsync(request, runtime);
        }

        public QueryDeviceVodUrlByTimeResponse QueryDeviceVodUrlByTimeWithOptions(QueryDeviceVodUrlByTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStun))
            {
                query["EnableStun"] = request.EnableStun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayUnLimited))
            {
                query["PlayUnLimited"] = request.PlayUnLimited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                query["Scheme"] = request.Scheme;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeekTime))
            {
                query["SeekTime"] = request.SeekTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldEncrypt))
            {
                query["ShouldEncrypt"] = request.ShouldEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceVodUrlByTime",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceVodUrlByTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceVodUrlByTimeResponse> QueryDeviceVodUrlByTimeWithOptionsAsync(QueryDeviceVodUrlByTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStun))
            {
                query["EnableStun"] = request.EnableStun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayUnLimited))
            {
                query["PlayUnLimited"] = request.PlayUnLimited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                query["Scheme"] = request.Scheme;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeekTime))
            {
                query["SeekTime"] = request.SeekTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldEncrypt))
            {
                query["ShouldEncrypt"] = request.ShouldEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceVodUrlByTime",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceVodUrlByTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceVodUrlByTimeResponse QueryDeviceVodUrlByTime(QueryDeviceVodUrlByTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceVodUrlByTimeWithOptions(request, runtime);
        }

        public async Task<QueryDeviceVodUrlByTimeResponse> QueryDeviceVodUrlByTimeAsync(QueryDeviceVodUrlByTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceVodUrlByTimeWithOptionsAsync(request, runtime);
        }

        public QueryEventRecordPlanDetailResponse QueryEventRecordPlanDetailWithOptions(QueryEventRecordPlanDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventRecordPlanDetail",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventRecordPlanDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryEventRecordPlanDetailResponse> QueryEventRecordPlanDetailWithOptionsAsync(QueryEventRecordPlanDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventRecordPlanDetail",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventRecordPlanDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryEventRecordPlanDetailResponse QueryEventRecordPlanDetail(QueryEventRecordPlanDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventRecordPlanDetailWithOptions(request, runtime);
        }

        public async Task<QueryEventRecordPlanDetailResponse> QueryEventRecordPlanDetailAsync(QueryEventRecordPlanDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventRecordPlanDetailWithOptionsAsync(request, runtime);
        }

        public QueryEventRecordPlanDeviceByDeviceResponse QueryEventRecordPlanDeviceByDeviceWithOptions(QueryEventRecordPlanDeviceByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventRecordPlanDeviceByDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventRecordPlanDeviceByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryEventRecordPlanDeviceByDeviceResponse> QueryEventRecordPlanDeviceByDeviceWithOptionsAsync(QueryEventRecordPlanDeviceByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventRecordPlanDeviceByDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventRecordPlanDeviceByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryEventRecordPlanDeviceByDeviceResponse QueryEventRecordPlanDeviceByDevice(QueryEventRecordPlanDeviceByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventRecordPlanDeviceByDeviceWithOptions(request, runtime);
        }

        public async Task<QueryEventRecordPlanDeviceByDeviceResponse> QueryEventRecordPlanDeviceByDeviceAsync(QueryEventRecordPlanDeviceByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventRecordPlanDeviceByDeviceWithOptionsAsync(request, runtime);
        }

        public QueryEventRecordPlanDeviceByPlanResponse QueryEventRecordPlanDeviceByPlanWithOptions(QueryEventRecordPlanDeviceByPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventRecordPlanDeviceByPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventRecordPlanDeviceByPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryEventRecordPlanDeviceByPlanResponse> QueryEventRecordPlanDeviceByPlanWithOptionsAsync(QueryEventRecordPlanDeviceByPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventRecordPlanDeviceByPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventRecordPlanDeviceByPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryEventRecordPlanDeviceByPlanResponse QueryEventRecordPlanDeviceByPlan(QueryEventRecordPlanDeviceByPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventRecordPlanDeviceByPlanWithOptions(request, runtime);
        }

        public async Task<QueryEventRecordPlanDeviceByPlanResponse> QueryEventRecordPlanDeviceByPlanAsync(QueryEventRecordPlanDeviceByPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventRecordPlanDeviceByPlanWithOptionsAsync(request, runtime);
        }

        public QueryEventRecordPlansResponse QueryEventRecordPlansWithOptions(QueryEventRecordPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "QueryEventRecordPlans",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventRecordPlansResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryEventRecordPlansResponse> QueryEventRecordPlansWithOptionsAsync(QueryEventRecordPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "QueryEventRecordPlans",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventRecordPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryEventRecordPlansResponse QueryEventRecordPlans(QueryEventRecordPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventRecordPlansWithOptions(request, runtime);
        }

        public async Task<QueryEventRecordPlansResponse> QueryEventRecordPlansAsync(QueryEventRecordPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventRecordPlansWithOptionsAsync(request, runtime);
        }

        public QueryFaceAllDeviceGroupResponse QueryFaceAllDeviceGroupWithOptions(QueryFaceAllDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
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
                Action = "QueryFaceAllDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceAllDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceAllDeviceGroupResponse> QueryFaceAllDeviceGroupWithOptionsAsync(QueryFaceAllDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
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
                Action = "QueryFaceAllDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceAllDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceAllDeviceGroupResponse QueryFaceAllDeviceGroup(QueryFaceAllDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceAllDeviceGroupWithOptions(request, runtime);
        }

        public async Task<QueryFaceAllDeviceGroupResponse> QueryFaceAllDeviceGroupAsync(QueryFaceAllDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceAllDeviceGroupWithOptionsAsync(request, runtime);
        }

        public QueryFaceAllUserGroupResponse QueryFaceAllUserGroupWithOptions(QueryFaceAllUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
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
                Action = "QueryFaceAllUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceAllUserGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceAllUserGroupResponse> QueryFaceAllUserGroupWithOptionsAsync(QueryFaceAllUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
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
                Action = "QueryFaceAllUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceAllUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceAllUserGroupResponse QueryFaceAllUserGroup(QueryFaceAllUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceAllUserGroupWithOptions(request, runtime);
        }

        public async Task<QueryFaceAllUserGroupResponse> QueryFaceAllUserGroupAsync(QueryFaceAllUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceAllUserGroupWithOptionsAsync(request, runtime);
        }

        public QueryFaceAllUserGroupAndDeviceGroupRelationResponse QueryFaceAllUserGroupAndDeviceGroupRelationWithOptions(QueryFaceAllUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
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
                Action = "QueryFaceAllUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceAllUserGroupAndDeviceGroupRelationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceAllUserGroupAndDeviceGroupRelationResponse> QueryFaceAllUserGroupAndDeviceGroupRelationWithOptionsAsync(QueryFaceAllUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
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
                Action = "QueryFaceAllUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceAllUserGroupAndDeviceGroupRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceAllUserGroupAndDeviceGroupRelationResponse QueryFaceAllUserGroupAndDeviceGroupRelation(QueryFaceAllUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceAllUserGroupAndDeviceGroupRelationWithOptions(request, runtime);
        }

        public async Task<QueryFaceAllUserGroupAndDeviceGroupRelationResponse> QueryFaceAllUserGroupAndDeviceGroupRelationAsync(QueryFaceAllUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceAllUserGroupAndDeviceGroupRelationWithOptionsAsync(request, runtime);
        }

        public QueryFaceAllUserIdsByGroupIdResponse QueryFaceAllUserIdsByGroupIdWithOptions(QueryFaceAllUserIdsByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceAllUserIdsByGroupId",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceAllUserIdsByGroupIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceAllUserIdsByGroupIdResponse> QueryFaceAllUserIdsByGroupIdWithOptionsAsync(QueryFaceAllUserIdsByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceAllUserIdsByGroupId",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceAllUserIdsByGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceAllUserIdsByGroupIdResponse QueryFaceAllUserIdsByGroupId(QueryFaceAllUserIdsByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceAllUserIdsByGroupIdWithOptions(request, runtime);
        }

        public async Task<QueryFaceAllUserIdsByGroupIdResponse> QueryFaceAllUserIdsByGroupIdAsync(QueryFaceAllUserIdsByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceAllUserIdsByGroupIdWithOptionsAsync(request, runtime);
        }

        public QueryFaceCustomUserIdByUserIdResponse QueryFaceCustomUserIdByUserIdWithOptions(QueryFaceCustomUserIdByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "QueryFaceCustomUserIdByUserId",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceCustomUserIdByUserIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceCustomUserIdByUserIdResponse> QueryFaceCustomUserIdByUserIdWithOptionsAsync(QueryFaceCustomUserIdByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "QueryFaceCustomUserIdByUserId",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceCustomUserIdByUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceCustomUserIdByUserIdResponse QueryFaceCustomUserIdByUserId(QueryFaceCustomUserIdByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceCustomUserIdByUserIdWithOptions(request, runtime);
        }

        public async Task<QueryFaceCustomUserIdByUserIdResponse> QueryFaceCustomUserIdByUserIdAsync(QueryFaceCustomUserIdByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceCustomUserIdByUserIdWithOptionsAsync(request, runtime);
        }

        public QueryFaceDeviceGroupsByDeviceResponse QueryFaceDeviceGroupsByDeviceWithOptions(QueryFaceDeviceGroupsByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "QueryFaceDeviceGroupsByDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceDeviceGroupsByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceDeviceGroupsByDeviceResponse> QueryFaceDeviceGroupsByDeviceWithOptionsAsync(QueryFaceDeviceGroupsByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "QueryFaceDeviceGroupsByDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceDeviceGroupsByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceDeviceGroupsByDeviceResponse QueryFaceDeviceGroupsByDevice(QueryFaceDeviceGroupsByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceDeviceGroupsByDeviceWithOptions(request, runtime);
        }

        public async Task<QueryFaceDeviceGroupsByDeviceResponse> QueryFaceDeviceGroupsByDeviceAsync(QueryFaceDeviceGroupsByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceDeviceGroupsByDeviceWithOptionsAsync(request, runtime);
        }

        public QueryFaceUserResponse QueryFaceUserWithOptions(QueryFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "QueryFaceUser",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceUserResponse> QueryFaceUserWithOptionsAsync(QueryFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "QueryFaceUser",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceUserResponse QueryFaceUser(QueryFaceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceUserWithOptions(request, runtime);
        }

        public async Task<QueryFaceUserResponse> QueryFaceUserAsync(QueryFaceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceUserWithOptionsAsync(request, runtime);
        }

        public QueryFaceUserBatchResponse QueryFaceUserBatchWithOptions(QueryFaceUserBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceUserBatch",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserBatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceUserBatchResponse> QueryFaceUserBatchWithOptionsAsync(QueryFaceUserBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceUserBatch",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceUserBatchResponse QueryFaceUserBatch(QueryFaceUserBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceUserBatchWithOptions(request, runtime);
        }

        public async Task<QueryFaceUserBatchResponse> QueryFaceUserBatchAsync(QueryFaceUserBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceUserBatchWithOptionsAsync(request, runtime);
        }

        public QueryFaceUserByNameResponse QueryFaceUserByNameWithOptions(QueryFaceUserByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceUserByName",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserByNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceUserByNameResponse> QueryFaceUserByNameWithOptionsAsync(QueryFaceUserByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceUserByName",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserByNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceUserByNameResponse QueryFaceUserByName(QueryFaceUserByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceUserByNameWithOptions(request, runtime);
        }

        public async Task<QueryFaceUserByNameResponse> QueryFaceUserByNameAsync(QueryFaceUserByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceUserByNameWithOptionsAsync(request, runtime);
        }

        public QueryFaceUserGroupResponse QueryFaceUserGroupWithOptions(QueryFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "QueryFaceUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceUserGroupResponse> QueryFaceUserGroupWithOptionsAsync(QueryFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "QueryFaceUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceUserGroupResponse QueryFaceUserGroup(QueryFaceUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceUserGroupWithOptions(request, runtime);
        }

        public async Task<QueryFaceUserGroupResponse> QueryFaceUserGroupAsync(QueryFaceUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceUserGroupWithOptionsAsync(request, runtime);
        }

        public QueryFaceUserGroupAndDeviceGroupRelationResponse QueryFaceUserGroupAndDeviceGroupRelationWithOptions(QueryFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlId))
            {
                query["ControlId"] = request.ControlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserGroupAndDeviceGroupRelationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceUserGroupAndDeviceGroupRelationResponse> QueryFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(QueryFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlId))
            {
                query["ControlId"] = request.ControlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserGroupAndDeviceGroupRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceUserGroupAndDeviceGroupRelationResponse QueryFaceUserGroupAndDeviceGroupRelation(QueryFaceUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceUserGroupAndDeviceGroupRelationWithOptions(request, runtime);
        }

        public async Task<QueryFaceUserGroupAndDeviceGroupRelationResponse> QueryFaceUserGroupAndDeviceGroupRelationAsync(QueryFaceUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(request, runtime);
        }

        public QueryFaceUserIdByCustomUserIdResponse QueryFaceUserIdByCustomUserIdWithOptions(QueryFaceUserIdByCustomUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceUserIdByCustomUserId",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserIdByCustomUserIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFaceUserIdByCustomUserIdResponse> QueryFaceUserIdByCustomUserIdWithOptionsAsync(QueryFaceUserIdByCustomUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFaceUserIdByCustomUserId",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFaceUserIdByCustomUserIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFaceUserIdByCustomUserIdResponse QueryFaceUserIdByCustomUserId(QueryFaceUserIdByCustomUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFaceUserIdByCustomUserIdWithOptions(request, runtime);
        }

        public async Task<QueryFaceUserIdByCustomUserIdResponse> QueryFaceUserIdByCustomUserIdAsync(QueryFaceUserIdByCustomUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFaceUserIdByCustomUserIdWithOptionsAsync(request, runtime);
        }

        public QueryLiveStreamingResponse QueryLiveStreamingWithOptions(QueryLiveStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheDuration))
            {
                query["CacheDuration"] = request.CacheDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStun))
            {
                query["EnableStun"] = request.EnableStun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceIFrame))
            {
                query["ForceIFrame"] = request.ForceIFrame;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayUnLimited))
            {
                query["PlayUnLimited"] = request.PlayUnLimited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                query["Scheme"] = request.Scheme;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldEncrypt))
            {
                query["ShouldEncrypt"] = request.ShouldEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveStreaming",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveStreamingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLiveStreamingResponse> QueryLiveStreamingWithOptionsAsync(QueryLiveStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheDuration))
            {
                query["CacheDuration"] = request.CacheDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStun))
            {
                query["EnableStun"] = request.EnableStun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceIFrame))
            {
                query["ForceIFrame"] = request.ForceIFrame;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayUnLimited))
            {
                query["PlayUnLimited"] = request.PlayUnLimited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                query["Scheme"] = request.Scheme;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShouldEncrypt))
            {
                query["ShouldEncrypt"] = request.ShouldEncrypt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLiveStreaming",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLiveStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLiveStreamingResponse QueryLiveStreaming(QueryLiveStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLiveStreamingWithOptions(request, runtime);
        }

        public async Task<QueryLiveStreamingResponse> QueryLiveStreamingAsync(QueryLiveStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLiveStreamingWithOptionsAsync(request, runtime);
        }

        public QueryLocalFileUploadJobResponse QueryLocalFileUploadJobWithOptions(QueryLocalFileUploadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLocalFileUploadJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLocalFileUploadJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLocalFileUploadJobResponse> QueryLocalFileUploadJobWithOptionsAsync(QueryLocalFileUploadJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLocalFileUploadJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLocalFileUploadJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLocalFileUploadJobResponse QueryLocalFileUploadJob(QueryLocalFileUploadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLocalFileUploadJobWithOptions(request, runtime);
        }

        public async Task<QueryLocalFileUploadJobResponse> QueryLocalFileUploadJobAsync(QueryLocalFileUploadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLocalFileUploadJobWithOptionsAsync(request, runtime);
        }

        public QueryMonthRecordResponse QueryMonthRecordWithOptions(QueryMonthRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
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
                Action = "QueryMonthRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMonthRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMonthRecordResponse> QueryMonthRecordWithOptionsAsync(QueryMonthRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Month))
            {
                query["Month"] = request.Month;
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
                Action = "QueryMonthRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMonthRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMonthRecordResponse QueryMonthRecord(QueryMonthRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMonthRecordWithOptions(request, runtime);
        }

        public async Task<QueryMonthRecordResponse> QueryMonthRecordAsync(QueryMonthRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMonthRecordWithOptionsAsync(request, runtime);
        }

        public QueryPictureFilesResponse QueryPictureFilesWithOptions(QueryPictureFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSource))
            {
                query["PictureSource"] = request.PictureSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureType))
            {
                query["PictureType"] = request.PictureType;
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
                Action = "QueryPictureFiles",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureFilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPictureFilesResponse> QueryPictureFilesWithOptionsAsync(QueryPictureFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureSource))
            {
                query["PictureSource"] = request.PictureSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureType))
            {
                query["PictureType"] = request.PictureType;
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
                Action = "QueryPictureFiles",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPictureFilesResponse QueryPictureFiles(QueryPictureFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPictureFilesWithOptions(request, runtime);
        }

        public async Task<QueryPictureFilesResponse> QueryPictureFilesAsync(QueryPictureFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPictureFilesWithOptionsAsync(request, runtime);
        }

        public QueryPictureSearchAiboxesResponse QueryPictureSearchAiboxesWithOptions(QueryPictureSearchAiboxesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryPictureSearchAiboxes",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchAiboxesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPictureSearchAiboxesResponse> QueryPictureSearchAiboxesWithOptionsAsync(QueryPictureSearchAiboxesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryPictureSearchAiboxes",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchAiboxesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPictureSearchAiboxesResponse QueryPictureSearchAiboxes(QueryPictureSearchAiboxesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPictureSearchAiboxesWithOptions(request, runtime);
        }

        public async Task<QueryPictureSearchAiboxesResponse> QueryPictureSearchAiboxesAsync(QueryPictureSearchAiboxesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPictureSearchAiboxesWithOptionsAsync(request, runtime);
        }

        public QueryPictureSearchAppsResponse QueryPictureSearchAppsWithOptions(QueryPictureSearchAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryPictureSearchApps",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchAppsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPictureSearchAppsResponse> QueryPictureSearchAppsWithOptionsAsync(QueryPictureSearchAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryPictureSearchApps",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPictureSearchAppsResponse QueryPictureSearchApps(QueryPictureSearchAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPictureSearchAppsWithOptions(request, runtime);
        }

        public async Task<QueryPictureSearchAppsResponse> QueryPictureSearchAppsAsync(QueryPictureSearchAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPictureSearchAppsWithOptionsAsync(request, runtime);
        }

        public QueryPictureSearchDevicesResponse QueryPictureSearchDevicesWithOptions(QueryPictureSearchDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "QueryPictureSearchDevices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPictureSearchDevicesResponse> QueryPictureSearchDevicesWithOptionsAsync(QueryPictureSearchDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "QueryPictureSearchDevices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPictureSearchDevicesResponse QueryPictureSearchDevices(QueryPictureSearchDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPictureSearchDevicesWithOptions(request, runtime);
        }

        public async Task<QueryPictureSearchDevicesResponse> QueryPictureSearchDevicesAsync(QueryPictureSearchDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPictureSearchDevicesWithOptionsAsync(request, runtime);
        }

        public QueryPictureSearchJobResponse QueryPictureSearchJobWithOptions(QueryPictureSearchJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatus))
            {
                query["JobStatus"] = request.JobStatus;
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
                Action = "QueryPictureSearchJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPictureSearchJobResponse> QueryPictureSearchJobWithOptionsAsync(QueryPictureSearchJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatus))
            {
                query["JobStatus"] = request.JobStatus;
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
                Action = "QueryPictureSearchJob",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPictureSearchJobResponse QueryPictureSearchJob(QueryPictureSearchJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPictureSearchJobWithOptions(request, runtime);
        }

        public async Task<QueryPictureSearchJobResponse> QueryPictureSearchJobAsync(QueryPictureSearchJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPictureSearchJobWithOptionsAsync(request, runtime);
        }

        public QueryPictureSearchJobResultResponse QueryPictureSearchJobResultWithOptions(QueryPictureSearchJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
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
                Action = "QueryPictureSearchJobResult",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchJobResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPictureSearchJobResultResponse> QueryPictureSearchJobResultWithOptionsAsync(QueryPictureSearchJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
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
                Action = "QueryPictureSearchJobResult",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPictureSearchJobResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPictureSearchJobResultResponse QueryPictureSearchJobResult(QueryPictureSearchJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPictureSearchJobResultWithOptions(request, runtime);
        }

        public async Task<QueryPictureSearchJobResultResponse> QueryPictureSearchJobResultAsync(QueryPictureSearchJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPictureSearchJobResultWithOptionsAsync(request, runtime);
        }

        public QueryRecordResponse QueryRecordWithOptions(QueryRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSnapshot))
            {
                query["NeedSnapshot"] = request.NeedSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordType))
            {
                query["RecordType"] = request.RecordType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordResponse> QueryRecordWithOptionsAsync(QueryRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSnapshot))
            {
                query["NeedSnapshot"] = request.NeedSnapshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordType))
            {
                query["RecordType"] = request.RecordType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordResponse QueryRecord(QueryRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordWithOptions(request, runtime);
        }

        public async Task<QueryRecordResponse> QueryRecordAsync(QueryRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordWithOptionsAsync(request, runtime);
        }

        public QueryRecordByRecordIdResponse QueryRecordByRecordIdWithOptions(QueryRecordByRecordIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordByRecordId",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordByRecordIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordByRecordIdResponse> QueryRecordByRecordIdWithOptionsAsync(QueryRecordByRecordIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordByRecordId",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordByRecordIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordByRecordIdResponse QueryRecordByRecordId(QueryRecordByRecordIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordByRecordIdWithOptions(request, runtime);
        }

        public async Task<QueryRecordByRecordIdResponse> QueryRecordByRecordIdAsync(QueryRecordByRecordIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordByRecordIdWithOptionsAsync(request, runtime);
        }

        public QueryRecordDownloadJobByIdResponse QueryRecordDownloadJobByIdWithOptions(QueryRecordDownloadJobByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordDownloadJobById",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordDownloadJobByIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordDownloadJobByIdResponse> QueryRecordDownloadJobByIdWithOptionsAsync(QueryRecordDownloadJobByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordDownloadJobById",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordDownloadJobByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordDownloadJobByIdResponse QueryRecordDownloadJobById(QueryRecordDownloadJobByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordDownloadJobByIdWithOptions(request, runtime);
        }

        public async Task<QueryRecordDownloadJobByIdResponse> QueryRecordDownloadJobByIdAsync(QueryRecordDownloadJobByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordDownloadJobByIdWithOptionsAsync(request, runtime);
        }

        public QueryRecordDownloadJobListResponse QueryRecordDownloadJobListWithOptions(QueryRecordDownloadJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryRecordDownloadJobList",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordDownloadJobListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordDownloadJobListResponse> QueryRecordDownloadJobListWithOptionsAsync(QueryRecordDownloadJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryRecordDownloadJobList",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordDownloadJobListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordDownloadJobListResponse QueryRecordDownloadJobList(QueryRecordDownloadJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordDownloadJobListWithOptions(request, runtime);
        }

        public async Task<QueryRecordDownloadJobListResponse> QueryRecordDownloadJobListAsync(QueryRecordDownloadJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordDownloadJobListWithOptionsAsync(request, runtime);
        }

        public QueryRecordDownloadUrlResponse QueryRecordDownloadUrlWithOptions(QueryRecordDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryRecordDownloadUrl",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordDownloadUrlResponse> QueryRecordDownloadUrlWithOptionsAsync(QueryRecordDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryRecordDownloadUrl",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordDownloadUrlResponse QueryRecordDownloadUrl(QueryRecordDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordDownloadUrlWithOptions(request, runtime);
        }

        public async Task<QueryRecordDownloadUrlResponse> QueryRecordDownloadUrlAsync(QueryRecordDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordDownloadUrlWithOptionsAsync(request, runtime);
        }

        public QueryRecordPlanDetailResponse QueryRecordPlanDetailWithOptions(QueryRecordPlanDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordPlanDetail",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordPlanDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordPlanDetailResponse> QueryRecordPlanDetailWithOptionsAsync(QueryRecordPlanDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordPlanDetail",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordPlanDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordPlanDetailResponse QueryRecordPlanDetail(QueryRecordPlanDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordPlanDetailWithOptions(request, runtime);
        }

        public async Task<QueryRecordPlanDetailResponse> QueryRecordPlanDetailAsync(QueryRecordPlanDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordPlanDetailWithOptionsAsync(request, runtime);
        }

        public QueryRecordPlanDeviceByDeviceResponse QueryRecordPlanDeviceByDeviceWithOptions(QueryRecordPlanDeviceByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordPlanDeviceByDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordPlanDeviceByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordPlanDeviceByDeviceResponse> QueryRecordPlanDeviceByDeviceWithOptionsAsync(QueryRecordPlanDeviceByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordPlanDeviceByDevice",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordPlanDeviceByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordPlanDeviceByDeviceResponse QueryRecordPlanDeviceByDevice(QueryRecordPlanDeviceByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordPlanDeviceByDeviceWithOptions(request, runtime);
        }

        public async Task<QueryRecordPlanDeviceByDeviceResponse> QueryRecordPlanDeviceByDeviceAsync(QueryRecordPlanDeviceByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordPlanDeviceByDeviceWithOptionsAsync(request, runtime);
        }

        public QueryRecordPlanDeviceByPlanResponse QueryRecordPlanDeviceByPlanWithOptions(QueryRecordPlanDeviceByPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordPlanDeviceByPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordPlanDeviceByPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordPlanDeviceByPlanResponse> QueryRecordPlanDeviceByPlanWithOptionsAsync(QueryRecordPlanDeviceByPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordPlanDeviceByPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordPlanDeviceByPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordPlanDeviceByPlanResponse QueryRecordPlanDeviceByPlan(QueryRecordPlanDeviceByPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordPlanDeviceByPlanWithOptions(request, runtime);
        }

        public async Task<QueryRecordPlanDeviceByPlanResponse> QueryRecordPlanDeviceByPlanAsync(QueryRecordPlanDeviceByPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordPlanDeviceByPlanWithOptionsAsync(request, runtime);
        }

        public QueryRecordPlansResponse QueryRecordPlansWithOptions(QueryRecordPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "QueryRecordPlans",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordPlansResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordPlansResponse> QueryRecordPlansWithOptionsAsync(QueryRecordPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "QueryRecordPlans",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordPlansResponse QueryRecordPlans(QueryRecordPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordPlansWithOptions(request, runtime);
        }

        public async Task<QueryRecordPlansResponse> QueryRecordPlansAsync(QueryRecordPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordPlansWithOptionsAsync(request, runtime);
        }

        public QueryRecordUrlResponse QueryRecordUrlWithOptions(QueryRecordUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeekTime))
            {
                query["SeekTime"] = request.SeekTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordUrl",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordUrlResponse> QueryRecordUrlWithOptionsAsync(QueryRecordUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeekTime))
            {
                query["SeekTime"] = request.SeekTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordUrl",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordUrlResponse QueryRecordUrl(QueryRecordUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordUrlWithOptions(request, runtime);
        }

        public async Task<QueryRecordUrlResponse> QueryRecordUrlAsync(QueryRecordUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordUrlWithOptionsAsync(request, runtime);
        }

        public QueryRecordUrlByTimeResponse QueryRecordUrlByTimeWithOptions(QueryRecordUrlByTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordUrlByTime",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordUrlByTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRecordUrlByTimeResponse> QueryRecordUrlByTimeWithOptionsAsync(QueryRecordUrlByTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlValidDuration))
            {
                query["UrlValidDuration"] = request.UrlValidDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRecordUrlByTime",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecordUrlByTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRecordUrlByTimeResponse QueryRecordUrlByTime(QueryRecordUrlByTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordUrlByTimeWithOptions(request, runtime);
        }

        public async Task<QueryRecordUrlByTimeResponse> QueryRecordUrlByTimeAsync(QueryRecordUrlByTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordUrlByTimeWithOptionsAsync(request, runtime);
        }

        public QueryRtmpKeyResponse QueryRtmpKeyWithOptions(QueryRtmpKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryRtmpKey",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRtmpKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRtmpKeyResponse> QueryRtmpKeyWithOptionsAsync(QueryRtmpKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryRtmpKey",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRtmpKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRtmpKeyResponse QueryRtmpKey(QueryRtmpKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRtmpKeyWithOptions(request, runtime);
        }

        public async Task<QueryRtmpKeyResponse> QueryRtmpKeyAsync(QueryRtmpKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRtmpKeyWithOptionsAsync(request, runtime);
        }

        public QueryTimeTemplateResponse QueryTimeTemplateWithOptions(QueryTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "QueryTimeTemplate",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTimeTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTimeTemplateResponse> QueryTimeTemplateWithOptionsAsync(QueryTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "QueryTimeTemplate",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTimeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTimeTemplateResponse QueryTimeTemplate(QueryTimeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTimeTemplateWithOptions(request, runtime);
        }

        public async Task<QueryTimeTemplateResponse> QueryTimeTemplateAsync(QueryTimeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTimeTemplateWithOptionsAsync(request, runtime);
        }

        public QueryTimeTemplateDetailResponse QueryTimeTemplateDetailWithOptions(QueryTimeTemplateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTimeTemplateDetail",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTimeTemplateDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTimeTemplateDetailResponse> QueryTimeTemplateDetailWithOptionsAsync(QueryTimeTemplateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTimeTemplateDetail",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTimeTemplateDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTimeTemplateDetailResponse QueryTimeTemplateDetail(QueryTimeTemplateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTimeTemplateDetailWithOptions(request, runtime);
        }

        public async Task<QueryTimeTemplateDetailResponse> QueryTimeTemplateDetailAsync(QueryTimeTemplateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTimeTemplateDetailWithOptionsAsync(request, runtime);
        }

        public QueryVisionDeviceInfoResponse QueryVisionDeviceInfoWithOptions(QueryVisionDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryVisionDeviceInfo",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVisionDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryVisionDeviceInfoResponse> QueryVisionDeviceInfoWithOptionsAsync(QueryVisionDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "QueryVisionDeviceInfo",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVisionDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryVisionDeviceInfoResponse QueryVisionDeviceInfo(QueryVisionDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVisionDeviceInfoWithOptions(request, runtime);
        }

        public async Task<QueryVisionDeviceInfoResponse> QueryVisionDeviceInfoAsync(QueryVisionDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVisionDeviceInfoWithOptionsAsync(request, runtime);
        }

        public QueryVoiceIntercomResponse QueryVoiceIntercomWithOptions(QueryVoiceIntercomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                query["Scheme"] = request.Scheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVoiceIntercom",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVoiceIntercomResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryVoiceIntercomResponse> QueryVoiceIntercomWithOptionsAsync(QueryVoiceIntercomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scheme))
            {
                query["Scheme"] = request.Scheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVoiceIntercom",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVoiceIntercomResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryVoiceIntercomResponse QueryVoiceIntercom(QueryVoiceIntercomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVoiceIntercomWithOptions(request, runtime);
        }

        public async Task<QueryVoiceIntercomResponse> QueryVoiceIntercomAsync(QueryVoiceIntercomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVoiceIntercomWithOptionsAsync(request, runtime);
        }

        public RemoveFaceDeviceFromDeviceGroupResponse RemoveFaceDeviceFromDeviceGroupWithOptions(RemoveFaceDeviceFromDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "RemoveFaceDeviceFromDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFaceDeviceFromDeviceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveFaceDeviceFromDeviceGroupResponse> RemoveFaceDeviceFromDeviceGroupWithOptionsAsync(RemoveFaceDeviceFromDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                query["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
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
                Action = "RemoveFaceDeviceFromDeviceGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFaceDeviceFromDeviceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveFaceDeviceFromDeviceGroupResponse RemoveFaceDeviceFromDeviceGroup(RemoveFaceDeviceFromDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveFaceDeviceFromDeviceGroupWithOptions(request, runtime);
        }

        public async Task<RemoveFaceDeviceFromDeviceGroupResponse> RemoveFaceDeviceFromDeviceGroupAsync(RemoveFaceDeviceFromDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveFaceDeviceFromDeviceGroupWithOptionsAsync(request, runtime);
        }

        public RemoveFaceUserFromUserGroupResponse RemoveFaceUserFromUserGroupWithOptions(RemoveFaceUserFromUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
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
                Action = "RemoveFaceUserFromUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFaceUserFromUserGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveFaceUserFromUserGroupResponse> RemoveFaceUserFromUserGroupWithOptionsAsync(RemoveFaceUserFromUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                query["UserGroupId"] = request.UserGroupId;
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
                Action = "RemoveFaceUserFromUserGroup",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFaceUserFromUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveFaceUserFromUserGroupResponse RemoveFaceUserFromUserGroup(RemoveFaceUserFromUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveFaceUserFromUserGroupWithOptions(request, runtime);
        }

        public async Task<RemoveFaceUserFromUserGroupResponse> RemoveFaceUserFromUserGroupAsync(RemoveFaceUserFromUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveFaceUserFromUserGroupWithOptionsAsync(request, runtime);
        }

        public SetDevicePictureLifeCycleResponse SetDevicePictureLifeCycleWithOptions(SetDevicePictureLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Day))
            {
                query["Day"] = request.Day;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "SetDevicePictureLifeCycle",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDevicePictureLifeCycleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDevicePictureLifeCycleResponse> SetDevicePictureLifeCycleWithOptionsAsync(SetDevicePictureLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Day))
            {
                query["Day"] = request.Day;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "SetDevicePictureLifeCycle",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDevicePictureLifeCycleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDevicePictureLifeCycleResponse SetDevicePictureLifeCycle(SetDevicePictureLifeCycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDevicePictureLifeCycleWithOptions(request, runtime);
        }

        public async Task<SetDevicePictureLifeCycleResponse> SetDevicePictureLifeCycleAsync(SetDevicePictureLifeCycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDevicePictureLifeCycleWithOptionsAsync(request, runtime);
        }

        public SetDeviceRecordLifeCycleResponse SetDeviceRecordLifeCycleWithOptions(SetDeviceRecordLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Day))
            {
                query["Day"] = request.Day;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "SetDeviceRecordLifeCycle",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeviceRecordLifeCycleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDeviceRecordLifeCycleResponse> SetDeviceRecordLifeCycleWithOptionsAsync(SetDeviceRecordLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Day))
            {
                query["Day"] = request.Day;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotId))
            {
                query["IotId"] = request.IotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "SetDeviceRecordLifeCycle",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeviceRecordLifeCycleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDeviceRecordLifeCycleResponse SetDeviceRecordLifeCycle(SetDeviceRecordLifeCycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeviceRecordLifeCycleWithOptions(request, runtime);
        }

        public async Task<SetDeviceRecordLifeCycleResponse> SetDeviceRecordLifeCycleAsync(SetDeviceRecordLifeCycleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeviceRecordLifeCycleWithOptionsAsync(request, runtime);
        }

        public StopLiveStreamingResponse StopLiveStreamingWithOptions(StopLiveStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLiveStreaming",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLiveStreamingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopLiveStreamingResponse> StopLiveStreamingWithOptionsAsync(StopLiveStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopLiveStreaming",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopLiveStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopLiveStreamingResponse StopLiveStreaming(StopLiveStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLiveStreamingWithOptions(request, runtime);
        }

        public async Task<StopLiveStreamingResponse> StopLiveStreamingAsync(StopLiveStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLiveStreamingWithOptionsAsync(request, runtime);
        }

        public StopTriggeredRecordResponse StopTriggeredRecordWithOptions(StopTriggeredRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTriggeredRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTriggeredRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopTriggeredRecordResponse> StopTriggeredRecordWithOptionsAsync(StopTriggeredRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTriggeredRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTriggeredRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopTriggeredRecordResponse StopTriggeredRecord(StopTriggeredRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopTriggeredRecordWithOptions(request, runtime);
        }

        public async Task<StopTriggeredRecordResponse> StopTriggeredRecordAsync(StopTriggeredRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopTriggeredRecordWithOptionsAsync(request, runtime);
        }

        public TransferDeviceInstanceResponse TransferDeviceInstanceWithOptions(TransferDeviceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNameList))
            {
                query["DeviceNameList"] = request.DeviceNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceId))
            {
                query["SourceInstanceId"] = request.SourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                query["TargetInstanceId"] = request.TargetInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferDeviceInstance",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferDeviceInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferDeviceInstanceResponse> TransferDeviceInstanceWithOptionsAsync(TransferDeviceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceNameList))
            {
                query["DeviceNameList"] = request.DeviceNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceId))
            {
                query["SourceInstanceId"] = request.SourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                query["TargetInstanceId"] = request.TargetInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferDeviceInstance",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferDeviceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferDeviceInstanceResponse TransferDeviceInstance(TransferDeviceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferDeviceInstanceWithOptions(request, runtime);
        }

        public async Task<TransferDeviceInstanceResponse> TransferDeviceInstanceAsync(TransferDeviceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferDeviceInstanceWithOptionsAsync(request, runtime);
        }

        public TriggerCapturePictureResponse TriggerCapturePictureWithOptions(TriggerCapturePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "TriggerCapturePicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerCapturePictureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TriggerCapturePictureResponse> TriggerCapturePictureWithOptionsAsync(TriggerCapturePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
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
                Action = "TriggerCapturePicture",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerCapturePictureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TriggerCapturePictureResponse TriggerCapturePicture(TriggerCapturePictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerCapturePictureWithOptions(request, runtime);
        }

        public async Task<TriggerCapturePictureResponse> TriggerCapturePictureAsync(TriggerCapturePictureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerCapturePictureWithOptionsAsync(request, runtime);
        }

        public TriggerRecordResponse TriggerRecordWithOptions(TriggerRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordDuration))
            {
                query["RecordDuration"] = request.RecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TriggerRecordResponse> TriggerRecordWithOptionsAsync(TriggerRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordDuration))
            {
                query["RecordDuration"] = request.RecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerRecord",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TriggerRecordResponse TriggerRecord(TriggerRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerRecordWithOptions(request, runtime);
        }

        public async Task<TriggerRecordResponse> TriggerRecordAsync(TriggerRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerRecordWithOptionsAsync(request, runtime);
        }

        public UnbindPictureSearchAppWithDevicesResponse UnbindPictureSearchAppWithDevicesWithOptions(UnbindPictureSearchAppWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIotIds))
            {
                query["DeviceIotIds"] = request.DeviceIotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPictureSearchAppWithDevices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPictureSearchAppWithDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindPictureSearchAppWithDevicesResponse> UnbindPictureSearchAppWithDevicesWithOptionsAsync(UnbindPictureSearchAppWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIotIds))
            {
                query["DeviceIotIds"] = request.DeviceIotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPictureSearchAppWithDevices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPictureSearchAppWithDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindPictureSearchAppWithDevicesResponse UnbindPictureSearchAppWithDevices(UnbindPictureSearchAppWithDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPictureSearchAppWithDevicesWithOptions(request, runtime);
        }

        public async Task<UnbindPictureSearchAppWithDevicesResponse> UnbindPictureSearchAppWithDevicesAsync(UnbindPictureSearchAppWithDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPictureSearchAppWithDevicesWithOptionsAsync(request, runtime);
        }

        public UpdateEventRecordPlanResponse UpdateEventRecordPlanWithOptions(UpdateEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypes))
            {
                query["EventTypes"] = request.EventTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordDuration))
            {
                query["RecordDuration"] = request.RecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventRecordPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEventRecordPlanResponse> UpdateEventRecordPlanWithOptionsAsync(UpdateEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypes))
            {
                query["EventTypes"] = request.EventTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreRecordDuration))
            {
                query["PreRecordDuration"] = request.PreRecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordDuration))
            {
                query["RecordDuration"] = request.RecordDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventRecordPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateEventRecordPlanResponse UpdateEventRecordPlan(UpdateEventRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventRecordPlanWithOptions(request, runtime);
        }

        public async Task<UpdateEventRecordPlanResponse> UpdateEventRecordPlanAsync(UpdateEventRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventRecordPlanWithOptionsAsync(request, runtime);
        }

        public UpdateFaceUserResponse UpdateFaceUserWithOptions(UpdateFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                query["FacePicUrl"] = request.FacePicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
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
                Action = "UpdateFaceUser",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFaceUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFaceUserResponse> UpdateFaceUserWithOptionsAsync(UpdateFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacePicUrl))
            {
                query["FacePicUrl"] = request.FacePicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
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
                Action = "UpdateFaceUser",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFaceUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFaceUserResponse UpdateFaceUser(UpdateFaceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFaceUserWithOptions(request, runtime);
        }

        public async Task<UpdateFaceUserResponse> UpdateFaceUserAsync(UpdateFaceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFaceUserWithOptionsAsync(request, runtime);
        }

        public UpdateFaceUserGroupAndDeviceGroupRelationResponse UpdateFaceUserGroupAndDeviceGroupRelationWithOptions(UpdateFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlId))
            {
                query["ControlId"] = request.ControlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Relation))
            {
                query["Relation"] = request.Relation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFaceUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFaceUserGroupAndDeviceGroupRelationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFaceUserGroupAndDeviceGroupRelationResponse> UpdateFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(UpdateFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlId))
            {
                query["ControlId"] = request.ControlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationId))
            {
                query["IsolationId"] = request.IsolationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Relation))
            {
                query["Relation"] = request.Relation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFaceUserGroupAndDeviceGroupRelation",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFaceUserGroupAndDeviceGroupRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFaceUserGroupAndDeviceGroupRelationResponse UpdateFaceUserGroupAndDeviceGroupRelation(UpdateFaceUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFaceUserGroupAndDeviceGroupRelationWithOptions(request, runtime);
        }

        public async Task<UpdateFaceUserGroupAndDeviceGroupRelationResponse> UpdateFaceUserGroupAndDeviceGroupRelationAsync(UpdateFaceUserGroupAndDeviceGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(request, runtime);
        }

        public UpdateInstanceInternetProtocolResponse UpdateInstanceInternetProtocolWithOptions(UpdateInstanceInternetProtocolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceInternetProtocol",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceInternetProtocolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateInstanceInternetProtocolResponse> UpdateInstanceInternetProtocolWithOptionsAsync(UpdateInstanceInternetProtocolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceInternetProtocol",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceInternetProtocolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateInstanceInternetProtocolResponse UpdateInstanceInternetProtocol(UpdateInstanceInternetProtocolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceInternetProtocolWithOptions(request, runtime);
        }

        public async Task<UpdateInstanceInternetProtocolResponse> UpdateInstanceInternetProtocolAsync(UpdateInstanceInternetProtocolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceInternetProtocolWithOptionsAsync(request, runtime);
        }

        public UpdatePictureSearchAppResponse UpdatePictureSearchAppWithOptions(UpdatePictureSearchAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePictureSearchApp",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePictureSearchAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePictureSearchAppResponse> UpdatePictureSearchAppWithOptionsAsync(UpdatePictureSearchAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePictureSearchApp",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePictureSearchAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePictureSearchAppResponse UpdatePictureSearchApp(UpdatePictureSearchAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePictureSearchAppWithOptions(request, runtime);
        }

        public async Task<UpdatePictureSearchAppResponse> UpdatePictureSearchAppAsync(UpdatePictureSearchAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePictureSearchAppWithOptionsAsync(request, runtime);
        }

        public UpdateRecordPlanResponse UpdateRecordPlanWithOptions(UpdateRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRecordPlanResponse> UpdateRecordPlanWithOptionsAsync(UpdateRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecordPlan",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRecordPlanResponse UpdateRecordPlan(UpdateRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordPlanWithOptions(request, runtime);
        }

        public async Task<UpdateRecordPlanResponse> UpdateRecordPlanAsync(UpdateRecordPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordPlanWithOptionsAsync(request, runtime);
        }

        public UpdateRtmpKeyResponse UpdateRtmpKeyWithOptions(UpdateRtmpKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullAuthKey))
            {
                query["PullAuthKey"] = request.PullAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullKeyExpireTime))
            {
                query["PullKeyExpireTime"] = request.PullKeyExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAuthKey))
            {
                query["PushAuthKey"] = request.PushAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushKeyExpireTime))
            {
                query["PushKeyExpireTime"] = request.PushKeyExpireTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRtmpKey",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRtmpKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRtmpKeyResponse> UpdateRtmpKeyWithOptionsAsync(UpdateRtmpKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IotInstanceId))
            {
                query["IotInstanceId"] = request.IotInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductKey))
            {
                query["ProductKey"] = request.ProductKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullAuthKey))
            {
                query["PullAuthKey"] = request.PullAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullKeyExpireTime))
            {
                query["PullKeyExpireTime"] = request.PullKeyExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushAuthKey))
            {
                query["PushAuthKey"] = request.PushAuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushKeyExpireTime))
            {
                query["PushKeyExpireTime"] = request.PushKeyExpireTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRtmpKey",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRtmpKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRtmpKeyResponse UpdateRtmpKey(UpdateRtmpKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRtmpKeyWithOptions(request, runtime);
        }

        public async Task<UpdateRtmpKeyResponse> UpdateRtmpKeyAsync(UpdateRtmpKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRtmpKeyWithOptionsAsync(request, runtime);
        }

        public UpdateTimeTemplateResponse UpdateTimeTemplateWithOptions(UpdateTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDay))
            {
                query["AllDay"] = request.AllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSections))
            {
                query["TimeSections"] = request.TimeSections;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTimeTemplate",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTimeTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTimeTemplateResponse> UpdateTimeTemplateWithOptionsAsync(UpdateTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDay))
            {
                query["AllDay"] = request.AllDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSections))
            {
                query["TimeSections"] = request.TimeSections;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTimeTemplate",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTimeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTimeTemplateResponse UpdateTimeTemplate(UpdateTimeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTimeTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateTimeTemplateResponse> UpdateTimeTemplateAsync(UpdateTimeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTimeTemplateWithOptionsAsync(request, runtime);
        }

    }
}
