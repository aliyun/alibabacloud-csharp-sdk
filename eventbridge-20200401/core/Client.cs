// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eventbridge20200401.Models;

namespace AlibabaCloud.SDK.Eventbridge20200401
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-wulanchabu", "eventbridge-console.cn-wulanchabu.aliyuncs.com"},
                {"cn-beijing", "eventbridge-console.cn-beijing.aliyuncs.com"},
                {"cn-qingdao", "eventbridge-console.cn-qingdao.aliyuncs.com"},
                {"cn-shanghai", "eventbridge-console.cn-shanghai.aliyuncs.com"},
                {"cn-hongkong", "eventbridge-console.cn-hongkong.aliyuncs.com"},
                {"cn-heyuan", "eventbridge-console.cn-heyuan.aliyuncs.com"},
                {"cn-zhangjiakou", "eventbridge-console.cn-zhangjiakou.aliyuncs.com"},
                {"cn-shenzhen", "eventbridge-console.cn-shenzhen.aliyuncs.com"},
                {"ap-northeast-2", "eventbridge-console.ap-northeast-2.aliyuncs.com"},
                {"ap-northeast-1", "eventbridge-console.ap-northeast-1.aliyuncs.com"},
                {"cn-chengdu", "eventbridge-console.cn-chengdu.aliyuncs.com"},
                {"cn-guangzhou", "eventbridge-console.cn-guangzhou.aliyuncs.com"},
                {"ap-southeast-1", "eventbridge-console.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "eventbridge-console.ap-southeast-3.aliyuncs.com"},
                {"cn-huhehaote", "eventbridge-console.cn-huhehaote.aliyuncs.com"},
                {"ap-southeast-5", "eventbridge-console.ap-southeast-5.aliyuncs.com"},
                {"ap-southeast-6", "eventbridge-console.ap-southeast-6.aliyuncs.com"},
                {"ap-southeast-7", "eventbridge-console.ap-southeast-7.aliyuncs.com"},
                {"cn-hangzhou", "eventbridge-console.cn-hangzhou.aliyuncs.com"},
                {"us-east-1", "eventbridge-console.us-east-1.aliyuncs.com"},
                {"eu-west-1", "eventbridge-console.eu-west-1.aliyuncs.com"},
                {"us-west-1", "eventbridge-console.us-west-1.aliyuncs.com"},
                {"eu-central-1", "eventbridge-console.eu-central-1.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "eventbridge-console.cn-shenzhen-finance-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "eventbridge-console.cn-beijing-finance-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "eventbridge-console.cn-shanghai-finance-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("eventbridge", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Queries data using natural language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskLumaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AskLumaResponse
        /// </returns>
        public AskLumaResponse AskLumaWithOptions(AskLumaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRows))
            {
                body["MaxRows"] = request.MaxRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["Question"] = request.Question;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskLuma",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskLumaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data using natural language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskLumaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AskLumaResponse
        /// </returns>
        public async Task<AskLumaResponse> AskLumaWithOptionsAsync(AskLumaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRows))
            {
                body["MaxRows"] = request.MaxRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["Question"] = request.Question;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskLuma",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskLumaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data using natural language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskLumaRequest
        /// </param>
        /// 
        /// <returns>
        /// AskLumaResponse
        /// </returns>
        public AskLumaResponse AskLuma(AskLumaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AskLumaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries data using natural language.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskLumaRequest
        /// </param>
        /// 
        /// <returns>
        /// AskLumaResponse
        /// </returns>
        public async Task<AskLumaResponse> AskLumaAsync(AskLumaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AskLumaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a service-linked role is authorized for an account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Checks for a service-linked role by name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckServiceLinkedRoleForProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleForProductResponse
        /// </returns>
        public CheckServiceLinkedRoleForProductResponse CheckServiceLinkedRoleForProductWithOptions(CheckServiceLinkedRoleForProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckServiceLinkedRoleForProduct",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a service-linked role is authorized for an account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Checks for a service-linked role by name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckServiceLinkedRoleForProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleForProductResponse
        /// </returns>
        public async Task<CheckServiceLinkedRoleForProductResponse> CheckServiceLinkedRoleForProductWithOptionsAsync(CheckServiceLinkedRoleForProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckServiceLinkedRoleForProduct",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a service-linked role is authorized for an account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Checks for a service-linked role by name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckServiceLinkedRoleForProductRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleForProductResponse
        /// </returns>
        public CheckServiceLinkedRoleForProductResponse CheckServiceLinkedRoleForProduct(CheckServiceLinkedRoleForProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckServiceLinkedRoleForProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a service-linked role is authorized for an account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Checks for a service-linked role by name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckServiceLinkedRoleForProductRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleForProductResponse
        /// </returns>
        public async Task<CheckServiceLinkedRoleForProductResponse> CheckServiceLinkedRoleForProductAsync(CheckServiceLinkedRoleForProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckServiceLinkedRoleForProductWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgentWithOptions(CreateAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentShrinkRequest request = new CreateAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Metadata))
            {
                request.MetadataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Metadata, "Metadata", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataShrink))
            {
                body["Metadata"] = request.MetadataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentWithOptionsAsync(CreateAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentShrinkRequest request = new CreateAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Metadata))
            {
                request.MetadataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Metadata, "Metadata", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataShrink))
            {
                body["Metadata"] = request.MetadataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to create an API destination.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateApiDestinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApiDestinationResponse
        /// </returns>
        public CreateApiDestinationResponse CreateApiDestinationWithOptions(CreateApiDestinationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApiDestinationShrinkRequest request = new CreateApiDestinationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpApiParameters))
            {
                request.HttpApiParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpApiParameters, "HttpApiParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiParametersShrink))
            {
                query["HttpApiParameters"] = request.HttpApiParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiDestinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to create an API destination.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateApiDestinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApiDestinationResponse
        /// </returns>
        public async Task<CreateApiDestinationResponse> CreateApiDestinationWithOptionsAsync(CreateApiDestinationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApiDestinationShrinkRequest request = new CreateApiDestinationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpApiParameters))
            {
                request.HttpApiParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpApiParameters, "HttpApiParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiParametersShrink))
            {
                query["HttpApiParameters"] = request.HttpApiParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to create an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApiDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApiDestinationResponse
        /// </returns>
        public CreateApiDestinationResponse CreateApiDestination(CreateApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApiDestinationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to create an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApiDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApiDestinationResponse
        /// </returns>
        public async Task<CreateApiDestinationResponse> CreateApiDestinationAsync(CreateApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApiDestinationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a connection configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a connection configuration.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConnectionResponse
        /// </returns>
        public CreateConnectionResponse CreateConnectionWithOptions(CreateConnectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConnectionShrinkRequest request = new CreateConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthParameters))
            {
                request.AuthParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthParameters, "AuthParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkParameters))
            {
                request.NetworkParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkParameters, "NetworkParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthParametersShrink))
            {
                query["AuthParameters"] = request.AuthParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkParametersShrink))
            {
                query["NetworkParameters"] = request.NetworkParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a connection configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a connection configuration.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConnectionResponse
        /// </returns>
        public async Task<CreateConnectionResponse> CreateConnectionWithOptionsAsync(CreateConnectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConnectionShrinkRequest request = new CreateConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthParameters))
            {
                request.AuthParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthParameters, "AuthParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkParameters))
            {
                request.NetworkParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkParameters, "NetworkParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthParametersShrink))
            {
                query["AuthParameters"] = request.AuthParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkParametersShrink))
            {
                query["NetworkParameters"] = request.NetworkParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a connection configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a connection configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConnectionResponse
        /// </returns>
        public CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a connection configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a connection configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConnectionResponse
        /// </returns>
        public async Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEventBusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventBusResponse
        /// </returns>
        public CreateEventBusResponse CreateEventBusWithOptions(CreateEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventBusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEventBusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventBusResponse
        /// </returns>
        public async Task<CreateEventBusResponse> CreateEventBusWithOptionsAsync(CreateEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventBusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEventBusRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventBusResponse
        /// </returns>
        public CreateEventBusResponse CreateEventBus(CreateEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventBusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEventBusRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventBusResponse
        /// </returns>
        public async Task<CreateEventBusResponse> CreateEventBusAsync(CreateEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventBusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an external event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an external event source.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateEventSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventSourceResponse
        /// </returns>
        public CreateEventSourceResponse CreateEventSourceWithOptions(CreateEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventSourceShrinkRequest request = new CreateEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalSourceConfig))
            {
                request.ExternalSourceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalSourceConfig, "ExternalSourceConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceHttpEventParameters))
            {
                request.SourceHttpEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceHttpEventParameters, "SourceHttpEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceKafkaParameters))
            {
                request.SourceKafkaParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceKafkaParameters, "SourceKafkaParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMNSParameters))
            {
                request.SourceMNSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMNSParameters, "SourceMNSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceOSSEventParameters))
            {
                request.SourceOSSEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceOSSEventParameters, "SourceOSSEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRabbitMQParameters))
            {
                request.SourceRabbitMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRabbitMQParameters, "SourceRabbitMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRocketMQParameters))
            {
                request.SourceRocketMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRocketMQParameters, "SourceRocketMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSLSParameters))
            {
                request.SourceSLSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSLSParameters, "SourceSLSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceScheduledEventParameters))
            {
                request.SourceScheduledEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceScheduledEventParameters, "SourceScheduledEventParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalSourceConfigShrink))
            {
                body["ExternalSourceConfig"] = request.ExternalSourceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalSourceType))
            {
                body["ExternalSourceType"] = request.ExternalSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkedExternalSource))
            {
                body["LinkedExternalSource"] = request.LinkedExternalSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHttpEventParametersShrink))
            {
                body["SourceHttpEventParameters"] = request.SourceHttpEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKafkaParametersShrink))
            {
                body["SourceKafkaParameters"] = request.SourceKafkaParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMNSParametersShrink))
            {
                body["SourceMNSParameters"] = request.SourceMNSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOSSEventParametersShrink))
            {
                body["SourceOSSEventParameters"] = request.SourceOSSEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRabbitMQParametersShrink))
            {
                body["SourceRabbitMQParameters"] = request.SourceRabbitMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRocketMQParametersShrink))
            {
                body["SourceRocketMQParameters"] = request.SourceRocketMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSLSParametersShrink))
            {
                body["SourceSLSParameters"] = request.SourceSLSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScheduledEventParametersShrink))
            {
                body["SourceScheduledEventParameters"] = request.SourceScheduledEventParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an external event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an external event source.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateEventSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventSourceResponse
        /// </returns>
        public async Task<CreateEventSourceResponse> CreateEventSourceWithOptionsAsync(CreateEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventSourceShrinkRequest request = new CreateEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalSourceConfig))
            {
                request.ExternalSourceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalSourceConfig, "ExternalSourceConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceHttpEventParameters))
            {
                request.SourceHttpEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceHttpEventParameters, "SourceHttpEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceKafkaParameters))
            {
                request.SourceKafkaParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceKafkaParameters, "SourceKafkaParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMNSParameters))
            {
                request.SourceMNSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMNSParameters, "SourceMNSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceOSSEventParameters))
            {
                request.SourceOSSEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceOSSEventParameters, "SourceOSSEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRabbitMQParameters))
            {
                request.SourceRabbitMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRabbitMQParameters, "SourceRabbitMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRocketMQParameters))
            {
                request.SourceRocketMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRocketMQParameters, "SourceRocketMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSLSParameters))
            {
                request.SourceSLSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSLSParameters, "SourceSLSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceScheduledEventParameters))
            {
                request.SourceScheduledEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceScheduledEventParameters, "SourceScheduledEventParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalSourceConfigShrink))
            {
                body["ExternalSourceConfig"] = request.ExternalSourceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalSourceType))
            {
                body["ExternalSourceType"] = request.ExternalSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkedExternalSource))
            {
                body["LinkedExternalSource"] = request.LinkedExternalSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHttpEventParametersShrink))
            {
                body["SourceHttpEventParameters"] = request.SourceHttpEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKafkaParametersShrink))
            {
                body["SourceKafkaParameters"] = request.SourceKafkaParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMNSParametersShrink))
            {
                body["SourceMNSParameters"] = request.SourceMNSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOSSEventParametersShrink))
            {
                body["SourceOSSEventParameters"] = request.SourceOSSEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRabbitMQParametersShrink))
            {
                body["SourceRabbitMQParameters"] = request.SourceRabbitMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRocketMQParametersShrink))
            {
                body["SourceRocketMQParameters"] = request.SourceRocketMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSLSParametersShrink))
            {
                body["SourceSLSParameters"] = request.SourceSLSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScheduledEventParametersShrink))
            {
                body["SourceScheduledEventParameters"] = request.SourceScheduledEventParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an external event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an external event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEventSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventSourceResponse
        /// </returns>
        public CreateEventSourceResponse CreateEventSource(CreateEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an external event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an external event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEventSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventSourceResponse
        /// </returns>
        public async Task<CreateEventSourceResponse> CreateEventSourceAsync(CreateEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event stream.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventStreamingResponse
        /// </returns>
        public CreateEventStreamingResponse CreateEventStreamingWithOptions(CreateEventStreamingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventStreamingShrinkRequest request = new CreateEventStreamingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RunOptions))
            {
                request.RunOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RunOptions, "RunOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sink))
            {
                request.SinkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sink, "Sink", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transforms))
            {
                request.TransformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transforms, "Transforms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                body["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunOptionsShrink))
            {
                body["RunOptions"] = request.RunOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkShrink))
            {
                body["Sink"] = request.SinkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                body["Source"] = request.SourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformsShrink))
            {
                body["Transforms"] = request.TransformsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event stream.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventStreamingResponse
        /// </returns>
        public async Task<CreateEventStreamingResponse> CreateEventStreamingWithOptionsAsync(CreateEventStreamingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventStreamingShrinkRequest request = new CreateEventStreamingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RunOptions))
            {
                request.RunOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RunOptions, "RunOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sink))
            {
                request.SinkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sink, "Sink", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transforms))
            {
                request.TransformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transforms, "Transforms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                body["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunOptionsShrink))
            {
                body["RunOptions"] = request.RunOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkShrink))
            {
                body["Sink"] = request.SinkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                body["Source"] = request.SourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformsShrink))
            {
                body["Transforms"] = request.TransformsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventStreamingResponse
        /// </returns>
        public CreateEventStreamingResponse CreateEventStreaming(CreateEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventStreamingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEventStreamingResponse
        /// </returns>
        public async Task<CreateEventStreamingResponse> CreateEventStreamingAsync(CreateEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventStreamingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public CreateKnowledgeBaseResponse CreateKnowledgeBaseWithOptions(CreateKnowledgeBaseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateKnowledgeBaseShrinkRequest request = new CreateKnowledgeBaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChunkConfiguration))
            {
                request.ChunkConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChunkConfiguration, "ChunkConfiguration", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetadataSchema))
            {
                request.MetadataSchemaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetadataSchema, "MetadataSchema", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchConfiguration))
            {
                request.SearchConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchConfiguration, "SearchConfiguration", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkConfigurationShrink))
            {
                query["ChunkConfiguration"] = request.ChunkConfigurationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingDimension))
            {
                query["EmbeddingDimension"] = request.EmbeddingDimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingModel))
            {
                query["EmbeddingModel"] = request.EmbeddingModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataSchemaShrink))
            {
                query["MetadataSchema"] = request.MetadataSchemaShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchConfigurationShrink))
            {
                query["SearchConfiguration"] = request.SearchConfigurationShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseWithOptionsAsync(CreateKnowledgeBaseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateKnowledgeBaseShrinkRequest request = new CreateKnowledgeBaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChunkConfiguration))
            {
                request.ChunkConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChunkConfiguration, "ChunkConfiguration", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetadataSchema))
            {
                request.MetadataSchemaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetadataSchema, "MetadataSchema", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchConfiguration))
            {
                request.SearchConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchConfiguration, "SearchConfiguration", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkConfigurationShrink))
            {
                query["ChunkConfiguration"] = request.ChunkConfigurationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingDimension))
            {
                query["EmbeddingDimension"] = request.EmbeddingDimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingModel))
            {
                query["EmbeddingModel"] = request.EmbeddingModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataSchemaShrink))
            {
                query["MetadataSchema"] = request.MetadataSchemaShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchConfigurationShrink))
            {
                query["SearchConfiguration"] = request.SearchConfigurationShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            return CreateKnowledgeBaseWithOptions(request, runtime);
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
            return await CreateKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRuleShrinkRequest request = new CreateRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventTargets))
            {
                request.EventTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventTargets, "EventTargets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTargetsShrink))
            {
                query["EventTargets"] = request.EventTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                query["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRuleShrinkRequest request = new CreateRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventTargets))
            {
                request.EventTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventTargets, "EventTargets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTargetsShrink))
            {
                query["EventTargets"] = request.EventTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                query["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates the service-linked role (SLR) that is associated with a specified product.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates the service-linked role (SLR) that is associated with a specified product.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleForProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleForProductResponse
        /// </returns>
        public CreateServiceLinkedRoleForProductResponse CreateServiceLinkedRoleForProductWithOptions(CreateServiceLinkedRoleForProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRoleForProduct",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleForProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates the service-linked role (SLR) that is associated with a specified product.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates the service-linked role (SLR) that is associated with a specified product.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleForProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleForProductResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleForProductResponse> CreateServiceLinkedRoleForProductWithOptionsAsync(CreateServiceLinkedRoleForProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRoleForProduct",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleForProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates the service-linked role (SLR) that is associated with a specified product.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates the service-linked role (SLR) that is associated with a specified product.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleForProductRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleForProductResponse
        /// </returns>
        public CreateServiceLinkedRoleForProductResponse CreateServiceLinkedRoleForProduct(CreateServiceLinkedRoleForProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleForProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates the service-linked role (SLR) that is associated with a specified product.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates the service-linked role (SLR) that is associated with a specified product.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleForProductRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleForProductResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleForProductResponse> CreateServiceLinkedRoleForProductAsync(CreateServiceLinkedRoleForProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleForProductWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a data catalog</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event target under the specified rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public CreateTableResponse CreateTableWithOptions(CreateTableRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTableShrinkRequest request = new CreateTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Columns))
            {
                request.ColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Columns, "Columns", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetentionPolicy))
            {
                request.RetentionPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetentionPolicy, "RetentionPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnsShrink))
            {
                query["Columns"] = request.ColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionPolicyShrink))
            {
                query["RetentionPolicy"] = request.RetentionPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a data catalog</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event target under the specified rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public async Task<CreateTableResponse> CreateTableWithOptionsAsync(CreateTableRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTableShrinkRequest request = new CreateTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Columns))
            {
                request.ColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Columns, "Columns", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetentionPolicy))
            {
                request.RetentionPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetentionPolicy, "RetentionPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnsShrink))
            {
                query["Columns"] = request.ColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionPolicyShrink))
            {
                query["RetentionPolicy"] = request.RetentionPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a data catalog</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event target under the specified rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public CreateTableResponse CreateTable(CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a data catalog</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an event target under the specified rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public async Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgentWithOptions(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentWithOptionsAsync(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApiDestinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiDestinationResponse
        /// </returns>
        public DeleteApiDestinationResponse DeleteApiDestinationWithOptions(DeleteApiDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiDestinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApiDestinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiDestinationResponse
        /// </returns>
        public async Task<DeleteApiDestinationResponse> DeleteApiDestinationWithOptionsAsync(DeleteApiDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApiDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiDestinationResponse
        /// </returns>
        public DeleteApiDestinationResponse DeleteApiDestination(DeleteApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApiDestinationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApiDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiDestinationResponse
        /// </returns>
        public async Task<DeleteApiDestinationResponse> DeleteApiDestinationAsync(DeleteApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApiDestinationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public DeleteConnectionResponse DeleteConnectionWithOptions(DeleteConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public async Task<DeleteConnectionResponse> DeleteConnectionWithOptionsAsync(DeleteConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public async Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data integration job.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteEventAnalysisJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventAnalysisJobResponse
        /// </returns>
        public DeleteEventAnalysisJobResponse DeleteEventAnalysisJobWithOptions(DeleteEventAnalysisJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEventAnalysisJobShrinkRequest request = new DeleteEventAnalysisJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResource))
            {
                request.SourceResourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResource, "SourceResource", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceShrink))
            {
                body["SourceResource"] = request.SourceResourceShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventAnalysisJob",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventAnalysisJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data integration job.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteEventAnalysisJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventAnalysisJobResponse
        /// </returns>
        public async Task<DeleteEventAnalysisJobResponse> DeleteEventAnalysisJobWithOptionsAsync(DeleteEventAnalysisJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEventAnalysisJobShrinkRequest request = new DeleteEventAnalysisJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResource))
            {
                request.SourceResourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResource, "SourceResource", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceShrink))
            {
                body["SourceResource"] = request.SourceResourceShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventAnalysisJob",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventAnalysisJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data integration job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventAnalysisJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventAnalysisJobResponse
        /// </returns>
        public DeleteEventAnalysisJobResponse DeleteEventAnalysisJob(DeleteEventAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventAnalysisJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data integration job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventAnalysisJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventAnalysisJobResponse
        /// </returns>
        public async Task<DeleteEventAnalysisJobResponse> DeleteEventAnalysisJobAsync(DeleteEventAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventAnalysisJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventBusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventBusResponse
        /// </returns>
        public DeleteEventBusResponse DeleteEventBusWithOptions(DeleteEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventBusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventBusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventBusResponse
        /// </returns>
        public async Task<DeleteEventBusResponse> DeleteEventBusWithOptionsAsync(DeleteEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventBusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventBusRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventBusResponse
        /// </returns>
        public DeleteEventBusResponse DeleteEventBus(DeleteEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventBusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventBusRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventBusResponse
        /// </returns>
        public async Task<DeleteEventBusResponse> DeleteEventBusAsync(DeleteEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventBusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventHouseRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventHouseRuntimeResponse
        /// </returns>
        public DeleteEventHouseRuntimeResponse DeleteEventHouseRuntimeWithOptions(DeleteEventHouseRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventHouseRuntime",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventHouseRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventHouseRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventHouseRuntimeResponse
        /// </returns>
        public async Task<DeleteEventHouseRuntimeResponse> DeleteEventHouseRuntimeWithOptionsAsync(DeleteEventHouseRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventHouseRuntime",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventHouseRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventHouseRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventHouseRuntimeResponse
        /// </returns>
        public DeleteEventHouseRuntimeResponse DeleteEventHouseRuntime(DeleteEventHouseRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventHouseRuntimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventHouseRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventHouseRuntimeResponse
        /// </returns>
        public async Task<DeleteEventHouseRuntimeResponse> DeleteEventHouseRuntimeAsync(DeleteEventHouseRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventHouseRuntimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventSourceResponse
        /// </returns>
        public DeleteEventSourceResponse DeleteEventSourceWithOptions(DeleteEventSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventSourceResponse
        /// </returns>
        public async Task<DeleteEventSourceResponse> DeleteEventSourceWithOptionsAsync(DeleteEventSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventSourceResponse
        /// </returns>
        public DeleteEventSourceResponse DeleteEventSource(DeleteEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventSourceResponse
        /// </returns>
        public async Task<DeleteEventSourceResponse> DeleteEventSourceAsync(DeleteEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventStreamingResponse
        /// </returns>
        public DeleteEventStreamingResponse DeleteEventStreamingWithOptions(DeleteEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventStreamingResponse
        /// </returns>
        public async Task<DeleteEventStreamingResponse> DeleteEventStreamingWithOptionsAsync(DeleteEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventStreamingResponse
        /// </returns>
        public DeleteEventStreamingResponse DeleteEventStreaming(DeleteEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventStreamingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventStreamingResponse
        /// </returns>
        public async Task<DeleteEventStreamingResponse> DeleteEventStreamingAsync(DeleteEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventStreamingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public DeleteKnowledgeBaseResponse DeleteKnowledgeBaseWithOptions(DeleteKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public async Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseWithOptionsAsync(DeleteKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public DeleteKnowledgeBaseResponse DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public async Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableResponse
        /// </returns>
        public DeleteTableResponse DeleteTableWithOptions(DeleteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableResponse
        /// </returns>
        public async Task<DeleteTableResponse> DeleteTableWithOptionsAsync(DeleteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTableRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableResponse
        /// </returns>
        public DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTableRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableResponse
        /// </returns>
        public async Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes one or more event targets of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete one or more event targets of an event rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTargetsResponse
        /// </returns>
        public DeleteTargetsResponse DeleteTargetsWithOptions(DeleteTargetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTargetsShrinkRequest request = new DeleteTargetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TargetIds))
            {
                request.TargetIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TargetIds, "TargetIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIdsShrink))
            {
                query["TargetIds"] = request.TargetIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTargetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes one or more event targets of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete one or more event targets of an event rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTargetsResponse
        /// </returns>
        public async Task<DeleteTargetsResponse> DeleteTargetsWithOptionsAsync(DeleteTargetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTargetsShrinkRequest request = new DeleteTargetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TargetIds))
            {
                request.TargetIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TargetIds, "TargetIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIdsShrink))
            {
                query["TargetIds"] = request.TargetIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes one or more event targets of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete one or more event targets of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTargetsResponse
        /// </returns>
        public DeleteTargetsResponse DeleteTargets(DeleteTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTargetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes one or more event targets of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to delete one or more event targets of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTargetsResponse
        /// </returns>
        public async Task<DeleteTargetsResponse> DeleteTargetsAsync(DeleteTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTargetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to disable an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableRuleResponse
        /// </returns>
        public DisableRuleResponse DisableRuleWithOptions(DisableRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to disable an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableRuleResponse
        /// </returns>
        public async Task<DisableRuleResponse> DisableRuleWithOptionsAsync(DisableRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to disable an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableRuleResponse
        /// </returns>
        public DisableRuleResponse DisableRule(DisableRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to disable an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableRuleResponse
        /// </returns>
        public async Task<DisableRuleResponse> DisableRuleAsync(DisableRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Discovers the schema and simple data of an event source, such as MySQL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Discovers information about an event source.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DiscoverEventSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DiscoverEventSourceResponse
        /// </returns>
        public DiscoverEventSourceResponse DiscoverEventSourceWithOptions(DiscoverEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DiscoverEventSourceShrinkRequest request = new DiscoverEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMySQLParameters))
            {
                request.SourceMySQLParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMySQLParameters, "SourceMySQLParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMySQLParametersShrink))
            {
                body["SourceMySQLParameters"] = request.SourceMySQLParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiscoverEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiscoverEventSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Discovers the schema and simple data of an event source, such as MySQL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Discovers information about an event source.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DiscoverEventSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DiscoverEventSourceResponse
        /// </returns>
        public async Task<DiscoverEventSourceResponse> DiscoverEventSourceWithOptionsAsync(DiscoverEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DiscoverEventSourceShrinkRequest request = new DiscoverEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMySQLParameters))
            {
                request.SourceMySQLParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMySQLParameters, "SourceMySQLParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMySQLParametersShrink))
            {
                body["SourceMySQLParameters"] = request.SourceMySQLParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiscoverEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiscoverEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Discovers the schema and simple data of an event source, such as MySQL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Discovers information about an event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DiscoverEventSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DiscoverEventSourceResponse
        /// </returns>
        public DiscoverEventSourceResponse DiscoverEventSource(DiscoverEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DiscoverEventSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Discovers the schema and simple data of an event source, such as MySQL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Discovers information about an event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DiscoverEventSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DiscoverEventSourceResponse
        /// </returns>
        public async Task<DiscoverEventSourceResponse> DiscoverEventSourceAsync(DiscoverEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DiscoverEventSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to enable an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableRuleResponse
        /// </returns>
        public EnableRuleResponse EnableRuleWithOptions(EnableRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to enable an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableRuleResponse
        /// </returns>
        public async Task<EnableRuleResponse> EnableRuleWithOptionsAsync(EnableRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to enable an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableRuleResponse
        /// </returns>
        public EnableRuleResponse EnableRule(EnableRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to enable an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableRuleResponse
        /// </returns>
        public async Task<EnableRuleResponse> EnableRuleAsync(EnableRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events from the event center.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// EventCenterQueryEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EventCenterQueryEventsResponse
        /// </returns>
        public EventCenterQueryEventsResponse EventCenterQueryEventsWithOptions(EventCenterQueryEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EventCenterQueryEventsShrinkRequest request = new EventCenterQueryEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "Body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusName))
            {
                query["BusName"] = request.BusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["Body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EventCenterQueryEvents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EventCenterQueryEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events from the event center.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// EventCenterQueryEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EventCenterQueryEventsResponse
        /// </returns>
        public async Task<EventCenterQueryEventsResponse> EventCenterQueryEventsWithOptionsAsync(EventCenterQueryEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EventCenterQueryEventsShrinkRequest request = new EventCenterQueryEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "Body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusName))
            {
                query["BusName"] = request.BusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["Body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EventCenterQueryEvents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EventCenterQueryEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events from the event center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EventCenterQueryEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// EventCenterQueryEventsResponse
        /// </returns>
        public EventCenterQueryEventsResponse EventCenterQueryEvents(EventCenterQueryEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EventCenterQueryEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events from the event center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EventCenterQueryEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// EventCenterQueryEventsResponse
        /// </returns>
        public async Task<EventCenterQueryEventsResponse> EventCenterQueryEventsAsync(EventCenterQueryEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EventCenterQueryEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an agent data semantics generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAgentDataSemanticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateAgentDataSemanticsResponse
        /// </returns>
        public GenerateAgentDataSemanticsResponse GenerateAgentDataSemanticsWithOptions(GenerateAgentDataSemanticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAgentDataSemantics",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAgentDataSemanticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an agent data semantics generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAgentDataSemanticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateAgentDataSemanticsResponse
        /// </returns>
        public async Task<GenerateAgentDataSemanticsResponse> GenerateAgentDataSemanticsWithOptionsAsync(GenerateAgentDataSemanticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAgentDataSemantics",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAgentDataSemanticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an agent data semantics generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAgentDataSemanticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateAgentDataSemanticsResponse
        /// </returns>
        public GenerateAgentDataSemanticsResponse GenerateAgentDataSemantics(GenerateAgentDataSemanticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAgentDataSemanticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an agent data semantics generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateAgentDataSemanticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateAgentDataSemanticsResponse
        /// </returns>
        public async Task<GenerateAgentDataSemanticsResponse> GenerateAgentDataSemanticsAsync(GenerateAgentDataSemanticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAgentDataSemanticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves Agent metadata.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgentWithOptions(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves Agent metadata.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentWithOptionsAsync(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves Agent metadata.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgent(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves Agent metadata.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentAsync(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the currently effective data semantics of an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentDataSemanticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentDataSemanticsResponse
        /// </returns>
        public GetAgentDataSemanticsResponse GetAgentDataSemanticsWithOptions(GetAgentDataSemanticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentDataSemantics",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentDataSemanticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the currently effective data semantics of an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentDataSemanticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentDataSemanticsResponse
        /// </returns>
        public async Task<GetAgentDataSemanticsResponse> GetAgentDataSemanticsWithOptionsAsync(GetAgentDataSemanticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentDataSemantics",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentDataSemanticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the currently effective data semantics of an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentDataSemanticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentDataSemanticsResponse
        /// </returns>
        public GetAgentDataSemanticsResponse GetAgentDataSemantics(GetAgentDataSemanticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentDataSemanticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the currently effective data semantics of an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentDataSemanticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentDataSemanticsResponse
        /// </returns>
        public async Task<GetAgentDataSemanticsResponse> GetAgentDataSemanticsAsync(GetAgentDataSemanticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentDataSemanticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the information about an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetApiDestinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApiDestinationResponse
        /// </returns>
        public GetApiDestinationResponse GetApiDestinationWithOptions(GetApiDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiDestinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the information about an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetApiDestinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApiDestinationResponse
        /// </returns>
        public async Task<GetApiDestinationResponse> GetApiDestinationWithOptionsAsync(GetApiDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the information about an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetApiDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApiDestinationResponse
        /// </returns>
        public GetApiDestinationResponse GetApiDestination(GetApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApiDestinationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the information about an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetApiDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApiDestinationResponse
        /// </returns>
        public async Task<GetApiDestinationResponse> GetApiDestinationAsync(GetApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApiDestinationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a data catalog.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogResponse
        /// </returns>
        public GetCatalogResponse GetCatalogWithOptions(GetCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalog",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a data catalog.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogResponse
        /// </returns>
        public async Task<GetCatalogResponse> GetCatalogWithOptionsAsync(GetCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalog",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a data catalog.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogResponse
        /// </returns>
        public GetCatalogResponse GetCatalog(GetCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCatalogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a data catalog.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogResponse
        /// </returns>
        public async Task<GetCatalogResponse> GetCatalogAsync(GetCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCatalogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a chunk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChunkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChunkResponse
        /// </returns>
        public GetChunkResponse GetChunkWithOptions(GetChunkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSeq))
            {
                query["ChunkSeq"] = request.ChunkSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChunk",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChunkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a chunk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChunkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChunkResponse
        /// </returns>
        public async Task<GetChunkResponse> GetChunkWithOptionsAsync(GetChunkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSeq))
            {
                query["ChunkSeq"] = request.ChunkSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChunk",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChunkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a chunk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChunkResponse
        /// </returns>
        public GetChunkResponse GetChunk(GetChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChunkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a chunk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChunkResponse
        /// </returns>
        public async Task<GetChunkResponse> GetChunkAsync(GetChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChunkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of a single connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the configuration of a single connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionResponse
        /// </returns>
        public GetConnectionResponse GetConnectionWithOptions(GetConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of a single connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the configuration of a single connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionResponse
        /// </returns>
        public async Task<GetConnectionResponse> GetConnectionWithOptionsAsync(GetConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of a single connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the configuration of a single connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionResponse
        /// </returns>
        public GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of a single connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the configuration of a single connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionResponse
        /// </returns>
        public async Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentResponse
        /// </returns>
        public GetDocumentResponse GetDocumentWithOptions(GetDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocument",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentResponse
        /// </returns>
        public async Task<GetDocumentResponse> GetDocumentWithOptionsAsync(GetDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocument",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentResponse
        /// </returns>
        public GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentResponse
        /// </returns>
        public async Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the download URL of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentDownloadUrlResponse
        /// </returns>
        public GetDocumentDownloadUrlResponse GetDocumentDownloadUrlWithOptions(GetDocumentDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentDownloadUrl",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the download URL of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentDownloadUrlResponse
        /// </returns>
        public async Task<GetDocumentDownloadUrlResponse> GetDocumentDownloadUrlWithOptionsAsync(GetDocumentDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentDownloadUrl",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the download URL of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentDownloadUrlResponse
        /// </returns>
        public GetDocumentDownloadUrlResponse GetDocumentDownloadUrl(GetDocumentDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentDownloadUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the download URL of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentDownloadUrlResponse
        /// </returns>
        public async Task<GetDocumentDownloadUrlResponse> GetDocumentDownloadUrlAsync(GetDocumentDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentDownloadUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the detailed information about an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventBusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventBusResponse
        /// </returns>
        public GetEventBusResponse GetEventBusWithOptions(GetEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventBusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the detailed information about an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventBusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventBusResponse
        /// </returns>
        public async Task<GetEventBusResponse> GetEventBusWithOptionsAsync(GetEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventBusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the detailed information about an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventBusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventBusResponse
        /// </returns>
        public GetEventBusResponse GetEventBus(GetEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventBusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed information about an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the detailed information about an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventBusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventBusResponse
        /// </returns>
        public async Task<GetEventBusResponse> GetEventBusAsync(GetEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventBusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and operation progress of an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventHouseRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventHouseRuntimeResponse
        /// </returns>
        public GetEventHouseRuntimeResponse GetEventHouseRuntimeWithOptions(GetEventHouseRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventHouseRuntime",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventHouseRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and operation progress of an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventHouseRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventHouseRuntimeResponse
        /// </returns>
        public async Task<GetEventHouseRuntimeResponse> GetEventHouseRuntimeWithOptionsAsync(GetEventHouseRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventHouseRuntime",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventHouseRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and operation progress of an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventHouseRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventHouseRuntimeResponse
        /// </returns>
        public GetEventHouseRuntimeResponse GetEventHouseRuntime(GetEventHouseRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventHouseRuntimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and operation progress of an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventHouseRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventHouseRuntimeResponse
        /// </returns>
        public async Task<GetEventHouseRuntimeResponse> GetEventHouseRuntimeAsync(GetEventHouseRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventHouseRuntimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventStreamingResponse
        /// </returns>
        public GetEventStreamingResponse GetEventStreamingWithOptions(GetEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventStreamingResponse
        /// </returns>
        public async Task<GetEventStreamingResponse> GetEventStreamingWithOptionsAsync(GetEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventStreamingResponse
        /// </returns>
        public GetEventStreamingResponse GetEventStreaming(GetEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventStreamingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventStreamingResponse
        /// </returns>
        public async Task<GetEventStreamingResponse> GetEventStreamingAsync(GetEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventStreamingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the generation progress of data semantics for an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGenerateAgentDataSemanticsProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGenerateAgentDataSemanticsProgressResponse
        /// </returns>
        public GetGenerateAgentDataSemanticsProgressResponse GetGenerateAgentDataSemanticsProgressWithOptions(GetGenerateAgentDataSemanticsProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGenerateAgentDataSemanticsProgress",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGenerateAgentDataSemanticsProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the generation progress of data semantics for an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGenerateAgentDataSemanticsProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGenerateAgentDataSemanticsProgressResponse
        /// </returns>
        public async Task<GetGenerateAgentDataSemanticsProgressResponse> GetGenerateAgentDataSemanticsProgressWithOptionsAsync(GetGenerateAgentDataSemanticsProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGenerateAgentDataSemanticsProgress",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGenerateAgentDataSemanticsProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the generation progress of data semantics for an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGenerateAgentDataSemanticsProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGenerateAgentDataSemanticsProgressResponse
        /// </returns>
        public GetGenerateAgentDataSemanticsProgressResponse GetGenerateAgentDataSemanticsProgress(GetGenerateAgentDataSemanticsProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGenerateAgentDataSemanticsProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the generation progress of data semantics for an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGenerateAgentDataSemanticsProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGenerateAgentDataSemanticsProgressResponse
        /// </returns>
        public async Task<GetGenerateAgentDataSemanticsProgressResponse> GetGenerateAgentDataSemanticsProgressAsync(GetGenerateAgentDataSemanticsProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGenerateAgentDataSemanticsProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public GetKnowledgeBaseResponse GetKnowledgeBaseWithOptions(GetKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public async Task<GetKnowledgeBaseResponse> GetKnowledgeBaseWithOptionsAsync(GetKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public GetKnowledgeBaseResponse GetKnowledgeBase(GetKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public async Task<GetKnowledgeBaseResponse> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified data catalog bound to a Luma Agent. You can only query data catalogs that are already bound to the Agent. A ResourceNotFound error is returned for unbound catalogs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified data catalog bound to a Luma Agent. You can only query data catalogs that are already bound to the Agent. A ResourceNotFound error is returned for unbound catalogs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaCatalogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaCatalogResponse
        /// </returns>
        public GetLumaCatalogResponse GetLumaCatalogWithOptions(GetLumaCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaCatalog",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaCatalogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified data catalog bound to a Luma Agent. You can only query data catalogs that are already bound to the Agent. A ResourceNotFound error is returned for unbound catalogs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified data catalog bound to a Luma Agent. You can only query data catalogs that are already bound to the Agent. A ResourceNotFound error is returned for unbound catalogs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaCatalogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaCatalogResponse
        /// </returns>
        public async Task<GetLumaCatalogResponse> GetLumaCatalogWithOptionsAsync(GetLumaCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaCatalog",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified data catalog bound to a Luma Agent. You can only query data catalogs that are already bound to the Agent. A ResourceNotFound error is returned for unbound catalogs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified data catalog bound to a Luma Agent. You can only query data catalogs that are already bound to the Agent. A ResourceNotFound error is returned for unbound catalogs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaCatalogResponse
        /// </returns>
        public GetLumaCatalogResponse GetLumaCatalog(GetLumaCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLumaCatalogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified data catalog bound to a Luma Agent. You can only query data catalogs that are already bound to the Agent. A ResourceNotFound error is returned for unbound catalogs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified data catalog bound to a Luma Agent. You can only query data catalogs that are already bound to the Agent. A ResourceNotFound error is returned for unbound catalogs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaCatalogResponse
        /// </returns>
        public async Task<GetLumaCatalogResponse> GetLumaCatalogAsync(GetLumaCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLumaCatalogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the full content of a specified text chunk from a knowledge base bound to a Luma Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the full content of a specified text chunk from a knowledge base bound to a Luma Agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaChunkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaChunkResponse
        /// </returns>
        public GetLumaChunkResponse GetLumaChunkWithOptions(GetLumaChunkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSeq))
            {
                body["ChunkSeq"] = request.ChunkSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaChunk",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaChunkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the full content of a specified text chunk from a knowledge base bound to a Luma Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the full content of a specified text chunk from a knowledge base bound to a Luma Agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaChunkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaChunkResponse
        /// </returns>
        public async Task<GetLumaChunkResponse> GetLumaChunkWithOptionsAsync(GetLumaChunkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSeq))
            {
                body["ChunkSeq"] = request.ChunkSeq;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaChunk",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaChunkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the full content of a specified text chunk from a knowledge base bound to a Luma Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the full content of a specified text chunk from a knowledge base bound to a Luma Agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaChunkResponse
        /// </returns>
        public GetLumaChunkResponse GetLumaChunk(GetLumaChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLumaChunkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the full content of a specified text chunk from a knowledge base bound to a Luma Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the full content of a specified text chunk from a knowledge base bound to a Luma Agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaChunkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaChunkResponse
        /// </returns>
        public async Task<GetLumaChunkResponse> GetLumaChunkAsync(GetLumaChunkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLumaChunkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified document in the knowledge base bound to a Luma Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified document in the knowledge base bound to a Luma Agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaDocumentResponse
        /// </returns>
        public GetLumaDocumentResponse GetLumaDocumentWithOptions(GetLumaDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaDocument",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified document in the knowledge base bound to a Luma Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified document in the knowledge base bound to a Luma Agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaDocumentResponse
        /// </returns>
        public async Task<GetLumaDocumentResponse> GetLumaDocumentWithOptionsAsync(GetLumaDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaDocument",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified document in the knowledge base bound to a Luma Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified document in the knowledge base bound to a Luma Agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaDocumentResponse
        /// </returns>
        public GetLumaDocumentResponse GetLumaDocument(GetLumaDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLumaDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified document in the knowledge base bound to a Luma Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified document in the knowledge base bound to a Luma Agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaDocumentResponse
        /// </returns>
        public async Task<GetLumaDocumentResponse> GetLumaDocumentAsync(GetLumaDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLumaDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for a specified document in the knowledge base bound to a Luma Agent. The URL is valid for one hour by default.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for a specified document in the knowledge base bound to a Luma Agent. The URL is valid for one hour by default.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaDocumentDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaDocumentDownloadUrlResponse
        /// </returns>
        public GetLumaDocumentDownloadUrlResponse GetLumaDocumentDownloadUrlWithOptions(GetLumaDocumentDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaDocumentDownloadUrl",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaDocumentDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for a specified document in the knowledge base bound to a Luma Agent. The URL is valid for one hour by default.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for a specified document in the knowledge base bound to a Luma Agent. The URL is valid for one hour by default.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaDocumentDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaDocumentDownloadUrlResponse
        /// </returns>
        public async Task<GetLumaDocumentDownloadUrlResponse> GetLumaDocumentDownloadUrlWithOptionsAsync(GetLumaDocumentDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaDocumentDownloadUrl",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaDocumentDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for a specified document in the knowledge base bound to a Luma Agent. The URL is valid for one hour by default.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for a specified document in the knowledge base bound to a Luma Agent. The URL is valid for one hour by default.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaDocumentDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaDocumentDownloadUrlResponse
        /// </returns>
        public GetLumaDocumentDownloadUrlResponse GetLumaDocumentDownloadUrl(GetLumaDocumentDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLumaDocumentDownloadUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for a specified document in the knowledge base bound to a Luma Agent. The URL is valid for one hour by default.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for a specified document in the knowledge base bound to a Luma Agent. The URL is valid for one hour by default.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaDocumentDownloadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaDocumentDownloadUrlResponse
        /// </returns>
        public async Task<GetLumaDocumentDownloadUrlResponse> GetLumaDocumentDownloadUrlAsync(GetLumaDocumentDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLumaDocumentDownloadUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified knowledge base bound to a Luma Agent, including the vector model, chunking configuration, and retrieval configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified knowledge base bound to a Luma Agent, including the vector model, chunking configuration, and retrieval configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaKnowledgeBaseResponse
        /// </returns>
        public GetLumaKnowledgeBaseResponse GetLumaKnowledgeBaseWithOptions(GetLumaKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified knowledge base bound to a Luma Agent, including the vector model, chunking configuration, and retrieval configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified knowledge base bound to a Luma Agent, including the vector model, chunking configuration, and retrieval configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaKnowledgeBaseResponse
        /// </returns>
        public async Task<GetLumaKnowledgeBaseResponse> GetLumaKnowledgeBaseWithOptionsAsync(GetLumaKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified knowledge base bound to a Luma Agent, including the vector model, chunking configuration, and retrieval configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified knowledge base bound to a Luma Agent, including the vector model, chunking configuration, and retrieval configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaKnowledgeBaseResponse
        /// </returns>
        public GetLumaKnowledgeBaseResponse GetLumaKnowledgeBase(GetLumaKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLumaKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified knowledge base bound to a Luma Agent, including the vector model, chunking configuration, and retrieval configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified knowledge base bound to a Luma Agent, including the vector model, chunking configuration, and retrieval configuration.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaKnowledgeBaseResponse
        /// </returns>
        public async Task<GetLumaKnowledgeBaseResponse> GetLumaKnowledgeBaseAsync(GetLumaKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLumaKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified namespace bound to a Luma Agent. Only namespaces that are already bound to the Agent can be queried.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified namespace bound to a Luma Agent. Only namespaces that are already bound to the Agent can be queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaNamespaceResponse
        /// </returns>
        public GetLumaNamespaceResponse GetLumaNamespaceWithOptions(GetLumaNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified namespace bound to a Luma Agent. Only namespaces that are already bound to the Agent can be queried.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified namespace bound to a Luma Agent. Only namespaces that are already bound to the Agent can be queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaNamespaceResponse
        /// </returns>
        public async Task<GetLumaNamespaceResponse> GetLumaNamespaceWithOptionsAsync(GetLumaNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified namespace bound to a Luma Agent. Only namespaces that are already bound to the Agent can be queried.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified namespace bound to a Luma Agent. Only namespaces that are already bound to the Agent can be queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaNamespaceResponse
        /// </returns>
        public GetLumaNamespaceResponse GetLumaNamespace(GetLumaNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLumaNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified namespace bound to a Luma Agent. Only namespaces that are already bound to the Agent can be queried.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified namespace bound to a Luma Agent. Only namespaces that are already bound to the Agent can be queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaNamespaceResponse
        /// </returns>
        public async Task<GetLumaNamespaceResponse> GetLumaNamespaceAsync(GetLumaNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLumaNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified event table bound to a Luma Agent, including column definitions and the data retention policy. Only event tables that are already bound to the Agent can be queried.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified event table bound to a Luma Agent, including column definitions and the data retention policy. Only event tables that are already bound to the Agent can be queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaTableResponse
        /// </returns>
        public GetLumaTableResponse GetLumaTableWithOptions(GetLumaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified event table bound to a Luma Agent, including column definitions and the data retention policy. Only event tables that are already bound to the Agent can be queried.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified event table bound to a Luma Agent, including column definitions and the data retention policy. Only event tables that are already bound to the Agent can be queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLumaTableResponse
        /// </returns>
        public async Task<GetLumaTableResponse> GetLumaTableWithOptionsAsync(GetLumaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLumaTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLumaTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified event table bound to a Luma Agent, including column definitions and the data retention policy. Only event tables that are already bound to the Agent can be queried.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified event table bound to a Luma Agent, including column definitions and the data retention policy. Only event tables that are already bound to the Agent can be queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaTableRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaTableResponse
        /// </returns>
        public GetLumaTableResponse GetLumaTable(GetLumaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLumaTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified event table bound to a Luma Agent, including column definitions and the data retention policy. Only event tables that are already bound to the Agent can be queried.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a specified event table bound to a Luma Agent, including column definitions and the data retention policy. Only event tables that are already bound to the Agent can be queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetLumaTableRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLumaTableResponse
        /// </returns>
        public async Task<GetLumaTableResponse> GetLumaTableAsync(GetLumaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLumaTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNamespaceResponse
        /// </returns>
        public GetNamespaceResponse GetNamespaceWithOptions(GetNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNamespaceResponse
        /// </returns>
        public async Task<GetNamespaceResponse> GetNamespaceWithOptionsAsync(GetNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNamespaceResponse
        /// </returns>
        public GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNamespaceResponse
        /// </returns>
        public async Task<GetNamespaceResponse> GetNamespaceAsync(GetNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Gets the details of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleResponse
        /// </returns>
        public GetRuleResponse GetRuleWithOptions(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Gets the details of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleResponse
        /// </returns>
        public async Task<GetRuleResponse> GetRuleWithOptionsAsync(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Gets the details of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleResponse
        /// </returns>
        public GetRuleResponse GetRule(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Gets the details of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleResponse
        /// </returns>
        public async Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
        public GetTableResponse GetTableWithOptions(GetTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
        public async Task<GetTableResponse> GetTableWithOptionsAsync(GetTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
        public GetTableResponse GetTable(GetTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
        public async Task<GetTableResponse> GetTableAsync(GetTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of custom agents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgentsWithOptions(ListAgentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.After))
            {
                body["After"] = request.After;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of custom agents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsWithOptionsAsync(ListAgentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.After))
            {
                body["After"] = request.After;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of custom agents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAgentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of custom agents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAgentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all Alibaba Cloud service event sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all Alibaba Cloud service event sources.</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAliyunOfficialEventSourcesResponse
        /// </returns>
        public ListAliyunOfficialEventSourcesResponse ListAliyunOfficialEventSourcesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliyunOfficialEventSources",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliyunOfficialEventSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all Alibaba Cloud service event sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all Alibaba Cloud service event sources.</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAliyunOfficialEventSourcesResponse
        /// </returns>
        public async Task<ListAliyunOfficialEventSourcesResponse> ListAliyunOfficialEventSourcesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliyunOfficialEventSources",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliyunOfficialEventSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all Alibaba Cloud service event sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all Alibaba Cloud service event sources.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListAliyunOfficialEventSourcesResponse
        /// </returns>
        public ListAliyunOfficialEventSourcesResponse ListAliyunOfficialEventSources()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAliyunOfficialEventSourcesWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all Alibaba Cloud service event sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all Alibaba Cloud service event sources.</para>
        /// </description>
        /// 
        /// <returns>
        /// ListAliyunOfficialEventSourcesResponse
        /// </returns>
        public async Task<ListAliyunOfficialEventSourcesResponse> ListAliyunOfficialEventSourcesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAliyunOfficialEventSourcesWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of API destinations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this API operation to query a list of API destinations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApiDestinationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiDestinationsResponse
        /// </returns>
        public ListApiDestinationsResponse ListApiDestinationsWithOptions(ListApiDestinationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationNamePrefix))
            {
                query["ApiDestinationNamePrefix"] = request.ApiDestinationNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiDestinations",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiDestinationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of API destinations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this API operation to query a list of API destinations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApiDestinationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiDestinationsResponse
        /// </returns>
        public async Task<ListApiDestinationsResponse> ListApiDestinationsWithOptionsAsync(ListApiDestinationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationNamePrefix))
            {
                query["ApiDestinationNamePrefix"] = request.ApiDestinationNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiDestinations",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiDestinationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of API destinations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this API operation to query a list of API destinations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApiDestinationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiDestinationsResponse
        /// </returns>
        public ListApiDestinationsResponse ListApiDestinations(ListApiDestinationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApiDestinationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of API destinations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use this API operation to query a list of API destinations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApiDestinationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiDestinationsResponse
        /// </returns>
        public async Task<ListApiDestinationsResponse> ListApiDestinationsAsync(ListApiDestinationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApiDestinationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of data catalogs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public ListCatalogsResponse ListCatalogsWithOptions(ListCatalogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCatalogs",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCatalogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of data catalogs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public async Task<ListCatalogsResponse> ListCatalogsWithOptionsAsync(ListCatalogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCatalogs",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCatalogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of data catalogs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public ListCatalogsResponse ListCatalogs(ListCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCatalogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of data catalogs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public async Task<ListCatalogsResponse> ListCatalogsAsync(ListCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCatalogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of document chunks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChunksResponse
        /// </returns>
        public ListChunksResponse ListChunksWithOptions(ListChunksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChunks",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChunksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of document chunks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChunksResponse
        /// </returns>
        public async Task<ListChunksResponse> ListChunksWithOptionsAsync(ListChunksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChunks",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChunksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of document chunks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChunksResponse
        /// </returns>
        public ListChunksResponse ListChunks(ListChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChunksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of document chunks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChunksResponse
        /// </returns>
        public async Task<ListChunksResponse> ListChunksAsync(ListChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChunksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of connection configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of connection configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public ListConnectionsResponse ListConnectionsWithOptions(ListConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionNamePrefix))
            {
                body["ConnectionNamePrefix"] = request.ConnectionNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeType))
            {
                body["ExcludeType"] = request.ExcludeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of connection configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of connection configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public async Task<ListConnectionsResponse> ListConnectionsWithOptionsAsync(ListConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionNamePrefix))
            {
                body["ConnectionNamePrefix"] = request.ConnectionNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeType))
            {
                body["ExcludeType"] = request.ExcludeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of connection configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of connection configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of connection configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a list of connection configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public async Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of documents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentsResponse
        /// </returns>
        public ListDocumentsResponse ListDocumentsWithOptions(ListDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNamePrefix))
            {
                query["FileNamePrefix"] = request.FileNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocuments",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of documents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentsResponse
        /// </returns>
        public async Task<ListDocumentsResponse> ListDocumentsWithOptionsAsync(ListDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNamePrefix))
            {
                query["FileNamePrefix"] = request.FileNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocuments",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of documents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentsResponse
        /// </returns>
        public ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDocumentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of documents.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentsResponse
        /// </returns>
        public async Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDocumentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all event buses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all event buses.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEventBusesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventBusesResponse
        /// </returns>
        public ListEventBusesResponse ListEventBusesWithOptions(ListEventBusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventBuses",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventBusesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all event buses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all event buses.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEventBusesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventBusesResponse
        /// </returns>
        public async Task<ListEventBusesResponse> ListEventBusesWithOptionsAsync(ListEventBusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventBuses",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventBusesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all event buses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all event buses.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEventBusesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventBusesResponse
        /// </returns>
        public ListEventBusesResponse ListEventBuses(ListEventBusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventBusesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all event buses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all event buses.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEventBusesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventBusesResponse
        /// </returns>
        public async Task<ListEventBusesResponse> ListEventBusesAsync(ListEventBusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventBusesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of EventHouse runtimes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventHouseRuntimesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventHouseRuntimesResponse
        /// </returns>
        public ListEventHouseRuntimesResponse ListEventHouseRuntimesWithOptions(ListEventHouseRuntimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventHouseRuntimes",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventHouseRuntimesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of EventHouse runtimes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventHouseRuntimesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventHouseRuntimesResponse
        /// </returns>
        public async Task<ListEventHouseRuntimesResponse> ListEventHouseRuntimesWithOptionsAsync(ListEventHouseRuntimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventHouseRuntimes",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventHouseRuntimesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of EventHouse runtimes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventHouseRuntimesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventHouseRuntimesResponse
        /// </returns>
        public ListEventHouseRuntimesResponse ListEventHouseRuntimes(ListEventHouseRuntimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventHouseRuntimesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of EventHouse runtimes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventHouseRuntimesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventHouseRuntimesResponse
        /// </returns>
        public async Task<ListEventHouseRuntimesResponse> ListEventHouseRuntimesAsync(ListEventHouseRuntimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventHouseRuntimesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event streams.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries event streams.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEventStreamingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventStreamingsResponse
        /// </returns>
        public ListEventStreamingsResponse ListEventStreamingsWithOptions(ListEventStreamingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                body["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkArn))
            {
                body["SinkArn"] = request.SinkArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["SourceArn"] = request.SourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventStreamings",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventStreamingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event streams.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries event streams.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEventStreamingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventStreamingsResponse
        /// </returns>
        public async Task<ListEventStreamingsResponse> ListEventStreamingsWithOptionsAsync(ListEventStreamingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                body["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkArn))
            {
                body["SinkArn"] = request.SinkArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["SourceArn"] = request.SourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventStreamings",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventStreamingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event streams.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries event streams.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEventStreamingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventStreamingsResponse
        /// </returns>
        public ListEventStreamingsResponse ListEventStreamings(ListEventStreamingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventStreamingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event streams.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries event streams.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListEventStreamingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventStreamingsResponse
        /// </returns>
        public async Task<ListEventStreamingsResponse> ListEventStreamingsAsync(ListEventStreamingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventStreamingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of knowledge bases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public ListKnowledgeBasesResponse ListKnowledgeBasesWithOptions(ListKnowledgeBasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBases",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of knowledge bases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public async Task<ListKnowledgeBasesResponse> ListKnowledgeBasesWithOptionsAsync(ListKnowledgeBasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBases",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of knowledge bases.</para>
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
            return ListKnowledgeBasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of knowledge bases.</para>
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
            return await ListKnowledgeBasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all data catalogs bound to a Luma Agent. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the data catalogs bound to a Luma Agent. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient page count to determine whether the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaCatalogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaCatalogsResponse
        /// </returns>
        public ListLumaCatalogsResponse ListLumaCatalogsWithOptions(ListLumaCatalogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaCatalogs",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaCatalogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all data catalogs bound to a Luma Agent. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the data catalogs bound to a Luma Agent. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient page count to determine whether the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaCatalogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaCatalogsResponse
        /// </returns>
        public async Task<ListLumaCatalogsResponse> ListLumaCatalogsWithOptionsAsync(ListLumaCatalogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaCatalogs",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaCatalogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all data catalogs bound to a Luma Agent. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the data catalogs bound to a Luma Agent. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient page count to determine whether the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaCatalogsResponse
        /// </returns>
        public ListLumaCatalogsResponse ListLumaCatalogs(ListLumaCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLumaCatalogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all data catalogs bound to a Luma Agent. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the data catalogs bound to a Luma Agent. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient page count to determine whether the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaCatalogsResponse
        /// </returns>
        public async Task<ListLumaCatalogsResponse> ListLumaCatalogsAsync(ListLumaCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLumaCatalogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists text chunks in a knowledge base bound to a Luma Agent, with support for filtering by document, keyword, and enabled status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists text chunks in a knowledge base bound to a Luma Agent, with support for filtering by document, keyword, and enabled status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaChunksResponse
        /// </returns>
        public ListLumaChunksResponse ListLumaChunksWithOptions(ListLumaChunksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaChunks",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaChunksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists text chunks in a knowledge base bound to a Luma Agent, with support for filtering by document, keyword, and enabled status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists text chunks in a knowledge base bound to a Luma Agent, with support for filtering by document, keyword, and enabled status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaChunksResponse
        /// </returns>
        public async Task<ListLumaChunksResponse> ListLumaChunksWithOptionsAsync(ListLumaChunksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaChunks",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaChunksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists text chunks in a knowledge base bound to a Luma Agent, with support for filtering by document, keyword, and enabled status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists text chunks in a knowledge base bound to a Luma Agent, with support for filtering by document, keyword, and enabled status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaChunksResponse
        /// </returns>
        public ListLumaChunksResponse ListLumaChunks(ListLumaChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLumaChunksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists text chunks in a knowledge base bound to a Luma Agent, with support for filtering by document, keyword, and enabled status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists text chunks in a knowledge base bound to a Luma Agent, with support for filtering by document, keyword, and enabled status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaChunksResponse
        /// </returns>
        public async Task<ListLumaChunksResponse> ListLumaChunksAsync(ListLumaChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLumaChunksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists documents in a knowledge base bound to a Luma Agent, with support for filtering by file name prefix and processing status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists documents in a knowledge base bound to a Luma Agent, with support for filtering by file name prefix and processing status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaDocumentsResponse
        /// </returns>
        public ListLumaDocumentsResponse ListLumaDocumentsWithOptions(ListLumaDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNamePrefix))
            {
                body["FileNamePrefix"] = request.FileNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaDocuments",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists documents in a knowledge base bound to a Luma Agent, with support for filtering by file name prefix and processing status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists documents in a knowledge base bound to a Luma Agent, with support for filtering by file name prefix and processing status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaDocumentsResponse
        /// </returns>
        public async Task<ListLumaDocumentsResponse> ListLumaDocumentsWithOptionsAsync(ListLumaDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNamePrefix))
            {
                body["FileNamePrefix"] = request.FileNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaDocuments",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists documents in a knowledge base bound to a Luma Agent, with support for filtering by file name prefix and processing status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists documents in a knowledge base bound to a Luma Agent, with support for filtering by file name prefix and processing status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaDocumentsResponse
        /// </returns>
        public ListLumaDocumentsResponse ListLumaDocuments(ListLumaDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLumaDocumentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists documents in a knowledge base bound to a Luma Agent, with support for filtering by file name prefix and processing status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists documents in a knowledge base bound to a Luma Agent, with support for filtering by file name prefix and processing status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaDocumentsResponse
        /// </returns>
        public async Task<ListLumaDocumentsResponse> ListLumaDocumentsAsync(ListLumaDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLumaDocumentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all knowledge bases bound to a Luma Agent in a specified namespace. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the knowledge bases bound to a Luma Agent in a specified namespace. Results are returned in pages. To retrieve the next page, pass the NextToken value from the previous response. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than MaxResults. Do not determine whether the last page is reached based on an insufficient number of entries on the current page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaKnowledgeBasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaKnowledgeBasesResponse
        /// </returns>
        public ListLumaKnowledgeBasesResponse ListLumaKnowledgeBasesWithOptions(ListLumaKnowledgeBasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaKnowledgeBases",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaKnowledgeBasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all knowledge bases bound to a Luma Agent in a specified namespace. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the knowledge bases bound to a Luma Agent in a specified namespace. Results are returned in pages. To retrieve the next page, pass the NextToken value from the previous response. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than MaxResults. Do not determine whether the last page is reached based on an insufficient number of entries on the current page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaKnowledgeBasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaKnowledgeBasesResponse
        /// </returns>
        public async Task<ListLumaKnowledgeBasesResponse> ListLumaKnowledgeBasesWithOptionsAsync(ListLumaKnowledgeBasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaKnowledgeBases",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaKnowledgeBasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all knowledge bases bound to a Luma Agent in a specified namespace. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the knowledge bases bound to a Luma Agent in a specified namespace. Results are returned in pages. To retrieve the next page, pass the NextToken value from the previous response. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than MaxResults. Do not determine whether the last page is reached based on an insufficient number of entries on the current page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaKnowledgeBasesResponse
        /// </returns>
        public ListLumaKnowledgeBasesResponse ListLumaKnowledgeBases(ListLumaKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLumaKnowledgeBasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all knowledge bases bound to a Luma Agent in a specified namespace. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the knowledge bases bound to a Luma Agent in a specified namespace. Results are returned in pages. To retrieve the next page, pass the NextToken value from the previous response. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than MaxResults. Do not determine whether the last page is reached based on an insufficient number of entries on the current page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaKnowledgeBasesResponse
        /// </returns>
        public async Task<ListLumaKnowledgeBasesResponse> ListLumaKnowledgeBasesAsync(ListLumaKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLumaKnowledgeBasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all namespaces bound to a Luma Agent under a specified data catalog. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the namespaces bound to a Luma Agent under a specified data catalog. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient number of entries on the current page to determine whether the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaNamespacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaNamespacesResponse
        /// </returns>
        public ListLumaNamespacesResponse ListLumaNamespacesWithOptions(ListLumaNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaNamespaces",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all namespaces bound to a Luma Agent under a specified data catalog. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the namespaces bound to a Luma Agent under a specified data catalog. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient number of entries on the current page to determine whether the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaNamespacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaNamespacesResponse
        /// </returns>
        public async Task<ListLumaNamespacesResponse> ListLumaNamespacesWithOptionsAsync(ListLumaNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaNamespaces",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all namespaces bound to a Luma Agent under a specified data catalog. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the namespaces bound to a Luma Agent under a specified data catalog. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient number of entries on the current page to determine whether the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaNamespacesResponse
        /// </returns>
        public ListLumaNamespacesResponse ListLumaNamespaces(ListLumaNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLumaNamespacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all namespaces bound to a Luma Agent under a specified data catalog. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the namespaces bound to a Luma Agent under a specified data catalog. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient number of entries on the current page to determine whether the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaNamespacesResponse
        /// </returns>
        public async Task<ListLumaNamespacesResponse> ListLumaNamespacesAsync(ListLumaNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLumaNamespacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all event tables bound to a Luma Agent in a specified namespace. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the event tables bound to a Luma Agent in a specified namespace. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient number of entries on the current page to determine that the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaTablesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaTablesResponse
        /// </returns>
        public ListLumaTablesResponse ListLumaTablesWithOptions(ListLumaTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaTables",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all event tables bound to a Luma Agent in a specified namespace. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the event tables bound to a Luma Agent in a specified namespace. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient number of entries on the current page to determine that the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaTablesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLumaTablesResponse
        /// </returns>
        public async Task<ListLumaTablesResponse> ListLumaTablesWithOptionsAsync(ListLumaTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLumaTables",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLumaTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all event tables bound to a Luma Agent in a specified namespace. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the event tables bound to a Luma Agent in a specified namespace. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient number of entries on the current page to determine that the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaTablesResponse
        /// </returns>
        public ListLumaTablesResponse ListLumaTables(ListLumaTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLumaTablesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all event tables bound to a Luma Agent in a specified namespace. Returns the complete set of bindings without pagination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the event tables bound to a Luma Agent in a specified namespace. Results are returned in pages. Pass the NextToken from the previous response to retrieve the next page. An empty NextToken indicates that no more data is available. Expired bindings are skipped, so the number of entries on a single page may be less than the Limit value. Do not use an insufficient number of entries on the current page to determine that the last page has been reached.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLumaTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLumaTablesResponse
        /// </returns>
        public async Task<ListLumaTablesResponse> ListLumaTablesAsync(ListLumaTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLumaTablesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query namespace list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNamespacesResponse
        /// </returns>
        public ListNamespacesResponse ListNamespacesWithOptions(ListNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespaces",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query namespace list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNamespacesResponse
        /// </returns>
        public async Task<ListNamespacesResponse> ListNamespacesWithOptionsAsync(ListNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespaces",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query namespace list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNamespacesResponse
        /// </returns>
        public ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNamespacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query namespace list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNamespacesResponse
        /// </returns>
        public async Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNamespacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all rules of an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all rules of an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public ListRulesResponse ListRulesWithOptions(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNamePrefix))
            {
                query["RuleNamePrefix"] = request.RuleNamePrefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRules",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all rules of an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all rules of an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNamePrefix))
            {
                query["RuleNamePrefix"] = request.RuleNamePrefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRules",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all rules of an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all rules of an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all rules of an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query all rules of an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query table list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTablesWithOptions(ListTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query table list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesWithOptionsAsync(ListTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query table list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTables(ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTablesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query table list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTablesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all event targets of an event rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTargetsResponse
        /// </returns>
        public ListTargetsResponse ListTargetsWithOptions(ListTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["Arn"] = request.Arn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTargetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all event targets of an event rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTargetsResponse
        /// </returns>
        public async Task<ListTargetsResponse> ListTargetsWithOptionsAsync(ListTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["Arn"] = request.Arn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all event targets of an event rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTargetsResponse
        /// </returns>
        public ListTargetsResponse ListTargets(ListTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTargetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all event targets of an event rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTargetsResponse
        /// </returns>
        public async Task<ListTargetsResponse> ListTargetsAsync(ListTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTargetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries all custom event sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries all custom event sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserDefinedEventSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserDefinedEventSourcesResponse
        /// </returns>
        public ListUserDefinedEventSourcesResponse ListUserDefinedEventSourcesWithOptions(ListUserDefinedEventSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDefinedEventSources",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDefinedEventSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries all custom event sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries all custom event sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserDefinedEventSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserDefinedEventSourcesResponse
        /// </returns>
        public async Task<ListUserDefinedEventSourcesResponse> ListUserDefinedEventSourcesWithOptionsAsync(ListUserDefinedEventSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDefinedEventSources",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDefinedEventSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries all custom event sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries all custom event sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserDefinedEventSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserDefinedEventSourcesResponse
        /// </returns>
        public ListUserDefinedEventSourcesResponse ListUserDefinedEventSources(ListUserDefinedEventSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDefinedEventSourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries all custom event sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries all custom event sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUserDefinedEventSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserDefinedEventSourcesResponse
        /// </returns>
        public async Task<ListUserDefinedEventSourcesResponse> ListUserDefinedEventSourcesAsync(ListUserDefinedEventSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDefinedEventSourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a running event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pauses a running event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseEventStreamingResponse
        /// </returns>
        public PauseEventStreamingResponse PauseEventStreamingWithOptions(PauseEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a running event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pauses a running event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseEventStreamingResponse
        /// </returns>
        public async Task<PauseEventStreamingResponse> PauseEventStreamingWithOptionsAsync(PauseEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a running event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pauses a running event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseEventStreamingResponse
        /// </returns>
        public PauseEventStreamingResponse PauseEventStreaming(PauseEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PauseEventStreamingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a running event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pauses a running event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PauseEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseEventStreamingResponse
        /// </returns>
        public async Task<PauseEventStreamingResponse> PauseEventStreamingAsync(PauseEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PauseEventStreamingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Polls for the result of a natural language query.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PollAskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PollAskResultResponse
        /// </returns>
        public PollAskResultResponse PollAskResultWithOptions(PollAskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PollAskResult",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PollAskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Polls for the result of a natural language query.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PollAskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PollAskResultResponse
        /// </returns>
        public async Task<PollAskResultResponse> PollAskResultWithOptionsAsync(PollAskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PollAskResult",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PollAskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Polls for the result of a natural language query.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PollAskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// PollAskResultResponse
        /// </returns>
        public PollAskResultResponse PollAskResult(PollAskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PollAskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Polls for the result of a natural language query.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PollAskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// PollAskResultResponse
        /// </returns>
        public async Task<PollAskResultResponse> PollAskResultAsync(PollAskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PollAskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends events to an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sends one or more events to an event bus.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PutEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutEventsResponse
        /// </returns>
        public PutEventsResponse PutEventsWithOptions(PutEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PutEventsShrinkRequest request = new PutEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventList))
            {
                request.EventListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventList, "EventList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventListShrink))
            {
                body["EventList"] = request.EventListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEvents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends events to an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sends one or more events to an event bus.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PutEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutEventsResponse
        /// </returns>
        public async Task<PutEventsResponse> PutEventsWithOptionsAsync(PutEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PutEventsShrinkRequest request = new PutEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventList))
            {
                request.EventListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventList, "EventList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventListShrink))
            {
                body["EventList"] = request.EventListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEvents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends events to an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sends one or more events to an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// PutEventsResponse
        /// </returns>
        public PutEventsResponse PutEvents(PutEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends events to an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sends one or more events to an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// PutEventsResponse
        /// </returns>
        public async Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create or update event targets for the specified rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates or updates event targets for a specified rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PutTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutTargetsResponse
        /// </returns>
        public PutTargetsResponse PutTargetsWithOptions(PutTargetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PutTargetsShrinkRequest request = new PutTargetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Targets))
            {
                request.TargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Targets, "Targets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetsShrink))
            {
                query["Targets"] = request.TargetsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutTargetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create or update event targets for the specified rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates or updates event targets for a specified rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PutTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutTargetsResponse
        /// </returns>
        public async Task<PutTargetsResponse> PutTargetsWithOptionsAsync(PutTargetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PutTargetsShrinkRequest request = new PutTargetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Targets))
            {
                request.TargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Targets, "Targets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetsShrink))
            {
                query["Targets"] = request.TargetsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create or update event targets for the specified rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates or updates event targets for a specified rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// PutTargetsResponse
        /// </returns>
        public PutTargetsResponse PutTargets(PutTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutTargetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create or update event targets for the specified rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates or updates event targets for a specified rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PutTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// PutTargetsResponse
        /// </returns>
        public async Task<PutTargetsResponse> PutTargetsAsync(PutTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutTargetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history logs of natural language queries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAskLumaLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAskLumaLogResponse
        /// </returns>
        public QueryAskLumaLogResponse QueryAskLumaLogWithOptions(QueryAskLumaLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.After))
            {
                body["After"] = request.After;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAskLumaLog",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAskLumaLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history logs of natural language queries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAskLumaLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAskLumaLogResponse
        /// </returns>
        public async Task<QueryAskLumaLogResponse> QueryAskLumaLogWithOptionsAsync(QueryAskLumaLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.After))
            {
                body["After"] = request.After;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAskLumaLog",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAskLumaLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history logs of natural language queries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAskLumaLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAskLumaLogResponse
        /// </returns>
        public QueryAskLumaLogResponse QueryAskLumaLog(QueryAskLumaLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAskLumaLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the history logs of natural language queries.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAskLumaLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAskLumaLogResponse
        /// </returns>
        public async Task<QueryAskLumaLogResponse> QueryAskLumaLogAsync(QueryAskLumaLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAskLumaLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the content of an event.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the content of an event.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEventResponse
        /// </returns>
        public QueryEventResponse QueryEventWithOptions(QueryEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEvent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the content of an event.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the content of an event.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEventResponse
        /// </returns>
        public async Task<QueryEventResponse> QueryEventWithOptionsAsync(QueryEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEvent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the content of an event.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the content of an event.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEventResponse
        /// </returns>
        public QueryEventResponse QueryEvent(QueryEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the content of an event.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the content of an event.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEventResponse
        /// </returns>
        public async Task<QueryEventResponse> QueryEventAsync(QueryEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query event store data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEventHouseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEventHouseResponse
        /// </returns>
        public QueryEventHouseResponse QueryEventHouseWithOptions(QueryEventHouseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventHouse",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventHouseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query event store data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEventHouseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEventHouseResponse
        /// </returns>
        public async Task<QueryEventHouseResponse> QueryEventHouseWithOptionsAsync(QueryEventHouseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventHouse",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventHouseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query event store data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEventHouseRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEventHouseResponse
        /// </returns>
        public QueryEventHouseResponse QueryEventHouse(QueryEventHouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventHouseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query event store data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEventHouseRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEventHouseResponse
        /// </returns>
        public async Task<QueryEventHouseResponse> QueryEventHouseAsync(QueryEventHouseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventHouseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a read-only SQL statement to query internal EventHouse data within a specified time range. The time range only constrains the internal EventHouse data referenced in the SQL statement and does not affect mounted external data sources. Returns a structured result set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Executes a single read-only SQL statement and returns a structured result set. BeginTime and EndTime only constrain the internal EventHouse data referenced in the SQL statement and do not affect mounted external data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventHouseWithTimeRangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEventHouseWithTimeRangeResponse
        /// </returns>
        public QueryEventHouseWithTimeRangeResponse QueryEventHouseWithTimeRangeWithOptions(QueryEventHouseWithTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventHouseWithTimeRange",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventHouseWithTimeRangeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a read-only SQL statement to query internal EventHouse data within a specified time range. The time range only constrains the internal EventHouse data referenced in the SQL statement and does not affect mounted external data sources. Returns a structured result set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Executes a single read-only SQL statement and returns a structured result set. BeginTime and EndTime only constrain the internal EventHouse data referenced in the SQL statement and do not affect mounted external data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventHouseWithTimeRangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEventHouseWithTimeRangeResponse
        /// </returns>
        public async Task<QueryEventHouseWithTimeRangeResponse> QueryEventHouseWithTimeRangeWithOptionsAsync(QueryEventHouseWithTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventHouseWithTimeRange",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventHouseWithTimeRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a read-only SQL statement to query internal EventHouse data within a specified time range. The time range only constrains the internal EventHouse data referenced in the SQL statement and does not affect mounted external data sources. Returns a structured result set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Executes a single read-only SQL statement and returns a structured result set. BeginTime and EndTime only constrain the internal EventHouse data referenced in the SQL statement and do not affect mounted external data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventHouseWithTimeRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEventHouseWithTimeRangeResponse
        /// </returns>
        public QueryEventHouseWithTimeRangeResponse QueryEventHouseWithTimeRange(QueryEventHouseWithTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventHouseWithTimeRangeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a read-only SQL statement to query internal EventHouse data within a specified time range. The time range only constrains the internal EventHouse data referenced in the SQL statement and does not affect mounted external data sources. Returns a structured result set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Executes a single read-only SQL statement and returns a structured result set. BeginTime and EndTime only constrain the internal EventHouse data referenced in the SQL statement and do not affect mounted external data sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventHouseWithTimeRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEventHouseWithTimeRangeResponse
        /// </returns>
        public async Task<QueryEventHouseWithTimeRangeResponse> QueryEventHouseWithTimeRangeAsync(QueryEventHouseWithTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventHouseWithTimeRangeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event traces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query event traces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventTracesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEventTracesResponse
        /// </returns>
        public QueryEventTracesResponse QueryEventTracesWithOptions(QueryEventTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventTraces",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventTracesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event traces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query event traces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventTracesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEventTracesResponse
        /// </returns>
        public async Task<QueryEventTracesResponse> QueryEventTracesWithOptionsAsync(QueryEventTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventTraces",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventTracesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event traces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query event traces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventTracesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEventTracesResponse
        /// </returns>
        public QueryEventTracesResponse QueryEventTraces(QueryEventTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventTracesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event traces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query event traces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryEventTracesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEventTracesResponse
        /// </returns>
        public async Task<QueryEventTracesResponse> QueryEventTracesAsync(QueryEventTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventTracesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL query directly on the EventHouse associated with a Luma Agent and returns structured results. Unlike AskLuma, this operation executes the SQL provided by the caller without natural language rewriting.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Executes an SQL query directly on the EventHouse associated with a Luma Agent and returns structured results. Unlike AskLuma, this operation executes the SQL provided by the caller without natural language rewriting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryLumaWithSQLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLumaWithSQLResponse
        /// </returns>
        public QueryLumaWithSQLResponse QueryLumaWithSQLWithOptions(QueryLumaWithSQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRows))
            {
                body["MaxRows"] = request.MaxRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLumaWithSQL",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLumaWithSQLResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL query directly on the EventHouse associated with a Luma Agent and returns structured results. Unlike AskLuma, this operation executes the SQL provided by the caller without natural language rewriting.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Executes an SQL query directly on the EventHouse associated with a Luma Agent and returns structured results. Unlike AskLuma, this operation executes the SQL provided by the caller without natural language rewriting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryLumaWithSQLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLumaWithSQLResponse
        /// </returns>
        public async Task<QueryLumaWithSQLResponse> QueryLumaWithSQLWithOptionsAsync(QueryLumaWithSQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRows))
            {
                body["MaxRows"] = request.MaxRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLumaWithSQL",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLumaWithSQLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL query directly on the EventHouse associated with a Luma Agent and returns structured results. Unlike AskLuma, this operation executes the SQL provided by the caller without natural language rewriting.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Executes an SQL query directly on the EventHouse associated with a Luma Agent and returns structured results. Unlike AskLuma, this operation executes the SQL provided by the caller without natural language rewriting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryLumaWithSQLRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLumaWithSQLResponse
        /// </returns>
        public QueryLumaWithSQLResponse QueryLumaWithSQL(QueryLumaWithSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLumaWithSQLWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL query directly on the EventHouse associated with a Luma Agent and returns structured results. Unlike AskLuma, this operation executes the SQL provided by the caller without natural language rewriting.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Executes an SQL query directly on the EventHouse associated with a Luma Agent and returns structured results. Unlike AskLuma, this operation executes the SQL provided by the caller without natural language rewriting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryLumaWithSQLRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLumaWithSQLResponse
        /// </returns>
        public async Task<QueryLumaWithSQLResponse> QueryLumaWithSQLAsync(QueryLumaWithSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLumaWithSQLWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event traces by event ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query event traces by event ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTracedEventByEventIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTracedEventByEventIdResponse
        /// </returns>
        public QueryTracedEventByEventIdResponse QueryTracedEventByEventIdWithOptions(QueryTracedEventByEventIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTracedEventByEventId",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTracedEventByEventIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event traces by event ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query event traces by event ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTracedEventByEventIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTracedEventByEventIdResponse
        /// </returns>
        public async Task<QueryTracedEventByEventIdResponse> QueryTracedEventByEventIdWithOptionsAsync(QueryTracedEventByEventIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTracedEventByEventId",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTracedEventByEventIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event traces by event ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query event traces by event ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTracedEventByEventIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTracedEventByEventIdResponse
        /// </returns>
        public QueryTracedEventByEventIdResponse QueryTracedEventByEventId(QueryTracedEventByEventIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTracedEventByEventIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event traces by event ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query event traces by event ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTracedEventByEventIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTracedEventByEventIdResponse
        /// </returns>
        public async Task<QueryTracedEventByEventIdResponse> QueryTracedEventByEventIdAsync(QueryTracedEventByEventIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTracedEventByEventIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries <c>event trace</c> data within a <c>time range</c>.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries for event traces within a specified time range.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTracedEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTracedEventsResponse
        /// </returns>
        public QueryTracedEventsResponse QueryTracedEventsWithOptions(QueryTracedEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchedRule))
            {
                query["MatchedRule"] = request.MatchedRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTracedEvents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTracedEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries <c>event trace</c> data within a <c>time range</c>.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries for event traces within a specified time range.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTracedEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTracedEventsResponse
        /// </returns>
        public async Task<QueryTracedEventsResponse> QueryTracedEventsWithOptionsAsync(QueryTracedEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchedRule))
            {
                query["MatchedRule"] = request.MatchedRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTracedEvents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTracedEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries <c>event trace</c> data within a <c>time range</c>.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries for event traces within a specified time range.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTracedEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTracedEventsResponse
        /// </returns>
        public QueryTracedEventsResponse QueryTracedEvents(QueryTracedEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTracedEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation queries <c>event trace</c> data within a <c>time range</c>.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries for event traces within a specified time range.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryTracedEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTracedEventsResponse
        /// </returns>
        public async Task<QueryTracedEventsResponse> QueryTracedEventsAsync(QueryTracedEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTracedEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a SQL statement to query event warehouse data. This operation is suitable for scenarios where the exact SQL is known, without natural language conversion or conversation context. Returns a structured result set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries event content.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryWithSQLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryWithSQLResponse
        /// </returns>
        public QueryWithSQLResponse QueryWithSQLWithOptions(QueryWithSQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWithSQL",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWithSQLResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a SQL statement to query event warehouse data. This operation is suitable for scenarios where the exact SQL is known, without natural language conversion or conversation context. Returns a structured result set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries event content.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryWithSQLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryWithSQLResponse
        /// </returns>
        public async Task<QueryWithSQLResponse> QueryWithSQLWithOptionsAsync(QueryWithSQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryWithSQL",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWithSQLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a SQL statement to query event warehouse data. This operation is suitable for scenarios where the exact SQL is known, without natural language conversion or conversation context. Returns a structured result set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries event content.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryWithSQLRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryWithSQLResponse
        /// </returns>
        public QueryWithSQLResponse QueryWithSQL(QueryWithSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWithSQLWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a SQL statement to query event warehouse data. This operation is suitable for scenarios where the exact SQL is known, without natural language conversion or conversation context. Returns a structured result set.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries event content.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryWithSQLRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryWithSQLResponse
        /// </returns>
        public async Task<QueryWithSQLResponse> QueryWithSQLAsync(QueryWithSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWithSQLWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves data semantics for an agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveAgentDataSemanticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAgentDataSemanticsResponse
        /// </returns>
        public SaveAgentDataSemanticsResponse SaveAgentDataSemanticsWithOptions(SaveAgentDataSemanticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveAgentDataSemanticsShrinkRequest request = new SaveAgentDataSemanticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Examples))
            {
                request.ExamplesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Examples, "Examples", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Joins))
            {
                request.JoinsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Joins, "Joins", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Metrics))
            {
                request.MetricsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Metrics, "Metrics", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Text))
            {
                request.TextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Text, "Text", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExamplesShrink))
            {
                body["Examples"] = request.ExamplesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinsShrink))
            {
                body["Joins"] = request.JoinsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricsShrink))
            {
                body["Metrics"] = request.MetricsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextShrink))
            {
                body["Text"] = request.TextShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAgentDataSemantics",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAgentDataSemanticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves data semantics for an agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveAgentDataSemanticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAgentDataSemanticsResponse
        /// </returns>
        public async Task<SaveAgentDataSemanticsResponse> SaveAgentDataSemanticsWithOptionsAsync(SaveAgentDataSemanticsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveAgentDataSemanticsShrinkRequest request = new SaveAgentDataSemanticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Examples))
            {
                request.ExamplesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Examples, "Examples", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Joins))
            {
                request.JoinsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Joins, "Joins", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Metrics))
            {
                request.MetricsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Metrics, "Metrics", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Text))
            {
                request.TextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Text, "Text", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExamplesShrink))
            {
                body["Examples"] = request.ExamplesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinsShrink))
            {
                body["Joins"] = request.JoinsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricsShrink))
            {
                body["Metrics"] = request.MetricsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextShrink))
            {
                body["Text"] = request.TextShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAgentDataSemantics",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAgentDataSemanticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves data semantics for an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAgentDataSemanticsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAgentDataSemanticsResponse
        /// </returns>
        public SaveAgentDataSemanticsResponse SaveAgentDataSemantics(SaveAgentDataSemanticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveAgentDataSemanticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves data semantics for an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAgentDataSemanticsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAgentDataSemanticsResponse
        /// </returns>
        public async Task<SaveAgentDataSemanticsResponse> SaveAgentDataSemanticsAsync(SaveAgentDataSemanticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveAgentDataSemanticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves knowledge base search results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchKnowledgeBaseResponse
        /// </returns>
        public SearchKnowledgeBaseResponse SearchKnowledgeBaseWithOptions(SearchKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataFilter))
            {
                query["MetadataFilter"] = request.MetadataFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankAlgorithm))
            {
                query["RankAlgorithm"] = request.RankAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rerank))
            {
                query["Rerank"] = request.Rerank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModel))
            {
                query["RerankModel"] = request.RerankModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RrfK))
            {
                query["RrfK"] = request.RrfK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                query["TopK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorWeight))
            {
                query["VectorWeight"] = request.VectorWeight;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves knowledge base search results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchKnowledgeBaseResponse
        /// </returns>
        public async Task<SearchKnowledgeBaseResponse> SearchKnowledgeBaseWithOptionsAsync(SearchKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataFilter))
            {
                query["MetadataFilter"] = request.MetadataFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankAlgorithm))
            {
                query["RankAlgorithm"] = request.RankAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rerank))
            {
                query["Rerank"] = request.Rerank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModel))
            {
                query["RerankModel"] = request.RerankModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RrfK))
            {
                query["RrfK"] = request.RrfK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                query["TopK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorWeight))
            {
                query["VectorWeight"] = request.VectorWeight;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves knowledge base search results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchKnowledgeBaseResponse
        /// </returns>
        public SearchKnowledgeBaseResponse SearchKnowledgeBase(SearchKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves knowledge base search results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchKnowledgeBaseResponse
        /// </returns>
        public async Task<SearchKnowledgeBaseResponse> SearchKnowledgeBaseAsync(SearchKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves content from a knowledge base bound to a Luma Agent and returns relevant text chunks along with their relevance scores.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves content from a knowledge base bound to a Luma Agent and returns relevant text chunks along with their relevance scores.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchLumaKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchLumaKnowledgeBaseResponse
        /// </returns>
        public SearchLumaKnowledgeBaseResponse SearchLumaKnowledgeBaseWithOptions(SearchLumaKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataFilter))
            {
                body["MetadataFilter"] = request.MetadataFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rerank))
            {
                body["Rerank"] = request.Rerank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["TopK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchLumaKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchLumaKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves content from a knowledge base bound to a Luma Agent and returns relevant text chunks along with their relevance scores.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves content from a knowledge base bound to a Luma Agent and returns relevant text chunks along with their relevance scores.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchLumaKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchLumaKnowledgeBaseResponse
        /// </returns>
        public async Task<SearchLumaKnowledgeBaseResponse> SearchLumaKnowledgeBaseWithOptionsAsync(SearchLumaKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                body["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                body["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                body["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataFilter))
            {
                body["MetadataFilter"] = request.MetadataFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rerank))
            {
                body["Rerank"] = request.Rerank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["TopK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchLumaKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchLumaKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves content from a knowledge base bound to a Luma Agent and returns relevant text chunks along with their relevance scores.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves content from a knowledge base bound to a Luma Agent and returns relevant text chunks along with their relevance scores.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchLumaKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchLumaKnowledgeBaseResponse
        /// </returns>
        public SearchLumaKnowledgeBaseResponse SearchLumaKnowledgeBase(SearchLumaKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchLumaKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves content from a knowledge base bound to a Luma Agent and returns relevant text chunks along with their relevance scores.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves content from a knowledge base bound to a Luma Agent and returns relevant text chunks along with their relevance scores.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchLumaKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchLumaKnowledgeBaseResponse
        /// </returns>
        public async Task<SearchLumaKnowledgeBaseResponse> SearchLumaKnowledgeBaseAsync(SearchLumaKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchLumaKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a created or disabled event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Enables a created or disabled event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartEventStreamingResponse
        /// </returns>
        public StartEventStreamingResponse StartEventStreamingWithOptions(StartEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a created or disabled event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Enables a created or disabled event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartEventStreamingResponse
        /// </returns>
        public async Task<StartEventStreamingResponse> StartEventStreamingWithOptionsAsync(StartEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a created or disabled event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Enables a created or disabled event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// StartEventStreamingResponse
        /// </returns>
        public StartEventStreamingResponse StartEventStreaming(StartEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartEventStreamingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a created or disabled event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Enables a created or disabled event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// StartEventStreamingResponse
        /// </returns>
        public async Task<StartEventStreamingResponse> StartEventStreamingAsync(StartEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartEventStreamingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests if an event pattern matches a given event.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this action to test an event pattern before you apply it to a rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TestEventPatternRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestEventPatternResponse
        /// </returns>
        public TestEventPatternResponse TestEventPatternWithOptions(TestEventPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventPattern))
            {
                body["EventPattern"] = request.EventPattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestEventPattern",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestEventPatternResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests if an event pattern matches a given event.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this action to test an event pattern before you apply it to a rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TestEventPatternRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestEventPatternResponse
        /// </returns>
        public async Task<TestEventPatternResponse> TestEventPatternWithOptionsAsync(TestEventPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventPattern))
            {
                body["EventPattern"] = request.EventPattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestEventPattern",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestEventPatternResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests if an event pattern matches a given event.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this action to test an event pattern before you apply it to a rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TestEventPatternRequest
        /// </param>
        /// 
        /// <returns>
        /// TestEventPatternResponse
        /// </returns>
        public TestEventPatternResponse TestEventPattern(TestEventPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestEventPatternWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests if an event pattern matches a given event.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Use this action to test an event pattern before you apply it to a rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TestEventPatternRequest
        /// </param>
        /// 
        /// <returns>
        /// TestEventPatternResponse
        /// </returns>
        public async Task<TestEventPatternResponse> TestEventPatternAsync(TestEventPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestEventPatternWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the event source configuration is active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns a list of all external event sources.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// TestEventSourceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestEventSourceConfigResponse
        /// </returns>
        public TestEventSourceConfigResponse TestEventSourceConfigWithOptions(TestEventSourceConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TestEventSourceConfigShrinkRequest request = new TestEventSourceConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMySQLParameters))
            {
                request.SourceMySQLParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMySQLParameters, "SourceMySQLParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMySQLParametersShrink))
            {
                body["SourceMySQLParameters"] = request.SourceMySQLParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestEventSourceConfig",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestEventSourceConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the event source configuration is active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns a list of all external event sources.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// TestEventSourceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestEventSourceConfigResponse
        /// </returns>
        public async Task<TestEventSourceConfigResponse> TestEventSourceConfigWithOptionsAsync(TestEventSourceConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TestEventSourceConfigShrinkRequest request = new TestEventSourceConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMySQLParameters))
            {
                request.SourceMySQLParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMySQLParameters, "SourceMySQLParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMySQLParametersShrink))
            {
                body["SourceMySQLParameters"] = request.SourceMySQLParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestEventSourceConfig",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestEventSourceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the event source configuration is active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns a list of all external event sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TestEventSourceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// TestEventSourceConfigResponse
        /// </returns>
        public TestEventSourceConfigResponse TestEventSourceConfig(TestEventSourceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestEventSourceConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the event source configuration is active.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Returns a list of all external event sources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TestEventSourceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// TestEventSourceConfigResponse
        /// </returns>
        public async Task<TestEventSourceConfigResponse> TestEventSourceConfigAsync(TestEventSourceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestEventSourceConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgentWithOptions(UpdateAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAgentShrinkRequest request = new UpdateAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Metadata))
            {
                request.MetadataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Metadata, "Metadata", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServerId))
            {
                body["McpServerId"] = request.McpServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServerName))
            {
                body["McpServerName"] = request.McpServerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataShrink))
            {
                body["Metadata"] = request.MetadataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentWithOptionsAsync(UpdateAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAgentShrinkRequest request = new UpdateAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Metadata))
            {
                request.MetadataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Metadata, "Metadata", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServerId))
            {
                body["McpServerId"] = request.McpServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.McpServerName))
            {
                body["McpServerName"] = request.McpServerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataShrink))
            {
                body["Metadata"] = request.MetadataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update an API destination.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateApiDestinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiDestinationResponse
        /// </returns>
        public UpdateApiDestinationResponse UpdateApiDestinationWithOptions(UpdateApiDestinationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApiDestinationShrinkRequest request = new UpdateApiDestinationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpApiParameters))
            {
                request.HttpApiParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpApiParameters, "HttpApiParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiParametersShrink))
            {
                query["HttpApiParameters"] = request.HttpApiParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiDestinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update an API destination.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateApiDestinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiDestinationResponse
        /// </returns>
        public async Task<UpdateApiDestinationResponse> UpdateApiDestinationWithOptionsAsync(UpdateApiDestinationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApiDestinationShrinkRequest request = new UpdateApiDestinationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpApiParameters))
            {
                request.HttpApiParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpApiParameters, "HttpApiParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiParametersShrink))
            {
                query["HttpApiParameters"] = request.HttpApiParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApiDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiDestinationResponse
        /// </returns>
        public UpdateApiDestinationResponse UpdateApiDestination(UpdateApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApiDestinationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an API destination.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update an API destination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApiDestinationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiDestinationResponse
        /// </returns>
        public async Task<UpdateApiDestinationResponse> UpdateApiDestinationAsync(UpdateApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApiDestinationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates connection configuration information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates connection configurations.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectionResponse
        /// </returns>
        public UpdateConnectionResponse UpdateConnectionWithOptions(UpdateConnectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConnectionShrinkRequest request = new UpdateConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthParameters))
            {
                request.AuthParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthParameters, "AuthParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkParameters))
            {
                request.NetworkParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkParameters, "NetworkParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthParametersShrink))
            {
                query["AuthParameters"] = request.AuthParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkParametersShrink))
            {
                query["NetworkParameters"] = request.NetworkParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates connection configuration information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates connection configurations.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectionResponse
        /// </returns>
        public async Task<UpdateConnectionResponse> UpdateConnectionWithOptionsAsync(UpdateConnectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConnectionShrinkRequest request = new UpdateConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthParameters))
            {
                request.AuthParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthParameters, "AuthParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkParameters))
            {
                request.NetworkParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkParameters, "NetworkParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthParametersShrink))
            {
                query["AuthParameters"] = request.AuthParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkParametersShrink))
            {
                query["NetworkParameters"] = request.NetworkParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates connection configuration information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates connection configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectionResponse
        /// </returns>
        public UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates connection configuration information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates connection configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectionResponse
        /// </returns>
        public async Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to update an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventBusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventBusResponse
        /// </returns>
        public UpdateEventBusResponse UpdateEventBusWithOptions(UpdateEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventBusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to update an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventBusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventBusResponse
        /// </returns>
        public async Task<UpdateEventBusResponse> UpdateEventBusWithOptionsAsync(UpdateEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventBusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to update an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventBusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventBusResponse
        /// </returns>
        public UpdateEventBusResponse UpdateEventBus(UpdateEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventBusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event bus.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to update an event bus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventBusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventBusResponse
        /// </returns>
        public async Task<UpdateEventBusResponse> UpdateEventBusAsync(UpdateEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventBusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventHouseRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventHouseRuntimeResponse
        /// </returns>
        public UpdateEventHouseRuntimeResponse UpdateEventHouseRuntimeWithOptions(UpdateEventHouseRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cu))
            {
                query["Cu"] = request.Cu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventHouseRuntime",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventHouseRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventHouseRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventHouseRuntimeResponse
        /// </returns>
        public async Task<UpdateEventHouseRuntimeResponse> UpdateEventHouseRuntimeWithOptionsAsync(UpdateEventHouseRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cu))
            {
                query["Cu"] = request.Cu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventHouseRuntime",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventHouseRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventHouseRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventHouseRuntimeResponse
        /// </returns>
        public UpdateEventHouseRuntimeResponse UpdateEventHouseRuntime(UpdateEventHouseRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventHouseRuntimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an EventHouse Runtime.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventHouseRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventHouseRuntimeResponse
        /// </returns>
        public async Task<UpdateEventHouseRuntimeResponse> UpdateEventHouseRuntimeAsync(UpdateEventHouseRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventHouseRuntimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update an event source.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateEventSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventSourceResponse
        /// </returns>
        public UpdateEventSourceResponse UpdateEventSourceWithOptions(UpdateEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventSourceShrinkRequest request = new UpdateEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalSourceConfig))
            {
                request.ExternalSourceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalSourceConfig, "ExternalSourceConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceHttpEventParameters))
            {
                request.SourceHttpEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceHttpEventParameters, "SourceHttpEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceKafkaParameters))
            {
                request.SourceKafkaParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceKafkaParameters, "SourceKafkaParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMNSParameters))
            {
                request.SourceMNSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMNSParameters, "SourceMNSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceOSSEventParameters))
            {
                request.SourceOSSEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceOSSEventParameters, "SourceOSSEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRabbitMQParameters))
            {
                request.SourceRabbitMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRabbitMQParameters, "SourceRabbitMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRocketMQParameters))
            {
                request.SourceRocketMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRocketMQParameters, "SourceRocketMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSLSParameters))
            {
                request.SourceSLSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSLSParameters, "SourceSLSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceScheduledEventParameters))
            {
                request.SourceScheduledEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceScheduledEventParameters, "SourceScheduledEventParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalSourceConfigShrink))
            {
                body["ExternalSourceConfig"] = request.ExternalSourceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalSourceType))
            {
                body["ExternalSourceType"] = request.ExternalSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkedExternalSource))
            {
                body["LinkedExternalSource"] = request.LinkedExternalSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHttpEventParametersShrink))
            {
                body["SourceHttpEventParameters"] = request.SourceHttpEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKafkaParametersShrink))
            {
                body["SourceKafkaParameters"] = request.SourceKafkaParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMNSParametersShrink))
            {
                body["SourceMNSParameters"] = request.SourceMNSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOSSEventParametersShrink))
            {
                body["SourceOSSEventParameters"] = request.SourceOSSEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRabbitMQParametersShrink))
            {
                body["SourceRabbitMQParameters"] = request.SourceRabbitMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRocketMQParametersShrink))
            {
                body["SourceRocketMQParameters"] = request.SourceRocketMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSLSParametersShrink))
            {
                body["SourceSLSParameters"] = request.SourceSLSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScheduledEventParametersShrink))
            {
                body["SourceScheduledEventParameters"] = request.SourceScheduledEventParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update an event source.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateEventSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventSourceResponse
        /// </returns>
        public async Task<UpdateEventSourceResponse> UpdateEventSourceWithOptionsAsync(UpdateEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventSourceShrinkRequest request = new UpdateEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExternalSourceConfig))
            {
                request.ExternalSourceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExternalSourceConfig, "ExternalSourceConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceHttpEventParameters))
            {
                request.SourceHttpEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceHttpEventParameters, "SourceHttpEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceKafkaParameters))
            {
                request.SourceKafkaParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceKafkaParameters, "SourceKafkaParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMNSParameters))
            {
                request.SourceMNSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMNSParameters, "SourceMNSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceOSSEventParameters))
            {
                request.SourceOSSEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceOSSEventParameters, "SourceOSSEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRabbitMQParameters))
            {
                request.SourceRabbitMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRabbitMQParameters, "SourceRabbitMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRocketMQParameters))
            {
                request.SourceRocketMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRocketMQParameters, "SourceRocketMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSLSParameters))
            {
                request.SourceSLSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSLSParameters, "SourceSLSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceScheduledEventParameters))
            {
                request.SourceScheduledEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceScheduledEventParameters, "SourceScheduledEventParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalSourceConfigShrink))
            {
                body["ExternalSourceConfig"] = request.ExternalSourceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalSourceType))
            {
                body["ExternalSourceType"] = request.ExternalSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkedExternalSource))
            {
                body["LinkedExternalSource"] = request.LinkedExternalSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHttpEventParametersShrink))
            {
                body["SourceHttpEventParameters"] = request.SourceHttpEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKafkaParametersShrink))
            {
                body["SourceKafkaParameters"] = request.SourceKafkaParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMNSParametersShrink))
            {
                body["SourceMNSParameters"] = request.SourceMNSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOSSEventParametersShrink))
            {
                body["SourceOSSEventParameters"] = request.SourceOSSEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRabbitMQParametersShrink))
            {
                body["SourceRabbitMQParameters"] = request.SourceRabbitMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRocketMQParametersShrink))
            {
                body["SourceRocketMQParameters"] = request.SourceRocketMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSLSParametersShrink))
            {
                body["SourceSLSParameters"] = request.SourceSLSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScheduledEventParametersShrink))
            {
                body["SourceScheduledEventParameters"] = request.SourceScheduledEventParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update an event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventSourceResponse
        /// </returns>
        public UpdateEventSourceResponse UpdateEventSource(UpdateEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update an event source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventSourceResponse
        /// </returns>
        public async Task<UpdateEventSourceResponse> UpdateEventSourceAsync(UpdateEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information, event source information, event filtering pattern, or event target information of an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the basic information, event source information, event filtering pattern, or event target information of an event stream.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventStreamingResponse
        /// </returns>
        public UpdateEventStreamingResponse UpdateEventStreamingWithOptions(UpdateEventStreamingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventStreamingShrinkRequest request = new UpdateEventStreamingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RunOptions))
            {
                request.RunOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RunOptions, "RunOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sink))
            {
                request.SinkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sink, "Sink", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transforms))
            {
                request.TransformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transforms, "Transforms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                body["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunOptionsShrink))
            {
                body["RunOptions"] = request.RunOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkShrink))
            {
                body["Sink"] = request.SinkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                body["Source"] = request.SourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformsShrink))
            {
                body["Transforms"] = request.TransformsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information, event source information, event filtering pattern, or event target information of an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the basic information, event source information, event filtering pattern, or event target information of an event stream.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateEventStreamingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventStreamingResponse
        /// </returns>
        public async Task<UpdateEventStreamingResponse> UpdateEventStreamingWithOptionsAsync(UpdateEventStreamingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventStreamingShrinkRequest request = new UpdateEventStreamingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RunOptions))
            {
                request.RunOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RunOptions, "RunOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sink))
            {
                request.SinkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sink, "Sink", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transforms))
            {
                request.TransformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transforms, "Transforms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                body["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunOptionsShrink))
            {
                body["RunOptions"] = request.RunOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkShrink))
            {
                body["Sink"] = request.SinkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                body["Source"] = request.SourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformsShrink))
            {
                body["Transforms"] = request.TransformsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information, event source information, event filtering pattern, or event target information of an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the basic information, event source information, event filtering pattern, or event target information of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventStreamingResponse
        /// </returns>
        public UpdateEventStreamingResponse UpdateEventStreaming(UpdateEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventStreamingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the basic information, event source information, event filtering pattern, or event target information of an event stream.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the basic information, event source information, event filtering pattern, or event target information of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventStreamingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventStreamingResponse
        /// </returns>
        public async Task<UpdateEventStreamingResponse> UpdateEventStreamingAsync(UpdateEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventStreamingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Querying an event stream</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the billing method, compute unit (CU) resources, and other configurations of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventStreamingBusinessOptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventStreamingBusinessOptionResponse
        /// </returns>
        public UpdateEventStreamingBusinessOptionResponse UpdateEventStreamingBusinessOptionWithOptions(UpdateEventStreamingBusinessOptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessMode))
            {
                body["BusinessMode"] = request.BusinessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCapacityUnitCount))
            {
                body["MaxCapacityUnitCount"] = request.MaxCapacityUnitCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinCapacityUnitCount))
            {
                body["MinCapacityUnitCount"] = request.MinCapacityUnitCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventStreamingBusinessOption",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventStreamingBusinessOptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Querying an event stream</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the billing method, compute unit (CU) resources, and other configurations of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventStreamingBusinessOptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventStreamingBusinessOptionResponse
        /// </returns>
        public async Task<UpdateEventStreamingBusinessOptionResponse> UpdateEventStreamingBusinessOptionWithOptionsAsync(UpdateEventStreamingBusinessOptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessMode))
            {
                body["BusinessMode"] = request.BusinessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCapacityUnitCount))
            {
                body["MaxCapacityUnitCount"] = request.MaxCapacityUnitCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinCapacityUnitCount))
            {
                body["MinCapacityUnitCount"] = request.MinCapacityUnitCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventStreamingBusinessOption",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventStreamingBusinessOptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Querying an event stream</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the billing method, compute unit (CU) resources, and other configurations of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventStreamingBusinessOptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventStreamingBusinessOptionResponse
        /// </returns>
        public UpdateEventStreamingBusinessOptionResponse UpdateEventStreamingBusinessOption(UpdateEventStreamingBusinessOptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventStreamingBusinessOptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Querying an event stream</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the billing method, compute unit (CU) resources, and other configurations of an event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateEventStreamingBusinessOptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventStreamingBusinessOptionResponse
        /// </returns>
        public async Task<UpdateEventStreamingBusinessOptionResponse> UpdateEventStreamingBusinessOptionAsync(UpdateEventStreamingBusinessOptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventStreamingBusinessOptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public UpdateKnowledgeBaseResponse UpdateKnowledgeBaseWithOptions(UpdateKnowledgeBaseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateKnowledgeBaseShrinkRequest request = new UpdateKnowledgeBaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChunkConfiguration))
            {
                request.ChunkConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChunkConfiguration, "ChunkConfiguration", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchConfiguration))
            {
                request.SearchConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchConfiguration, "SearchConfiguration", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkConfigurationShrink))
            {
                query["ChunkConfiguration"] = request.ChunkConfigurationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchConfigurationShrink))
            {
                query["SearchConfiguration"] = request.SearchConfigurationShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseWithOptionsAsync(UpdateKnowledgeBaseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateKnowledgeBaseShrinkRequest request = new UpdateKnowledgeBaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChunkConfiguration))
            {
                request.ChunkConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChunkConfiguration, "ChunkConfiguration", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchConfiguration))
            {
                request.SearchConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchConfiguration, "SearchConfiguration", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkConfigurationShrink))
            {
                query["ChunkConfiguration"] = request.ChunkConfigurationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseName))
            {
                query["KnowledgeBaseName"] = request.KnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchConfigurationShrink))
            {
                query["SearchConfiguration"] = request.SearchConfigurationShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBase",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public UpdateKnowledgeBaseResponse UpdateKnowledgeBase(UpdateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public UpdateNamespaceResponse UpdateNamespaceWithOptions(UpdateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespaceWithOptionsAsync(UpdateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify namespace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update the configurations of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleResponse
        /// </returns>
        public UpdateRuleResponse UpdateRuleWithOptions(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                query["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update the configurations of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleResponse
        /// </returns>
        public async Task<UpdateRuleResponse> UpdateRuleWithOptionsAsync(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                query["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update the configurations of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleResponse
        /// </returns>
        public UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of an event rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to update the configurations of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleResponse
        /// </returns>
        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update table</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of an event rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableResponse
        /// </returns>
        public UpdateTableResponse UpdateTableWithOptions(UpdateTableRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTableShrinkRequest request = new UpdateTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddColumn))
            {
                request.AddColumnShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddColumn, "AddColumn", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeleteColumn))
            {
                request.DeleteColumnShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeleteColumn, "DeleteColumn", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RenameColumn))
            {
                request.RenameColumnShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RenameColumn, "RenameColumn", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateColumnComment))
            {
                request.UpdateColumnCommentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateColumnComment, "UpdateColumnComment", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateColumnType))
            {
                request.UpdateColumnTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateColumnType, "UpdateColumnType", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateRetentionPolicy))
            {
                request.UpdateRetentionPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateRetentionPolicy, "UpdateRetentionPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddColumnShrink))
            {
                query["AddColumn"] = request.AddColumnShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteColumnShrink))
            {
                query["DeleteColumn"] = request.DeleteColumnShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenameColumnShrink))
            {
                query["RenameColumn"] = request.RenameColumnShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateColumnCommentShrink))
            {
                query["UpdateColumnComment"] = request.UpdateColumnCommentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateColumnTypeShrink))
            {
                query["UpdateColumnType"] = request.UpdateColumnTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateComment))
            {
                query["UpdateComment"] = request.UpdateComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateRetentionPolicyShrink))
            {
                query["UpdateRetentionPolicy"] = request.UpdateRetentionPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update table</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of an event rule.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableResponse
        /// </returns>
        public async Task<UpdateTableResponse> UpdateTableWithOptionsAsync(UpdateTableRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTableShrinkRequest request = new UpdateTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddColumn))
            {
                request.AddColumnShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddColumn, "AddColumn", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeleteColumn))
            {
                request.DeleteColumnShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeleteColumn, "DeleteColumn", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RenameColumn))
            {
                request.RenameColumnShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RenameColumn, "RenameColumn", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateColumnComment))
            {
                request.UpdateColumnCommentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateColumnComment, "UpdateColumnComment", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateColumnType))
            {
                request.UpdateColumnTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateColumnType, "UpdateColumnType", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateRetentionPolicy))
            {
                request.UpdateRetentionPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateRetentionPolicy, "UpdateRetentionPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddColumnShrink))
            {
                query["AddColumn"] = request.AddColumnShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["Catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteColumnShrink))
            {
                query["DeleteColumn"] = request.DeleteColumnShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenameColumnShrink))
            {
                query["RenameColumn"] = request.RenameColumnShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateColumnCommentShrink))
            {
                query["UpdateColumnComment"] = request.UpdateColumnCommentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateColumnTypeShrink))
            {
                query["UpdateColumnType"] = request.UpdateColumnTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateComment))
            {
                query["UpdateComment"] = request.UpdateComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateRetentionPolicyShrink))
            {
                query["UpdateRetentionPolicy"] = request.UpdateRetentionPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTable",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update table</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTableRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableResponse
        /// </returns>
        public UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update table</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of an event rule.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTableRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableResponse
        /// </returns>
        public async Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableWithOptionsAsync(request, runtime);
        }

    }
}
