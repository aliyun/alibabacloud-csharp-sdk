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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activate CA Certificate</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅铂金版和专业版实例支持使用ActiveCaCertificate接口。</description></item>
        /// <item><description>单用户请求频率限制为500次/秒。如有特殊需求，请联系云消息队列 MQTT 版技术支持，钉钉群号：35228338。</description></item>
        /// <item><description>ActiveCaCertificate接口仅支持对已在云消息队列 MQTT 版服务端注册的CA证书进行操作，您可以通过<a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a>接口查询指定实例下已注册的CA证书。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActiveCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activate CA Certificate</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅铂金版和专业版实例支持使用ActiveCaCertificate接口。</description></item>
        /// <item><description>单用户请求频率限制为500次/秒。如有特殊需求，请联系云消息队列 MQTT 版技术支持，钉钉群号：35228338。</description></item>
        /// <item><description>ActiveCaCertificate接口仅支持对已在云消息队列 MQTT 版服务端注册的CA证书进行操作，您可以通过<a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a>接口查询指定实例下已注册的CA证书。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActiveCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activate CA Certificate</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅铂金版和专业版实例支持使用ActiveCaCertificate接口。</description></item>
        /// <item><description>单用户请求频率限制为500次/秒。如有特殊需求，请联系云消息队列 MQTT 版技术支持，钉钉群号：35228338。</description></item>
        /// <item><description>ActiveCaCertificate接口仅支持对已在云消息队列 MQTT 版服务端注册的CA证书进行操作，您可以通过<a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a>接口查询指定实例下已注册的CA证书。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ActiveCaCertificateResponse
        /// </returns>
        public ActiveCaCertificateResponse ActiveCaCertificate(ActiveCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveCaCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activate CA Certificate</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅铂金版和专业版实例支持使用ActiveCaCertificate接口。</description></item>
        /// <item><description>单用户请求频率限制为500次/秒。如有特殊需求，请联系云消息队列 MQTT 版技术支持，钉钉群号：35228338。</description></item>
        /// <item><description>ActiveCaCertificate接口仅支持对已在云消息队列 MQTT 版服务端注册的CA证书进行操作，您可以通过<a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a>接口查询指定实例下已注册的CA证书。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ActiveCaCertificateResponse
        /// </returns>
        public async Task<ActiveCaCertificateResponse> ActiveCaCertificateAsync(ActiveCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveCaCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reactivates a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client based on the registered CA certificate. If the CA certificate matches the device certificate, the client passes the authentication and the system automatically registers the device certificate with the ApsaraMQ for MQTT broker. After a device certificate is registered with an ApsaraMQ for MQTT broker, the certificate is automatically activated. If your device certificate is changed to the inactivated state, you can call this operation to reactivate the device certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActiveDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reactivates a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client based on the registered CA certificate. If the CA certificate matches the device certificate, the client passes the authentication and the system automatically registers the device certificate with the ApsaraMQ for MQTT broker. After a device certificate is registered with an ApsaraMQ for MQTT broker, the certificate is automatically activated. If your device certificate is changed to the inactivated state, you can call this operation to reactivate the device certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActiveDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reactivates a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client based on the registered CA certificate. If the CA certificate matches the device certificate, the client passes the authentication and the system automatically registers the device certificate with the ApsaraMQ for MQTT broker. After a device certificate is registered with an ApsaraMQ for MQTT broker, the certificate is automatically activated. If your device certificate is changed to the inactivated state, you can call this operation to reactivate the device certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ActiveDeviceCertificateResponse
        /// </returns>
        public ActiveDeviceCertificateResponse ActiveDeviceCertificate(ActiveDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveDeviceCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reactivates a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client based on the registered CA certificate. If the CA certificate matches the device certificate, the client passes the authentication and the system automatically registers the device certificate with the ApsaraMQ for MQTT broker. After a device certificate is registered with an ApsaraMQ for MQTT broker, the certificate is automatically activated. If your device certificate is changed to the inactivated state, you can call this operation to reactivate the device certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ActiveDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ActiveDeviceCertificateResponse
        /// </returns>
        public async Task<ActiveDeviceCertificateResponse> ActiveDeviceCertificateAsync(ActiveDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a device to the connection blacklist to disable connections from the device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthConnectBlackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthConnectBlackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a device to the connection blacklist to disable connections from the device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthConnectBlackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthConnectBlackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a device to the connection blacklist to disable connections from the device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthConnectBlackRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthConnectBlackResponse
        /// </returns>
        public AddCustomAuthConnectBlackResponse AddCustomAuthConnectBlack(AddCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthConnectBlackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a device to the connection blacklist to disable connections from the device.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthConnectBlackRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthConnectBlackResponse
        /// </returns>
        public async Task<AddCustomAuthConnectBlackResponse> AddCustomAuthConnectBlackAsync(AddCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the information about identity authentication. The identity can be accurate to a client.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthIdentityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the information about identity authentication. The identity can be accurate to a client.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthIdentityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the information about identity authentication. The identity can be accurate to a client.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthIdentityResponse
        /// </returns>
        public AddCustomAuthIdentityResponse AddCustomAuthIdentity(AddCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds the information about identity authentication. The identity can be accurate to a client.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthIdentityResponse
        /// </returns>
        public async Task<AddCustomAuthIdentityResponse> AddCustomAuthIdentityAsync(AddCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds permissions on topics. You must create a level-1 topic in the ApsaraMQ for MQTT console before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds permissions on topics. You must create a level-1 topic in the ApsaraMQ for MQTT console before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds permissions on topics. You must create a level-1 topic in the ApsaraMQ for MQTT console before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthPermissionResponse
        /// </returns>
        public AddCustomAuthPermissionResponse AddCustomAuthPermission(AddCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomAuthPermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds permissions on topics. You must create a level-1 topic in the ApsaraMQ for MQTT console before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCustomAuthPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomAuthPermissionResponse
        /// </returns>
        public async Task<AddCustomAuthPermissionResponse> AddCustomAuthPermissionAsync(AddCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a token from ApsaraMQ for MQTT. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>ApplyToken</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyTokenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a token from ApsaraMQ for MQTT. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>ApplyToken</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyTokenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a token from ApsaraMQ for MQTT. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>ApplyToken</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyTokenResponse
        /// </returns>
        public ApplyTokenResponse ApplyToken(ApplyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a token from ApsaraMQ for MQTT. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>ApplyToken</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyTokenResponse
        /// </returns>
        public async Task<ApplyTokenResponse> ApplyTokenAsync(ApplyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of multiple ApsaraMQ for MQTT clients by client ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the <b>BatchQuerySessionByClientIds</b> operation up to 100 times per second. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <b>BatchQuerySessionByClientIds</b> operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.</description></item>
        /// <item><description>Each successful call to the <b>BatchQuerySessionByClientIds</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchQuerySessionByClientIdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQuerySessionByClientIdsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of multiple ApsaraMQ for MQTT clients by client ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the <b>BatchQuerySessionByClientIds</b> operation up to 100 times per second. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <b>BatchQuerySessionByClientIds</b> operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.</description></item>
        /// <item><description>Each successful call to the <b>BatchQuerySessionByClientIds</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchQuerySessionByClientIdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQuerySessionByClientIdsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of multiple ApsaraMQ for MQTT clients by client ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the <b>BatchQuerySessionByClientIds</b> operation up to 100 times per second. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <b>BatchQuerySessionByClientIds</b> operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.</description></item>
        /// <item><description>Each successful call to the <b>BatchQuerySessionByClientIds</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchQuerySessionByClientIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQuerySessionByClientIdsResponse
        /// </returns>
        public BatchQuerySessionByClientIdsResponse BatchQuerySessionByClientIds(BatchQuerySessionByClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQuerySessionByClientIdsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of multiple ApsaraMQ for MQTT clients by client ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the <b>BatchQuerySessionByClientIds</b> operation up to 100 times per second. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <b>BatchQuerySessionByClientIds</b> operation to query the status of up to 10 ApsaraMQ for MQTT clients in a single query.</description></item>
        /// <item><description>Each successful call to the <b>BatchQuerySessionByClientIds</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchQuerySessionByClientIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQuerySessionByClientIdsResponse
        /// </returns>
        public async Task<BatchQuerySessionByClientIdsResponse> BatchQuerySessionByClientIdsAsync(BatchQuerySessionByClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQuerySessionByClientIdsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Proactively closes an online connection. After you call this API operation, the device may reconnect to the broker based on the client reconnection mechanism.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is still in the testing phase and is only available for Professional Edition instances in the Shanghai region. Legacy instances are not supported at this time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CloseConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseConnectionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Proactively closes an online connection. After you call this API operation, the device may reconnect to the broker based on the client reconnection mechanism.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is still in the testing phase and is only available for Professional Edition instances in the Shanghai region. Legacy instances are not supported at this time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CloseConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseConnectionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Proactively closes an online connection. After you call this API operation, the device may reconnect to the broker based on the client reconnection mechanism.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is still in the testing phase and is only available for Professional Edition instances in the Shanghai region. Legacy instances are not supported at this time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CloseConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseConnectionResponse
        /// </returns>
        public CloseConnectionResponse CloseConnection(CloseConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Proactively closes an online connection. After you call this API operation, the device may reconnect to the broker based on the client reconnection mechanism.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is still in the testing phase and is only available for Professional Edition instances in the Shanghai region. Legacy instances are not supported at this time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CloseConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseConnectionResponse
        /// </returns>
        public async Task<CloseConnectionResponse> CloseConnectionAsync(CloseConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a group ID. Before you connect producers and consumers to an ApsaraMQ for MQTT broker to send and receive messages, you must specify a unique ID for each client for identification. A client ID is in the format of \<GroupID>@@@\<DeviceID>. In the preceding format, DeviceID is the custom ID that you specify for the client, and GroupID is the ID of the group that you create on the ApsaraMQ for MQTT broker in advance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>CreateGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a group ID. Before you connect producers and consumers to an ApsaraMQ for MQTT broker to send and receive messages, you must specify a unique ID for each client for identification. A client ID is in the format of \<GroupID>@@@\<DeviceID>. In the preceding format, DeviceID is the custom ID that you specify for the client, and GroupID is the ID of the group that you create on the ApsaraMQ for MQTT broker in advance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>CreateGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a group ID. Before you connect producers and consumers to an ApsaraMQ for MQTT broker to send and receive messages, you must specify a unique ID for each client for identification. A client ID is in the format of \<GroupID>@@@\<DeviceID>. In the preceding format, DeviceID is the custom ID that you specify for the client, and GroupID is the ID of the group that you create on the ApsaraMQ for MQTT broker in advance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>CreateGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupIdResponse
        /// </returns>
        public CreateGroupIdResponse CreateGroupId(CreateGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a group ID. Before you connect producers and consumers to an ApsaraMQ for MQTT broker to send and receive messages, you must specify a unique ID for each client for identification. A client ID is in the format of \<GroupID>@@@\<DeviceID>. In the preceding format, DeviceID is the custom ID that you specify for the client, and GroupID is the ID of the group that you create on the ApsaraMQ for MQTT broker in advance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>CreateGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupIdResponse
        /// </returns>
        public async Task<CreateGroupIdResponse> CreateGroupIdAsync(CreateGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a certificate authority (CA) certificate from an ApsaraMQ for MQTT broker. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. Before you can use a CA certificate, you must register the certificate with an ApsaraMQ for MQTT broker. If you no longer require a CA certificate, you can call this operation to delete the certificate from the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// <item><description>You can call this operation to delete only CA certificates that are registered with ApsaraMQ for MQTT brokers. You can call the <a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a> operation to query CA certificates that are registered with an ApsaraMQ for MQTT instance.</description></item>
        /// <item><description>If you delete a specific CA certificate from an ApsaraMQ for MQTT broker, all device certificates that are issued by the CA certificate and are registered with the ApsaraMQ for MQTT broker are automatically deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a certificate authority (CA) certificate from an ApsaraMQ for MQTT broker. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. Before you can use a CA certificate, you must register the certificate with an ApsaraMQ for MQTT broker. If you no longer require a CA certificate, you can call this operation to delete the certificate from the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// <item><description>You can call this operation to delete only CA certificates that are registered with ApsaraMQ for MQTT brokers. You can call the <a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a> operation to query CA certificates that are registered with an ApsaraMQ for MQTT instance.</description></item>
        /// <item><description>If you delete a specific CA certificate from an ApsaraMQ for MQTT broker, all device certificates that are issued by the CA certificate and are registered with the ApsaraMQ for MQTT broker are automatically deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a certificate authority (CA) certificate from an ApsaraMQ for MQTT broker. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. Before you can use a CA certificate, you must register the certificate with an ApsaraMQ for MQTT broker. If you no longer require a CA certificate, you can call this operation to delete the certificate from the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// <item><description>You can call this operation to delete only CA certificates that are registered with ApsaraMQ for MQTT brokers. You can call the <a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a> operation to query CA certificates that are registered with an ApsaraMQ for MQTT instance.</description></item>
        /// <item><description>If you delete a specific CA certificate from an ApsaraMQ for MQTT broker, all device certificates that are issued by the CA certificate and are registered with the ApsaraMQ for MQTT broker are automatically deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCaCertificateResponse
        /// </returns>
        public DeleteCaCertificateResponse DeleteCaCertificate(DeleteCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCaCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a certificate authority (CA) certificate from an ApsaraMQ for MQTT broker. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. Before you can use a CA certificate, you must register the certificate with an ApsaraMQ for MQTT broker. If you no longer require a CA certificate, you can call this operation to delete the certificate from the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// <item><description>You can call this operation to delete only CA certificates that are registered with ApsaraMQ for MQTT brokers. You can call the <a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a> operation to query CA certificates that are registered with an ApsaraMQ for MQTT instance.</description></item>
        /// <item><description>If you delete a specific CA certificate from an ApsaraMQ for MQTT broker, all device certificates that are issued by the CA certificate and are registered with the ApsaraMQ for MQTT broker are automatically deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCaCertificateResponse
        /// </returns>
        public async Task<DeleteCaCertificateResponse> DeleteCaCertificateAsync(DeleteCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCaCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection blacklist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthConnectBlackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthConnectBlackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection blacklist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthConnectBlackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthConnectBlackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection blacklist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthConnectBlackRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthConnectBlackResponse
        /// </returns>
        public DeleteCustomAuthConnectBlackResponse DeleteCustomAuthConnectBlack(DeleteCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthConnectBlackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection blacklist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthConnectBlackRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthConnectBlackResponse
        /// </returns>
        public async Task<DeleteCustomAuthConnectBlackResponse> DeleteCustomAuthConnectBlackAsync(DeleteCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an identity for custom authorization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthIdentityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an identity for custom authorization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthIdentityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an identity for custom authorization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthIdentityResponse
        /// </returns>
        public DeleteCustomAuthIdentityResponse DeleteCustomAuthIdentity(DeleteCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an identity for custom authorization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthIdentityResponse
        /// </returns>
        public async Task<DeleteCustomAuthIdentityResponse> DeleteCustomAuthIdentityAsync(DeleteCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes permissions on a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes permissions on a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes permissions on a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthPermissionResponse
        /// </returns>
        public DeleteCustomAuthPermissionResponse DeleteCustomAuthPermission(DeleteCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAuthPermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes permissions on a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAuthPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAuthPermissionResponse
        /// </returns>
        public async Task<DeleteCustomAuthPermissionResponse> DeleteCustomAuthPermissionAsync(DeleteCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the registration information about a specific device certificate from an ApsaraMQ for MQTT broker. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client. If you no longer require a device certificate, you can call this operation to delete the registration information about the certificate from an ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the registration information about a specific device certificate from an ApsaraMQ for MQTT broker. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client. If you no longer require a device certificate, you can call this operation to delete the registration information about the certificate from an ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the registration information about a specific device certificate from an ApsaraMQ for MQTT broker. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client. If you no longer require a device certificate, you can call this operation to delete the registration information about the certificate from an ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeviceCertificateResponse
        /// </returns>
        public DeleteDeviceCertificateResponse DeleteDeviceCertificate(DeleteDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the registration information about a specific device certificate from an ApsaraMQ for MQTT broker. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client. If you no longer require a device certificate, you can call this operation to delete the registration information about the certificate from an ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeviceCertificateResponse
        /// </returns>
        public async Task<DeleteDeviceCertificateResponse> DeleteDeviceCertificateAsync(DeleteDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a group from an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>DeleteGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a group from an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>DeleteGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a group from an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>DeleteGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupIdResponse
        /// </returns>
        public DeleteGroupIdResponse DeleteGroupId(DeleteGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a group from an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>DeleteGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupIdResponse
        /// </returns>
        public async Task<DeleteGroupIdResponse> DeleteGroupIdAsync(DeleteGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a certificate authority (CA) certificate, such as the content and status of the certificate. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅铂金版和专业版实例支持使用GetCaCertificate接口。</description></item>
        /// <item><description>单用户请求频率限制为500次/秒。如有特殊需求，请联系云消息队列 MQTT 版技术支持，钉钉群号：35228338。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a certificate authority (CA) certificate, such as the content and status of the certificate. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅铂金版和专业版实例支持使用GetCaCertificate接口。</description></item>
        /// <item><description>单用户请求频率限制为500次/秒。如有特殊需求，请联系云消息队列 MQTT 版技术支持，钉钉群号：35228338。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a certificate authority (CA) certificate, such as the content and status of the certificate. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅铂金版和专业版实例支持使用GetCaCertificate接口。</description></item>
        /// <item><description>单用户请求频率限制为500次/秒。如有特殊需求，请联系云消息队列 MQTT 版技术支持，钉钉群号：35228338。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCaCertificateResponse
        /// </returns>
        public GetCaCertificateResponse GetCaCertificate(GetCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCaCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a certificate authority (CA) certificate, such as the content and status of the certificate. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>仅铂金版和专业版实例支持使用GetCaCertificate接口。</description></item>
        /// <item><description>单用户请求频率限制为500次/秒。如有特殊需求，请联系云消息队列 MQTT 版技术支持，钉钉群号：35228338。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCaCertificateResponse
        /// </returns>
        public async Task<GetCaCertificateResponse> GetCaCertificateAsync(GetCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCaCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum edition instances support the use of the GetDeviceCertificate interface. - The request frequency limit per user is 500 requests/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum edition instances support the use of the GetDeviceCertificate interface. - The request frequency limit per user is 500 requests/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum edition instances support the use of the GetDeviceCertificate interface. - The request frequency limit per user is 500 requests/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceCertificateResponse
        /// </returns>
        public GetDeviceCertificateResponse GetDeviceCertificate(GetDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum edition instances support the use of the GetDeviceCertificate interface. - The request frequency limit per user is 500 requests/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceCertificateResponse
        /// </returns>
        public async Task<GetDeviceCertificateResponse> GetDeviceCertificateAsync(GetDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access credential of a device. If unique-certificate-per-device authentication is used as the authentication method on an ApsaraMQ for MQTT broker, an access credential that you apply for in advance is required for authentication when you connect your device to the broker. The connection can be established only after the authentication is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>GetDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeviceCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access credential of a device. If unique-certificate-per-device authentication is used as the authentication method on an ApsaraMQ for MQTT broker, an access credential that you apply for in advance is required for authentication when you connect your device to the broker. The connection can be established only after the authentication is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>GetDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeviceCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access credential of a device. If unique-certificate-per-device authentication is used as the authentication method on an ApsaraMQ for MQTT broker, an access credential that you apply for in advance is required for authentication when you connect your device to the broker. The connection can be established only after the authentication is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>GetDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeviceCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceCredentialResponse
        /// </returns>
        public GetDeviceCredentialResponse GetDeviceCredential(GetDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access credential of a device. If unique-certificate-per-device authentication is used as the authentication method on an ApsaraMQ for MQTT broker, an access credential that you apply for in advance is required for authentication when you connect your device to the broker. The connection can be established only after the authentication is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>GetDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeviceCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceCredentialResponse
        /// </returns>
        public async Task<GetDeviceCredentialResponse> GetDeviceCredentialAsync(GetDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the registration code of a specific certificate authority (CA) certificate. When you register a CA certificate with an ApsaraMQ for MQTT broker, you must upload the validation certificate of the CA certificate to verify whether you have the private key of the CA certificate. The validation certificate of a CA certificate must be generated by using the registration code of the CA certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This API operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRegisterCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRegisterCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the registration code of a specific certificate authority (CA) certificate. When you register a CA certificate with an ApsaraMQ for MQTT broker, you must upload the validation certificate of the CA certificate to verify whether you have the private key of the CA certificate. The validation certificate of a CA certificate must be generated by using the registration code of the CA certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This API operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRegisterCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRegisterCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the registration code of a specific certificate authority (CA) certificate. When you register a CA certificate with an ApsaraMQ for MQTT broker, you must upload the validation certificate of the CA certificate to verify whether you have the private key of the CA certificate. The validation certificate of a CA certificate must be generated by using the registration code of the CA certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This API operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRegisterCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRegisterCodeResponse
        /// </returns>
        public GetRegisterCodeResponse GetRegisterCode(GetRegisterCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegisterCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the registration code of a specific certificate authority (CA) certificate. When you register a CA certificate with an ApsaraMQ for MQTT broker, you must upload the validation certificate of the CA certificate to verify whether you have the private key of the CA certificate. The validation certificate of a CA certificate must be generated by using the registration code of the CA certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This API operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRegisterCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRegisterCodeResponse
        /// </returns>
        public async Task<GetRegisterCodeResponse> GetRegisterCodeAsync(GetRegisterCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegisterCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregister a certificate authority (CA) certificate. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. If you no longer require a CA certificate, you can call this operation to deregister the certificate. If you want to continue using a deregistered CA certificate, you can call the ActiveCaCertificate operation to reactivate the certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// <item><description>You can call this operation to deregister only CA certificates that are registered with ApsaraMQ for MQTT brokers. You can call the <a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a> operation to query CA certificates that are registered with an ApsaraMQ for MQTT instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InactivateCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InactivateCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregister a certificate authority (CA) certificate. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. If you no longer require a CA certificate, you can call this operation to deregister the certificate. If you want to continue using a deregistered CA certificate, you can call the ActiveCaCertificate operation to reactivate the certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// <item><description>You can call this operation to deregister only CA certificates that are registered with ApsaraMQ for MQTT brokers. You can call the <a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a> operation to query CA certificates that are registered with an ApsaraMQ for MQTT instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InactivateCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InactivateCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregister a certificate authority (CA) certificate. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. If you no longer require a CA certificate, you can call this operation to deregister the certificate. If you want to continue using a deregistered CA certificate, you can call the ActiveCaCertificate operation to reactivate the certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// <item><description>You can call this operation to deregister only CA certificates that are registered with ApsaraMQ for MQTT brokers. You can call the <a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a> operation to query CA certificates that are registered with an ApsaraMQ for MQTT instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InactivateCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// InactivateCaCertificateResponse
        /// </returns>
        public InactivateCaCertificateResponse InactivateCaCertificate(InactivateCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InactivateCaCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregister a certificate authority (CA) certificate. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. If you no longer require a CA certificate, you can call this operation to deregister the certificate. If you want to continue using a deregistered CA certificate, you can call the ActiveCaCertificate operation to reactivate the certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// <item><description>You can call this operation to deregister only CA certificates that are registered with ApsaraMQ for MQTT brokers. You can call the <a href="https://help.aliyun.com/document_detail/436768.html">ListCaCertificate</a> operation to query CA certificates that are registered with an ApsaraMQ for MQTT instance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InactivateCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// InactivateCaCertificateResponse
        /// </returns>
        public async Task<InactivateCaCertificateResponse> InactivateCaCertificateAsync(InactivateCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InactivateCaCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregisters a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InactivateDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InactivateDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregisters a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InactivateDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InactivateDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregisters a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InactivateDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// InactivateDeviceCertificateResponse
        /// </returns>
        public InactivateDeviceCertificateResponse InactivateDeviceCertificate(InactivateDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InactivateDeviceCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregisters a device certificate. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is supported only by ApsaraMQ for MQTT Enterprise Platinum Edition and Professional Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per Alibaba Cloud account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InactivateDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// InactivateDeviceCertificateResponse
        /// </returns>
        public async Task<InactivateDeviceCertificateResponse> InactivateDeviceCertificateAsync(InactivateDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InactivateDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all certificate authority (CA) certificates that are registered with an ApsaraMQ for MQTT instance. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the ListCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact the Micro Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all certificate authority (CA) certificates that are registered with an ApsaraMQ for MQTT instance. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the ListCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact the Micro Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all certificate authority (CA) certificates that are registered with an ApsaraMQ for MQTT instance. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the ListCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact the Micro Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCaCertificateResponse
        /// </returns>
        public ListCaCertificateResponse ListCaCertificate(ListCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCaCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all certificate authority (CA) certificates that are registered with an ApsaraMQ for MQTT instance. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the ListCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact the Micro Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCaCertificateResponse
        /// </returns>
        public async Task<ListCaCertificateResponse> ListCaCertificateAsync(ListCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCaCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all device certificates that are registered with an ApsaraMQ for MQTT instance. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the ListDeviceCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all device certificates that are registered with an ApsaraMQ for MQTT instance. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the ListDeviceCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeviceCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all device certificates that are registered with an ApsaraMQ for MQTT instance. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the ListDeviceCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCertificateResponse
        /// </returns>
        public ListDeviceCertificateResponse ListDeviceCertificate(ListDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all device certificates that are registered with an ApsaraMQ for MQTT instance. Device certificates are digital certificates issued to clients by certificate authority (CA) root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the ListDeviceCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeviceCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCertificateResponse
        /// </returns>
        public async Task<ListDeviceCertificateResponse> ListDeviceCertificateAsync(ListDeviceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all device certificates that are issued by a certificate authority (CA) certificate and registered with ApsaraMQ for MQTT brokers. Device certificates are digital certificates issued to clients by CA root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional edition instances support using the ListDeviceCertificateByCaSn interface. - The request frequency limit for a single user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeviceCertificateByCaSnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCertificateByCaSnResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all device certificates that are issued by a certificate authority (CA) certificate and registered with ApsaraMQ for MQTT brokers. Device certificates are digital certificates issued to clients by CA root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional edition instances support using the ListDeviceCertificateByCaSn interface. - The request frequency limit for a single user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeviceCertificateByCaSnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCertificateByCaSnResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all device certificates that are issued by a certificate authority (CA) certificate and registered with ApsaraMQ for MQTT brokers. Device certificates are digital certificates issued to clients by CA root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional edition instances support using the ListDeviceCertificateByCaSn interface. - The request frequency limit for a single user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeviceCertificateByCaSnRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCertificateByCaSnResponse
        /// </returns>
        public ListDeviceCertificateByCaSnResponse ListDeviceCertificateByCaSn(ListDeviceCertificateByCaSnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCertificateByCaSnWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all device certificates that are issued by a certificate authority (CA) certificate and registered with ApsaraMQ for MQTT brokers. Device certificates are digital certificates issued to clients by CA root certificates. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, the broker uses the device certificate to authenticate the client. If the client passes the authentication, the client and the broker can communicate with each other based on the encrypted private key in the device certificate. If the client fails the authentication, access requests from the client are denied by the client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional edition instances support using the ListDeviceCertificateByCaSn interface. - The request frequency limit for a single user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDeviceCertificateByCaSnRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCertificateByCaSnResponse
        /// </returns>
        public async Task<ListDeviceCertificateByCaSnResponse> ListDeviceCertificateByCaSnAsync(ListDeviceCertificateByCaSnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCertificateByCaSnWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries clients that have applied for access credentials in unique-certificate-per-device authentication mode in an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceCredentialClientIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCredentialClientIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries clients that have applied for access credentials in unique-certificate-per-device authentication mode in an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceCredentialClientIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCredentialClientIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries clients that have applied for access credentials in unique-certificate-per-device authentication mode in an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceCredentialClientIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCredentialClientIdResponse
        /// </returns>
        public ListDeviceCredentialClientIdResponse ListDeviceCredentialClientId(ListDeviceCredentialClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceCredentialClientIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries clients that have applied for access credentials in unique-certificate-per-device authentication mode in an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeviceCredentialClientIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeviceCredentialClientIdResponse
        /// </returns>
        public async Task<ListDeviceCredentialClientIdResponse> ListDeviceCredentialClientIdAsync(ListDeviceCredentialClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceCredentialClientIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all groups on an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>ListGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all groups on an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>ListGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all groups on an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>ListGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupIdResponse
        /// </returns>
        public ListGroupIdResponse ListGroupId(ListGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all groups on an ApsaraMQ for MQTT instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Each successful call to the <b>ListGroupId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGroupIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupIdResponse
        /// </returns>
        public async Task<ListGroupIdResponse> ListGroupIdAsync(ListGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a client ID in a connection blacklist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthConnectBlackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthConnectBlackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a client ID in a connection blacklist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthConnectBlackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthConnectBlackResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a client ID in a connection blacklist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthConnectBlackRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthConnectBlackResponse
        /// </returns>
        public QueryCustomAuthConnectBlackResponse QueryCustomAuthConnectBlack(QueryCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthConnectBlackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a client ID in a connection blacklist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthConnectBlackRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthConnectBlackResponse
        /// </returns>
        public async Task<QueryCustomAuthConnectBlackResponse> QueryCustomAuthConnectBlackAsync(QueryCustomAuthConnectBlackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthConnectBlackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about custom identity authentication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthIdentityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about custom identity authentication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthIdentityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about custom identity authentication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthIdentityResponse
        /// </returns>
        public QueryCustomAuthIdentityResponse QueryCustomAuthIdentity(QueryCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about custom identity authentication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthIdentityResponse
        /// </returns>
        public async Task<QueryCustomAuthIdentityResponse> QueryCustomAuthIdentityAsync(QueryCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authorization information about a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authorization information about a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authorization information about a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthPermissionResponse
        /// </returns>
        public QueryCustomAuthPermissionResponse QueryCustomAuthPermission(QueryCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomAuthPermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authorization information about a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomAuthPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomAuthPermissionResponse
        /// </returns>
        public async Task<QueryCustomAuthPermissionResponse> QueryCustomAuthPermissionAsync(QueryCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trace of a device that corresponds to an ApsaraMQ for MQTT client by page. When the status of a device is abnormal, you can call this operation to query the connection history of the device. This helps you efficiently troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceDevice</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trace of a device that corresponds to an ApsaraMQ for MQTT client by page. When the status of a device is abnormal, you can call this operation to query the connection history of the device. This helps you efficiently troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceDevice</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trace of a device that corresponds to an ApsaraMQ for MQTT client by page. When the status of a device is abnormal, you can call this operation to query the connection history of the device. This helps you efficiently troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceDevice</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceDeviceResponse
        /// </returns>
        public QueryMqttTraceDeviceResponse QueryMqttTraceDevice(QueryMqttTraceDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMqttTraceDeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trace of a device that corresponds to an ApsaraMQ for MQTT client by page. When the status of a device is abnormal, you can call this operation to query the connection history of the device. This helps you efficiently troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceDevice</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceDeviceResponse
        /// </returns>
        public async Task<QueryMqttTraceDeviceResponse> QueryMqttTraceDeviceAsync(QueryMqttTraceDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMqttTraceDeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries messages on a device within a specific period of time. If a message is not sent or received as expected, you can call this operation to query the messaging status of the message to efficiently troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessageOfClient</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessageOfClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessageOfClientResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries messages on a device within a specific period of time. If a message is not sent or received as expected, you can call this operation to query the messaging status of the message to efficiently troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessageOfClient</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessageOfClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessageOfClientResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries messages on a device within a specific period of time. If a message is not sent or received as expected, you can call this operation to query the messaging status of the message to efficiently troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessageOfClient</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessageOfClientRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessageOfClientResponse
        /// </returns>
        public QueryMqttTraceMessageOfClientResponse QueryMqttTraceMessageOfClient(QueryMqttTraceMessageOfClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMqttTraceMessageOfClientWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries messages on a device within a specific period of time. If a message is not sent or received as expected, you can call this operation to query the messaging status of the message to efficiently troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessageOfClient</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessageOfClientRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessageOfClientResponse
        /// </returns>
        public async Task<QueryMqttTraceMessageOfClientResponse> QueryMqttTraceMessageOfClientAsync(QueryMqttTraceMessageOfClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMqttTraceMessageOfClientWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trace of a message. If a message is not sent or received as expected, you can call this operation to view the message details to troubleshoot the issue. For example, you can query the time when the message is published and the client that publishes the message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessagePublish</b> operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessagePublishRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessagePublishResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trace of a message. If a message is not sent or received as expected, you can call this operation to view the message details to troubleshoot the issue. For example, you can query the time when the message is published and the client that publishes the message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessagePublish</b> operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessagePublishRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessagePublishResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trace of a message. If a message is not sent or received as expected, you can call this operation to view the message details to troubleshoot the issue. For example, you can query the time when the message is published and the client that publishes the message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessagePublish</b> operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessagePublishRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessagePublishResponse
        /// </returns>
        public QueryMqttTraceMessagePublishResponse QueryMqttTraceMessagePublish(QueryMqttTraceMessagePublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMqttTraceMessagePublishWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trace of a message. If a message is not sent or received as expected, you can call this operation to view the message details to troubleshoot the issue. For example, you can query the time when the message is published and the client that publishes the message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessagePublish</b> operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessagePublishRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessagePublishResponse
        /// </returns>
        public async Task<QueryMqttTraceMessagePublishResponse> QueryMqttTraceMessagePublishAsync(QueryMqttTraceMessagePublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMqttTraceMessagePublishWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery trace of a message. If a message is not sent or received as expected, you can call this operation to view the details about the message. For example, you can query the clients that subscribe to the message and the time when the message is delivered. This operation helps you locate the problem and identify the cause of the problem.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessageSubscribe</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessageSubscribeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessageSubscribeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery trace of a message. If a message is not sent or received as expected, you can call this operation to view the details about the message. For example, you can query the clients that subscribe to the message and the time when the message is delivered. This operation helps you locate the problem and identify the cause of the problem.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessageSubscribe</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessageSubscribeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessageSubscribeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery trace of a message. If a message is not sent or received as expected, you can call this operation to view the details about the message. For example, you can query the clients that subscribe to the message and the time when the message is delivered. This operation helps you locate the problem and identify the cause of the problem.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessageSubscribe</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessageSubscribeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessageSubscribeResponse
        /// </returns>
        public QueryMqttTraceMessageSubscribeResponse QueryMqttTraceMessageSubscribe(QueryMqttTraceMessageSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMqttTraceMessageSubscribeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery trace of a message. If a message is not sent or received as expected, you can call this operation to view the details about the message. For example, you can query the clients that subscribe to the message and the time when the message is delivered. This operation helps you locate the problem and identify the cause of the problem.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each successful call to the <b>QueryMqttTraceMessageSubscribe</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// <list type="bullet">
        /// <item><description>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMqttTraceMessageSubscribeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMqttTraceMessageSubscribeResponse
        /// </returns>
        public async Task<QueryMqttTraceMessageSubscribeResponse> QueryMqttTraceMessageSubscribeAsync(QueryMqttTraceMessageSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMqttTraceMessageSubscribeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the running status of an ApsaraMQ for MQTT client. You can troubleshoot issues based on the queried results. You can enter the ID of an ApsaraMQ for MQTT client to check the connection status and IP address of the device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second.**** For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>QuerySessionByClientId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySessionByClientIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionByClientIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the running status of an ApsaraMQ for MQTT client. You can troubleshoot issues based on the queried results. You can enter the ID of an ApsaraMQ for MQTT client to check the connection status and IP address of the device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second.**** For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>QuerySessionByClientId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySessionByClientIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionByClientIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the running status of an ApsaraMQ for MQTT client. You can troubleshoot issues based on the queried results. You can enter the ID of an ApsaraMQ for MQTT client to check the connection status and IP address of the device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second.**** For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>QuerySessionByClientId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySessionByClientIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionByClientIdResponse
        /// </returns>
        public QuerySessionByClientIdResponse QuerySessionByClientId(QuerySessionByClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySessionByClientIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the running status of an ApsaraMQ for MQTT client. You can troubleshoot issues based on the queried results. You can enter the ID of an ApsaraMQ for MQTT client to check the connection status and IP address of the device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second.**** For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>QuerySessionByClientId</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QuerySessionByClientIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionByClientIdResponse
        /// </returns>
        public async Task<QuerySessionByClientIdResponse> QuerySessionByClientIdAsync(QuerySessionByClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySessionByClientIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a token. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker. A token is a temporary credential and is valid only within a specific period of time. You can call this operation to query whether a token expires.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>QueryToken</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTokenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a token. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker. A token is a temporary credential and is valid only within a specific period of time. You can call this operation to query whether a token expires.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>QueryToken</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTokenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a token. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker. A token is a temporary credential and is valid only within a specific period of time. You can call this operation to query whether a token expires.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>QueryToken</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTokenResponse
        /// </returns>
        public QueryTokenResponse QueryToken(QueryTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a token. If token-based authentication is used for permission authentication on an ApsaraMQ for MQTT broker, a token that is issued by the broker is required for authentication each time a client is connected to the broker. A token is a temporary credential and is valid only within a specific period of time. You can call this operation to query whether a token expires.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 100 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>QueryToken</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTokenResponse
        /// </returns>
        public async Task<QueryTokenResponse> QueryTokenAsync(QueryTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the access credential of a device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Limits</h2>
        /// <para>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <remarks>
        /// <para> Each successful call to the <b>RefreshDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RefreshDeviceCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshDeviceCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the access credential of a device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Limits</h2>
        /// <para>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <remarks>
        /// <para> Each successful call to the <b>RefreshDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RefreshDeviceCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshDeviceCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the access credential of a device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Limits</h2>
        /// <para>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <remarks>
        /// <para> Each successful call to the <b>RefreshDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RefreshDeviceCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshDeviceCredentialResponse
        /// </returns>
        public RefreshDeviceCredentialResponse RefreshDeviceCredential(RefreshDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshDeviceCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the access credential of a device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Limits</h2>
        /// <para>You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <remarks>
        /// <para> Each successful call to the <b>RefreshDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// RefreshDeviceCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshDeviceCredentialResponse
        /// </returns>
        public async Task<RefreshDeviceCredentialResponse> RefreshDeviceCredentialAsync(RefreshDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDeviceCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a certificate authority (CA) certificate with an ApsaraMQ for MQTT broker. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. Before you use a device certificate to authenticate an ApsaraMQ for MQTT client, you must register the CA certificate for which you apply with the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the RegisterCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a certificate authority (CA) certificate with an ApsaraMQ for MQTT broker. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. Before you use a device certificate to authenticate an ApsaraMQ for MQTT client, you must register the CA certificate for which you apply with the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the RegisterCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterCaCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCaCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a certificate authority (CA) certificate with an ApsaraMQ for MQTT broker. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. Before you use a device certificate to authenticate an ApsaraMQ for MQTT client, you must register the CA certificate for which you apply with the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the RegisterCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCaCertificateResponse
        /// </returns>
        public RegisterCaCertificateResponse RegisterCaCertificate(RegisterCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterCaCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a certificate authority (CA) certificate with an ApsaraMQ for MQTT broker. ApsaraMQ for MQTT allows you to use X.509 certificates for authentication. When you connect an ApsaraMQ for MQTT client to an ApsaraMQ for MQTT broker, you can use the device certificate to implement authentication. CA certificates are used to issue device certificates to clients and validate the device certificates. Before you use a device certificate to authenticate an ApsaraMQ for MQTT client, you must register the CA certificate for which you apply with the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Only Platinum and Professional instances support using the RegisterCaCertificate interface. - The request frequency limit per user is 500 times/second. For special requirements, please contact Cloud Message Queue MQTT version technical support, DingTalk group number: 35228338.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterCaCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCaCertificateResponse
        /// </returns>
        public async Task<RegisterCaCertificateResponse> RegisterCaCertificateAsync(RegisterCaCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterCaCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers an access credential for a device. In unique-certificate-per-device authentication mode, an application server applies a unique access credential for each device from the corresponding ApsaraMQ for MQTT broker. The access credential of a device consists of the client ID, AccessKey ID, and AccessKey secret of the device. When you connect a device to ApsaraMQ for MQTT, you must configure Username and Password based on the access credential of the device for authentication. You can activate the device and transfer data between the device and ApsaraMQ for MQTT only after the authentication is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>RegisterDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterDeviceCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterDeviceCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers an access credential for a device. In unique-certificate-per-device authentication mode, an application server applies a unique access credential for each device from the corresponding ApsaraMQ for MQTT broker. The access credential of a device consists of the client ID, AccessKey ID, and AccessKey secret of the device. When you connect a device to ApsaraMQ for MQTT, you must configure Username and Password based on the access credential of the device for authentication. You can activate the device and transfer data between the device and ApsaraMQ for MQTT only after the authentication is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>RegisterDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterDeviceCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterDeviceCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers an access credential for a device. In unique-certificate-per-device authentication mode, an application server applies a unique access credential for each device from the corresponding ApsaraMQ for MQTT broker. The access credential of a device consists of the client ID, AccessKey ID, and AccessKey secret of the device. When you connect a device to ApsaraMQ for MQTT, you must configure Username and Password based on the access credential of the device for authentication. You can activate the device and transfer data between the device and ApsaraMQ for MQTT only after the authentication is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>RegisterDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterDeviceCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterDeviceCredentialResponse
        /// </returns>
        public RegisterDeviceCredentialResponse RegisterDeviceCredential(RegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers an access credential for a device. In unique-certificate-per-device authentication mode, an application server applies a unique access credential for each device from the corresponding ApsaraMQ for MQTT broker. The access credential of a device consists of the client ID, AccessKey ID, and AccessKey secret of the device. When you connect a device to ApsaraMQ for MQTT, you must configure Username and Password based on the access credential of the device for authentication. You can activate the device and transfer data between the device and ApsaraMQ for MQTT only after the authentication is passed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>RegisterDeviceCredential</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterDeviceCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterDeviceCredentialResponse
        /// </returns>
        public async Task<RegisterDeviceCredentialResponse> RegisterDeviceCredentialAsync(RegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a token.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>RevokeToken</b> operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a token.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>RevokeToken</b> operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a token.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>RevokeToken</b> operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenResponse
        /// </returns>
        public RevokeTokenResponse RevokeToken(RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes a token.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 5 times per second per account. If you want to increase the limit, join the DingTalk group 35228338 to contact ApsaraMQ for MQTT technical support.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>RevokeToken</b> operation increases the messaging transactions per second (TPS). This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenResponse
        /// </returns>
        public async Task<RevokeTokenResponse> RevokeTokenAsync(RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a single message from an application on a cloud server to ApsaraMQ for MQTT.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The <b>SendMessage</b> operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see <a href="https://help.aliyun.com/document_detail/179160.html">Developer guide</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call the <b>SendMessage</b> operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the <a href="https://mqtt.console.aliyun.com">Instance Details</a> page that corresponds to the instance in the <b>ApsaraMQ for MQTT console</b>.</description></item>
        /// <item><description>Messages that are sent by calling the <b>SendMessage</b> operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see <a href="https://help.aliyun.com/document_detail/174527.html">Export data from ApsaraMQ for MQTT to other Alibaba Cloud services</a>. You can call the <b>SendMessage</b> operation up to 1,000 times per second. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// <item><description>Each successful call to the <b>SendMessage</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a single message from an application on a cloud server to ApsaraMQ for MQTT.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The <b>SendMessage</b> operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see <a href="https://help.aliyun.com/document_detail/179160.html">Developer guide</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call the <b>SendMessage</b> operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the <a href="https://mqtt.console.aliyun.com">Instance Details</a> page that corresponds to the instance in the <b>ApsaraMQ for MQTT console</b>.</description></item>
        /// <item><description>Messages that are sent by calling the <b>SendMessage</b> operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see <a href="https://help.aliyun.com/document_detail/174527.html">Export data from ApsaraMQ for MQTT to other Alibaba Cloud services</a>. You can call the <b>SendMessage</b> operation up to 1,000 times per second. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// <item><description>Each successful call to the <b>SendMessage</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a single message from an application on a cloud server to ApsaraMQ for MQTT.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The <b>SendMessage</b> operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see <a href="https://help.aliyun.com/document_detail/179160.html">Developer guide</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call the <b>SendMessage</b> operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the <a href="https://mqtt.console.aliyun.com">Instance Details</a> page that corresponds to the instance in the <b>ApsaraMQ for MQTT console</b>.</description></item>
        /// <item><description>Messages that are sent by calling the <b>SendMessage</b> operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see <a href="https://help.aliyun.com/document_detail/174527.html">Export data from ApsaraMQ for MQTT to other Alibaba Cloud services</a>. You can call the <b>SendMessage</b> operation up to 1,000 times per second. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// <item><description>Each successful call to the <b>SendMessage</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a single message from an application on a cloud server to ApsaraMQ for MQTT.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The <b>SendMessage</b> operation is called by applications on cloud servers. It is complementary to the operation that is called by ApsaraMQ for MQTT clients to send messages. For information about the differences between the scenarios of sending messages from applications on cloud servers and the scenarios of sending messages from ApsaraMQ for MQTT clients, see <a href="https://help.aliyun.com/document_detail/179160.html">Developer guide</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call the <b>SendMessage</b> operation, make sure that the kernel version of your ApsaraMQ for MQTT instance is 3.3.0 or later. You can obtain the information about the kernel version on the <a href="https://mqtt.console.aliyun.com">Instance Details</a> page that corresponds to the instance in the <b>ApsaraMQ for MQTT console</b>.</description></item>
        /// <item><description>Messages that are sent by calling the <b>SendMessage</b> operation cannot be forwarded to ApsaraMQ for RocketMQ. If you want to use an ApsaraMQ for MQTT to forward messages to ApsaraMQ for RocketMQ, send the messages by using an SDK. For more information, see <a href="https://help.aliyun.com/document_detail/174527.html">Export data from ApsaraMQ for MQTT to other Alibaba Cloud services</a>. You can call the <b>SendMessage</b> operation up to 1,000 times per second. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</description></item>
        /// <item><description>Each successful call to the <b>SendMessage</b> operation increases the messaging transactions per second (TPS) by one. This affects the billing of your instance. For information about the billing details, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置多域名证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSniConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSniConfigResponse
        /// </returns>
        public SetSniConfigResponse SetSniConfigWithOptions(SetSniConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCertificate))
            {
                query["DefaultCertificate"] = request.DefaultCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniConfig))
            {
                query["SniConfig"] = request.SniConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSniConfig",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSniConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置多域名证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSniConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSniConfigResponse
        /// </returns>
        public async Task<SetSniConfigResponse> SetSniConfigWithOptionsAsync(SetSniConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCertificate))
            {
                query["DefaultCertificate"] = request.DefaultCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MqttInstanceId))
            {
                query["MqttInstanceId"] = request.MqttInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SniConfig))
            {
                query["SniConfig"] = request.SniConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSniConfig",
                Version = "2020-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSniConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置多域名证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSniConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSniConfigResponse
        /// </returns>
        public SetSniConfigResponse SetSniConfig(SetSniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSniConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置多域名证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSniConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSniConfigResponse
        /// </returns>
        public async Task<SetSniConfigResponse> SetSniConfigAsync(SetSniConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSniConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregisters the access credential of a device. After the access credential of a device is deregistered, you can no longer use the access credential to authenticate the device on the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>UnRegisterDeviceCredential</b> operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnRegisterDeviceCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnRegisterDeviceCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregisters the access credential of a device. After the access credential of a device is deregistered, you can no longer use the access credential to authenticate the device on the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>UnRegisterDeviceCredential</b> operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnRegisterDeviceCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnRegisterDeviceCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregisters the access credential of a device. After the access credential of a device is deregistered, you can no longer use the access credential to authenticate the device on the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>UnRegisterDeviceCredential</b> operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnRegisterDeviceCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UnRegisterDeviceCredentialResponse
        /// </returns>
        public UnRegisterDeviceCredentialResponse UnRegisterDeviceCredential(UnRegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnRegisterDeviceCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deregisters the access credential of a device. After the access credential of a device is deregistered, you can no longer use the access credential to authenticate the device on the ApsaraMQ for MQTT broker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation up to 500 times per second per account. If the limit is exceeded, throttling is triggered. This may affect your business. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/163047.html">Limits on QPS</a>.</para>
        /// <list type="bullet">
        /// <item><description>Each successful call to the <b>UnRegisterDeviceCredential</b> operation increases the number of transactions per second (TPS) by one. This affects the billing of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/52819.html">Billing rules</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnRegisterDeviceCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UnRegisterDeviceCredentialResponse
        /// </returns>
        public async Task<UnRegisterDeviceCredentialResponse> UnRegisterDeviceCredentialAsync(UnRegisterDeviceCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnRegisterDeviceCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about custom identity authentication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAuthIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAuthIdentityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about custom identity authentication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAuthIdentityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAuthIdentityResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about custom identity authentication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAuthIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAuthIdentityResponse
        /// </returns>
        public UpdateCustomAuthIdentityResponse UpdateCustomAuthIdentity(UpdateCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomAuthIdentityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about custom identity authentication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAuthIdentityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAuthIdentityResponse
        /// </returns>
        public async Task<UpdateCustomAuthIdentityResponse> UpdateCustomAuthIdentityAsync(UpdateCustomAuthIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomAuthIdentityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the permissions on a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAuthPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAuthPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the permissions on a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAuthPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAuthPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the permissions on a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAuthPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAuthPermissionResponse
        /// </returns>
        public UpdateCustomAuthPermissionResponse UpdateCustomAuthPermission(UpdateCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomAuthPermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the permissions on a topic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAuthPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAuthPermissionResponse
        /// </returns>
        public async Task<UpdateCustomAuthPermissionResponse> UpdateCustomAuthPermissionAsync(UpdateCustomAuthPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomAuthPermissionWithOptionsAsync(request, runtime);
        }

    }
}
