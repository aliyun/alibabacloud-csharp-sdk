// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Push20160801.Models;

namespace AlibabaCloud.SDK.Push20160801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "cloudpush.aliyuncs.com"},
                {"ap-northeast-2-pop", "cloudpush.aliyuncs.com"},
                {"ap-south-1", "cloudpush.aliyuncs.com"},
                {"ap-southeast-1", "cloudpush.aliyuncs.com"},
                {"ap-southeast-2", "cloudpush.aliyuncs.com"},
                {"ap-southeast-3", "cloudpush.aliyuncs.com"},
                {"ap-southeast-5", "cloudpush.aliyuncs.com"},
                {"cn-beijing", "cloudpush.aliyuncs.com"},
                {"cn-beijing-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cloudpush.aliyuncs.com"},
                {"cn-beijing-gov-1", "cloudpush.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cloudpush.aliyuncs.com"},
                {"cn-chengdu", "cloudpush.aliyuncs.com"},
                {"cn-edge-1", "cloudpush.aliyuncs.com"},
                {"cn-fujian", "cloudpush.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-finance", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cloudpush.aliyuncs.com"},
                {"cn-hongkong", "cloudpush.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cloudpush.aliyuncs.com"},
                {"cn-huhehaote", "cloudpush.aliyuncs.com"},
                {"cn-north-2-gov-1", "cloudpush.aliyuncs.com"},
                {"cn-qingdao", "cloudpush.aliyuncs.com"},
                {"cn-qingdao-nebula", "cloudpush.aliyuncs.com"},
                {"cn-shanghai", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-inner", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-inner", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cloudpush.aliyuncs.com"},
                {"cn-wuhan", "cloudpush.aliyuncs.com"},
                {"cn-yushanfang", "cloudpush.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cloudpush.aliyuncs.com"},
                {"cn-zhangjiakou", "cloudpush.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cloudpush.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cloudpush.aliyuncs.com"},
                {"eu-central-1", "cloudpush.aliyuncs.com"},
                {"eu-west-1", "cloudpush.aliyuncs.com"},
                {"eu-west-1-oxs", "cloudpush.aliyuncs.com"},
                {"me-east-1", "cloudpush.aliyuncs.com"},
                {"rus-west-1-pop", "cloudpush.aliyuncs.com"},
                {"us-east-1", "cloudpush.aliyuncs.com"},
                {"us-west-1", "cloudpush.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("push", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public BindAliasResponse BindAliasWithOptions(BindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAliasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindAliasResponse> BindAliasWithOptionsAsync(BindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindAliasResponse BindAlias(BindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAliasWithOptions(request, runtime);
        }

        public async Task<BindAliasResponse> BindAliasAsync(BindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAliasWithOptionsAsync(request, runtime);
        }

        public BindPhoneResponse BindPhoneWithOptions(BindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPhone",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPhoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindPhoneResponse> BindPhoneWithOptionsAsync(BindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPhone",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPhoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindPhoneResponse BindPhone(BindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPhoneWithOptions(request, runtime);
        }

        public async Task<BindPhoneResponse> BindPhoneAsync(BindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPhoneWithOptionsAsync(request, runtime);
        }

        public BindTagResponse BindTagWithOptions(BindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindTagResponse> BindTagWithOptionsAsync(BindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindTagResponse BindTag(BindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindTagWithOptions(request, runtime);
        }

        public async Task<BindTagResponse> BindTagAsync(BindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindTagWithOptionsAsync(request, runtime);
        }

        public CancelPushResponse CancelPushWithOptions(CancelPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPushResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelPushResponse> CancelPushWithOptionsAsync(CancelPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelPushResponse CancelPush(CancelPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPushWithOptions(request, runtime);
        }

        public async Task<CancelPushResponse> CancelPushAsync(CancelPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPushWithOptionsAsync(request, runtime);
        }

        public CheckCertificateResponse CheckCertificateWithOptions(CheckCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCertificate",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckCertificateResponse> CheckCertificateWithOptionsAsync(CheckCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCertificate",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckCertificateResponse CheckCertificate(CheckCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCertificateWithOptions(request, runtime);
        }

        public async Task<CheckCertificateResponse> CheckCertificateAsync(CheckCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request CheckDeviceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CheckDeviceResponse
         */
        // Deprecated
        public CheckDeviceResponse CheckDeviceWithOptions(CheckDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevice",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request CheckDeviceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CheckDeviceResponse
         */
        // Deprecated
        public async Task<CheckDeviceResponse> CheckDeviceWithOptionsAsync(CheckDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevice",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request CheckDeviceRequest
          * @return CheckDeviceResponse
         */
        // Deprecated
        public CheckDeviceResponse CheckDevice(CheckDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDeviceWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request CheckDeviceRequest
          * @return CheckDeviceResponse
         */
        // Deprecated
        public async Task<CheckDeviceResponse> CheckDeviceAsync(CheckDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDeviceWithOptionsAsync(request, runtime);
        }

        public CheckDevicesResponse CheckDevicesWithOptions(CheckDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                query["DeviceIds"] = request.DeviceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevices",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDevicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDevicesResponse> CheckDevicesWithOptionsAsync(CheckDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIds))
            {
                query["DeviceIds"] = request.DeviceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDevices",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDevicesResponse CheckDevices(CheckDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDevicesWithOptions(request, runtime);
        }

        public async Task<CheckDevicesResponse> CheckDevicesAsync(CheckDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDevicesWithOptionsAsync(request, runtime);
        }

        public CompleteContinuouslyPushResponse CompleteContinuouslyPushWithOptions(CompleteContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteContinuouslyPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteContinuouslyPushResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CompleteContinuouslyPushResponse> CompleteContinuouslyPushWithOptionsAsync(CompleteContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteContinuouslyPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteContinuouslyPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CompleteContinuouslyPushResponse CompleteContinuouslyPush(CompleteContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteContinuouslyPushWithOptions(request, runtime);
        }

        public async Task<CompleteContinuouslyPushResponse> CompleteContinuouslyPushAsync(CompleteContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteContinuouslyPushWithOptionsAsync(request, runtime);
        }

        public ContinuouslyPushResponse ContinuouslyPushWithOptions(ContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinuouslyPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinuouslyPushResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ContinuouslyPushResponse> ContinuouslyPushWithOptionsAsync(ContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinuouslyPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinuouslyPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ContinuouslyPushResponse ContinuouslyPush(ContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinuouslyPushWithOptions(request, runtime);
        }

        public async Task<ContinuouslyPushResponse> ContinuouslyPushAsync(ContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinuouslyPushWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request ListSummaryAppsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSummaryAppsResponse
         */
        // Deprecated
        public ListSummaryAppsResponse ListSummaryAppsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSummaryApps",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSummaryAppsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request ListSummaryAppsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSummaryAppsResponse
         */
        // Deprecated
        public async Task<ListSummaryAppsResponse> ListSummaryAppsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSummaryApps",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSummaryAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @return ListSummaryAppsResponse
         */
        // Deprecated
        public ListSummaryAppsResponse ListSummaryApps()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSummaryAppsWithOptions(runtime);
        }

        /**
          * @deprecated
          *
          * @return ListSummaryAppsResponse
         */
        // Deprecated
        public async Task<ListSummaryAppsResponse> ListSummaryAppsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSummaryAppsWithOptionsAsync(runtime);
        }

        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTags",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTags",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsWithOptions(request, runtime);
        }

        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsWithOptionsAsync(request, runtime);
        }

        public MassPushResponse MassPushWithOptions(MassPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTask))
            {
                body["PushTask"] = request.PushTask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MassPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MassPushResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MassPushResponse> MassPushWithOptionsAsync(MassPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTask))
            {
                body["PushTask"] = request.PushTask;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MassPush",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MassPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MassPushResponse MassPush(MassPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MassPushWithOptions(request, runtime);
        }

        public async Task<MassPushResponse> MassPushAsync(MassPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MassPushWithOptionsAsync(request, runtime);
        }

        public PushResponse PushWithOptions(PushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidActivity))
            {
                query["AndroidActivity"] = request.AndroidActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigBody))
            {
                query["AndroidBigBody"] = request.AndroidBigBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigPictureUrl))
            {
                query["AndroidBigPictureUrl"] = request.AndroidBigPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigTitle))
            {
                query["AndroidBigTitle"] = request.AndroidBigTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidExtParameters))
            {
                query["AndroidExtParameters"] = request.AndroidExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiReceiptId))
            {
                query["AndroidHuaweiReceiptId"] = request.AndroidHuaweiReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiTargetUserType))
            {
                query["AndroidHuaweiTargetUserType"] = request.AndroidHuaweiTargetUserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidImageUrl))
            {
                query["AndroidImageUrl"] = request.AndroidImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInboxBody))
            {
                query["AndroidInboxBody"] = request.AndroidInboxBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageHuaweiCategory))
            {
                query["AndroidMessageHuaweiCategory"] = request.AndroidMessageHuaweiCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageHuaweiUrgency))
            {
                query["AndroidMessageHuaweiUrgency"] = request.AndroidMessageHuaweiUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageVivoCategory))
            {
                query["AndroidMessageVivoCategory"] = request.AndroidMessageVivoCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMusic))
            {
                query["AndroidMusic"] = request.AndroidMusic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationBarPriority))
            {
                query["AndroidNotificationBarPriority"] = request.AndroidNotificationBarPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationBarType))
            {
                query["AndroidNotificationBarType"] = request.AndroidNotificationBarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationChannel))
            {
                query["AndroidNotificationChannel"] = request.AndroidNotificationChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationGroup))
            {
                query["AndroidNotificationGroup"] = request.AndroidNotificationGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationHonorChannel))
            {
                query["AndroidNotificationHonorChannel"] = request.AndroidNotificationHonorChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationHuaweiChannel))
            {
                query["AndroidNotificationHuaweiChannel"] = request.AndroidNotificationHuaweiChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationNotifyId))
            {
                query["AndroidNotificationNotifyId"] = request.AndroidNotificationNotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationVivoChannel))
            {
                query["AndroidNotificationVivoChannel"] = request.AndroidNotificationVivoChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationXiaomiChannel))
            {
                query["AndroidNotificationXiaomiChannel"] = request.AndroidNotificationXiaomiChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotifyType))
            {
                query["AndroidNotifyType"] = request.AndroidNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOpenType))
            {
                query["AndroidOpenType"] = request.AndroidOpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOpenUrl))
            {
                query["AndroidOpenUrl"] = request.AndroidOpenUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupActivity))
            {
                query["AndroidPopupActivity"] = request.AndroidPopupActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupBody))
            {
                query["AndroidPopupBody"] = request.AndroidPopupBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupTitle))
            {
                query["AndroidPopupTitle"] = request.AndroidPopupTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidRemind))
            {
                query["AndroidRemind"] = request.AndroidRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidRenderStyle))
            {
                query["AndroidRenderStyle"] = request.AndroidRenderStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidVivoPushMode))
            {
                query["AndroidVivoPushMode"] = request.AndroidVivoPushMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiActivity))
            {
                query["AndroidXiaoMiActivity"] = request.AndroidXiaoMiActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiNotifyBody))
            {
                query["AndroidXiaoMiNotifyBody"] = request.AndroidXiaoMiNotifyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiNotifyTitle))
            {
                query["AndroidXiaoMiNotifyTitle"] = request.AndroidXiaoMiNotifyTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiBigPictureUrl))
            {
                query["AndroidXiaomiBigPictureUrl"] = request.AndroidXiaomiBigPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiImageUrl))
            {
                query["AndroidXiaomiImageUrl"] = request.AndroidXiaomiImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTime))
            {
                query["PushTime"] = request.PushTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannels))
            {
                query["SendChannels"] = request.SendChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendSpeed))
            {
                query["SendSpeed"] = request.SendSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsDelaySecs))
            {
                query["SmsDelaySecs"] = request.SmsDelaySecs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsParams))
            {
                query["SmsParams"] = request.SmsParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSendPolicy))
            {
                query["SmsSendPolicy"] = request.SmsSendPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                query["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateName))
            {
                query["SmsTemplateName"] = request.SmsTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trim))
            {
                query["Trim"] = request.Trim;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSApnsEnv))
            {
                query["iOSApnsEnv"] = request.IOSApnsEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSBadge))
            {
                query["iOSBadge"] = request.IOSBadge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSBadgeAutoIncrement))
            {
                query["iOSBadgeAutoIncrement"] = request.IOSBadgeAutoIncrement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSExtParameters))
            {
                query["iOSExtParameters"] = request.IOSExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSInterruptionLevel))
            {
                query["iOSInterruptionLevel"] = request.IOSInterruptionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSMusic))
            {
                query["iOSMusic"] = request.IOSMusic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSMutableContent))
            {
                query["iOSMutableContent"] = request.IOSMutableContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationCategory))
            {
                query["iOSNotificationCategory"] = request.IOSNotificationCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationCollapseId))
            {
                query["iOSNotificationCollapseId"] = request.IOSNotificationCollapseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationThreadId))
            {
                query["iOSNotificationThreadId"] = request.IOSNotificationThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRelevanceScore))
            {
                query["iOSRelevanceScore"] = request.IOSRelevanceScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRemind))
            {
                query["iOSRemind"] = request.IOSRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRemindBody))
            {
                query["iOSRemindBody"] = request.IOSRemindBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSSilentNotification))
            {
                query["iOSSilentNotification"] = request.IOSSilentNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSSubtitle))
            {
                query["iOSSubtitle"] = request.IOSSubtitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Push",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushResponse> PushWithOptionsAsync(PushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidActivity))
            {
                query["AndroidActivity"] = request.AndroidActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigBody))
            {
                query["AndroidBigBody"] = request.AndroidBigBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigPictureUrl))
            {
                query["AndroidBigPictureUrl"] = request.AndroidBigPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidBigTitle))
            {
                query["AndroidBigTitle"] = request.AndroidBigTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidExtParameters))
            {
                query["AndroidExtParameters"] = request.AndroidExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiReceiptId))
            {
                query["AndroidHuaweiReceiptId"] = request.AndroidHuaweiReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidHuaweiTargetUserType))
            {
                query["AndroidHuaweiTargetUserType"] = request.AndroidHuaweiTargetUserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidImageUrl))
            {
                query["AndroidImageUrl"] = request.AndroidImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInboxBody))
            {
                query["AndroidInboxBody"] = request.AndroidInboxBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageHuaweiCategory))
            {
                query["AndroidMessageHuaweiCategory"] = request.AndroidMessageHuaweiCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageHuaweiUrgency))
            {
                query["AndroidMessageHuaweiUrgency"] = request.AndroidMessageHuaweiUrgency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMessageVivoCategory))
            {
                query["AndroidMessageVivoCategory"] = request.AndroidMessageVivoCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidMusic))
            {
                query["AndroidMusic"] = request.AndroidMusic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationBarPriority))
            {
                query["AndroidNotificationBarPriority"] = request.AndroidNotificationBarPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationBarType))
            {
                query["AndroidNotificationBarType"] = request.AndroidNotificationBarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationChannel))
            {
                query["AndroidNotificationChannel"] = request.AndroidNotificationChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationGroup))
            {
                query["AndroidNotificationGroup"] = request.AndroidNotificationGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationHonorChannel))
            {
                query["AndroidNotificationHonorChannel"] = request.AndroidNotificationHonorChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationHuaweiChannel))
            {
                query["AndroidNotificationHuaweiChannel"] = request.AndroidNotificationHuaweiChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationNotifyId))
            {
                query["AndroidNotificationNotifyId"] = request.AndroidNotificationNotifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationVivoChannel))
            {
                query["AndroidNotificationVivoChannel"] = request.AndroidNotificationVivoChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotificationXiaomiChannel))
            {
                query["AndroidNotificationXiaomiChannel"] = request.AndroidNotificationXiaomiChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidNotifyType))
            {
                query["AndroidNotifyType"] = request.AndroidNotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOpenType))
            {
                query["AndroidOpenType"] = request.AndroidOpenType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidOpenUrl))
            {
                query["AndroidOpenUrl"] = request.AndroidOpenUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupActivity))
            {
                query["AndroidPopupActivity"] = request.AndroidPopupActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupBody))
            {
                query["AndroidPopupBody"] = request.AndroidPopupBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPopupTitle))
            {
                query["AndroidPopupTitle"] = request.AndroidPopupTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidRemind))
            {
                query["AndroidRemind"] = request.AndroidRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidRenderStyle))
            {
                query["AndroidRenderStyle"] = request.AndroidRenderStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidVivoPushMode))
            {
                query["AndroidVivoPushMode"] = request.AndroidVivoPushMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiActivity))
            {
                query["AndroidXiaoMiActivity"] = request.AndroidXiaoMiActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiNotifyBody))
            {
                query["AndroidXiaoMiNotifyBody"] = request.AndroidXiaoMiNotifyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaoMiNotifyTitle))
            {
                query["AndroidXiaoMiNotifyTitle"] = request.AndroidXiaoMiNotifyTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiBigPictureUrl))
            {
                query["AndroidXiaomiBigPictureUrl"] = request.AndroidXiaomiBigPictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidXiaomiImageUrl))
            {
                query["AndroidXiaomiImageUrl"] = request.AndroidXiaomiImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushTime))
            {
                query["PushTime"] = request.PushTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannels))
            {
                query["SendChannels"] = request.SendChannels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendSpeed))
            {
                query["SendSpeed"] = request.SendSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsDelaySecs))
            {
                query["SmsDelaySecs"] = request.SmsDelaySecs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsParams))
            {
                query["SmsParams"] = request.SmsParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSendPolicy))
            {
                query["SmsSendPolicy"] = request.SmsSendPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsSignName))
            {
                query["SmsSignName"] = request.SmsSignName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsTemplateName))
            {
                query["SmsTemplateName"] = request.SmsTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreOffline))
            {
                query["StoreOffline"] = request.StoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trim))
            {
                query["Trim"] = request.Trim;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSApnsEnv))
            {
                query["iOSApnsEnv"] = request.IOSApnsEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSBadge))
            {
                query["iOSBadge"] = request.IOSBadge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSBadgeAutoIncrement))
            {
                query["iOSBadgeAutoIncrement"] = request.IOSBadgeAutoIncrement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSExtParameters))
            {
                query["iOSExtParameters"] = request.IOSExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSInterruptionLevel))
            {
                query["iOSInterruptionLevel"] = request.IOSInterruptionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSMusic))
            {
                query["iOSMusic"] = request.IOSMusic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSMutableContent))
            {
                query["iOSMutableContent"] = request.IOSMutableContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationCategory))
            {
                query["iOSNotificationCategory"] = request.IOSNotificationCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationCollapseId))
            {
                query["iOSNotificationCollapseId"] = request.IOSNotificationCollapseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSNotificationThreadId))
            {
                query["iOSNotificationThreadId"] = request.IOSNotificationThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRelevanceScore))
            {
                query["iOSRelevanceScore"] = request.IOSRelevanceScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRemind))
            {
                query["iOSRemind"] = request.IOSRemind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSRemindBody))
            {
                query["iOSRemindBody"] = request.IOSRemindBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSSilentNotification))
            {
                query["iOSSilentNotification"] = request.IOSSilentNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IOSSubtitle))
            {
                query["iOSSubtitle"] = request.IOSSubtitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Push",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushResponse Push(PushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushWithOptions(request, runtime);
        }

        public async Task<PushResponse> PushAsync(PushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushWithOptionsAsync(request, runtime);
        }

        public PushMessageToAndroidResponse PushMessageToAndroidWithOptions(PushMessageToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMessageToAndroid",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMessageToAndroidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushMessageToAndroidResponse> PushMessageToAndroidWithOptionsAsync(PushMessageToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMessageToAndroid",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMessageToAndroidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushMessageToAndroidResponse PushMessageToAndroid(PushMessageToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMessageToAndroidWithOptions(request, runtime);
        }

        public async Task<PushMessageToAndroidResponse> PushMessageToAndroidAsync(PushMessageToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMessageToAndroidWithOptionsAsync(request, runtime);
        }

        public PushMessageToiOSResponse PushMessageToiOSWithOptions(PushMessageToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMessageToiOS",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMessageToiOSResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushMessageToiOSResponse> PushMessageToiOSWithOptionsAsync(PushMessageToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMessageToiOS",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMessageToiOSResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushMessageToiOSResponse PushMessageToiOS(PushMessageToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMessageToiOSWithOptions(request, runtime);
        }

        public async Task<PushMessageToiOSResponse> PushMessageToiOSAsync(PushMessageToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMessageToiOSWithOptionsAsync(request, runtime);
        }

        public PushNoticeToAndroidResponse PushNoticeToAndroidWithOptions(PushNoticeToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParameters))
            {
                query["ExtParameters"] = request.ExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNoticeToAndroid",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushNoticeToAndroidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushNoticeToAndroidResponse> PushNoticeToAndroidWithOptionsAsync(PushNoticeToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParameters))
            {
                query["ExtParameters"] = request.ExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNoticeToAndroid",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushNoticeToAndroidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushNoticeToAndroidResponse PushNoticeToAndroid(PushNoticeToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushNoticeToAndroidWithOptions(request, runtime);
        }

        public async Task<PushNoticeToAndroidResponse> PushNoticeToAndroidAsync(PushNoticeToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushNoticeToAndroidWithOptionsAsync(request, runtime);
        }

        public PushNoticeToiOSResponse PushNoticeToiOSWithOptions(PushNoticeToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApnsEnv))
            {
                query["ApnsEnv"] = request.ApnsEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParameters))
            {
                query["ExtParameters"] = request.ExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNoticeToiOS",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushNoticeToiOSResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushNoticeToiOSResponse> PushNoticeToiOSWithOptionsAsync(PushNoticeToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApnsEnv))
            {
                query["ApnsEnv"] = request.ApnsEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                query["Body"] = request.Body;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParameters))
            {
                query["ExtParameters"] = request.ExtParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobKey))
            {
                query["JobKey"] = request.JobKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetValue))
            {
                query["TargetValue"] = request.TargetValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNoticeToiOS",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushNoticeToiOSResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushNoticeToiOSResponse PushNoticeToiOS(PushNoticeToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushNoticeToiOSWithOptions(request, runtime);
        }

        public async Task<PushNoticeToiOSResponse> PushNoticeToiOSAsync(PushNoticeToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushNoticeToiOSWithOptionsAsync(request, runtime);
        }

        public QueryAliasesResponse QueryAliasesWithOptions(QueryAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAliases",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAliasesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryAliasesResponse> QueryAliasesWithOptionsAsync(QueryAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAliases",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAliasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryAliasesResponse QueryAliases(QueryAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAliasesWithOptions(request, runtime);
        }

        public async Task<QueryAliasesResponse> QueryAliasesAsync(QueryAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAliasesWithOptionsAsync(request, runtime);
        }

        public QueryDeviceInfoResponse QueryDeviceInfoWithOptions(QueryDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceInfo",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceInfoResponse> QueryDeviceInfoWithOptionsAsync(QueryDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceInfo",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceInfoResponse QueryDeviceInfo(QueryDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceInfoWithOptions(request, runtime);
        }

        public async Task<QueryDeviceInfoResponse> QueryDeviceInfoAsync(QueryDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceInfoWithOptionsAsync(request, runtime);
        }

        public QueryDeviceStatResponse QueryDeviceStatWithOptions(QueryDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
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
                Action = "QueryDeviceStat",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceStatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDeviceStatResponse> QueryDeviceStatWithOptionsAsync(QueryDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
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
                Action = "QueryDeviceStat",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceStatResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDeviceStatResponse QueryDeviceStat(QueryDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceStatWithOptions(request, runtime);
        }

        public async Task<QueryDeviceStatResponse> QueryDeviceStatAsync(QueryDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceStatWithOptionsAsync(request, runtime);
        }

        public QueryDevicesByAccountResponse QueryDevicesByAccountWithOptions(QueryDevicesByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesByAccount",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesByAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDevicesByAccountResponse> QueryDevicesByAccountWithOptionsAsync(QueryDevicesByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesByAccount",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesByAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDevicesByAccountResponse QueryDevicesByAccount(QueryDevicesByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesByAccountWithOptions(request, runtime);
        }

        public async Task<QueryDevicesByAccountResponse> QueryDevicesByAccountAsync(QueryDevicesByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesByAccountWithOptionsAsync(request, runtime);
        }

        public QueryDevicesByAliasResponse QueryDevicesByAliasWithOptions(QueryDevicesByAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesByAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesByAliasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDevicesByAliasResponse> QueryDevicesByAliasWithOptionsAsync(QueryDevicesByAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                query["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDevicesByAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicesByAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDevicesByAliasResponse QueryDevicesByAlias(QueryDevicesByAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesByAliasWithOptions(request, runtime);
        }

        public async Task<QueryDevicesByAliasResponse> QueryDevicesByAliasAsync(QueryDevicesByAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesByAliasWithOptionsAsync(request, runtime);
        }

        public QueryPushRecordsResponse QueryPushRecordsWithOptions(QueryPushRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushRecords",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushRecordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPushRecordsResponse> QueryPushRecordsWithOptionsAsync(QueryPushRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushRecords",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPushRecordsResponse QueryPushRecords(QueryPushRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushRecordsWithOptions(request, runtime);
        }

        public async Task<QueryPushRecordsResponse> QueryPushRecordsAsync(QueryPushRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushRecordsWithOptionsAsync(request, runtime);
        }

        public QueryPushStatByAppResponse QueryPushStatByAppWithOptions(QueryPushStatByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
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
                Action = "QueryPushStatByApp",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushStatByAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPushStatByAppResponse> QueryPushStatByAppWithOptionsAsync(QueryPushStatByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
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
                Action = "QueryPushStatByApp",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushStatByAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPushStatByAppResponse QueryPushStatByApp(QueryPushStatByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushStatByAppWithOptions(request, runtime);
        }

        public async Task<QueryPushStatByAppResponse> QueryPushStatByAppAsync(QueryPushStatByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushStatByAppWithOptionsAsync(request, runtime);
        }

        public QueryPushStatByMsgResponse QueryPushStatByMsgWithOptions(QueryPushStatByMsgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushStatByMsg",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushStatByMsgResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryPushStatByMsgResponse> QueryPushStatByMsgWithOptionsAsync(QueryPushStatByMsgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPushStatByMsg",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPushStatByMsgResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryPushStatByMsgResponse QueryPushStatByMsg(QueryPushStatByMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushStatByMsgWithOptions(request, runtime);
        }

        public async Task<QueryPushStatByMsgResponse> QueryPushStatByMsgAsync(QueryPushStatByMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushStatByMsgWithOptionsAsync(request, runtime);
        }

        public QueryTagsResponse QueryTagsWithOptions(QueryTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTags",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTagsResponse> QueryTagsWithOptionsAsync(QueryTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTags",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTagsResponse QueryTags(QueryTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagsWithOptions(request, runtime);
        }

        public async Task<QueryTagsResponse> QueryTagsAsync(QueryTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagsWithOptionsAsync(request, runtime);
        }

        public QueryUniqueDeviceStatResponse QueryUniqueDeviceStatWithOptions(QueryUniqueDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
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
                Action = "QueryUniqueDeviceStat",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUniqueDeviceStatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryUniqueDeviceStatResponse> QueryUniqueDeviceStatWithOptionsAsync(QueryUniqueDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
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
                Action = "QueryUniqueDeviceStat",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUniqueDeviceStatResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryUniqueDeviceStatResponse QueryUniqueDeviceStat(QueryUniqueDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUniqueDeviceStatWithOptions(request, runtime);
        }

        public async Task<QueryUniqueDeviceStatResponse> QueryUniqueDeviceStatAsync(QueryUniqueDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUniqueDeviceStatWithOptionsAsync(request, runtime);
        }

        public RemoveTagResponse RemoveTagWithOptions(RemoveTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveTagResponse> RemoveTagWithOptionsAsync(RemoveTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveTagResponse RemoveTag(RemoveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagWithOptions(request, runtime);
        }

        public async Task<RemoveTagResponse> RemoveTagAsync(RemoveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagWithOptionsAsync(request, runtime);
        }

        public UnbindAliasResponse UnbindAliasWithOptions(UnbindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindAll))
            {
                query["UnbindAll"] = request.UnbindAll;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAliasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindAliasResponse> UnbindAliasWithOptionsAsync(UnbindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindAll))
            {
                query["UnbindAll"] = request.UnbindAll;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAlias",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindAliasResponse UnbindAlias(UnbindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAliasWithOptions(request, runtime);
        }

        public async Task<UnbindAliasResponse> UnbindAliasAsync(UnbindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAliasWithOptionsAsync(request, runtime);
        }

        public UnbindPhoneResponse UnbindPhoneWithOptions(UnbindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPhone",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPhoneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindPhoneResponse> UnbindPhoneWithOptionsAsync(UnbindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPhone",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPhoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindPhoneResponse UnbindPhone(UnbindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPhoneWithOptions(request, runtime);
        }

        public async Task<UnbindPhoneResponse> UnbindPhoneAsync(UnbindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPhoneWithOptionsAsync(request, runtime);
        }

        public UnbindTagResponse UnbindTagWithOptions(UnbindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindTagResponse> UnbindTagWithOptionsAsync(UnbindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["AppKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKey))
            {
                query["ClientKey"] = request.ClientKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyType))
            {
                query["KeyType"] = request.KeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindTag",
                Version = "2016-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindTagResponse UnbindTag(UnbindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindTagWithOptions(request, runtime);
        }

        public async Task<UnbindTagResponse> UnbindTagAsync(UnbindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindTagWithOptionsAsync(request, runtime);
        }

    }
}
