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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddEventRecordPlanDeviceResponse>(DoRPCRequest("AddEventRecordPlanDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddEventRecordPlanDeviceResponse> AddEventRecordPlanDeviceWithOptionsAsync(AddEventRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddEventRecordPlanDeviceResponse>(await DoRPCRequestAsync("AddEventRecordPlanDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceDeviceGroupResponse>(DoRPCRequest("AddFaceDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFaceDeviceGroupResponse> AddFaceDeviceGroupWithOptionsAsync(AddFaceDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceDeviceGroupResponse>(await DoRPCRequestAsync("AddFaceDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceDeviceToDeviceGroupResponse>(DoRPCRequest("AddFaceDeviceToDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFaceDeviceToDeviceGroupResponse> AddFaceDeviceToDeviceGroupWithOptionsAsync(AddFaceDeviceToDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceDeviceToDeviceGroupResponse>(await DoRPCRequestAsync("AddFaceDeviceToDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserResponse>(DoRPCRequest("AddFaceUser", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFaceUserResponse> AddFaceUserWithOptionsAsync(AddFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserResponse>(await DoRPCRequestAsync("AddFaceUser", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserGroupResponse>(DoRPCRequest("AddFaceUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFaceUserGroupResponse> AddFaceUserGroupWithOptionsAsync(AddFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserGroupResponse>(await DoRPCRequestAsync("AddFaceUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserGroupAndDeviceGroupRelationResponse>(DoRPCRequest("AddFaceUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFaceUserGroupAndDeviceGroupRelationResponse> AddFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(AddFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserGroupAndDeviceGroupRelationResponse>(await DoRPCRequestAsync("AddFaceUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserPictureResponse>(DoRPCRequest("AddFaceUserPicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFaceUserPictureResponse> AddFaceUserPictureWithOptionsAsync(AddFaceUserPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserPictureResponse>(await DoRPCRequestAsync("AddFaceUserPicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserToUserGroupResponse>(DoRPCRequest("AddFaceUserToUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddFaceUserToUserGroupResponse> AddFaceUserToUserGroupWithOptionsAsync(AddFaceUserToUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddFaceUserToUserGroupResponse>(await DoRPCRequestAsync("AddFaceUserToUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRecordPlanDeviceResponse>(DoRPCRequest("AddRecordPlanDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddRecordPlanDeviceResponse> AddRecordPlanDeviceWithOptionsAsync(AddRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRecordPlanDeviceResponse>(await DoRPCRequestAsync("AddRecordPlanDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public BindAIPlanWithDevicesResponse BindAIPlanWithDevicesWithOptions(BindAIPlanWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAIPlanWithDevicesResponse>(DoRPCRequest("BindAIPlanWithDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindAIPlanWithDevicesResponse> BindAIPlanWithDevicesWithOptionsAsync(BindAIPlanWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAIPlanWithDevicesResponse>(await DoRPCRequestAsync("BindAIPlanWithDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindAIPlanWithDevicesResponse BindAIPlanWithDevices(BindAIPlanWithDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAIPlanWithDevicesWithOptions(request, runtime);
        }

        public async Task<BindAIPlanWithDevicesResponse> BindAIPlanWithDevicesAsync(BindAIPlanWithDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAIPlanWithDevicesWithOptionsAsync(request, runtime);
        }

        public BindPictureSearchAppWithDevicesResponse BindPictureSearchAppWithDevicesWithOptions(BindPictureSearchAppWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindPictureSearchAppWithDevicesResponse>(DoRPCRequest("BindPictureSearchAppWithDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindPictureSearchAppWithDevicesResponse> BindPictureSearchAppWithDevicesWithOptionsAsync(BindPictureSearchAppWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindPictureSearchAppWithDevicesResponse>(await DoRPCRequestAsync("BindPictureSearchAppWithDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFaceUserDoExistOnDeviceResponse>(DoRPCRequest("CheckFaceUserDoExistOnDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckFaceUserDoExistOnDeviceResponse> CheckFaceUserDoExistOnDeviceWithOptionsAsync(CheckFaceUserDoExistOnDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFaceUserDoExistOnDeviceResponse>(await DoRPCRequestAsync("CheckFaceUserDoExistOnDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearFaceDeviceDBResponse>(DoRPCRequest("ClearFaceDeviceDB", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClearFaceDeviceDBResponse> ClearFaceDeviceDBWithOptionsAsync(ClearFaceDeviceDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearFaceDeviceDBResponse>(await DoRPCRequestAsync("ClearFaceDeviceDB", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ConfigAIActionResponse ConfigAIActionWithOptions(ConfigAIActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigAIActionResponse>(DoRPCRequest("ConfigAIAction", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigAIActionResponse> ConfigAIActionWithOptionsAsync(ConfigAIActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigAIActionResponse>(await DoRPCRequestAsync("ConfigAIAction", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigAIActionResponse ConfigAIAction(ConfigAIActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigAIActionWithOptions(request, runtime);
        }

        public async Task<ConfigAIActionResponse> ConfigAIActionAsync(ConfigAIActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigAIActionWithOptionsAsync(request, runtime);
        }

        public CreateAIAppResponse CreateAIAppWithOptions(CreateAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAIAppResponse>(DoRPCRequest("CreateAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAIAppResponse> CreateAIAppWithOptionsAsync(CreateAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAIAppResponse>(await DoRPCRequestAsync("CreateAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAIAppResponse CreateAIApp(CreateAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAIAppWithOptions(request, runtime);
        }

        public async Task<CreateAIAppResponse> CreateAIAppAsync(CreateAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAIAppWithOptionsAsync(request, runtime);
        }

        public CreateAIPlanResponse CreateAIPlanWithOptions(CreateAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAIPlanResponse>(DoRPCRequest("CreateAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAIPlanResponse> CreateAIPlanWithOptionsAsync(CreateAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAIPlanResponse>(await DoRPCRequestAsync("CreateAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAIPlanResponse CreateAIPlan(CreateAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAIPlanWithOptions(request, runtime);
        }

        public async Task<CreateAIPlanResponse> CreateAIPlanAsync(CreateAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAIPlanWithOptionsAsync(request, runtime);
        }

        public CreateAlgorithmResponse CreateAlgorithmWithOptions(CreateAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlgorithmResponse>(DoRPCRequest("CreateAlgorithm", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAlgorithmResponse> CreateAlgorithmWithOptionsAsync(CreateAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlgorithmResponse>(await DoRPCRequestAsync("CreateAlgorithm", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAlgorithmResponse CreateAlgorithm(CreateAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAlgorithmWithOptions(request, runtime);
        }

        public async Task<CreateAlgorithmResponse> CreateAlgorithmAsync(CreateAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAlgorithmWithOptionsAsync(request, runtime);
        }

        public CreateDevicePurifyJobResponse CreateDevicePurifyJobWithOptions(CreateDevicePurifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevicePurifyJobResponse>(DoRPCRequest("CreateDevicePurifyJob", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDevicePurifyJobResponse> CreateDevicePurifyJobWithOptionsAsync(CreateDevicePurifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevicePurifyJobResponse>(await DoRPCRequestAsync("CreateDevicePurifyJob", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDevicePurifyJobResponse CreateDevicePurifyJob(CreateDevicePurifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDevicePurifyJobWithOptions(request, runtime);
        }

        public async Task<CreateDevicePurifyJobResponse> CreateDevicePurifyJobAsync(CreateDevicePurifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDevicePurifyJobWithOptionsAsync(request, runtime);
        }

        public CreateDevicePurifyJobByPlanIdResponse CreateDevicePurifyJobByPlanIdWithOptions(CreateDevicePurifyJobByPlanIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevicePurifyJobByPlanIdResponse>(DoRPCRequest("CreateDevicePurifyJobByPlanId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDevicePurifyJobByPlanIdResponse> CreateDevicePurifyJobByPlanIdWithOptionsAsync(CreateDevicePurifyJobByPlanIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevicePurifyJobByPlanIdResponse>(await DoRPCRequestAsync("CreateDevicePurifyJobByPlanId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDevicePurifyJobByPlanIdResponse CreateDevicePurifyJobByPlanId(CreateDevicePurifyJobByPlanIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDevicePurifyJobByPlanIdWithOptions(request, runtime);
        }

        public async Task<CreateDevicePurifyJobByPlanIdResponse> CreateDevicePurifyJobByPlanIdAsync(CreateDevicePurifyJobByPlanIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDevicePurifyJobByPlanIdWithOptionsAsync(request, runtime);
        }

        public CreateDevicePurifyPlanResponse CreateDevicePurifyPlanWithOptions(CreateDevicePurifyPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevicePurifyPlanResponse>(DoRPCRequest("CreateDevicePurifyPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDevicePurifyPlanResponse> CreateDevicePurifyPlanWithOptionsAsync(CreateDevicePurifyPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDevicePurifyPlanResponse>(await DoRPCRequestAsync("CreateDevicePurifyPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDevicePurifyPlanResponse CreateDevicePurifyPlan(CreateDevicePurifyPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDevicePurifyPlanWithOptions(request, runtime);
        }

        public async Task<CreateDevicePurifyPlanResponse> CreateDevicePurifyPlanAsync(CreateDevicePurifyPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDevicePurifyPlanWithOptionsAsync(request, runtime);
        }

        public CreateEventRecordPlanResponse CreateEventRecordPlanWithOptions(CreateEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEventRecordPlanResponse>(DoRPCRequest("CreateEventRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEventRecordPlanResponse> CreateEventRecordPlanWithOptionsAsync(CreateEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEventRecordPlanResponse>(await DoRPCRequestAsync("CreateEventRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateModelResponse CreateModelWithOptions(CreateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateModelResponse>(DoRPCRequest("CreateModel", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(CreateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateModelResponse>(await DoRPCRequestAsync("CreateModel", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateModelResponse CreateModel(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateModelWithOptions(request, runtime);
        }

        public async Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateModelWithOptionsAsync(request, runtime);
        }

        public CreatePictureSearchAppResponse CreatePictureSearchAppWithOptions(CreatePictureSearchAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePictureSearchAppResponse>(DoRPCRequest("CreatePictureSearchApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePictureSearchAppResponse> CreatePictureSearchAppWithOptionsAsync(CreatePictureSearchAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePictureSearchAppResponse>(await DoRPCRequestAsync("CreatePictureSearchApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateRecordPlanResponse CreateRecordPlanWithOptions(CreateRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRecordPlanResponse>(DoRPCRequest("CreateRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRecordPlanResponse> CreateRecordPlanWithOptionsAsync(CreateRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRecordPlanResponse>(await DoRPCRequestAsync("CreateRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateTimeTemplateResponse CreateTimeTemplateWithOptions(CreateTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTimeTemplateResponse>(DoRPCRequest("CreateTimeTemplate", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTimeTemplateResponse> CreateTimeTemplateWithOptionsAsync(CreateTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTimeTemplateResponse>(await DoRPCRequestAsync("CreateTimeTemplate", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteAlgorithmResponse DeleteAlgorithmWithOptions(DeleteAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlgorithmResponse>(DoRPCRequest("DeleteAlgorithm", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlgorithmResponse> DeleteAlgorithmWithOptionsAsync(DeleteAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlgorithmResponse>(await DoRPCRequestAsync("DeleteAlgorithm", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlgorithmResponse DeleteAlgorithm(DeleteAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlgorithmWithOptions(request, runtime);
        }

        public async Task<DeleteAlgorithmResponse> DeleteAlgorithmAsync(DeleteAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlgorithmWithOptionsAsync(request, runtime);
        }

        public DeleteEventRecordPlanResponse DeleteEventRecordPlanWithOptions(DeleteEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventRecordPlanResponse>(DoRPCRequest("DeleteEventRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEventRecordPlanResponse> DeleteEventRecordPlanWithOptionsAsync(DeleteEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventRecordPlanResponse>(await DoRPCRequestAsync("DeleteEventRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventRecordPlanDeviceResponse>(DoRPCRequest("DeleteEventRecordPlanDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEventRecordPlanDeviceResponse> DeleteEventRecordPlanDeviceWithOptionsAsync(DeleteEventRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEventRecordPlanDeviceResponse>(await DoRPCRequestAsync("DeleteEventRecordPlanDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceDeviceGroupResponse>(DoRPCRequest("DeleteFaceDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceDeviceGroupResponse> DeleteFaceDeviceGroupWithOptionsAsync(DeleteFaceDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceDeviceGroupResponse>(await DoRPCRequestAsync("DeleteFaceDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceUserResponse>(DoRPCRequest("DeleteFaceUser", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceUserResponse> DeleteFaceUserWithOptionsAsync(DeleteFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceUserResponse>(await DoRPCRequestAsync("DeleteFaceUser", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceUserGroupResponse>(DoRPCRequest("DeleteFaceUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceUserGroupResponse> DeleteFaceUserGroupWithOptionsAsync(DeleteFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceUserGroupResponse>(await DoRPCRequestAsync("DeleteFaceUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceUserGroupAndDeviceGroupRelationResponse>(DoRPCRequest("DeleteFaceUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceUserGroupAndDeviceGroupRelationResponse> DeleteFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(DeleteFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceUserGroupAndDeviceGroupRelationResponse>(await DoRPCRequestAsync("DeleteFaceUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceUserPictureResponse>(DoRPCRequest("DeleteFaceUserPicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFaceUserPictureResponse> DeleteFaceUserPictureWithOptionsAsync(DeleteFaceUserPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFaceUserPictureResponse>(await DoRPCRequestAsync("DeleteFaceUserPicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteModelResponse DeleteModelWithOptions(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteModelResponse>(DoRPCRequest("DeleteModel", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteModelResponse>(await DoRPCRequestAsync("DeleteModel", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelWithOptions(request, runtime);
        }

        public async Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelWithOptionsAsync(request, runtime);
        }

        public DeleteRecordPlanResponse DeleteRecordPlanWithOptions(DeleteRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordPlanResponse>(DoRPCRequest("DeleteRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRecordPlanResponse> DeleteRecordPlanWithOptionsAsync(DeleteRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordPlanResponse>(await DoRPCRequestAsync("DeleteRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordPlanDeviceResponse>(DoRPCRequest("DeleteRecordPlanDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRecordPlanDeviceResponse> DeleteRecordPlanDeviceWithOptionsAsync(DeleteRecordPlanDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRecordPlanDeviceResponse>(await DoRPCRequestAsync("DeleteRecordPlanDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteTimeTemplateResponse DeleteTimeTemplateWithOptions(DeleteTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTimeTemplateResponse>(DoRPCRequest("DeleteTimeTemplate", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTimeTemplateResponse> DeleteTimeTemplateWithOptionsAsync(DeleteTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTimeTemplateResponse>(await DoRPCRequestAsync("DeleteTimeTemplate", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeployModelBatchResponse DeployModelBatchWithOptions(DeployModelBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployModelBatchResponse>(DoRPCRequest("DeployModelBatch", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployModelBatchResponse> DeployModelBatchWithOptionsAsync(DeployModelBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployModelBatchResponse>(await DoRPCRequestAsync("DeployModelBatch", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployModelBatchResponse DeployModelBatch(DeployModelBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployModelBatchWithOptions(request, runtime);
        }

        public async Task<DeployModelBatchResponse> DeployModelBatchAsync(DeployModelBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployModelBatchWithOptionsAsync(request, runtime);
        }

        public DetectUserFaceByUrlResponse DetectUserFaceByUrlWithOptions(DetectUserFaceByUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectUserFaceByUrlResponse>(DoRPCRequest("DetectUserFaceByUrl", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectUserFaceByUrlResponse> DetectUserFaceByUrlWithOptionsAsync(DetectUserFaceByUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectUserFaceByUrlResponse>(await DoRPCRequestAsync("DetectUserFaceByUrl", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetAIActionResponse GetAIActionWithOptions(GetAIActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIActionResponse>(DoRPCRequest("GetAIAction", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAIActionResponse> GetAIActionWithOptionsAsync(GetAIActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIActionResponse>(await DoRPCRequestAsync("GetAIAction", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAIActionResponse GetAIAction(GetAIActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIActionWithOptions(request, runtime);
        }

        public async Task<GetAIActionResponse> GetAIActionAsync(GetAIActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIActionWithOptionsAsync(request, runtime);
        }

        public GetAIActionConfigResponse GetAIActionConfigWithOptions(GetAIActionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIActionConfigResponse>(DoRPCRequest("GetAIActionConfig", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAIActionConfigResponse> GetAIActionConfigWithOptionsAsync(GetAIActionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIActionConfigResponse>(await DoRPCRequestAsync("GetAIActionConfig", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAIActionConfigResponse GetAIActionConfig(GetAIActionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIActionConfigWithOptions(request, runtime);
        }

        public async Task<GetAIActionConfigResponse> GetAIActionConfigAsync(GetAIActionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIActionConfigWithOptionsAsync(request, runtime);
        }

        public GetAIAppResponse GetAIAppWithOptions(GetAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIAppResponse>(DoRPCRequest("GetAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAIAppResponse> GetAIAppWithOptionsAsync(GetAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIAppResponse>(await DoRPCRequestAsync("GetAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAIAppResponse GetAIApp(GetAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIAppWithOptions(request, runtime);
        }

        public async Task<GetAIAppResponse> GetAIAppAsync(GetAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIAppWithOptionsAsync(request, runtime);
        }

        public GetAIJobResponse GetAIJobWithOptions(GetAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIJobResponse>(DoRPCRequest("GetAIJob", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAIJobResponse> GetAIJobWithOptionsAsync(GetAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIJobResponse>(await DoRPCRequestAsync("GetAIJob", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAIJobResponse GetAIJob(GetAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIJobWithOptions(request, runtime);
        }

        public async Task<GetAIJobResponse> GetAIJobAsync(GetAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIJobWithOptionsAsync(request, runtime);
        }

        public GetAIPlanResponse GetAIPlanWithOptions(GetAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIPlanResponse>(DoRPCRequest("GetAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAIPlanResponse> GetAIPlanWithOptionsAsync(GetAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAIPlanResponse>(await DoRPCRequestAsync("GetAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAIPlanResponse GetAIPlan(GetAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIPlanWithOptions(request, runtime);
        }

        public async Task<GetAIPlanResponse> GetAIPlanAsync(GetAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIPlanWithOptionsAsync(request, runtime);
        }

        public GetAlgorithmDetailByIdResponse GetAlgorithmDetailByIdWithOptions(GetAlgorithmDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlgorithmDetailByIdResponse>(DoRPCRequest("GetAlgorithmDetailById", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAlgorithmDetailByIdResponse> GetAlgorithmDetailByIdWithOptionsAsync(GetAlgorithmDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlgorithmDetailByIdResponse>(await DoRPCRequestAsync("GetAlgorithmDetailById", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAlgorithmDetailByIdResponse GetAlgorithmDetailById(GetAlgorithmDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlgorithmDetailByIdWithOptions(request, runtime);
        }

        public async Task<GetAlgorithmDetailByIdResponse> GetAlgorithmDetailByIdAsync(GetAlgorithmDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlgorithmDetailByIdWithOptionsAsync(request, runtime);
        }

        public GetAlgorithmDetailByNameResponse GetAlgorithmDetailByNameWithOptions(GetAlgorithmDetailByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlgorithmDetailByNameResponse>(DoRPCRequest("GetAlgorithmDetailByName", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAlgorithmDetailByNameResponse> GetAlgorithmDetailByNameWithOptionsAsync(GetAlgorithmDetailByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAlgorithmDetailByNameResponse>(await DoRPCRequestAsync("GetAlgorithmDetailByName", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAlgorithmDetailByNameResponse GetAlgorithmDetailByName(GetAlgorithmDetailByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlgorithmDetailByNameWithOptions(request, runtime);
        }

        public async Task<GetAlgorithmDetailByNameResponse> GetAlgorithmDetailByNameAsync(GetAlgorithmDetailByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlgorithmDetailByNameWithOptionsAsync(request, runtime);
        }

        public GetDevicePurifyJobByJobIdResponse GetDevicePurifyJobByJobIdWithOptions(GetDevicePurifyJobByJobIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevicePurifyJobByJobIdResponse>(DoRPCRequest("GetDevicePurifyJobByJobId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDevicePurifyJobByJobIdResponse> GetDevicePurifyJobByJobIdWithOptionsAsync(GetDevicePurifyJobByJobIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDevicePurifyJobByJobIdResponse>(await DoRPCRequestAsync("GetDevicePurifyJobByJobId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDevicePurifyJobByJobIdResponse GetDevicePurifyJobByJobId(GetDevicePurifyJobByJobIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDevicePurifyJobByJobIdWithOptions(request, runtime);
        }

        public async Task<GetDevicePurifyJobByJobIdResponse> GetDevicePurifyJobByJobIdAsync(GetDevicePurifyJobByJobIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDevicePurifyJobByJobIdWithOptionsAsync(request, runtime);
        }

        public GetModelDetailResponse GetModelDetailWithOptions(GetModelDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelDetailResponse>(DoRPCRequest("GetModelDetail", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetModelDetailResponse> GetModelDetailWithOptionsAsync(GetModelDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelDetailResponse>(await DoRPCRequestAsync("GetModelDetail", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetModelDetailResponse GetModelDetail(GetModelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelDetailWithOptions(request, runtime);
        }

        public async Task<GetModelDetailResponse> GetModelDetailAsync(GetModelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelDetailWithOptionsAsync(request, runtime);
        }

        public GetModelDetailByIdResponse GetModelDetailByIdWithOptions(GetModelDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelDetailByIdResponse>(DoRPCRequest("GetModelDetailById", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetModelDetailByIdResponse> GetModelDetailByIdWithOptionsAsync(GetModelDetailByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelDetailByIdResponse>(await DoRPCRequestAsync("GetModelDetailById", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetModelDetailByIdResponse GetModelDetailById(GetModelDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelDetailByIdWithOptions(request, runtime);
        }

        public async Task<GetModelDetailByIdResponse> GetModelDetailByIdAsync(GetModelDetailByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelDetailByIdWithOptionsAsync(request, runtime);
        }

        public GetModelOssPolicyResponse GetModelOssPolicyWithOptions(GetModelOssPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelOssPolicyResponse>(DoRPCRequest("GetModelOssPolicy", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetModelOssPolicyResponse> GetModelOssPolicyWithOptionsAsync(GetModelOssPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelOssPolicyResponse>(await DoRPCRequestAsync("GetModelOssPolicy", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetModelOssPolicyResponse GetModelOssPolicy(GetModelOssPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelOssPolicyWithOptions(request, runtime);
        }

        public async Task<GetModelOssPolicyResponse> GetModelOssPolicyAsync(GetModelOssPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelOssPolicyWithOptionsAsync(request, runtime);
        }

        public GetPictureInfoWithVectorIdsResponse GetPictureInfoWithVectorIdsWithOptions(GetPictureInfoWithVectorIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPictureInfoWithVectorIdsResponse>(DoRPCRequest("GetPictureInfoWithVectorIds", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPictureInfoWithVectorIdsResponse> GetPictureInfoWithVectorIdsWithOptionsAsync(GetPictureInfoWithVectorIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPictureInfoWithVectorIdsResponse>(await DoRPCRequestAsync("GetPictureInfoWithVectorIds", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPictureInfoWithVectorIdsResponse GetPictureInfoWithVectorIds(GetPictureInfoWithVectorIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPictureInfoWithVectorIdsWithOptions(request, runtime);
        }

        public async Task<GetPictureInfoWithVectorIdsResponse> GetPictureInfoWithVectorIdsAsync(GetPictureInfoWithVectorIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPictureInfoWithVectorIdsWithOptionsAsync(request, runtime);
        }

        public GetPictureWithVectorIdResponse GetPictureWithVectorIdWithOptions(GetPictureWithVectorIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPictureWithVectorIdResponse>(DoRPCRequest("GetPictureWithVectorId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPictureWithVectorIdResponse> GetPictureWithVectorIdWithOptionsAsync(GetPictureWithVectorIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPictureWithVectorIdResponse>(await DoRPCRequestAsync("GetPictureWithVectorId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPictureWithVectorIdResponse GetPictureWithVectorId(GetPictureWithVectorIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPictureWithVectorIdWithOptions(request, runtime);
        }

        public async Task<GetPictureWithVectorIdResponse> GetPictureWithVectorIdAsync(GetPictureWithVectorIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPictureWithVectorIdWithOptionsAsync(request, runtime);
        }

        public ListAlgorithmsByPageResponse ListAlgorithmsByPageWithOptions(ListAlgorithmsByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlgorithmsByPageResponse>(DoRPCRequest("ListAlgorithmsByPage", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAlgorithmsByPageResponse> ListAlgorithmsByPageWithOptionsAsync(ListAlgorithmsByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlgorithmsByPageResponse>(await DoRPCRequestAsync("ListAlgorithmsByPage", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAlgorithmsByPageResponse ListAlgorithmsByPage(ListAlgorithmsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlgorithmsByPageWithOptions(request, runtime);
        }

        public async Task<ListAlgorithmsByPageResponse> ListAlgorithmsByPageAsync(ListAlgorithmsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlgorithmsByPageWithOptionsAsync(request, runtime);
        }

        public ListDeployTaskByModelIdAndDevicesResponse ListDeployTaskByModelIdAndDevicesWithOptions(ListDeployTaskByModelIdAndDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeployTaskByModelIdAndDevicesResponse>(DoRPCRequest("ListDeployTaskByModelIdAndDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeployTaskByModelIdAndDevicesResponse> ListDeployTaskByModelIdAndDevicesWithOptionsAsync(ListDeployTaskByModelIdAndDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeployTaskByModelIdAndDevicesResponse>(await DoRPCRequestAsync("ListDeployTaskByModelIdAndDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDeployTaskByModelIdAndDevicesResponse ListDeployTaskByModelIdAndDevices(ListDeployTaskByModelIdAndDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeployTaskByModelIdAndDevicesWithOptions(request, runtime);
        }

        public async Task<ListDeployTaskByModelIdAndDevicesResponse> ListDeployTaskByModelIdAndDevicesAsync(ListDeployTaskByModelIdAndDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeployTaskByModelIdAndDevicesWithOptionsAsync(request, runtime);
        }

        public ListDeployTaskByPageResponse ListDeployTaskByPageWithOptions(ListDeployTaskByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeployTaskByPageResponse>(DoRPCRequest("ListDeployTaskByPage", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeployTaskByPageResponse> ListDeployTaskByPageWithOptionsAsync(ListDeployTaskByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeployTaskByPageResponse>(await DoRPCRequestAsync("ListDeployTaskByPage", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDeployTaskByPageResponse ListDeployTaskByPage(ListDeployTaskByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeployTaskByPageWithOptions(request, runtime);
        }

        public async Task<ListDeployTaskByPageResponse> ListDeployTaskByPageAsync(ListDeployTaskByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeployTaskByPageWithOptionsAsync(request, runtime);
        }

        public ListModelsByPageResponse ListModelsByPageWithOptions(ListModelsByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListModelsByPageResponse>(DoRPCRequest("ListModelsByPage", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListModelsByPageResponse> ListModelsByPageWithOptionsAsync(ListModelsByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListModelsByPageResponse>(await DoRPCRequestAsync("ListModelsByPage", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListModelsByPageResponse ListModelsByPage(ListModelsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelsByPageWithOptions(request, runtime);
        }

        public async Task<ListModelsByPageResponse> ListModelsByPageAsync(ListModelsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelsByPageWithOptionsAsync(request, runtime);
        }

        public ListModelVersionsByPageResponse ListModelVersionsByPageWithOptions(ListModelVersionsByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListModelVersionsByPageResponse>(DoRPCRequest("ListModelVersionsByPage", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListModelVersionsByPageResponse> ListModelVersionsByPageWithOptionsAsync(ListModelVersionsByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListModelVersionsByPageResponse>(await DoRPCRequestAsync("ListModelVersionsByPage", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListModelVersionsByPageResponse ListModelVersionsByPage(ListModelVersionsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListModelVersionsByPageWithOptions(request, runtime);
        }

        public async Task<ListModelVersionsByPageResponse> ListModelVersionsByPageAsync(ListModelVersionsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListModelVersionsByPageWithOptionsAsync(request, runtime);
        }

        public PictureSearchPictureResponse PictureSearchPictureWithOptions(PictureSearchPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PictureSearchPictureResponse>(DoRPCRequest("PictureSearchPicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PictureSearchPictureResponse> PictureSearchPictureWithOptionsAsync(PictureSearchPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PictureSearchPictureResponse>(await DoRPCRequestAsync("PictureSearchPicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryAIActionResponse QueryAIActionWithOptions(QueryAIActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIActionResponse>(DoRPCRequest("QueryAIAction", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAIActionResponse> QueryAIActionWithOptionsAsync(QueryAIActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIActionResponse>(await DoRPCRequestAsync("QueryAIAction", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAIActionResponse QueryAIAction(QueryAIActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAIActionWithOptions(request, runtime);
        }

        public async Task<QueryAIActionResponse> QueryAIActionAsync(QueryAIActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAIActionWithOptionsAsync(request, runtime);
        }

        public QueryAIAppResponse QueryAIAppWithOptions(QueryAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIAppResponse>(DoRPCRequest("QueryAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAIAppResponse> QueryAIAppWithOptionsAsync(QueryAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIAppResponse>(await DoRPCRequestAsync("QueryAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAIAppResponse QueryAIApp(QueryAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAIAppWithOptions(request, runtime);
        }

        public async Task<QueryAIAppResponse> QueryAIAppAsync(QueryAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAIAppWithOptionsAsync(request, runtime);
        }

        public QueryAIJobsResponse QueryAIJobsWithOptions(QueryAIJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIJobsResponse>(DoRPCRequest("QueryAIJobs", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAIJobsResponse> QueryAIJobsWithOptionsAsync(QueryAIJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIJobsResponse>(await DoRPCRequestAsync("QueryAIJobs", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAIJobsResponse QueryAIJobs(QueryAIJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAIJobsWithOptions(request, runtime);
        }

        public async Task<QueryAIJobsResponse> QueryAIJobsAsync(QueryAIJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAIJobsWithOptionsAsync(request, runtime);
        }

        public QueryAIPlanResponse QueryAIPlanWithOptions(QueryAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIPlanResponse>(DoRPCRequest("QueryAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAIPlanResponse> QueryAIPlanWithOptionsAsync(QueryAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIPlanResponse>(await DoRPCRequestAsync("QueryAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAIPlanResponse QueryAIPlan(QueryAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAIPlanWithOptions(request, runtime);
        }

        public async Task<QueryAIPlanResponse> QueryAIPlanAsync(QueryAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAIPlanWithOptionsAsync(request, runtime);
        }

        public QueryAIPlanTemplatesResponse QueryAIPlanTemplatesWithOptions(QueryAIPlanTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIPlanTemplatesResponse>(DoRPCRequest("QueryAIPlanTemplates", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAIPlanTemplatesResponse> QueryAIPlanTemplatesWithOptionsAsync(QueryAIPlanTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAIPlanTemplatesResponse>(await DoRPCRequestAsync("QueryAIPlanTemplates", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAIPlanTemplatesResponse QueryAIPlanTemplates(QueryAIPlanTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAIPlanTemplatesWithOptions(request, runtime);
        }

        public async Task<QueryAIPlanTemplatesResponse> QueryAIPlanTemplatesAsync(QueryAIPlanTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAIPlanTemplatesWithOptionsAsync(request, runtime);
        }

        public QueryDeviceEventResponse QueryDeviceEventWithOptions(QueryDeviceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceEventResponse>(DoRPCRequest("QueryDeviceEvent", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceEventResponse> QueryDeviceEventWithOptionsAsync(QueryDeviceEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceEventResponse>(await DoRPCRequestAsync("QueryDeviceEvent", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceEventPictureResponse>(DoRPCRequest("QueryDeviceEventPicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceEventPictureResponse> QueryDeviceEventPictureWithOptionsAsync(QueryDeviceEventPictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceEventPictureResponse>(await DoRPCRequestAsync("QueryDeviceEventPicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceEventRecordResponse>(DoRPCRequest("QueryDeviceEventRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceEventRecordResponse> QueryDeviceEventRecordWithOptionsAsync(QueryDeviceEventRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceEventRecordResponse>(await DoRPCRequestAsync("QueryDeviceEventRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryDeviceFileVodResponse QueryDeviceFileVodWithOptions(QueryDeviceFileVodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceFileVodResponse>(DoRPCRequest("QueryDeviceFileVod", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceFileVodResponse> QueryDeviceFileVodWithOptionsAsync(QueryDeviceFileVodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceFileVodResponse>(await DoRPCRequestAsync("QueryDeviceFileVod", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDeviceFileVodResponse QueryDeviceFileVod(QueryDeviceFileVodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceFileVodWithOptions(request, runtime);
        }

        public async Task<QueryDeviceFileVodResponse> QueryDeviceFileVodAsync(QueryDeviceFileVodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceFileVodWithOptionsAsync(request, runtime);
        }

        public QueryDevicePictureFileResponse QueryDevicePictureFileWithOptions(QueryDevicePictureFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePictureFileResponse>(DoRPCRequest("QueryDevicePictureFile", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDevicePictureFileResponse> QueryDevicePictureFileWithOptionsAsync(QueryDevicePictureFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePictureFileResponse>(await DoRPCRequestAsync("QueryDevicePictureFile", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePictureLifeCycleResponse>(DoRPCRequest("QueryDevicePictureLifeCycle", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDevicePictureLifeCycleResponse> QueryDevicePictureLifeCycleWithOptionsAsync(QueryDevicePictureLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePictureLifeCycleResponse>(await DoRPCRequestAsync("QueryDevicePictureLifeCycle", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryDevicePurifyJobsResponse QueryDevicePurifyJobsWithOptions(QueryDevicePurifyJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePurifyJobsResponse>(DoRPCRequest("QueryDevicePurifyJobs", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDevicePurifyJobsResponse> QueryDevicePurifyJobsWithOptionsAsync(QueryDevicePurifyJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePurifyJobsResponse>(await DoRPCRequestAsync("QueryDevicePurifyJobs", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDevicePurifyJobsResponse QueryDevicePurifyJobs(QueryDevicePurifyJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePurifyJobsWithOptions(request, runtime);
        }

        public async Task<QueryDevicePurifyJobsResponse> QueryDevicePurifyJobsAsync(QueryDevicePurifyJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePurifyJobsWithOptionsAsync(request, runtime);
        }

        public QueryDevicePurifyPlanByPlanIdResponse QueryDevicePurifyPlanByPlanIdWithOptions(QueryDevicePurifyPlanByPlanIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePurifyPlanByPlanIdResponse>(DoRPCRequest("QueryDevicePurifyPlanByPlanId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDevicePurifyPlanByPlanIdResponse> QueryDevicePurifyPlanByPlanIdWithOptionsAsync(QueryDevicePurifyPlanByPlanIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePurifyPlanByPlanIdResponse>(await DoRPCRequestAsync("QueryDevicePurifyPlanByPlanId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDevicePurifyPlanByPlanIdResponse QueryDevicePurifyPlanByPlanId(QueryDevicePurifyPlanByPlanIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePurifyPlanByPlanIdWithOptions(request, runtime);
        }

        public async Task<QueryDevicePurifyPlanByPlanIdResponse> QueryDevicePurifyPlanByPlanIdAsync(QueryDevicePurifyPlanByPlanIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePurifyPlanByPlanIdWithOptionsAsync(request, runtime);
        }

        public QueryDevicePurifyPlansResponse QueryDevicePurifyPlansWithOptions(QueryDevicePurifyPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePurifyPlansResponse>(DoRPCRequest("QueryDevicePurifyPlans", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDevicePurifyPlansResponse> QueryDevicePurifyPlansWithOptionsAsync(QueryDevicePurifyPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicePurifyPlansResponse>(await DoRPCRequestAsync("QueryDevicePurifyPlans", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDevicePurifyPlansResponse QueryDevicePurifyPlans(QueryDevicePurifyPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePurifyPlansWithOptions(request, runtime);
        }

        public async Task<QueryDevicePurifyPlansResponse> QueryDevicePurifyPlansAsync(QueryDevicePurifyPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePurifyPlansWithOptionsAsync(request, runtime);
        }

        public QueryDeviceRecordLifeCycleResponse QueryDeviceRecordLifeCycleWithOptions(QueryDeviceRecordLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceRecordLifeCycleResponse>(DoRPCRequest("QueryDeviceRecordLifeCycle", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceRecordLifeCycleResponse> QueryDeviceRecordLifeCycleWithOptionsAsync(QueryDeviceRecordLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceRecordLifeCycleResponse>(await DoRPCRequestAsync("QueryDeviceRecordLifeCycle", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceVodUrlResponse>(DoRPCRequest("QueryDeviceVodUrl", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceVodUrlResponse> QueryDeviceVodUrlWithOptionsAsync(QueryDeviceVodUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceVodUrlResponse>(await DoRPCRequestAsync("QueryDeviceVodUrl", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryEventRecordPlanDetailResponse QueryEventRecordPlanDetailWithOptions(QueryEventRecordPlanDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEventRecordPlanDetailResponse>(DoRPCRequest("QueryEventRecordPlanDetail", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEventRecordPlanDetailResponse> QueryEventRecordPlanDetailWithOptionsAsync(QueryEventRecordPlanDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEventRecordPlanDetailResponse>(await DoRPCRequestAsync("QueryEventRecordPlanDetail", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEventRecordPlanDeviceByDeviceResponse>(DoRPCRequest("QueryEventRecordPlanDeviceByDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEventRecordPlanDeviceByDeviceResponse> QueryEventRecordPlanDeviceByDeviceWithOptionsAsync(QueryEventRecordPlanDeviceByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEventRecordPlanDeviceByDeviceResponse>(await DoRPCRequestAsync("QueryEventRecordPlanDeviceByDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEventRecordPlanDeviceByPlanResponse>(DoRPCRequest("QueryEventRecordPlanDeviceByPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEventRecordPlanDeviceByPlanResponse> QueryEventRecordPlanDeviceByPlanWithOptionsAsync(QueryEventRecordPlanDeviceByPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEventRecordPlanDeviceByPlanResponse>(await DoRPCRequestAsync("QueryEventRecordPlanDeviceByPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEventRecordPlansResponse>(DoRPCRequest("QueryEventRecordPlans", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEventRecordPlansResponse> QueryEventRecordPlansWithOptionsAsync(QueryEventRecordPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEventRecordPlansResponse>(await DoRPCRequestAsync("QueryEventRecordPlans", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceAllDeviceGroupResponse>(DoRPCRequest("QueryFaceAllDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceAllDeviceGroupResponse> QueryFaceAllDeviceGroupWithOptionsAsync(QueryFaceAllDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceAllDeviceGroupResponse>(await DoRPCRequestAsync("QueryFaceAllDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceAllUserGroupResponse>(DoRPCRequest("QueryFaceAllUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceAllUserGroupResponse> QueryFaceAllUserGroupWithOptionsAsync(QueryFaceAllUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceAllUserGroupResponse>(await DoRPCRequestAsync("QueryFaceAllUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceAllUserGroupAndDeviceGroupRelationResponse>(DoRPCRequest("QueryFaceAllUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceAllUserGroupAndDeviceGroupRelationResponse> QueryFaceAllUserGroupAndDeviceGroupRelationWithOptionsAsync(QueryFaceAllUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceAllUserGroupAndDeviceGroupRelationResponse>(await DoRPCRequestAsync("QueryFaceAllUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceAllUserIdsByGroupIdResponse>(DoRPCRequest("QueryFaceAllUserIdsByGroupId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceAllUserIdsByGroupIdResponse> QueryFaceAllUserIdsByGroupIdWithOptionsAsync(QueryFaceAllUserIdsByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceAllUserIdsByGroupIdResponse>(await DoRPCRequestAsync("QueryFaceAllUserIdsByGroupId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceCustomUserIdByUserIdResponse>(DoRPCRequest("QueryFaceCustomUserIdByUserId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceCustomUserIdByUserIdResponse> QueryFaceCustomUserIdByUserIdWithOptionsAsync(QueryFaceCustomUserIdByUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceCustomUserIdByUserIdResponse>(await DoRPCRequestAsync("QueryFaceCustomUserIdByUserId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceDeviceGroupsByDeviceResponse>(DoRPCRequest("QueryFaceDeviceGroupsByDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceDeviceGroupsByDeviceResponse> QueryFaceDeviceGroupsByDeviceWithOptionsAsync(QueryFaceDeviceGroupsByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceDeviceGroupsByDeviceResponse>(await DoRPCRequestAsync("QueryFaceDeviceGroupsByDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceUserResponse>(DoRPCRequest("QueryFaceUser", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceUserResponse> QueryFaceUserWithOptionsAsync(QueryFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceUserResponse>(await DoRPCRequestAsync("QueryFaceUser", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryFaceUserGroupResponse QueryFaceUserGroupWithOptions(QueryFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceUserGroupResponse>(DoRPCRequest("QueryFaceUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceUserGroupResponse> QueryFaceUserGroupWithOptionsAsync(QueryFaceUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceUserGroupResponse>(await DoRPCRequestAsync("QueryFaceUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceUserGroupAndDeviceGroupRelationResponse>(DoRPCRequest("QueryFaceUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceUserGroupAndDeviceGroupRelationResponse> QueryFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(QueryFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceUserGroupAndDeviceGroupRelationResponse>(await DoRPCRequestAsync("QueryFaceUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceUserIdByCustomUserIdResponse>(DoRPCRequest("QueryFaceUserIdByCustomUserId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFaceUserIdByCustomUserIdResponse> QueryFaceUserIdByCustomUserIdWithOptionsAsync(QueryFaceUserIdByCustomUserIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFaceUserIdByCustomUserIdResponse>(await DoRPCRequestAsync("QueryFaceUserIdByCustomUserId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryIotIdsByAIPlanResponse QueryIotIdsByAIPlanWithOptions(QueryIotIdsByAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIotIdsByAIPlanResponse>(DoRPCRequest("QueryIotIdsByAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryIotIdsByAIPlanResponse> QueryIotIdsByAIPlanWithOptionsAsync(QueryIotIdsByAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryIotIdsByAIPlanResponse>(await DoRPCRequestAsync("QueryIotIdsByAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryIotIdsByAIPlanResponse QueryIotIdsByAIPlan(QueryIotIdsByAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIotIdsByAIPlanWithOptions(request, runtime);
        }

        public async Task<QueryIotIdsByAIPlanResponse> QueryIotIdsByAIPlanAsync(QueryIotIdsByAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIotIdsByAIPlanWithOptionsAsync(request, runtime);
        }

        public QueryLiveStreamingResponse QueryLiveStreamingWithOptions(QueryLiveStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryLiveStreamingResponse>(DoRPCRequest("QueryLiveStreaming", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryLiveStreamingResponse> QueryLiveStreamingWithOptionsAsync(QueryLiveStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryLiveStreamingResponse>(await DoRPCRequestAsync("QueryLiveStreaming", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryMonthRecordResponse QueryMonthRecordWithOptions(QueryMonthRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMonthRecordResponse>(DoRPCRequest("QueryMonthRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMonthRecordResponse> QueryMonthRecordWithOptionsAsync(QueryMonthRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMonthRecordResponse>(await DoRPCRequestAsync("QueryMonthRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPictureFilesResponse>(DoRPCRequest("QueryPictureFiles", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPictureFilesResponse> QueryPictureFilesWithOptionsAsync(QueryPictureFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPictureFilesResponse>(await DoRPCRequestAsync("QueryPictureFiles", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPictureSearchAiboxesResponse>(DoRPCRequest("QueryPictureSearchAiboxes", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPictureSearchAiboxesResponse> QueryPictureSearchAiboxesWithOptionsAsync(QueryPictureSearchAiboxesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPictureSearchAiboxesResponse>(await DoRPCRequestAsync("QueryPictureSearchAiboxes", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryPictureSearchAppResponse QueryPictureSearchAppWithOptions(QueryPictureSearchAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPictureSearchAppResponse>(DoRPCRequest("QueryPictureSearchApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPictureSearchAppResponse> QueryPictureSearchAppWithOptionsAsync(QueryPictureSearchAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPictureSearchAppResponse>(await DoRPCRequestAsync("QueryPictureSearchApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPictureSearchAppResponse QueryPictureSearchApp(QueryPictureSearchAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPictureSearchAppWithOptions(request, runtime);
        }

        public async Task<QueryPictureSearchAppResponse> QueryPictureSearchAppAsync(QueryPictureSearchAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPictureSearchAppWithOptionsAsync(request, runtime);
        }

        public QueryPictureSearchDevicesResponse QueryPictureSearchDevicesWithOptions(QueryPictureSearchDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPictureSearchDevicesResponse>(DoRPCRequest("QueryPictureSearchDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPictureSearchDevicesResponse> QueryPictureSearchDevicesWithOptionsAsync(QueryPictureSearchDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPictureSearchDevicesResponse>(await DoRPCRequestAsync("QueryPictureSearchDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryRecordResponse QueryRecordWithOptions(QueryRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordResponse>(DoRPCRequest("QueryRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRecordResponse> QueryRecordWithOptionsAsync(QueryRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordResponse>(await DoRPCRequestAsync("QueryRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordByRecordIdResponse>(DoRPCRequest("QueryRecordByRecordId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRecordByRecordIdResponse> QueryRecordByRecordIdWithOptionsAsync(QueryRecordByRecordIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordByRecordIdResponse>(await DoRPCRequestAsync("QueryRecordByRecordId", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryRecordPlanDetailResponse QueryRecordPlanDetailWithOptions(QueryRecordPlanDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordPlanDetailResponse>(DoRPCRequest("QueryRecordPlanDetail", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRecordPlanDetailResponse> QueryRecordPlanDetailWithOptionsAsync(QueryRecordPlanDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordPlanDetailResponse>(await DoRPCRequestAsync("QueryRecordPlanDetail", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordPlanDeviceByDeviceResponse>(DoRPCRequest("QueryRecordPlanDeviceByDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRecordPlanDeviceByDeviceResponse> QueryRecordPlanDeviceByDeviceWithOptionsAsync(QueryRecordPlanDeviceByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordPlanDeviceByDeviceResponse>(await DoRPCRequestAsync("QueryRecordPlanDeviceByDevice", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordPlanDeviceByPlanResponse>(DoRPCRequest("QueryRecordPlanDeviceByPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRecordPlanDeviceByPlanResponse> QueryRecordPlanDeviceByPlanWithOptionsAsync(QueryRecordPlanDeviceByPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordPlanDeviceByPlanResponse>(await DoRPCRequestAsync("QueryRecordPlanDeviceByPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordPlansResponse>(DoRPCRequest("QueryRecordPlans", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRecordPlansResponse> QueryRecordPlansWithOptionsAsync(QueryRecordPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordPlansResponse>(await DoRPCRequestAsync("QueryRecordPlans", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordUrlResponse>(DoRPCRequest("QueryRecordUrl", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRecordUrlResponse> QueryRecordUrlWithOptionsAsync(QueryRecordUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordUrlResponse>(await DoRPCRequestAsync("QueryRecordUrl", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryStandardAIAppTemplatesResponse QueryStandardAIAppTemplatesWithOptions(QueryStandardAIAppTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryStandardAIAppTemplatesResponse>(DoRPCRequest("QueryStandardAIAppTemplates", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryStandardAIAppTemplatesResponse> QueryStandardAIAppTemplatesWithOptionsAsync(QueryStandardAIAppTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryStandardAIAppTemplatesResponse>(await DoRPCRequestAsync("QueryStandardAIAppTemplates", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryStandardAIAppTemplatesResponse QueryStandardAIAppTemplates(QueryStandardAIAppTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStandardAIAppTemplatesWithOptions(request, runtime);
        }

        public async Task<QueryStandardAIAppTemplatesResponse> QueryStandardAIAppTemplatesAsync(QueryStandardAIAppTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStandardAIAppTemplatesWithOptionsAsync(request, runtime);
        }

        public QueryTimeTemplateResponse QueryTimeTemplateWithOptions(QueryTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTimeTemplateResponse>(DoRPCRequest("QueryTimeTemplate", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTimeTemplateResponse> QueryTimeTemplateWithOptionsAsync(QueryTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTimeTemplateResponse>(await DoRPCRequestAsync("QueryTimeTemplate", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTimeTemplateDetailResponse>(DoRPCRequest("QueryTimeTemplateDetail", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTimeTemplateDetailResponse> QueryTimeTemplateDetailWithOptionsAsync(QueryTimeTemplateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTimeTemplateDetailResponse>(await DoRPCRequestAsync("QueryTimeTemplateDetail", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryVoiceIntercomResponse QueryVoiceIntercomWithOptions(QueryVoiceIntercomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVoiceIntercomResponse>(DoRPCRequest("QueryVoiceIntercom", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryVoiceIntercomResponse> QueryVoiceIntercomWithOptionsAsync(QueryVoiceIntercomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVoiceIntercomResponse>(await DoRPCRequestAsync("QueryVoiceIntercom", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RemoveAIAppResponse RemoveAIAppWithOptions(RemoveAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAIAppResponse>(DoRPCRequest("RemoveAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveAIAppResponse> RemoveAIAppWithOptionsAsync(RemoveAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAIAppResponse>(await DoRPCRequestAsync("RemoveAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveAIAppResponse RemoveAIApp(RemoveAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAIAppWithOptions(request, runtime);
        }

        public async Task<RemoveAIAppResponse> RemoveAIAppAsync(RemoveAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAIAppWithOptionsAsync(request, runtime);
        }

        public RemoveAIPlanResponse RemoveAIPlanWithOptions(RemoveAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAIPlanResponse>(DoRPCRequest("RemoveAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveAIPlanResponse> RemoveAIPlanWithOptionsAsync(RemoveAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAIPlanResponse>(await DoRPCRequestAsync("RemoveAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveAIPlanResponse RemoveAIPlan(RemoveAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAIPlanWithOptions(request, runtime);
        }

        public async Task<RemoveAIPlanResponse> RemoveAIPlanAsync(RemoveAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAIPlanWithOptionsAsync(request, runtime);
        }

        public RemoveDevicePurifyPlanResponse RemoveDevicePurifyPlanWithOptions(RemoveDevicePurifyPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDevicePurifyPlanResponse>(DoRPCRequest("RemoveDevicePurifyPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveDevicePurifyPlanResponse> RemoveDevicePurifyPlanWithOptionsAsync(RemoveDevicePurifyPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveDevicePurifyPlanResponse>(await DoRPCRequestAsync("RemoveDevicePurifyPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveDevicePurifyPlanResponse RemoveDevicePurifyPlan(RemoveDevicePurifyPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveDevicePurifyPlanWithOptions(request, runtime);
        }

        public async Task<RemoveDevicePurifyPlanResponse> RemoveDevicePurifyPlanAsync(RemoveDevicePurifyPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveDevicePurifyPlanWithOptionsAsync(request, runtime);
        }

        public RemoveFaceDeviceFromDeviceGroupResponse RemoveFaceDeviceFromDeviceGroupWithOptions(RemoveFaceDeviceFromDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveFaceDeviceFromDeviceGroupResponse>(DoRPCRequest("RemoveFaceDeviceFromDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveFaceDeviceFromDeviceGroupResponse> RemoveFaceDeviceFromDeviceGroupWithOptionsAsync(RemoveFaceDeviceFromDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveFaceDeviceFromDeviceGroupResponse>(await DoRPCRequestAsync("RemoveFaceDeviceFromDeviceGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveFaceUserFromUserGroupResponse>(DoRPCRequest("RemoveFaceUserFromUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveFaceUserFromUserGroupResponse> RemoveFaceUserFromUserGroupWithOptionsAsync(RemoveFaceUserFromUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveFaceUserFromUserGroupResponse>(await DoRPCRequestAsync("RemoveFaceUserFromUserGroup", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDevicePictureLifeCycleResponse>(DoRPCRequest("SetDevicePictureLifeCycle", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDevicePictureLifeCycleResponse> SetDevicePictureLifeCycleWithOptionsAsync(SetDevicePictureLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDevicePictureLifeCycleResponse>(await DoRPCRequestAsync("SetDevicePictureLifeCycle", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDeviceRecordLifeCycleResponse>(DoRPCRequest("SetDeviceRecordLifeCycle", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDeviceRecordLifeCycleResponse> SetDeviceRecordLifeCycleWithOptionsAsync(SetDeviceRecordLifeCycleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDeviceRecordLifeCycleResponse>(await DoRPCRequestAsync("SetDeviceRecordLifeCycle", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopLiveStreamingResponse>(DoRPCRequest("StopLiveStreaming", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopLiveStreamingResponse> StopLiveStreamingWithOptionsAsync(StopLiveStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopLiveStreamingResponse>(await DoRPCRequestAsync("StopLiveStreaming", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopTriggeredRecordResponse>(DoRPCRequest("StopTriggeredRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopTriggeredRecordResponse> StopTriggeredRecordWithOptionsAsync(StopTriggeredRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopTriggeredRecordResponse>(await DoRPCRequestAsync("StopTriggeredRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TriggerCapturePictureResponse TriggerCapturePictureWithOptions(TriggerCapturePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TriggerCapturePictureResponse>(DoRPCRequest("TriggerCapturePicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TriggerCapturePictureResponse> TriggerCapturePictureWithOptionsAsync(TriggerCapturePictureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TriggerCapturePictureResponse>(await DoRPCRequestAsync("TriggerCapturePicture", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TriggerRecordResponse>(DoRPCRequest("TriggerRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TriggerRecordResponse> TriggerRecordWithOptionsAsync(TriggerRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TriggerRecordResponse>(await DoRPCRequestAsync("TriggerRecord", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UnbindAIPlanWithDevicesResponse UnbindAIPlanWithDevicesWithOptions(UnbindAIPlanWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindAIPlanWithDevicesResponse>(DoRPCRequest("UnbindAIPlanWithDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindAIPlanWithDevicesResponse> UnbindAIPlanWithDevicesWithOptionsAsync(UnbindAIPlanWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindAIPlanWithDevicesResponse>(await DoRPCRequestAsync("UnbindAIPlanWithDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindAIPlanWithDevicesResponse UnbindAIPlanWithDevices(UnbindAIPlanWithDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAIPlanWithDevicesWithOptions(request, runtime);
        }

        public async Task<UnbindAIPlanWithDevicesResponse> UnbindAIPlanWithDevicesAsync(UnbindAIPlanWithDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAIPlanWithDevicesWithOptionsAsync(request, runtime);
        }

        public UnbindPictureSearchAppWithDevicesResponse UnbindPictureSearchAppWithDevicesWithOptions(UnbindPictureSearchAppWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindPictureSearchAppWithDevicesResponse>(DoRPCRequest("UnbindPictureSearchAppWithDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindPictureSearchAppWithDevicesResponse> UnbindPictureSearchAppWithDevicesWithOptionsAsync(UnbindPictureSearchAppWithDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindPictureSearchAppWithDevicesResponse>(await DoRPCRequestAsync("UnbindPictureSearchAppWithDevices", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateAIAppResponse UpdateAIAppWithOptions(UpdateAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAIAppResponse>(DoRPCRequest("UpdateAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAIAppResponse> UpdateAIAppWithOptionsAsync(UpdateAIAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAIAppResponse>(await DoRPCRequestAsync("UpdateAIApp", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAIAppResponse UpdateAIApp(UpdateAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAIAppWithOptions(request, runtime);
        }

        public async Task<UpdateAIAppResponse> UpdateAIAppAsync(UpdateAIAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAIAppWithOptionsAsync(request, runtime);
        }

        public UpdateAIPlanResponse UpdateAIPlanWithOptions(UpdateAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAIPlanResponse>(DoRPCRequest("UpdateAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAIPlanResponse> UpdateAIPlanWithOptionsAsync(UpdateAIPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAIPlanResponse>(await DoRPCRequestAsync("UpdateAIPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAIPlanResponse UpdateAIPlan(UpdateAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAIPlanWithOptions(request, runtime);
        }

        public async Task<UpdateAIPlanResponse> UpdateAIPlanAsync(UpdateAIPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAIPlanWithOptionsAsync(request, runtime);
        }

        public UpdateDevicePurifyPlanResponse UpdateDevicePurifyPlanWithOptions(UpdateDevicePurifyPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDevicePurifyPlanResponse>(DoRPCRequest("UpdateDevicePurifyPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDevicePurifyPlanResponse> UpdateDevicePurifyPlanWithOptionsAsync(UpdateDevicePurifyPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDevicePurifyPlanResponse>(await DoRPCRequestAsync("UpdateDevicePurifyPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDevicePurifyPlanResponse UpdateDevicePurifyPlan(UpdateDevicePurifyPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDevicePurifyPlanWithOptions(request, runtime);
        }

        public async Task<UpdateDevicePurifyPlanResponse> UpdateDevicePurifyPlanAsync(UpdateDevicePurifyPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDevicePurifyPlanWithOptionsAsync(request, runtime);
        }

        public UpdateEventRecordPlanResponse UpdateEventRecordPlanWithOptions(UpdateEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEventRecordPlanResponse>(DoRPCRequest("UpdateEventRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateEventRecordPlanResponse> UpdateEventRecordPlanWithOptionsAsync(UpdateEventRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEventRecordPlanResponse>(await DoRPCRequestAsync("UpdateEventRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFaceUserResponse>(DoRPCRequest("UpdateFaceUser", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFaceUserResponse> UpdateFaceUserWithOptionsAsync(UpdateFaceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFaceUserResponse>(await DoRPCRequestAsync("UpdateFaceUser", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFaceUserGroupAndDeviceGroupRelationResponse>(DoRPCRequest("UpdateFaceUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFaceUserGroupAndDeviceGroupRelationResponse> UpdateFaceUserGroupAndDeviceGroupRelationWithOptionsAsync(UpdateFaceUserGroupAndDeviceGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFaceUserGroupAndDeviceGroupRelationResponse>(await DoRPCRequestAsync("UpdateFaceUserGroupAndDeviceGroupRelation", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateModelResponse UpdateModelWithOptions(UpdateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateModelResponse>(DoRPCRequest("UpdateModel", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateModelResponse> UpdateModelWithOptionsAsync(UpdateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateModelResponse>(await DoRPCRequestAsync("UpdateModel", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateModelWithOptions(request, runtime);
        }

        public async Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateModelWithOptionsAsync(request, runtime);
        }

        public UpdateRecordPlanResponse UpdateRecordPlanWithOptions(UpdateRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordPlanResponse>(DoRPCRequest("UpdateRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRecordPlanResponse> UpdateRecordPlanWithOptionsAsync(UpdateRecordPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordPlanResponse>(await DoRPCRequestAsync("UpdateRecordPlan", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateTimeTemplateResponse UpdateTimeTemplateWithOptions(UpdateTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTimeTemplateResponse>(DoRPCRequest("UpdateTimeTemplate", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTimeTemplateResponse> UpdateTimeTemplateWithOptionsAsync(UpdateTimeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTimeTemplateResponse>(await DoRPCRequestAsync("UpdateTimeTemplate", "2018-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
