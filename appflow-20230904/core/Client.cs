// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Appflow20230904.Models;

namespace AlibabaCloud.SDK.Appflow20230904
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("appflow", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowDesc))
            {
                query["FlowDesc"] = request.FlowDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTemplate))
            {
                query["FlowTemplate"] = request.FlowTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchStatus))
            {
                query["LaunchStatus"] = request.LaunchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowResponse
        /// </returns>
        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowDesc))
            {
                query["FlowDesc"] = request.FlowDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTemplate))
            {
                query["FlowTemplate"] = request.FlowTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaunchStatus))
            {
                query["LaunchStatus"] = request.LaunchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建连接流</para>
        /// </summary>
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
            return CreateFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建连接流</para>
        /// </summary>
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
            return await CreateFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserAuthConfigResponse
        /// </returns>
        public CreateUserAuthConfigResponse CreateUserAuthConfigWithOptions(CreateUserAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                query["AuthConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigName))
            {
                query["AuthConfigName"] = request.AuthConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserAuthConfig",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserAuthConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserAuthConfigResponse
        /// </returns>
        public async Task<CreateUserAuthConfigResponse> CreateUserAuthConfigWithOptionsAsync(CreateUserAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                query["AuthConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigName))
            {
                query["AuthConfigName"] = request.AuthConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserAuthConfig",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserAuthConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserAuthConfigResponse
        /// </returns>
        public CreateUserAuthConfigResponse CreateUserAuthConfig(CreateUserAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserAuthConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserAuthConfigResponse
        /// </returns>
        public async Task<CreateUserAuthConfigResponse> CreateUserAuthConfigAsync(CreateUserAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserAuthConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public DeleteFlowResponse DeleteFlowWithOptions(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowResponse
        /// </returns>
        public async Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserAuthConfigResponse
        /// </returns>
        public DeleteUserAuthConfigResponse DeleteUserAuthConfigWithOptions(DeleteUserAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigId))
            {
                query["AuthConfigId"] = request.AuthConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserAuthConfig",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserAuthConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserAuthConfigResponse
        /// </returns>
        public async Task<DeleteUserAuthConfigResponse> DeleteUserAuthConfigWithOptionsAsync(DeleteUserAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigId))
            {
                query["AuthConfigId"] = request.AuthConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserAuthConfig",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserAuthConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserAuthConfigResponse
        /// </returns>
        public DeleteUserAuthConfigResponse DeleteUserAuthConfig(DeleteUserAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserAuthConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserAuthConfigResponse
        /// </returns>
        public async Task<DeleteUserAuthConfigResponse> DeleteUserAuthConfigAsync(DeleteUserAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserAuthConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableFlowResponse
        /// </returns>
        public DisableFlowResponse DisableFlowWithOptions(DisableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableFlowResponse
        /// </returns>
        public async Task<DisableFlowResponse> DisableFlowWithOptionsAsync(DisableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableFlowResponse
        /// </returns>
        public DisableFlowResponse DisableFlow(DisableFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>禁用连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableFlowResponse
        /// </returns>
        public async Task<DisableFlowResponse> DisableFlowAsync(DisableFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableFlowResponse
        /// </returns>
        public EnableFlowResponse EnableFlowWithOptions(EnableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableFlowResponse
        /// </returns>
        public async Task<EnableFlowResponse> EnableFlowWithOptionsAsync(EnableFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableFlowResponse
        /// </returns>
        public EnableFlowResponse EnableFlow(EnableFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableFlowResponse
        /// </returns>
        public async Task<EnableFlowResponse> EnableFlowAsync(EnableFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generate Login Session Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUserSessionTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUserSessionTokenResponse
        /// </returns>
        public GenerateUserSessionTokenResponse GenerateUserSessionTokenWithOptions(GenerateUserSessionTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                query["ChatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSecond))
            {
                query["ExpireSecond"] = request.ExpireSecond;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                query["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrateId))
            {
                query["IntegrateId"] = request.IntegrateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAvatar))
            {
                query["UserAvatar"] = request.UserAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUserSessionToken",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUserSessionTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generate Login Session Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUserSessionTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUserSessionTokenResponse
        /// </returns>
        public async Task<GenerateUserSessionTokenResponse> GenerateUserSessionTokenWithOptionsAsync(GenerateUserSessionTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                query["ChatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireSecond))
            {
                query["ExpireSecond"] = request.ExpireSecond;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                query["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntegrateId))
            {
                query["IntegrateId"] = request.IntegrateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAvatar))
            {
                query["UserAvatar"] = request.UserAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUserSessionToken",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUserSessionTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generate Login Session Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUserSessionTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUserSessionTokenResponse
        /// </returns>
        public GenerateUserSessionTokenResponse GenerateUserSessionToken(GenerateUserSessionTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUserSessionTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generate Login Session Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUserSessionTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUserSessionTokenResponse
        /// </returns>
        public async Task<GenerateUserSessionTokenResponse> GenerateUserSessionTokenAsync(GenerateUserSessionTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUserSessionTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取连接流详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowResponse
        /// </returns>
        public GetFlowResponse GetFlowWithOptions(GetFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取连接流详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowResponse
        /// </returns>
        public async Task<GetFlowResponse> GetFlowWithOptionsAsync(GetFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取连接流详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowResponse
        /// </returns>
        public GetFlowResponse GetFlow(GetFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取连接流详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFlowResponse
        /// </returns>
        public async Task<GetFlowResponse> GetFlowAsync(GetFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户鉴权凭证详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAuthConfigResponse
        /// </returns>
        public GetUserAuthConfigResponse GetUserAuthConfigWithOptions(GetUserAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigId))
            {
                query["AuthConfigId"] = request.AuthConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAuthConfig",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAuthConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户鉴权凭证详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserAuthConfigResponse
        /// </returns>
        public async Task<GetUserAuthConfigResponse> GetUserAuthConfigWithOptionsAsync(GetUserAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigId))
            {
                query["AuthConfigId"] = request.AuthConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserAuthConfig",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserAuthConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户鉴权凭证详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAuthConfigResponse
        /// </returns>
        public GetUserAuthConfigResponse GetUserAuthConfig(GetUserAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserAuthConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户鉴权凭证详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserAuthConfigResponse
        /// </returns>
        public async Task<GetUserAuthConfigResponse> GetUserAuthConfigAsync(GetUserAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserAuthConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行连接器的执行动作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InvokeActionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeActionResponse
        /// </returns>
        public InvokeActionResponse InvokeActionWithOptions(InvokeActionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvokeActionShrinkRequest request = new InvokeActionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthConfig))
            {
                request.AuthConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthConfig, "AuthConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "Body", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Headers))
            {
                request.HeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Headers, "Headers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Path))
            {
                request.PathShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Path, "Path", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionId))
            {
                query["ActionId"] = request.ActionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionVersion))
            {
                query["ActionVersion"] = request.ActionVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigShrink))
            {
                query["AuthConfig"] = request.AuthConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["Body"] = request.BodyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeadersShrink))
            {
                query["Headers"] = request.HeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathShrink))
            {
                query["Path"] = request.PathShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                query["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                query["Stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeAction",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeActionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行连接器的执行动作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InvokeActionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeActionResponse
        /// </returns>
        public async Task<InvokeActionResponse> InvokeActionWithOptionsAsync(InvokeActionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvokeActionShrinkRequest request = new InvokeActionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthConfig))
            {
                request.AuthConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthConfig, "AuthConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "Body", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Headers))
            {
                request.HeadersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Headers, "Headers", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Path))
            {
                request.PathShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Path, "Path", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionId))
            {
                query["ActionId"] = request.ActionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionVersion))
            {
                query["ActionVersion"] = request.ActionVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigShrink))
            {
                query["AuthConfig"] = request.AuthConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["Body"] = request.BodyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeadersShrink))
            {
                query["Headers"] = request.HeadersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathShrink))
            {
                query["Path"] = request.PathShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                query["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                query["Stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeAction",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokeActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行连接器的执行动作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeActionRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeActionResponse
        /// </returns>
        public InvokeActionResponse InvokeAction(InvokeActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeActionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行连接器的执行动作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokeActionRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeActionResponse
        /// </returns>
        public async Task<InvokeActionResponse> InvokeActionAsync(InvokeActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeActionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LaunchFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LaunchFlowResponse
        /// </returns>
        public LaunchFlowResponse LaunchFlowWithOptions(LaunchFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowDesc))
            {
                query["FlowDesc"] = request.FlowDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTemplate))
            {
                query["FlowTemplate"] = request.FlowTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LaunchFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LaunchFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LaunchFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LaunchFlowResponse
        /// </returns>
        public async Task<LaunchFlowResponse> LaunchFlowWithOptionsAsync(LaunchFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowDesc))
            {
                query["FlowDesc"] = request.FlowDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTemplate))
            {
                query["FlowTemplate"] = request.FlowTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LaunchFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LaunchFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LaunchFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// LaunchFlowResponse
        /// </returns>
        public LaunchFlowResponse LaunchFlow(LaunchFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LaunchFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LaunchFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// LaunchFlowResponse
        /// </returns>
        public async Task<LaunchFlowResponse> LaunchFlowAsync(LaunchFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LaunchFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户鉴权凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserAuthConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserAuthConfigsResponse
        /// </returns>
        public ListUserAuthConfigsResponse ListUserAuthConfigsWithOptions(ListUserAuthConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
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
                Action = "ListUserAuthConfigs",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserAuthConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户鉴权凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserAuthConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserAuthConfigsResponse
        /// </returns>
        public async Task<ListUserAuthConfigsResponse> ListUserAuthConfigsWithOptionsAsync(ListUserAuthConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
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
                Action = "ListUserAuthConfigs",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserAuthConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户鉴权凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserAuthConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserAuthConfigsResponse
        /// </returns>
        public ListUserAuthConfigsResponse ListUserAuthConfigs(ListUserAuthConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserAuthConfigsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户鉴权凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserAuthConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserAuthConfigsResponse
        /// </returns>
        public async Task<ListUserAuthConfigsResponse> ListUserAuthConfigsAsync(ListUserAuthConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserAuthConfigsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public UpdateFlowResponse UpdateFlowWithOptions(UpdateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowDesc))
            {
                query["FlowDesc"] = request.FlowDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTemplate))
            {
                query["FlowTemplate"] = request.FlowTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public async Task<UpdateFlowResponse> UpdateFlowWithOptionsAsync(UpdateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowDesc))
            {
                query["FlowDesc"] = request.FlowDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTemplate))
            {
                query["FlowTemplate"] = request.FlowTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public UpdateFlowResponse UpdateFlow(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFlowResponse
        /// </returns>
        public async Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserAuthConfigResponse
        /// </returns>
        public UpdateUserAuthConfigResponse UpdateUserAuthConfigWithOptions(UpdateUserAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                query["AuthConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigId))
            {
                query["AuthConfigId"] = request.AuthConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigName))
            {
                query["AuthConfigName"] = request.AuthConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserAuthConfig",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserAuthConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserAuthConfigResponse
        /// </returns>
        public async Task<UpdateUserAuthConfigResponse> UpdateUserAuthConfigWithOptionsAsync(UpdateUserAuthConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                query["AuthConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigId))
            {
                query["AuthConfigId"] = request.AuthConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfigName))
            {
                query["AuthConfigName"] = request.AuthConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                query["ConnectorId"] = request.ConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorVersion))
            {
                query["ConnectorVersion"] = request.ConnectorVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserAuthConfig",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserAuthConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserAuthConfigResponse
        /// </returns>
        public UpdateUserAuthConfigResponse UpdateUserAuthConfig(UpdateUserAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserAuthConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑用户鉴权凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserAuthConfigResponse
        /// </returns>
        public async Task<UpdateUserAuthConfigResponse> UpdateUserAuthConfigAsync(UpdateUserAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserAuthConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WithdrawFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WithdrawFlowResponse
        /// </returns>
        public WithdrawFlowResponse WithdrawFlowWithOptions(WithdrawFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WithdrawFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WithdrawFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WithdrawFlowResponse
        /// </returns>
        public async Task<WithdrawFlowResponse> WithdrawFlowWithOptionsAsync(WithdrawFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowVersion))
            {
                query["FlowVersion"] = request.FlowVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WithdrawFlow",
                Version = "2023-09-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WithdrawFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// WithdrawFlowResponse
        /// </returns>
        public WithdrawFlowResponse WithdrawFlow(WithdrawFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WithdrawFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线连接流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WithdrawFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// WithdrawFlowResponse
        /// </returns>
        public async Task<WithdrawFlowResponse> WithdrawFlowAsync(WithdrawFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WithdrawFlowWithOptionsAsync(request, runtime);
        }

    }
}
