// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AgentRun20250910.Models;

namespace AlibabaCloud.SDK.AgentRun20250910
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shenzhen", "agentrun.cn-shenzhen.aliyuncs.com"},
                {"cn-shanghai", "agentrun.cn-shanghai.aliyuncs.com"},
                {"cn-hangzhou", "agentrun.cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "agentrun.cn-beijing.aliyuncs.com"},
                {"ap-southeast-1", "agentrun.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("agentrun", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Activates the <c>MCP service</c> for a <c>sandbox</c> <c>template</c>. This enables a client to access the <c>sandbox</c> using the MCP protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After activation, the platform automatically deploys the <c>MCP service</c> <c>function</c> for the specified <c>sandbox</c> <c>template</c>. The <c>MCP service</c> ensures a unique mapping between an <c>mcp-session-id</c> and a <c>SandboxID</c>. When an MCP <c>client</c> invokes a <c>tool</c>, the <c>MCP service</c> automatically creates a <c>sandbox</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActivateTemplateMCPRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateTemplateMCPResponse
        /// </returns>
        public ActivateTemplateMCPResponse ActivateTemplateMCPWithOptions(string templateName, ActivateTemplateMCPRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnabledTools))
            {
                body["enabledTools"] = request.EnabledTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transport))
            {
                body["transport"] = request.Transport;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateTemplateMCP",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName) + "/mcp/activate",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateTemplateMCPResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the <c>MCP service</c> for a <c>sandbox</c> <c>template</c>. This enables a client to access the <c>sandbox</c> using the MCP protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After activation, the platform automatically deploys the <c>MCP service</c> <c>function</c> for the specified <c>sandbox</c> <c>template</c>. The <c>MCP service</c> ensures a unique mapping between an <c>mcp-session-id</c> and a <c>SandboxID</c>. When an MCP <c>client</c> invokes a <c>tool</c>, the <c>MCP service</c> automatically creates a <c>sandbox</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActivateTemplateMCPRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateTemplateMCPResponse
        /// </returns>
        public async Task<ActivateTemplateMCPResponse> ActivateTemplateMCPWithOptionsAsync(string templateName, ActivateTemplateMCPRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnabledTools))
            {
                body["enabledTools"] = request.EnabledTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transport))
            {
                body["transport"] = request.Transport;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateTemplateMCP",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName) + "/mcp/activate",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateTemplateMCPResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the <c>MCP service</c> for a <c>sandbox</c> <c>template</c>. This enables a client to access the <c>sandbox</c> using the MCP protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After activation, the platform automatically deploys the <c>MCP service</c> <c>function</c> for the specified <c>sandbox</c> <c>template</c>. The <c>MCP service</c> ensures a unique mapping between an <c>mcp-session-id</c> and a <c>SandboxID</c>. When an MCP <c>client</c> invokes a <c>tool</c>, the <c>MCP service</c> automatically creates a <c>sandbox</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActivateTemplateMCPRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateTemplateMCPResponse
        /// </returns>
        public ActivateTemplateMCPResponse ActivateTemplateMCP(string templateName, ActivateTemplateMCPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ActivateTemplateMCPWithOptions(templateName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the <c>MCP service</c> for a <c>sandbox</c> <c>template</c>. This enables a client to access the <c>sandbox</c> using the MCP protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After activation, the platform automatically deploys the <c>MCP service</c> <c>function</c> for the specified <c>sandbox</c> <c>template</c>. The <c>MCP service</c> ensures a unique mapping between an <c>mcp-session-id</c> and a <c>SandboxID</c>. When an MCP <c>client</c> invokes a <c>tool</c>, the <c>MCP service</c> automatically creates a <c>sandbox</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActivateTemplateMCPRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateTemplateMCPResponse
        /// </returns>
        public async Task<ActivateTemplateMCPResponse> ActivateTemplateMCPAsync(string templateName, ActivateTemplateMCPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ActivateTemplateMCPWithOptionsAsync(templateName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a Flow DSL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation converts a third-party workflow DSL, such as Dify or n8n, into an AgentRun Flow definition. It performs compatibility checks, identifies plugins, and extracts metadata. The operation runs in dry-run mode, returning the converted Flow configuration, a compatibility analysis report, and the required Toolset installation configuration without creating a Flow resource.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertFlowDSLRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertFlowDSLResponse
        /// </returns>
        public ConvertFlowDSLResponse ConvertFlowDSLWithOptions(ConvertFlowDSLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertFlowDSL",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/action/convertDsl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertFlowDSLResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a Flow DSL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation converts a third-party workflow DSL, such as Dify or n8n, into an AgentRun Flow definition. It performs compatibility checks, identifies plugins, and extracts metadata. The operation runs in dry-run mode, returning the converted Flow configuration, a compatibility analysis report, and the required Toolset installation configuration without creating a Flow resource.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertFlowDSLRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConvertFlowDSLResponse
        /// </returns>
        public async Task<ConvertFlowDSLResponse> ConvertFlowDSLWithOptionsAsync(ConvertFlowDSLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertFlowDSL",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/action/convertDsl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertFlowDSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a Flow DSL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation converts a third-party workflow DSL, such as Dify or n8n, into an AgentRun Flow definition. It performs compatibility checks, identifies plugins, and extracts metadata. The operation runs in dry-run mode, returning the converted Flow configuration, a compatibility analysis report, and the required Toolset installation configuration without creating a Flow resource.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertFlowDSLRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertFlowDSLResponse
        /// </returns>
        public ConvertFlowDSLResponse ConvertFlowDSL(ConvertFlowDSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConvertFlowDSLWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a Flow DSL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation converts a third-party workflow DSL, such as Dify or n8n, into an AgentRun Flow definition. It performs compatibility checks, identifies plugins, and extracts metadata. The operation runs in dry-run mode, returning the converted Flow configuration, a compatibility analysis report, and the required Toolset installation configuration without creating a Flow resource.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConvertFlowDSLRequest
        /// </param>
        /// 
        /// <returns>
        /// ConvertFlowDSLResponse
        /// </returns>
        public async Task<ConvertFlowDSLResponse> ConvertFlowDSLAsync(ConvertFlowDSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConvertFlowDSLWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的智能体运行时实例，用于执行AI代理任务。智能体运行时是AgentRun服务的核心组件，提供代码执行、浏览器操作、内存管理等能力。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRuntimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentRuntimeResponse
        /// </returns>
        public CreateAgentRuntimeResponse CreateAgentRuntimeWithOptions(CreateAgentRuntimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentRuntime",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的智能体运行时实例，用于执行AI代理任务。智能体运行时是AgentRun服务的核心组件，提供代码执行、浏览器操作、内存管理等能力。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRuntimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentRuntimeResponse
        /// </returns>
        public async Task<CreateAgentRuntimeResponse> CreateAgentRuntimeWithOptionsAsync(CreateAgentRuntimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentRuntime",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的智能体运行时实例，用于执行AI代理任务。智能体运行时是AgentRun服务的核心组件，提供代码执行、浏览器操作、内存管理等能力。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentRuntimeResponse
        /// </returns>
        public CreateAgentRuntimeResponse CreateAgentRuntime(CreateAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAgentRuntimeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的智能体运行时实例，用于执行AI代理任务。智能体运行时是AgentRun服务的核心组件，提供代码执行、浏览器操作、内存管理等能力。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentRuntimeResponse
        /// </returns>
        public async Task<CreateAgentRuntimeResponse> CreateAgentRuntimeAsync(CreateAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAgentRuntimeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an access endpoint for an agent runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a new endpoint for the specified agent runtime, used for external access and invocation. An endpoint serves as the entry point through which an agent runtime provides services externally.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRuntimeEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentRuntimeEndpointResponse
        /// </returns>
        public CreateAgentRuntimeEndpointResponse CreateAgentRuntimeEndpointWithOptions(string agentRuntimeId, CreateAgentRuntimeEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentRuntimeEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentRuntimeEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an access endpoint for an agent runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a new endpoint for the specified agent runtime, used for external access and invocation. An endpoint serves as the entry point through which an agent runtime provides services externally.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRuntimeEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentRuntimeEndpointResponse
        /// </returns>
        public async Task<CreateAgentRuntimeEndpointResponse> CreateAgentRuntimeEndpointWithOptionsAsync(string agentRuntimeId, CreateAgentRuntimeEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentRuntimeEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentRuntimeEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an access endpoint for an agent runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a new endpoint for the specified agent runtime, used for external access and invocation. An endpoint serves as the entry point through which an agent runtime provides services externally.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRuntimeEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentRuntimeEndpointResponse
        /// </returns>
        public CreateAgentRuntimeEndpointResponse CreateAgentRuntimeEndpoint(string agentRuntimeId, CreateAgentRuntimeEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAgentRuntimeEndpointWithOptions(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create an access endpoint for an agent runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a new endpoint for the specified agent runtime, used for external access and invocation. An endpoint serves as the entry point through which an agent runtime provides services externally.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRuntimeEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentRuntimeEndpointResponse
        /// </returns>
        public async Task<CreateAgentRuntimeEndpointResponse> CreateAgentRuntimeEndpointAsync(string agentRuntimeId, CreateAgentRuntimeEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAgentRuntimeEndpointWithOptionsAsync(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Browser Sandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a new browser instance for executing web automation tasks. The browser instance provides features such as web browsing, element manipulation, and screenshot recording.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBrowserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBrowserResponse
        /// </returns>
        public CreateBrowserResponse CreateBrowserWithOptions(CreateBrowserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBrowser",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/browsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBrowserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Browser Sandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a new browser instance for executing web automation tasks. The browser instance provides features such as web browsing, element manipulation, and screenshot recording.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBrowserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBrowserResponse
        /// </returns>
        public async Task<CreateBrowserResponse> CreateBrowserWithOptionsAsync(CreateBrowserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBrowser",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/browsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBrowserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Browser Sandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a new browser instance for executing web automation tasks. The browser instance provides features such as web browsing, element manipulation, and screenshot recording.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBrowserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBrowserResponse
        /// </returns>
        public CreateBrowserResponse CreateBrowser(CreateBrowserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBrowserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Browser Sandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a new browser instance for executing web automation tasks. The browser instance provides features such as web browsing, element manipulation, and screenshot recording.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBrowserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBrowserResponse
        /// </returns>
        public async Task<CreateBrowserResponse> CreateBrowserAsync(CreateBrowserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBrowserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code interpreter.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的代码解释器实例，用于执行代码解释和运行任务。代码解释器提供Python代码执行、数据处理、机器学习等功能。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCodeInterpreterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeInterpreterResponse
        /// </returns>
        public CreateCodeInterpreterResponse CreateCodeInterpreterWithOptions(CreateCodeInterpreterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCodeInterpreter",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/code-interpreters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCodeInterpreterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code interpreter.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的代码解释器实例，用于执行代码解释和运行任务。代码解释器提供Python代码执行、数据处理、机器学习等功能。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCodeInterpreterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeInterpreterResponse
        /// </returns>
        public async Task<CreateCodeInterpreterResponse> CreateCodeInterpreterWithOptionsAsync(CreateCodeInterpreterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCodeInterpreter",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/code-interpreters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCodeInterpreterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code interpreter.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的代码解释器实例，用于执行代码解释和运行任务。代码解释器提供Python代码执行、数据处理、机器学习等功能。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCodeInterpreterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeInterpreterResponse
        /// </returns>
        public CreateCodeInterpreterResponse CreateCodeInterpreter(CreateCodeInterpreterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCodeInterpreterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code interpreter.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的代码解释器实例，用于执行代码解释和运行任务。代码解释器提供Python代码执行、数据处理、机器学习等功能。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCodeInterpreterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeInterpreterResponse
        /// </returns>
        public async Task<CreateCodeInterpreterResponse> CreateCodeInterpreterAsync(CreateCodeInterpreterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCodeInterpreterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a credential for an agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public CreateCredentialResponse CreateCredentialWithOptions(CreateCredentialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCredential",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a credential for an agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public async Task<CreateCredentialResponse> CreateCredentialWithOptionsAsync(CreateCredentialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCredential",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a credential for an agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public CreateCredentialResponse CreateCredential(CreateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCredentialWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a credential for an agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public async Task<CreateCredentialResponse> CreateCredentialAsync(CreateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCredentialWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomDomainResponse
        /// </returns>
        public CreateCustomDomainResponse CreateCustomDomainWithOptions(CreateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomDomain",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomDomainResponse
        /// </returns>
        public async Task<CreateCustomDomainResponse> CreateCustomDomainWithOptionsAsync(CreateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomDomain",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomDomainResponse
        /// </returns>
        public CreateCustomDomainResponse CreateCustomDomain(CreateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCustomDomainWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomDomainResponse
        /// </returns>
        public async Task<CreateCustomDomainResponse> CreateCustomDomainAsync(CreateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCustomDomainWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a flow orchestration agent. Flow orchestration is a core component of the AgentRun service that supports visual orchestration and version management.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a flow orchestration agent. Flow orchestration is a core component of the AgentRun service that supports visual orchestration and version management.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a flow orchestration agent. Flow orchestration is a core component of the AgentRun service that supports visual orchestration and version management.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFlowWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a flow orchestration agent. Flow orchestration is a core component of the AgentRun service that supports visual orchestration and version management.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public async Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFlowWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定工作流创建一个新的端点，用于对外提供服务访问。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowEndpointResponse
        /// </returns>
        public CreateFlowEndpointResponse CreateFlowEndpointWithOptions(string flowName, CreateFlowEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/endpoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定工作流创建一个新的端点，用于对外提供服务访问。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowEndpointResponse
        /// </returns>
        public async Task<CreateFlowEndpointResponse> CreateFlowEndpointWithOptionsAsync(string flowName, CreateFlowEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/endpoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定工作流创建一个新的端点，用于对外提供服务访问。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowEndpointResponse
        /// </returns>
        public CreateFlowEndpointResponse CreateFlowEndpoint(string flowName, CreateFlowEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFlowEndpointWithOptions(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定工作流创建一个新的端点，用于对外提供服务访问。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFlowEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowEndpointResponse
        /// </returns>
        public async Task<CreateFlowEndpointResponse> CreateFlowEndpointAsync(string flowName, CreateFlowEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFlowEndpointWithOptionsAsync(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IM Bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A successful request returns an HTTP 201 status code. Once created, an IM Bot\&quot;s status is always <c>running</c>. The response is in a standard format, and its <c>data</c> field contains an <c>IMBotInfo</c> object.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIMBotRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIMBotResponse
        /// </returns>
        public CreateIMBotResponse CreateIMBotWithOptions(CreateIMBotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIMBot",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIMBotResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IM Bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A successful request returns an HTTP 201 status code. Once created, an IM Bot\&quot;s status is always <c>running</c>. The response is in a standard format, and its <c>data</c> field contains an <c>IMBotInfo</c> object.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIMBotRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIMBotResponse
        /// </returns>
        public async Task<CreateIMBotResponse> CreateIMBotWithOptionsAsync(CreateIMBotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIMBot",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIMBotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IM Bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A successful request returns an HTTP 201 status code. Once created, an IM Bot\&quot;s status is always <c>running</c>. The response is in a standard format, and its <c>data</c> field contains an <c>IMBotInfo</c> object.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIMBotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIMBotResponse
        /// </returns>
        public CreateIMBotResponse CreateIMBot(CreateIMBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIMBotWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IM Bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A successful request returns an HTTP 201 status code. Once created, an IM Bot\&quot;s status is always <c>running</c>. The response is in a standard format, and its <c>data</c> field contains an <c>IMBotInfo</c> object.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIMBotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIMBotResponse
        /// </returns>
        public async Task<CreateIMBotResponse> CreateIMBotAsync(CreateIMBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIMBotWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public CreateKnowledgeBaseResponse CreateKnowledgeBaseWithOptions(CreateKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBase",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseWithOptionsAsync(CreateKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBase",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKnowledgeBaseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKnowledgeBaseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryCollectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryCollectionResponse
        /// </returns>
        public CreateMemoryCollectionResponse CreateMemoryCollectionWithOptions(CreateMemoryCollectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemoryCollection",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryCollectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryCollectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryCollectionResponse
        /// </returns>
        public async Task<CreateMemoryCollectionResponse> CreateMemoryCollectionWithOptionsAsync(CreateMemoryCollectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemoryCollection",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryCollectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryCollectionResponse
        /// </returns>
        public CreateMemoryCollectionResponse CreateMemoryCollection(CreateMemoryCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemoryCollectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemoryCollectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemoryCollectionResponse
        /// </returns>
        public async Task<CreateMemoryCollectionResponse> CreateMemoryCollectionAsync(CreateMemoryCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemoryCollectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Model Proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a Model Proxy based on the specified configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProxyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProxyResponse
        /// </returns>
        public CreateModelProxyResponse CreateModelProxyWithOptions(CreateModelProxyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelProxy",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelProxyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Model Proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a Model Proxy based on the specified configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProxyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProxyResponse
        /// </returns>
        public async Task<CreateModelProxyResponse> CreateModelProxyWithOptionsAsync(CreateModelProxyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelProxy",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Model Proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a Model Proxy based on the specified configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProxyResponse
        /// </returns>
        public CreateModelProxyResponse CreateModelProxy(CreateModelProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelProxyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Model Proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a Model Proxy based on the specified configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelProxyResponse
        /// </returns>
        public async Task<CreateModelProxyResponse> CreateModelProxyAsync(CreateModelProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelProxyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a model service, such as a code interpreter, based on the specified configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelServiceResponse
        /// </returns>
        public CreateModelServiceResponse CreateModelServiceWithOptions(CreateModelServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelService",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a model service, such as a code interpreter, based on the specified configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelServiceResponse
        /// </returns>
        public async Task<CreateModelServiceResponse> CreateModelServiceWithOptionsAsync(CreateModelServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelService",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a model service, such as a code interpreter, based on the specified configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelServiceResponse
        /// </returns>
        public CreateModelServiceResponse CreateModelService(CreateModelServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a model service, such as a code interpreter, based on the specified configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateModelServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelServiceResponse
        /// </returns>
        public async Task<CreateModelServiceResponse> CreateModelServiceAsync(CreateModelServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a new sandbox instance from a specified template. A sandbox provides an isolated execution environment to run code or launch a browser.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSandboxRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSandboxResponse
        /// </returns>
        public CreateSandboxResponse CreateSandboxWithOptions(CreateSandboxRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSandboxResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a new sandbox instance from a specified template. A sandbox provides an isolated execution environment to run code or launch a browser.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSandboxRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSandboxResponse
        /// </returns>
        public async Task<CreateSandboxResponse> CreateSandboxWithOptionsAsync(CreateSandboxRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSandboxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a new sandbox instance from a specified template. A sandbox provides an isolated execution environment to run code or launch a browser.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSandboxRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSandboxResponse
        /// </returns>
        public CreateSandboxResponse CreateSandbox(CreateSandboxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSandboxWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a new sandbox instance from a specified template. A sandbox provides an isolated execution environment to run code or launch a browser.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSandboxRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSandboxResponse
        /// </returns>
        public async Task<CreateSandboxResponse> CreateSandboxAsync(CreateSandboxRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSandboxWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a template for launching sandboxes. A template defines the runtime environment, resource configuration, and other settings for a sandbox.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a template for launching sandboxes. A template defines the runtime environment, resource configuration, and other settings for a sandbox.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a template for launching sandboxes. A template defines the runtime environment, resource configuration, and other settings for a sandbox.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a template for launching sandboxes. A template defines the runtime environment, resource configuration, and other settings for a sandbox.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates various types of tools, such as MCP, function call, and skill. An Agent can then call a tool to extend its capabilities.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateToolRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateToolResponse
        /// </returns>
        public CreateToolResponse CreateToolWithOptions(CreateToolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTool",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateToolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates various types of tools, such as MCP, function call, and skill. An Agent can then call a tool to extend its capabilities.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateToolRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateToolResponse
        /// </returns>
        public async Task<CreateToolResponse> CreateToolWithOptionsAsync(CreateToolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTool",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateToolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates various types of tools, such as MCP, function call, and skill. An Agent can then call a tool to extend its capabilities.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateToolRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateToolResponse
        /// </returns>
        public CreateToolResponse CreateTool(CreateToolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateToolWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates various types of tools, such as MCP, function call, and skill. An Agent can then call a tool to extend its capabilities.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateToolRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateToolResponse
        /// </returns>
        public async Task<CreateToolResponse> CreateToolAsync(CreateToolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateToolWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Agent Runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified agent runtime instance, including all associated resources and data. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentRuntimeResponse
        /// </returns>
        public DeleteAgentRuntimeResponse DeleteAgentRuntimeWithOptions(string agentRuntimeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentRuntime",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Agent Runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified agent runtime instance, including all associated resources and data. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentRuntimeResponse
        /// </returns>
        public async Task<DeleteAgentRuntimeResponse> DeleteAgentRuntimeWithOptionsAsync(string agentRuntimeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentRuntime",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Agent Runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified agent runtime instance, including all associated resources and data. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteAgentRuntimeResponse
        /// </returns>
        public DeleteAgentRuntimeResponse DeleteAgentRuntime(string agentRuntimeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentRuntimeWithOptions(agentRuntimeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Agent Runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified agent runtime instance, including all associated resources and data. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteAgentRuntimeResponse
        /// </returns>
        public async Task<DeleteAgentRuntimeResponse> DeleteAgentRuntimeAsync(string agentRuntimeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentRuntimeWithOptionsAsync(agentRuntimeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Agent Runtime Endpoint</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentRuntimeEndpointResponse
        /// </returns>
        public DeleteAgentRuntimeEndpointResponse DeleteAgentRuntimeEndpointWithOptions(string agentRuntimeId, string agentRuntimeEndpointId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentRuntimeEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeEndpointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentRuntimeEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Agent Runtime Endpoint</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentRuntimeEndpointResponse
        /// </returns>
        public async Task<DeleteAgentRuntimeEndpointResponse> DeleteAgentRuntimeEndpointWithOptionsAsync(string agentRuntimeId, string agentRuntimeEndpointId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentRuntimeEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeEndpointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentRuntimeEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Agent Runtime Endpoint</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAgentRuntimeEndpointResponse
        /// </returns>
        public DeleteAgentRuntimeEndpointResponse DeleteAgentRuntimeEndpoint(string agentRuntimeId, string agentRuntimeEndpointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentRuntimeEndpointWithOptions(agentRuntimeId, agentRuntimeEndpointId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Agent Runtime Endpoint</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAgentRuntimeEndpointResponse
        /// </returns>
        public async Task<DeleteAgentRuntimeEndpointResponse> DeleteAgentRuntimeEndpointAsync(string agentRuntimeId, string agentRuntimeEndpointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentRuntimeEndpointWithOptionsAsync(agentRuntimeId, agentRuntimeEndpointId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Browser Sandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the specified browser instance, including all its associated resources and data. The deletion is irreversible. Please proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBrowserResponse
        /// </returns>
        public DeleteBrowserResponse DeleteBrowserWithOptions(string browserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBrowser",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/browsers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(browserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBrowserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Browser Sandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the specified browser instance, including all its associated resources and data. The deletion is irreversible. Please proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBrowserResponse
        /// </returns>
        public async Task<DeleteBrowserResponse> DeleteBrowserWithOptionsAsync(string browserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBrowser",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/browsers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(browserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBrowserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Browser Sandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the specified browser instance, including all its associated resources and data. The deletion is irreversible. Please proceed with caution.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteBrowserResponse
        /// </returns>
        public DeleteBrowserResponse DeleteBrowser(string browserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBrowserWithOptions(browserId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Browser Sandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the specified browser instance, including all its associated resources and data. The deletion is irreversible. Please proceed with caution.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteBrowserResponse
        /// </returns>
        public async Task<DeleteBrowserResponse> DeleteBrowserAsync(string browserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBrowserWithOptionsAsync(browserId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Code Interpreter</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a specified code interpreter instance, including all its associated resources and data. This operation is irreversible. Please proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCodeInterpreterResponse
        /// </returns>
        public DeleteCodeInterpreterResponse DeleteCodeInterpreterWithOptions(string codeInterpreterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCodeInterpreter",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/code-interpreters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(codeInterpreterId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCodeInterpreterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Code Interpreter</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a specified code interpreter instance, including all its associated resources and data. This operation is irreversible. Please proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCodeInterpreterResponse
        /// </returns>
        public async Task<DeleteCodeInterpreterResponse> DeleteCodeInterpreterWithOptionsAsync(string codeInterpreterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCodeInterpreter",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/code-interpreters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(codeInterpreterId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCodeInterpreterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Code Interpreter</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a specified code interpreter instance, including all its associated resources and data. This operation is irreversible. Please proceed with caution.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteCodeInterpreterResponse
        /// </returns>
        public DeleteCodeInterpreterResponse DeleteCodeInterpreter(string codeInterpreterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCodeInterpreterWithOptions(codeInterpreterId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Code Interpreter</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a specified code interpreter instance, including all its associated resources and data. This operation is irreversible. Please proceed with caution.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteCodeInterpreterResponse
        /// </returns>
        public async Task<DeleteCodeInterpreterResponse> DeleteCodeInterpreterAsync(string codeInterpreterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCodeInterpreterWithOptionsAsync(codeInterpreterId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the specified credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes the specified credential. This action cannot be undone.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public DeleteCredentialResponse DeleteCredentialWithOptions(string credentialName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCredential",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the specified credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes the specified credential. This action cannot be undone.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public async Task<DeleteCredentialResponse> DeleteCredentialWithOptionsAsync(string credentialName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCredential",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the specified credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes the specified credential. This action cannot be undone.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public DeleteCredentialResponse DeleteCredential(string credentialName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCredentialWithOptions(credentialName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the specified credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes the specified credential. This action cannot be undone.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public async Task<DeleteCredentialResponse> DeleteCredentialAsync(string credentialName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCredentialWithOptionsAsync(credentialName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomDomainResponse
        /// </returns>
        public DeleteCustomDomainResponse DeleteCustomDomainWithOptions(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomDomain",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomDomainResponse
        /// </returns>
        public async Task<DeleteCustomDomainResponse> DeleteCustomDomainWithOptionsAsync(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomDomain",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom domain.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCustomDomainResponse
        /// </returns>
        public DeleteCustomDomainResponse DeleteCustomDomain(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCustomDomainWithOptions(domainName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom domain.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCustomDomainResponse
        /// </returns>
        public async Task<DeleteCustomDomainResponse> DeleteCustomDomainAsync(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCustomDomainWithOptionsAsync(domainName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified flow instance, along with all its related resources and data. This operation is irreversible and cannot be undone. Use with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public DeleteFlowResponse DeleteFlowWithOptions(string flowName, DeleteFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified flow instance, along with all its related resources and data. This operation is irreversible and cannot be undone. Use with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(string flowName, DeleteFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified flow instance, along with all its related resources and data. This operation is irreversible and cannot be undone. Use with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public DeleteFlowResponse DeleteFlow(string flowName, DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFlowWithOptions(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified flow instance, along with all its related resources and data. This operation is irreversible and cannot be undone. Use with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public async Task<DeleteFlowResponse> DeleteFlowAsync(string flowName, DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFlowWithOptionsAsync(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified flow endpoint. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowEndpointResponse
        /// </returns>
        public DeleteFlowEndpointResponse DeleteFlowEndpointWithOptions(string flowName, string flowEndpointName, DeleteFlowEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowEndpointName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified flow endpoint. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowEndpointResponse
        /// </returns>
        public async Task<DeleteFlowEndpointResponse> DeleteFlowEndpointWithOptionsAsync(string flowName, string flowEndpointName, DeleteFlowEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowEndpointName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified flow endpoint. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowEndpointResponse
        /// </returns>
        public DeleteFlowEndpointResponse DeleteFlowEndpoint(string flowName, string flowEndpointName, DeleteFlowEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFlowEndpointWithOptions(flowName, flowEndpointName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified flow endpoint. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowEndpointResponse
        /// </returns>
        public async Task<DeleteFlowEndpointResponse> DeleteFlowEndpointAsync(string flowName, string flowEndpointName, DeleteFlowEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFlowEndpointWithOptionsAsync(flowName, flowEndpointName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified version of a workflow. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowVersionResponse
        /// </returns>
        public DeleteFlowVersionResponse DeleteFlowVersionWithOptions(string flowName, string flowVersion, DeleteFlowVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowVersion",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowVersion),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified version of a workflow. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowVersionResponse
        /// </returns>
        public async Task<DeleteFlowVersionResponse> DeleteFlowVersionWithOptionsAsync(string flowName, string flowVersion, DeleteFlowVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowVersion",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowVersion),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified version of a workflow. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowVersionResponse
        /// </returns>
        public DeleteFlowVersionResponse DeleteFlowVersion(string flowName, string flowVersion, DeleteFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFlowVersionWithOptions(flowName, flowVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified version of a workflow. This operation is irreversible. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowVersionResponse
        /// </returns>
        public async Task<DeleteFlowVersionResponse> DeleteFlowVersionAsync(string flowName, string flowVersion, DeleteFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFlowVersionWithOptionsAsync(flowName, flowVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IM bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes an IM bot via a <c>DELETE</c> request to the <c>/2025-09-10/agents/im-bots/{imBotId}</c> endpoint. A successful request returns an HTTP <c>204 No Content</c> status code and an empty response body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIMBotRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIMBotResponse
        /// </returns>
        public DeleteIMBotResponse DeleteIMBotWithOptions(string imBotId, DeleteIMBotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIMBot",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imBotId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIMBotResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IM bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes an IM bot via a <c>DELETE</c> request to the <c>/2025-09-10/agents/im-bots/{imBotId}</c> endpoint. A successful request returns an HTTP <c>204 No Content</c> status code and an empty response body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIMBotRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIMBotResponse
        /// </returns>
        public async Task<DeleteIMBotResponse> DeleteIMBotWithOptionsAsync(string imBotId, DeleteIMBotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIMBot",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imBotId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIMBotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IM bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes an IM bot via a <c>DELETE</c> request to the <c>/2025-09-10/agents/im-bots/{imBotId}</c> endpoint. A successful request returns an HTTP <c>204 No Content</c> status code and an empty response body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIMBotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIMBotResponse
        /// </returns>
        public DeleteIMBotResponse DeleteIMBot(string imBotId, DeleteIMBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIMBotWithOptions(imBotId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IM bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes an IM bot via a <c>DELETE</c> request to the <c>/2025-09-10/agents/im-bots/{imBotId}</c> endpoint. A successful request returns an HTTP <c>204 No Content</c> status code and an empty response body.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIMBotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIMBotResponse
        /// </returns>
        public async Task<DeleteIMBotResponse> DeleteIMBotAsync(string imBotId, DeleteIMBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIMBotWithOptionsAsync(imBotId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a knowledge base.</para>
        /// <remarks>
        /// <para>This operation is permanent and cannot be undone.</para>
        /// </remarks>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public DeleteKnowledgeBaseResponse DeleteKnowledgeBaseWithOptions(string knowledgeBaseName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKnowledgeBase",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a knowledge base.</para>
        /// <remarks>
        /// <para>This operation is permanent and cannot be undone.</para>
        /// </remarks>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public async Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseWithOptionsAsync(string knowledgeBaseName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKnowledgeBase",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a knowledge base.</para>
        /// <remarks>
        /// <para>This operation is permanent and cannot be undone.</para>
        /// </remarks>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public DeleteKnowledgeBaseResponse DeleteKnowledgeBase(string knowledgeBaseName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteKnowledgeBaseWithOptions(knowledgeBaseName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a knowledge base.</para>
        /// <remarks>
        /// <para>This operation is permanent and cannot be undone.</para>
        /// </remarks>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public async Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseAsync(string knowledgeBaseName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteKnowledgeBaseWithOptionsAsync(knowledgeBaseName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryCollectionResponse
        /// </returns>
        public DeleteMemoryCollectionResponse DeleteMemoryCollectionWithOptions(string memoryCollectionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemoryCollection",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryCollectionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryCollectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemoryCollectionResponse
        /// </returns>
        public async Task<DeleteMemoryCollectionResponse> DeleteMemoryCollectionWithOptionsAsync(string memoryCollectionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemoryCollection",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryCollectionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a memory collection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMemoryCollectionResponse
        /// </returns>
        public DeleteMemoryCollectionResponse DeleteMemoryCollection(string memoryCollectionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryCollectionWithOptions(memoryCollectionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a memory collection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMemoryCollectionResponse
        /// </returns>
        public async Task<DeleteMemoryCollectionResponse> DeleteMemoryCollectionAsync(string memoryCollectionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryCollectionWithOptionsAsync(memoryCollectionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes the specified model proxy configuration without deleting the underlying models or related resources.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProxyResponse
        /// </returns>
        public DeleteModelProxyResponse DeleteModelProxyWithOptions(string modelProxyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelProxy",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelProxyName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelProxyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes the specified model proxy configuration without deleting the underlying models or related resources.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelProxyResponse
        /// </returns>
        public async Task<DeleteModelProxyResponse> DeleteModelProxyWithOptionsAsync(string modelProxyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelProxy",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelProxyName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes the specified model proxy configuration without deleting the underlying models or related resources.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteModelProxyResponse
        /// </returns>
        public DeleteModelProxyResponse DeleteModelProxy(string modelProxyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelProxyWithOptions(modelProxyName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes the specified model proxy configuration without deleting the underlying models or related resources.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteModelProxyResponse
        /// </returns>
        public async Task<DeleteModelProxyResponse> DeleteModelProxyAsync(string modelProxyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelProxyWithOptionsAsync(modelProxyName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes a model service. You must specify the name of the service to delete.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelServiceResponse
        /// </returns>
        public DeleteModelServiceResponse DeleteModelServiceWithOptions(string modelServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelService",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelServiceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes a model service. You must specify the name of the service to delete.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelServiceResponse
        /// </returns>
        public async Task<DeleteModelServiceResponse> DeleteModelServiceWithOptionsAsync(string modelServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelService",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelServiceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes a model service. You must specify the name of the service to delete.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteModelServiceResponse
        /// </returns>
        public DeleteModelServiceResponse DeleteModelService(string modelServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelServiceWithOptions(modelServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes a model service. You must specify the name of the service to delete.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteModelServiceResponse
        /// </returns>
        public async Task<DeleteModelServiceResponse> DeleteModelServiceAsync(string modelServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelServiceWithOptionsAsync(modelServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a sandbox instance.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxResponse
        /// </returns>
        public DeleteSandboxResponse DeleteSandboxWithOptions(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSandboxResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a sandbox instance.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxResponse
        /// </returns>
        public async Task<DeleteSandboxResponse> DeleteSandboxWithOptionsAsync(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSandboxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a sandbox instance.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteSandboxResponse
        /// </returns>
        public DeleteSandboxResponse DeleteSandbox(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSandboxWithOptions(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a sandbox instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a sandbox instance.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteSandboxResponse
        /// </returns>
        public async Task<DeleteSandboxResponse> DeleteSandboxAsync(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSandboxWithOptionsAsync(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified template. After you delete a template, you can no longer use it to create new sandboxes.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplateWithOptions(string templateName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified template. After you delete a template, you can no longer use it to create new sandboxes.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(string templateName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified template. After you delete a template, you can no longer use it to create new sandboxes.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplate(string templateName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTemplateWithOptions(templateName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified template. After you delete a template, you can no longer use it to create new sandboxes.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(string templateName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTemplateWithOptionsAsync(templateName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a tool</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the specified tool. The delete operation is irreversible. Proceed with caution. After the tool is deleted, all Agents that reference this tool will no longer be able to use it.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteToolResponse
        /// </returns>
        public DeleteToolResponse DeleteToolWithOptions(string toolName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTool",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(toolName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteToolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a tool</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the specified tool. The delete operation is irreversible. Proceed with caution. After the tool is deleted, all Agents that reference this tool will no longer be able to use it.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteToolResponse
        /// </returns>
        public async Task<DeleteToolResponse> DeleteToolWithOptionsAsync(string toolName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTool",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(toolName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteToolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a tool</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the specified tool. The delete operation is irreversible. Proceed with caution. After the tool is deleted, all Agents that reference this tool will no longer be able to use it.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteToolResponse
        /// </returns>
        public DeleteToolResponse DeleteTool(string toolName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteToolWithOptions(toolName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a tool</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete the specified tool. The delete operation is irreversible. Proceed with caution. After the tool is deleted, all Agents that reference this tool will no longer be able to use it.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteToolResponse
        /// </returns>
        public async Task<DeleteToolResponse> DeleteToolAsync(string toolName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteToolWithOptionsAsync(toolName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified workspace.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified workspace.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified workspace.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceWithOptions(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes the specified workspace.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceWithOptionsAsync(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains an access token.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtains a temporary accessToken that is used to authenticate subsequent API requests.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public GetAccessTokenResponse GetAccessTokenWithOptions(GetAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessToken",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/accessToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains an access token.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtains a temporary accessToken that is used to authenticate subsequent API requests.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public async Task<GetAccessTokenResponse> GetAccessTokenWithOptionsAsync(GetAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessToken",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/accessToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains an access token.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtains a temporary accessToken that is used to authenticate subsequent API requests.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAccessTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains an access token.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtains a temporary accessToken that is used to authenticate subsequent API requests.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public async Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAccessTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Agent Runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified agent runtime by its agent runtime ID, including configuration, status, resource usage, and more.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentRuntimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentRuntimeResponse
        /// </returns>
        public GetAgentRuntimeResponse GetAgentRuntimeWithOptions(string agentRuntimeId, GetAgentRuntimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentRuntimeVersion))
            {
                query["agentRuntimeVersion"] = request.AgentRuntimeVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentRuntime",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Agent Runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified agent runtime by its agent runtime ID, including configuration, status, resource usage, and more.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentRuntimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentRuntimeResponse
        /// </returns>
        public async Task<GetAgentRuntimeResponse> GetAgentRuntimeWithOptionsAsync(string agentRuntimeId, GetAgentRuntimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentRuntimeVersion))
            {
                query["agentRuntimeVersion"] = request.AgentRuntimeVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentRuntime",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Agent Runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified agent runtime by its agent runtime ID, including configuration, status, resource usage, and more.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentRuntimeResponse
        /// </returns>
        public GetAgentRuntimeResponse GetAgentRuntime(string agentRuntimeId, GetAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentRuntimeWithOptions(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Agent Runtime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified agent runtime by its agent runtime ID, including configuration, status, resource usage, and more.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentRuntimeResponse
        /// </returns>
        public async Task<GetAgentRuntimeResponse> GetAgentRuntimeAsync(string agentRuntimeId, GetAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentRuntimeWithOptionsAsync(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Agent Runtime Access Endpoint</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentRuntimeEndpointResponse
        /// </returns>
        public GetAgentRuntimeEndpointResponse GetAgentRuntimeEndpointWithOptions(string agentRuntimeId, string agentRuntimeEndpointId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentRuntimeEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeEndpointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentRuntimeEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Agent Runtime Access Endpoint</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentRuntimeEndpointResponse
        /// </returns>
        public async Task<GetAgentRuntimeEndpointResponse> GetAgentRuntimeEndpointWithOptionsAsync(string agentRuntimeId, string agentRuntimeEndpointId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentRuntimeEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeEndpointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentRuntimeEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Agent Runtime Access Endpoint</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAgentRuntimeEndpointResponse
        /// </returns>
        public GetAgentRuntimeEndpointResponse GetAgentRuntimeEndpoint(string agentRuntimeId, string agentRuntimeEndpointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentRuntimeEndpointWithOptions(agentRuntimeId, agentRuntimeEndpointId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Agent Runtime Access Endpoint</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAgentRuntimeEndpointResponse
        /// </returns>
        public async Task<GetAgentRuntimeEndpointResponse> GetAgentRuntimeEndpointAsync(string agentRuntimeId, string agentRuntimeEndpointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentRuntimeEndpointWithOptionsAsync(agentRuntimeId, agentRuntimeEndpointId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetBrowserSandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified browser instance by browser ID, including configuration, status, resource usage, and more.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBrowserResponse
        /// </returns>
        public GetBrowserResponse GetBrowserWithOptions(string browserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBrowser",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/browsers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(browserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBrowserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetBrowserSandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified browser instance by browser ID, including configuration, status, resource usage, and more.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBrowserResponse
        /// </returns>
        public async Task<GetBrowserResponse> GetBrowserWithOptionsAsync(string browserId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBrowser",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/browsers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(browserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBrowserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetBrowserSandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified browser instance by browser ID, including configuration, status, resource usage, and more.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetBrowserResponse
        /// </returns>
        public GetBrowserResponse GetBrowser(string browserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBrowserWithOptions(browserId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetBrowserSandbox</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified browser instance by browser ID, including configuration, status, resource usage, and more.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetBrowserResponse
        /// </returns>
        public async Task<GetBrowserResponse> GetBrowserAsync(string browserId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBrowserWithOptionsAsync(browserId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an interpreter.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据代码解释器ID获取指定代码解释器实例的详细信息，包括配置、状态、资源使用情况等。</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCodeInterpreterResponse
        /// </returns>
        public GetCodeInterpreterResponse GetCodeInterpreterWithOptions(string codeInterpreterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeInterpreter",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/code-interpreters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(codeInterpreterId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeInterpreterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an interpreter.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据代码解释器ID获取指定代码解释器实例的详细信息，包括配置、状态、资源使用情况等。</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCodeInterpreterResponse
        /// </returns>
        public async Task<GetCodeInterpreterResponse> GetCodeInterpreterWithOptionsAsync(string codeInterpreterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeInterpreter",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/code-interpreters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(codeInterpreterId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeInterpreterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an interpreter.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据代码解释器ID获取指定代码解释器实例的详细信息，包括配置、状态、资源使用情况等。</para>
        /// </description>
        /// 
        /// <returns>
        /// GetCodeInterpreterResponse
        /// </returns>
        public GetCodeInterpreterResponse GetCodeInterpreter(string codeInterpreterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCodeInterpreterWithOptions(codeInterpreterId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an interpreter.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据代码解释器ID获取指定代码解释器实例的详细信息，包括配置、状态、资源使用情况等。</para>
        /// </description>
        /// 
        /// <returns>
        /// GetCodeInterpreterResponse
        /// </returns>
        public async Task<GetCodeInterpreterResponse> GetCodeInterpreterAsync(string codeInterpreterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCodeInterpreterWithOptionsAsync(codeInterpreterId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a specific credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified credential, including its configuration, metadata, and related resources.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public GetCredentialResponse GetCredentialWithOptions(string credentialName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCredential",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a specific credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified credential, including its configuration, metadata, and related resources.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public async Task<GetCredentialResponse> GetCredentialWithOptionsAsync(string credentialName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCredential",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a specific credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified credential, including its configuration, metadata, and related resources.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public GetCredentialResponse GetCredential(string credentialName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCredentialWithOptions(credentialName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a specific credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves detailed information about a specified credential, including its configuration, metadata, and related resources.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public async Task<GetCredentialResponse> GetCredentialAsync(string credentialName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCredentialWithOptionsAsync(credentialName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration of a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomDomainResponse
        /// </returns>
        public GetCustomDomainResponse GetCustomDomainWithOptions(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomDomain",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration of a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomDomainResponse
        /// </returns>
        public async Task<GetCustomDomainResponse> GetCustomDomainWithOptionsAsync(string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomDomain",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration of a custom domain.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCustomDomainResponse
        /// </returns>
        public GetCustomDomainResponse GetCustomDomain(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCustomDomainWithOptions(domainName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration of a custom domain.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCustomDomainResponse
        /// </returns>
        public async Task<GetCustomDomainResponse> GetCustomDomainAsync(string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCustomDomainWithOptionsAsync(domainName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get flow details</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据工作流ID获取指定工作流的详细信息，包括配置、定义、版本信息等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowResponse
        /// </returns>
        public GetFlowResponse GetFlowWithOptions(string flowName, GetFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlow",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get flow details</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据工作流ID获取指定工作流的详细信息，包括配置、定义、版本信息等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowResponse
        /// </returns>
        public async Task<GetFlowResponse> GetFlowWithOptionsAsync(string flowName, GetFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlow",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get flow details</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据工作流ID获取指定工作流的详细信息，包括配置、定义、版本信息等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowResponse
        /// </returns>
        public GetFlowResponse GetFlow(string flowName, GetFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFlowWithOptions(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get flow details</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据工作流ID获取指定工作流的详细信息，包括配置、定义、版本信息等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowResponse
        /// </returns>
        public async Task<GetFlowResponse> GetFlowAsync(string flowName, GetFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFlowWithOptionsAsync(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the workflow draft.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取指定工作流的草稿版本，返回草稿中的配置信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowDraftRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowDraftResponse
        /// </returns>
        public GetFlowDraftResponse GetFlowDraftWithOptions(string flowName, GetFlowDraftRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowDraft",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/draft",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowDraftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the workflow draft.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取指定工作流的草稿版本，返回草稿中的配置信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowDraftRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowDraftResponse
        /// </returns>
        public async Task<GetFlowDraftResponse> GetFlowDraftWithOptionsAsync(string flowName, GetFlowDraftRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowDraft",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/draft",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the workflow draft.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取指定工作流的草稿版本，返回草稿中的配置信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowDraftResponse
        /// </returns>
        public GetFlowDraftResponse GetFlowDraft(string flowName, GetFlowDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFlowDraftWithOptions(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the workflow draft.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取指定工作流的草稿版本，返回草稿中的配置信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowDraftResponse
        /// </returns>
        public async Task<GetFlowDraftResponse> GetFlowDraftAsync(string flowName, GetFlowDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFlowDraftWithOptionsAsync(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a workflow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据工作流ID和端点ID获取指定工作流端点的详细信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowEndpointResponse
        /// </returns>
        public GetFlowEndpointResponse GetFlowEndpointWithOptions(string flowName, string flowEndpointName, GetFlowEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowEndpointName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a workflow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据工作流ID和端点ID获取指定工作流端点的详细信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowEndpointResponse
        /// </returns>
        public async Task<GetFlowEndpointResponse> GetFlowEndpointWithOptionsAsync(string flowName, string flowEndpointName, GetFlowEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowEndpointName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a workflow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据工作流ID和端点ID获取指定工作流端点的详细信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowEndpointResponse
        /// </returns>
        public GetFlowEndpointResponse GetFlowEndpoint(string flowName, string flowEndpointName, GetFlowEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFlowEndpointWithOptions(flowName, flowEndpointName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a workflow endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据工作流ID和端点ID获取指定工作流端点的详细信息。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowEndpointResponse
        /// </returns>
        public async Task<GetFlowEndpointResponse> GetFlowEndpointAsync(string flowName, string flowEndpointName, GetFlowEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFlowEndpointWithOptionsAsync(flowName, flowEndpointName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific workflow version, including a complete configuration snapshot of its definition, environment variables, tracing configuration, and logging configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowVersionResponse
        /// </returns>
        public GetFlowVersionResponse GetFlowVersionWithOptions(string flowName, string flowVersion, GetFlowVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowVersion",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific workflow version, including a complete configuration snapshot of its definition, environment variables, tracing configuration, and logging configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowVersionResponse
        /// </returns>
        public async Task<GetFlowVersionResponse> GetFlowVersionWithOptionsAsync(string flowName, string flowVersion, GetFlowVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowVersion",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific workflow version, including a complete configuration snapshot of its definition, environment variables, tracing configuration, and logging configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowVersionResponse
        /// </returns>
        public GetFlowVersionResponse GetFlowVersion(string flowName, string flowVersion, GetFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFlowVersionWithOptions(flowName, flowVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific workflow version, including a complete configuration snapshot of its definition, environment variables, tracing configuration, and logging configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowVersionResponse
        /// </returns>
        public async Task<GetFlowVersionResponse> GetFlowVersionAsync(string flowName, string flowVersion, GetFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFlowVersionWithOptionsAsync(flowName, flowVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the details of a specific IM Bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /2025-09-10/agents/im-bots/{imBotId}；200 OK，Body 标准包装，data 为 IMBotInfo</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIMBotRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIMBotResponse
        /// </returns>
        public GetIMBotResponse GetIMBotWithOptions(string imBotId, GetIMBotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIMBot",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imBotId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIMBotResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the details of a specific IM Bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /2025-09-10/agents/im-bots/{imBotId}；200 OK，Body 标准包装，data 为 IMBotInfo</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIMBotRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIMBotResponse
        /// </returns>
        public async Task<GetIMBotResponse> GetIMBotWithOptionsAsync(string imBotId, GetIMBotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIMBot",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imBotId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIMBotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the details of a specific IM Bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /2025-09-10/agents/im-bots/{imBotId}；200 OK，Body 标准包装，data 为 IMBotInfo</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIMBotRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIMBotResponse
        /// </returns>
        public GetIMBotResponse GetIMBot(string imBotId, GetIMBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIMBotWithOptions(imBotId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the details of a specific IM Bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /2025-09-10/agents/im-bots/{imBotId}；200 OK，Body 标准包装，data 为 IMBotInfo</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetIMBotRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIMBotResponse
        /// </returns>
        public async Task<GetIMBotResponse> GetIMBotAsync(string imBotId, GetIMBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIMBotWithOptionsAsync(imBotId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets information about a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public GetKnowledgeBaseResponse GetKnowledgeBaseWithOptions(string knowledgeBaseName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBase",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets information about a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public async Task<GetKnowledgeBaseResponse> GetKnowledgeBaseWithOptionsAsync(string knowledgeBaseName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBase",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets information about a knowledge base.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public GetKnowledgeBaseResponse GetKnowledgeBase(string knowledgeBaseName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKnowledgeBaseWithOptions(knowledgeBaseName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets information about a knowledge base.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public async Task<GetKnowledgeBaseResponse> GetKnowledgeBaseAsync(string knowledgeBaseName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKnowledgeBaseWithOptionsAsync(knowledgeBaseName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specific memory collection.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryCollectionResponse
        /// </returns>
        public GetMemoryCollectionResponse GetMemoryCollectionWithOptions(string memoryCollectionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryCollection",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryCollectionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryCollectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specific memory collection.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemoryCollectionResponse
        /// </returns>
        public async Task<GetMemoryCollectionResponse> GetMemoryCollectionWithOptionsAsync(string memoryCollectionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryCollection",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryCollectionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specific memory collection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMemoryCollectionResponse
        /// </returns>
        public GetMemoryCollectionResponse GetMemoryCollection(string memoryCollectionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryCollectionWithOptions(memoryCollectionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specific memory collection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMemoryCollectionResponse
        /// </returns>
        public async Task<GetMemoryCollectionResponse> GetMemoryCollectionAsync(string memoryCollectionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryCollectionWithOptionsAsync(memoryCollectionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves model governance information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the configuration details of a specific model proxy.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelProxyResponse
        /// </returns>
        public GetModelProxyResponse GetModelProxyWithOptions(string modelProxyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelProxy",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelProxyName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelProxyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves model governance information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the configuration details of a specific model proxy.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelProxyResponse
        /// </returns>
        public async Task<GetModelProxyResponse> GetModelProxyWithOptionsAsync(string modelProxyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelProxy",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelProxyName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves model governance information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the configuration details of a specific model proxy.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetModelProxyResponse
        /// </returns>
        public GetModelProxyResponse GetModelProxy(string modelProxyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelProxyWithOptions(modelProxyName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves model governance information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the configuration details of a specific model proxy.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetModelProxyResponse
        /// </returns>
        public async Task<GetModelProxyResponse> GetModelProxyAsync(string modelProxyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelProxyWithOptionsAsync(modelProxyName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified model service.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelServiceResponse
        /// </returns>
        public GetModelServiceResponse GetModelServiceWithOptions(string modelServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelService",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelServiceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified model service.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelServiceResponse
        /// </returns>
        public async Task<GetModelServiceResponse> GetModelServiceWithOptionsAsync(string modelServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelService",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelServiceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified model service.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetModelServiceResponse
        /// </returns>
        public GetModelServiceResponse GetModelService(string modelServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelServiceWithOptions(modelServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified model service.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetModelServiceResponse
        /// </returns>
        public async Task<GetModelServiceResponse> GetModelServiceAsync(string modelServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelServiceWithOptionsAsync(modelServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific sandbox by its <c>sandboxId</c>, including its status and configuration.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSandboxResponse
        /// </returns>
        public GetSandboxResponse GetSandboxWithOptions(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSandboxResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific sandbox by its <c>sandboxId</c>, including its status and configuration.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSandboxResponse
        /// </returns>
        public async Task<GetSandboxResponse> GetSandboxWithOptionsAsync(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSandboxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific sandbox by its <c>sandboxId</c>, including its status and configuration.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetSandboxResponse
        /// </returns>
        public GetSandboxResponse GetSandbox(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSandboxWithOptions(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific sandbox by its <c>sandboxId</c>, including its status and configuration.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetSandboxResponse
        /// </returns>
        public async Task<GetSandboxResponse> GetSandboxAsync(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSandboxWithOptionsAsync(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a template by its name. The response includes the template\&quot;s configuration and status.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplateWithOptions(string templateName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a template by its name. The response includes the template\&quot;s configuration and status.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(string templateName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a template by its name. The response includes the template\&quot;s configuration and status.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplate(string templateName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateWithOptions(templateName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a template by its name. The response includes the template\&quot;s configuration and status.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateAsync(string templateName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateWithOptionsAsync(templateName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get a tool</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtain the complete configuration information of a tool by its name, including basic information, resource configuration, network configuration, running status, and all other detailed information.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetToolResponse
        /// </returns>
        public GetToolResponse GetToolWithOptions(string toolName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTool",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(toolName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetToolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get a tool</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtain the complete configuration information of a tool by its name, including basic information, resource configuration, network configuration, running status, and all other detailed information.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetToolResponse
        /// </returns>
        public async Task<GetToolResponse> GetToolWithOptionsAsync(string toolName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTool",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(toolName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetToolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get a tool</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtain the complete configuration information of a tool by its name, including basic information, resource configuration, network configuration, running status, and all other detailed information.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetToolResponse
        /// </returns>
        public GetToolResponse GetTool(string toolName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetToolWithOptions(toolName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get a tool</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtain the complete configuration information of a tool by its name, including basic information, resource configuration, network configuration, running status, and all other detailed information.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetToolResponse
        /// </returns>
        public async Task<GetToolResponse> GetToolAsync(string toolName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetToolWithOptionsAsync(toolName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific workspace.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific workspace.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific workspace.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceWithOptions(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specific workspace.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceWithOptionsAsync(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the discovery endpoints for a workspace.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceDiscoveryEndpointsResponse
        /// </returns>
        public GetWorkspaceDiscoveryEndpointsResponse GetWorkspaceDiscoveryEndpointsWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspaceDiscoveryEndpoints",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/discovery/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceDiscoveryEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the discovery endpoints for a workspace.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceDiscoveryEndpointsResponse
        /// </returns>
        public async Task<GetWorkspaceDiscoveryEndpointsResponse> GetWorkspaceDiscoveryEndpointsWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspaceDiscoveryEndpoints",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/discovery/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceDiscoveryEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the discovery endpoints for a workspace.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWorkspaceDiscoveryEndpointsResponse
        /// </returns>
        public GetWorkspaceDiscoveryEndpointsResponse GetWorkspaceDiscoveryEndpoints(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceDiscoveryEndpointsWithOptions(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the discovery endpoints for a workspace.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWorkspaceDiscoveryEndpointsResponse
        /// </returns>
        public async Task<GetWorkspaceDiscoveryEndpointsResponse> GetWorkspaceDiscoveryEndpointsAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceDiscoveryEndpointsWithOptionsAsync(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Agent Runtime Endpoints</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取指定智能体运行时的所有端点列表，支持按名称过滤和分页查询。端点用于外部系统访问智能体运行时服务。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentRuntimeEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimeEndpointsResponse
        /// </returns>
        public ListAgentRuntimeEndpointsResponse ListAgentRuntimeEndpointsWithOptions(string agentRuntimeId, ListAgentRuntimeEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointName))
            {
                query["endpointName"] = request.EndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["searchMode"] = request.SearchMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentRuntimeEndpoints",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentRuntimeEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Agent Runtime Endpoints</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取指定智能体运行时的所有端点列表，支持按名称过滤和分页查询。端点用于外部系统访问智能体运行时服务。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentRuntimeEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimeEndpointsResponse
        /// </returns>
        public async Task<ListAgentRuntimeEndpointsResponse> ListAgentRuntimeEndpointsWithOptionsAsync(string agentRuntimeId, ListAgentRuntimeEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointName))
            {
                query["endpointName"] = request.EndpointName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["searchMode"] = request.SearchMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentRuntimeEndpoints",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentRuntimeEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Agent Runtime Endpoints</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取指定智能体运行时的所有端点列表，支持按名称过滤和分页查询。端点用于外部系统访问智能体运行时服务。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentRuntimeEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimeEndpointsResponse
        /// </returns>
        public ListAgentRuntimeEndpointsResponse ListAgentRuntimeEndpoints(string agentRuntimeId, ListAgentRuntimeEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentRuntimeEndpointsWithOptions(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Agent Runtime Endpoints</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取指定智能体运行时的所有端点列表，支持按名称过滤和分页查询。端点用于外部系统访问智能体运行时服务。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentRuntimeEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimeEndpointsResponse
        /// </returns>
        public async Task<ListAgentRuntimeEndpointsResponse> ListAgentRuntimeEndpointsAsync(string agentRuntimeId, ListAgentRuntimeEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentRuntimeEndpointsWithOptionsAsync(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves agent runtime versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentRuntimeVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimeVersionsResponse
        /// </returns>
        public ListAgentRuntimeVersionsResponse ListAgentRuntimeVersionsWithOptions(string agentRuntimeId, ListAgentRuntimeVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentRuntimeVersions",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentRuntimeVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves agent runtime versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentRuntimeVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimeVersionsResponse
        /// </returns>
        public async Task<ListAgentRuntimeVersionsResponse> ListAgentRuntimeVersionsWithOptionsAsync(string agentRuntimeId, ListAgentRuntimeVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentRuntimeVersions",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentRuntimeVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves agent runtime versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentRuntimeVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimeVersionsResponse
        /// </returns>
        public ListAgentRuntimeVersionsResponse ListAgentRuntimeVersions(string agentRuntimeId, ListAgentRuntimeVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentRuntimeVersionsWithOptions(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves agent runtime versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentRuntimeVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimeVersionsResponse
        /// </returns>
        public async Task<ListAgentRuntimeVersionsResponse> ListAgentRuntimeVersionsAsync(string agentRuntimeId, ListAgentRuntimeVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentRuntimeVersionsWithOptionsAsync(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent runtimes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of agent runtimes for the current user. You can filter the results based on criteria such as name and tags. This operation supports pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentRuntimesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimesResponse
        /// </returns>
        public ListAgentRuntimesResponse ListAgentRuntimesWithOptions(ListAgentRuntimesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentRuntimeName))
            {
                query["agentRuntimeName"] = request.AgentRuntimeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryResourceGroupId))
            {
                query["discoveryResourceGroupId"] = request.DiscoveryResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["searchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemTags))
            {
                query["systemTags"] = request.SystemTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentRuntimes",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentRuntimesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent runtimes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of agent runtimes for the current user. You can filter the results based on criteria such as name and tags. This operation supports pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentRuntimesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimesResponse
        /// </returns>
        public async Task<ListAgentRuntimesResponse> ListAgentRuntimesWithOptionsAsync(ListAgentRuntimesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentRuntimeName))
            {
                query["agentRuntimeName"] = request.AgentRuntimeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryResourceGroupId))
            {
                query["discoveryResourceGroupId"] = request.DiscoveryResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["searchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemTags))
            {
                query["systemTags"] = request.SystemTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentRuntimes",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentRuntimesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent runtimes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of agent runtimes for the current user. You can filter the results based on criteria such as name and tags. This operation supports pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentRuntimesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimesResponse
        /// </returns>
        public ListAgentRuntimesResponse ListAgentRuntimes(ListAgentRuntimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentRuntimesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent runtimes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of agent runtimes for the current user. You can filter the results based on criteria such as name and tags. This operation supports pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentRuntimesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentRuntimesResponse
        /// </returns>
        public async Task<ListAgentRuntimesResponse> ListAgentRuntimesAsync(ListAgentRuntimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentRuntimesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Browser Sandboxes</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of all browser instances for the current user. Supports filtering by conditions such as name and status, and supports paginated queries.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBrowsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBrowsersResponse
        /// </returns>
        public ListBrowsersResponse ListBrowsersWithOptions(ListBrowsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserName))
            {
                query["browserName"] = request.BrowserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBrowsers",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/browsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBrowsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Browser Sandboxes</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of all browser instances for the current user. Supports filtering by conditions such as name and status, and supports paginated queries.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBrowsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBrowsersResponse
        /// </returns>
        public async Task<ListBrowsersResponse> ListBrowsersWithOptionsAsync(ListBrowsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserName))
            {
                query["browserName"] = request.BrowserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBrowsers",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/browsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBrowsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Browser Sandboxes</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of all browser instances for the current user. Supports filtering by conditions such as name and status, and supports paginated queries.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBrowsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBrowsersResponse
        /// </returns>
        public ListBrowsersResponse ListBrowsers(ListBrowsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBrowsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Browser Sandboxes</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of all browser instances for the current user. Supports filtering by conditions such as name and status, and supports paginated queries.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListBrowsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBrowsersResponse
        /// </returns>
        public async Task<ListBrowsersResponse> ListBrowsersAsync(ListBrowsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBrowsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Code Interpreters</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve a list of all code interpreter instances for the current user, with support for filtering by name and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCodeInterpretersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCodeInterpretersResponse
        /// </returns>
        public ListCodeInterpretersResponse ListCodeInterpretersWithOptions(ListCodeInterpretersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeInterpreterName))
            {
                query["codeInterpreterName"] = request.CodeInterpreterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCodeInterpreters",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/code-interpreters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCodeInterpretersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Code Interpreters</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve a list of all code interpreter instances for the current user, with support for filtering by name and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCodeInterpretersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCodeInterpretersResponse
        /// </returns>
        public async Task<ListCodeInterpretersResponse> ListCodeInterpretersWithOptionsAsync(ListCodeInterpretersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeInterpreterName))
            {
                query["codeInterpreterName"] = request.CodeInterpreterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCodeInterpreters",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/code-interpreters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCodeInterpretersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Code Interpreters</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve a list of all code interpreter instances for the current user, with support for filtering by name and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCodeInterpretersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCodeInterpretersResponse
        /// </returns>
        public ListCodeInterpretersResponse ListCodeInterpreters(ListCodeInterpretersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCodeInterpretersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Code Interpreters</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve a list of all code interpreter instances for the current user, with support for filtering by name and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCodeInterpretersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCodeInterpretersResponse
        /// </returns>
        public async Task<ListCodeInterpretersResponse> ListCodeInterpretersAsync(ListCodeInterpretersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCodeInterpretersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all credentials.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the credentials in your account. This operation supports filtering and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public ListCredentialsResponse ListCredentialsWithOptions(ListCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialAuthType))
            {
                query["credentialAuthType"] = request.CredentialAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialName))
            {
                query["credentialName"] = request.CredentialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialSourceType))
            {
                query["credentialSourceType"] = request.CredentialSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCredentials",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all credentials.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the credentials in your account. This operation supports filtering and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public async Task<ListCredentialsResponse> ListCredentialsWithOptionsAsync(ListCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialAuthType))
            {
                query["credentialAuthType"] = request.CredentialAuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialName))
            {
                query["credentialName"] = request.CredentialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialSourceType))
            {
                query["credentialSourceType"] = request.CredentialSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCredentials",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all credentials.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the credentials in your account. This operation supports filtering and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public ListCredentialsResponse ListCredentials(ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCredentialsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all credentials.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the credentials in your account. This operation supports filtering and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public async Task<ListCredentialsResponse> ListCredentialsAsync(ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCredentialsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists custom domains.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomDomainsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomDomainsResponse
        /// </returns>
        public ListCustomDomainsResponse ListCustomDomainsWithOptions(ListCustomDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["domainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomDomains",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists custom domains.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomDomainsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomDomainsResponse
        /// </returns>
        public async Task<ListCustomDomainsResponse> ListCustomDomainsWithOptionsAsync(ListCustomDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["domainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomDomains",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists custom domains.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomDomainsResponse
        /// </returns>
        public ListCustomDomainsResponse ListCustomDomains(ListCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCustomDomainsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists custom domains.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomDomainsResponse
        /// </returns>
        public async Task<ListCustomDomainsResponse> ListCustomDomainsAsync(ListCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCustomDomainsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List workflow endpoints.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve all endpoints for a specified workflow, with pagination support.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowEndpointsResponse
        /// </returns>
        public ListFlowEndpointsResponse ListFlowEndpointsWithOptions(string flowId, ListFlowEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowEndpoints",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowId) + "/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List workflow endpoints.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve all endpoints for a specified workflow, with pagination support.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowEndpointsResponse
        /// </returns>
        public async Task<ListFlowEndpointsResponse> ListFlowEndpointsWithOptionsAsync(string flowId, ListFlowEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowEndpoints",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowId) + "/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List workflow endpoints.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve all endpoints for a specified workflow, with pagination support.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowEndpointsResponse
        /// </returns>
        public ListFlowEndpointsResponse ListFlowEndpoints(string flowId, ListFlowEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowEndpointsWithOptions(flowId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List workflow endpoints.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieve all endpoints for a specified workflow, with pagination support.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowEndpointsResponse
        /// </returns>
        public async Task<ListFlowEndpointsResponse> ListFlowEndpointsAsync(string flowId, ListFlowEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowEndpointsWithOptionsAsync(flowId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the versions of a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns a paginated list of all versions for a specified flow.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowVersionsResponse
        /// </returns>
        public ListFlowVersionsResponse ListFlowVersionsWithOptions(string flowName, ListFlowVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowVersions",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the versions of a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns a paginated list of all versions for a specified flow.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowVersionsResponse
        /// </returns>
        public async Task<ListFlowVersionsResponse> ListFlowVersionsWithOptionsAsync(string flowName, ListFlowVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowVersions",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the versions of a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns a paginated list of all versions for a specified flow.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowVersionsResponse
        /// </returns>
        public ListFlowVersionsResponse ListFlowVersions(string flowName, ListFlowVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowVersionsWithOptions(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the versions of a flow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns a paginated list of all versions for a specified flow.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowVersionsResponse
        /// </returns>
        public async Task<ListFlowVersionsResponse> ListFlowVersionsAsync(string flowName, ListFlowVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowVersionsWithOptionsAsync(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List flows</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的工作流列表，支持按名称、工作空间等条件过滤，支持分页查询。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowsResponse
        /// </returns>
        public ListFlowsResponse ListFlowsWithOptions(ListFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["flowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlows",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List flows</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的工作流列表，支持按名称、工作空间等条件过滤，支持分页查询。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowsResponse
        /// </returns>
        public async Task<ListFlowsResponse> ListFlowsWithOptionsAsync(ListFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["flowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlows",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List flows</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的工作流列表，支持按名称、工作空间等条件过滤，支持分页查询。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowsResponse
        /// </returns>
        public ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List flows</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的工作流列表，支持按名称、工作空间等条件过滤，支持分页查询。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowsResponse
        /// </returns>
        public async Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of IM bots.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Send a GET request to the <c>/2025-09-10/agents/im-bots</c> endpoint to retrieve a paginated list of IM bots. Use the <c>botName</c>, <c>agentRuntimeId</c>, <c>botBizType</c>, and <c>status</c> query parameters to filter the results. For pagination, the <c>pageNumber</c> defaults to 1 and the <c>pageSize</c> defaults to 20, with a maximum of 100.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIMBotsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIMBotsResponse
        /// </returns>
        public ListIMBotsResponse ListIMBotsWithOptions(ListIMBotsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentRuntimeId))
            {
                query["agentRuntimeId"] = request.AgentRuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotBizType))
            {
                query["botBizType"] = request.BotBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotName))
            {
                query["botName"] = request.BotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIMBots",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIMBotsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of IM bots.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Send a GET request to the <c>/2025-09-10/agents/im-bots</c> endpoint to retrieve a paginated list of IM bots. Use the <c>botName</c>, <c>agentRuntimeId</c>, <c>botBizType</c>, and <c>status</c> query parameters to filter the results. For pagination, the <c>pageNumber</c> defaults to 1 and the <c>pageSize</c> defaults to 20, with a maximum of 100.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIMBotsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIMBotsResponse
        /// </returns>
        public async Task<ListIMBotsResponse> ListIMBotsWithOptionsAsync(ListIMBotsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentRuntimeId))
            {
                query["agentRuntimeId"] = request.AgentRuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotBizType))
            {
                query["botBizType"] = request.BotBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BotName))
            {
                query["botName"] = request.BotName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIMBots",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIMBotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of IM bots.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Send a GET request to the <c>/2025-09-10/agents/im-bots</c> endpoint to retrieve a paginated list of IM bots. Use the <c>botName</c>, <c>agentRuntimeId</c>, <c>botBizType</c>, and <c>status</c> query parameters to filter the results. For pagination, the <c>pageNumber</c> defaults to 1 and the <c>pageSize</c> defaults to 20, with a maximum of 100.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIMBotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIMBotsResponse
        /// </returns>
        public ListIMBotsResponse ListIMBots(ListIMBotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIMBotsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of IM bots.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Send a GET request to the <c>/2025-09-10/agents/im-bots</c> endpoint to retrieve a paginated list of IM bots. Use the <c>botName</c>, <c>agentRuntimeId</c>, <c>botBizType</c>, and <c>status</c> query parameters to filter the results. For pagination, the <c>pageNumber</c> defaults to 1 and the <c>pageSize</c> defaults to 20, with a maximum of 100.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIMBotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIMBotsResponse
        /// </returns>
        public async Task<ListIMBotsResponse> ListIMBotsAsync(ListIMBotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIMBotsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the knowledge bases in your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public ListKnowledgeBasesResponse ListKnowledgeBasesWithOptions(ListKnowledgeBasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBases",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the knowledge bases in your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public async Task<ListKnowledgeBasesResponse> ListKnowledgeBasesWithOptionsAsync(ListKnowledgeBasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBases",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the knowledge bases in your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKnowledgeBasesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the knowledge bases in your account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public async Task<ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKnowledgeBasesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a paginated list of memory collections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryCollectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryCollectionsResponse
        /// </returns>
        public ListMemoryCollectionsResponse ListMemoryCollectionsWithOptions(ListMemoryCollectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryCollectionName))
            {
                query["memoryCollectionName"] = request.MemoryCollectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemoryCollections",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoryCollectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a paginated list of memory collections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryCollectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryCollectionsResponse
        /// </returns>
        public async Task<ListMemoryCollectionsResponse> ListMemoryCollectionsWithOptionsAsync(ListMemoryCollectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryCollectionName))
            {
                query["memoryCollectionName"] = request.MemoryCollectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMemoryCollections",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoryCollectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a paginated list of memory collections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryCollectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryCollectionsResponse
        /// </returns>
        public ListMemoryCollectionsResponse ListMemoryCollections(ListMemoryCollectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMemoryCollectionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a paginated list of memory collections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMemoryCollectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMemoryCollectionsResponse
        /// </returns>
        public async Task<ListMemoryCollectionsResponse> ListMemoryCollectionsAsync(ListMemoryCollectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMemoryCollectionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all model providers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the available model providers. This operation supports filtering and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProvidersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProvidersResponse
        /// </returns>
        public ListModelProvidersResponse ListModelProvidersWithOptions(ListModelProvidersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["modelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProviders",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-providers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all model providers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the available model providers. This operation supports filtering and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProvidersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProvidersResponse
        /// </returns>
        public async Task<ListModelProvidersResponse> ListModelProvidersWithOptionsAsync(ListModelProvidersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["modelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProviders",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-providers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all model providers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the available model providers. This operation supports filtering and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProvidersResponse
        /// </returns>
        public ListModelProvidersResponse ListModelProviders(ListModelProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelProvidersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all model providers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the available model providers. This operation supports filtering and pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProvidersResponse
        /// </returns>
        public async Task<ListModelProvidersResponse> ListModelProvidersAsync(ListModelProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelProvidersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all Model Proxies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a paginated list of all Model Proxies for the current user. You can filter the list by status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProxiesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProxiesResponse
        /// </returns>
        public ListModelProxiesResponse ListModelProxiesWithOptions(ListModelProxiesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyMode))
            {
                query["proxyMode"] = request.ProxyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProxies",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProxiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all Model Proxies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a paginated list of all Model Proxies for the current user. You can filter the list by status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProxiesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelProxiesResponse
        /// </returns>
        public async Task<ListModelProxiesResponse> ListModelProxiesWithOptionsAsync(ListModelProxiesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyMode))
            {
                query["proxyMode"] = request.ProxyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelProxies",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelProxiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all Model Proxies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a paginated list of all Model Proxies for the current user. You can filter the list by status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProxiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProxiesResponse
        /// </returns>
        public ListModelProxiesResponse ListModelProxies(ListModelProxiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelProxiesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all Model Proxies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a paginated list of all Model Proxies for the current user. You can filter the list by status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelProxiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelProxiesResponse
        /// </returns>
        public async Task<ListModelProxiesResponse> ListModelProxiesAsync(ListModelProxiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelProxiesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all models.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of all models for the current user. You can filter the models by type and paginate the results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelServicesResponse
        /// </returns>
        public ListModelServicesResponse ListModelServicesWithOptions(ListModelServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderType))
            {
                query["providerType"] = request.ProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelServices",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all models.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of all models for the current user. You can filter the models by type and paginate the results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelServicesResponse
        /// </returns>
        public async Task<ListModelServicesResponse> ListModelServicesWithOptionsAsync(ListModelServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderType))
            {
                query["providerType"] = request.ProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelServices",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all models.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of all models for the current user. You can filter the models by type and paginate the results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelServicesResponse
        /// </returns>
        public ListModelServicesResponse ListModelServices(ListModelServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelServicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all models.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of all models for the current user. You can filter the models by type and paginate the results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelServicesResponse
        /// </returns>
        public async Task<ListModelServicesResponse> ListModelServicesAsync(ListModelServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelServicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a list of sandboxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of sandboxes for the current user. You can filter the results by template name, template type, or status. This operation supports pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSandboxesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSandboxesResponse
        /// </returns>
        public ListSandboxesResponse ListSandboxesWithOptions(ListSandboxesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxId))
            {
                query["sandboxId"] = request.SandboxId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["templateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSandboxes",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSandboxesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a list of sandboxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of sandboxes for the current user. You can filter the results by template name, template type, or status. This operation supports pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSandboxesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSandboxesResponse
        /// </returns>
        public async Task<ListSandboxesResponse> ListSandboxesWithOptionsAsync(ListSandboxesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SandboxId))
            {
                query["sandboxId"] = request.SandboxId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["templateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSandboxes",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSandboxesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a list of sandboxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of sandboxes for the current user. You can filter the results by template name, template type, or status. This operation supports pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSandboxesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSandboxesResponse
        /// </returns>
        public ListSandboxesResponse ListSandboxes(ListSandboxesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSandboxesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a list of sandboxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of sandboxes for the current user. You can filter the results by template name, template type, or status. This operation supports pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSandboxesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSandboxesResponse
        /// </returns>
        public async Task<ListSandboxesResponse> ListSandboxesAsync(ListSandboxesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSandboxesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all templates for the current user. You can filter the results by template type and use pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["templateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all templates for the current user. You can filter the results by template type and use pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["templateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all templates for the current user. You can filter the results by template type and use pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all templates for the current user. You can filter the results by template type and use pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List tools</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the tool list. Support paged query and conditional filtering by tool type, workspace, and other criteria. Return the list of tools that meet the conditions and paging information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListToolsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListToolsResponse
        /// </returns>
        public ListToolsResponse ListToolsWithOptions(ListToolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolName))
            {
                query["toolName"] = request.ToolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolType))
            {
                query["toolType"] = request.ToolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTools",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListToolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List tools</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the tool list. Support paged query and conditional filtering by tool type, workspace, and other criteria. Return the list of tools that meet the conditions and paging information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListToolsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListToolsResponse
        /// </returns>
        public async Task<ListToolsResponse> ListToolsWithOptionsAsync(ListToolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolName))
            {
                query["toolName"] = request.ToolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolType))
            {
                query["toolType"] = request.ToolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["workspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTools",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListToolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List tools</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the tool list. Support paged query and conditional filtering by tool type, workspace, and other criteria. Return the list of tools that meet the conditions and paging information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListToolsResponse
        /// </returns>
        public ListToolsResponse ListTools(ListToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListToolsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List tools</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the tool list. Support paged query and conditional filtering by tool type, workspace, and other criteria. Return the list of tools that meet the conditions and paging information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListToolsResponse
        /// </returns>
        public async Task<ListToolsResponse> ListToolsAsync(ListToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListToolsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all workspaces in your account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all workspaces in your account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all workspaces in your account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all workspaces in your account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pause the sandbox and retain snapshots of its memory and file system. The sandbox enters the PAUSED state so that it can be recovered later.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to pause a sandbox. When invoked, the system takes a snapshot of the sandbox, capturing and persisting the memory and disk states. The user can recover the sandbox at a later time.<br>Note that sandbox snapshots are retained for only 30 days. After 30 days, recovery becomes unavailable.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseSandboxResponse
        /// </returns>
        public PauseSandboxResponse PauseSandboxWithOptions(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId) + "/pause",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseSandboxResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pause the sandbox and retain snapshots of its memory and file system. The sandbox enters the PAUSED state so that it can be recovered later.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to pause a sandbox. When invoked, the system takes a snapshot of the sandbox, capturing and persisting the memory and disk states. The user can recover the sandbox at a later time.<br>Note that sandbox snapshots are retained for only 30 days. After 30 days, recovery becomes unavailable.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseSandboxResponse
        /// </returns>
        public async Task<PauseSandboxResponse> PauseSandboxWithOptionsAsync(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId) + "/pause",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseSandboxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pause the sandbox and retain snapshots of its memory and file system. The sandbox enters the PAUSED state so that it can be recovered later.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to pause a sandbox. When invoked, the system takes a snapshot of the sandbox, capturing and persisting the memory and disk states. The user can recover the sandbox at a later time.<br>Note that sandbox snapshots are retained for only 30 days. After 30 days, recovery becomes unavailable.</para>
        /// </description>
        /// 
        /// <returns>
        /// PauseSandboxResponse
        /// </returns>
        public PauseSandboxResponse PauseSandbox(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PauseSandboxWithOptions(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pause the sandbox and retain snapshots of its memory and file system. The sandbox enters the PAUSED state so that it can be recovered later.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API is used to pause a sandbox. When invoked, the system takes a snapshot of the sandbox, capturing and persisting the memory and disk states. The user can recover the sandbox at a later time.<br>Note that sandbox snapshots are retained for only 30 days. After 30 days, recovery becomes unavailable.</para>
        /// </description>
        /// 
        /// <returns>
        /// PauseSandboxResponse
        /// </returns>
        public async Task<PauseSandboxResponse> PauseSandboxAsync(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PauseSandboxWithOptionsAsync(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publishes a new version of a specified workflow. This operation supports version management and rollbacks.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishFlowVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowVersionResponse
        /// </returns>
        public PublishFlowVersionResponse PublishFlowVersionWithOptions(string flowName, PublishFlowVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFlowVersion",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFlowVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publishes a new version of a specified workflow. This operation supports version management and rollbacks.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishFlowVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowVersionResponse
        /// </returns>
        public async Task<PublishFlowVersionResponse> PublishFlowVersionWithOptionsAsync(string flowName, PublishFlowVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFlowVersion",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFlowVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publishes a new version of a specified workflow. This operation supports version management and rollbacks.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowVersionResponse
        /// </returns>
        public PublishFlowVersionResponse PublishFlowVersion(string flowName, PublishFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishFlowVersionWithOptions(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a workflow version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publishes a new version of a specified workflow. This operation supports version management and rollbacks.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishFlowVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowVersionResponse
        /// </returns>
        public async Task<PublishFlowVersionResponse> PublishFlowVersionAsync(string flowName, PublishFlowVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishFlowVersionWithOptionsAsync(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a new version of an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publishes a new version for a specified agent runtime for version management and deployment. The new version can include code updates, configuration changes, and other content.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishRuntimeVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishRuntimeVersionResponse
        /// </returns>
        public PublishRuntimeVersionResponse PublishRuntimeVersionWithOptions(string agentRuntimeId, PublishRuntimeVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishRuntimeVersion",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRuntimeVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a new version of an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publishes a new version for a specified agent runtime for version management and deployment. The new version can include code updates, configuration changes, and other content.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishRuntimeVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishRuntimeVersionResponse
        /// </returns>
        public async Task<PublishRuntimeVersionResponse> PublishRuntimeVersionWithOptionsAsync(string agentRuntimeId, PublishRuntimeVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishRuntimeVersion",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRuntimeVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a new version of an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publishes a new version for a specified agent runtime for version management and deployment. The new version can include code updates, configuration changes, and other content.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishRuntimeVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishRuntimeVersionResponse
        /// </returns>
        public PublishRuntimeVersionResponse PublishRuntimeVersion(string agentRuntimeId, PublishRuntimeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishRuntimeVersionWithOptions(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a new version of an agent runtime.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publishes a new version for a specified agent runtime for version management and deployment. The new version can include code updates, configuration changes, and other content.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishRuntimeVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishRuntimeVersionResponse
        /// </returns>
        public async Task<PublishRuntimeVersionResponse> PublishRuntimeVersionAsync(string agentRuntimeId, PublishRuntimeVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishRuntimeVersionWithOptionsAsync(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resume a paused sandbox instance to restore it from the PAUSED state to the READY (running) state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API resumes a sandbox instance from the paused state to the ready state, allowing the user to invoke it and restore it to the state it was in before being paused.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeSandboxResponse
        /// </returns>
        public ResumeSandboxResponse ResumeSandboxWithOptions(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId) + "/resume",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeSandboxResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resume a paused sandbox instance to restore it from the PAUSED state to the READY (running) state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API resumes a sandbox instance from the paused state to the ready state, allowing the user to invoke it and restore it to the state it was in before being paused.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeSandboxResponse
        /// </returns>
        public async Task<ResumeSandboxResponse> ResumeSandboxWithOptionsAsync(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId) + "/resume",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeSandboxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resume a paused sandbox instance to restore it from the PAUSED state to the READY (running) state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API resumes a sandbox instance from the paused state to the ready state, allowing the user to invoke it and restore it to the state it was in before being paused.</para>
        /// </description>
        /// 
        /// <returns>
        /// ResumeSandboxResponse
        /// </returns>
        public ResumeSandboxResponse ResumeSandbox(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeSandboxWithOptions(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resume a paused sandbox instance to restore it from the PAUSED state to the READY (running) state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API resumes a sandbox instance from the paused state to the ready state, allowing the user to invoke it and restore it to the state it was in before being paused.</para>
        /// </description>
        /// 
        /// <returns>
        /// ResumeSandboxResponse
        /// </returns>
        public async Task<ResumeSandboxResponse> ResumeSandboxAsync(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeSandboxWithOptionsAsync(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops the specified sandbox instance. After the operation, the sandbox enters the TERMINATED state.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopSandboxResponse
        /// </returns>
        public StopSandboxResponse StopSandboxWithOptions(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSandboxResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops the specified sandbox instance. After the operation, the sandbox enters the TERMINATED state.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopSandboxResponse
        /// </returns>
        public async Task<StopSandboxResponse> StopSandboxWithOptionsAsync(string sandboxId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSandbox",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/sandboxes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sandboxId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSandboxResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops the specified sandbox instance. After the operation, the sandbox enters the TERMINATED state.</para>
        /// </description>
        /// 
        /// <returns>
        /// StopSandboxResponse
        /// </returns>
        public StopSandboxResponse StopSandbox(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopSandboxWithOptions(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a sandbox.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops the specified sandbox instance. After the operation, the sandbox enters the TERMINATED state.</para>
        /// </description>
        /// 
        /// <returns>
        /// StopSandboxResponse
        /// </returns>
        public async Task<StopSandboxResponse> StopSandboxAsync(string sandboxId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopSandboxWithOptionsAsync(sandboxId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the TemplateMCP service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stopping the MCP service deletes the associated MCP resources and makes the endpoint inaccessible.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTemplateMCPResponse
        /// </returns>
        public StopTemplateMCPResponse StopTemplateMCPWithOptions(string templateName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTemplateMCP",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName) + "/mcp/stop",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTemplateMCPResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the TemplateMCP service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stopping the MCP service deletes the associated MCP resources and makes the endpoint inaccessible.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTemplateMCPResponse
        /// </returns>
        public async Task<StopTemplateMCPResponse> StopTemplateMCPWithOptionsAsync(string templateName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTemplateMCP",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName) + "/mcp/stop",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTemplateMCPResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the TemplateMCP service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stopping the MCP service deletes the associated MCP resources and makes the endpoint inaccessible.</para>
        /// </description>
        /// 
        /// <returns>
        /// StopTemplateMCPResponse
        /// </returns>
        public StopTemplateMCPResponse StopTemplateMCP(string templateName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTemplateMCPWithOptions(templateName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the TemplateMCP service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stopping the MCP service deletes the associated MCP resources and makes the endpoint inaccessible.</para>
        /// </description>
        /// 
        /// <returns>
        /// StopTemplateMCPResponse
        /// </returns>
        public async Task<StopTemplateMCPResponse> StopTemplateMCPAsync(string templateName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTemplateMCPWithOptionsAsync(templateName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateAgentRuntime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified agent runtime, including resource allocation, network configuration, and environment variables. The update operation triggers a runtime restart.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRuntimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentRuntimeResponse
        /// </returns>
        public UpdateAgentRuntimeResponse UpdateAgentRuntimeWithOptions(string agentRuntimeId, UpdateAgentRuntimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentRuntime",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateAgentRuntime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified agent runtime, including resource allocation, network configuration, and environment variables. The update operation triggers a runtime restart.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRuntimeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentRuntimeResponse
        /// </returns>
        public async Task<UpdateAgentRuntimeResponse> UpdateAgentRuntimeWithOptionsAsync(string agentRuntimeId, UpdateAgentRuntimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentRuntime",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateAgentRuntime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified agent runtime, including resource allocation, network configuration, and environment variables. The update operation triggers a runtime restart.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentRuntimeResponse
        /// </returns>
        public UpdateAgentRuntimeResponse UpdateAgentRuntime(string agentRuntimeId, UpdateAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAgentRuntimeWithOptions(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateAgentRuntime</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified agent runtime, including resource allocation, network configuration, and environment variables. The update operation triggers a runtime restart.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentRuntimeResponse
        /// </returns>
        public async Task<UpdateAgentRuntimeResponse> UpdateAgentRuntimeAsync(string agentRuntimeId, UpdateAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAgentRuntimeWithOptionsAsync(agentRuntimeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Agent Runtime Endpoint</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRuntimeEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentRuntimeEndpointResponse
        /// </returns>
        public UpdateAgentRuntimeEndpointResponse UpdateAgentRuntimeEndpointWithOptions(string agentRuntimeId, string agentRuntimeEndpointId, UpdateAgentRuntimeEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentRuntimeEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeEndpointId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentRuntimeEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Agent Runtime Endpoint</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRuntimeEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentRuntimeEndpointResponse
        /// </returns>
        public async Task<UpdateAgentRuntimeEndpointResponse> UpdateAgentRuntimeEndpointWithOptionsAsync(string agentRuntimeId, string agentRuntimeEndpointId, UpdateAgentRuntimeEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentRuntimeEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/runtimes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeId) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentRuntimeEndpointId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentRuntimeEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Agent Runtime Endpoint</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRuntimeEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentRuntimeEndpointResponse
        /// </returns>
        public UpdateAgentRuntimeEndpointResponse UpdateAgentRuntimeEndpoint(string agentRuntimeId, string agentRuntimeEndpointId, UpdateAgentRuntimeEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAgentRuntimeEndpointWithOptions(agentRuntimeId, agentRuntimeEndpointId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Agent Runtime Endpoint</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRuntimeEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentRuntimeEndpointResponse
        /// </returns>
        public async Task<UpdateAgentRuntimeEndpointResponse> UpdateAgentRuntimeEndpointAsync(string agentRuntimeId, string agentRuntimeEndpointId, UpdateAgentRuntimeEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAgentRuntimeEndpointWithOptionsAsync(agentRuntimeId, agentRuntimeEndpointId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified credential.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public UpdateCredentialResponse UpdateCredentialWithOptions(string credentialName, UpdateCredentialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredential",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified credential.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public async Task<UpdateCredentialResponse> UpdateCredentialWithOptionsAsync(string credentialName, UpdateCredentialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredential",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified credential.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public UpdateCredentialResponse UpdateCredential(string credentialName, UpdateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCredentialWithOptions(credentialName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a credential.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified credential.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public async Task<UpdateCredentialResponse> UpdateCredentialAsync(string credentialName, UpdateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCredentialWithOptionsAsync(credentialName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomDomainResponse
        /// </returns>
        public UpdateCustomDomainResponse UpdateCustomDomainWithOptions(string domainName, UpdateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomDomain",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomDomainResponse
        /// </returns>
        public async Task<UpdateCustomDomainResponse> UpdateCustomDomainWithOptionsAsync(string domainName, UpdateCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomDomain",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomDomainResponse
        /// </returns>
        public UpdateCustomDomainResponse UpdateCustomDomain(string domainName, UpdateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCustomDomainWithOptions(domainName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom domain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomDomainResponse
        /// </returns>
        public async Task<UpdateCustomDomainResponse> UpdateCustomDomainAsync(string domainName, UpdateCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCustomDomainWithOptionsAsync(domainName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified workflow, including the definition, execution mode, and environment variables.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public UpdateFlowResponse UpdateFlowWithOptions(string flowName, UpdateFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlow",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified workflow, including the definition, execution mode, and environment variables.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public async Task<UpdateFlowResponse> UpdateFlowWithOptionsAsync(string flowName, UpdateFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlow",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified workflow, including the definition, execution mode, and environment variables.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public UpdateFlowResponse UpdateFlow(string flowName, UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFlowWithOptions(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workflow.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified workflow, including the definition, execution mode, and environment variables.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public async Task<UpdateFlowResponse> UpdateFlowAsync(string flowName, UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFlowWithOptionsAsync(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a flow draft.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定工作流的草稿版本，草稿更新不影响已发布的工作流版本。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowDraftRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowDraftResponse
        /// </returns>
        public UpdateFlowDraftResponse UpdateFlowDraftWithOptions(string flowName, UpdateFlowDraftRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowDraft",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/draft",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowDraftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a flow draft.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定工作流的草稿版本，草稿更新不影响已发布的工作流版本。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowDraftRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowDraftResponse
        /// </returns>
        public async Task<UpdateFlowDraftResponse> UpdateFlowDraftWithOptionsAsync(string flowName, UpdateFlowDraftRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowDraft",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/draft",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a flow draft.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定工作流的草稿版本，草稿更新不影响已发布的工作流版本。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowDraftResponse
        /// </returns>
        public UpdateFlowDraftResponse UpdateFlowDraft(string flowName, UpdateFlowDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFlowDraftWithOptions(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a flow draft.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定工作流的草稿版本，草稿更新不影响已发布的工作流版本。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowDraftResponse
        /// </returns>
        public async Task<UpdateFlowDraftResponse> UpdateFlowDraftAsync(string flowName, UpdateFlowDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFlowDraftWithOptionsAsync(flowName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Flow Endpoint</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定工作流端点的配置信息，包括目标版本、路由配置等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowEndpointResponse
        /// </returns>
        public UpdateFlowEndpointResponse UpdateFlowEndpointWithOptions(string flowName, string flowEndpointName, UpdateFlowEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowEndpointName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Flow Endpoint</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定工作流端点的配置信息，包括目标版本、路由配置等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowEndpointResponse
        /// </returns>
        public async Task<UpdateFlowEndpointResponse> UpdateFlowEndpointWithOptionsAsync(string flowName, string flowEndpointName, UpdateFlowEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowEndpoint",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/flows/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowName) + "/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(flowEndpointName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Flow Endpoint</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定工作流端点的配置信息，包括目标版本、路由配置等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowEndpointResponse
        /// </returns>
        public UpdateFlowEndpointResponse UpdateFlowEndpoint(string flowName, string flowEndpointName, UpdateFlowEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFlowEndpointWithOptions(flowName, flowEndpointName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Flow Endpoint</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定工作流端点的配置信息，包括目标版本、路由配置等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateFlowEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowEndpointResponse
        /// </returns>
        public async Task<UpdateFlowEndpointResponse> UpdateFlowEndpointAsync(string flowName, string flowEndpointName, UpdateFlowEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFlowEndpointWithOptionsAsync(flowName, flowEndpointName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an IM bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>PUT /2025-09-10/agents/im-bots/{imBotId}；成功建议 HTTP 202，Body 标准包装，data 为更新后 IMBotInfo</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIMBotRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIMBotResponse
        /// </returns>
        public UpdateIMBotResponse UpdateIMBotWithOptions(string imBotId, UpdateIMBotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIMBot",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imBotId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIMBotResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an IM bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>PUT /2025-09-10/agents/im-bots/{imBotId}；成功建议 HTTP 202，Body 标准包装，data 为更新后 IMBotInfo</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIMBotRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIMBotResponse
        /// </returns>
        public async Task<UpdateIMBotResponse> UpdateIMBotWithOptionsAsync(string imBotId, UpdateIMBotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIMBot",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/im-bots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imBotId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIMBotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an IM bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>PUT /2025-09-10/agents/im-bots/{imBotId}；成功建议 HTTP 202，Body 标准包装，data 为更新后 IMBotInfo</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIMBotRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIMBotResponse
        /// </returns>
        public UpdateIMBotResponse UpdateIMBot(string imBotId, UpdateIMBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIMBotWithOptions(imBotId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an IM bot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>PUT /2025-09-10/agents/im-bots/{imBotId}；成功建议 HTTP 202，Body 标准包装，data 为更新后 IMBotInfo</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateIMBotRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIMBotResponse
        /// </returns>
        public async Task<UpdateIMBotResponse> UpdateIMBotAsync(string imBotId, UpdateIMBotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIMBotWithOptionsAsync(imBotId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public UpdateKnowledgeBaseResponse UpdateKnowledgeBaseWithOptions(string knowledgeBaseName, UpdateKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBase",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseWithOptionsAsync(string knowledgeBaseName, UpdateKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBase",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public UpdateKnowledgeBaseResponse UpdateKnowledgeBase(string knowledgeBaseName, UpdateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKnowledgeBaseWithOptions(knowledgeBaseName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseAsync(string knowledgeBaseName, UpdateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKnowledgeBaseWithOptionsAsync(knowledgeBaseName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryCollectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryCollectionResponse
        /// </returns>
        public UpdateMemoryCollectionResponse UpdateMemoryCollectionWithOptions(string memoryCollectionName, UpdateMemoryCollectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemoryCollection",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryCollectionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryCollectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryCollectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryCollectionResponse
        /// </returns>
        public async Task<UpdateMemoryCollectionResponse> UpdateMemoryCollectionWithOptionsAsync(string memoryCollectionName, UpdateMemoryCollectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemoryCollection",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/memory-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryCollectionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryCollectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryCollectionResponse
        /// </returns>
        public UpdateMemoryCollectionResponse UpdateMemoryCollection(string memoryCollectionName, UpdateMemoryCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemoryCollectionWithOptions(memoryCollectionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a memory collection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemoryCollectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemoryCollectionResponse
        /// </returns>
        public async Task<UpdateMemoryCollectionResponse> UpdateMemoryCollectionAsync(string memoryCollectionName, UpdateMemoryCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemoryCollectionWithOptionsAsync(memoryCollectionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a model proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to update the configuration of a specific model proxy.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelProxyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProxyResponse
        /// </returns>
        public UpdateModelProxyResponse UpdateModelProxyWithOptions(string modelProxyName, UpdateModelProxyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelProxy",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelProxyName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelProxyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a model proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to update the configuration of a specific model proxy.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelProxyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProxyResponse
        /// </returns>
        public async Task<UpdateModelProxyResponse> UpdateModelProxyWithOptionsAsync(string modelProxyName, UpdateModelProxyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelProxy",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-proxies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelProxyName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a model proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to update the configuration of a specific model proxy.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProxyResponse
        /// </returns>
        public UpdateModelProxyResponse UpdateModelProxy(string modelProxyName, UpdateModelProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelProxyWithOptions(modelProxyName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a model proxy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this operation to update the configuration of a specific model proxy.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelProxyResponse
        /// </returns>
        public async Task<UpdateModelProxyResponse> UpdateModelProxyAsync(string modelProxyName, UpdateModelProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelProxyWithOptionsAsync(modelProxyName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation modifies the configuration of an existing model service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelServiceResponse
        /// </returns>
        public UpdateModelServiceResponse UpdateModelServiceWithOptions(string modelServiceName, UpdateModelServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelService",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelServiceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation modifies the configuration of an existing model service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelServiceResponse
        /// </returns>
        public async Task<UpdateModelServiceResponse> UpdateModelServiceWithOptionsAsync(string modelServiceName, UpdateModelServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelService",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/model-services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelServiceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation modifies the configuration of an existing model service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelServiceResponse
        /// </returns>
        public UpdateModelServiceResponse UpdateModelService(string modelServiceName, UpdateModelServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelServiceWithOptions(modelServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation modifies the configuration of an existing model service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateModelServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelServiceResponse
        /// </returns>
        public async Task<UpdateModelServiceResponse> UpdateModelServiceAsync(string modelServiceName, UpdateModelServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelServiceWithOptionsAsync(modelServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates a template\&quot;s configuration, including its resource configuration, network configuration, and environment variables.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public UpdateTemplateResponse UpdateTemplateWithOptions(string templateName, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates a template\&quot;s configuration, including its resource configuration, network configuration, and environment variables.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(string templateName, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates a template\&quot;s configuration, including its resource configuration, network configuration, and environment variables.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public UpdateTemplateResponse UpdateTemplate(string templateName, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTemplateWithOptions(templateName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates a template\&quot;s configuration, including its resource configuration, network configuration, and environment variables.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(string templateName, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTemplateWithOptionsAsync(templateName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a tool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of an existing tool. You can modify its description, resource configuration, network configuration, and more. This operation supports partial updates. You only need to specify the fields that you want to modify.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateToolRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateToolResponse
        /// </returns>
        public UpdateToolResponse UpdateToolWithOptions(string toolName, UpdateToolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTool",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(toolName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateToolResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a tool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of an existing tool. You can modify its description, resource configuration, network configuration, and more. This operation supports partial updates. You only need to specify the fields that you want to modify.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateToolRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateToolResponse
        /// </returns>
        public async Task<UpdateToolResponse> UpdateToolWithOptionsAsync(string toolName, UpdateToolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTool",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/agents/tools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(toolName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateToolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a tool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of an existing tool. You can modify its description, resource configuration, network configuration, and more. This operation supports partial updates. You only need to specify the fields that you want to modify.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateToolRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateToolResponse
        /// </returns>
        public UpdateToolResponse UpdateTool(string toolName, UpdateToolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateToolWithOptions(toolName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a tool.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of an existing tool. You can modify its description, resource configuration, network configuration, and more. This operation supports partial updates. You only need to specify the fields that you want to modify.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateToolRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateToolResponse
        /// </returns>
        public async Task<UpdateToolResponse> UpdateToolAsync(string toolName, UpdateToolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateToolWithOptionsAsync(toolName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the properties of a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspaceWithOptions(string workspaceId, UpdateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the properties of a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceWithOptionsAsync(string workspaceId, UpdateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the properties of a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspace(string workspaceId, UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWorkspaceWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the properties of a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(string workspaceId, UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWorkspaceWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the discovery endpoint configuration for a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceDiscoveryEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceDiscoveryEndpointsResponse
        /// </returns>
        public UpdateWorkspaceDiscoveryEndpointsResponse UpdateWorkspaceDiscoveryEndpointsWithOptions(string workspaceId, UpdateWorkspaceDiscoveryEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceDiscoveryEndpoints",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/discovery/endpoints",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceDiscoveryEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the discovery endpoint configuration for a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceDiscoveryEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceDiscoveryEndpointsResponse
        /// </returns>
        public async Task<UpdateWorkspaceDiscoveryEndpointsResponse> UpdateWorkspaceDiscoveryEndpointsWithOptionsAsync(string workspaceId, UpdateWorkspaceDiscoveryEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceDiscoveryEndpoints",
                Version = "2025-09-10",
                Protocol = "HTTPS",
                Pathname = "/2025-09-10/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/discovery/endpoints",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceDiscoveryEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the discovery endpoint configuration for a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceDiscoveryEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceDiscoveryEndpointsResponse
        /// </returns>
        public UpdateWorkspaceDiscoveryEndpointsResponse UpdateWorkspaceDiscoveryEndpoints(string workspaceId, UpdateWorkspaceDiscoveryEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWorkspaceDiscoveryEndpointsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the discovery endpoint configuration for a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceDiscoveryEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceDiscoveryEndpointsResponse
        /// </returns>
        public async Task<UpdateWorkspaceDiscoveryEndpointsResponse> UpdateWorkspaceDiscoveryEndpointsAsync(string workspaceId, UpdateWorkspaceDiscoveryEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWorkspaceDiscoveryEndpointsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
