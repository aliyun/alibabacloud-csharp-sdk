// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ada20260701.Models;

namespace AlibabaCloud.SDK.Ada20260701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ada", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates an Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is the unique identifier of the Agent within the current tenant. It can contain only letters, digits, underscores, and hyphens, and must be 1 to 128 characters in length. The name cannot be modified after creation.</description></item>
        /// <item><description>Each Agent can be associated with only one knowledge base.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgentWithOptions(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBases))
            {
                body["KnowledgeBases"] = request.KnowledgeBases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skills))
            {
                body["Skills"] = request.Skills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                body["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["Tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgent",
                Version = "2026-07-01",
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
        /// <para>Creates an Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is the unique identifier of the Agent within the current tenant. It can contain only letters, digits, underscores, and hyphens, and must be 1 to 128 characters in length. The name cannot be modified after creation.</description></item>
        /// <item><description>Each Agent can be associated with only one knowledge base.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentWithOptionsAsync(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBases))
            {
                body["KnowledgeBases"] = request.KnowledgeBases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skills))
            {
                body["Skills"] = request.Skills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                body["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["Tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgent",
                Version = "2026-07-01",
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
        /// <para>Creates an Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is the unique identifier of the Agent within the current tenant. It can contain only letters, digits, underscores, and hyphens, and must be 1 to 128 characters in length. The name cannot be modified after creation.</description></item>
        /// <item><description>Each Agent can be associated with only one knowledge base.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Creates an Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is the unique identifier of the Agent within the current tenant. It can contain only letters, digits, underscores, and hyphens, and must be 1 to 128 characters in length. The name cannot be modified after creation.</description></item>
        /// <item><description>Each Agent can be associated with only one knowledge base.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Creates a Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creation rules:<list type="bullet">
        /// <item><description><c>Name</c> must be unique within the current tenant and cannot share a name with an official Skill.</description></item>
        /// <item><description><c>Description</c> and <c>Metadata</c> are required. <c>Metadata</c> must contain exactly one valid content source. Different sources cannot be mixed.</description></item>
        /// <item><description>After the Skill is created, you can modify it by calling <c>UpdateSkill</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description><c>skillMd</c>: Directly provide the Markdown body without a YAML header. Specify the name and description by using <c>Name</c> and <c>Description</c>.</description></item>
        /// <item><description><c>transitId</c>: Upload and confirm a ZIP file through Transit. Call the operations in the following order:<ol>
        /// <item><description>Call <c>CreateTransitUploadPolicy</c> with <c>FileShowName</c> to obtain <c>TransitId</c>, <c>FilePath</c>, and <c>PolicyInfo</c>.</description></item>
        /// <item><description>Upload the ZIP file to object storage by using <c>PolicyInfo</c> and <c>FilePath</c>.</description></item>
        /// <item><description>Call <c>ConfirmTransitUpload</c> with <c>TransitId</c>. Proceed with creation only when the response returns <c>Confirmed=true</c>.</description></item>
        /// <item><description>Call <c>CreateSkill</c> and pass the confirmed <c>TransitId</c> in <c>Metadata.transitId</c>.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><c>bundleUrl</c>: Provide a public HTTPS direct link to a ZIP file. The platform downloads the file and saves it as an Artifact. The original URL is not persisted or returned in responses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public CreateSkillResponse CreateSkillWithOptions(CreateSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creation rules:<list type="bullet">
        /// <item><description><c>Name</c> must be unique within the current tenant and cannot share a name with an official Skill.</description></item>
        /// <item><description><c>Description</c> and <c>Metadata</c> are required. <c>Metadata</c> must contain exactly one valid content source. Different sources cannot be mixed.</description></item>
        /// <item><description>After the Skill is created, you can modify it by calling <c>UpdateSkill</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description><c>skillMd</c>: Directly provide the Markdown body without a YAML header. Specify the name and description by using <c>Name</c> and <c>Description</c>.</description></item>
        /// <item><description><c>transitId</c>: Upload and confirm a ZIP file through Transit. Call the operations in the following order:<ol>
        /// <item><description>Call <c>CreateTransitUploadPolicy</c> with <c>FileShowName</c> to obtain <c>TransitId</c>, <c>FilePath</c>, and <c>PolicyInfo</c>.</description></item>
        /// <item><description>Upload the ZIP file to object storage by using <c>PolicyInfo</c> and <c>FilePath</c>.</description></item>
        /// <item><description>Call <c>ConfirmTransitUpload</c> with <c>TransitId</c>. Proceed with creation only when the response returns <c>Confirmed=true</c>.</description></item>
        /// <item><description>Call <c>CreateSkill</c> and pass the confirmed <c>TransitId</c> in <c>Metadata.transitId</c>.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><c>bundleUrl</c>: Provide a public HTTPS direct link to a ZIP file. The platform downloads the file and saves it as an Artifact. The original URL is not persisted or returned in responses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public async Task<CreateSkillResponse> CreateSkillWithOptionsAsync(CreateSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creation rules:<list type="bullet">
        /// <item><description><c>Name</c> must be unique within the current tenant and cannot share a name with an official Skill.</description></item>
        /// <item><description><c>Description</c> and <c>Metadata</c> are required. <c>Metadata</c> must contain exactly one valid content source. Different sources cannot be mixed.</description></item>
        /// <item><description>After the Skill is created, you can modify it by calling <c>UpdateSkill</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description><c>skillMd</c>: Directly provide the Markdown body without a YAML header. Specify the name and description by using <c>Name</c> and <c>Description</c>.</description></item>
        /// <item><description><c>transitId</c>: Upload and confirm a ZIP file through Transit. Call the operations in the following order:<ol>
        /// <item><description>Call <c>CreateTransitUploadPolicy</c> with <c>FileShowName</c> to obtain <c>TransitId</c>, <c>FilePath</c>, and <c>PolicyInfo</c>.</description></item>
        /// <item><description>Upload the ZIP file to object storage by using <c>PolicyInfo</c> and <c>FilePath</c>.</description></item>
        /// <item><description>Call <c>ConfirmTransitUpload</c> with <c>TransitId</c>. Proceed with creation only when the response returns <c>Confirmed=true</c>.</description></item>
        /// <item><description>Call <c>CreateSkill</c> and pass the confirmed <c>TransitId</c> in <c>Metadata.transitId</c>.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><c>bundleUrl</c>: Provide a public HTTPS direct link to a ZIP file. The platform downloads the file and saves it as an Artifact. The original URL is not persisted or returned in responses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public CreateSkillResponse CreateSkill(CreateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creation rules:<list type="bullet">
        /// <item><description><c>Name</c> must be unique within the current tenant and cannot share a name with an official Skill.</description></item>
        /// <item><description><c>Description</c> and <c>Metadata</c> are required. <c>Metadata</c> must contain exactly one valid content source. Different sources cannot be mixed.</description></item>
        /// <item><description>After the Skill is created, you can modify it by calling <c>UpdateSkill</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content sources:<list type="bullet">
        /// <item><description><c>skillMd</c>: Directly provide the Markdown body without a YAML header. Specify the name and description by using <c>Name</c> and <c>Description</c>.</description></item>
        /// <item><description><c>transitId</c>: Upload and confirm a ZIP file through Transit. Call the operations in the following order:<ol>
        /// <item><description>Call <c>CreateTransitUploadPolicy</c> with <c>FileShowName</c> to obtain <c>TransitId</c>, <c>FilePath</c>, and <c>PolicyInfo</c>.</description></item>
        /// <item><description>Upload the ZIP file to object storage by using <c>PolicyInfo</c> and <c>FilePath</c>.</description></item>
        /// <item><description>Call <c>ConfirmTransitUpload</c> with <c>TransitId</c>. Proceed with creation only when the response returns <c>Confirmed=true</c>.</description></item>
        /// <item><description>Call <c>CreateSkill</c> and pass the confirmed <c>TransitId</c> in <c>Metadata.transitId</c>.</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><c>bundleUrl</c>: Provide a public HTTPS direct link to a ZIP file. The platform downloads the file and saves it as an Artifact. The original URL is not persisted or returned in responses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public async Task<CreateSkillResponse> CreateSkillAsync(CreateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a credential for direct file upload. The caller can use the returned upload policy to upload a file directly to object storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Network</c> can be set to <c>public</c> or <c>internal</c> to generate a public or same-region internal upload address. Default value: <c>public</c>.</description></item>
        /// <item><description>The maximum size of a single file is 50 MiB.</description></item>
        /// <item><description><c>PolicyInfo</c> contains short-term upload authorization information intended only for the current file upload. Do not log it, persist it long-term, or forward it to other users.</description></item>
        /// <item><description><c>ExpireMs</c> controls the validity period of the upload policy and the Transit record, in milliseconds. It is not an absolute timestamp. The default and maximum value is <c>604800000</c> (7 days), and the minimum value is <c>1000</c> (1 second). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>Call <c>GetTransitMeta</c> and read <c>ExpireAt</c> to obtain the expiration time of the Transit record. Confirming the upload or querying the record does not extend the validity period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTransitUploadPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTransitUploadPolicyResponse
        /// </returns>
        public CreateTransitUploadPolicyResponse CreateTransitUploadPolicyWithOptions(CreateTransitUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMs))
            {
                body["ExpireMs"] = request.ExpireMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileShowName))
            {
                body["FileShowName"] = request.FileShowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathPrefix))
            {
                body["PathPrefix"] = request.PathPrefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitUploadPolicy",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitUploadPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a credential for direct file upload. The caller can use the returned upload policy to upload a file directly to object storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Network</c> can be set to <c>public</c> or <c>internal</c> to generate a public or same-region internal upload address. Default value: <c>public</c>.</description></item>
        /// <item><description>The maximum size of a single file is 50 MiB.</description></item>
        /// <item><description><c>PolicyInfo</c> contains short-term upload authorization information intended only for the current file upload. Do not log it, persist it long-term, or forward it to other users.</description></item>
        /// <item><description><c>ExpireMs</c> controls the validity period of the upload policy and the Transit record, in milliseconds. It is not an absolute timestamp. The default and maximum value is <c>604800000</c> (7 days), and the minimum value is <c>1000</c> (1 second). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>Call <c>GetTransitMeta</c> and read <c>ExpireAt</c> to obtain the expiration time of the Transit record. Confirming the upload or querying the record does not extend the validity period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTransitUploadPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTransitUploadPolicyResponse
        /// </returns>
        public async Task<CreateTransitUploadPolicyResponse> CreateTransitUploadPolicyWithOptionsAsync(CreateTransitUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMs))
            {
                body["ExpireMs"] = request.ExpireMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileShowName))
            {
                body["FileShowName"] = request.FileShowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathPrefix))
            {
                body["PathPrefix"] = request.PathPrefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitUploadPolicy",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitUploadPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a credential for direct file upload. The caller can use the returned upload policy to upload a file directly to object storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Network</c> can be set to <c>public</c> or <c>internal</c> to generate a public or same-region internal upload address. Default value: <c>public</c>.</description></item>
        /// <item><description>The maximum size of a single file is 50 MiB.</description></item>
        /// <item><description><c>PolicyInfo</c> contains short-term upload authorization information intended only for the current file upload. Do not log it, persist it long-term, or forward it to other users.</description></item>
        /// <item><description><c>ExpireMs</c> controls the validity period of the upload policy and the Transit record, in milliseconds. It is not an absolute timestamp. The default and maximum value is <c>604800000</c> (7 days), and the minimum value is <c>1000</c> (1 second). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>Call <c>GetTransitMeta</c> and read <c>ExpireAt</c> to obtain the expiration time of the Transit record. Confirming the upload or querying the record does not extend the validity period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTransitUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTransitUploadPolicyResponse
        /// </returns>
        public CreateTransitUploadPolicyResponse CreateTransitUploadPolicy(CreateTransitUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitUploadPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a credential for direct file upload. The caller can use the returned upload policy to upload a file directly to object storage.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Network</c> can be set to <c>public</c> or <c>internal</c> to generate a public or same-region internal upload address. Default value: <c>public</c>.</description></item>
        /// <item><description>The maximum size of a single file is 50 MiB.</description></item>
        /// <item><description><c>PolicyInfo</c> contains short-term upload authorization information intended only for the current file upload. Do not log it, persist it long-term, or forward it to other users.</description></item>
        /// <item><description><c>ExpireMs</c> controls the validity period of the upload policy and the Transit record, in milliseconds. It is not an absolute timestamp. The default and maximum value is <c>604800000</c> (7 days), and the minimum value is <c>1000</c> (1 second). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds takes effect as 1 second.</description></item>
        /// <item><description>Call <c>GetTransitMeta</c> and read <c>ExpireAt</c> to obtain the expiration time of the Transit record. Confirming the upload or querying the record does not extend the validity period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTransitUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTransitUploadPolicyResponse
        /// </returns>
        public async Task<CreateTransitUploadPolicyResponse> CreateTransitUploadPolicyAsync(CreateTransitUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitUploadPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creators can delete Agents that they created.</description></item>
        /// <item><description>After deletion, the Agent can no longer be queried, updated, or run.</description></item>
        /// </list>
        /// </description>
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
                Action = "DeleteAgent",
                Version = "2026-07-01",
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
        /// <para>Deletes a specified Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creators can delete Agents that they created.</description></item>
        /// <item><description>After deletion, the Agent can no longer be queried, updated, or run.</description></item>
        /// </list>
        /// </description>
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
                Action = "DeleteAgent",
                Version = "2026-07-01",
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
        /// <para>Deletes a specified Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creators can delete Agents that they created.</description></item>
        /// <item><description>After deletion, the Agent can no longer be queried, updated, or run.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Deletes a specified Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Creators can delete Agents that they created.</description></item>
        /// <item><description>After deletion, the Agent can no longer be queried, updated, or run.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Soft-deletes a Skill that the current caller has permission to modify.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deletion permissions:<list type="bullet">
        /// <item><description>You can only delete custom Skills that the current caller has permission to modify.</description></item>
        /// <item><description>The caller must be the Skill creator or the tenant root account that has permission to manage the tenant-level Skill. Official Skills cannot be deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Deletion results:<list type="bullet">
        /// <item><description>Deletion uses soft delete. After successful deletion, <c>GetSkill</c> and <c>ListSkills</c> no longer return the Skill, and you can create a new Skill with the same name.</description></item>
        /// <item><description>Recovery is not supported. You cannot delete a Skill that has already been deleted or does not exist.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public DeleteSkillResponse DeleteSkillWithOptions(DeleteSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Soft-deletes a Skill that the current caller has permission to modify.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deletion permissions:<list type="bullet">
        /// <item><description>You can only delete custom Skills that the current caller has permission to modify.</description></item>
        /// <item><description>The caller must be the Skill creator or the tenant root account that has permission to manage the tenant-level Skill. Official Skills cannot be deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Deletion results:<list type="bullet">
        /// <item><description>Deletion uses soft delete. After successful deletion, <c>GetSkill</c> and <c>ListSkills</c> no longer return the Skill, and you can create a new Skill with the same name.</description></item>
        /// <item><description>Recovery is not supported. You cannot delete a Skill that has already been deleted or does not exist.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public async Task<DeleteSkillResponse> DeleteSkillWithOptionsAsync(DeleteSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Soft-deletes a Skill that the current caller has permission to modify.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deletion permissions:<list type="bullet">
        /// <item><description>You can only delete custom Skills that the current caller has permission to modify.</description></item>
        /// <item><description>The caller must be the Skill creator or the tenant root account that has permission to manage the tenant-level Skill. Official Skills cannot be deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Deletion results:<list type="bullet">
        /// <item><description>Deletion uses soft delete. After successful deletion, <c>GetSkill</c> and <c>ListSkills</c> no longer return the Skill, and you can create a new Skill with the same name.</description></item>
        /// <item><description>Recovery is not supported. You cannot delete a Skill that has already been deleted or does not exist.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public DeleteSkillResponse DeleteSkill(DeleteSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Soft-deletes a Skill that the current caller has permission to modify.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Deletion permissions:<list type="bullet">
        /// <item><description>You can only delete custom Skills that the current caller has permission to modify.</description></item>
        /// <item><description>The caller must be the Skill creator or the tenant root account that has permission to manage the tenant-level Skill. Official Skills cannot be deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Deletion results:<list type="bullet">
        /// <item><description>Deletion uses soft delete. After successful deletion, <c>GetSkill</c> and <c>ListSkills</c> no longer return the Skill, and you can create a new Skill with the same name.</description></item>
        /// <item><description>Recovery is not supported. You cannot delete a Skill that has already been deleted or does not exist.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public async Task<DeleteSkillResponse> DeleteSkillAsync(DeleteSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an agent visible to the current identity by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can retrieve agents that you created, agents visible within the current tenant, and official agents provided by the platform.</description></item>
        /// </list>
        /// </description>
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
                Action = "GetAgent",
                Version = "2026-07-01",
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
        /// <para>Queries an agent visible to the current identity by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can retrieve agents that you created, agents visible within the current tenant, and official agents provided by the platform.</description></item>
        /// </list>
        /// </description>
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
                Action = "GetAgent",
                Version = "2026-07-01",
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
        /// <para>Queries an agent visible to the current identity by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can retrieve agents that you created, agents visible within the current tenant, and official agents provided by the platform.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries an agent visible to the current identity by name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can retrieve agents that you created, agents visible within the current tenant, and official agents provided by the platform.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries a Skill by name that is visible to the current caller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query target:<list type="bullet">
        /// <item><description>Queries by <c>Name</c>. Querying by <c>SkillId</c> is not supported.</description></item>
        /// <item><description>Returns the Skill with the matching name that is visible to the current caller under the current tenant first. If no visible record exists, queries the official Skill with the same name.</description></item>
        /// <item><description>If <c>SkillVersion</c> is omitted, the current Skill is returned. This parameter is omitted by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Download URL:<list type="bullet">
        /// <item><description><c>Network</c> supports <c>public</c> and <c>internal</c>. If omitted, no download URL is generated.</description></item>
        /// <item><description>If the Skill has an accessible Artifact, a temporary <c>DownloadUrl</c> and the corresponding <c>DownloadUrlNetwork</c> are returned.</description></item>
        /// <item><description>If the Artifact does not exist, is inaccessible, or the URL generation fails, the Skill query still succeeds, but download URL-related fields may not be returned.</description></item>
        /// <item><description>The original <c>bundleUrl</c> used during creation is not stored and is not returned by this operation.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public GetSkillResponse GetSkillWithOptions(GetSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillVersion))
            {
                query["SkillVersion"] = request.SkillVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Skill by name that is visible to the current caller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query target:<list type="bullet">
        /// <item><description>Queries by <c>Name</c>. Querying by <c>SkillId</c> is not supported.</description></item>
        /// <item><description>Returns the Skill with the matching name that is visible to the current caller under the current tenant first. If no visible record exists, queries the official Skill with the same name.</description></item>
        /// <item><description>If <c>SkillVersion</c> is omitted, the current Skill is returned. This parameter is omitted by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Download URL:<list type="bullet">
        /// <item><description><c>Network</c> supports <c>public</c> and <c>internal</c>. If omitted, no download URL is generated.</description></item>
        /// <item><description>If the Skill has an accessible Artifact, a temporary <c>DownloadUrl</c> and the corresponding <c>DownloadUrlNetwork</c> are returned.</description></item>
        /// <item><description>If the Artifact does not exist, is inaccessible, or the URL generation fails, the Skill query still succeeds, but download URL-related fields may not be returned.</description></item>
        /// <item><description>The original <c>bundleUrl</c> used during creation is not stored and is not returned by this operation.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public async Task<GetSkillResponse> GetSkillWithOptionsAsync(GetSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillVersion))
            {
                query["SkillVersion"] = request.SkillVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Skill by name that is visible to the current caller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query target:<list type="bullet">
        /// <item><description>Queries by <c>Name</c>. Querying by <c>SkillId</c> is not supported.</description></item>
        /// <item><description>Returns the Skill with the matching name that is visible to the current caller under the current tenant first. If no visible record exists, queries the official Skill with the same name.</description></item>
        /// <item><description>If <c>SkillVersion</c> is omitted, the current Skill is returned. This parameter is omitted by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Download URL:<list type="bullet">
        /// <item><description><c>Network</c> supports <c>public</c> and <c>internal</c>. If omitted, no download URL is generated.</description></item>
        /// <item><description>If the Skill has an accessible Artifact, a temporary <c>DownloadUrl</c> and the corresponding <c>DownloadUrlNetwork</c> are returned.</description></item>
        /// <item><description>If the Artifact does not exist, is inaccessible, or the URL generation fails, the Skill query still succeeds, but download URL-related fields may not be returned.</description></item>
        /// <item><description>The original <c>bundleUrl</c> used during creation is not stored and is not returned by this operation.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public GetSkillResponse GetSkill(GetSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a Skill by name that is visible to the current caller.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query target:<list type="bullet">
        /// <item><description>Queries by <c>Name</c>. Querying by <c>SkillId</c> is not supported.</description></item>
        /// <item><description>Returns the Skill with the matching name that is visible to the current caller under the current tenant first. If no visible record exists, queries the official Skill with the same name.</description></item>
        /// <item><description>If <c>SkillVersion</c> is omitted, the current Skill is returned. This parameter is omitted by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Download URL:<list type="bullet">
        /// <item><description><c>Network</c> supports <c>public</c> and <c>internal</c>. If omitted, no download URL is generated.</description></item>
        /// <item><description>If the Skill has an accessible Artifact, a temporary <c>DownloadUrl</c> and the corresponding <c>DownloadUrlNetwork</c> are returned.</description></item>
        /// <item><description>If the Artifact does not exist, is inaccessible, or the URL generation fails, the Skill query still succeeds, but download URL-related fields may not be returned.</description></item>
        /// <item><description>The original <c>bundleUrl</c> used during creation is not stored and is not returned by this operation.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public async Task<GetSkillResponse> GetSkillAsync(GetSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a Transit file, including the upload status, file size, and expiration time, and optionally generates a temporary download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of <c>TransitId</c> and <c>FilePath</c>. If both are specified, <c>TransitId</c> takes precedence.</description></item>
        /// <item><description>Use the <c>TransitId</c> returned by <c>CreateTransitUploadPolicy</c> to query the file. <c>TransitId</c> is a temporary capability identifier used during the file upload process. Do not share it with unauthorized users.</description></item>
        /// <item><description><c>FilePath</c> is an opaque object path returned by <c>CreateTransitUploadPolicy</c>. Use it as-is. Do not parse, modify, or construct it manually.</description></item>
        /// <item><description>When you query by <c>FilePath</c>, an error is returned if the record does not exist or is not accessible to the caller.</description></item>
        /// <item><description><c>ExpireMs</c> specifies the validity period of the download URL in milliseconds. Default value: <c>900000</c> (15 minutes). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds is rounded down to 1 second.</description></item>
        /// <item><description><c>ExpireAt</c> is the expiration time of the Transit record, not the expiration time of the download URL. Querying, generating a download URL, and confirming the upload do not extend the record validity period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTransitMetaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTransitMetaResponse
        /// </returns>
        public GetTransitMetaResponse GetTransitMetaWithOptions(GetTransitMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMs))
            {
                query["ExpireMs"] = request.ExpireMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitId))
            {
                query["TransitId"] = request.TransitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTransitMeta",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTransitMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a Transit file, including the upload status, file size, and expiration time, and optionally generates a temporary download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of <c>TransitId</c> and <c>FilePath</c>. If both are specified, <c>TransitId</c> takes precedence.</description></item>
        /// <item><description>Use the <c>TransitId</c> returned by <c>CreateTransitUploadPolicy</c> to query the file. <c>TransitId</c> is a temporary capability identifier used during the file upload process. Do not share it with unauthorized users.</description></item>
        /// <item><description><c>FilePath</c> is an opaque object path returned by <c>CreateTransitUploadPolicy</c>. Use it as-is. Do not parse, modify, or construct it manually.</description></item>
        /// <item><description>When you query by <c>FilePath</c>, an error is returned if the record does not exist or is not accessible to the caller.</description></item>
        /// <item><description><c>ExpireMs</c> specifies the validity period of the download URL in milliseconds. Default value: <c>900000</c> (15 minutes). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds is rounded down to 1 second.</description></item>
        /// <item><description><c>ExpireAt</c> is the expiration time of the Transit record, not the expiration time of the download URL. Querying, generating a download URL, and confirming the upload do not extend the record validity period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTransitMetaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTransitMetaResponse
        /// </returns>
        public async Task<GetTransitMetaResponse> GetTransitMetaWithOptionsAsync(GetTransitMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireMs))
            {
                query["ExpireMs"] = request.ExpireMs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitId))
            {
                query["TransitId"] = request.TransitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTransitMeta",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTransitMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a Transit file, including the upload status, file size, and expiration time, and optionally generates a temporary download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of <c>TransitId</c> and <c>FilePath</c>. If both are specified, <c>TransitId</c> takes precedence.</description></item>
        /// <item><description>Use the <c>TransitId</c> returned by <c>CreateTransitUploadPolicy</c> to query the file. <c>TransitId</c> is a temporary capability identifier used during the file upload process. Do not share it with unauthorized users.</description></item>
        /// <item><description><c>FilePath</c> is an opaque object path returned by <c>CreateTransitUploadPolicy</c>. Use it as-is. Do not parse, modify, or construct it manually.</description></item>
        /// <item><description>When you query by <c>FilePath</c>, an error is returned if the record does not exist or is not accessible to the caller.</description></item>
        /// <item><description><c>ExpireMs</c> specifies the validity period of the download URL in milliseconds. Default value: <c>900000</c> (15 minutes). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds is rounded down to 1 second.</description></item>
        /// <item><description><c>ExpireAt</c> is the expiration time of the Transit record, not the expiration time of the download URL. Querying, generating a download URL, and confirming the upload do not extend the record validity period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTransitMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTransitMetaResponse
        /// </returns>
        public GetTransitMetaResponse GetTransitMeta(GetTransitMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTransitMetaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a Transit file, including the upload status, file size, and expiration time, and optionally generates a temporary download URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Specify at least one of <c>TransitId</c> and <c>FilePath</c>. If both are specified, <c>TransitId</c> takes precedence.</description></item>
        /// <item><description>Use the <c>TransitId</c> returned by <c>CreateTransitUploadPolicy</c> to query the file. <c>TransitId</c> is a temporary capability identifier used during the file upload process. Do not share it with unauthorized users.</description></item>
        /// <item><description><c>FilePath</c> is an opaque object path returned by <c>CreateTransitUploadPolicy</c>. Use it as-is. Do not parse, modify, or construct it manually.</description></item>
        /// <item><description>When you query by <c>FilePath</c>, an error is returned if the record does not exist or is not accessible to the caller.</description></item>
        /// <item><description><c>ExpireMs</c> specifies the validity period of the download URL in milliseconds. Default value: <c>900000</c> (15 minutes). The validity period is rounded down to the nearest whole second. For example, 1500 milliseconds is rounded down to 1 second.</description></item>
        /// <item><description><c>ExpireAt</c> is the expiration time of the Transit record, not the expiration time of the download URL. Querying, generating a download URL, and confirming the upload do not extend the record validity period.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTransitMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTransitMetaResponse
        /// </returns>
        public async Task<GetTransitMetaResponse> GetTransitMetaAsync(GetTransitMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTransitMetaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries agents visible to the current identity by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>By default, returns official platform agents and tenant agents visible to the current identity.</description></item>
        /// <item><description>Set <c>Scope=SYSTEM</c> to query only official agents, or <c>Scope=CUSTOM</c> to query only custom agents.</description></item>
        /// <item><description>Both cursor-based pagination and page number-based pagination are supported. When using cursor-based pagination, pass the <c>NextToken</c> value from the previous response to the next request, and keep the caller identity, filter conditions, and <c>MaxResults</c> unchanged.</description></item>
        /// </list>
        /// </description>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                query["CreatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Q))
            {
                query["Q"] = request.Q;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredRuntime))
            {
                query["RequiredRuntime"] = request.RequiredRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                query["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgents",
                Version = "2026-07-01",
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
        /// <para>Queries agents visible to the current identity by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>By default, returns official platform agents and tenant agents visible to the current identity.</description></item>
        /// <item><description>Set <c>Scope=SYSTEM</c> to query only official agents, or <c>Scope=CUSTOM</c> to query only custom agents.</description></item>
        /// <item><description>Both cursor-based pagination and page number-based pagination are supported. When using cursor-based pagination, pass the <c>NextToken</c> value from the previous response to the next request, and keep the caller identity, filter conditions, and <c>MaxResults</c> unchanged.</description></item>
        /// </list>
        /// </description>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                query["CreatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Q))
            {
                query["Q"] = request.Q;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequiredRuntime))
            {
                query["RequiredRuntime"] = request.RequiredRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                query["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgents",
                Version = "2026-07-01",
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
        /// <para>Queries agents visible to the current identity by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>By default, returns official platform agents and tenant agents visible to the current identity.</description></item>
        /// <item><description>Set <c>Scope=SYSTEM</c> to query only official agents, or <c>Scope=CUSTOM</c> to query only custom agents.</description></item>
        /// <item><description>Both cursor-based pagination and page number-based pagination are supported. When using cursor-based pagination, pass the <c>NextToken</c> value from the previous response to the next request, and keep the caller identity, filter conditions, and <c>MaxResults</c> unchanged.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries agents visible to the current identity by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>By default, returns official platform agents and tenant agents visible to the current identity.</description></item>
        /// <item><description>Set <c>Scope=SYSTEM</c> to query only official agents, or <c>Scope=CUSTOM</c> to query only custom agents.</description></item>
        /// <item><description>Both cursor-based pagination and page number-based pagination are supported. When using cursor-based pagination, pass the <c>NextToken</c> value from the previous response to the next request, and keep the caller identity, filter conditions, and <c>MaxResults</c> unchanged.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries Skills visible to the current caller by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query and filtering: <list type="bullet">
        /// <item><description>Set <c>Scope=SYSTEM</c> to query only official Skills, or <c>Scope=CUSTOM</c> to query only custom Skills. If omitted, both official and custom Skills are queried.</description></item>
        /// <item><description>Custom Skills with <c>user</c> visibility are visible only to the creator. Skills with <c>tenant</c> visibility are visible to the current tenant.</description></item>
        /// <item><description>Filtering by <c>CreatorId</c>, <c>Q</c>, and <c>Visibility</c> is supported. <c>Q</c> performs a fuzzy match on the Skill name or description.</description></item>
        /// <item><description>Results are sorted by update time in descending order by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Pagination: <list type="bullet">
        /// <item><description>For cursor-based pagination, use <c>MaxResults</c> and <c>NextToken</c>. Do not pass <c>NextToken</c> for the first query. For subsequent pages, use the token returned in the previous response. When using <c>NextToken</c> for subsequent pages, <c>CreatorId</c>, <c>Q</c>, <c>Visibility</c>, <c>Scope</c>, and <c>MaxResults</c> must remain the same as the previous page. If you change the query conditions, start over from the first page.</description></item>
        /// <item><description>For page-number-based pagination, use <c>PageNumber</c> and <c>PageSize</c>. If <c>MaxResults</c> is explicitly specified, cursor-based pagination takes precedence. If <c>NextToken</c> is specified, <c>PageNumber</c> is ignored.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Response content: <list type="bullet">
        /// <item><description>This operation returns only Skill summaries and does not generate Bundle download URLs. To obtain download URLs, call <c>GetSkill</c> and specify <c>Network</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkillsWithOptions(ListSkillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                query["CreatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Q))
            {
                query["Q"] = request.Q;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                query["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Skills visible to the current caller by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query and filtering: <list type="bullet">
        /// <item><description>Set <c>Scope=SYSTEM</c> to query only official Skills, or <c>Scope=CUSTOM</c> to query only custom Skills. If omitted, both official and custom Skills are queried.</description></item>
        /// <item><description>Custom Skills with <c>user</c> visibility are visible only to the creator. Skills with <c>tenant</c> visibility are visible to the current tenant.</description></item>
        /// <item><description>Filtering by <c>CreatorId</c>, <c>Q</c>, and <c>Visibility</c> is supported. <c>Q</c> performs a fuzzy match on the Skill name or description.</description></item>
        /// <item><description>Results are sorted by update time in descending order by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Pagination: <list type="bullet">
        /// <item><description>For cursor-based pagination, use <c>MaxResults</c> and <c>NextToken</c>. Do not pass <c>NextToken</c> for the first query. For subsequent pages, use the token returned in the previous response. When using <c>NextToken</c> for subsequent pages, <c>CreatorId</c>, <c>Q</c>, <c>Visibility</c>, <c>Scope</c>, and <c>MaxResults</c> must remain the same as the previous page. If you change the query conditions, start over from the first page.</description></item>
        /// <item><description>For page-number-based pagination, use <c>PageNumber</c> and <c>PageSize</c>. If <c>MaxResults</c> is explicitly specified, cursor-based pagination takes precedence. If <c>NextToken</c> is specified, <c>PageNumber</c> is ignored.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Response content: <list type="bullet">
        /// <item><description>This operation returns only Skill summaries and does not generate Bundle download URLs. To obtain download URLs, call <c>GetSkill</c> and specify <c>Network</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsWithOptionsAsync(ListSkillsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                query["CreatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Q))
            {
                query["Q"] = request.Q;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                query["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Skills visible to the current caller by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query and filtering: <list type="bullet">
        /// <item><description>Set <c>Scope=SYSTEM</c> to query only official Skills, or <c>Scope=CUSTOM</c> to query only custom Skills. If omitted, both official and custom Skills are queried.</description></item>
        /// <item><description>Custom Skills with <c>user</c> visibility are visible only to the creator. Skills with <c>tenant</c> visibility are visible to the current tenant.</description></item>
        /// <item><description>Filtering by <c>CreatorId</c>, <c>Q</c>, and <c>Visibility</c> is supported. <c>Q</c> performs a fuzzy match on the Skill name or description.</description></item>
        /// <item><description>Results are sorted by update time in descending order by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Pagination: <list type="bullet">
        /// <item><description>For cursor-based pagination, use <c>MaxResults</c> and <c>NextToken</c>. Do not pass <c>NextToken</c> for the first query. For subsequent pages, use the token returned in the previous response. When using <c>NextToken</c> for subsequent pages, <c>CreatorId</c>, <c>Q</c>, <c>Visibility</c>, <c>Scope</c>, and <c>MaxResults</c> must remain the same as the previous page. If you change the query conditions, start over from the first page.</description></item>
        /// <item><description>For page-number-based pagination, use <c>PageNumber</c> and <c>PageSize</c>. If <c>MaxResults</c> is explicitly specified, cursor-based pagination takes precedence. If <c>NextToken</c> is specified, <c>PageNumber</c> is ignored.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Response content: <list type="bullet">
        /// <item><description>This operation returns only Skill summaries and does not generate Bundle download URLs. To obtain download URLs, call <c>GetSkill</c> and specify <c>Network</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkills(ListSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Skills visible to the current caller by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Query and filtering: <list type="bullet">
        /// <item><description>Set <c>Scope=SYSTEM</c> to query only official Skills, or <c>Scope=CUSTOM</c> to query only custom Skills. If omitted, both official and custom Skills are queried.</description></item>
        /// <item><description>Custom Skills with <c>user</c> visibility are visible only to the creator. Skills with <c>tenant</c> visibility are visible to the current tenant.</description></item>
        /// <item><description>Filtering by <c>CreatorId</c>, <c>Q</c>, and <c>Visibility</c> is supported. <c>Q</c> performs a fuzzy match on the Skill name or description.</description></item>
        /// <item><description>Results are sorted by update time in descending order by default.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Pagination: <list type="bullet">
        /// <item><description>For cursor-based pagination, use <c>MaxResults</c> and <c>NextToken</c>. Do not pass <c>NextToken</c> for the first query. For subsequent pages, use the token returned in the previous response. When using <c>NextToken</c> for subsequent pages, <c>CreatorId</c>, <c>Q</c>, <c>Visibility</c>, <c>Scope</c>, and <c>MaxResults</c> must remain the same as the previous page. If you change the query conditions, start over from the first page.</description></item>
        /// <item><description>For page-number-based pagination, use <c>PageNumber</c> and <c>PageSize</c>. If <c>MaxResults</c> is explicitly specified, cursor-based pagination takes precedence. If <c>NextToken</c> is specified, <c>PageNumber</c> is ignored.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Response content: <list type="bullet">
        /// <item><description>This operation returns only Skill summaries and does not generate Bundle download URLs. To obtain download URLs, call <c>GetSkill</c> and specify <c>Network</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsAsync(ListSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of an Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the Agent and cannot be modified after creation.</description></item>
        /// <item><description>Each Agent can be bindded to only one knowledge base.</description></item>
        /// <item><description><c>Tools</c> is updated according to the rules below. If <c>Skills</c> or <c>KnowledgeBases</c> is not specified, the existing value is retained. A non-empty array replaces the entire value. An empty array removes the corresponding binddings. Other optional fields retain their existing values if not specified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgentWithOptions(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBases))
            {
                body["KnowledgeBases"] = request.KnowledgeBases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skills))
            {
                body["Skills"] = request.Skills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                body["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["Tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgent",
                Version = "2026-07-01",
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
        /// <para>Updates the configuration of an Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the Agent and cannot be modified after creation.</description></item>
        /// <item><description>Each Agent can be bindded to only one knowledge base.</description></item>
        /// <item><description><c>Tools</c> is updated according to the rules below. If <c>Skills</c> or <c>KnowledgeBases</c> is not specified, the existing value is retained. A non-empty array replaces the entire value. An empty array removes the corresponding binddings. Other optional fields retain their existing values if not specified.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentWithOptionsAsync(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBases))
            {
                body["KnowledgeBases"] = request.KnowledgeBases;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skills))
            {
                body["Skills"] = request.Skills;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                body["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["Tools"] = request.Tools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgent",
                Version = "2026-07-01",
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
        /// <para>Updates the configuration of an Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the Agent and cannot be modified after creation.</description></item>
        /// <item><description>Each Agent can be bindded to only one knowledge base.</description></item>
        /// <item><description><c>Tools</c> is updated according to the rules below. If <c>Skills</c> or <c>KnowledgeBases</c> is not specified, the existing value is retained. A non-empty array replaces the entire value. An empty array removes the corresponding binddings. Other optional fields retain their existing values if not specified.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Updates the configuration of an Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the Agent and cannot be modified after creation.</description></item>
        /// <item><description>Each Agent can be bindded to only one knowledge base.</description></item>
        /// <item><description><c>Tools</c> is updated according to the rules below. If <c>Skills</c> or <c>KnowledgeBases</c> is not specified, the existing value is retained. A non-empty array replaces the entire value. An empty array removes the corresponding binddings. Other optional fields retain their existing values if not specified.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Updates a Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Update rules:<list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the Skill and cannot be modified.</description></item>
        /// <item><description>The caller must be the Skill creator or the tenant root account that has permissions to manage the tenant-level Skill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Replacement rules:<list type="bullet">
        /// <item><description><c>Description</c> and <c>Visibility</c> retain their original values when omitted. Passing <c>null</c> is treated the same as omitting the field and cannot be used to clear the original value.</description></item>
        /// <item><description><c>Metadata</c> is replaced as a whole, not merged incrementally. Omitting <c>Metadata</c> preserves the original content. When provided, any old fields not included in the new object are deleted.</description></item>
        /// <item><description>When modifying only <c>Description</c> or <c>Visibility</c>, do not pass <c>Metadata</c> or an empty object <c>{}</c>. An empty object replaces the entire original Metadata with an empty value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content source:<list type="bullet">
        /// <item><description>When replacing the body or bundle, specify exactly one of <c>skillMd</c>, <c>transitId</c>, or <c>bundleUrl</c>.</description></item>
        /// <item><description>For field formats, the Transit upload confirmation process, and <c>bundleUrl</c> restrictions of the three sources, refer to CreateSkill. Pass the selected source in <c>UpdateSkill.Metadata</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public UpdateSkillResponse UpdateSkillWithOptions(UpdateSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Update rules:<list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the Skill and cannot be modified.</description></item>
        /// <item><description>The caller must be the Skill creator or the tenant root account that has permissions to manage the tenant-level Skill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Replacement rules:<list type="bullet">
        /// <item><description><c>Description</c> and <c>Visibility</c> retain their original values when omitted. Passing <c>null</c> is treated the same as omitting the field and cannot be used to clear the original value.</description></item>
        /// <item><description><c>Metadata</c> is replaced as a whole, not merged incrementally. Omitting <c>Metadata</c> preserves the original content. When provided, any old fields not included in the new object are deleted.</description></item>
        /// <item><description>When modifying only <c>Description</c> or <c>Visibility</c>, do not pass <c>Metadata</c> or an empty object <c>{}</c>. An empty object replaces the entire original Metadata with an empty value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content source:<list type="bullet">
        /// <item><description>When replacing the body or bundle, specify exactly one of <c>skillMd</c>, <c>transitId</c>, or <c>bundleUrl</c>.</description></item>
        /// <item><description>For field formats, the Transit upload confirmation process, and <c>bundleUrl</c> restrictions of the three sources, refer to CreateSkill. Pass the selected source in <c>UpdateSkill.Metadata</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public async Task<UpdateSkillResponse> UpdateSkillWithOptionsAsync(UpdateSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedVersion))
            {
                body["ExpectedVersion"] = request.ExpectedVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["Metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visibility))
            {
                body["Visibility"] = request.Visibility;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkill",
                Version = "2026-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Update rules:<list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the Skill and cannot be modified.</description></item>
        /// <item><description>The caller must be the Skill creator or the tenant root account that has permissions to manage the tenant-level Skill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Replacement rules:<list type="bullet">
        /// <item><description><c>Description</c> and <c>Visibility</c> retain their original values when omitted. Passing <c>null</c> is treated the same as omitting the field and cannot be used to clear the original value.</description></item>
        /// <item><description><c>Metadata</c> is replaced as a whole, not merged incrementally. Omitting <c>Metadata</c> preserves the original content. When provided, any old fields not included in the new object are deleted.</description></item>
        /// <item><description>When modifying only <c>Description</c> or <c>Visibility</c>, do not pass <c>Metadata</c> or an empty object <c>{}</c>. An empty object replaces the entire original Metadata with an empty value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content source:<list type="bullet">
        /// <item><description>When replacing the body or bundle, specify exactly one of <c>skillMd</c>, <c>transitId</c>, or <c>bundleUrl</c>.</description></item>
        /// <item><description>For field formats, the Transit upload confirmation process, and <c>bundleUrl</c> restrictions of the three sources, refer to CreateSkill. Pass the selected source in <c>UpdateSkill.Metadata</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public UpdateSkillResponse UpdateSkill(UpdateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Update rules:<list type="bullet">
        /// <item><description><c>Name</c> is used only to locate the Skill and cannot be modified.</description></item>
        /// <item><description>The caller must be the Skill creator or the tenant root account that has permissions to manage the tenant-level Skill.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Replacement rules:<list type="bullet">
        /// <item><description><c>Description</c> and <c>Visibility</c> retain their original values when omitted. Passing <c>null</c> is treated the same as omitting the field and cannot be used to clear the original value.</description></item>
        /// <item><description><c>Metadata</c> is replaced as a whole, not merged incrementally. Omitting <c>Metadata</c> preserves the original content. When provided, any old fields not included in the new object are deleted.</description></item>
        /// <item><description>When modifying only <c>Description</c> or <c>Visibility</c>, do not pass <c>Metadata</c> or an empty object <c>{}</c>. An empty object replaces the entire original Metadata with an empty value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Content source:<list type="bullet">
        /// <item><description>When replacing the body or bundle, specify exactly one of <c>skillMd</c>, <c>transitId</c>, or <c>bundleUrl</c>.</description></item>
        /// <item><description>For field formats, the Transit upload confirmation process, and <c>bundleUrl</c> restrictions of the three sources, refer to CreateSkill. Pass the selected source in <c>UpdateSkill.Metadata</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public async Task<UpdateSkillResponse> UpdateSkillAsync(UpdateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSkillWithOptionsAsync(request, runtime);
        }

    }
}
