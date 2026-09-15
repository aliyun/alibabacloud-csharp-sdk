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
            this._endpointRule = "";
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
        /// <para>以 SSE 流式调用已发布 AIGC Agent；支持 AIGCLite 文生图/图生图与 AIGCStandard Planner，兼容 OpenAI Chat Completions。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 AIGC Agent；支持 AIGCLite 文生图/图生图与 AIGCStandard Planner，兼容 OpenAI Chat Completions。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 AIGC Agent；支持 AIGCLite 文生图/图生图与 AIGCStandard Planner，兼容 OpenAI Chat Completions。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 AIGC Agent；支持 AIGCLite 文生图/图生图与 AIGCStandard Planner，兼容 OpenAI Chat Completions。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 GUI Agent；兼容 OpenAI Chat Completions，输入屏幕截图与任务文本，返回下一步 GUI 操作。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 GUI Agent；兼容 OpenAI Chat Completions，输入屏幕截图与任务文本，返回下一步 GUI 操作。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 GUI Agent；兼容 OpenAI Chat Completions，输入屏幕截图与任务文本，返回下一步 GUI 操作。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 GUI Agent；兼容 OpenAI Chat Completions，输入屏幕截图与任务文本，返回下一步 GUI 操作。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 PA Agent；兼容 OpenAI Chat Completions，支持多轮消息、工具调用、多模态输入与思考内容。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 PA Agent；兼容 OpenAI Chat Completions，支持多轮消息、工具调用、多模态输入与思考内容。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 PA Agent；兼容 OpenAI Chat Completions，支持多轮消息、工具调用、多模态输入与思考内容。</para>
        /// </summary>
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
        /// <para>以 SSE 流式调用已发布 PA Agent；兼容 OpenAI Chat Completions，支持多轮消息、工具调用、多模态输入与思考内容。</para>
        /// </summary>
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
