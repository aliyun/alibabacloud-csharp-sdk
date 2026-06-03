// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.SearchAgent20260515.Models;

namespace AlibabaCloud.SDK.SearchAgent20260515
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "SearchAgent";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>search agent acp 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAcpCommandRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAcpCommandResponse
        /// </returns>
        public ExecuteAcpCommandResponse ExecuteAcpCommandWithOptions(string workspaceName, ExecuteAcpCommandRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["agentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteAcpCommand",
                Version = "2026-05-15",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/agent/acp",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAcpCommandResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>search agent acp 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAcpCommandRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAcpCommandResponse
        /// </returns>
        public async Task<ExecuteAcpCommandResponse> ExecuteAcpCommandWithOptionsAsync(string workspaceName, ExecuteAcpCommandRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["agentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteAcpCommand",
                Version = "2026-05-15",
                Protocol = "HTTPS",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/agent/acp",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAcpCommandResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>search agent acp 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAcpCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAcpCommandResponse
        /// </returns>
        public ExecuteAcpCommandResponse ExecuteAcpCommand(string workspaceName, ExecuteAcpCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAcpCommandWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>search agent acp 接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAcpCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAcpCommandResponse
        /// </returns>
        public async Task<ExecuteAcpCommandResponse> ExecuteAcpCommandAsync(string workspaceName, ExecuteAcpCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAcpCommandWithOptionsAsync(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成 acp stream</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAcpCompletionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateAcpCompletionResponse
        /// </returns>
        public GenerateAcpCompletionResponse GenerateAcpCompletionWithOptions(string workspaceName, GenerateAcpCompletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["agentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAcpCompletion",
                Version = "2026-05-15",
                Protocol = "SSE",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/agent/acp",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GenerateAcpCompletionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成 acp stream</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAcpCompletionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateAcpCompletionResponse
        /// </returns>
        public async Task<GenerateAcpCompletionResponse> GenerateAcpCompletionWithOptionsAsync(string workspaceName, GenerateAcpCompletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["agentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jsonrpc))
            {
                body["jsonrpc"] = request.Jsonrpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAcpCompletion",
                Version = "2026-05-15",
                Protocol = "SSE",
                Pathname = "/v3/openapi/workspaces/" + workspaceName + "/agent/acp",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GenerateAcpCompletionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成 acp stream</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAcpCompletionRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateAcpCompletionResponse
        /// </returns>
        public GenerateAcpCompletionResponse GenerateAcpCompletion(string workspaceName, GenerateAcpCompletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateAcpCompletionWithOptions(workspaceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成 acp stream</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAcpCompletionRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateAcpCompletionResponse
        /// </returns>
        public async Task<GenerateAcpCompletionResponse> GenerateAcpCompletionAsync(string workspaceName, GenerateAcpCompletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateAcpCompletionWithOptionsAsync(workspaceName, request, headers, runtime);
        }

    }
}
