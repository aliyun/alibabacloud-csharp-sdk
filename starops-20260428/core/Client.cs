// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.STAROps20260428.Models;

namespace AlibabaCloud.SDK.STAROps20260428
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("starops", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatResponse
        /// </returns>
        public CreateChatResponse CreateChatWithOptions(CreateChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeName))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadId))
            {
                body["threadId"] = request.ThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChat",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatResponse
        /// </returns>
        public async Task<CreateChatResponse> CreateChatWithOptionsAsync(CreateChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalEmployeeName))
            {
                body["digitalEmployeeName"] = request.DigitalEmployeeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadId))
            {
                body["threadId"] = request.ThreadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChat",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatResponse
        /// </returns>
        public CreateChatResponse CreateChat(CreateChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateChatWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatResponse
        /// </returns>
        public async Task<CreateChatResponse> CreateChatAsync(CreateChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateChatWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDigitalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalEmployeeResponse
        /// </returns>
        public CreateDigitalEmployeeResponse CreateDigitalEmployeeWithOptions(CreateDigitalEmployeeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                body["defaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledges))
            {
                body["knowledges"] = request.Knowledges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["roleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolPolicy))
            {
                body["toolPolicy"] = request.ToolPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalEmployee",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalEmployeeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDigitalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalEmployeeResponse
        /// </returns>
        public async Task<CreateDigitalEmployeeResponse> CreateDigitalEmployeeWithOptionsAsync(CreateDigitalEmployeeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                body["defaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledges))
            {
                body["knowledges"] = request.Knowledges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["roleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolPolicy))
            {
                body["toolPolicy"] = request.ToolPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalEmployee",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalEmployeeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDigitalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalEmployeeResponse
        /// </returns>
        public CreateDigitalEmployeeResponse CreateDigitalEmployee(CreateDigitalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDigitalEmployeeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDigitalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalEmployeeResponse
        /// </returns>
        public async Task<CreateDigitalEmployeeResponse> CreateDigitalEmployeeAsync(CreateDigitalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDigitalEmployeeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDigitalEmployeeSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalEmployeeSkillResponse
        /// </returns>
        public CreateDigitalEmployeeSkillResponse CreateDigitalEmployeeSkillWithOptions(string name, CreateDigitalEmployeeSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                body["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalEmployeeSkill",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalEmployeeSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDigitalEmployeeSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalEmployeeSkillResponse
        /// </returns>
        public async Task<CreateDigitalEmployeeSkillResponse> CreateDigitalEmployeeSkillWithOptionsAsync(string name, CreateDigitalEmployeeSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                body["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDigitalEmployeeSkill",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDigitalEmployeeSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDigitalEmployeeSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalEmployeeSkillResponse
        /// </returns>
        public CreateDigitalEmployeeSkillResponse CreateDigitalEmployeeSkill(string name, CreateDigitalEmployeeSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDigitalEmployeeSkillWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDigitalEmployeeSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDigitalEmployeeSkillResponse
        /// </returns>
        public async Task<CreateDigitalEmployeeSkillResponse> CreateDigitalEmployeeSkillAsync(string name, CreateDigitalEmployeeSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDigitalEmployeeSkillWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMcpServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpServiceResponse
        /// </returns>
        public CreateMcpServiceResponse CreateMcpServiceWithOptions(string name, CreateMcpServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Connection))
            {
                body["connection"] = request.Connection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServiceName))
            {
                body["mcpServiceName"] = request.McpServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcpService",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpService",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcpServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMcpServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpServiceResponse
        /// </returns>
        public async Task<CreateMcpServiceResponse> CreateMcpServiceWithOptionsAsync(string name, CreateMcpServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Connection))
            {
                body["connection"] = request.Connection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServiceName))
            {
                body["mcpServiceName"] = request.McpServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcpService",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpService",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcpServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMcpServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpServiceResponse
        /// </returns>
        public CreateMcpServiceResponse CreateMcpService(string name, CreateMcpServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMcpServiceWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMcpServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpServiceResponse
        /// </returns>
        public async Task<CreateMcpServiceResponse> CreateMcpServiceAsync(string name, CreateMcpServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMcpServiceWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateThreadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateThreadResponse
        /// </returns>
        public CreateThreadResponse CreateThreadWithOptions(string name, CreateThreadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateThread",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateThreadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateThreadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateThreadResponse
        /// </returns>
        public async Task<CreateThreadResponse> CreateThreadWithOptionsAsync(string name, CreateThreadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateThread",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateThreadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateThreadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateThreadResponse
        /// </returns>
        public CreateThreadResponse CreateThread(string name, CreateThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateThreadWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateThreadRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateThreadResponse
        /// </returns>
        public async Task<CreateThreadResponse> CreateThreadAsync(string name, CreateThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateThreadWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建票据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public CreateTicketResponse CreateTicketWithOptions(CreateTicketRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenExpirationTime))
            {
                query["accessTokenExpirationTime"] = request.AccessTokenExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTime))
            {
                query["expirationTime"] = request.ExpirationTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建票据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public async Task<CreateTicketResponse> CreateTicketWithOptionsAsync(CreateTicketRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenExpirationTime))
            {
                query["accessTokenExpirationTime"] = request.AccessTokenExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTime))
            {
                query["expirationTime"] = request.ExpirationTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建票据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTicketWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建票据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTicketWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDigitalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDigitalEmployeeResponse
        /// </returns>
        public DeleteDigitalEmployeeResponse DeleteDigitalEmployeeWithOptions(string name, DeleteDigitalEmployeeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDigitalEmployee",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDigitalEmployeeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDigitalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDigitalEmployeeResponse
        /// </returns>
        public async Task<DeleteDigitalEmployeeResponse> DeleteDigitalEmployeeWithOptionsAsync(string name, DeleteDigitalEmployeeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDigitalEmployee",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDigitalEmployeeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDigitalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDigitalEmployeeResponse
        /// </returns>
        public DeleteDigitalEmployeeResponse DeleteDigitalEmployee(string name, DeleteDigitalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDigitalEmployeeWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDigitalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDigitalEmployeeResponse
        /// </returns>
        public async Task<DeleteDigitalEmployeeResponse> DeleteDigitalEmployeeAsync(string name, DeleteDigitalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDigitalEmployeeWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDigitalEmployeeSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDigitalEmployeeSkillResponse
        /// </returns>
        public DeleteDigitalEmployeeSkillResponse DeleteDigitalEmployeeSkillWithOptions(string name, string skillName, DeleteDigitalEmployeeSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDigitalEmployeeSkill",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDigitalEmployeeSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDigitalEmployeeSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDigitalEmployeeSkillResponse
        /// </returns>
        public async Task<DeleteDigitalEmployeeSkillResponse> DeleteDigitalEmployeeSkillWithOptionsAsync(string name, string skillName, DeleteDigitalEmployeeSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDigitalEmployeeSkill",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDigitalEmployeeSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDigitalEmployeeSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDigitalEmployeeSkillResponse
        /// </returns>
        public DeleteDigitalEmployeeSkillResponse DeleteDigitalEmployeeSkill(string name, string skillName, DeleteDigitalEmployeeSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDigitalEmployeeSkillWithOptions(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDigitalEmployeeSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDigitalEmployeeSkillResponse
        /// </returns>
        public async Task<DeleteDigitalEmployeeSkillResponse> DeleteDigitalEmployeeSkillAsync(string name, string skillName, DeleteDigitalEmployeeSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDigitalEmployeeSkillWithOptionsAsync(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMcpServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpServiceResponse
        /// </returns>
        public DeleteMcpServiceResponse DeleteMcpServiceWithOptions(string name, string mcpServiceName, DeleteMcpServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcpService",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServiceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcpServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMcpServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpServiceResponse
        /// </returns>
        public async Task<DeleteMcpServiceResponse> DeleteMcpServiceWithOptionsAsync(string name, string mcpServiceName, DeleteMcpServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcpService",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServiceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcpServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMcpServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpServiceResponse
        /// </returns>
        public DeleteMcpServiceResponse DeleteMcpService(string name, string mcpServiceName, DeleteMcpServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMcpServiceWithOptions(name, mcpServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMcpServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpServiceResponse
        /// </returns>
        public async Task<DeleteMcpServiceResponse> DeleteMcpServiceAsync(string name, string mcpServiceName, DeleteMcpServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMcpServiceWithOptionsAsync(name, mcpServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteThreadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteThreadResponse
        /// </returns>
        public DeleteThreadResponse DeleteThreadWithOptions(string name, string threadId, DeleteThreadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteThread",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(threadId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteThreadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteThreadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteThreadResponse
        /// </returns>
        public async Task<DeleteThreadResponse> DeleteThreadWithOptionsAsync(string name, string threadId, DeleteThreadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteThread",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(threadId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteThreadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteThreadRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteThreadResponse
        /// </returns>
        public DeleteThreadResponse DeleteThread(string name, string threadId, DeleteThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteThreadWithOptions(name, threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteThreadRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteThreadResponse
        /// </returns>
        public async Task<DeleteThreadResponse> DeleteThreadAsync(string name, string threadId, DeleteThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteThreadWithOptionsAsync(name, threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览远端 MCP 工具列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchRemoteMcpToolsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchRemoteMcpToolsResponse
        /// </returns>
        public FetchRemoteMcpToolsResponse FetchRemoteMcpToolsWithOptions(FetchRemoteMcpToolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Connection))
            {
                body["connection"] = request.Connection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchRemoteMcpTools",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/mcptools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchRemoteMcpToolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览远端 MCP 工具列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchRemoteMcpToolsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchRemoteMcpToolsResponse
        /// </returns>
        public async Task<FetchRemoteMcpToolsResponse> FetchRemoteMcpToolsWithOptionsAsync(FetchRemoteMcpToolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Connection))
            {
                body["connection"] = request.Connection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchRemoteMcpTools",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/mcptools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchRemoteMcpToolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览远端 MCP 工具列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchRemoteMcpToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchRemoteMcpToolsResponse
        /// </returns>
        public FetchRemoteMcpToolsResponse FetchRemoteMcpTools(FetchRemoteMcpToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FetchRemoteMcpToolsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览远端 MCP 工具列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchRemoteMcpToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchRemoteMcpToolsResponse
        /// </returns>
        public async Task<FetchRemoteMcpToolsResponse> FetchRemoteMcpToolsAsync(FetchRemoteMcpToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FetchRemoteMcpToolsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载小型产物文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactResponse
        /// </returns>
        public GetArtifactResponse GetArtifactWithOptions(string name, GetArtifactRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactPath))
            {
                query["artifactPath"] = request.ArtifactPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifact",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/artifact",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "binary",
            };
            GetArtifactResponse res = new GetArtifactResponse();
            Dictionary<string, object> tmp = AlibabaCloud.TeaUtil.Common.AssertAsMap(CallApi(params_, req, runtime));
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("body")))
            {
                Stream respBody = AlibabaCloud.TeaUtil.Common.AssertAsReadable(tmp.Get("body"));
                res.Body = respBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("headers")))
            {
                Dictionary<string, object> respHeaders = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmp.Get("headers"));
                res.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(respHeaders);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("statusCode")))
            {
                int? statusCode = AlibabaCloud.TeaUtil.Common.AssertAsInteger(tmp.Get("statusCode"));
                res.StatusCode = statusCode;
            }
            return res;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载小型产物文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactResponse
        /// </returns>
        public async Task<GetArtifactResponse> GetArtifactWithOptionsAsync(string name, GetArtifactRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactPath))
            {
                query["artifactPath"] = request.ArtifactPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifact",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/artifact",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "binary",
            };
            GetArtifactResponse res = new GetArtifactResponse();
            Dictionary<string, object> tmp = AlibabaCloud.TeaUtil.Common.AssertAsMap(await CallApiAsync(params_, req, runtime));
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("body")))
            {
                Stream respBody = AlibabaCloud.TeaUtil.Common.AssertAsReadable(tmp.Get("body"));
                res.Body = respBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("headers")))
            {
                Dictionary<string, object> respHeaders = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmp.Get("headers"));
                res.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(respHeaders);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("statusCode")))
            {
                int? statusCode = AlibabaCloud.TeaUtil.Common.AssertAsInteger(tmp.Get("statusCode"));
                res.StatusCode = statusCode;
            }
            return res;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载小型产物文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactResponse
        /// </returns>
        public GetArtifactResponse GetArtifact(string name, GetArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetArtifactWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载小型产物文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactResponse
        /// </returns>
        public async Task<GetArtifactResponse> GetArtifactAsync(string name, GetArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetArtifactWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDigitalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDigitalEmployeeResponse
        /// </returns>
        public GetDigitalEmployeeResponse GetDigitalEmployeeWithOptions(string name, GetDigitalEmployeeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDigitalEmployee",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDigitalEmployeeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDigitalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDigitalEmployeeResponse
        /// </returns>
        public async Task<GetDigitalEmployeeResponse> GetDigitalEmployeeWithOptionsAsync(string name, GetDigitalEmployeeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDigitalEmployee",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDigitalEmployeeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDigitalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDigitalEmployeeResponse
        /// </returns>
        public GetDigitalEmployeeResponse GetDigitalEmployee(string name, GetDigitalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDigitalEmployeeWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDigitalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDigitalEmployeeResponse
        /// </returns>
        public async Task<GetDigitalEmployeeResponse> GetDigitalEmployeeAsync(string name, GetDigitalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDigitalEmployeeWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDigitalEmployeeSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDigitalEmployeeSkillResponse
        /// </returns>
        public GetDigitalEmployeeSkillResponse GetDigitalEmployeeSkillWithOptions(string name, string skillName, GetDigitalEmployeeSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDigitalEmployeeSkill",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDigitalEmployeeSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDigitalEmployeeSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDigitalEmployeeSkillResponse
        /// </returns>
        public async Task<GetDigitalEmployeeSkillResponse> GetDigitalEmployeeSkillWithOptionsAsync(string name, string skillName, GetDigitalEmployeeSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDigitalEmployeeSkill",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDigitalEmployeeSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDigitalEmployeeSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDigitalEmployeeSkillResponse
        /// </returns>
        public GetDigitalEmployeeSkillResponse GetDigitalEmployeeSkill(string name, string skillName, GetDigitalEmployeeSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDigitalEmployeeSkillWithOptions(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取技能详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDigitalEmployeeSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDigitalEmployeeSkillResponse
        /// </returns>
        public async Task<GetDigitalEmployeeSkillResponse> GetDigitalEmployeeSkillAsync(string name, string skillName, GetDigitalEmployeeSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDigitalEmployeeSkillWithOptionsAsync(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMcpServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcpServiceResponse
        /// </returns>
        public GetMcpServiceResponse GetMcpServiceWithOptions(string name, string mcpServiceName, GetMcpServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcpService",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServiceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcpServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMcpServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcpServiceResponse
        /// </returns>
        public async Task<GetMcpServiceResponse> GetMcpServiceWithOptionsAsync(string name, string mcpServiceName, GetMcpServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcpService",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServiceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcpServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMcpServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcpServiceResponse
        /// </returns>
        public GetMcpServiceResponse GetMcpService(string name, string mcpServiceName, GetMcpServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMcpServiceWithOptions(name, mcpServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMcpServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcpServiceResponse
        /// </returns>
        public async Task<GetMcpServiceResponse> GetMcpServiceAsync(string name, string mcpServiceName, GetMcpServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMcpServiceWithOptionsAsync(name, mcpServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetThreadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetThreadResponse
        /// </returns>
        public GetThreadResponse GetThreadWithOptions(string name, string threadId, GetThreadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetThread",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(threadId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThreadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetThreadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetThreadResponse
        /// </returns>
        public async Task<GetThreadResponse> GetThreadWithOptionsAsync(string name, string threadId, GetThreadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetThread",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(threadId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThreadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetThreadRequest
        /// </param>
        /// 
        /// <returns>
        /// GetThreadResponse
        /// </returns>
        public GetThreadResponse GetThread(string name, string threadId, GetThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetThreadWithOptions(name, threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetThreadRequest
        /// </param>
        /// 
        /// <returns>
        /// GetThreadResponse
        /// </returns>
        public async Task<GetThreadResponse> GetThreadAsync(string name, string threadId, GetThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetThreadWithOptionsAsync(name, threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetThreadDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetThreadDataResponse
        /// </returns>
        public GetThreadDataResponse GetThreadDataWithOptions(string name, string threadId, GetThreadDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetThreadData",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(threadId) + "/data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThreadDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetThreadDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetThreadDataResponse
        /// </returns>
        public async Task<GetThreadDataResponse> GetThreadDataWithOptionsAsync(string name, string threadId, GetThreadDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetThreadData",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(threadId) + "/data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThreadDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetThreadDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetThreadDataResponse
        /// </returns>
        public GetThreadDataResponse GetThreadData(string name, string threadId, GetThreadDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetThreadDataWithOptions(name, threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetThreadDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetThreadDataResponse
        /// </returns>
        public async Task<GetThreadDataResponse> GetThreadDataAsync(string name, string threadId, GetThreadDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetThreadDataWithOptionsAsync(name, threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出产物文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactsResponse
        /// </returns>
        public ListArtifactsResponse ListArtifactsWithOptions(string name, ListArtifactsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactPath))
            {
                query["artifactPath"] = request.ArtifactPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifacts",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/artifacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出产物文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactsResponse
        /// </returns>
        public async Task<ListArtifactsResponse> ListArtifactsWithOptionsAsync(string name, ListArtifactsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactPath))
            {
                query["artifactPath"] = request.ArtifactPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifacts",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/artifacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出产物文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactsResponse
        /// </returns>
        public ListArtifactsResponse ListArtifacts(string name, ListArtifactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListArtifactsWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出产物文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactsResponse
        /// </returns>
        public async Task<ListArtifactsResponse> ListArtifactsAsync(string name, ListArtifactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListArtifactsWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出技能版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeeSkillVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeeSkillVersionsResponse
        /// </returns>
        public ListDigitalEmployeeSkillVersionsResponse ListDigitalEmployeeSkillVersionsWithOptions(string name, string skillName, ListDigitalEmployeeSkillVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDigitalEmployeeSkillVersions",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDigitalEmployeeSkillVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出技能版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeeSkillVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeeSkillVersionsResponse
        /// </returns>
        public async Task<ListDigitalEmployeeSkillVersionsResponse> ListDigitalEmployeeSkillVersionsWithOptionsAsync(string name, string skillName, ListDigitalEmployeeSkillVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDigitalEmployeeSkillVersions",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDigitalEmployeeSkillVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出技能版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeeSkillVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeeSkillVersionsResponse
        /// </returns>
        public ListDigitalEmployeeSkillVersionsResponse ListDigitalEmployeeSkillVersions(string name, string skillName, ListDigitalEmployeeSkillVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDigitalEmployeeSkillVersionsWithOptions(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出技能版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeeSkillVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeeSkillVersionsResponse
        /// </returns>
        public async Task<ListDigitalEmployeeSkillVersionsResponse> ListDigitalEmployeeSkillVersionsAsync(string name, string skillName, ListDigitalEmployeeSkillVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDigitalEmployeeSkillVersionsWithOptionsAsync(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeeSkillsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeeSkillsResponse
        /// </returns>
        public ListDigitalEmployeeSkillsResponse ListDigitalEmployeeSkillsWithOptions(string name, ListDigitalEmployeeSkillsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                query["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDigitalEmployeeSkills",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skills",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDigitalEmployeeSkillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeeSkillsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeeSkillsResponse
        /// </returns>
        public async Task<ListDigitalEmployeeSkillsResponse> ListDigitalEmployeeSkillsWithOptionsAsync(string name, ListDigitalEmployeeSkillsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                query["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDigitalEmployeeSkills",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skills",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDigitalEmployeeSkillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeeSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeeSkillsResponse
        /// </returns>
        public ListDigitalEmployeeSkillsResponse ListDigitalEmployeeSkills(string name, ListDigitalEmployeeSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDigitalEmployeeSkillsWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeeSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeeSkillsResponse
        /// </returns>
        public async Task<ListDigitalEmployeeSkillsResponse> ListDigitalEmployeeSkillsAsync(string name, ListDigitalEmployeeSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDigitalEmployeeSkillsWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDigitalEmployeesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeesResponse
        /// </returns>
        public ListDigitalEmployeesResponse ListDigitalEmployeesWithOptions(ListDigitalEmployeesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDigitalEmployeesShrinkRequest request = new ListDigitalEmployeesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeType))
            {
                query["employeeType"] = request.EmployeeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDigitalEmployees",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDigitalEmployeesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDigitalEmployeesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeesResponse
        /// </returns>
        public async Task<ListDigitalEmployeesResponse> ListDigitalEmployeesWithOptionsAsync(ListDigitalEmployeesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDigitalEmployeesShrinkRequest request = new ListDigitalEmployeesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeType))
            {
                query["employeeType"] = request.EmployeeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDigitalEmployees",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDigitalEmployeesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeesResponse
        /// </returns>
        public ListDigitalEmployeesResponse ListDigitalEmployees(ListDigitalEmployeesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDigitalEmployeesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源DigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDigitalEmployeesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDigitalEmployeesResponse
        /// </returns>
        public async Task<ListDigitalEmployeesResponse> ListDigitalEmployeesAsync(ListDigitalEmployeesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDigitalEmployeesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工下的 MCP 服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMcpServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpServicesResponse
        /// </returns>
        public ListMcpServicesResponse ListMcpServicesWithOptions(string name, ListMcpServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcpServices",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工下的 MCP 服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMcpServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpServicesResponse
        /// </returns>
        public async Task<ListMcpServicesResponse> ListMcpServicesWithOptionsAsync(string name, ListMcpServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcpServices",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工下的 MCP 服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMcpServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpServicesResponse
        /// </returns>
        public ListMcpServicesResponse ListMcpServices(string name, ListMcpServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMcpServicesWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字员工下的 MCP 服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMcpServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpServicesResponse
        /// </returns>
        public async Task<ListMcpServicesResponse> ListMcpServicesAsync(string name, ListMcpServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMcpServicesWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出会话</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListThreadsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListThreadsResponse
        /// </returns>
        public ListThreadsResponse ListThreadsWithOptions(string name, ListThreadsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListThreadsShrinkRequest request = new ListThreadsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeMission))
            {
                query["includeMission"] = request.IncludeMission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadId))
            {
                query["threadId"] = request.ThreadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListThreads",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/threads",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListThreadsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出会话</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListThreadsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListThreadsResponse
        /// </returns>
        public async Task<ListThreadsResponse> ListThreadsWithOptionsAsync(string name, ListThreadsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListThreadsShrinkRequest request = new ListThreadsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeMission))
            {
                query["includeMission"] = request.IncludeMission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadId))
            {
                query["threadId"] = request.ThreadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListThreads",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/threads",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListThreadsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListThreadsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListThreadsResponse
        /// </returns>
        public ListThreadsResponse ListThreads(string name, ListThreadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListThreadsWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListThreadsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListThreadsResponse
        /// </returns>
        public async Task<ListThreadsResponse> ListThreadsAsync(string name, ListThreadsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListThreadsWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateDigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalEmployeeResponse
        /// </returns>
        public UpdateDigitalEmployeeResponse UpdateDigitalEmployeeWithOptions(string name, UpdateDigitalEmployeeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                body["defaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledges))
            {
                body["knowledges"] = request.Knowledges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["roleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolPolicy))
            {
                body["toolPolicy"] = request.ToolPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDigitalEmployee",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDigitalEmployeeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateDigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalEmployeeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalEmployeeResponse
        /// </returns>
        public async Task<UpdateDigitalEmployeeResponse> UpdateDigitalEmployeeWithOptionsAsync(string name, UpdateDigitalEmployeeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                body["defaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledges))
            {
                body["knowledges"] = request.Knowledges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                body["roleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolPolicy))
            {
                body["toolPolicy"] = request.ToolPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDigitalEmployee",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digital-employee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDigitalEmployeeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateDigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalEmployeeResponse
        /// </returns>
        public UpdateDigitalEmployeeResponse UpdateDigitalEmployee(string name, UpdateDigitalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDigitalEmployeeWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateDigitalEmployee</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalEmployeeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalEmployeeResponse
        /// </returns>
        public async Task<UpdateDigitalEmployeeResponse> UpdateDigitalEmployeeAsync(string name, UpdateDigitalEmployeeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDigitalEmployeeWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalEmployeeSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalEmployeeSkillResponse
        /// </returns>
        public UpdateDigitalEmployeeSkillResponse UpdateDigitalEmployeeSkillWithOptions(string name, string skillName, UpdateDigitalEmployeeSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDigitalEmployeeSkill",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDigitalEmployeeSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalEmployeeSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalEmployeeSkillResponse
        /// </returns>
        public async Task<UpdateDigitalEmployeeSkillResponse> UpdateDigitalEmployeeSkillWithOptionsAsync(string name, string skillName, UpdateDigitalEmployeeSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDigitalEmployeeSkill",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDigitalEmployeeSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalEmployeeSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalEmployeeSkillResponse
        /// </returns>
        public UpdateDigitalEmployeeSkillResponse UpdateDigitalEmployeeSkill(string name, string skillName, UpdateDigitalEmployeeSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDigitalEmployeeSkillWithOptions(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalEmployeeSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalEmployeeSkillResponse
        /// </returns>
        public async Task<UpdateDigitalEmployeeSkillResponse> UpdateDigitalEmployeeSkillAsync(string name, string skillName, UpdateDigitalEmployeeSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDigitalEmployeeSkillWithOptionsAsync(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMcpServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpServiceResponse
        /// </returns>
        public UpdateMcpServiceResponse UpdateMcpServiceWithOptions(string name, string mcpServiceName, UpdateMcpServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Connection))
            {
                body["connection"] = request.Connection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcpService",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServiceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcpServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMcpServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpServiceResponse
        /// </returns>
        public async Task<UpdateMcpServiceResponse> UpdateMcpServiceWithOptionsAsync(string name, string mcpServiceName, UpdateMcpServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Connection))
            {
                body["connection"] = request.Connection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcpService",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/mcpService/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServiceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcpServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMcpServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpServiceResponse
        /// </returns>
        public UpdateMcpServiceResponse UpdateMcpService(string name, string mcpServiceName, UpdateMcpServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMcpServiceWithOptions(name, mcpServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 MCP 服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMcpServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpServiceResponse
        /// </returns>
        public async Task<UpdateMcpServiceResponse> UpdateMcpServiceAsync(string name, string mcpServiceName, UpdateMcpServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMcpServiceWithOptionsAsync(name, mcpServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateThreadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateThreadResponse
        /// </returns>
        public UpdateThreadResponse UpdateThreadWithOptions(string name, string threadId, UpdateThreadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateThread",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(threadId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateThreadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateThreadRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateThreadResponse
        /// </returns>
        public async Task<UpdateThreadResponse> UpdateThreadWithOptionsAsync(string name, string threadId, UpdateThreadRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                body["attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateThread",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/digitalEmployee/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/thread/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(threadId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateThreadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateThreadRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateThreadResponse
        /// </returns>
        public UpdateThreadResponse UpdateThread(string name, string threadId, UpdateThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateThreadWithOptions(name, threadId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateThreadRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateThreadResponse
        /// </returns>
        public async Task<UpdateThreadResponse> UpdateThreadAsync(string name, string threadId, UpdateThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateThreadWithOptionsAsync(name, threadId, request, headers, runtime);
        }

    }
}
