// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OpenAPIExplorer20241130.Models;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "openapi-mcp.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou", "openapi-mcp.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("openapiexplorer", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>验证 Terraform HCL 语法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApiMcpServerValidateHclRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApiMcpServerValidateHclResponse
        /// </returns>
        public ApiMcpServerValidateHclResponse ApiMcpServerValidateHclWithOptions(ApiMcpServerValidateHclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApiMcpServerValidateHcl",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/terraform/validate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApiMcpServerValidateHclResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证 Terraform HCL 语法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApiMcpServerValidateHclRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApiMcpServerValidateHclResponse
        /// </returns>
        public async Task<ApiMcpServerValidateHclResponse> ApiMcpServerValidateHclWithOptionsAsync(ApiMcpServerValidateHclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApiMcpServerValidateHcl",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/terraform/validate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApiMcpServerValidateHclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证 Terraform HCL 语法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApiMcpServerValidateHclRequest
        /// </param>
        /// 
        /// <returns>
        /// ApiMcpServerValidateHclResponse
        /// </returns>
        public ApiMcpServerValidateHclResponse ApiMcpServerValidateHcl(ApiMcpServerValidateHclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApiMcpServerValidateHclWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证 Terraform HCL 语法</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApiMcpServerValidateHclRequest
        /// </param>
        /// 
        /// <returns>
        /// ApiMcpServerValidateHclResponse
        /// </returns>
        public async Task<ApiMcpServerValidateHclResponse> ApiMcpServerValidateHclAsync(ApiMcpServerValidateHclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApiMcpServerValidateHclWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApiMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApiMcpServerResponse
        /// </returns>
        public CreateApiMcpServerResponse CreateApiMcpServerWithOptions(CreateApiMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalApiDescriptions))
            {
                body["additionalApiDescriptions"] = request.AdditionalApiDescriptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Apis))
            {
                body["apis"] = request.Apis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRoleExtraPolicy))
            {
                body["assumeRoleExtraPolicy"] = request.AssumeRoleExtraPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRoleName))
            {
                body["assumeRoleName"] = request.AssumeRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAssumeRole))
            {
                body["enableAssumeRole"] = request.EnableAssumeRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCustomVpcWhitelist))
            {
                body["enableCustomVpcWhitelist"] = request.EnableCustomVpcWhitelist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OauthClientId))
            {
                body["oauthClientId"] = request.OauthClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompts))
            {
                body["prompts"] = request.Prompts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicAccess))
            {
                body["publicAccess"] = request.PublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemTools))
            {
                body["systemTools"] = request.SystemTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformTools))
            {
                body["terraformTools"] = request.TerraformTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcWhitelists))
            {
                body["vpcWhitelists"] = request.VpcWhitelists;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiMcpServer",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpserver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApiMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApiMcpServerResponse
        /// </returns>
        public async Task<CreateApiMcpServerResponse> CreateApiMcpServerWithOptionsAsync(CreateApiMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalApiDescriptions))
            {
                body["additionalApiDescriptions"] = request.AdditionalApiDescriptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Apis))
            {
                body["apis"] = request.Apis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRoleExtraPolicy))
            {
                body["assumeRoleExtraPolicy"] = request.AssumeRoleExtraPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRoleName))
            {
                body["assumeRoleName"] = request.AssumeRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAssumeRole))
            {
                body["enableAssumeRole"] = request.EnableAssumeRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCustomVpcWhitelist))
            {
                body["enableCustomVpcWhitelist"] = request.EnableCustomVpcWhitelist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OauthClientId))
            {
                body["oauthClientId"] = request.OauthClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompts))
            {
                body["prompts"] = request.Prompts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicAccess))
            {
                body["publicAccess"] = request.PublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemTools))
            {
                body["systemTools"] = request.SystemTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformTools))
            {
                body["terraformTools"] = request.TerraformTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcWhitelists))
            {
                body["vpcWhitelists"] = request.VpcWhitelists;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiMcpServer",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpserver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApiMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApiMcpServerResponse
        /// </returns>
        public CreateApiMcpServerResponse CreateApiMcpServer(CreateApiMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApiMcpServerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApiMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApiMcpServerResponse
        /// </returns>
        public async Task<CreateApiMcpServerResponse> CreateApiMcpServerAsync(CreateApiMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApiMcpServerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApiMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiMcpServerResponse
        /// </returns>
        public DeleteApiMcpServerResponse DeleteApiMcpServerWithOptions(DeleteApiMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiMcpServer",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpserver",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApiMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiMcpServerResponse
        /// </returns>
        public async Task<DeleteApiMcpServerResponse> DeleteApiMcpServerWithOptionsAsync(DeleteApiMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiMcpServer",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpserver",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApiMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiMcpServerResponse
        /// </returns>
        public DeleteApiMcpServerResponse DeleteApiMcpServer(DeleteApiMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApiMcpServerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApiMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiMcpServerResponse
        /// </returns>
        public async Task<DeleteApiMcpServerResponse> DeleteApiMcpServerAsync(DeleteApiMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApiMcpServerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>动态生成Aliyun CLI命令</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateCLICommandRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCLICommandResponse
        /// </returns>
        public GenerateCLICommandResponse GenerateCLICommandWithOptions(GenerateCLICommandRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateCLICommandShrinkRequest request = new GenerateCLICommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiParams))
            {
                request.ApiParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiParams, "apiParams", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Api))
            {
                body["api"] = request.Api;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiParamsShrink))
            {
                body["apiParams"] = request.ApiParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                body["apiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonApiParams))
            {
                body["jsonApiParams"] = request.JsonApiParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCLICommand",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/api/cli/makeCode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCLICommandResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>动态生成Aliyun CLI命令</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateCLICommandRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateCLICommandResponse
        /// </returns>
        public async Task<GenerateCLICommandResponse> GenerateCLICommandWithOptionsAsync(GenerateCLICommandRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateCLICommandShrinkRequest request = new GenerateCLICommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiParams))
            {
                request.ApiParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiParams, "apiParams", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Api))
            {
                body["api"] = request.Api;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiParamsShrink))
            {
                body["apiParams"] = request.ApiParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                body["apiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonApiParams))
            {
                body["jsonApiParams"] = request.JsonApiParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateCLICommand",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/api/cli/makeCode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateCLICommandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>动态生成Aliyun CLI命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCLICommandRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCLICommandResponse
        /// </returns>
        public GenerateCLICommandResponse GenerateCLICommand(GenerateCLICommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateCLICommandWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>动态生成Aliyun CLI命令</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateCLICommandRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateCLICommandResponse
        /// </returns>
        public async Task<GenerateCLICommandResponse> GenerateCLICommandAsync(GenerateCLICommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateCLICommandWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品相关接口的开放元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApiDefinitionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApiDefinitionResponse
        /// </returns>
        public GetApiDefinitionResponse GetApiDefinitionWithOptions(GetApiDefinitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Api))
            {
                query["api"] = request.Api;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["apiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiDefinition",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/api/definition",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiDefinitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品相关接口的开放元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApiDefinitionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApiDefinitionResponse
        /// </returns>
        public async Task<GetApiDefinitionResponse> GetApiDefinitionWithOptionsAsync(GetApiDefinitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Api))
            {
                query["api"] = request.Api;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["apiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiDefinition",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/api/definition",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiDefinitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品相关接口的开放元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApiDefinitionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApiDefinitionResponse
        /// </returns>
        public GetApiDefinitionResponse GetApiDefinition(GetApiDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetApiDefinitionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品相关接口的开放元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApiDefinitionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApiDefinitionResponse
        /// </returns>
        public async Task<GetApiDefinitionResponse> GetApiDefinitionAsync(GetApiDefinitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetApiDefinitionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApiMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApiMcpServerResponse
        /// </returns>
        public GetApiMcpServerResponse GetApiMcpServerWithOptions(GetApiMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiMcpServer",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpserver",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApiMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApiMcpServerResponse
        /// </returns>
        public async Task<GetApiMcpServerResponse> GetApiMcpServerWithOptionsAsync(GetApiMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiMcpServer",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpserver",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApiMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApiMcpServerResponse
        /// </returns>
        public GetApiMcpServerResponse GetApiMcpServer(GetApiMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetApiMcpServerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApiMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApiMcpServerResponse
        /// </returns>
        public async Task<GetApiMcpServerResponse> GetApiMcpServerAsync(GetApiMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetApiMcpServerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户全局API MCP Server配置</para>
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
        /// GetApiMcpServerUserConfigResponse
        /// </returns>
        public GetApiMcpServerUserConfigResponse GetApiMcpServerUserConfigWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiMcpServerUserConfig",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/userconfig/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiMcpServerUserConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户全局API MCP Server配置</para>
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
        /// GetApiMcpServerUserConfigResponse
        /// </returns>
        public async Task<GetApiMcpServerUserConfigResponse> GetApiMcpServerUserConfigWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiMcpServerUserConfig",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/userconfig/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiMcpServerUserConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户全局API MCP Server配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetApiMcpServerUserConfigResponse
        /// </returns>
        public GetApiMcpServerUserConfigResponse GetApiMcpServerUserConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetApiMcpServerUserConfigWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户全局API MCP Server配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetApiMcpServerUserConfigResponse
        /// </returns>
        public async Task<GetApiMcpServerUserConfigResponse> GetApiMcpServerUserConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetApiMcpServerUserConfigWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an error solution by error code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query public information instead of special information, such as the account ownership. Permissions on this API operation cannot be granted to other members.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorCodeSolutionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErrorCodeSolutionsResponse
        /// </returns>
        public GetErrorCodeSolutionsResponse GetErrorCodeSolutionsWithOptions(GetErrorCodeSolutionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMessage))
            {
                query["errorMessage"] = request.ErrorMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErrorCodeSolutions",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getErrorCodeSolutions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErrorCodeSolutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an error solution by error code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query public information instead of special information, such as the account ownership. Permissions on this API operation cannot be granted to other members.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorCodeSolutionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErrorCodeSolutionsResponse
        /// </returns>
        public async Task<GetErrorCodeSolutionsResponse> GetErrorCodeSolutionsWithOptionsAsync(GetErrorCodeSolutionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMessage))
            {
                query["errorMessage"] = request.ErrorMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErrorCodeSolutions",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getErrorCodeSolutions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErrorCodeSolutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an error solution by error code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query public information instead of special information, such as the account ownership. Permissions on this API operation cannot be granted to other members.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorCodeSolutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErrorCodeSolutionsResponse
        /// </returns>
        public GetErrorCodeSolutionsResponse GetErrorCodeSolutions(GetErrorCodeSolutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetErrorCodeSolutionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an error solution by error code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query public information instead of special information, such as the account ownership. Permissions on this API operation cannot be granted to other members.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorCodeSolutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErrorCodeSolutionsResponse
        /// </returns>
        public async Task<GetErrorCodeSolutionsResponse> GetErrorCodeSolutionsAsync(GetErrorCodeSolutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetErrorCodeSolutionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an API call performed by using the current account based on the returned request ID of the API to troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Permissions on this API cannot be granted to other members.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOwnRequestLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOwnRequestLogResponse
        /// </returns>
        public GetOwnRequestLogResponse GetOwnRequestLogWithOptions(GetOwnRequestLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["logRequestId"] = request.LogRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOwnRequestLog",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getOwnRequestLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOwnRequestLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an API call performed by using the current account based on the returned request ID of the API to troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Permissions on this API cannot be granted to other members.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOwnRequestLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOwnRequestLogResponse
        /// </returns>
        public async Task<GetOwnRequestLogResponse> GetOwnRequestLogWithOptionsAsync(GetOwnRequestLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["logRequestId"] = request.LogRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOwnRequestLog",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getOwnRequestLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOwnRequestLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an API call performed by using the current account based on the returned request ID of the API to troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Permissions on this API cannot be granted to other members.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOwnRequestLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOwnRequestLogResponse
        /// </returns>
        public GetOwnRequestLogResponse GetOwnRequestLog(GetOwnRequestLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOwnRequestLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an API call performed by using the current account based on the returned request ID of the API to troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Permissions on this API cannot be granted to other members.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetOwnRequestLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOwnRequestLogResponse
        /// </returns>
        public async Task<GetOwnRequestLogResponse> GetOwnRequestLogAsync(GetOwnRequestLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOwnRequestLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品的接入点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductEndpointsResponse
        /// </returns>
        public GetProductEndpointsResponse GetProductEndpointsWithOptions(GetProductEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductEndpoints",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/product/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品的接入点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductEndpointsResponse
        /// </returns>
        public async Task<GetProductEndpointsResponse> GetProductEndpointsWithOptionsAsync(GetProductEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductEndpoints",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/product/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品的接入点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductEndpointsResponse
        /// </returns>
        public GetProductEndpointsResponse GetProductEndpoints(GetProductEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProductEndpointsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品的接入点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductEndpointsResponse
        /// </returns>
        public async Task<GetProductEndpointsResponse> GetProductEndpointsAsync(GetProductEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProductEndpointsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an API call based on the returned request ID of the API to troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can grant permissions to a Resource Access Management (RAM) user or assume a role to query the log of an API call across RAM users or Alibaba Cloud accounts. For more information, see <a href="https://help.aliyun.com/document_detail/2868101.html">Grant permissions to troubleshoot API errors across accounts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRequestLogResponse
        /// </returns>
        public GetRequestLogResponse GetRequestLogWithOptions(GetRequestLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["logRequestId"] = request.LogRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestLog",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getRequestLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an API call based on the returned request ID of the API to troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can grant permissions to a Resource Access Management (RAM) user or assume a role to query the log of an API call across RAM users or Alibaba Cloud accounts. For more information, see <a href="https://help.aliyun.com/document_detail/2868101.html">Grant permissions to troubleshoot API errors across accounts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRequestLogResponse
        /// </returns>
        public async Task<GetRequestLogResponse> GetRequestLogWithOptionsAsync(GetRequestLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["logRequestId"] = request.LogRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestLog",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/getRequestLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an API call based on the returned request ID of the API to troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can grant permissions to a Resource Access Management (RAM) user or assume a role to query the log of an API call across RAM users or Alibaba Cloud accounts. For more information, see <a href="https://help.aliyun.com/document_detail/2868101.html">Grant permissions to troubleshoot API errors across accounts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRequestLogResponse
        /// </returns>
        public GetRequestLogResponse GetRequestLog(GetRequestLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRequestLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an API call based on the returned request ID of the API to troubleshoot issues.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can grant permissions to a Resource Access Management (RAM) user or assume a role to query the log of an API call across RAM users or Alibaba Cloud accounts. For more information, see <a href="https://help.aliyun.com/document_detail/2868101.html">Grant permissions to troubleshoot API errors across accounts</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRequestLogResponse
        /// </returns>
        public async Task<GetRequestLogResponse> GetRequestLogAsync(GetRequestLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRequestLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品的开放元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiDefinitionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiDefinitionsResponse
        /// </returns>
        public ListApiDefinitionsResponse ListApiDefinitionsWithOptions(ListApiDefinitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["apiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiDefinitions",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/api/definitions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiDefinitionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品的开放元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiDefinitionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiDefinitionsResponse
        /// </returns>
        public async Task<ListApiDefinitionsResponse> ListApiDefinitionsWithOptionsAsync(ListApiDefinitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["apiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiDefinitions",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/api/definitions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiDefinitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品的开放元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiDefinitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiDefinitionsResponse
        /// </returns>
        public ListApiDefinitionsResponse ListApiDefinitions(ListApiDefinitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApiDefinitionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取产品的开放元数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiDefinitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiDefinitionsResponse
        /// </returns>
        public async Task<ListApiDefinitionsResponse> ListApiDefinitionsAsync(ListApiDefinitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApiDefinitionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统工具列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiMcpServerSystemToolsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiMcpServerSystemToolsResponse
        /// </returns>
        public ListApiMcpServerSystemToolsResponse ListApiMcpServerSystemToolsWithOptions(ListApiMcpServerSystemToolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["skip"] = request.Skip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiMcpServerSystemTools",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/mcpSystemTools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiMcpServerSystemToolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统工具列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiMcpServerSystemToolsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiMcpServerSystemToolsResponse
        /// </returns>
        public async Task<ListApiMcpServerSystemToolsResponse> ListApiMcpServerSystemToolsWithOptionsAsync(ListApiMcpServerSystemToolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["skip"] = request.Skip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiMcpServerSystemTools",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/mcpSystemTools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiMcpServerSystemToolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统工具列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiMcpServerSystemToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiMcpServerSystemToolsResponse
        /// </returns>
        public ListApiMcpServerSystemToolsResponse ListApiMcpServerSystemTools(ListApiMcpServerSystemToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApiMcpServerSystemToolsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询系统工具列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiMcpServerSystemToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiMcpServerSystemToolsResponse
        /// </returns>
        public async Task<ListApiMcpServerSystemToolsResponse> ListApiMcpServerSystemToolsAsync(ListApiMcpServerSystemToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApiMcpServerSystemToolsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiMcpServersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiMcpServersResponse
        /// </returns>
        public ListApiMcpServersResponse ListApiMcpServersWithOptions(ListApiMcpServersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                query["updateTime"] = request.UpdateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiMcpServers",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpservers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiMcpServersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiMcpServersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiMcpServersResponse
        /// </returns>
        public async Task<ListApiMcpServersResponse> ListApiMcpServersWithOptionsAsync(ListApiMcpServersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                query["updateTime"] = request.UpdateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiMcpServers",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpservers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiMcpServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiMcpServersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiMcpServersResponse
        /// </returns>
        public ListApiMcpServersResponse ListApiMcpServers(ListApiMcpServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApiMcpServersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源ApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApiMcpServersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiMcpServersResponse
        /// </returns>
        public async Task<ListApiMcpServersResponse> ListApiMcpServersAsync(ListApiMcpServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApiMcpServersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiMcpServerResponse
        /// </returns>
        public UpdateApiMcpServerResponse UpdateApiMcpServerWithOptions(UpdateApiMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalApiDescriptions))
            {
                body["additionalApiDescriptions"] = request.AdditionalApiDescriptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Apis))
            {
                body["apis"] = request.Apis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRoleExtraPolicy))
            {
                body["assumeRoleExtraPolicy"] = request.AssumeRoleExtraPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRoleName))
            {
                body["assumeRoleName"] = request.AssumeRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAssumeRole))
            {
                body["enableAssumeRole"] = request.EnableAssumeRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCustomVpcWhitelist))
            {
                body["enableCustomVpcWhitelist"] = request.EnableCustomVpcWhitelist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OauthClientId))
            {
                body["oauthClientId"] = request.OauthClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompts))
            {
                body["prompts"] = request.Prompts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicAccess))
            {
                body["publicAccess"] = request.PublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemTools))
            {
                body["systemTools"] = request.SystemTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformTools))
            {
                body["terraformTools"] = request.TerraformTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcWhitelists))
            {
                body["vpcWhitelists"] = request.VpcWhitelists;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiMcpServer",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpserver",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiMcpServerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiMcpServerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiMcpServerResponse
        /// </returns>
        public async Task<UpdateApiMcpServerResponse> UpdateApiMcpServerWithOptionsAsync(UpdateApiMcpServerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalApiDescriptions))
            {
                body["additionalApiDescriptions"] = request.AdditionalApiDescriptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Apis))
            {
                body["apis"] = request.Apis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRoleExtraPolicy))
            {
                body["assumeRoleExtraPolicy"] = request.AssumeRoleExtraPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRoleName))
            {
                body["assumeRoleName"] = request.AssumeRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAssumeRole))
            {
                body["enableAssumeRole"] = request.EnableAssumeRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCustomVpcWhitelist))
            {
                body["enableCustomVpcWhitelist"] = request.EnableCustomVpcWhitelist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OauthClientId))
            {
                body["oauthClientId"] = request.OauthClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompts))
            {
                body["prompts"] = request.Prompts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicAccess))
            {
                body["publicAccess"] = request.PublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemTools))
            {
                body["systemTools"] = request.SystemTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformTools))
            {
                body["terraformTools"] = request.TerraformTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcWhitelists))
            {
                body["vpcWhitelists"] = request.VpcWhitelists;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiMcpServer",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/apimcpserver",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiMcpServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiMcpServerResponse
        /// </returns>
        public UpdateApiMcpServerResponse UpdateApiMcpServer(UpdateApiMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApiMcpServerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateApiMcpServer</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiMcpServerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiMcpServerResponse
        /// </returns>
        public async Task<UpdateApiMcpServerResponse> UpdateApiMcpServerAsync(UpdateApiMcpServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApiMcpServerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户全局API MCP Server配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiMcpServerUserConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiMcpServerUserConfigResponse
        /// </returns>
        public UpdateApiMcpServerUserConfigResponse UpdateApiMcpServerUserConfigWithOptions(UpdateApiMcpServerUserConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublicAccess))
            {
                body["enablePublicAccess"] = request.EnablePublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcWhitelists))
            {
                body["vpcWhitelists"] = request.VpcWhitelists;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiMcpServerUserConfig",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/userconfig/update",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiMcpServerUserConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户全局API MCP Server配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiMcpServerUserConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiMcpServerUserConfigResponse
        /// </returns>
        public async Task<UpdateApiMcpServerUserConfigResponse> UpdateApiMcpServerUserConfigWithOptionsAsync(UpdateApiMcpServerUserConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublicAccess))
            {
                body["enablePublicAccess"] = request.EnablePublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcWhitelists))
            {
                body["vpcWhitelists"] = request.VpcWhitelists;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiMcpServerUserConfig",
                Version = "2024-11-30",
                Protocol = "HTTPS",
                Pathname = "/userconfig/update",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiMcpServerUserConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户全局API MCP Server配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiMcpServerUserConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiMcpServerUserConfigResponse
        /// </returns>
        public UpdateApiMcpServerUserConfigResponse UpdateApiMcpServerUserConfig(UpdateApiMcpServerUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApiMcpServerUserConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户全局API MCP Server配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApiMcpServerUserConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiMcpServerUserConfigResponse
        /// </returns>
        public async Task<UpdateApiMcpServerUserConfigResponse> UpdateApiMcpServerUserConfigAsync(UpdateApiMcpServerUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApiMcpServerUserConfigWithOptionsAsync(request, headers, runtime);
        }

    }
}
