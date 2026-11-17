// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MaasQIService20260831.Models;

namespace AlibabaCloud.SDK.MaasQIService20260831
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "MaasQIService";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("maasqiservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Invokes a published Creative Agent, supporting both the lite and dedicated editions, and returns execution progress and image artifacts via Server-Sent Events (SSE). The lite edition performs text-to-image or image-to-image generation based on whether a reference image is provided. The dedicated edition uses a Planner to schedule and execute generation and editing tasks, supporting multi-turn conversations. Parameters such as the generation count and size are passed through metadata.parameters. For image URLs in the results, refer to artifacts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Creative Agent service and prepare the published instance ID and the corresponding instance access key.</description></item>
        /// <item><description>Creative Agent provides the lite and dedicated editions. The lite edition performs generation or editing based on whether a reference image is provided. The dedicated edition uses a Planner to schedule and execute creative tasks.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. The instance access key must be placed in the X-QI-Agent-Api-Key header and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: POST /aigc/v1/chat/completions.</description></item>
        /// <item><description>Specify the instance through X-QI-Instance-Id and execute according to the published configuration of the instance. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>This operation returns incremental events rather than a complete JSON response. Continuously read the stream until it ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first turn. Save the session ID returned by the server from the qi_session_id field in the SSE body and pass the same value back in subsequent turns. Do not rely on the gateway to pass through custom response headers. Use different IDs for different sessions and send requests in sequence for the same session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AigcChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// AigcChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AigcChatCompletionStreamResponse
        /// </returns>
        public AigcChatCompletionStreamResponse AigcChatCompletionStreamWithOptions(AigcChatCompletionStreamRequest request, AigcChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptions))
            {
                body["streamOptions"] = request.StreamOptions;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AigcChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/aigc/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AigcChatCompletionStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Creative Agent, supporting both the lite and dedicated editions, and returns execution progress and image artifacts via Server-Sent Events (SSE). The lite edition performs text-to-image or image-to-image generation based on whether a reference image is provided. The dedicated edition uses a Planner to schedule and execute generation and editing tasks, supporting multi-turn conversations. Parameters such as the generation count and size are passed through metadata.parameters. For image URLs in the results, refer to artifacts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Creative Agent service and prepare the published instance ID and the corresponding instance access key.</description></item>
        /// <item><description>Creative Agent provides the lite and dedicated editions. The lite edition performs generation or editing based on whether a reference image is provided. The dedicated edition uses a Planner to schedule and execute creative tasks.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. The instance access key must be placed in the X-QI-Agent-Api-Key header and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: POST /aigc/v1/chat/completions.</description></item>
        /// <item><description>Specify the instance through X-QI-Instance-Id and execute according to the published configuration of the instance. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>This operation returns incremental events rather than a complete JSON response. Continuously read the stream until it ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first turn. Save the session ID returned by the server from the qi_session_id field in the SSE body and pass the same value back in subsequent turns. Do not rely on the gateway to pass through custom response headers. Use different IDs for different sessions and send requests in sequence for the same session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AigcChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// AigcChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AigcChatCompletionStreamResponse
        /// </returns>
        public async Task<AigcChatCompletionStreamResponse> AigcChatCompletionStreamWithOptionsAsync(AigcChatCompletionStreamRequest request, AigcChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptions))
            {
                body["streamOptions"] = request.StreamOptions;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AigcChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/aigc/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AigcChatCompletionStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Creative Agent, supporting both the lite and dedicated editions, and returns execution progress and image artifacts via Server-Sent Events (SSE). The lite edition performs text-to-image or image-to-image generation based on whether a reference image is provided. The dedicated edition uses a Planner to schedule and execute generation and editing tasks, supporting multi-turn conversations. Parameters such as the generation count and size are passed through metadata.parameters. For image URLs in the results, refer to artifacts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Creative Agent service and prepare the published instance ID and the corresponding instance access key.</description></item>
        /// <item><description>Creative Agent provides the lite and dedicated editions. The lite edition performs generation or editing based on whether a reference image is provided. The dedicated edition uses a Planner to schedule and execute creative tasks.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. The instance access key must be placed in the X-QI-Agent-Api-Key header and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: POST /aigc/v1/chat/completions.</description></item>
        /// <item><description>Specify the instance through X-QI-Instance-Id and execute according to the published configuration of the instance. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>This operation returns incremental events rather than a complete JSON response. Continuously read the stream until it ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first turn. Save the session ID returned by the server from the qi_session_id field in the SSE body and pass the same value back in subsequent turns. Do not rely on the gateway to pass through custom response headers. Use different IDs for different sessions and send requests in sequence for the same session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AigcChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// AigcChatCompletionStreamResponse
        /// </returns>
        public AigcChatCompletionStreamResponse AigcChatCompletionStream(AigcChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AigcChatCompletionStreamHeaders headers = new AigcChatCompletionStreamHeaders();
            return AigcChatCompletionStreamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Creative Agent, supporting both the lite and dedicated editions, and returns execution progress and image artifacts via Server-Sent Events (SSE). The lite edition performs text-to-image or image-to-image generation based on whether a reference image is provided. The dedicated edition uses a Planner to schedule and execute generation and editing tasks, supporting multi-turn conversations. Parameters such as the generation count and size are passed through metadata.parameters. For image URLs in the results, refer to artifacts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Creative Agent service and prepare the published instance ID and the corresponding instance access key.</description></item>
        /// <item><description>Creative Agent provides the lite and dedicated editions. The lite edition performs generation or editing based on whether a reference image is provided. The dedicated edition uses a Planner to schedule and execute creative tasks.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. The instance access key must be placed in the X-QI-Agent-Api-Key header and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: POST /aigc/v1/chat/completions.</description></item>
        /// <item><description>Specify the instance through X-QI-Instance-Id and execute according to the published configuration of the instance. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>This operation returns incremental events rather than a complete JSON response. Continuously read the stream until it ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first turn. Save the session ID returned by the server from the qi_session_id field in the SSE body and pass the same value back in subsequent turns. Do not rely on the gateway to pass through custom response headers. Use different IDs for different sessions and send requests in sequence for the same session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AigcChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// AigcChatCompletionStreamResponse
        /// </returns>
        public async Task<AigcChatCompletionStreamResponse> AigcChatCompletionStreamAsync(AigcChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AigcChatCompletionStreamHeaders headers = new AigcChatCompletionStreamHeaders();
            return await AigcChatCompletionStreamWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls a published Camera Agent to recognize food and beverages and detect new persons in scenes. Food recognition returns the locations and counts of targets. Person detection deduplicates against recorded portraits in the scene and returns at most one new person per call. The recognition capabilities are determined by the published configuration of the instance. Both JSON and Server-Sent Events (SSE) responses are supported. All bounding boxes use the pixel coordinates of the original image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>The Camera Agent service is activated. A published CameraStandard instance ID and the corresponding instance access key are prepared.</description></item>
        /// <item><description>AccessKey authentication is completed by using SDK or OpenAPI signatures. The instance key is provided in the X-QI-Agent-Api-Key header and cannot replace the AccessKey signature.</description></item>
        /// <item><description>The Content-Type header is set to application/json. If stream is set to true, SSE is used and the Accept header is set to text/event-stream. Otherwise, a JSON response is returned.</description></item>
        /// </list>
        /// <h3>Call method</h3>
        /// <para>Send a POST request to /camera/v1/chat/completions. Specify the instance by using the X-QI-Instance-Id header and provide the raw value of the key. Submit one role=user message and one image per call. The recognition scene, model, and thresholds are based on the published configuration of the instance.</para>
        /// <h3>Session management</h3>
        /// <para>You can omit the X-QI-Session-Id header in the first call and make sequential calls within the same session. The scene_id parameter is required for person recognition but must be omitted for food recognition. Session management ensures execution and idempotency, while the scene ID manages person deduplication. The same scene can be reused across sessions, but calls must be sequential. Create a new session when you switch the published version or recognition scene. For person recognition, create a new scene at the same time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CameraChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// CameraChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CameraChatCompletionStreamResponse
        /// </returns>
        public CameraChatCompletionStreamResponse CameraChatCompletionStreamWithOptions(CameraChatCompletionStreamRequest request, CameraChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIRequestId))
            {
                realHeaders["X-QI-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIRequestId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["x-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CameraChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/camera/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<CameraChatCompletionStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls a published Camera Agent to recognize food and beverages and detect new persons in scenes. Food recognition returns the locations and counts of targets. Person detection deduplicates against recorded portraits in the scene and returns at most one new person per call. The recognition capabilities are determined by the published configuration of the instance. Both JSON and Server-Sent Events (SSE) responses are supported. All bounding boxes use the pixel coordinates of the original image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>The Camera Agent service is activated. A published CameraStandard instance ID and the corresponding instance access key are prepared.</description></item>
        /// <item><description>AccessKey authentication is completed by using SDK or OpenAPI signatures. The instance key is provided in the X-QI-Agent-Api-Key header and cannot replace the AccessKey signature.</description></item>
        /// <item><description>The Content-Type header is set to application/json. If stream is set to true, SSE is used and the Accept header is set to text/event-stream. Otherwise, a JSON response is returned.</description></item>
        /// </list>
        /// <h3>Call method</h3>
        /// <para>Send a POST request to /camera/v1/chat/completions. Specify the instance by using the X-QI-Instance-Id header and provide the raw value of the key. Submit one role=user message and one image per call. The recognition scene, model, and thresholds are based on the published configuration of the instance.</para>
        /// <h3>Session management</h3>
        /// <para>You can omit the X-QI-Session-Id header in the first call and make sequential calls within the same session. The scene_id parameter is required for person recognition but must be omitted for food recognition. Session management ensures execution and idempotency, while the scene ID manages person deduplication. The same scene can be reused across sessions, but calls must be sequential. Create a new session when you switch the published version or recognition scene. For person recognition, create a new scene at the same time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CameraChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// CameraChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CameraChatCompletionStreamResponse
        /// </returns>
        public async Task<CameraChatCompletionStreamResponse> CameraChatCompletionStreamWithOptionsAsync(CameraChatCompletionStreamRequest request, CameraChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIRequestId))
            {
                realHeaders["X-QI-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIRequestId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["x-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CameraChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/camera/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<CameraChatCompletionStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls a published Camera Agent to recognize food and beverages and detect new persons in scenes. Food recognition returns the locations and counts of targets. Person detection deduplicates against recorded portraits in the scene and returns at most one new person per call. The recognition capabilities are determined by the published configuration of the instance. Both JSON and Server-Sent Events (SSE) responses are supported. All bounding boxes use the pixel coordinates of the original image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>The Camera Agent service is activated. A published CameraStandard instance ID and the corresponding instance access key are prepared.</description></item>
        /// <item><description>AccessKey authentication is completed by using SDK or OpenAPI signatures. The instance key is provided in the X-QI-Agent-Api-Key header and cannot replace the AccessKey signature.</description></item>
        /// <item><description>The Content-Type header is set to application/json. If stream is set to true, SSE is used and the Accept header is set to text/event-stream. Otherwise, a JSON response is returned.</description></item>
        /// </list>
        /// <h3>Call method</h3>
        /// <para>Send a POST request to /camera/v1/chat/completions. Specify the instance by using the X-QI-Instance-Id header and provide the raw value of the key. Submit one role=user message and one image per call. The recognition scene, model, and thresholds are based on the published configuration of the instance.</para>
        /// <h3>Session management</h3>
        /// <para>You can omit the X-QI-Session-Id header in the first call and make sequential calls within the same session. The scene_id parameter is required for person recognition but must be omitted for food recognition. Session management ensures execution and idempotency, while the scene ID manages person deduplication. The same scene can be reused across sessions, but calls must be sequential. Create a new session when you switch the published version or recognition scene. For person recognition, create a new scene at the same time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CameraChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// CameraChatCompletionStreamResponse
        /// </returns>
        public CameraChatCompletionStreamResponse CameraChatCompletionStream(CameraChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CameraChatCompletionStreamHeaders headers = new CameraChatCompletionStreamHeaders();
            return CameraChatCompletionStreamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls a published Camera Agent to recognize food and beverages and detect new persons in scenes. Food recognition returns the locations and counts of targets. Person detection deduplicates against recorded portraits in the scene and returns at most one new person per call. The recognition capabilities are determined by the published configuration of the instance. Both JSON and Server-Sent Events (SSE) responses are supported. All bounding boxes use the pixel coordinates of the original image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>The Camera Agent service is activated. A published CameraStandard instance ID and the corresponding instance access key are prepared.</description></item>
        /// <item><description>AccessKey authentication is completed by using SDK or OpenAPI signatures. The instance key is provided in the X-QI-Agent-Api-Key header and cannot replace the AccessKey signature.</description></item>
        /// <item><description>The Content-Type header is set to application/json. If stream is set to true, SSE is used and the Accept header is set to text/event-stream. Otherwise, a JSON response is returned.</description></item>
        /// </list>
        /// <h3>Call method</h3>
        /// <para>Send a POST request to /camera/v1/chat/completions. Specify the instance by using the X-QI-Instance-Id header and provide the raw value of the key. Submit one role=user message and one image per call. The recognition scene, model, and thresholds are based on the published configuration of the instance.</para>
        /// <h3>Session management</h3>
        /// <para>You can omit the X-QI-Session-Id header in the first call and make sequential calls within the same session. The scene_id parameter is required for person recognition but must be omitted for food recognition. Session management ensures execution and idempotency, while the scene ID manages person deduplication. The same scene can be reused across sessions, but calls must be sequential. Create a new session when you switch the published version or recognition scene. For person recognition, create a new scene at the same time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CameraChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// CameraChatCompletionStreamResponse
        /// </returns>
        public async Task<CameraChatCompletionStreamResponse> CameraChatCompletionStreamAsync(CameraChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CameraChatCompletionStreamHeaders headers = new CameraChatCompletionStreamHeaders();
            return await CameraChatCompletionStreamWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试 Camera Agent</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>接入前提</h3>
        /// <list type="bullet">
        /// <item><description>已开通 Camera Agent 服务，准备当前租户的 CameraStandard 实例；实例可以未发布。</description></item>
        /// <item><description>使用 SDK/OpenAPI 签名完成 AccessKey 认证，无需 <c>X-QI-Agent-Api-Key</c>。</description></item>
        /// <item><description>设置 <c>Content-Type: application/json</c>。<c>input.stream=true</c> 时使用 SSE，并设置 <c>Accept: text/event-stream</c>；否则返回 JSON。</description></item>
        /// </list>
        /// <h3>调用方式</h3>
        /// <para><c>POST /api/console/camera/agents/debug</c>。实例 ID 放在 <c>instanceId</c> 或 <c>X-QI-Instance-Id</c> Header，非空 Header 优先；图片请求放入 <c>input</c>。省略 <c>config</c> 使用实例草稿，临时配置仅对本次调用生效，不保存或发布实例。</para>
        /// <h3>会话管理</h3>
        /// <para>首轮可省略 <c>sessionId</c>，非空 <c>X-QI-Session-Id</c> Header 优先。同一会话顺序调用；人物识别省略整个 <c>input.scene_id</c> 字段时，由 Session 派生场景。需要连续去重时复用 Session 或显式指定同一场景，切换有效配置时换新 Session 和场景。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CameraConsoleDebugStreamRequest
        /// </param>
        /// <param name="headers">
        /// CameraConsoleDebugStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CameraConsoleDebugStreamResponse
        /// </returns>
        public CameraConsoleDebugStreamResponse CameraConsoleDebugStreamWithOptions(CameraConsoleDebugStreamRequest request, CameraConsoleDebugStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIRequestId))
            {
                realHeaders["X-QI-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIRequestId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CameraConsoleDebugStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/api/console/camera/agents/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<CameraConsoleDebugStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试 Camera Agent</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>接入前提</h3>
        /// <list type="bullet">
        /// <item><description>已开通 Camera Agent 服务，准备当前租户的 CameraStandard 实例；实例可以未发布。</description></item>
        /// <item><description>使用 SDK/OpenAPI 签名完成 AccessKey 认证，无需 <c>X-QI-Agent-Api-Key</c>。</description></item>
        /// <item><description>设置 <c>Content-Type: application/json</c>。<c>input.stream=true</c> 时使用 SSE，并设置 <c>Accept: text/event-stream</c>；否则返回 JSON。</description></item>
        /// </list>
        /// <h3>调用方式</h3>
        /// <para><c>POST /api/console/camera/agents/debug</c>。实例 ID 放在 <c>instanceId</c> 或 <c>X-QI-Instance-Id</c> Header，非空 Header 优先；图片请求放入 <c>input</c>。省略 <c>config</c> 使用实例草稿，临时配置仅对本次调用生效，不保存或发布实例。</para>
        /// <h3>会话管理</h3>
        /// <para>首轮可省略 <c>sessionId</c>，非空 <c>X-QI-Session-Id</c> Header 优先。同一会话顺序调用；人物识别省略整个 <c>input.scene_id</c> 字段时，由 Session 派生场景。需要连续去重时复用 Session 或显式指定同一场景，切换有效配置时换新 Session 和场景。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CameraConsoleDebugStreamRequest
        /// </param>
        /// <param name="headers">
        /// CameraConsoleDebugStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CameraConsoleDebugStreamResponse
        /// </returns>
        public async Task<CameraConsoleDebugStreamResponse> CameraConsoleDebugStreamWithOptionsAsync(CameraConsoleDebugStreamRequest request, CameraConsoleDebugStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIRequestId))
            {
                realHeaders["X-QI-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIRequestId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CameraConsoleDebugStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/api/console/camera/agents/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<CameraConsoleDebugStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试 Camera Agent</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>接入前提</h3>
        /// <list type="bullet">
        /// <item><description>已开通 Camera Agent 服务，准备当前租户的 CameraStandard 实例；实例可以未发布。</description></item>
        /// <item><description>使用 SDK/OpenAPI 签名完成 AccessKey 认证，无需 <c>X-QI-Agent-Api-Key</c>。</description></item>
        /// <item><description>设置 <c>Content-Type: application/json</c>。<c>input.stream=true</c> 时使用 SSE，并设置 <c>Accept: text/event-stream</c>；否则返回 JSON。</description></item>
        /// </list>
        /// <h3>调用方式</h3>
        /// <para><c>POST /api/console/camera/agents/debug</c>。实例 ID 放在 <c>instanceId</c> 或 <c>X-QI-Instance-Id</c> Header，非空 Header 优先；图片请求放入 <c>input</c>。省略 <c>config</c> 使用实例草稿，临时配置仅对本次调用生效，不保存或发布实例。</para>
        /// <h3>会话管理</h3>
        /// <para>首轮可省略 <c>sessionId</c>，非空 <c>X-QI-Session-Id</c> Header 优先。同一会话顺序调用；人物识别省略整个 <c>input.scene_id</c> 字段时，由 Session 派生场景。需要连续去重时复用 Session 或显式指定同一场景，切换有效配置时换新 Session 和场景。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CameraConsoleDebugStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// CameraConsoleDebugStreamResponse
        /// </returns>
        public CameraConsoleDebugStreamResponse CameraConsoleDebugStream(CameraConsoleDebugStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CameraConsoleDebugStreamHeaders headers = new CameraConsoleDebugStreamHeaders();
            return CameraConsoleDebugStreamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试 Camera Agent</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>接入前提</h3>
        /// <list type="bullet">
        /// <item><description>已开通 Camera Agent 服务，准备当前租户的 CameraStandard 实例；实例可以未发布。</description></item>
        /// <item><description>使用 SDK/OpenAPI 签名完成 AccessKey 认证，无需 <c>X-QI-Agent-Api-Key</c>。</description></item>
        /// <item><description>设置 <c>Content-Type: application/json</c>。<c>input.stream=true</c> 时使用 SSE，并设置 <c>Accept: text/event-stream</c>；否则返回 JSON。</description></item>
        /// </list>
        /// <h3>调用方式</h3>
        /// <para><c>POST /api/console/camera/agents/debug</c>。实例 ID 放在 <c>instanceId</c> 或 <c>X-QI-Instance-Id</c> Header，非空 Header 优先；图片请求放入 <c>input</c>。省略 <c>config</c> 使用实例草稿，临时配置仅对本次调用生效，不保存或发布实例。</para>
        /// <h3>会话管理</h3>
        /// <para>首轮可省略 <c>sessionId</c>，非空 <c>X-QI-Session-Id</c> Header 优先。同一会话顺序调用；人物识别省略整个 <c>input.scene_id</c> 字段时，由 Session 派生场景。需要连续去重时复用 Session 或显式指定同一场景，切换有效配置时换新 Session 和场景。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CameraConsoleDebugStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// CameraConsoleDebugStreamResponse
        /// </returns>
        public async Task<CameraConsoleDebugStreamResponse> CameraConsoleDebugStreamAsync(CameraConsoleDebugStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CameraConsoleDebugStreamHeaders headers = new CameraConsoleDebugStreamHeaders();
            return await CameraConsoleDebugStreamWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Computer Use Agent (CUA) Standard Edition instance, submits a task and the current desktop screenshot, and returns single-step computer operation decisions through Server-Sent Events (SSE). After the client executes the computer_use action, it returns the actual results and continues the call with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic retains the section names and order of the previous version. For version differences, see Release notes. This topic is compiled based on the official API reference of the previous version, subsequent call instructions from the service provider, and pre-release call observations. It does not indicate that a full audit of the new version of the service source code or the official gateway has been completed. No new API version number is provided.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Install the official SDK applicable to the target endpoint from the SDK center.</description></item>
        /// <item><description>Activate the CUA Agent service and prepare the published CUA instance ID and its access key.</description></item>
        /// <item><description>CUA is only available in Standard Edition.</description></item>
        /// <item><description>The official POP/OpenAPI endpoint uses the Alibaba Cloud SDK or OpenAPI signature to complete AccessKey authentication. The instance access key is separately placed in <c>X-QI-Agent-Api-Key</c> and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set <c>Content-Type: application/json</c> and <c>Accept: text/event-stream</c>. The <c>stream</c> parameter must be set to <c>true</c>.</description></item>
        /// <item><description>Use the target endpoint confirmed by the service provider. The authentication behavior of the pre-release direct business endpoint cannot be extrapolated to mean that the official endpoint does not require an AK signature.</description></item>
        /// <item><description>The client must have the capabilities of taking screenshots, fully parsing SSE, executing actions, and returning actual results. Code and commands must be executed in a controlled and authorized environment. Manual confirmation should be added for sensitive operations.</description></item>
        /// </list>
        /// <h2>Call methods</h2>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /cua/v1/chat/completions</c>.</description></item>
        /// <item><description><c>X-QI-Instance-Id</c> specifies the instance and is executed according to the published CUA Standard Edition configuration. The <c>model</c> parameter in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE events, not a complete JSON object. Continue reading until the end and check for errors within the stream.</description></item>
        /// <item><description>CUA returns the complete action after the single-step model decision is completed, rather than outputting token by token. Heartbeats are used to maintain the connection during the waiting phase.</description></item>
        /// <item><description>The mode is selected through <c>metadata.actionMode</c> in the request body: <c>gui-only</c> or <c>gui+cli</c>. This is a field supplemented by subsequent service instructions, not a model name or request header.</description></item>
        /// <item><description>Do not use <c>stream:false</c> to replace this API operation. Non-streaming mode may result in no response bytes for a long time before the model finishes, which increases the risk of intermediate link timeouts.</description></item>
        /// </list>
        /// <h2>Session management</h2>
        /// <para>In the first round, you can omit or leave <c>X-QI-Session-Id</c> empty, save <c>qi_session_id</c> from the SSE body, and reuse it through the request header with the same name in subsequent rounds. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.
        /// <c>X-QI-Request-Id</c> can be generated by the server. We recommend that the client explicitly generate it to facilitate recovery and troubleshooting:</para>
        /// <list type="bullet">
        /// <item><description>New step: new request ID.</description></item>
        /// <item><description>Retry the same step: same session, same request ID, and same request body.</description></item>
        /// <item><description>Calls within the same session must be strictly sequential. Do not send different steps in parallel. Use different sessions for different tasks.</description></item>
        /// <item><description>Explicitly select <c>actionMode</c> in the first round and keep it consistent in subsequent rounds. If you need to change the mode, create a new session. You cannot switch modes within the same session.</description></item>
        /// <item><description>If the stream is disconnected before <c>qi_session_id</c> is obtained in the first round, the recovery method must be handled according to the rules confirmed by the service provider. You cannot assume that the request ID can be deduplicated across unknown sessions.</description></item>
        /// <item><description>Save the session/request ID immediately when the identity event is obtained, but do not treat the identity event as a complete return of the action.</description></item>
        /// <item><description>Stop continuing after receiving <c>finished</c>. The current documentation does not provide an independent session release API operation. Do not construct additional release requests on your own.</description></item>
        /// </list>
        /// <h2>Rate limit</h2>
        /// <para>The current API request rate for the cloud service is not exposed. Do not treat the client concurrency configuration as the concurrency or QPS commitment allowed by the service. You should confirm the capacity, queuing, and quotas with the service provider.
        /// Limits provided in subsequent service instructions:</para>
        /// <list type="bullet">
        /// <item><description>The current request body limit is <b>8 MB</b>, including the fully serialized JSON, not just images.</description></item>
        /// <item><description>Exactly one current screenshot is required for each step. Do not pass multiple images or screenshot history.</description></item>
        /// <item><description>A keepalive message is sent approximately every <b>15 seconds</b> during the waiting period. This interval is not a response latency SLA, and you cannot rely on heartbeats when an HTTP/SSE response has not been established.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CuaChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// CuaChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CuaChatCompletionStreamResponse
        /// </returns>
        public CuaChatCompletionStreamResponse CuaChatCompletionStreamWithOptions(CuaChatCompletionStreamRequest request, CuaChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptions))
            {
                body["streamOptions"] = request.StreamOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIRequestId))
            {
                realHeaders["X-QI-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIRequestId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CuaChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/cua/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CuaChatCompletionStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Computer Use Agent (CUA) Standard Edition instance, submits a task and the current desktop screenshot, and returns single-step computer operation decisions through Server-Sent Events (SSE). After the client executes the computer_use action, it returns the actual results and continues the call with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic retains the section names and order of the previous version. For version differences, see Release notes. This topic is compiled based on the official API reference of the previous version, subsequent call instructions from the service provider, and pre-release call observations. It does not indicate that a full audit of the new version of the service source code or the official gateway has been completed. No new API version number is provided.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Install the official SDK applicable to the target endpoint from the SDK center.</description></item>
        /// <item><description>Activate the CUA Agent service and prepare the published CUA instance ID and its access key.</description></item>
        /// <item><description>CUA is only available in Standard Edition.</description></item>
        /// <item><description>The official POP/OpenAPI endpoint uses the Alibaba Cloud SDK or OpenAPI signature to complete AccessKey authentication. The instance access key is separately placed in <c>X-QI-Agent-Api-Key</c> and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set <c>Content-Type: application/json</c> and <c>Accept: text/event-stream</c>. The <c>stream</c> parameter must be set to <c>true</c>.</description></item>
        /// <item><description>Use the target endpoint confirmed by the service provider. The authentication behavior of the pre-release direct business endpoint cannot be extrapolated to mean that the official endpoint does not require an AK signature.</description></item>
        /// <item><description>The client must have the capabilities of taking screenshots, fully parsing SSE, executing actions, and returning actual results. Code and commands must be executed in a controlled and authorized environment. Manual confirmation should be added for sensitive operations.</description></item>
        /// </list>
        /// <h2>Call methods</h2>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /cua/v1/chat/completions</c>.</description></item>
        /// <item><description><c>X-QI-Instance-Id</c> specifies the instance and is executed according to the published CUA Standard Edition configuration. The <c>model</c> parameter in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE events, not a complete JSON object. Continue reading until the end and check for errors within the stream.</description></item>
        /// <item><description>CUA returns the complete action after the single-step model decision is completed, rather than outputting token by token. Heartbeats are used to maintain the connection during the waiting phase.</description></item>
        /// <item><description>The mode is selected through <c>metadata.actionMode</c> in the request body: <c>gui-only</c> or <c>gui+cli</c>. This is a field supplemented by subsequent service instructions, not a model name or request header.</description></item>
        /// <item><description>Do not use <c>stream:false</c> to replace this API operation. Non-streaming mode may result in no response bytes for a long time before the model finishes, which increases the risk of intermediate link timeouts.</description></item>
        /// </list>
        /// <h2>Session management</h2>
        /// <para>In the first round, you can omit or leave <c>X-QI-Session-Id</c> empty, save <c>qi_session_id</c> from the SSE body, and reuse it through the request header with the same name in subsequent rounds. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.
        /// <c>X-QI-Request-Id</c> can be generated by the server. We recommend that the client explicitly generate it to facilitate recovery and troubleshooting:</para>
        /// <list type="bullet">
        /// <item><description>New step: new request ID.</description></item>
        /// <item><description>Retry the same step: same session, same request ID, and same request body.</description></item>
        /// <item><description>Calls within the same session must be strictly sequential. Do not send different steps in parallel. Use different sessions for different tasks.</description></item>
        /// <item><description>Explicitly select <c>actionMode</c> in the first round and keep it consistent in subsequent rounds. If you need to change the mode, create a new session. You cannot switch modes within the same session.</description></item>
        /// <item><description>If the stream is disconnected before <c>qi_session_id</c> is obtained in the first round, the recovery method must be handled according to the rules confirmed by the service provider. You cannot assume that the request ID can be deduplicated across unknown sessions.</description></item>
        /// <item><description>Save the session/request ID immediately when the identity event is obtained, but do not treat the identity event as a complete return of the action.</description></item>
        /// <item><description>Stop continuing after receiving <c>finished</c>. The current documentation does not provide an independent session release API operation. Do not construct additional release requests on your own.</description></item>
        /// </list>
        /// <h2>Rate limit</h2>
        /// <para>The current API request rate for the cloud service is not exposed. Do not treat the client concurrency configuration as the concurrency or QPS commitment allowed by the service. You should confirm the capacity, queuing, and quotas with the service provider.
        /// Limits provided in subsequent service instructions:</para>
        /// <list type="bullet">
        /// <item><description>The current request body limit is <b>8 MB</b>, including the fully serialized JSON, not just images.</description></item>
        /// <item><description>Exactly one current screenshot is required for each step. Do not pass multiple images or screenshot history.</description></item>
        /// <item><description>A keepalive message is sent approximately every <b>15 seconds</b> during the waiting period. This interval is not a response latency SLA, and you cannot rely on heartbeats when an HTTP/SSE response has not been established.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CuaChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// CuaChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CuaChatCompletionStreamResponse
        /// </returns>
        public async Task<CuaChatCompletionStreamResponse> CuaChatCompletionStreamWithOptionsAsync(CuaChatCompletionStreamRequest request, CuaChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptions))
            {
                body["streamOptions"] = request.StreamOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIRequestId))
            {
                realHeaders["X-QI-Request-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIRequestId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CuaChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/cua/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CuaChatCompletionStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Computer Use Agent (CUA) Standard Edition instance, submits a task and the current desktop screenshot, and returns single-step computer operation decisions through Server-Sent Events (SSE). After the client executes the computer_use action, it returns the actual results and continues the call with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic retains the section names and order of the previous version. For version differences, see Release notes. This topic is compiled based on the official API reference of the previous version, subsequent call instructions from the service provider, and pre-release call observations. It does not indicate that a full audit of the new version of the service source code or the official gateway has been completed. No new API version number is provided.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Install the official SDK applicable to the target endpoint from the SDK center.</description></item>
        /// <item><description>Activate the CUA Agent service and prepare the published CUA instance ID and its access key.</description></item>
        /// <item><description>CUA is only available in Standard Edition.</description></item>
        /// <item><description>The official POP/OpenAPI endpoint uses the Alibaba Cloud SDK or OpenAPI signature to complete AccessKey authentication. The instance access key is separately placed in <c>X-QI-Agent-Api-Key</c> and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set <c>Content-Type: application/json</c> and <c>Accept: text/event-stream</c>. The <c>stream</c> parameter must be set to <c>true</c>.</description></item>
        /// <item><description>Use the target endpoint confirmed by the service provider. The authentication behavior of the pre-release direct business endpoint cannot be extrapolated to mean that the official endpoint does not require an AK signature.</description></item>
        /// <item><description>The client must have the capabilities of taking screenshots, fully parsing SSE, executing actions, and returning actual results. Code and commands must be executed in a controlled and authorized environment. Manual confirmation should be added for sensitive operations.</description></item>
        /// </list>
        /// <h2>Call methods</h2>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /cua/v1/chat/completions</c>.</description></item>
        /// <item><description><c>X-QI-Instance-Id</c> specifies the instance and is executed according to the published CUA Standard Edition configuration. The <c>model</c> parameter in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE events, not a complete JSON object. Continue reading until the end and check for errors within the stream.</description></item>
        /// <item><description>CUA returns the complete action after the single-step model decision is completed, rather than outputting token by token. Heartbeats are used to maintain the connection during the waiting phase.</description></item>
        /// <item><description>The mode is selected through <c>metadata.actionMode</c> in the request body: <c>gui-only</c> or <c>gui+cli</c>. This is a field supplemented by subsequent service instructions, not a model name or request header.</description></item>
        /// <item><description>Do not use <c>stream:false</c> to replace this API operation. Non-streaming mode may result in no response bytes for a long time before the model finishes, which increases the risk of intermediate link timeouts.</description></item>
        /// </list>
        /// <h2>Session management</h2>
        /// <para>In the first round, you can omit or leave <c>X-QI-Session-Id</c> empty, save <c>qi_session_id</c> from the SSE body, and reuse it through the request header with the same name in subsequent rounds. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.
        /// <c>X-QI-Request-Id</c> can be generated by the server. We recommend that the client explicitly generate it to facilitate recovery and troubleshooting:</para>
        /// <list type="bullet">
        /// <item><description>New step: new request ID.</description></item>
        /// <item><description>Retry the same step: same session, same request ID, and same request body.</description></item>
        /// <item><description>Calls within the same session must be strictly sequential. Do not send different steps in parallel. Use different sessions for different tasks.</description></item>
        /// <item><description>Explicitly select <c>actionMode</c> in the first round and keep it consistent in subsequent rounds. If you need to change the mode, create a new session. You cannot switch modes within the same session.</description></item>
        /// <item><description>If the stream is disconnected before <c>qi_session_id</c> is obtained in the first round, the recovery method must be handled according to the rules confirmed by the service provider. You cannot assume that the request ID can be deduplicated across unknown sessions.</description></item>
        /// <item><description>Save the session/request ID immediately when the identity event is obtained, but do not treat the identity event as a complete return of the action.</description></item>
        /// <item><description>Stop continuing after receiving <c>finished</c>. The current documentation does not provide an independent session release API operation. Do not construct additional release requests on your own.</description></item>
        /// </list>
        /// <h2>Rate limit</h2>
        /// <para>The current API request rate for the cloud service is not exposed. Do not treat the client concurrency configuration as the concurrency or QPS commitment allowed by the service. You should confirm the capacity, queuing, and quotas with the service provider.
        /// Limits provided in subsequent service instructions:</para>
        /// <list type="bullet">
        /// <item><description>The current request body limit is <b>8 MB</b>, including the fully serialized JSON, not just images.</description></item>
        /// <item><description>Exactly one current screenshot is required for each step. Do not pass multiple images or screenshot history.</description></item>
        /// <item><description>A keepalive message is sent approximately every <b>15 seconds</b> during the waiting period. This interval is not a response latency SLA, and you cannot rely on heartbeats when an HTTP/SSE response has not been established.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CuaChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// CuaChatCompletionStreamResponse
        /// </returns>
        public CuaChatCompletionStreamResponse CuaChatCompletionStream(CuaChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CuaChatCompletionStreamHeaders headers = new CuaChatCompletionStreamHeaders();
            return CuaChatCompletionStreamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Computer Use Agent (CUA) Standard Edition instance, submits a task and the current desktop screenshot, and returns single-step computer operation decisions through Server-Sent Events (SSE). After the client executes the computer_use action, it returns the actual results and continues the call with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic retains the section names and order of the previous version. For version differences, see Release notes. This topic is compiled based on the official API reference of the previous version, subsequent call instructions from the service provider, and pre-release call observations. It does not indicate that a full audit of the new version of the service source code or the official gateway has been completed. No new API version number is provided.</para>
        /// <h2>Before you begin</h2>
        /// <list type="bullet">
        /// <item><description>Install the official SDK applicable to the target endpoint from the SDK center.</description></item>
        /// <item><description>Activate the CUA Agent service and prepare the published CUA instance ID and its access key.</description></item>
        /// <item><description>CUA is only available in Standard Edition.</description></item>
        /// <item><description>The official POP/OpenAPI endpoint uses the Alibaba Cloud SDK or OpenAPI signature to complete AccessKey authentication. The instance access key is separately placed in <c>X-QI-Agent-Api-Key</c> and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set <c>Content-Type: application/json</c> and <c>Accept: text/event-stream</c>. The <c>stream</c> parameter must be set to <c>true</c>.</description></item>
        /// <item><description>Use the target endpoint confirmed by the service provider. The authentication behavior of the pre-release direct business endpoint cannot be extrapolated to mean that the official endpoint does not require an AK signature.</description></item>
        /// <item><description>The client must have the capabilities of taking screenshots, fully parsing SSE, executing actions, and returning actual results. Code and commands must be executed in a controlled and authorized environment. Manual confirmation should be added for sensitive operations.</description></item>
        /// </list>
        /// <h2>Call methods</h2>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /cua/v1/chat/completions</c>.</description></item>
        /// <item><description><c>X-QI-Instance-Id</c> specifies the instance and is executed according to the published CUA Standard Edition configuration. The <c>model</c> parameter in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE events, not a complete JSON object. Continue reading until the end and check for errors within the stream.</description></item>
        /// <item><description>CUA returns the complete action after the single-step model decision is completed, rather than outputting token by token. Heartbeats are used to maintain the connection during the waiting phase.</description></item>
        /// <item><description>The mode is selected through <c>metadata.actionMode</c> in the request body: <c>gui-only</c> or <c>gui+cli</c>. This is a field supplemented by subsequent service instructions, not a model name or request header.</description></item>
        /// <item><description>Do not use <c>stream:false</c> to replace this API operation. Non-streaming mode may result in no response bytes for a long time before the model finishes, which increases the risk of intermediate link timeouts.</description></item>
        /// </list>
        /// <h2>Session management</h2>
        /// <para>In the first round, you can omit or leave <c>X-QI-Session-Id</c> empty, save <c>qi_session_id</c> from the SSE body, and reuse it through the request header with the same name in subsequent rounds. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.
        /// <c>X-QI-Request-Id</c> can be generated by the server. We recommend that the client explicitly generate it to facilitate recovery and troubleshooting:</para>
        /// <list type="bullet">
        /// <item><description>New step: new request ID.</description></item>
        /// <item><description>Retry the same step: same session, same request ID, and same request body.</description></item>
        /// <item><description>Calls within the same session must be strictly sequential. Do not send different steps in parallel. Use different sessions for different tasks.</description></item>
        /// <item><description>Explicitly select <c>actionMode</c> in the first round and keep it consistent in subsequent rounds. If you need to change the mode, create a new session. You cannot switch modes within the same session.</description></item>
        /// <item><description>If the stream is disconnected before <c>qi_session_id</c> is obtained in the first round, the recovery method must be handled according to the rules confirmed by the service provider. You cannot assume that the request ID can be deduplicated across unknown sessions.</description></item>
        /// <item><description>Save the session/request ID immediately when the identity event is obtained, but do not treat the identity event as a complete return of the action.</description></item>
        /// <item><description>Stop continuing after receiving <c>finished</c>. The current documentation does not provide an independent session release API operation. Do not construct additional release requests on your own.</description></item>
        /// </list>
        /// <h2>Rate limit</h2>
        /// <para>The current API request rate for the cloud service is not exposed. Do not treat the client concurrency configuration as the concurrency or QPS commitment allowed by the service. You should confirm the capacity, queuing, and quotas with the service provider.
        /// Limits provided in subsequent service instructions:</para>
        /// <list type="bullet">
        /// <item><description>The current request body limit is <b>8 MB</b>, including the fully serialized JSON, not just images.</description></item>
        /// <item><description>Exactly one current screenshot is required for each step. Do not pass multiple images or screenshot history.</description></item>
        /// <item><description>A keepalive message is sent approximately every <b>15 seconds</b> during the waiting period. This interval is not a response latency SLA, and you cannot rely on heartbeats when an HTTP/SSE response has not been established.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CuaChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// CuaChatCompletionStreamResponse
        /// </returns>
        public async Task<CuaChatCompletionStreamResponse> CuaChatCompletionStreamAsync(CuaChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CuaChatCompletionStreamHeaders headers = new CuaChatCompletionStreamHeaders();
            return await CuaChatCompletionStreamWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls a published Mobile-Use Agent, which supports both the standard and exclusive editions. Submits the task text and the current screen screenshot, passes the device and application context through metadata, and returns the next mobile UI operation via Server-Sent Events (SSE). The UI operation is executed by the caller. After execution, subsequent calls are made with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile-Use Agent service and prepare the published Mobile-Use Agent instance ID and its access key.</description></item>
        /// <item><description>Mobile-Use Agent provides the standard and exclusive editions. Call the API based on the edition of the selected instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /gui/v1/chat/completions</c>.</description></item>
        /// <item><description>X-QI-Instance-Id specifies the instance and executes based on the published configuration. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events, not a complete JSON object. Continuously read until the stream ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first round. Save the qi_session_id from the SSE body and pass it in the request header with the same name for subsequent calls. Make sequential calls within the same session and use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GuiChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// GuiChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GuiChatCompletionStreamResponse
        /// </returns>
        public GuiChatCompletionStreamResponse GuiChatCompletionStreamWithOptions(GuiChatCompletionStreamRequest request, GuiChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedTokenIds))
            {
                body["allowedTokenIds"] = request.AllowedTokenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BadWords))
            {
                body["badWords"] = request.BadWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatTemplateKwargs))
            {
                body["chatTemplateKwargs"] = request.ChatTemplateKwargs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrequencyPenalty))
            {
                body["frequencyPenalty"] = request.FrequencyPenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreEos))
            {
                body["ignoreEos"] = request.IgnoreEos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeReasoning))
            {
                body["includeReasoning"] = request.IncludeReasoning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logprobs))
            {
                body["logprobs"] = request.Logprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCompletionTokens))
            {
                body["maxCompletionTokens"] = request.MaxCompletionTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTokens))
            {
                body["maxTokens"] = request.MaxTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinP))
            {
                body["minP"] = request.MinP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTokens))
            {
                body["minTokens"] = request.MinTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MmProcessorKwargs))
            {
                body["mmProcessorKwargs"] = request.MmProcessorKwargs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                body["n"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParallelToolCalls))
            {
                body["parallelToolCalls"] = request.ParallelToolCalls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PresencePenalty))
            {
                body["presencePenalty"] = request.PresencePenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptLogprobs))
            {
                body["promptLogprobs"] = request.PromptLogprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasoningEffort))
            {
                body["reasoningEffort"] = request.ReasoningEffort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepetitionPenalty))
            {
                body["repetitionPenalty"] = request.RepetitionPenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormat))
            {
                body["responseFormat"] = request.ResponseFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipSpecialTokens))
            {
                body["skipSpecialTokens"] = request.SkipSpecialTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stop))
            {
                body["stop"] = request.Stop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTokenIds))
            {
                body["stopTokenIds"] = request.StopTokenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptions))
            {
                body["streamOptions"] = request.StreamOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructuredOutputs))
            {
                body["structuredOutputs"] = request.StructuredOutputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Temperature))
            {
                body["temperature"] = request.Temperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLogprobs))
            {
                body["topLogprobs"] = request.TopLogprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopP))
            {
                body["topP"] = request.TopP;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GuiChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/gui/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GuiChatCompletionStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls a published Mobile-Use Agent, which supports both the standard and exclusive editions. Submits the task text and the current screen screenshot, passes the device and application context through metadata, and returns the next mobile UI operation via Server-Sent Events (SSE). The UI operation is executed by the caller. After execution, subsequent calls are made with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile-Use Agent service and prepare the published Mobile-Use Agent instance ID and its access key.</description></item>
        /// <item><description>Mobile-Use Agent provides the standard and exclusive editions. Call the API based on the edition of the selected instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /gui/v1/chat/completions</c>.</description></item>
        /// <item><description>X-QI-Instance-Id specifies the instance and executes based on the published configuration. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events, not a complete JSON object. Continuously read until the stream ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first round. Save the qi_session_id from the SSE body and pass it in the request header with the same name for subsequent calls. Make sequential calls within the same session and use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GuiChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// GuiChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GuiChatCompletionStreamResponse
        /// </returns>
        public async Task<GuiChatCompletionStreamResponse> GuiChatCompletionStreamWithOptionsAsync(GuiChatCompletionStreamRequest request, GuiChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedTokenIds))
            {
                body["allowedTokenIds"] = request.AllowedTokenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BadWords))
            {
                body["badWords"] = request.BadWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatTemplateKwargs))
            {
                body["chatTemplateKwargs"] = request.ChatTemplateKwargs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrequencyPenalty))
            {
                body["frequencyPenalty"] = request.FrequencyPenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreEos))
            {
                body["ignoreEos"] = request.IgnoreEos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeReasoning))
            {
                body["includeReasoning"] = request.IncludeReasoning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logprobs))
            {
                body["logprobs"] = request.Logprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCompletionTokens))
            {
                body["maxCompletionTokens"] = request.MaxCompletionTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTokens))
            {
                body["maxTokens"] = request.MaxTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinP))
            {
                body["minP"] = request.MinP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTokens))
            {
                body["minTokens"] = request.MinTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MmProcessorKwargs))
            {
                body["mmProcessorKwargs"] = request.MmProcessorKwargs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                body["n"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParallelToolCalls))
            {
                body["parallelToolCalls"] = request.ParallelToolCalls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PresencePenalty))
            {
                body["presencePenalty"] = request.PresencePenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptLogprobs))
            {
                body["promptLogprobs"] = request.PromptLogprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasoningEffort))
            {
                body["reasoningEffort"] = request.ReasoningEffort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepetitionPenalty))
            {
                body["repetitionPenalty"] = request.RepetitionPenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormat))
            {
                body["responseFormat"] = request.ResponseFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipSpecialTokens))
            {
                body["skipSpecialTokens"] = request.SkipSpecialTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stop))
            {
                body["stop"] = request.Stop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTokenIds))
            {
                body["stopTokenIds"] = request.StopTokenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptions))
            {
                body["streamOptions"] = request.StreamOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructuredOutputs))
            {
                body["structuredOutputs"] = request.StructuredOutputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Temperature))
            {
                body["temperature"] = request.Temperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLogprobs))
            {
                body["topLogprobs"] = request.TopLogprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopP))
            {
                body["topP"] = request.TopP;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GuiChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/gui/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GuiChatCompletionStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls a published Mobile-Use Agent, which supports both the standard and exclusive editions. Submits the task text and the current screen screenshot, passes the device and application context through metadata, and returns the next mobile UI operation via Server-Sent Events (SSE). The UI operation is executed by the caller. After execution, subsequent calls are made with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile-Use Agent service and prepare the published Mobile-Use Agent instance ID and its access key.</description></item>
        /// <item><description>Mobile-Use Agent provides the standard and exclusive editions. Call the API based on the edition of the selected instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /gui/v1/chat/completions</c>.</description></item>
        /// <item><description>X-QI-Instance-Id specifies the instance and executes based on the published configuration. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events, not a complete JSON object. Continuously read until the stream ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first round. Save the qi_session_id from the SSE body and pass it in the request header with the same name for subsequent calls. Make sequential calls within the same session and use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GuiChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// GuiChatCompletionStreamResponse
        /// </returns>
        public GuiChatCompletionStreamResponse GuiChatCompletionStream(GuiChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GuiChatCompletionStreamHeaders headers = new GuiChatCompletionStreamHeaders();
            return GuiChatCompletionStreamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls a published Mobile-Use Agent, which supports both the standard and exclusive editions. Submits the task text and the current screen screenshot, passes the device and application context through metadata, and returns the next mobile UI operation via Server-Sent Events (SSE). The UI operation is executed by the caller. After execution, subsequent calls are made with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile-Use Agent service and prepare the published Mobile-Use Agent instance ID and its access key.</description></item>
        /// <item><description>Mobile-Use Agent provides the standard and exclusive editions. Call the API based on the edition of the selected instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /gui/v1/chat/completions</c>.</description></item>
        /// <item><description>X-QI-Instance-Id specifies the instance and executes based on the published configuration. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events, not a complete JSON object. Continuously read until the stream ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first round. Save the qi_session_id from the SSE body and pass it in the request header with the same name for subsequent calls. Make sequential calls within the same session and use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GuiChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// GuiChatCompletionStreamResponse
        /// </returns>
        public async Task<GuiChatCompletionStreamResponse> GuiChatCompletionStreamAsync(GuiChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GuiChatCompletionStreamHeaders headers = new GuiChatCompletionStreamHeaders();
            return await GuiChatCompletionStreamWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Mobile Planner Agent to initiate a conversation or node planning by using OpenAI-compatible Chat Completions messages, and returns text, model-provided thinking content, and structured tool invocations over Server-Sent Events (SSE). Supports multi-turn sessions and image inputs supported by the model. Business tools are executed by the invoker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile Planner Agent service and prepare the ID and access key of a published Mobile Planner Agent instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /pa/v1/chat/completions</c>.</description></item>
        /// <item><description>Use X-QI-Instance-Id to specify the instance and execute it based on the published configuration. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events rather than a complete JSON object. Continuously read the stream until it ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first turn and save the qi_session_id from the SSE body. Pass it back in the request header with the same name in subsequent turns to continue the session. Make sequential calls within the same session and use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PaChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// PaChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PaChatCompletionStreamResponse
        /// </returns>
        public PaChatCompletionStreamResponse PaChatCompletionStreamWithOptions(PaChatCompletionStreamRequest request, PaChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedTokenIds))
            {
                body["allowedTokenIds"] = request.AllowedTokenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BadWords))
            {
                body["badWords"] = request.BadWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatTemplateKwargs))
            {
                body["chatTemplateKwargs"] = request.ChatTemplateKwargs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrequencyPenalty))
            {
                body["frequencyPenalty"] = request.FrequencyPenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreEos))
            {
                body["ignoreEos"] = request.IgnoreEos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeReasoning))
            {
                body["includeReasoning"] = request.IncludeReasoning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logprobs))
            {
                body["logprobs"] = request.Logprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCompletionTokens))
            {
                body["maxCompletionTokens"] = request.MaxCompletionTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTokens))
            {
                body["maxTokens"] = request.MaxTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinP))
            {
                body["minP"] = request.MinP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTokens))
            {
                body["minTokens"] = request.MinTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MmProcessorKwargs))
            {
                body["mmProcessorKwargs"] = request.MmProcessorKwargs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                body["n"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParallelToolCalls))
            {
                body["parallelToolCalls"] = request.ParallelToolCalls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PresencePenalty))
            {
                body["presencePenalty"] = request.PresencePenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptLogprobs))
            {
                body["promptLogprobs"] = request.PromptLogprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasoningEffort))
            {
                body["reasoningEffort"] = request.ReasoningEffort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepetitionPenalty))
            {
                body["repetitionPenalty"] = request.RepetitionPenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormat))
            {
                body["responseFormat"] = request.ResponseFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipSpecialTokens))
            {
                body["skipSpecialTokens"] = request.SkipSpecialTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stop))
            {
                body["stop"] = request.Stop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTokenIds))
            {
                body["stopTokenIds"] = request.StopTokenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptions))
            {
                body["streamOptions"] = request.StreamOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructuredOutputs))
            {
                body["structuredOutputs"] = request.StructuredOutputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Temperature))
            {
                body["temperature"] = request.Temperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolChoice))
            {
                body["toolChoice"] = request.ToolChoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLogprobs))
            {
                body["topLogprobs"] = request.TopLogprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopP))
            {
                body["topP"] = request.TopP;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PaChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/pa/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PaChatCompletionStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Mobile Planner Agent to initiate a conversation or node planning by using OpenAI-compatible Chat Completions messages, and returns text, model-provided thinking content, and structured tool invocations over Server-Sent Events (SSE). Supports multi-turn sessions and image inputs supported by the model. Business tools are executed by the invoker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile Planner Agent service and prepare the ID and access key of a published Mobile Planner Agent instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /pa/v1/chat/completions</c>.</description></item>
        /// <item><description>Use X-QI-Instance-Id to specify the instance and execute it based on the published configuration. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events rather than a complete JSON object. Continuously read the stream until it ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first turn and save the qi_session_id from the SSE body. Pass it back in the request header with the same name in subsequent turns to continue the session. Make sequential calls within the same session and use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PaChatCompletionStreamRequest
        /// </param>
        /// <param name="headers">
        /// PaChatCompletionStreamHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PaChatCompletionStreamResponse
        /// </returns>
        public async Task<PaChatCompletionStreamResponse> PaChatCompletionStreamWithOptionsAsync(PaChatCompletionStreamRequest request, PaChatCompletionStreamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedTokenIds))
            {
                body["allowedTokenIds"] = request.AllowedTokenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BadWords))
            {
                body["badWords"] = request.BadWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatTemplateKwargs))
            {
                body["chatTemplateKwargs"] = request.ChatTemplateKwargs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrequencyPenalty))
            {
                body["frequencyPenalty"] = request.FrequencyPenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreEos))
            {
                body["ignoreEos"] = request.IgnoreEos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeReasoning))
            {
                body["includeReasoning"] = request.IncludeReasoning;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logprobs))
            {
                body["logprobs"] = request.Logprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCompletionTokens))
            {
                body["maxCompletionTokens"] = request.MaxCompletionTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTokens))
            {
                body["maxTokens"] = request.MaxTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinP))
            {
                body["minP"] = request.MinP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTokens))
            {
                body["minTokens"] = request.MinTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MmProcessorKwargs))
            {
                body["mmProcessorKwargs"] = request.MmProcessorKwargs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                body["n"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParallelToolCalls))
            {
                body["parallelToolCalls"] = request.ParallelToolCalls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PresencePenalty))
            {
                body["presencePenalty"] = request.PresencePenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptLogprobs))
            {
                body["promptLogprobs"] = request.PromptLogprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReasoningEffort))
            {
                body["reasoningEffort"] = request.ReasoningEffort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepetitionPenalty))
            {
                body["repetitionPenalty"] = request.RepetitionPenalty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormat))
            {
                body["responseFormat"] = request.ResponseFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipSpecialTokens))
            {
                body["skipSpecialTokens"] = request.SkipSpecialTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stop))
            {
                body["stop"] = request.Stop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTokenIds))
            {
                body["stopTokenIds"] = request.StopTokenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamOptions))
            {
                body["streamOptions"] = request.StreamOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructuredOutputs))
            {
                body["structuredOutputs"] = request.StructuredOutputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Temperature))
            {
                body["temperature"] = request.Temperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolChoice))
            {
                body["toolChoice"] = request.ToolChoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLogprobs))
            {
                body["topLogprobs"] = request.TopLogprobs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopP))
            {
                body["topP"] = request.TopP;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIAgentApiKey))
            {
                realHeaders["X-QI-Agent-Api-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIAgentApiKey);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQIInstanceId))
            {
                realHeaders["X-QI-Instance-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQIInstanceId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XQISessionId))
            {
                realHeaders["X-QI-Session-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XQISessionId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PaChatCompletionStream",
                Version = "2026-08-31",
                Protocol = "HTTPS",
                Pathname = "/pa/v1/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PaChatCompletionStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Mobile Planner Agent to initiate a conversation or node planning by using OpenAI-compatible Chat Completions messages, and returns text, model-provided thinking content, and structured tool invocations over Server-Sent Events (SSE). Supports multi-turn sessions and image inputs supported by the model. Business tools are executed by the invoker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile Planner Agent service and prepare the ID and access key of a published Mobile Planner Agent instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /pa/v1/chat/completions</c>.</description></item>
        /// <item><description>Use X-QI-Instance-Id to specify the instance and execute it based on the published configuration. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events rather than a complete JSON object. Continuously read the stream until it ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first turn and save the qi_session_id from the SSE body. Pass it back in the request header with the same name in subsequent turns to continue the session. Make sequential calls within the same session and use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PaChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// PaChatCompletionStreamResponse
        /// </returns>
        public PaChatCompletionStreamResponse PaChatCompletionStream(PaChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PaChatCompletionStreamHeaders headers = new PaChatCompletionStreamHeaders();
            return PaChatCompletionStreamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Invokes a published Mobile Planner Agent to initiate a conversation or node planning by using OpenAI-compatible Chat Completions messages, and returns text, model-provided thinking content, and structured tool invocations over Server-Sent Events (SSE). Supports multi-turn sessions and image inputs supported by the model. Business tools are executed by the invoker.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile Planner Agent service and prepare the ID and access key of a published Mobile Planner Agent instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /pa/v1/chat/completions</c>.</description></item>
        /// <item><description>Use X-QI-Instance-Id to specify the instance and execute it based on the published configuration. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events rather than a complete JSON object. Continuously read the stream until it ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id in the first turn and save the qi_session_id from the SSE body. Pass it back in the request header with the same name in subsequent turns to continue the session. Make sequential calls within the same session and use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is subject to the SSE body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PaChatCompletionStreamRequest
        /// </param>
        /// 
        /// <returns>
        /// PaChatCompletionStreamResponse
        /// </returns>
        public async Task<PaChatCompletionStreamResponse> PaChatCompletionStreamAsync(PaChatCompletionStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PaChatCompletionStreamHeaders headers = new PaChatCompletionStreamHeaders();
            return await PaChatCompletionStreamWithOptionsAsync(request, headers, runtime);
        }

    }
}
