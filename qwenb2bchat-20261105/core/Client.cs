// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.QwenB2BChat20261105.Models;

namespace AlibabaCloud.SDK.QwenB2BChat20261105
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "QwenB2BChat";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("qwenb2bchat", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Sends text or multimodal messages to initiate conversations with web search capabilities, supporting deep thinking, session history management, and both complete JSON and Server-Sent Events (SSE) streaming responses. Specific agent and media capabilities are subject to the activated scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatRequest
        /// </param>
        /// <param name="headers">
        /// ChatHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatResponse
        /// </returns>
        public ChatResponse ChatWithOptions(ChatRequest request, ChatHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Accept))
            {
                realHeaders["Accept"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Accept);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XDashScopeSSE))
            {
                realHeaders["X-DashScope-SSE"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XDashScopeSSE);
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
                Action = "Chat",
                Version = "2026-11-05",
                Protocol = "HTTPS",
                Pathname = "/v1/api/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends text or multimodal messages to initiate conversations with web search capabilities, supporting deep thinking, session history management, and both complete JSON and Server-Sent Events (SSE) streaming responses. Specific agent and media capabilities are subject to the activated scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatRequest
        /// </param>
        /// <param name="headers">
        /// ChatHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatResponse
        /// </returns>
        public async Task<ChatResponse> ChatWithOptionsAsync(ChatRequest request, ChatHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Accept))
            {
                realHeaders["Accept"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Accept);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XDashScopeSSE))
            {
                realHeaders["X-DashScope-SSE"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XDashScopeSSE);
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
                Action = "Chat",
                Version = "2026-11-05",
                Protocol = "HTTPS",
                Pathname = "/v1/api/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends text or multimodal messages to initiate conversations with web search capabilities, supporting deep thinking, session history management, and both complete JSON and Server-Sent Events (SSE) streaming responses. Specific agent and media capabilities are subject to the activated scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatResponse
        /// </returns>
        public ChatResponse Chat(ChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatHeaders headers = new ChatHeaders();
            return ChatWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends text or multimodal messages to initiate conversations with web search capabilities, supporting deep thinking, session history management, and both complete JSON and Server-Sent Events (SSE) streaming responses. Specific agent and media capabilities are subject to the activated scope.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatResponse
        /// </returns>
        public async Task<ChatResponse> ChatAsync(ChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatHeaders headers = new ChatHeaders();
            return await ChatWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the service activation API or initiates service activation for the current account, and returns the current activation status along with the available order or instance ID.</para>
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
                Version = "2026-11-05",
                Protocol = "HTTPS",
                Pathname = "/v1/api/openService",
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
        /// <para>Validates the service activation API or initiates service activation for the current account, and returns the current activation status along with the available order or instance ID.</para>
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
                Version = "2026-11-05",
                Protocol = "HTTPS",
                Pathname = "/v1/api/openService",
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
        /// <para>Validates the service activation API or initiates service activation for the current account, and returns the current activation status along with the available order or instance ID.</para>
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
        /// <para>Validates the service activation API or initiates service activation for the current account, and returns the current activation status along with the available order or instance ID.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads audio and receives recognized text, agent responses, and synthesized audio over a WebSocket connection. Supports image and text auxiliary input, recognition context, and conversation history. The operation description covers the complete handshake, control frames, audio frames, return events, and error handling protocols.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamVoiceRequest
        /// </param>
        /// <param name="headers">
        /// StreamVoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StreamVoiceResponse
        /// </returns>
        public StreamVoiceResponse StreamVoiceWithOptions(StreamVoiceRequest request, StreamVoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StreamVoice",
                Version = "2026-11-05",
                Protocol = "HTTPS",
                Pathname = "/v1/api/voice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StreamVoiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads audio and receives recognized text, agent responses, and synthesized audio over a WebSocket connection. Supports image and text auxiliary input, recognition context, and conversation history. The operation description covers the complete handshake, control frames, audio frames, return events, and error handling protocols.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamVoiceRequest
        /// </param>
        /// <param name="headers">
        /// StreamVoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StreamVoiceResponse
        /// </returns>
        public async Task<StreamVoiceResponse> StreamVoiceWithOptionsAsync(StreamVoiceRequest request, StreamVoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StreamVoice",
                Version = "2026-11-05",
                Protocol = "HTTPS",
                Pathname = "/v1/api/voice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StreamVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads audio and receives recognized text, agent responses, and synthesized audio over a WebSocket connection. Supports image and text auxiliary input, recognition context, and conversation history. The operation description covers the complete handshake, control frames, audio frames, return events, and error handling protocols.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// StreamVoiceResponse
        /// </returns>
        public StreamVoiceResponse StreamVoice(StreamVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StreamVoiceHeaders headers = new StreamVoiceHeaders();
            return StreamVoiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads audio and receives recognized text, agent responses, and synthesized audio over a WebSocket connection. Supports image and text auxiliary input, recognition context, and conversation history. The operation description covers the complete handshake, control frames, audio frames, return events, and error handling protocols.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// StreamVoiceResponse
        /// </returns>
        public async Task<StreamVoiceResponse> StreamVoiceAsync(StreamVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StreamVoiceHeaders headers = new StreamVoiceHeaders();
            return await StreamVoiceWithOptionsAsync(request, headers, runtime);
        }

    }
}
