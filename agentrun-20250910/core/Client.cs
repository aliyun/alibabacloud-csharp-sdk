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
            this._endpointRule = "";
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
        /// <para>Create an agent runtime</para>
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
        /// <para>Create an agent runtime</para>
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
        /// <para>Create an agent runtime</para>
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
        /// <para>Create an agent runtime</para>
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
        /// <para>创建智能体运行时端点</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定的智能体运行时创建新的端点，用于外部访问和调用。端点是智能体运行时对外提供服务的入口。</para>
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
        /// <para>创建智能体运行时端点</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定的智能体运行时创建新的端点，用于外部访问和调用。端点是智能体运行时对外提供服务的入口。</para>
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
        /// <para>创建智能体运行时端点</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定的智能体运行时创建新的端点，用于外部访问和调用。端点是智能体运行时对外提供服务的入口。</para>
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
        /// <para>创建智能体运行时端点</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定的智能体运行时创建新的端点，用于外部访问和调用。端点是智能体运行时对外提供服务的入口。</para>
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
        /// <para>创建浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的浏览器实例，用于执行网页自动化任务。浏览器实例提供网页浏览、元素操作、截图录制等功能。</para>
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
        /// <para>创建浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的浏览器实例，用于执行网页自动化任务。浏览器实例提供网页浏览、元素操作、截图录制等功能。</para>
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
        /// <para>创建浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的浏览器实例，用于执行网页自动化任务。浏览器实例提供网页浏览、元素操作、截图录制等功能。</para>
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
        /// <para>创建浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>创建一个新的浏览器实例，用于执行网页自动化任务。浏览器实例提供网页浏览、元素操作、截图录制等功能。</para>
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
        /// <para>创建代码解释器</para>
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
        /// <para>创建代码解释器</para>
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
        /// <para>创建代码解释器</para>
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
        /// <para>创建代码解释器</para>
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
        /// <para>删除智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的智能体运行时实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的智能体运行时实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的智能体运行时实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的智能体运行时实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>Delete an agent runtime endpoint</para>
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
        /// <para>Delete an agent runtime endpoint</para>
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
        /// <para>Delete an agent runtime endpoint</para>
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
        /// <para>Delete an agent runtime endpoint</para>
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
        /// <para>删除浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的浏览器实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的浏览器实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的浏览器实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的浏览器实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除代码解释器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的代码解释器实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除代码解释器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的代码解释器实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除代码解释器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的代码解释器实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>删除代码解释器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>删除指定的代码解释器实例，包括其所有相关资源和数据。删除操作不可逆，请谨慎操作。</para>
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
        /// <para>获取智能体运行时详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据智能体运行时ID获取指定智能体运行时的详细信息，包括配置、状态、资源使用情况等。</para>
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
        /// <para>获取智能体运行时详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据智能体运行时ID获取指定智能体运行时的详细信息，包括配置、状态、资源使用情况等。</para>
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
        /// <para>获取智能体运行时详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据智能体运行时ID获取指定智能体运行时的详细信息，包括配置、状态、资源使用情况等。</para>
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
        /// <para>获取智能体运行时详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据智能体运行时ID获取指定智能体运行时的详细信息，包括配置、状态、资源使用情况等。</para>
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
        /// <para>Get an agent runtime endpoint</para>
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
        /// <para>Get an agent runtime endpoint</para>
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
        /// <para>Get an agent runtime endpoint</para>
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
        /// <para>Get an agent runtime endpoint</para>
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
        /// <para>获取浏览器实例详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据浏览器ID获取指定浏览器实例的详细信息，包括配置、状态、资源使用情况等。</para>
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
        /// <para>获取浏览器实例详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据浏览器ID获取指定浏览器实例的详细信息，包括配置、状态、资源使用情况等。</para>
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
        /// <para>获取浏览器实例详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据浏览器ID获取指定浏览器实例的详细信息，包括配置、状态、资源使用情况等。</para>
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
        /// <para>获取浏览器实例详情</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>根据浏览器ID获取指定浏览器实例的详细信息，包括配置、状态、资源使用情况等。</para>
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
        /// <para>获取代码解释器详情</para>
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
        /// <para>获取代码解释器详情</para>
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
        /// <para>获取代码解释器详情</para>
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
        /// <para>获取代码解释器详情</para>
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
        /// <para>列出智能体运行时端点</para>
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
        /// <para>列出智能体运行时端点</para>
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
        /// <para>列出智能体运行时端点</para>
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
        /// <para>列出智能体运行时端点</para>
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
        /// <para>List agent runtime versions</para>
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
        /// <para>List agent runtime versions</para>
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
        /// <para>List agent runtime versions</para>
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
        /// <para>List agent runtime versions</para>
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
        /// <para>列出智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有智能体运行时列表，支持按名称、标签等条件过滤，支持分页查询。</para>
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
        /// <para>列出智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有智能体运行时列表，支持按名称、标签等条件过滤，支持分页查询。</para>
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
        /// <para>列出智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有智能体运行时列表，支持按名称、标签等条件过滤，支持分页查询。</para>
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
        /// <para>列出智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有智能体运行时列表，支持按名称、标签等条件过滤，支持分页查询。</para>
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
        /// <para>列出浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有浏览器实例列表，支持按名称、状态等条件过滤，支持分页查询。</para>
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
        /// <para>列出浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有浏览器实例列表，支持按名称、状态等条件过滤，支持分页查询。</para>
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
        /// <para>列出浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有浏览器实例列表，支持按名称、状态等条件过滤，支持分页查询。</para>
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
        /// <para>列出浏览器实例</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有浏览器实例列表，支持按名称、状态等条件过滤，支持分页查询。</para>
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
        /// <para>列出代码解释器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有代码解释器实例列表，支持按名称等条件过滤，支持分页查询。</para>
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
        /// <para>列出代码解释器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有代码解释器实例列表，支持按名称等条件过滤，支持分页查询。</para>
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
        /// <para>列出代码解释器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有代码解释器实例列表，支持按名称等条件过滤，支持分页查询。</para>
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
        /// <para>列出代码解释器</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>获取当前用户的所有代码解释器实例列表，支持按名称等条件过滤，支持分页查询。</para>
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
        /// <para>发布运行时版本</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定的智能体运行时发布新版本，用于版本管理和部署。新版本可以包含代码更新、配置变更等内容。</para>
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
        /// <para>发布运行时版本</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定的智能体运行时发布新版本，用于版本管理和部署。新版本可以包含代码更新、配置变更等内容。</para>
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
        /// <para>发布运行时版本</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定的智能体运行时发布新版本，用于版本管理和部署。新版本可以包含代码更新、配置变更等内容。</para>
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
        /// <para>发布运行时版本</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>为指定的智能体运行时发布新版本，用于版本管理和部署。新版本可以包含代码更新、配置变更等内容。</para>
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
        /// <para>更新智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定智能体运行时的配置信息，包括资源分配、网络配置、环境变量等。更新操作会触发运行时重启。</para>
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
        /// <para>更新智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定智能体运行时的配置信息，包括资源分配、网络配置、环境变量等。更新操作会触发运行时重启。</para>
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
        /// <para>更新智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定智能体运行时的配置信息，包括资源分配、网络配置、环境变量等。更新操作会触发运行时重启。</para>
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
        /// <para>更新智能体运行时</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>更新指定智能体运行时的配置信息，包括资源分配、网络配置、环境变量等。更新操作会触发运行时重启。</para>
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
        /// <para>Update an agent runtime endpoint</para>
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
        /// <para>Update an agent runtime endpoint</para>
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
        /// <para>Update an agent runtime endpoint</para>
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
        /// <para>Update an agent runtime endpoint</para>
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

    }
}
