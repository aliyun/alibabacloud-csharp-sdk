// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.QwenB2BMed20261116.Models;

namespace AlibabaCloud.SDK.QwenB2BMed20261116
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "QwenB2BMed";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("qwenb2bmed", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Initiates a conversation with the Qwen medical agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalAgentChatRequest
        /// </param>
        /// <param name="headers">
        /// MedicalAgentChatHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MedicalAgentChatResponse
        /// </returns>
        public MedicalAgentChatResponse MedicalAgentChatWithOptions(MedicalAgentChatRequest request, MedicalAgentChatHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Communication))
            {
                body["communication"] = request.Communication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWAccess))
            {
                realHeaders["X-GW-Access"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWAccess);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWNonce))
            {
                realHeaders["X-GW-Nonce"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWNonce);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWProtocol))
            {
                realHeaders["X-GW-Protocol"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWProtocol);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWSignature))
            {
                realHeaders["X-GW-Signature"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWSignature);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWTimestamp))
            {
                realHeaders["X-GW-Timestamp"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWTimestamp);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XRequestId))
            {
                realHeaders["X-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XRequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MedicalAgentChat",
                Version = "2026-11-16",
                Protocol = "HTTPS",
                Pathname = "/v1/api/medicalQa",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MedicalAgentChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a conversation with the Qwen medical agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalAgentChatRequest
        /// </param>
        /// <param name="headers">
        /// MedicalAgentChatHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MedicalAgentChatResponse
        /// </returns>
        public async Task<MedicalAgentChatResponse> MedicalAgentChatWithOptionsAsync(MedicalAgentChatRequest request, MedicalAgentChatHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Communication))
            {
                body["communication"] = request.Communication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWAccess))
            {
                realHeaders["X-GW-Access"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWAccess);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWNonce))
            {
                realHeaders["X-GW-Nonce"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWNonce);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWProtocol))
            {
                realHeaders["X-GW-Protocol"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWProtocol);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWSignature))
            {
                realHeaders["X-GW-Signature"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWSignature);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWTimestamp))
            {
                realHeaders["X-GW-Timestamp"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWTimestamp);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XRequestId))
            {
                realHeaders["X-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XRequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MedicalAgentChat",
                Version = "2026-11-16",
                Protocol = "HTTPS",
                Pathname = "/v1/api/medicalQa",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MedicalAgentChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a conversation with the Qwen medical agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalAgentChatRequest
        /// </param>
        /// 
        /// <returns>
        /// MedicalAgentChatResponse
        /// </returns>
        public MedicalAgentChatResponse MedicalAgentChat(MedicalAgentChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MedicalAgentChatHeaders headers = new MedicalAgentChatHeaders();
            return MedicalAgentChatWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a conversation with the Qwen medical agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalAgentChatRequest
        /// </param>
        /// 
        /// <returns>
        /// MedicalAgentChatResponse
        /// </returns>
        public async Task<MedicalAgentChatResponse> MedicalAgentChatAsync(MedicalAgentChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MedicalAgentChatHeaders headers = new MedicalAgentChatHeaders();
            return await MedicalAgentChatWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs inference using the external Qwen medical foundation model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalModelInferenceRequest
        /// </param>
        /// <param name="headers">
        /// MedicalModelInferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MedicalModelInferenceResponse
        /// </returns>
        public MedicalModelInferenceResponse MedicalModelInferenceWithOptions(MedicalModelInferenceRequest request, MedicalModelInferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Communication))
            {
                body["communication"] = request.Communication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWAccess))
            {
                realHeaders["X-GW-Access"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWAccess);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWNonce))
            {
                realHeaders["X-GW-Nonce"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWNonce);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWProtocol))
            {
                realHeaders["X-GW-Protocol"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWProtocol);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWSignature))
            {
                realHeaders["X-GW-Signature"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWSignature);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWTimestamp))
            {
                realHeaders["X-GW-Timestamp"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWTimestamp);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XRequestId))
            {
                realHeaders["X-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XRequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MedicalModelInference",
                Version = "2026-11-16",
                Protocol = "HTTPS",
                Pathname = "/v1/api/directModel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MedicalModelInferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs inference using the external Qwen medical foundation model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalModelInferenceRequest
        /// </param>
        /// <param name="headers">
        /// MedicalModelInferenceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MedicalModelInferenceResponse
        /// </returns>
        public async Task<MedicalModelInferenceResponse> MedicalModelInferenceWithOptionsAsync(MedicalModelInferenceRequest request, MedicalModelInferenceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Communication))
            {
                body["communication"] = request.Communication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWAccess))
            {
                realHeaders["X-GW-Access"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWAccess);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWNonce))
            {
                realHeaders["X-GW-Nonce"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWNonce);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWProtocol))
            {
                realHeaders["X-GW-Protocol"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWProtocol);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWSignature))
            {
                realHeaders["X-GW-Signature"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWSignature);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWTimestamp))
            {
                realHeaders["X-GW-Timestamp"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWTimestamp);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XRequestId))
            {
                realHeaders["X-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XRequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MedicalModelInference",
                Version = "2026-11-16",
                Protocol = "HTTPS",
                Pathname = "/v1/api/directModel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MedicalModelInferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs inference using the external Qwen medical foundation model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalModelInferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// MedicalModelInferenceResponse
        /// </returns>
        public MedicalModelInferenceResponse MedicalModelInference(MedicalModelInferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MedicalModelInferenceHeaders headers = new MedicalModelInferenceHeaders();
            return MedicalModelInferenceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs inference using the external Qwen medical foundation model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalModelInferenceRequest
        /// </param>
        /// 
        /// <returns>
        /// MedicalModelInferenceResponse
        /// </returns>
        public async Task<MedicalModelInferenceResponse> MedicalModelInferenceAsync(MedicalModelInferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            MedicalModelInferenceHeaders headers = new MedicalModelInferenceHeaders();
            return await MedicalModelInferenceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Qwen medical service and returns the current activation status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenServiceRequest
        /// </param>
        /// <param name="headers">
        /// OpenServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenServiceResponse
        /// </returns>
        public OpenServiceResponse OpenServiceWithOptions(OpenServiceRequest request, OpenServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Communication))
            {
                body["communication"] = request.Communication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBenefits))
            {
                body["openBenefits"] = request.OpenBenefits;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWAccess))
            {
                realHeaders["X-GW-Access"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWAccess);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWNonce))
            {
                realHeaders["X-GW-Nonce"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWNonce);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWSignature))
            {
                realHeaders["X-GW-Signature"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWSignature);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWTimestamp))
            {
                realHeaders["X-GW-Timestamp"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWTimestamp);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XRequestId))
            {
                realHeaders["X-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XRequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenService",
                Version = "2026-11-16",
                Protocol = "HTTPS",
                Pathname = "/v1/api/medical/openService",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Qwen medical service and returns the current activation status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenServiceRequest
        /// </param>
        /// <param name="headers">
        /// OpenServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenServiceResponse
        /// </returns>
        public async Task<OpenServiceResponse> OpenServiceWithOptionsAsync(OpenServiceRequest request, OpenServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Communication))
            {
                body["communication"] = request.Communication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBenefits))
            {
                body["openBenefits"] = request.OpenBenefits;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWAccess))
            {
                realHeaders["X-GW-Access"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWAccess);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWNonce))
            {
                realHeaders["X-GW-Nonce"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWNonce);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWSignature))
            {
                realHeaders["X-GW-Signature"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWSignature);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XGWTimestamp))
            {
                realHeaders["X-GW-Timestamp"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XGWTimestamp);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XRequestId))
            {
                realHeaders["X-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XRequestId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenService",
                Version = "2026-11-16",
                Protocol = "HTTPS",
                Pathname = "/v1/api/medical/openService",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Qwen medical service and returns the current activation status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenServiceResponse
        /// </returns>
        public OpenServiceResponse OpenService(OpenServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenServiceHeaders headers = new OpenServiceHeaders();
            return OpenServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Qwen medical service and returns the current activation status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenServiceResponse
        /// </returns>
        public async Task<OpenServiceResponse> OpenServiceAsync(OpenServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenServiceHeaders headers = new OpenServiceHeaders();
            return await OpenServiceWithOptionsAsync(request, headers, runtime);
        }

    }
}
