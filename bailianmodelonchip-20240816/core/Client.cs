// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.BailianModelOnChip20240816.Models;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("bailianmodelonchip", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>主动交互消息传递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActiveInteractionCreateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActiveInteractionCreateResponse
        /// </returns>
        public ActiveInteractionCreateResponse ActiveInteractionCreateWithOptions(ActiveInteractionCreateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                body["image"] = request.Image;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveInteractionCreate",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/active/interaction/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveInteractionCreateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主动交互消息传递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActiveInteractionCreateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActiveInteractionCreateResponse
        /// </returns>
        public async Task<ActiveInteractionCreateResponse> ActiveInteractionCreateWithOptionsAsync(ActiveInteractionCreateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                body["image"] = request.Image;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveInteractionCreate",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/v1/active/interaction/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveInteractionCreateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主动交互消息传递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActiveInteractionCreateRequest
        /// </param>
        /// 
        /// <returns>
        /// ActiveInteractionCreateResponse
        /// </returns>
        public ActiveInteractionCreateResponse ActiveInteractionCreate(ActiveInteractionCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ActiveInteractionCreateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主动交互消息传递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActiveInteractionCreateRequest
        /// </param>
        /// 
        /// <returns>
        /// ActiveInteractionCreateResponse
        /// </returns>
        public async Task<ActiveInteractionCreateResponse> ActiveInteractionCreateAsync(ActiveInteractionCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ActiveInteractionCreateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceRegisterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeviceRegisterResponse
        /// </returns>
        public DeviceRegisterResponse DeviceRegisterWithOptions(DeviceRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nonce))
            {
                body["nonce"] = request.Nonce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTime))
            {
                body["requestTime"] = request.RequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceRegister",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceRegisterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceRegisterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeviceRegisterResponse
        /// </returns>
        public async Task<DeviceRegisterResponse> DeviceRegisterWithOptionsAsync(DeviceRegisterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nonce))
            {
                body["nonce"] = request.Nonce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTime))
            {
                body["requestTime"] = request.RequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeviceRegister",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/device/v1/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeviceRegisterResponse
        /// </returns>
        public DeviceRegisterResponse DeviceRegister(DeviceRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeviceRegisterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备注册</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeviceRegisterResponse
        /// </returns>
        public async Task<DeviceRegisterResponse> DeviceRegisterAsync(DeviceRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeviceRegisterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关校验Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetTokenWithOptions(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nonce))
            {
                body["nonce"] = request.Nonce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTime))
            {
                body["requestTime"] = request.RequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenKey))
            {
                body["tokenKey"] = request.TokenKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenType))
            {
                body["tokenType"] = request.TokenType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/auth/v1/token/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关校验Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nonce))
            {
                body["nonce"] = request.Nonce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTime))
            {
                body["requestTime"] = request.RequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenKey))
            {
                body["tokenKey"] = request.TokenKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenType))
            {
                body["tokenType"] = request.TokenType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2024-08-16",
                Protocol = "HTTPS",
                Pathname = "/open/api/auth/v1/token/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关校验Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取网关校验Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenWithOptionsAsync(request, headers, runtime);
        }

    }
}
