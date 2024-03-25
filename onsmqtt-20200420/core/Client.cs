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

        public ActiveCaCertificateResponse ActiveCaCertificate(ActiveCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveCaCertificateWithOptions(request, runtime);
        }

        public async Task<ActiveCaCertificateResponse> ActiveCaCertificateAsync(ActiveCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveCaCertificateWithOptionsAsync(request, runtime);
        }

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

        public ActiveDeviceCertificateResponse ActiveDeviceCertificate(ActiveDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveDeviceCertificateWithOptions(request, runtime);
        }

        public async Task<ActiveDeviceCertificateResponse> ActiveDeviceCertificateAsync(ActiveDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveDeviceCertificateWithOptionsAsync(request, runtime);
        }

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

        public AddCustomAuthConnectBlackResponse AddCustomAuthConnectBlack(AddCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthConnectBlackWithOptions(request, runtime);
        }

        public async Task<AddCustomAuthConnectBlackResponse> AddCustomAuthConnectBlackAsync(AddCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

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

        public AddCustomAuthIdentityResponse AddCustomAuthIdentity(AddCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthIdentityWithOptions(request, runtime);
        }

        public async Task<AddCustomAuthIdentityResponse> AddCustomAuthIdentityAsync(AddCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

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

        public AddCustomAuthPermissionResponse AddCustomAuthPermission(AddCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthPermissionWithOptions(request, runtime);
        }

        public async Task<AddCustomAuthPermissionResponse> AddCustomAuthPermissionAsync(AddCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **ApplyToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **ApplyToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **ApplyToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **ApplyToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call the **BatchQuerySessionByClientIds** operation up to 100 times per second. For more information, see [Limits on QPS](~~163047~~).
          * *   You can call the **BatchQuerySessionByClientIds** operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.
          * *   Each successful call to the **BatchQuerySessionByClientIds** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call the **BatchQuerySessionByClientIds** operation up to 100 times per second. For more information, see [Limits on QPS](~~163047~~).
          * *   You can call the **BatchQuerySessionByClientIds** operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.
          * *   Each successful call to the **BatchQuerySessionByClientIds** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call the **BatchQuerySessionByClientIds** operation up to 100 times per second. For more information, see [Limits on QPS](~~163047~~).
          * *   You can call the **BatchQuerySessionByClientIds** operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.
          * *   Each successful call to the **BatchQuerySessionByClientIds** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call the **BatchQuerySessionByClientIds** operation up to 100 times per second. For more information, see [Limits on QPS](~~163047~~).
          * *   You can call the **BatchQuerySessionByClientIds** operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.
          * *   Each successful call to the **BatchQuerySessionByClientIds** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **CreateGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **CreateGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **CreateGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **CreateGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          *
          * @param request CreateGroupIdRequest
          * @return CreateGroupIdResponse
         */
        public async Task<CreateGroupIdResponse> CreateGroupIdAsync(CreateGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupIdWithOptionsAsync(request, runtime);
        }

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

        public DeleteCaCertificateResponse DeleteCaCertificate(DeleteCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCaCertificateWithOptions(request, runtime);
        }

        public async Task<DeleteCaCertificateResponse> DeleteCaCertificateAsync(DeleteCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCaCertificateWithOptionsAsync(request, runtime);
        }

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

        public DeleteCustomAuthConnectBlackResponse DeleteCustomAuthConnectBlack(DeleteCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthConnectBlackWithOptions(request, runtime);
        }

        public async Task<DeleteCustomAuthConnectBlackResponse> DeleteCustomAuthConnectBlackAsync(DeleteCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

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

        public DeleteCustomAuthIdentityResponse DeleteCustomAuthIdentity(DeleteCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthIdentityWithOptions(request, runtime);
        }

        public async Task<DeleteCustomAuthIdentityResponse> DeleteCustomAuthIdentityAsync(DeleteCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

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

        public DeleteCustomAuthPermissionResponse DeleteCustomAuthPermission(DeleteCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthPermissionWithOptions(request, runtime);
        }

        public async Task<DeleteCustomAuthPermissionResponse> DeleteCustomAuthPermissionAsync(DeleteCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

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

        public DeleteDeviceCertificateResponse DeleteDeviceCertificate(DeleteDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceCertificateWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceCertificateResponse> DeleteDeviceCertificateAsync(DeleteDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * Each successful call to the **DeleteGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **DeleteGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **DeleteGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **DeleteGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          *
          * @param request DeleteGroupIdRequest
          * @return DeleteGroupIdResponse
         */
        public async Task<DeleteGroupIdResponse> DeleteGroupIdAsync(DeleteGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupIdWithOptionsAsync(request, runtime);
        }

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

        public GetCaCertificateResponse GetCaCertificate(GetCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCaCertificateWithOptions(request, runtime);
        }

        public async Task<GetCaCertificateResponse> GetCaCertificateAsync(GetCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCaCertificateWithOptionsAsync(request, runtime);
        }

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

        public GetDeviceCertificateResponse GetDeviceCertificate(GetDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceCertificateWithOptions(request, runtime);
        }

        public async Task<GetDeviceCertificateResponse> GetDeviceCertificateAsync(GetDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **GetDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **GetDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **GetDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **GetDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          *
          * @param request GetDeviceCredentialRequest
          * @return GetDeviceCredentialResponse
         */
        public async Task<GetDeviceCredentialResponse> GetDeviceCredentialAsync(GetDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceCredentialWithOptionsAsync(request, runtime);
        }

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

        public GetRegisterCodeResponse GetRegisterCode(GetRegisterCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegisterCodeWithOptions(request, runtime);
        }

        public async Task<GetRegisterCodeResponse> GetRegisterCodeAsync(GetRegisterCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegisterCodeWithOptionsAsync(request, runtime);
        }

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

        public InactivateCaCertificateResponse InactivateCaCertificate(InactivateCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InactivateCaCertificateWithOptions(request, runtime);
        }

        public async Task<InactivateCaCertificateResponse> InactivateCaCertificateAsync(InactivateCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InactivateCaCertificateWithOptionsAsync(request, runtime);
        }

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

        public InactivateDeviceCertificateResponse InactivateDeviceCertificate(InactivateDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InactivateDeviceCertificateWithOptions(request, runtime);
        }

        public async Task<InactivateDeviceCertificateResponse> InactivateDeviceCertificateAsync(InactivateDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InactivateDeviceCertificateWithOptionsAsync(request, runtime);
        }

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

        public ListCaCertificateResponse ListCaCertificate(ListCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCaCertificateWithOptions(request, runtime);
        }

        public async Task<ListCaCertificateResponse> ListCaCertificateAsync(ListCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCaCertificateWithOptionsAsync(request, runtime);
        }

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

        public ListDeviceCertificateResponse ListDeviceCertificate(ListDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCertificateWithOptions(request, runtime);
        }

        public async Task<ListDeviceCertificateResponse> ListDeviceCertificateAsync(ListDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCertificateWithOptionsAsync(request, runtime);
        }

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

        public ListDeviceCertificateByCaSnResponse ListDeviceCertificateByCaSn(ListDeviceCertificateByCaSnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCertificateByCaSnWithOptions(request, runtime);
        }

        public async Task<ListDeviceCertificateByCaSnResponse> ListDeviceCertificateByCaSnAsync(ListDeviceCertificateByCaSnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCertificateByCaSnWithOptionsAsync(request, runtime);
        }

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

        public ListDeviceCredentialClientIdResponse ListDeviceCredentialClientId(ListDeviceCredentialClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCredentialClientIdWithOptions(request, runtime);
        }

        public async Task<ListDeviceCredentialClientIdResponse> ListDeviceCredentialClientIdAsync(ListDeviceCredentialClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCredentialClientIdWithOptionsAsync(request, runtime);
        }

        /**
          * Each successful call to the **ListGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **ListGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **ListGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * Each successful call to the **ListGroupId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          *
          * @param request ListGroupIdRequest
          * @return ListGroupIdResponse
         */
        public async Task<ListGroupIdResponse> ListGroupIdAsync(ListGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupIdWithOptionsAsync(request, runtime);
        }

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

        public QueryCustomAuthConnectBlackResponse QueryCustomAuthConnectBlack(QueryCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthConnectBlackWithOptions(request, runtime);
        }

        public async Task<QueryCustomAuthConnectBlackResponse> QueryCustomAuthConnectBlackAsync(QueryCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

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

        public QueryCustomAuthIdentityResponse QueryCustomAuthIdentity(QueryCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthIdentityWithOptions(request, runtime);
        }

        public async Task<QueryCustomAuthIdentityResponse> QueryCustomAuthIdentityAsync(QueryCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

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

        public QueryCustomAuthPermissionResponse QueryCustomAuthPermission(QueryCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthPermissionWithOptions(request, runtime);
        }

        public async Task<QueryCustomAuthPermissionResponse> QueryCustomAuthPermissionAsync(QueryCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

        /**
          * *   Each successful call to the **QueryMqttTraceDevice** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceDevice** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceDevice** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceDevice** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessageOfClient** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessageOfClient** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessageOfClient** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessageOfClient** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessagePublish** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessagePublish** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessagePublish** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessagePublish** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessageSubscribe** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessageSubscribe** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessageSubscribe** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   Each successful call to the **QueryMqttTraceMessageSubscribe** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
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
          * *   You can call this operation up to 500 times per second.**** For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **QuerySessionByClientId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second.**** For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **QuerySessionByClientId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second.**** For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **QuerySessionByClientId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second.**** For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **QuerySessionByClientId** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **QueryToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **QueryToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **QueryToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **QueryToken** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * ## [](#)Limits
          * You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * >  Each successful call to the **RefreshDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * ## [](#)Limits
          * You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * >  Each successful call to the **RefreshDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * ## [](#)Limits
          * You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * >  Each successful call to the **RefreshDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * ## [](#)Limits
          * You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * >  Each successful call to the **RefreshDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          *
          * @param request RefreshDeviceCredentialRequest
          * @return RefreshDeviceCredentialResponse
         */
        public async Task<RefreshDeviceCredentialResponse> RefreshDeviceCredentialAsync(RefreshDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDeviceCredentialWithOptionsAsync(request, runtime);
        }

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

        public RegisterCaCertificateResponse RegisterCaCertificate(RegisterCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterCaCertificateWithOptions(request, runtime);
        }

        public async Task<RegisterCaCertificateResponse> RegisterCaCertificateAsync(RegisterCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterCaCertificateWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **RegisterDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **RegisterDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **RegisterDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **RegisterDeviceCredential** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **RevokeToken** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **RevokeToken** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **RevokeToken** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.
          * *   Each successful call to the **RevokeToken** operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   The **SendMessage** operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see [Developer guide](~~179160~~).
          * *   Before you call the **SendMessage** operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the [Instance Details](https://mqtt.console.aliyun.com) page that corresponds to the instance in the **ApsaraMQ for MQTT console**.
          * *   Messages that are sent by calling the **SendMessage** operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see [Export data from ApsaraMQ for MQTT to other Alibaba Cloud services](~~174527~~). You can call the **SendMessage** operation up to 1,000 times per second. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **SendMessage** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see [Billing rules](~~52819~~).
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
          * *   The **SendMessage** operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see [Developer guide](~~179160~~).
          * *   Before you call the **SendMessage** operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the [Instance Details](https://mqtt.console.aliyun.com) page that corresponds to the instance in the **ApsaraMQ for MQTT console**.
          * *   Messages that are sent by calling the **SendMessage** operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see [Export data from ApsaraMQ for MQTT to other Alibaba Cloud services](~~174527~~). You can call the **SendMessage** operation up to 1,000 times per second. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **SendMessage** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see [Billing rules](~~52819~~).
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
          * *   The **SendMessage** operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see [Developer guide](~~179160~~).
          * *   Before you call the **SendMessage** operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the [Instance Details](https://mqtt.console.aliyun.com) page that corresponds to the instance in the **ApsaraMQ for MQTT console**.
          * *   Messages that are sent by calling the **SendMessage** operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see [Export data from ApsaraMQ for MQTT to other Alibaba Cloud services](~~174527~~). You can call the **SendMessage** operation up to 1,000 times per second. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **SendMessage** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see [Billing rules](~~52819~~).
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
          * *   The **SendMessage** operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see [Developer guide](~~179160~~).
          * *   Before you call the **SendMessage** operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the [Instance Details](https://mqtt.console.aliyun.com) page that corresponds to the instance in the **ApsaraMQ for MQTT console**.
          * *   Messages that are sent by calling the **SendMessage** operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see [Export data from ApsaraMQ for MQTT to other Alibaba Cloud services](~~174527~~). You can call the **SendMessage** operation up to 1,000 times per second. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **SendMessage** operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **UnRegisterDeviceCredential** operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **UnRegisterDeviceCredential** operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **UnRegisterDeviceCredential** operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
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
          * *   You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see [Limits on QPS](~~163047~~).
          * *   Each successful call to the **UnRegisterDeviceCredential** operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see [Billing rules](~~52819~~).
          *
          * @param request UnRegisterDeviceCredentialRequest
          * @return UnRegisterDeviceCredentialResponse
         */
        public async Task<UnRegisterDeviceCredentialResponse> UnRegisterDeviceCredentialAsync(UnRegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnRegisterDeviceCredentialWithOptionsAsync(request, runtime);
        }

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

        public UpdateCustomAuthIdentityResponse UpdateCustomAuthIdentity(UpdateCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomAuthIdentityWithOptions(request, runtime);
        }

        public async Task<UpdateCustomAuthIdentityResponse> UpdateCustomAuthIdentityAsync(UpdateCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

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

        public UpdateCustomAuthPermissionResponse UpdateCustomAuthPermission(UpdateCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomAuthPermissionWithOptions(request, runtime);
        }

        public async Task<UpdateCustomAuthPermissionResponse> UpdateCustomAuthPermissionAsync(UpdateCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

    }
}
