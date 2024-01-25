// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudesl20200201.Models;

namespace AlibabaCloud.SDK.Cloudesl20200201
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "cloudesl.aliyuncs.com"},
                {"ap-northeast-2-pop", "cloudesl.aliyuncs.com"},
                {"ap-south-1", "cloudesl.aliyuncs.com"},
                {"ap-southeast-1", "cloudesl.aliyuncs.com"},
                {"ap-southeast-2", "cloudesl.aliyuncs.com"},
                {"ap-southeast-3", "cloudesl.aliyuncs.com"},
                {"ap-southeast-5", "cloudesl.aliyuncs.com"},
                {"cn-beijing", "cloudesl.aliyuncs.com"},
                {"cn-beijing-finance-1", "cloudesl.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cloudesl.aliyuncs.com"},
                {"cn-beijing-gov-1", "cloudesl.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cloudesl.aliyuncs.com"},
                {"cn-chengdu", "cloudesl.aliyuncs.com"},
                {"cn-edge-1", "cloudesl.aliyuncs.com"},
                {"cn-fujian", "cloudesl.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-finance", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cloudesl.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cloudesl.aliyuncs.com"},
                {"cn-hongkong", "cloudesl.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cloudesl.aliyuncs.com"},
                {"cn-huhehaote", "cloudesl.aliyuncs.com"},
                {"cn-north-2-gov-1", "cloudesl.aliyuncs.com"},
                {"cn-qingdao", "cloudesl.aliyuncs.com"},
                {"cn-qingdao-nebula", "cloudesl.aliyuncs.com"},
                {"cn-shanghai", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-inner", "cloudesl.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen-inner", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cloudesl.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cloudesl.aliyuncs.com"},
                {"cn-wuhan", "cloudesl.aliyuncs.com"},
                {"cn-yushanfang", "cloudesl.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cloudesl.aliyuncs.com"},
                {"cn-zhangjiakou", "cloudesl.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cloudesl.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cloudesl.aliyuncs.com"},
                {"eu-central-1", "cloudesl.aliyuncs.com"},
                {"eu-west-1", "cloudesl.aliyuncs.com"},
                {"eu-west-1-oxs", "cloudesl.aliyuncs.com"},
                {"me-east-1", "cloudesl.aliyuncs.com"},
                {"rus-west-1-pop", "cloudesl.aliyuncs.com"},
                {"us-east-1", "cloudesl.aliyuncs.com"},
                {"us-west-1", "cloudesl.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudesl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActivateApDeviceResponse ActivateApDeviceWithOptions(ActivateApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateApDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateApDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ActivateApDeviceResponse> ActivateApDeviceWithOptionsAsync(ActivateApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateApDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateApDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ActivateApDeviceResponse ActivateApDevice(ActivateApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateApDeviceWithOptions(request, runtime);
        }

        public async Task<ActivateApDeviceResponse> ActivateApDeviceAsync(ActivateApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateApDeviceWithOptionsAsync(request, runtime);
        }

        public AddApDeviceResponse AddApDeviceWithOptions(AddApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddApDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddApDeviceResponse> AddApDeviceWithOptionsAsync(AddApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddApDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddApDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddApDeviceResponse AddApDevice(AddApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddApDeviceWithOptions(request, runtime);
        }

        public async Task<AddApDeviceResponse> AddApDeviceAsync(AddApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddApDeviceWithOptionsAsync(request, runtime);
        }

        public AddCompanyTemplateResponse AddCompanyTemplateWithOptions(AddCompanyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslSize))
            {
                body["EslSize"] = request.EslSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfDefault))
            {
                body["IfDefault"] = request.IfDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfMember))
            {
                body["IfMember"] = request.IfMember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfOutOfInventory))
            {
                body["IfOutOfInventory"] = request.IfOutOfInventory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfPromotion))
            {
                body["IfPromotion"] = request.IfPromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfSourceCode))
            {
                body["IfSourceCode"] = request.IfSourceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layout))
            {
                body["Layout"] = request.Layout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSceneId))
            {
                body["TemplateSceneId"] = request.TemplateSceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                body["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCompanyTemplate",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCompanyTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddCompanyTemplateResponse> AddCompanyTemplateWithOptionsAsync(AddCompanyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslSize))
            {
                body["EslSize"] = request.EslSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfDefault))
            {
                body["IfDefault"] = request.IfDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfMember))
            {
                body["IfMember"] = request.IfMember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfOutOfInventory))
            {
                body["IfOutOfInventory"] = request.IfOutOfInventory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfPromotion))
            {
                body["IfPromotion"] = request.IfPromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfSourceCode))
            {
                body["IfSourceCode"] = request.IfSourceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layout))
            {
                body["Layout"] = request.Layout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSceneId))
            {
                body["TemplateSceneId"] = request.TemplateSceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                body["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCompanyTemplate",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCompanyTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddCompanyTemplateResponse AddCompanyTemplate(AddCompanyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCompanyTemplateWithOptions(request, runtime);
        }

        public async Task<AddCompanyTemplateResponse> AddCompanyTemplateAsync(AddCompanyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCompanyTemplateWithOptionsAsync(request, runtime);
        }

        public AddUserResponse AddUserWithOptions(AddUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddUserResponse> AddUserWithOptionsAsync(AddUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddUserResponse AddUser(AddUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserWithOptions(request, runtime);
        }

        public async Task<AddUserResponse> AddUserAsync(AddUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserWithOptionsAsync(request, runtime);
        }

        public ApplyCompanyTemplateVersionToStoresResponse ApplyCompanyTemplateVersionToStoresWithOptions(ApplyCompanyTemplateVersionToStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["Stores"] = request.Stores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyCompanyTemplateVersionToStores",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyCompanyTemplateVersionToStoresResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApplyCompanyTemplateVersionToStoresResponse> ApplyCompanyTemplateVersionToStoresWithOptionsAsync(ApplyCompanyTemplateVersionToStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["Stores"] = request.Stores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyCompanyTemplateVersionToStores",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyCompanyTemplateVersionToStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApplyCompanyTemplateVersionToStoresResponse ApplyCompanyTemplateVersionToStores(ApplyCompanyTemplateVersionToStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyCompanyTemplateVersionToStoresWithOptions(request, runtime);
        }

        public async Task<ApplyCompanyTemplateVersionToStoresResponse> ApplyCompanyTemplateVersionToStoresAsync(ApplyCompanyTemplateVersionToStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyCompanyTemplateVersionToStoresWithOptionsAsync(request, runtime);
        }

        public AssignUserResponse AssignUserWithOptions(AssignUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["Stores"] = request.Stores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssignUserResponse> AssignUserWithOptionsAsync(AssignUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["Stores"] = request.Stores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssignUserResponse AssignUser(AssignUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignUserWithOptions(request, runtime);
        }

        public async Task<AssignUserResponse> AssignUserAsync(AssignUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignUserWithOptionsAsync(request, runtime);
        }

        public BatchInsertItemsResponse BatchInsertItemsWithOptions(BatchInsertItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemInfo))
            {
                body["ItemInfo"] = request.ItemInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncByItemId))
            {
                body["SyncByItemId"] = request.SyncByItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchInsertItems",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchInsertItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchInsertItemsResponse> BatchInsertItemsWithOptionsAsync(BatchInsertItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemInfo))
            {
                body["ItemInfo"] = request.ItemInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncByItemId))
            {
                body["SyncByItemId"] = request.SyncByItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchInsertItems",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchInsertItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchInsertItemsResponse BatchInsertItems(BatchInsertItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchInsertItemsWithOptions(request, runtime);
        }

        public async Task<BatchInsertItemsResponse> BatchInsertItemsAsync(BatchInsertItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchInsertItemsWithOptionsAsync(request, runtime);
        }

        public BindEslDeviceResponse BindEslDeviceWithOptions(BindEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerId))
            {
                body["ContainerId"] = request.ContainerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                body["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                body["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutId))
            {
                body["LayoutId"] = request.LayoutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutName))
            {
                body["LayoutName"] = request.LayoutName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shelf))
            {
                body["Shelf"] = request.Shelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEslDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEslDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindEslDeviceResponse> BindEslDeviceWithOptionsAsync(BindEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerId))
            {
                body["ContainerId"] = request.ContainerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                body["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                body["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutId))
            {
                body["LayoutId"] = request.LayoutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutName))
            {
                body["LayoutName"] = request.LayoutName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shelf))
            {
                body["Shelf"] = request.Shelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEslDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEslDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindEslDeviceResponse BindEslDevice(BindEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindEslDeviceWithOptions(request, runtime);
        }

        public async Task<BindEslDeviceResponse> BindEslDeviceAsync(BindEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindEslDeviceWithOptionsAsync(request, runtime);
        }

        public CreateStoreResponse CreateStoreWithOptions(CreateStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUnbindDays))
            {
                body["AutoUnbindDays"] = request.AutoUnbindDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUnbindOfflineEsl))
            {
                body["AutoUnbindOfflineEsl"] = request.AutoUnbindOfflineEsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BarCodeEncode))
            {
                body["BarCodeEncode"] = request.BarCodeEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserStoreCode))
            {
                body["UserStoreCode"] = request.UserStoreCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStore",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateStoreResponse> CreateStoreWithOptionsAsync(CreateStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUnbindDays))
            {
                body["AutoUnbindDays"] = request.AutoUnbindDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUnbindOfflineEsl))
            {
                body["AutoUnbindOfflineEsl"] = request.AutoUnbindOfflineEsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BarCodeEncode))
            {
                body["BarCodeEncode"] = request.BarCodeEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserStoreCode))
            {
                body["UserStoreCode"] = request.UserStoreCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStore",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateStoreResponse CreateStore(CreateStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStoreWithOptions(request, runtime);
        }

        public async Task<CreateStoreResponse> CreateStoreAsync(CreateStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStoreWithOptionsAsync(request, runtime);
        }

        public DeleteApDeviceResponse DeleteApDeviceWithOptions(DeleteApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteApDeviceResponse> DeleteApDeviceWithOptionsAsync(DeleteApDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteApDeviceResponse DeleteApDevice(DeleteApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteApDeviceResponse> DeleteApDeviceAsync(DeleteApDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteCompanyTemplateResponse DeleteCompanyTemplateWithOptions(DeleteCompanyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCompanyTemplate",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCompanyTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCompanyTemplateResponse> DeleteCompanyTemplateWithOptionsAsync(DeleteCompanyTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCompanyTemplate",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCompanyTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCompanyTemplateResponse DeleteCompanyTemplate(DeleteCompanyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCompanyTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteCompanyTemplateResponse> DeleteCompanyTemplateAsync(DeleteCompanyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCompanyTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteItemResponse DeleteItemWithOptions(DeleteItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindEslDevice))
            {
                body["UnbindEslDevice"] = request.UnbindEslDevice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteItem",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteItemResponse> DeleteItemWithOptionsAsync(DeleteItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindEslDevice))
            {
                body["UnbindEslDevice"] = request.UnbindEslDevice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteItem",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteItemResponse DeleteItem(DeleteItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteItemWithOptions(request, runtime);
        }

        public async Task<DeleteItemResponse> DeleteItemAsync(DeleteItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteItemWithOptionsAsync(request, runtime);
        }

        public DeleteStoreResponse DeleteStoreWithOptions(DeleteStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStore",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteStoreResponse> DeleteStoreWithOptionsAsync(DeleteStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStore",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteStoreResponse DeleteStore(DeleteStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStoreWithOptions(request, runtime);
        }

        public async Task<DeleteStoreResponse> DeleteStoreAsync(DeleteStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStoreWithOptionsAsync(request, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        public DescribeApDevicesResponse DescribeApDevicesWithOptions(DescribeApDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeActivate))
            {
                body["BeActivate"] = request.BeActivate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApDevices",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApDevicesResponse> DescribeApDevicesWithOptionsAsync(DescribeApDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApMac))
            {
                body["ApMac"] = request.ApMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeActivate))
            {
                body["BeActivate"] = request.BeActivate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApDevices",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApDevicesResponse DescribeApDevices(DescribeApDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApDevicesWithOptions(request, runtime);
        }

        public async Task<DescribeApDevicesResponse> DescribeApDevicesAsync(DescribeApDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApDevicesWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableEslModelsResponse DescribeAvailableEslModelsWithOptions(DescribeAvailableEslModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "DescribeAvailableEslModels",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableEslModelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableEslModelsResponse> DescribeAvailableEslModelsWithOptionsAsync(DescribeAvailableEslModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "DescribeAvailableEslModels",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableEslModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableEslModelsResponse DescribeAvailableEslModels(DescribeAvailableEslModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableEslModelsWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableEslModelsResponse> DescribeAvailableEslModelsAsync(DescribeAvailableEslModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableEslModelsWithOptionsAsync(request, runtime);
        }

        public DescribeBindersResponse DescribeBindersWithOptions(DescribeBindersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTitle))
            {
                body["ItemTitle"] = request.ItemTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBinders",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBindersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBindersResponse> DescribeBindersWithOptionsAsync(DescribeBindersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTitle))
            {
                body["ItemTitle"] = request.ItemTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBinders",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBindersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBindersResponse DescribeBinders(DescribeBindersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBindersWithOptions(request, runtime);
        }

        public async Task<DescribeBindersResponse> DescribeBindersAsync(DescribeBindersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBindersWithOptionsAsync(request, runtime);
        }

        public DescribeCompanyTemplateVersionsResponse DescribeCompanyTemplateVersionsWithOptions(DescribeCompanyTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeCompanyTemplateVersions",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCompanyTemplateVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCompanyTemplateVersionsResponse> DescribeCompanyTemplateVersionsWithOptionsAsync(DescribeCompanyTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeCompanyTemplateVersions",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCompanyTemplateVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCompanyTemplateVersionsResponse DescribeCompanyTemplateVersions(DescribeCompanyTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCompanyTemplateVersionsWithOptions(request, runtime);
        }

        public async Task<DescribeCompanyTemplateVersionsResponse> DescribeCompanyTemplateVersionsAsync(DescribeCompanyTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCompanyTemplateVersionsWithOptionsAsync(request, runtime);
        }

        public DescribeEslDeviceResponse DescribeEslDeviceWithOptions(DescribeEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEslDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEslDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEslDeviceResponse> DescribeEslDeviceWithOptionsAsync(DescribeEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEslDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEslDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEslDeviceResponse DescribeEslDevice(DescribeEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEslDeviceWithOptions(request, runtime);
        }

        public async Task<DescribeEslDeviceResponse> DescribeEslDeviceAsync(DescribeEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEslDeviceWithOptionsAsync(request, runtime);
        }

        public DescribeEslDevicesResponse DescribeEslDevicesWithOptions(DescribeEslDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslStatus))
            {
                body["EslStatus"] = request.EslStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromBatteryLevel))
            {
                body["FromBatteryLevel"] = request.FromBatteryLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToBatteryLevel))
            {
                body["ToBatteryLevel"] = request.ToBatteryLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeEncode))
            {
                body["TypeEncode"] = request.TypeEncode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEslDevices",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEslDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEslDevicesResponse> DescribeEslDevicesWithOptionsAsync(DescribeEslDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslStatus))
            {
                body["EslStatus"] = request.EslStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromBatteryLevel))
            {
                body["FromBatteryLevel"] = request.FromBatteryLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToBatteryLevel))
            {
                body["ToBatteryLevel"] = request.ToBatteryLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeEncode))
            {
                body["TypeEncode"] = request.TypeEncode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEslDevices",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEslDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEslDevicesResponse DescribeEslDevices(DescribeEslDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEslDevicesWithOptions(request, runtime);
        }

        public async Task<DescribeEslDevicesResponse> DescribeEslDevicesAsync(DescribeEslDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEslDevicesWithOptionsAsync(request, runtime);
        }

        public DescribeEslModelByTemplateVersionResponse DescribeEslModelByTemplateVersionWithOptions(DescribeEslModelByTemplateVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEslModelByTemplateVersion",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEslModelByTemplateVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEslModelByTemplateVersionResponse> DescribeEslModelByTemplateVersionWithOptionsAsync(DescribeEslModelByTemplateVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEslModelByTemplateVersion",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEslModelByTemplateVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEslModelByTemplateVersionResponse DescribeEslModelByTemplateVersion(DescribeEslModelByTemplateVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEslModelByTemplateVersionWithOptions(request, runtime);
        }

        public async Task<DescribeEslModelByTemplateVersionResponse> DescribeEslModelByTemplateVersionAsync(DescribeEslModelByTemplateVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEslModelByTemplateVersionWithOptionsAsync(request, runtime);
        }

        public DescribeItemsResponse DescribeItemsWithOptions(DescribeItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BePromotion))
            {
                body["BePromotion"] = request.BePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTitle))
            {
                body["ItemTitle"] = request.ItemTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                body["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeItems",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeItemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeItemsResponse> DescribeItemsWithOptionsAsync(DescribeItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BePromotion))
            {
                body["BePromotion"] = request.BePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                body["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTitle))
            {
                body["ItemTitle"] = request.ItemTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkuId))
            {
                body["SkuId"] = request.SkuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeItems",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeItemsResponse DescribeItems(DescribeItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeItemsWithOptions(request, runtime);
        }

        public async Task<DescribeItemsResponse> DescribeItemsAsync(DescribeItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeItemsWithOptionsAsync(request, runtime);
        }

        public DescribeStoreByTemplateVersionResponse DescribeStoreByTemplateVersionWithOptions(DescribeStoreByTemplateVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStoreByTemplateVersion",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoreByTemplateVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeStoreByTemplateVersionResponse> DescribeStoreByTemplateVersionWithOptionsAsync(DescribeStoreByTemplateVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStoreByTemplateVersion",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoreByTemplateVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeStoreByTemplateVersionResponse DescribeStoreByTemplateVersion(DescribeStoreByTemplateVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStoreByTemplateVersionWithOptions(request, runtime);
        }

        public async Task<DescribeStoreByTemplateVersionResponse> DescribeStoreByTemplateVersionAsync(DescribeStoreByTemplateVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStoreByTemplateVersionWithOptionsAsync(request, runtime);
        }

        public DescribeStoreConfigResponse DescribeStoreConfigWithOptions(DescribeStoreConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStoreConfig",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoreConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeStoreConfigResponse> DescribeStoreConfigWithOptionsAsync(DescribeStoreConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStoreConfig",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoreConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeStoreConfigResponse DescribeStoreConfig(DescribeStoreConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStoreConfigWithOptions(request, runtime);
        }

        public async Task<DescribeStoreConfigResponse> DescribeStoreConfigAsync(DescribeStoreConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStoreConfigWithOptionsAsync(request, runtime);
        }

        public DescribeStoresResponse DescribeStoresWithOptions(DescribeStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserStoreCode))
            {
                body["UserStoreCode"] = request.UserStoreCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStores",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoresResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeStoresResponse> DescribeStoresWithOptionsAsync(DescribeStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserStoreCode))
            {
                body["UserStoreCode"] = request.UserStoreCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStores",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeStoresResponse DescribeStores(DescribeStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStoresWithOptions(request, runtime);
        }

        public async Task<DescribeStoresResponse> DescribeStoresAsync(DescribeStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStoresWithOptionsAsync(request, runtime);
        }

        public DescribeTemplateByModelResponse DescribeTemplateByModelWithOptions(DescribeTemplateByModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslSize))
            {
                body["EslSize"] = request.EslSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplateByModel",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateByModelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTemplateByModelResponse> DescribeTemplateByModelWithOptionsAsync(DescribeTemplateByModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslSize))
            {
                body["EslSize"] = request.EslSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplateByModel",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateByModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTemplateByModelResponse DescribeTemplateByModel(DescribeTemplateByModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTemplateByModelWithOptions(request, runtime);
        }

        public async Task<DescribeTemplateByModelResponse> DescribeTemplateByModelAsync(DescribeTemplateByModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTemplateByModelWithOptionsAsync(request, runtime);
        }

        public DescribeUserLogResponse DescribeUserLogWithOptions(DescribeUserLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemShortTitle))
            {
                body["ItemShortTitle"] = request.ItemShortTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogId))
            {
                body["LogId"] = request.LogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                body["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                body["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserLog",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserLogResponse> DescribeUserLogWithOptionsAsync(DescribeUserLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDate))
            {
                body["FromDate"] = request.FromDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemShortTitle))
            {
                body["ItemShortTitle"] = request.ItemShortTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogId))
            {
                body["LogId"] = request.LogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                body["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                body["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDate))
            {
                body["ToDate"] = request.ToDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserLog",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserLogResponse DescribeUserLog(DescribeUserLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserLogWithOptions(request, runtime);
        }

        public async Task<DescribeUserLogResponse> DescribeUserLogAsync(DescribeUserLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserLogWithOptionsAsync(request, runtime);
        }

        public DescribeUsersResponse DescribeUsersWithOptions(DescribeUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsers",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUsersResponse> DescribeUsersWithOptionsAsync(DescribeUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsers",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUsersWithOptions(request, runtime);
        }

        public async Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUsersWithOptionsAsync(request, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        public QueryTemplateListByGroupIdResponse QueryTemplateListByGroupIdWithOptions(QueryTemplateListByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
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
                Action = "QueryTemplateListByGroupId",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTemplateListByGroupIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTemplateListByGroupIdResponse> QueryTemplateListByGroupIdWithOptionsAsync(QueryTemplateListByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
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
                Action = "QueryTemplateListByGroupId",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTemplateListByGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTemplateListByGroupIdResponse QueryTemplateListByGroupId(QueryTemplateListByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTemplateListByGroupIdWithOptions(request, runtime);
        }

        public async Task<QueryTemplateListByGroupIdResponse> QueryTemplateListByGroupIdAsync(QueryTemplateListByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTemplateListByGroupIdWithOptionsAsync(request, runtime);
        }

        public SyncAddMaterialResponse SyncAddMaterialWithOptions(SyncAddMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncAddMaterial",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncAddMaterialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SyncAddMaterialResponse> SyncAddMaterialWithOptionsAsync(SyncAddMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncAddMaterial",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncAddMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SyncAddMaterialResponse SyncAddMaterial(SyncAddMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncAddMaterialWithOptions(request, runtime);
        }

        public async Task<SyncAddMaterialResponse> SyncAddMaterialAsync(SyncAddMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncAddMaterialWithOptionsAsync(request, runtime);
        }

        public UnassignUserResponse UnassignUserWithOptions(UnassignUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassignUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassignUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnassignUserResponse> UnassignUserWithOptionsAsync(UnassignUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassignUser",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassignUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnassignUserResponse UnassignUser(UnassignUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassignUserWithOptions(request, runtime);
        }

        public async Task<UnassignUserResponse> UnassignUserAsync(UnassignUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassignUserWithOptionsAsync(request, runtime);
        }

        public UnbindEslDeviceResponse UnbindEslDeviceWithOptions(UnbindEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                body["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                body["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shelf))
            {
                body["Shelf"] = request.Shelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEslDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEslDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindEslDeviceResponse> UnbindEslDeviceWithOptionsAsync(UnbindEslDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Column))
            {
                body["Column"] = request.Column;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                body["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Layer))
            {
                body["Layer"] = request.Layer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shelf))
            {
                body["Shelf"] = request.Shelf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEslDevice",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEslDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindEslDeviceResponse UnbindEslDevice(UnbindEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindEslDeviceWithOptions(request, runtime);
        }

        public async Task<UnbindEslDeviceResponse> UnbindEslDeviceAsync(UnbindEslDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindEslDeviceWithOptionsAsync(request, runtime);
        }

        public UpdateEslDeviceLightResponse UpdateEslDeviceLightWithOptions(UpdateEslDeviceLightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frequency))
            {
                body["Frequency"] = request.Frequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LedColor))
            {
                body["LedColor"] = request.LedColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LightUpTime))
            {
                body["LightUpTime"] = request.LightUpTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEslDeviceLight",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEslDeviceLightResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEslDeviceLightResponse> UpdateEslDeviceLightWithOptionsAsync(UpdateEslDeviceLightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EslBarCode))
            {
                body["EslBarCode"] = request.EslBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frequency))
            {
                body["Frequency"] = request.Frequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemBarCode))
            {
                body["ItemBarCode"] = request.ItemBarCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LedColor))
            {
                body["LedColor"] = request.LedColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LightUpTime))
            {
                body["LightUpTime"] = request.LightUpTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEslDeviceLight",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEslDeviceLightResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateEslDeviceLightResponse UpdateEslDeviceLight(UpdateEslDeviceLightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEslDeviceLightWithOptions(request, runtime);
        }

        public async Task<UpdateEslDeviceLightResponse> UpdateEslDeviceLightAsync(UpdateEslDeviceLightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEslDeviceLightWithOptionsAsync(request, runtime);
        }

        public UpdateStoreResponse UpdateStoreWithOptions(UpdateStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUnbindDays))
            {
                body["AutoUnbindDays"] = request.AutoUnbindDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUnbindOfflineEsl))
            {
                body["AutoUnbindOfflineEsl"] = request.AutoUnbindOfflineEsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BarCodeEncode))
            {
                body["BarCodeEncode"] = request.BarCodeEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserStoreCode))
            {
                body["UserStoreCode"] = request.UserStoreCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStore",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateStoreResponse> UpdateStoreWithOptionsAsync(UpdateStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUnbindDays))
            {
                body["AutoUnbindDays"] = request.AutoUnbindDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUnbindOfflineEsl))
            {
                body["AutoUnbindOfflineEsl"] = request.AutoUnbindOfflineEsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BarCodeEncode))
            {
                body["BarCodeEncode"] = request.BarCodeEncode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreName))
            {
                body["StoreName"] = request.StoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                body["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserStoreCode))
            {
                body["UserStoreCode"] = request.UserStoreCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStore",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateStoreResponse UpdateStore(UpdateStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStoreWithOptions(request, runtime);
        }

        public async Task<UpdateStoreResponse> UpdateStoreAsync(UpdateStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStoreWithOptionsAsync(request, runtime);
        }

        public UpdateStoreConfigResponse UpdateStoreConfigWithOptions(UpdateStoreConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNotification))
            {
                body["EnableNotification"] = request.EnableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationSilentTimes))
            {
                body["NotificationSilentTimes"] = request.NotificationSilentTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationWebHook))
            {
                body["NotificationWebHook"] = request.NotificationWebHook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeContents))
            {
                body["SubscribeContents"] = request.SubscribeContents;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStoreConfig",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoreConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateStoreConfigResponse> UpdateStoreConfigWithOptionsAsync(UpdateStoreConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNotification))
            {
                body["EnableNotification"] = request.EnableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParams))
            {
                body["ExtraParams"] = request.ExtraParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationSilentTimes))
            {
                body["NotificationSilentTimes"] = request.NotificationSilentTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationWebHook))
            {
                body["NotificationWebHook"] = request.NotificationWebHook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                body["StoreId"] = request.StoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscribeContents))
            {
                body["SubscribeContents"] = request.SubscribeContents;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStoreConfig",
                Version = "2020-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoreConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateStoreConfigResponse UpdateStoreConfig(UpdateStoreConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStoreConfigWithOptions(request, runtime);
        }

        public async Task<UpdateStoreConfigResponse> UpdateStoreConfigAsync(UpdateStoreConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStoreConfigWithOptionsAsync(request, runtime);
        }

    }
}
