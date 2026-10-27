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
        /// <para>Calls a published Creative Agent with support for Lite and Dedicated editions, and returns execution progress and image artifacts by using Server-Sent Events (SSE). The Lite edition performs text-to-image or image-to-image generation depending on whether a reference image is provided. The Dedicated edition uses a Planner to plan and execute generation and editing tasks with multi-turn conversation support. Pass generation count, dimensions, and other parameters through metadata.parameters. Image URLs are included in the artifacts of the result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Creative Agent service and prepare the published instance ID and the corresponding instance access key.</description></item>
        /// <item><description>Creative Agent provides Lite and Dedicated editions. The Lite edition generates or edits images based on whether a reference image is provided. The Dedicated edition uses a Planner to plan and execute creative tasks.</description></item>
        /// <item><description>Complete AccessKey authentication by using the SDK. The instance access key is placed in X-QI-Agent-Api-Key and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>How to call</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /aigc/v1/chat/completions</c>.</description></item>
        /// <item><description>Specify the instance by using <c>X-QI-Instance-Id</c>. The request is executed based on the published configuration of the specified instance. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>This operation returns incremental events instead of a complete JSON response. Continue reading until the stream ends and check for in-stream errors.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit <c>X-QI-Session-Id</c> for the first turn. Save the session identifier returned by the server from the <c>qi_session_id</c> field in the SSE body, and pass the same value back in subsequent turns. Do not rely on the gateway to pass through custom response headers. Use different identifiers for different sessions and send requests sequentially within the same session.</para>
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
        /// <para>Calls a published Creative Agent with support for Lite and Dedicated editions, and returns execution progress and image artifacts by using Server-Sent Events (SSE). The Lite edition performs text-to-image or image-to-image generation depending on whether a reference image is provided. The Dedicated edition uses a Planner to plan and execute generation and editing tasks with multi-turn conversation support. Pass generation count, dimensions, and other parameters through metadata.parameters. Image URLs are included in the artifacts of the result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Creative Agent service and prepare the published instance ID and the corresponding instance access key.</description></item>
        /// <item><description>Creative Agent provides Lite and Dedicated editions. The Lite edition generates or edits images based on whether a reference image is provided. The Dedicated edition uses a Planner to plan and execute creative tasks.</description></item>
        /// <item><description>Complete AccessKey authentication by using the SDK. The instance access key is placed in X-QI-Agent-Api-Key and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>How to call</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /aigc/v1/chat/completions</c>.</description></item>
        /// <item><description>Specify the instance by using <c>X-QI-Instance-Id</c>. The request is executed based on the published configuration of the specified instance. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>This operation returns incremental events instead of a complete JSON response. Continue reading until the stream ends and check for in-stream errors.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit <c>X-QI-Session-Id</c> for the first turn. Save the session identifier returned by the server from the <c>qi_session_id</c> field in the SSE body, and pass the same value back in subsequent turns. Do not rely on the gateway to pass through custom response headers. Use different identifiers for different sessions and send requests sequentially within the same session.</para>
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
        /// <para>Calls a published Creative Agent with support for Lite and Dedicated editions, and returns execution progress and image artifacts by using Server-Sent Events (SSE). The Lite edition performs text-to-image or image-to-image generation depending on whether a reference image is provided. The Dedicated edition uses a Planner to plan and execute generation and editing tasks with multi-turn conversation support. Pass generation count, dimensions, and other parameters through metadata.parameters. Image URLs are included in the artifacts of the result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Creative Agent service and prepare the published instance ID and the corresponding instance access key.</description></item>
        /// <item><description>Creative Agent provides Lite and Dedicated editions. The Lite edition generates or edits images based on whether a reference image is provided. The Dedicated edition uses a Planner to plan and execute creative tasks.</description></item>
        /// <item><description>Complete AccessKey authentication by using the SDK. The instance access key is placed in X-QI-Agent-Api-Key and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>How to call</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /aigc/v1/chat/completions</c>.</description></item>
        /// <item><description>Specify the instance by using <c>X-QI-Instance-Id</c>. The request is executed based on the published configuration of the specified instance. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>This operation returns incremental events instead of a complete JSON response. Continue reading until the stream ends and check for in-stream errors.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit <c>X-QI-Session-Id</c> for the first turn. Save the session identifier returned by the server from the <c>qi_session_id</c> field in the SSE body, and pass the same value back in subsequent turns. Do not rely on the gateway to pass through custom response headers. Use different identifiers for different sessions and send requests sequentially within the same session.</para>
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
        /// <para>Calls a published Creative Agent with support for Lite and Dedicated editions, and returns execution progress and image artifacts by using Server-Sent Events (SSE). The Lite edition performs text-to-image or image-to-image generation depending on whether a reference image is provided. The Dedicated edition uses a Planner to plan and execute generation and editing tasks with multi-turn conversation support. Pass generation count, dimensions, and other parameters through metadata.parameters. Image URLs are included in the artifacts of the result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Creative Agent service and prepare the published instance ID and the corresponding instance access key.</description></item>
        /// <item><description>Creative Agent provides Lite and Dedicated editions. The Lite edition generates or edits images based on whether a reference image is provided. The Dedicated edition uses a Planner to plan and execute creative tasks.</description></item>
        /// <item><description>Complete AccessKey authentication by using the SDK. The instance access key is placed in X-QI-Agent-Api-Key and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>How to call</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /aigc/v1/chat/completions</c>.</description></item>
        /// <item><description>Specify the instance by using <c>X-QI-Instance-Id</c>. The request is executed based on the published configuration of the specified instance. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>This operation returns incremental events instead of a complete JSON response. Continue reading until the stream ends and check for in-stream errors.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit <c>X-QI-Session-Id</c> for the first turn. Save the session identifier returned by the server from the <c>qi_session_id</c> field in the SSE body, and pass the same value back in subsequent turns. Do not rely on the gateway to pass through custom response headers. Use different identifiers for different sessions and send requests sequentially within the same session.</para>
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
        /// <para>调用已发布 CUAStandard 实例，根据任务和桌面截图生成电脑操作单步决策，以 SSE 返回 computer_use 工具调用</para>
        /// </summary>
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
        /// <para>调用已发布 CUAStandard 实例，根据任务和桌面截图生成电脑操作单步决策，以 SSE 返回 computer_use 工具调用</para>
        /// </summary>
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
        /// <para>调用已发布 CUAStandard 实例，根据任务和桌面截图生成电脑操作单步决策，以 SSE 返回 computer_use 工具调用</para>
        /// </summary>
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
        /// <para>调用已发布 CUAStandard 实例，根据任务和桌面截图生成电脑操作单步决策，以 SSE 返回 computer_use 工具调用</para>
        /// </summary>
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
        /// <para>Calls a published Mobile-Use Agent instance, which supports the Standard Edition and Dedicated Edition. Submits the task text and the current screen screenshot, passes the device and application context through metadata, and returns the next mobile UI operation by using Server-Sent Events (SSE). The caller executes the UI operation and then continues to call the API with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Mobile-Use Agent service and prepare the ID and access key of a published Mobile-Use Agent instance.</description></item>
        /// <item><description>Mobile-Use Agent provides the Standard Edition and Dedicated Edition. Call the API based on the edition of the selected instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: POST /gui/v1/chat/completions.</description></item>
        /// <item><description>Use X-QI-Instance-Id to specify the instance and execute based on the published configurations. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events rather than a complete JSON object. Continuously read the stream until it ends and check for errors within the stream.</description></item>
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
        /// <para>Calls a published Mobile-Use Agent instance, which supports the Standard Edition and Dedicated Edition. Submits the task text and the current screen screenshot, passes the device and application context through metadata, and returns the next mobile UI operation by using Server-Sent Events (SSE). The caller executes the UI operation and then continues to call the API with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Mobile-Use Agent service and prepare the ID and access key of a published Mobile-Use Agent instance.</description></item>
        /// <item><description>Mobile-Use Agent provides the Standard Edition and Dedicated Edition. Call the API based on the edition of the selected instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: POST /gui/v1/chat/completions.</description></item>
        /// <item><description>Use X-QI-Instance-Id to specify the instance and execute based on the published configurations. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events rather than a complete JSON object. Continuously read the stream until it ends and check for errors within the stream.</description></item>
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
        /// <para>Calls a published Mobile-Use Agent instance, which supports the Standard Edition and Dedicated Edition. Submits the task text and the current screen screenshot, passes the device and application context through metadata, and returns the next mobile UI operation by using Server-Sent Events (SSE). The caller executes the UI operation and then continues to call the API with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Mobile-Use Agent service and prepare the ID and access key of a published Mobile-Use Agent instance.</description></item>
        /// <item><description>Mobile-Use Agent provides the Standard Edition and Dedicated Edition. Call the API based on the edition of the selected instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: POST /gui/v1/chat/completions.</description></item>
        /// <item><description>Use X-QI-Instance-Id to specify the instance and execute based on the published configurations. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events rather than a complete JSON object. Continuously read the stream until it ends and check for errors within the stream.</description></item>
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
        /// <para>Calls a published Mobile-Use Agent instance, which supports the Standard Edition and Dedicated Edition. Submits the task text and the current screen screenshot, passes the device and application context through metadata, and returns the next mobile UI operation by using Server-Sent Events (SSE). The caller executes the UI operation and then continues to call the API with the session ID and the latest screenshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK Center.</description></item>
        /// <item><description>Activate the Mobile-Use Agent service and prepare the ID and access key of a published Mobile-Use Agent instance.</description></item>
        /// <item><description>Mobile-Use Agent provides the Standard Edition and Dedicated Edition. Call the API based on the edition of the selected instance.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. Place the instance access key in the X-QI-Agent-Api-Key header, which cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type to application/json and Accept to text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>Call methods</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: POST /gui/v1/chat/completions.</description></item>
        /// <item><description>Use X-QI-Instance-Id to specify the instance and execute based on the published configurations. The model field in the request body is a compatibility placeholder and cannot be used to switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events rather than a complete JSON object. Continuously read the stream until it ends and check for errors within the stream.</description></item>
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
        /// <para>Invokes a published Mobile Planner Agent using OpenAI-Compatible Chat Completions messages to initiate a conversation or node planning, and returns text, model-provided reasoning content, and structured tool calling via SSE. Supports multi-turn sessions and model-supported image input. Business tools are executed by the caller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile Planner Agent service and prepare the published Mobile Planner Agent instance ID and its access key.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. The instance access key is placed in X-QI-Agent-Api-Key and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>How to call</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /pa/v1/chat/completions</c>.</description></item>
        /// <item><description>X-QI-Instance-Id specifies the instance and executes based on the published configuration. The model field in the request body is a compatibility placeholder and cannot switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events, not a single complete JSON object. Continue reading until the stream ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id for the first turn. Save qi_session_id from the SSE body and pass it back through the request header of the same name in subsequent turns. Call sequentially within the same session. Use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is based on the SSE body.</para>
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
        /// <para>Invokes a published Mobile Planner Agent using OpenAI-Compatible Chat Completions messages to initiate a conversation or node planning, and returns text, model-provided reasoning content, and structured tool calling via SSE. Supports multi-turn sessions and model-supported image input. Business tools are executed by the caller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile Planner Agent service and prepare the published Mobile Planner Agent instance ID and its access key.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. The instance access key is placed in X-QI-Agent-Api-Key and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>How to call</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /pa/v1/chat/completions</c>.</description></item>
        /// <item><description>X-QI-Instance-Id specifies the instance and executes based on the published configuration. The model field in the request body is a compatibility placeholder and cannot switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events, not a single complete JSON object. Continue reading until the stream ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id for the first turn. Save qi_session_id from the SSE body and pass it back through the request header of the same name in subsequent turns. Call sequentially within the same session. Use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is based on the SSE body.</para>
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
        /// <para>Invokes a published Mobile Planner Agent using OpenAI-Compatible Chat Completions messages to initiate a conversation or node planning, and returns text, model-provided reasoning content, and structured tool calling via SSE. Supports multi-turn sessions and model-supported image input. Business tools are executed by the caller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile Planner Agent service and prepare the published Mobile Planner Agent instance ID and its access key.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. The instance access key is placed in X-QI-Agent-Api-Key and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>How to call</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /pa/v1/chat/completions</c>.</description></item>
        /// <item><description>X-QI-Instance-Id specifies the instance and executes based on the published configuration. The model field in the request body is a compatibility placeholder and cannot switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events, not a single complete JSON object. Continue reading until the stream ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id for the first turn. Save qi_session_id from the SSE body and pass it back through the request header of the same name in subsequent turns. Call sequentially within the same session. Use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is based on the SSE body.</para>
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
        /// <para>Invokes a published Mobile Planner Agent using OpenAI-Compatible Chat Completions messages to initiate a conversation or node planning, and returns text, model-provided reasoning content, and structured tool calling via SSE. Supports multi-turn sessions and model-supported image input. Business tools are executed by the caller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>Install the SDK from the SDK center.</description></item>
        /// <item><description>Activate the Mobile Planner Agent service and prepare the published Mobile Planner Agent instance ID and its access key.</description></item>
        /// <item><description>Use the SDK to complete AccessKey authentication. The instance access key is placed in X-QI-Agent-Api-Key and cannot replace the AccessKey signature.</description></item>
        /// <item><description>Set Content-Type: application/json and Accept: text/event-stream. The stream parameter must be set to true.</description></item>
        /// </list>
        /// <h3>How to call</h3>
        /// <list type="bullet">
        /// <item><description>Method and path: <c>POST /pa/v1/chat/completions</c>.</description></item>
        /// <item><description>X-QI-Instance-Id specifies the instance and executes based on the published configuration. The model field in the request body is a compatibility placeholder and cannot switch models.</description></item>
        /// <item><description>The response consists of SSE incremental events, not a single complete JSON object. Continue reading until the stream ends and check for errors within the stream.</description></item>
        /// </list>
        /// <h3>Session management</h3>
        /// <para>You can omit X-QI-Session-Id for the first turn. Save qi_session_id from the SSE body and pass it back through the request header of the same name in subsequent turns. Call sequentially within the same session. Use different identifiers for different sessions. Do not rely on the gateway to pass through custom response headers. The actual identifier is based on the SSE body.</para>
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
