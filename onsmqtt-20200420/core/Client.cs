// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OnsMqtt20200420.Models;

namespace AlibabaCloud.SDK.OnsMqtt20200420
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("onsmqtt", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 激活CA证书
         *
         * @param request ActiveCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActiveCaCertificateResponse
         */
        public ActiveCaCertificateResponse ActiveCaCertificateWithOptions(ActiveCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveCaCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 激活CA证书
         *
         * @param request ActiveCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActiveCaCertificateResponse
         */
        public async Task<ActiveCaCertificateResponse> ActiveCaCertificateWithOptionsAsync(ActiveCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveCaCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 激活CA证书
         *
         * @param request ActiveCaCertificateRequest
         * @return ActiveCaCertificateResponse
         */
        public ActiveCaCertificateResponse ActiveCaCertificate(ActiveCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveCaCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 激活CA证书
         *
         * @param request ActiveCaCertificateRequest
         * @return ActiveCaCertificateResponse
         */
        public async Task<ActiveCaCertificateResponse> ActiveCaCertificateAsync(ActiveCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveCaCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 激活设备证书
         *
         * @param request ActiveDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActiveDeviceCertificateResponse
         */
        public ActiveDeviceCertificateResponse ActiveDeviceCertificateWithOptions(ActiveDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaSn))
            {
                query["CaSn"] = request.CaSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveDeviceCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 激活设备证书
         *
         * @param request ActiveDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActiveDeviceCertificateResponse
         */
        public async Task<ActiveDeviceCertificateResponse> ActiveDeviceCertificateWithOptionsAsync(ActiveDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaSn))
            {
                query["CaSn"] = request.CaSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveDeviceCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 激活设备证书
         *
         * @param request ActiveDeviceCertificateRequest
         * @return ActiveDeviceCertificateResponse
         */
        public ActiveDeviceCertificateResponse ActiveDeviceCertificate(ActiveDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveDeviceCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 激活设备证书
         *
         * @param request ActiveDeviceCertificateRequest
         * @return ActiveDeviceCertificateResponse
         */
        public async Task<ActiveDeviceCertificateResponse> ActiveDeviceCertificateAsync(ActiveDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a device to the connection blacklist to disable connections from the device.
         *
         * @param request AddCustomAuthConnectBlackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomAuthConnectBlackResponse
         */
        public AddCustomAuthConnectBlackResponse AddCustomAuthConnectBlackWithOptions(AddCustomAuthConnectBlackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomAuthConnectBlack",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomAuthConnectBlackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a device to the connection blacklist to disable connections from the device.
         *
         * @param request AddCustomAuthConnectBlackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomAuthConnectBlackResponse
         */
        public async Task<AddCustomAuthConnectBlackResponse> AddCustomAuthConnectBlackWithOptionsAsync(AddCustomAuthConnectBlackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomAuthConnectBlack",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomAuthConnectBlackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a device to the connection blacklist to disable connections from the device.
         *
         * @param request AddCustomAuthConnectBlackRequest
         * @return AddCustomAuthConnectBlackResponse
         */
        public AddCustomAuthConnectBlackResponse AddCustomAuthConnectBlack(AddCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthConnectBlackWithOptions(request, runtime);
        }

        /**
         * @summary Adds a device to the connection blacklist to disable connections from the device.
         *
         * @param request AddCustomAuthConnectBlackRequest
         * @return AddCustomAuthConnectBlackResponse
         */
        public async Task<AddCustomAuthConnectBlackResponse> AddCustomAuthConnectBlackAsync(AddCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds the information about identity authentication. The identity can be accurate to a client.
         *
         * @param request AddCustomAuthIdentityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomAuthIdentityResponse
         */
        public AddCustomAuthIdentityResponse AddCustomAuthIdentityWithOptions(AddCustomAuthIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Secret))
            {
                body["Secret"] = request.Secret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignMode))
            {
                body["SignMode"] = request.SignMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomAuthIdentity",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomAuthIdentityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds the information about identity authentication. The identity can be accurate to a client.
         *
         * @param request AddCustomAuthIdentityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomAuthIdentityResponse
         */
        public async Task<AddCustomAuthIdentityResponse> AddCustomAuthIdentityWithOptionsAsync(AddCustomAuthIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Secret))
            {
                body["Secret"] = request.Secret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignMode))
            {
                body["SignMode"] = request.SignMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomAuthIdentity",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomAuthIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds the information about identity authentication. The identity can be accurate to a client.
         *
         * @param request AddCustomAuthIdentityRequest
         * @return AddCustomAuthIdentityResponse
         */
        public AddCustomAuthIdentityResponse AddCustomAuthIdentity(AddCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthIdentityWithOptions(request, runtime);
        }

        /**
         * @summary Adds the information about identity authentication. The identity can be accurate to a client.
         *
         * @param request AddCustomAuthIdentityRequest
         * @return AddCustomAuthIdentityResponse
         */
        public async Task<AddCustomAuthIdentityResponse> AddCustomAuthIdentityAsync(AddCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds permissions on topics. You must create a level-1 topic in the ApsaraMQ for MQTT console before you call this operation.
         *
         * @param request AddCustomAuthPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomAuthPermissionResponse
         */
        public AddCustomAuthPermissionResponse AddCustomAuthPermissionWithOptions(AddCustomAuthPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["Effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["Identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitAction))
            {
                body["PermitAction"] = request.PermitAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomAuthPermission",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomAuthPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds permissions on topics. You must create a level-1 topic in the ApsaraMQ for MQTT console before you call this operation.
         *
         * @param request AddCustomAuthPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomAuthPermissionResponse
         */
        public async Task<AddCustomAuthPermissionResponse> AddCustomAuthPermissionWithOptionsAsync(AddCustomAuthPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["Effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["Identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitAction))
            {
                body["PermitAction"] = request.PermitAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomAuthPermission",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomAuthPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds permissions on topics. You must create a level-1 topic in the ApsaraMQ for MQTT console before you call this operation.
         *
         * @param request AddCustomAuthPermissionRequest
         * @return AddCustomAuthPermissionResponse
         */
        public AddCustomAuthPermissionResponse AddCustomAuthPermission(AddCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthPermissionWithOptions(request, runtime);
        }

        /**
         * @summary Adds permissions on topics. You must create a level-1 topic in the ApsaraMQ for MQTT console before you call this operation.
         *
         * @param request AddCustomAuthPermissionRequest
         * @return AddCustomAuthPermissionResponse
         */
        public async Task<AddCustomAuthPermissionResponse> AddCustomAuthPermissionAsync(AddCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Applies for a token from ApsaraMQ for MQTT. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker.
         *
         * @description *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **ApplyToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request ApplyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyTokenResponse
         */
        public ApplyTokenResponse ApplyTokenWithOptions(ApplyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Actions))
            {
                query["Actions"] = request.Actions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyToken",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Applies for a token from ApsaraMQ for MQTT. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker.
         *
         * @description *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **ApplyToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request ApplyTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyTokenResponse
         */
        public async Task<ApplyTokenResponse> ApplyTokenWithOptionsAsync(ApplyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Actions))
            {
                query["Actions"] = request.Actions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyToken",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Applies for a token from ApsaraMQ for MQTT. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker.
         *
         * @description *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **ApplyToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request ApplyTokenRequest
         * @return ApplyTokenResponse
         */
        public ApplyTokenResponse ApplyToken(ApplyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyTokenWithOptions(request, runtime);
        }

        /**
         * @summary Applies for a token from ApsaraMQ for MQTT. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker.
         *
         * @description *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **ApplyToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request ApplyTokenRequest
         * @return ApplyTokenResponse
         */
        public async Task<ApplyTokenResponse> ApplyTokenAsync(ApplyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of multiple ApsaraMQ for MQTT clients by client ID.
         *
         * @description *   You can call the **BatchQuerySessionByClientIds** operation up to 100 times per second. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   You can call the **BatchQuerySessionByClientIds** operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.
         * *   Each successful call to the **BatchQuerySessionByClientIds** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request BatchQuerySessionByClientIdsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchQuerySessionByClientIdsResponse
         */
        public BatchQuerySessionByClientIdsResponse BatchQuerySessionByClientIdsWithOptions(BatchQuerySessionByClientIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdList))
            {
                query["ClientIdList"] = request.ClientIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQuerySessionByClientIds",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQuerySessionByClientIdsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of multiple ApsaraMQ for MQTT clients by client ID.
         *
         * @description *   You can call the **BatchQuerySessionByClientIds** operation up to 100 times per second. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   You can call the **BatchQuerySessionByClientIds** operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.
         * *   Each successful call to the **BatchQuerySessionByClientIds** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request BatchQuerySessionByClientIdsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchQuerySessionByClientIdsResponse
         */
        public async Task<BatchQuerySessionByClientIdsResponse> BatchQuerySessionByClientIdsWithOptionsAsync(BatchQuerySessionByClientIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdList))
            {
                query["ClientIdList"] = request.ClientIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQuerySessionByClientIds",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQuerySessionByClientIdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of multiple ApsaraMQ for MQTT clients by client ID.
         *
         * @description *   You can call the **BatchQuerySessionByClientIds** operation up to 100 times per second. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   You can call the **BatchQuerySessionByClientIds** operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.
         * *   Each successful call to the **BatchQuerySessionByClientIds** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request BatchQuerySessionByClientIdsRequest
         * @return BatchQuerySessionByClientIdsResponse
         */
        public BatchQuerySessionByClientIdsResponse BatchQuerySessionByClientIds(BatchQuerySessionByClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQuerySessionByClientIdsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status of multiple ApsaraMQ for MQTT clients by client ID.
         *
         * @description *   You can call the **BatchQuerySessionByClientIds** operation up to 100 times per second. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   You can call the **BatchQuerySessionByClientIds** operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.
         * *   Each successful call to the **BatchQuerySessionByClientIds** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request BatchQuerySessionByClientIdsRequest
         * @return BatchQuerySessionByClientIdsResponse
         */
        public async Task<BatchQuerySessionByClientIdsResponse> BatchQuerySessionByClientIdsAsync(BatchQuerySessionByClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQuerySessionByClientIdsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 关闭设备连接
         *
         * @param request CloseConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseConnectionResponse
         */
        public CloseConnectionResponse CloseConnectionWithOptions(CloseConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseConnection",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 关闭设备连接
         *
         * @param request CloseConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseConnectionResponse
         */
        public async Task<CloseConnectionResponse> CloseConnectionWithOptionsAsync(CloseConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseConnection",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 关闭设备连接
         *
         * @param request CloseConnectionRequest
         * @return CloseConnectionResponse
         */
        public CloseConnectionResponse CloseConnection(CloseConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseConnectionWithOptions(request, runtime);
        }

        /**
         * @summary 关闭设备连接
         *
         * @param request CloseConnectionRequest
         * @return CloseConnectionResponse
         */
        public async Task<CloseConnectionResponse> CloseConnectionAsync(CloseConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseConnectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a group ID. Before you connect producers and consumers to an ApsaraMQ for MQTT broker to send and receive messages, you must specify a unique ID for each client for identification. A client ID is in the format of \\<GroupID>@@@\\<DeviceID>. In the preceding format, DeviceID is the custom ID that you specify for the client, and GroupID is the ID of the group that you create on the ApsaraMQ for MQTT broker in advance.
         *
         * @description Each successful call to the **CreateGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request CreateGroupIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupIdResponse
         */
        public CreateGroupIdResponse CreateGroupIdWithOptions(CreateGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a group ID. Before you connect producers and consumers to an ApsaraMQ for MQTT broker to send and receive messages, you must specify a unique ID for each client for identification. A client ID is in the format of \\<GroupID>@@@\\<DeviceID>. In the preceding format, DeviceID is the custom ID that you specify for the client, and GroupID is the ID of the group that you create on the ApsaraMQ for MQTT broker in advance.
         *
         * @description Each successful call to the **CreateGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request CreateGroupIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupIdResponse
         */
        public async Task<CreateGroupIdResponse> CreateGroupIdWithOptionsAsync(CreateGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a group ID. Before you connect producers and consumers to an ApsaraMQ for MQTT broker to send and receive messages, you must specify a unique ID for each client for identification. A client ID is in the format of \\<GroupID>@@@\\<DeviceID>. In the preceding format, DeviceID is the custom ID that you specify for the client, and GroupID is the ID of the group that you create on the ApsaraMQ for MQTT broker in advance.
         *
         * @description Each successful call to the **CreateGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request CreateGroupIdRequest
         * @return CreateGroupIdResponse
         */
        public CreateGroupIdResponse CreateGroupId(CreateGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupIdWithOptions(request, runtime);
        }

        /**
         * @summary Creates a group ID. Before you connect producers and consumers to an ApsaraMQ for MQTT broker to send and receive messages, you must specify a unique ID for each client for identification. A client ID is in the format of \\<GroupID>@@@\\<DeviceID>. In the preceding format, DeviceID is the custom ID that you specify for the client, and GroupID is the ID of the group that you create on the ApsaraMQ for MQTT broker in advance.
         *
         * @description Each successful call to the **CreateGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request CreateGroupIdRequest
         * @return CreateGroupIdResponse
         */
        public async Task<CreateGroupIdResponse> CreateGroupIdAsync(CreateGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除CA证书
         *
         * @param request DeleteCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCaCertificateResponse
         */
        public DeleteCaCertificateResponse DeleteCaCertificateWithOptions(DeleteCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCaCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除CA证书
         *
         * @param request DeleteCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCaCertificateResponse
         */
        public async Task<DeleteCaCertificateResponse> DeleteCaCertificateWithOptionsAsync(DeleteCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCaCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除CA证书
         *
         * @param request DeleteCaCertificateRequest
         * @return DeleteCaCertificateResponse
         */
        public DeleteCaCertificateResponse DeleteCaCertificate(DeleteCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCaCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 删除CA证书
         *
         * @param request DeleteCaCertificateRequest
         * @return DeleteCaCertificateResponse
         */
        public async Task<DeleteCaCertificateResponse> DeleteCaCertificateAsync(DeleteCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCaCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除自定义权限连接黑名单
         *
         * @param request DeleteCustomAuthConnectBlackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomAuthConnectBlackResponse
         */
        public DeleteCustomAuthConnectBlackResponse DeleteCustomAuthConnectBlackWithOptions(DeleteCustomAuthConnectBlackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomAuthConnectBlack",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAuthConnectBlackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除自定义权限连接黑名单
         *
         * @param request DeleteCustomAuthConnectBlackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomAuthConnectBlackResponse
         */
        public async Task<DeleteCustomAuthConnectBlackResponse> DeleteCustomAuthConnectBlackWithOptionsAsync(DeleteCustomAuthConnectBlackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomAuthConnectBlack",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAuthConnectBlackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除自定义权限连接黑名单
         *
         * @param request DeleteCustomAuthConnectBlackRequest
         * @return DeleteCustomAuthConnectBlackResponse
         */
        public DeleteCustomAuthConnectBlackResponse DeleteCustomAuthConnectBlack(DeleteCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthConnectBlackWithOptions(request, runtime);
        }

        /**
         * @summary 删除自定义权限连接黑名单
         *
         * @param request DeleteCustomAuthConnectBlackRequest
         * @return DeleteCustomAuthConnectBlackResponse
         */
        public async Task<DeleteCustomAuthConnectBlackResponse> DeleteCustomAuthConnectBlackAsync(DeleteCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an identity for custom authorization.
         *
         * @param request DeleteCustomAuthIdentityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomAuthIdentityResponse
         */
        public DeleteCustomAuthIdentityResponse DeleteCustomAuthIdentityWithOptions(DeleteCustomAuthIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomAuthIdentity",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAuthIdentityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an identity for custom authorization.
         *
         * @param request DeleteCustomAuthIdentityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomAuthIdentityResponse
         */
        public async Task<DeleteCustomAuthIdentityResponse> DeleteCustomAuthIdentityWithOptionsAsync(DeleteCustomAuthIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomAuthIdentity",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAuthIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an identity for custom authorization.
         *
         * @param request DeleteCustomAuthIdentityRequest
         * @return DeleteCustomAuthIdentityResponse
         */
        public DeleteCustomAuthIdentityResponse DeleteCustomAuthIdentity(DeleteCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthIdentityWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an identity for custom authorization.
         *
         * @param request DeleteCustomAuthIdentityRequest
         * @return DeleteCustomAuthIdentityResponse
         */
        public async Task<DeleteCustomAuthIdentityResponse> DeleteCustomAuthIdentityAsync(DeleteCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes permissions on a topic.
         *
         * @param request DeleteCustomAuthPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomAuthPermissionResponse
         */
        public DeleteCustomAuthPermissionResponse DeleteCustomAuthPermissionWithOptions(DeleteCustomAuthPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["Identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomAuthPermission",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAuthPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes permissions on a topic.
         *
         * @param request DeleteCustomAuthPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomAuthPermissionResponse
         */
        public async Task<DeleteCustomAuthPermissionResponse> DeleteCustomAuthPermissionWithOptionsAsync(DeleteCustomAuthPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["Identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomAuthPermission",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAuthPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes permissions on a topic.
         *
         * @param request DeleteCustomAuthPermissionRequest
         * @return DeleteCustomAuthPermissionResponse
         */
        public DeleteCustomAuthPermissionResponse DeleteCustomAuthPermission(DeleteCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthPermissionWithOptions(request, runtime);
        }

        /**
         * @summary Deletes permissions on a topic.
         *
         * @param request DeleteCustomAuthPermissionRequest
         * @return DeleteCustomAuthPermissionResponse
         */
        public async Task<DeleteCustomAuthPermissionResponse> DeleteCustomAuthPermissionAsync(DeleteCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除设备证书
         *
         * @param request DeleteDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeviceCertificateResponse
         */
        public DeleteDeviceCertificateResponse DeleteDeviceCertificateWithOptions(DeleteDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaSn))
            {
                query["CaSn"] = request.CaSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeviceCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除设备证书
         *
         * @param request DeleteDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDeviceCertificateResponse
         */
        public async Task<DeleteDeviceCertificateResponse> DeleteDeviceCertificateWithOptionsAsync(DeleteDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaSn))
            {
                query["CaSn"] = request.CaSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeviceCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除设备证书
         *
         * @param request DeleteDeviceCertificateRequest
         * @return DeleteDeviceCertificateResponse
         */
        public DeleteDeviceCertificateResponse DeleteDeviceCertificate(DeleteDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 删除设备证书
         *
         * @param request DeleteDeviceCertificateRequest
         * @return DeleteDeviceCertificateResponse
         */
        public async Task<DeleteDeviceCertificateResponse> DeleteDeviceCertificateAsync(DeleteDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a group from an ApsaraMQ for MQTT instance.
         *
         * @description Each successful call to the **DeleteGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request DeleteGroupIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupIdResponse
         */
        public DeleteGroupIdResponse DeleteGroupIdWithOptions(DeleteGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a group from an ApsaraMQ for MQTT instance.
         *
         * @description Each successful call to the **DeleteGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request DeleteGroupIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupIdResponse
         */
        public async Task<DeleteGroupIdResponse> DeleteGroupIdWithOptionsAsync(DeleteGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a group from an ApsaraMQ for MQTT instance.
         *
         * @description Each successful call to the **DeleteGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request DeleteGroupIdRequest
         * @return DeleteGroupIdResponse
         */
        public DeleteGroupIdResponse DeleteGroupId(DeleteGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupIdWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a group from an ApsaraMQ for MQTT instance.
         *
         * @description Each successful call to the **DeleteGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request DeleteGroupIdRequest
         * @return DeleteGroupIdResponse
         */
        public async Task<DeleteGroupIdResponse> DeleteGroupIdAsync(DeleteGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据SN返回CA证书
         *
         * @param request GetCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCaCertificateResponse
         */
        public GetCaCertificateResponse GetCaCertificateWithOptions(GetCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCaCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据SN返回CA证书
         *
         * @param request GetCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCaCertificateResponse
         */
        public async Task<GetCaCertificateResponse> GetCaCertificateWithOptionsAsync(GetCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCaCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据SN返回CA证书
         *
         * @param request GetCaCertificateRequest
         * @return GetCaCertificateResponse
         */
        public GetCaCertificateResponse GetCaCertificate(GetCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCaCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 根据SN返回CA证书
         *
         * @param request GetCaCertificateRequest
         * @return GetCaCertificateResponse
         */
        public async Task<GetCaCertificateResponse> GetCaCertificateAsync(GetCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCaCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取设备证书
         *
         * @param request GetDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceCertificateResponse
         */
        public GetDeviceCertificateResponse GetDeviceCertificateWithOptions(GetDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取设备证书
         *
         * @param request GetDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceCertificateResponse
         */
        public async Task<GetDeviceCertificateResponse> GetDeviceCertificateWithOptionsAsync(GetDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备证书
         *
         * @param request GetDeviceCertificateRequest
         * @return GetDeviceCertificateResponse
         */
        public GetDeviceCertificateResponse GetDeviceCertificate(GetDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 获取设备证书
         *
         * @param request GetDeviceCertificateRequest
         * @return GetDeviceCertificateResponse
         */
        public async Task<GetDeviceCertificateResponse> GetDeviceCertificateAsync(GetDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the access credential of a device. If unique-certificate-per-device authentication is used as the authentication method on an ApsaraMQ for MQTT broker, an access credential that you apply for in advance is required for authentication when you connect your device to the broker. The connection can be established only after the authentication is passed.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **GetDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request GetDeviceCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceCredentialResponse
         */
        public GetDeviceCredentialResponse GetDeviceCredentialWithOptions(GetDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceCredential",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceCredentialResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the access credential of a device. If unique-certificate-per-device authentication is used as the authentication method on an ApsaraMQ for MQTT broker, an access credential that you apply for in advance is required for authentication when you connect your device to the broker. The connection can be established only after the authentication is passed.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **GetDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request GetDeviceCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceCredentialResponse
         */
        public async Task<GetDeviceCredentialResponse> GetDeviceCredentialWithOptionsAsync(GetDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceCredential",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the access credential of a device. If unique-certificate-per-device authentication is used as the authentication method on an ApsaraMQ for MQTT broker, an access credential that you apply for in advance is required for authentication when you connect your device to the broker. The connection can be established only after the authentication is passed.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **GetDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request GetDeviceCredentialRequest
         * @return GetDeviceCredentialResponse
         */
        public GetDeviceCredentialResponse GetDeviceCredential(GetDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceCredentialWithOptions(request, runtime);
        }

        /**
         * @summary Queries the access credential of a device. If unique-certificate-per-device authentication is used as the authentication method on an ApsaraMQ for MQTT broker, an access credential that you apply for in advance is required for authentication when you connect your device to the broker. The connection can be established only after the authentication is passed.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **GetDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request GetDeviceCredentialRequest
         * @return GetDeviceCredentialResponse
         */
        public async Task<GetDeviceCredentialResponse> GetDeviceCredentialAsync(GetDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceCredentialWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取添加CA证书的注册码
         *
         * @param request GetRegisterCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRegisterCodeResponse
         */
        public GetRegisterCodeResponse GetRegisterCodeWithOptions(GetRegisterCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegisterCode",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegisterCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取添加CA证书的注册码
         *
         * @param request GetRegisterCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRegisterCodeResponse
         */
        public async Task<GetRegisterCodeResponse> GetRegisterCodeWithOptionsAsync(GetRegisterCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegisterCode",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegisterCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取添加CA证书的注册码
         *
         * @param request GetRegisterCodeRequest
         * @return GetRegisterCodeResponse
         */
        public GetRegisterCodeResponse GetRegisterCode(GetRegisterCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegisterCodeWithOptions(request, runtime);
        }

        /**
         * @summary 获取添加CA证书的注册码
         *
         * @param request GetRegisterCodeRequest
         * @return GetRegisterCodeResponse
         */
        public async Task<GetRegisterCodeResponse> GetRegisterCodeAsync(GetRegisterCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegisterCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 注销CA证书
         *
         * @param request InactivateCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InactivateCaCertificateResponse
         */
        public InactivateCaCertificateResponse InactivateCaCertificateWithOptions(InactivateCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InactivateCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InactivateCaCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 注销CA证书
         *
         * @param request InactivateCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InactivateCaCertificateResponse
         */
        public async Task<InactivateCaCertificateResponse> InactivateCaCertificateWithOptionsAsync(InactivateCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InactivateCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InactivateCaCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 注销CA证书
         *
         * @param request InactivateCaCertificateRequest
         * @return InactivateCaCertificateResponse
         */
        public InactivateCaCertificateResponse InactivateCaCertificate(InactivateCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InactivateCaCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 注销CA证书
         *
         * @param request InactivateCaCertificateRequest
         * @return InactivateCaCertificateResponse
         */
        public async Task<InactivateCaCertificateResponse> InactivateCaCertificateAsync(InactivateCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InactivateCaCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 注销设备证书
         *
         * @param request InactivateDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InactivateDeviceCertificateResponse
         */
        public InactivateDeviceCertificateResponse InactivateDeviceCertificateWithOptions(InactivateDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaSn))
            {
                query["CaSn"] = request.CaSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InactivateDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InactivateDeviceCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 注销设备证书
         *
         * @param request InactivateDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InactivateDeviceCertificateResponse
         */
        public async Task<InactivateDeviceCertificateResponse> InactivateDeviceCertificateWithOptionsAsync(InactivateDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaSn))
            {
                query["CaSn"] = request.CaSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["DeviceSn"] = request.DeviceSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InactivateDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InactivateDeviceCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 注销设备证书
         *
         * @param request InactivateDeviceCertificateRequest
         * @return InactivateDeviceCertificateResponse
         */
        public InactivateDeviceCertificateResponse InactivateDeviceCertificate(InactivateDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InactivateDeviceCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 注销设备证书
         *
         * @param request InactivateDeviceCertificateRequest
         * @return InactivateDeviceCertificateResponse
         */
        public async Task<InactivateDeviceCertificateResponse> InactivateDeviceCertificateAsync(InactivateDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InactivateDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据实例ID 分页获取CA证书
         *
         * @param request ListCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCaCertificateResponse
         */
        public ListCaCertificateResponse ListCaCertificateWithOptions(ListCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCaCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据实例ID 分页获取CA证书
         *
         * @param request ListCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCaCertificateResponse
         */
        public async Task<ListCaCertificateResponse> ListCaCertificateWithOptionsAsync(ListCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCaCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据实例ID 分页获取CA证书
         *
         * @param request ListCaCertificateRequest
         * @return ListCaCertificateResponse
         */
        public ListCaCertificateResponse ListCaCertificate(ListCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCaCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 根据实例ID 分页获取CA证书
         *
         * @param request ListCaCertificateRequest
         * @return ListCaCertificateResponse
         */
        public async Task<ListCaCertificateResponse> ListCaCertificateAsync(ListCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCaCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取设备证书列表
         *
         * @param request ListDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceCertificateResponse
         */
        public ListDeviceCertificateResponse ListDeviceCertificateWithOptions(ListDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取设备证书列表
         *
         * @param request ListDeviceCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceCertificateResponse
         */
        public async Task<ListDeviceCertificateResponse> ListDeviceCertificateWithOptionsAsync(ListDeviceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备证书列表
         *
         * @param request ListDeviceCertificateRequest
         * @return ListDeviceCertificateResponse
         */
        public ListDeviceCertificateResponse ListDeviceCertificate(ListDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 获取设备证书列表
         *
         * @param request ListDeviceCertificateRequest
         * @return ListDeviceCertificateResponse
         */
        public async Task<ListDeviceCertificateResponse> ListDeviceCertificateAsync(ListDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取设备证书列表
         *
         * @param request ListDeviceCertificateByCaSnRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceCertificateByCaSnResponse
         */
        public ListDeviceCertificateByCaSnResponse ListDeviceCertificateByCaSnWithOptions(ListDeviceCertificateByCaSnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceCertificateByCaSn",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceCertificateByCaSnResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取设备证书列表
         *
         * @param request ListDeviceCertificateByCaSnRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceCertificateByCaSnResponse
         */
        public async Task<ListDeviceCertificateByCaSnResponse> ListDeviceCertificateByCaSnWithOptionsAsync(ListDeviceCertificateByCaSnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceCertificateByCaSn",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceCertificateByCaSnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备证书列表
         *
         * @param request ListDeviceCertificateByCaSnRequest
         * @return ListDeviceCertificateByCaSnResponse
         */
        public ListDeviceCertificateByCaSnResponse ListDeviceCertificateByCaSn(ListDeviceCertificateByCaSnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCertificateByCaSnWithOptions(request, runtime);
        }

        /**
         * @summary 获取设备证书列表
         *
         * @param request ListDeviceCertificateByCaSnRequest
         * @return ListDeviceCertificateByCaSnResponse
         */
        public async Task<ListDeviceCertificateByCaSnResponse> ListDeviceCertificateByCaSnAsync(ListDeviceCertificateByCaSnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCertificateByCaSnWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出注册的一机一密的设备ID
         *
         * @param request ListDeviceCredentialClientIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceCredentialClientIdResponse
         */
        public ListDeviceCredentialClientIdResponse ListDeviceCredentialClientIdWithOptions(ListDeviceCredentialClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListDeviceCredentialClientId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceCredentialClientIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出注册的一机一密的设备ID
         *
         * @param request ListDeviceCredentialClientIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceCredentialClientIdResponse
         */
        public async Task<ListDeviceCredentialClientIdResponse> ListDeviceCredentialClientIdWithOptionsAsync(ListDeviceCredentialClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListDeviceCredentialClientId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceCredentialClientIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出注册的一机一密的设备ID
         *
         * @param request ListDeviceCredentialClientIdRequest
         * @return ListDeviceCredentialClientIdResponse
         */
        public ListDeviceCredentialClientIdResponse ListDeviceCredentialClientId(ListDeviceCredentialClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCredentialClientIdWithOptions(request, runtime);
        }

        /**
         * @summary 列出注册的一机一密的设备ID
         *
         * @param request ListDeviceCredentialClientIdRequest
         * @return ListDeviceCredentialClientIdResponse
         */
        public async Task<ListDeviceCredentialClientIdResponse> ListDeviceCredentialClientIdAsync(ListDeviceCredentialClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCredentialClientIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all groups on an ApsaraMQ for MQTT instance.
         *
         * @description Each successful call to the **ListGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request ListGroupIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupIdResponse
         */
        public ListGroupIdResponse ListGroupIdWithOptions(ListGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all groups on an ApsaraMQ for MQTT instance.
         *
         * @description Each successful call to the **ListGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request ListGroupIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupIdResponse
         */
        public async Task<ListGroupIdResponse> ListGroupIdWithOptionsAsync(ListGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all groups on an ApsaraMQ for MQTT instance.
         *
         * @description Each successful call to the **ListGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request ListGroupIdRequest
         * @return ListGroupIdResponse
         */
        public ListGroupIdResponse ListGroupId(ListGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupIdWithOptions(request, runtime);
        }

        /**
         * @summary Queries all groups on an ApsaraMQ for MQTT instance.
         *
         * @description Each successful call to the **ListGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request ListGroupIdRequest
         * @return ListGroupIdResponse
         */
        public async Task<ListGroupIdResponse> ListGroupIdAsync(ListGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a client ID in a connection blacklist.
         *
         * @param request QueryCustomAuthConnectBlackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomAuthConnectBlackResponse
         */
        public QueryCustomAuthConnectBlackResponse QueryCustomAuthConnectBlackWithOptions(QueryCustomAuthConnectBlackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomAuthConnectBlack",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomAuthConnectBlackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a client ID in a connection blacklist.
         *
         * @param request QueryCustomAuthConnectBlackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomAuthConnectBlackResponse
         */
        public async Task<QueryCustomAuthConnectBlackResponse> QueryCustomAuthConnectBlackWithOptionsAsync(QueryCustomAuthConnectBlackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomAuthConnectBlack",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomAuthConnectBlackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a client ID in a connection blacklist.
         *
         * @param request QueryCustomAuthConnectBlackRequest
         * @return QueryCustomAuthConnectBlackResponse
         */
        public QueryCustomAuthConnectBlackResponse QueryCustomAuthConnectBlack(QueryCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthConnectBlackWithOptions(request, runtime);
        }

        /**
         * @summary Queries a client ID in a connection blacklist.
         *
         * @param request QueryCustomAuthConnectBlackRequest
         * @return QueryCustomAuthConnectBlackResponse
         */
        public async Task<QueryCustomAuthConnectBlackResponse> QueryCustomAuthConnectBlackAsync(QueryCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about custom identity authentication.
         *
         * @param request QueryCustomAuthIdentityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomAuthIdentityResponse
         */
        public QueryCustomAuthIdentityResponse QueryCustomAuthIdentityWithOptions(QueryCustomAuthIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomAuthIdentity",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomAuthIdentityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about custom identity authentication.
         *
         * @param request QueryCustomAuthIdentityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomAuthIdentityResponse
         */
        public async Task<QueryCustomAuthIdentityResponse> QueryCustomAuthIdentityWithOptionsAsync(QueryCustomAuthIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomAuthIdentity",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomAuthIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about custom identity authentication.
         *
         * @param request QueryCustomAuthIdentityRequest
         * @return QueryCustomAuthIdentityResponse
         */
        public QueryCustomAuthIdentityResponse QueryCustomAuthIdentity(QueryCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthIdentityWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about custom identity authentication.
         *
         * @param request QueryCustomAuthIdentityRequest
         * @return QueryCustomAuthIdentityResponse
         */
        public async Task<QueryCustomAuthIdentityResponse> QueryCustomAuthIdentityAsync(QueryCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the authorization information about a topic.
         *
         * @param request QueryCustomAuthPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomAuthPermissionResponse
         */
        public QueryCustomAuthPermissionResponse QueryCustomAuthPermissionWithOptions(QueryCustomAuthPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomAuthPermission",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomAuthPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the authorization information about a topic.
         *
         * @param request QueryCustomAuthPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomAuthPermissionResponse
         */
        public async Task<QueryCustomAuthPermissionResponse> QueryCustomAuthPermissionWithOptionsAsync(QueryCustomAuthPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomAuthPermission",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomAuthPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the authorization information about a topic.
         *
         * @param request QueryCustomAuthPermissionRequest
         * @return QueryCustomAuthPermissionResponse
         */
        public QueryCustomAuthPermissionResponse QueryCustomAuthPermission(QueryCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthPermissionWithOptions(request, runtime);
        }

        /**
         * @summary Queries the authorization information about a topic.
         *
         * @param request QueryCustomAuthPermissionRequest
         * @return QueryCustomAuthPermissionResponse
         */
        public async Task<QueryCustomAuthPermissionResponse> QueryCustomAuthPermissionAsync(QueryCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the trace of a device that corresponds to an ApsaraMQ for MQTT client by page. When the status of a device is abnormal, you can call this operation to query the connection history of the device. This helps you efficiently troubleshoot issues.
         *
         * @description *   Each successful call to the **QueryMqttTraceDevice** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMqttTraceDeviceResponse
         */
        public QueryMqttTraceDeviceResponse QueryMqttTraceDeviceWithOptions(QueryMqttTraceDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttRegionId))
            {
                query["MqttRegionId"] = request.MqttRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMqttTraceDevice",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMqttTraceDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the trace of a device that corresponds to an ApsaraMQ for MQTT client by page. When the status of a device is abnormal, you can call this operation to query the connection history of the device. This helps you efficiently troubleshoot issues.
         *
         * @description *   Each successful call to the **QueryMqttTraceDevice** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMqttTraceDeviceResponse
         */
        public async Task<QueryMqttTraceDeviceResponse> QueryMqttTraceDeviceWithOptionsAsync(QueryMqttTraceDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttRegionId))
            {
                query["MqttRegionId"] = request.MqttRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMqttTraceDevice",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMqttTraceDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the trace of a device that corresponds to an ApsaraMQ for MQTT client by page. When the status of a device is abnormal, you can call this operation to query the connection history of the device. This helps you efficiently troubleshoot issues.
         *
         * @description *   Each successful call to the **QueryMqttTraceDevice** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceDeviceRequest
         * @return QueryMqttTraceDeviceResponse
         */
        public QueryMqttTraceDeviceResponse QueryMqttTraceDevice(QueryMqttTraceDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMqttTraceDeviceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the trace of a device that corresponds to an ApsaraMQ for MQTT client by page. When the status of a device is abnormal, you can call this operation to query the connection history of the device. This helps you efficiently troubleshoot issues.
         *
         * @description *   Each successful call to the **QueryMqttTraceDevice** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceDeviceRequest
         * @return QueryMqttTraceDeviceResponse
         */
        public async Task<QueryMqttTraceDeviceResponse> QueryMqttTraceDeviceAsync(QueryMqttTraceDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMqttTraceDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries messages on a device within a specific period of time. If a message is not sent or received as expected, you can call this operation to query the messaging status of the message to efficiently troubleshoot issues.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessageOfClient** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessageOfClientRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMqttTraceMessageOfClientResponse
         */
        public QueryMqttTraceMessageOfClientResponse QueryMqttTraceMessageOfClientWithOptions(QueryMqttTraceMessageOfClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttRegionId))
            {
                query["MqttRegionId"] = request.MqttRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMqttTraceMessageOfClient",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMqttTraceMessageOfClientResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries messages on a device within a specific period of time. If a message is not sent or received as expected, you can call this operation to query the messaging status of the message to efficiently troubleshoot issues.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessageOfClient** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessageOfClientRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMqttTraceMessageOfClientResponse
         */
        public async Task<QueryMqttTraceMessageOfClientResponse> QueryMqttTraceMessageOfClientWithOptionsAsync(QueryMqttTraceMessageOfClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttRegionId))
            {
                query["MqttRegionId"] = request.MqttRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMqttTraceMessageOfClient",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMqttTraceMessageOfClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries messages on a device within a specific period of time. If a message is not sent or received as expected, you can call this operation to query the messaging status of the message to efficiently troubleshoot issues.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessageOfClient** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessageOfClientRequest
         * @return QueryMqttTraceMessageOfClientResponse
         */
        public QueryMqttTraceMessageOfClientResponse QueryMqttTraceMessageOfClient(QueryMqttTraceMessageOfClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMqttTraceMessageOfClientWithOptions(request, runtime);
        }

        /**
         * @summary Queries messages on a device within a specific period of time. If a message is not sent or received as expected, you can call this operation to query the messaging status of the message to efficiently troubleshoot issues.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessageOfClient** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessageOfClientRequest
         * @return QueryMqttTraceMessageOfClientResponse
         */
        public async Task<QueryMqttTraceMessageOfClientResponse> QueryMqttTraceMessageOfClientAsync(QueryMqttTraceMessageOfClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMqttTraceMessageOfClientWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the trace of a message. If a message is not sent or received as expected, you can call this operation to view the message details to troubleshoot the issue. For example, you can query the time when the message is published and the client that publishes the message.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessagePublish** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessagePublishRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMqttTraceMessagePublishResponse
         */
        public QueryMqttTraceMessagePublishResponse QueryMqttTraceMessagePublishWithOptions(QueryMqttTraceMessagePublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttRegionId))
            {
                query["MqttRegionId"] = request.MqttRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMqttTraceMessagePublish",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMqttTraceMessagePublishResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the trace of a message. If a message is not sent or received as expected, you can call this operation to view the message details to troubleshoot the issue. For example, you can query the time when the message is published and the client that publishes the message.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessagePublish** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessagePublishRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMqttTraceMessagePublishResponse
         */
        public async Task<QueryMqttTraceMessagePublishResponse> QueryMqttTraceMessagePublishWithOptionsAsync(QueryMqttTraceMessagePublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttRegionId))
            {
                query["MqttRegionId"] = request.MqttRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMqttTraceMessagePublish",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMqttTraceMessagePublishResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the trace of a message. If a message is not sent or received as expected, you can call this operation to view the message details to troubleshoot the issue. For example, you can query the time when the message is published and the client that publishes the message.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessagePublish** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessagePublishRequest
         * @return QueryMqttTraceMessagePublishResponse
         */
        public QueryMqttTraceMessagePublishResponse QueryMqttTraceMessagePublish(QueryMqttTraceMessagePublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMqttTraceMessagePublishWithOptions(request, runtime);
        }

        /**
         * @summary Queries the trace of a message. If a message is not sent or received as expected, you can call this operation to view the message details to troubleshoot the issue. For example, you can query the time when the message is published and the client that publishes the message.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessagePublish** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessagePublishRequest
         * @return QueryMqttTraceMessagePublishResponse
         */
        public async Task<QueryMqttTraceMessagePublishResponse> QueryMqttTraceMessagePublishAsync(QueryMqttTraceMessagePublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMqttTraceMessagePublishWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the delivery trace of a message. If a message is not sent or received as expected, you can call this operation to view the details about the message. For example, you can query the clients that subscribe to the message and the time when the message is delivered. This operation helps you locate the problem and identify the cause of the problem.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessageSubscribe** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessageSubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMqttTraceMessageSubscribeResponse
         */
        public QueryMqttTraceMessageSubscribeResponse QueryMqttTraceMessageSubscribeWithOptions(QueryMqttTraceMessageSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttRegionId))
            {
                query["MqttRegionId"] = request.MqttRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMqttTraceMessageSubscribe",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMqttTraceMessageSubscribeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the delivery trace of a message. If a message is not sent or received as expected, you can call this operation to view the details about the message. For example, you can query the clients that subscribe to the message and the time when the message is delivered. This operation helps you locate the problem and identify the cause of the problem.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessageSubscribe** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessageSubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMqttTraceMessageSubscribeResponse
         */
        public async Task<QueryMqttTraceMessageSubscribeResponse> QueryMqttTraceMessageSubscribeWithOptionsAsync(QueryMqttTraceMessageSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttRegionId))
            {
                query["MqttRegionId"] = request.MqttRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMqttTraceMessageSubscribe",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMqttTraceMessageSubscribeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the delivery trace of a message. If a message is not sent or received as expected, you can call this operation to view the details about the message. For example, you can query the clients that subscribe to the message and the time when the message is delivered. This operation helps you locate the problem and identify the cause of the problem.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessageSubscribe** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessageSubscribeRequest
         * @return QueryMqttTraceMessageSubscribeResponse
         */
        public QueryMqttTraceMessageSubscribeResponse QueryMqttTraceMessageSubscribe(QueryMqttTraceMessageSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMqttTraceMessageSubscribeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the delivery trace of a message. If a message is not sent or received as expected, you can call this operation to view the details about the message. For example, you can query the clients that subscribe to the message and the time when the message is delivered. This operation helps you locate the problem and identify the cause of the problem.
         *
         * @description *   Each successful call to the **QueryMqttTraceMessageSubscribe** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         *
         * @param request QueryMqttTraceMessageSubscribeRequest
         * @return QueryMqttTraceMessageSubscribeResponse
         */
        public async Task<QueryMqttTraceMessageSubscribeResponse> QueryMqttTraceMessageSubscribeAsync(QueryMqttTraceMessageSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMqttTraceMessageSubscribeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the running status of an ApsaraMQ for MQTT client. You can troubleshoot issues based on the queried results. You can enter the ID of an ApsaraMQ for MQTT client to check the connection status and IP address of the device.
         *
         * @description *   You can call this operation up to 500 times per second.**** For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **QuerySessionByClientId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request QuerySessionByClientIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySessionByClientIdResponse
         */
        public QuerySessionByClientIdResponse QuerySessionByClientIdWithOptions(QuerySessionByClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySessionByClientId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySessionByClientIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the running status of an ApsaraMQ for MQTT client. You can troubleshoot issues based on the queried results. You can enter the ID of an ApsaraMQ for MQTT client to check the connection status and IP address of the device.
         *
         * @description *   You can call this operation up to 500 times per second.**** For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **QuerySessionByClientId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request QuerySessionByClientIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySessionByClientIdResponse
         */
        public async Task<QuerySessionByClientIdResponse> QuerySessionByClientIdWithOptionsAsync(QuerySessionByClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySessionByClientId",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySessionByClientIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the running status of an ApsaraMQ for MQTT client. You can troubleshoot issues based on the queried results. You can enter the ID of an ApsaraMQ for MQTT client to check the connection status and IP address of the device.
         *
         * @description *   You can call this operation up to 500 times per second.**** For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **QuerySessionByClientId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request QuerySessionByClientIdRequest
         * @return QuerySessionByClientIdResponse
         */
        public QuerySessionByClientIdResponse QuerySessionByClientId(QuerySessionByClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySessionByClientIdWithOptions(request, runtime);
        }

        /**
         * @summary Queries the running status of an ApsaraMQ for MQTT client. You can troubleshoot issues based on the queried results. You can enter the ID of an ApsaraMQ for MQTT client to check the connection status and IP address of the device.
         *
         * @description *   You can call this operation up to 500 times per second.**** For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **QuerySessionByClientId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request QuerySessionByClientIdRequest
         * @return QuerySessionByClientIdResponse
         */
        public async Task<QuerySessionByClientIdResponse> QuerySessionByClientIdAsync(QuerySessionByClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySessionByClientIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of a token. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker. A token is a temporary credential and is valid only within a specific period of time. You can call this operation to query whether a token expires.
         *
         * @description *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **QueryToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request QueryTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTokenResponse
         */
        public QueryTokenResponse QueryTokenWithOptions(QueryTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryToken",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a token. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker. A token is a temporary credential and is valid only within a specific period of time. You can call this operation to query whether a token expires.
         *
         * @description *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **QueryToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request QueryTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTokenResponse
         */
        public async Task<QueryTokenResponse> QueryTokenWithOptionsAsync(QueryTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryToken",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a token. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker. A token is a temporary credential and is valid only within a specific period of time. You can call this operation to query whether a token expires.
         *
         * @description *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **QueryToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request QueryTokenRequest
         * @return QueryTokenResponse
         */
        public QueryTokenResponse QueryToken(QueryTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTokenWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status of a token. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker. A token is a temporary credential and is valid only within a specific period of time. You can call this operation to query whether a token expires.
         *
         * @description *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **QueryToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request QueryTokenRequest
         * @return QueryTokenResponse
         */
        public async Task<QueryTokenResponse> QueryTokenAsync(QueryTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the access credential of a device.
         *
         * @description ## [](#)Limits
         * You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * >  Each successful call to the **RefreshDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RefreshDeviceCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshDeviceCredentialResponse
         */
        public RefreshDeviceCredentialResponse RefreshDeviceCredentialWithOptions(RefreshDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshDeviceCredential",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshDeviceCredentialResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the access credential of a device.
         *
         * @description ## [](#)Limits
         * You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * >  Each successful call to the **RefreshDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RefreshDeviceCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshDeviceCredentialResponse
         */
        public async Task<RefreshDeviceCredentialResponse> RefreshDeviceCredentialWithOptionsAsync(RefreshDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshDeviceCredential",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshDeviceCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the access credential of a device.
         *
         * @description ## [](#)Limits
         * You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * >  Each successful call to the **RefreshDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RefreshDeviceCredentialRequest
         * @return RefreshDeviceCredentialResponse
         */
        public RefreshDeviceCredentialResponse RefreshDeviceCredential(RefreshDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshDeviceCredentialWithOptions(request, runtime);
        }

        /**
         * @summary Updates the access credential of a device.
         *
         * @description ## [](#)Limits
         * You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * >  Each successful call to the **RefreshDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RefreshDeviceCredentialRequest
         * @return RefreshDeviceCredentialResponse
         */
        public async Task<RefreshDeviceCredentialResponse> RefreshDeviceCredentialAsync(RefreshDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDeviceCredentialWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 注册CA证书
         *
         * @param request RegisterCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCaCertificateResponse
         */
        public RegisterCaCertificateResponse RegisterCaCertificateWithOptions(RegisterCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaContent))
            {
                query["CaContent"] = request.CaContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaName))
            {
                query["CaName"] = request.CaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationContent))
            {
                query["VerificationContent"] = request.VerificationContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCaCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 注册CA证书
         *
         * @param request RegisterCaCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCaCertificateResponse
         */
        public async Task<RegisterCaCertificateResponse> RegisterCaCertificateWithOptionsAsync(RegisterCaCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaContent))
            {
                query["CaContent"] = request.CaContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaName))
            {
                query["CaName"] = request.CaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationContent))
            {
                query["VerificationContent"] = request.VerificationContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterCaCertificate",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCaCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 注册CA证书
         *
         * @param request RegisterCaCertificateRequest
         * @return RegisterCaCertificateResponse
         */
        public RegisterCaCertificateResponse RegisterCaCertificate(RegisterCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterCaCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 注册CA证书
         *
         * @param request RegisterCaCertificateRequest
         * @return RegisterCaCertificateResponse
         */
        public async Task<RegisterCaCertificateResponse> RegisterCaCertificateAsync(RegisterCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterCaCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Registers an access credential for a device. In unique-certificate-per-device authentication mode, an application server applies a unique access credential for each device from the corresponding ApsaraMQ for MQTT broker. The access credential of a device consists of the client ID, AccessKey ID, and AccessKey secret of the device. When you connect a device to ApsaraMQ for MQTT, you must configure Username and Password based on the access credential of the device for authentication. You can activate the device and transfer data between the device and ApsaraMQ for MQTT only after the authentication is passed.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **RegisterDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RegisterDeviceCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDeviceCredentialResponse
         */
        public RegisterDeviceCredentialResponse RegisterDeviceCredentialWithOptions(RegisterDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDeviceCredential",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceCredentialResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Registers an access credential for a device. In unique-certificate-per-device authentication mode, an application server applies a unique access credential for each device from the corresponding ApsaraMQ for MQTT broker. The access credential of a device consists of the client ID, AccessKey ID, and AccessKey secret of the device. When you connect a device to ApsaraMQ for MQTT, you must configure Username and Password based on the access credential of the device for authentication. You can activate the device and transfer data between the device and ApsaraMQ for MQTT only after the authentication is passed.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **RegisterDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RegisterDeviceCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDeviceCredentialResponse
         */
        public async Task<RegisterDeviceCredentialResponse> RegisterDeviceCredentialWithOptionsAsync(RegisterDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDeviceCredential",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Registers an access credential for a device. In unique-certificate-per-device authentication mode, an application server applies a unique access credential for each device from the corresponding ApsaraMQ for MQTT broker. The access credential of a device consists of the client ID, AccessKey ID, and AccessKey secret of the device. When you connect a device to ApsaraMQ for MQTT, you must configure Username and Password based on the access credential of the device for authentication. You can activate the device and transfer data between the device and ApsaraMQ for MQTT only after the authentication is passed.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **RegisterDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RegisterDeviceCredentialRequest
         * @return RegisterDeviceCredentialResponse
         */
        public RegisterDeviceCredentialResponse RegisterDeviceCredential(RegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceCredentialWithOptions(request, runtime);
        }

        /**
         * @summary Registers an access credential for a device. In unique-certificate-per-device authentication mode, an application server applies a unique access credential for each device from the corresponding ApsaraMQ for MQTT broker. The access credential of a device consists of the client ID, AccessKey ID, and AccessKey secret of the device. When you connect a device to ApsaraMQ for MQTT, you must configure Username and Password based on the access credential of the device for authentication. You can activate the device and transfer data between the device and ApsaraMQ for MQTT only after the authentication is passed.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **RegisterDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RegisterDeviceCredentialRequest
         * @return RegisterDeviceCredentialResponse
         */
        public async Task<RegisterDeviceCredentialResponse> RegisterDeviceCredentialAsync(RegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceCredentialWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Revokes a token.
         *
         * @description *   You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **RevokeToken** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RevokeTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeTokenResponse
         */
        public RevokeTokenResponse RevokeTokenWithOptions(RevokeTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeToken",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeTokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Revokes a token.
         *
         * @description *   You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **RevokeToken** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RevokeTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeTokenResponse
         */
        public async Task<RevokeTokenResponse> RevokeTokenWithOptionsAsync(RevokeTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeToken",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Revokes a token.
         *
         * @description *   You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **RevokeToken** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RevokeTokenRequest
         * @return RevokeTokenResponse
         */
        public RevokeTokenResponse RevokeToken(RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeTokenWithOptions(request, runtime);
        }

        /**
         * @summary Revokes a token.
         *
         * @description *   You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
         * *   Each successful call to the **RevokeToken** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request RevokeTokenRequest
         * @return RevokeTokenResponse
         */
        public async Task<RevokeTokenResponse> RevokeTokenAsync(RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sends a single message from an application on a cloud server to ApsaraMQ for MQTT.
         *
         * @description *   The **SendMessage** operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see [Developer guide](https://help.aliyun.com/document_detail/179160.html).
         * *   Before you call the **SendMessage** operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the [Instance Details](https://mqtt.console.aliyun.com) page that corresponds to the instance in the **ApsaraMQ for MQTT console**.
         * *   Messages that are sent by calling the **SendMessage** operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see [Export data from ApsaraMQ for MQTT to other Alibaba Cloud services](https://help.aliyun.com/document_detail/174527.html). You can call the **SendMessage** operation up to 1,000 times per second. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **SendMessage** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request SendMessageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMessageResponse
         */
        public SendMessageResponse SendMessageWithOptions(SendMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttTopic))
            {
                query["MqttTopic"] = request.MqttTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                query["Payload"] = request.Payload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessage",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sends a single message from an application on a cloud server to ApsaraMQ for MQTT.
         *
         * @description *   The **SendMessage** operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see [Developer guide](https://help.aliyun.com/document_detail/179160.html).
         * *   Before you call the **SendMessage** operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the [Instance Details](https://mqtt.console.aliyun.com) page that corresponds to the instance in the **ApsaraMQ for MQTT console**.
         * *   Messages that are sent by calling the **SendMessage** operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see [Export data from ApsaraMQ for MQTT to other Alibaba Cloud services](https://help.aliyun.com/document_detail/174527.html). You can call the **SendMessage** operation up to 1,000 times per second. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **SendMessage** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request SendMessageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMessageResponse
         */
        public async Task<SendMessageResponse> SendMessageWithOptionsAsync(SendMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttTopic))
            {
                query["MqttTopic"] = request.MqttTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                query["Payload"] = request.Payload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessage",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sends a single message from an application on a cloud server to ApsaraMQ for MQTT.
         *
         * @description *   The **SendMessage** operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see [Developer guide](https://help.aliyun.com/document_detail/179160.html).
         * *   Before you call the **SendMessage** operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the [Instance Details](https://mqtt.console.aliyun.com) page that corresponds to the instance in the **ApsaraMQ for MQTT console**.
         * *   Messages that are sent by calling the **SendMessage** operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see [Export data from ApsaraMQ for MQTT to other Alibaba Cloud services](https://help.aliyun.com/document_detail/174527.html). You can call the **SendMessage** operation up to 1,000 times per second. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **SendMessage** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request SendMessageRequest
         * @return SendMessageResponse
         */
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageWithOptions(request, runtime);
        }

        /**
         * @summary Sends a single message from an application on a cloud server to ApsaraMQ for MQTT.
         *
         * @description *   The **SendMessage** operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see [Developer guide](https://help.aliyun.com/document_detail/179160.html).
         * *   Before you call the **SendMessage** operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the [Instance Details](https://mqtt.console.aliyun.com) page that corresponds to the instance in the **ApsaraMQ for MQTT console**.
         * *   Messages that are sent by calling the **SendMessage** operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see [Export data from ApsaraMQ for MQTT to other Alibaba Cloud services](https://help.aliyun.com/document_detail/174527.html). You can call the **SendMessage** operation up to 1,000 times per second. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **SendMessage** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request SendMessageRequest
         * @return SendMessageResponse
         */
        public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deregisters the access credential of a device. After the access credential of a device is deregistered, you can no longer use the access credential to authenticate the device on the ApsaraMQ for MQTT broker.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **UnRegisterDeviceCredential** operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request UnRegisterDeviceCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnRegisterDeviceCredentialResponse
         */
        public UnRegisterDeviceCredentialResponse UnRegisterDeviceCredentialWithOptions(UnRegisterDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnRegisterDeviceCredential",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnRegisterDeviceCredentialResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deregisters the access credential of a device. After the access credential of a device is deregistered, you can no longer use the access credential to authenticate the device on the ApsaraMQ for MQTT broker.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **UnRegisterDeviceCredential** operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request UnRegisterDeviceCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnRegisterDeviceCredentialResponse
         */
        public async Task<UnRegisterDeviceCredentialResponse> UnRegisterDeviceCredentialWithOptionsAsync(UnRegisterDeviceCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnRegisterDeviceCredential",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnRegisterDeviceCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deregisters the access credential of a device. After the access credential of a device is deregistered, you can no longer use the access credential to authenticate the device on the ApsaraMQ for MQTT broker.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **UnRegisterDeviceCredential** operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request UnRegisterDeviceCredentialRequest
         * @return UnRegisterDeviceCredentialResponse
         */
        public UnRegisterDeviceCredentialResponse UnRegisterDeviceCredential(UnRegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnRegisterDeviceCredentialWithOptions(request, runtime);
        }

        /**
         * @summary Deregisters the access credential of a device. After the access credential of a device is deregistered, you can no longer use the access credential to authenticate the device on the ApsaraMQ for MQTT broker.
         *
         * @description *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](https://help.aliyun.com/document_detail/163047.html).
         * *   Each successful call to the **UnRegisterDeviceCredential** operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](https://help.aliyun.com/document_detail/52819.html).
         *
         * @param request UnRegisterDeviceCredentialRequest
         * @return UnRegisterDeviceCredentialResponse
         */
        public async Task<UnRegisterDeviceCredentialResponse> UnRegisterDeviceCredentialAsync(UnRegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnRegisterDeviceCredentialWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the information about custom identity authentication.
         *
         * @param request UpdateCustomAuthIdentityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomAuthIdentityResponse
         */
        public UpdateCustomAuthIdentityResponse UpdateCustomAuthIdentityWithOptions(UpdateCustomAuthIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Secret))
            {
                body["Secret"] = request.Secret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignMode))
            {
                body["SignMode"] = request.SignMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomAuthIdentity",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomAuthIdentityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the information about custom identity authentication.
         *
         * @param request UpdateCustomAuthIdentityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomAuthIdentityResponse
         */
        public async Task<UpdateCustomAuthIdentityResponse> UpdateCustomAuthIdentityWithOptionsAsync(UpdateCustomAuthIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Secret))
            {
                body["Secret"] = request.Secret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignMode))
            {
                body["SignMode"] = request.SignMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomAuthIdentity",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomAuthIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the information about custom identity authentication.
         *
         * @param request UpdateCustomAuthIdentityRequest
         * @return UpdateCustomAuthIdentityResponse
         */
        public UpdateCustomAuthIdentityResponse UpdateCustomAuthIdentity(UpdateCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomAuthIdentityWithOptions(request, runtime);
        }

        /**
         * @summary Updates the information about custom identity authentication.
         *
         * @param request UpdateCustomAuthIdentityRequest
         * @return UpdateCustomAuthIdentityResponse
         */
        public async Task<UpdateCustomAuthIdentityResponse> UpdateCustomAuthIdentityAsync(UpdateCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新自定义权限授权
         *
         * @param request UpdateCustomAuthPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomAuthPermissionResponse
         */
        public UpdateCustomAuthPermissionResponse UpdateCustomAuthPermissionWithOptions(UpdateCustomAuthPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["Effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["Identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitAction))
            {
                body["PermitAction"] = request.PermitAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomAuthPermission",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomAuthPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新自定义权限授权
         *
         * @param request UpdateCustomAuthPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomAuthPermissionResponse
         */
        public async Task<UpdateCustomAuthPermissionResponse> UpdateCustomAuthPermissionWithOptionsAsync(UpdateCustomAuthPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Effect))
            {
                body["Effect"] = request.Effect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                body["Identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                body["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitAction))
            {
                body["PermitAction"] = request.PermitAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomAuthPermission",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomAuthPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新自定义权限授权
         *
         * @param request UpdateCustomAuthPermissionRequest
         * @return UpdateCustomAuthPermissionResponse
         */
        public UpdateCustomAuthPermissionResponse UpdateCustomAuthPermission(UpdateCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomAuthPermissionWithOptions(request, runtime);
        }

        /**
         * @summary 更新自定义权限授权
         *
         * @param request UpdateCustomAuthPermissionRequest
         * @return UpdateCustomAuthPermissionResponse
         */
        public async Task<UpdateCustomAuthPermissionResponse> UpdateCustomAuthPermissionAsync(UpdateCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

    }
}
