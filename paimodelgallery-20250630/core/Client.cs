// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PAIModelGallery20250630.Models;

namespace AlibabaCloud.SDK.PAIModelGallery20250630
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("paimodelgallery", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates a new job plan that supports task types such as distillation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation creates a new node plan. You can specify the workspace ID, node plan type, name, and steps.</description></item>
        /// <item><description>If you use a scenario-specific distillation template, provide the <c>TemplateId</c> parameter and make sure that <c>JobPlanSteps</c> contains distillation configurations that match the template.</description></item>
        /// <item><description>The <c>Tag</c> parameter follows the Alibaba Cloud label system specification and is used to add additional identity information to the node plan.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateJobPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobPlanResponse
        /// </returns>
        public CreateJobPlanResponse CreateJobPlanWithOptions(CreateJobPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanName))
            {
                body["JobPlanName"] = request.JobPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanSteps))
            {
                body["JobPlanSteps"] = request.JobPlanSteps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanType))
            {
                body["JobPlanType"] = request.JobPlanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJobPlan",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new job plan that supports task types such as distillation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation creates a new node plan. You can specify the workspace ID, node plan type, name, and steps.</description></item>
        /// <item><description>If you use a scenario-specific distillation template, provide the <c>TemplateId</c> parameter and make sure that <c>JobPlanSteps</c> contains distillation configurations that match the template.</description></item>
        /// <item><description>The <c>Tag</c> parameter follows the Alibaba Cloud label system specification and is used to add additional identity information to the node plan.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateJobPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobPlanResponse
        /// </returns>
        public async Task<CreateJobPlanResponse> CreateJobPlanWithOptionsAsync(CreateJobPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanName))
            {
                body["JobPlanName"] = request.JobPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanSteps))
            {
                body["JobPlanSteps"] = request.JobPlanSteps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanType))
            {
                body["JobPlanType"] = request.JobPlanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJobPlan",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new job plan that supports task types such as distillation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation creates a new node plan. You can specify the workspace ID, node plan type, name, and steps.</description></item>
        /// <item><description>If you use a scenario-specific distillation template, provide the <c>TemplateId</c> parameter and make sure that <c>JobPlanSteps</c> contains distillation configurations that match the template.</description></item>
        /// <item><description>The <c>Tag</c> parameter follows the Alibaba Cloud label system specification and is used to add additional identity information to the node plan.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateJobPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobPlanResponse
        /// </returns>
        public CreateJobPlanResponse CreateJobPlan(CreateJobPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateJobPlanWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new job plan that supports task types such as distillation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation creates a new node plan. You can specify the workspace ID, node plan type, name, and steps.</description></item>
        /// <item><description>If you use a scenario-specific distillation template, provide the <c>TemplateId</c> parameter and make sure that <c>JobPlanSteps</c> contains distillation configurations that match the template.</description></item>
        /// <item><description>The <c>Tag</c> parameter follows the Alibaba Cloud label system specification and is used to add additional identity information to the node plan.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateJobPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobPlanResponse
        /// </returns>
        public async Task<CreateJobPlanResponse> CreateJobPlanAsync(CreateJobPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateJobPlanWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified task plan by task plan ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteJobPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobPlanResponse
        /// </returns>
        public DeleteJobPlanResponse DeleteJobPlanWithOptions(string JobPlanId, DeleteJobPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobPlan",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobPlanId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified task plan by task plan ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteJobPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobPlanResponse
        /// </returns>
        public async Task<DeleteJobPlanResponse> DeleteJobPlanWithOptionsAsync(string JobPlanId, DeleteJobPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobPlan",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobPlanId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified task plan by task plan ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteJobPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobPlanResponse
        /// </returns>
        public DeleteJobPlanResponse DeleteJobPlan(string JobPlanId, DeleteJobPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteJobPlanWithOptions(JobPlanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified task plan by task plan ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteJobPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobPlanResponse
        /// </returns>
        public async Task<DeleteJobPlanResponse> DeleteJobPlanAsync(string JobPlanId, DeleteJobPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteJobPlanWithOptionsAsync(JobPlanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified distillation template, including preset configurations and default YAML.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation queries the full details of a specific distillation template to facilitate rendering the creation form.</description></item>
        /// <item><description>The template ID is a required parameter, obtained from the <c>ListDistillationTemplates</c> operation.</description></item>
        /// <item><description>The <c>DefaultConfig</c> field provides the complete EasyDistill configuration YAML (with comments). All paths in the YAML are relative paths, and callers do not need to perform absolute path conversion or string replacement.</description></item>
        /// <item><description>All translatable fields are automatically parsed into the corresponding language version based on the <c>x-acs-accept-language</c> request header.</description></item>
        /// <item><description>If the <c>TrainingOptions</c> field is missing, the template supports only the first stage of processing. Attempts to use such a template to create a task that includes the second stage will fail.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDistillationTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDistillationTemplateResponse
        /// </returns>
        public GetDistillationTemplateResponse GetDistillationTemplateWithOptions(string TemplateId, GetDistillationTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDistillationTemplate",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/distillationtemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDistillationTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified distillation template, including preset configurations and default YAML.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation queries the full details of a specific distillation template to facilitate rendering the creation form.</description></item>
        /// <item><description>The template ID is a required parameter, obtained from the <c>ListDistillationTemplates</c> operation.</description></item>
        /// <item><description>The <c>DefaultConfig</c> field provides the complete EasyDistill configuration YAML (with comments). All paths in the YAML are relative paths, and callers do not need to perform absolute path conversion or string replacement.</description></item>
        /// <item><description>All translatable fields are automatically parsed into the corresponding language version based on the <c>x-acs-accept-language</c> request header.</description></item>
        /// <item><description>If the <c>TrainingOptions</c> field is missing, the template supports only the first stage of processing. Attempts to use such a template to create a task that includes the second stage will fail.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDistillationTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDistillationTemplateResponse
        /// </returns>
        public async Task<GetDistillationTemplateResponse> GetDistillationTemplateWithOptionsAsync(string TemplateId, GetDistillationTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDistillationTemplate",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/distillationtemplates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDistillationTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified distillation template, including preset configurations and default YAML.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation queries the full details of a specific distillation template to facilitate rendering the creation form.</description></item>
        /// <item><description>The template ID is a required parameter, obtained from the <c>ListDistillationTemplates</c> operation.</description></item>
        /// <item><description>The <c>DefaultConfig</c> field provides the complete EasyDistill configuration YAML (with comments). All paths in the YAML are relative paths, and callers do not need to perform absolute path conversion or string replacement.</description></item>
        /// <item><description>All translatable fields are automatically parsed into the corresponding language version based on the <c>x-acs-accept-language</c> request header.</description></item>
        /// <item><description>If the <c>TrainingOptions</c> field is missing, the template supports only the first stage of processing. Attempts to use such a template to create a task that includes the second stage will fail.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDistillationTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDistillationTemplateResponse
        /// </returns>
        public GetDistillationTemplateResponse GetDistillationTemplate(string TemplateId, GetDistillationTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDistillationTemplateWithOptions(TemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified distillation template, including preset configurations and default YAML.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This API operation queries the full details of a specific distillation template to facilitate rendering the creation form.</description></item>
        /// <item><description>The template ID is a required parameter, obtained from the <c>ListDistillationTemplates</c> operation.</description></item>
        /// <item><description>The <c>DefaultConfig</c> field provides the complete EasyDistill configuration YAML (with comments). All paths in the YAML are relative paths, and callers do not need to perform absolute path conversion or string replacement.</description></item>
        /// <item><description>All translatable fields are automatically parsed into the corresponding language version based on the <c>x-acs-accept-language</c> request header.</description></item>
        /// <item><description>If the <c>TrainingOptions</c> field is missing, the template supports only the first stage of processing. Attempts to use such a template to create a task that includes the second stage will fail.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDistillationTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDistillationTemplateResponse
        /// </returns>
        public async Task<GetDistillationTemplateResponse> GetDistillationTemplateAsync(string TemplateId, GetDistillationTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDistillationTemplateWithOptionsAsync(TemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified job plan by job plan ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>This API operation retrieves the details of a job plan based on the specified job plan ID (<c>JobPlanId</c>), including but not limited to the name, type, and current step status of the job plan. Make sure the <c>JobPlanId</c> provided in the request is valid and belongs to your workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetJobPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobPlanResponse
        /// </returns>
        public GetJobPlanResponse GetJobPlanWithOptions(string JobPlanId, GetJobPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobPlan",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobPlanId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified job plan by job plan ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>This API operation retrieves the details of a job plan based on the specified job plan ID (<c>JobPlanId</c>), including but not limited to the name, type, and current step status of the job plan. Make sure the <c>JobPlanId</c> provided in the request is valid and belongs to your workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetJobPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobPlanResponse
        /// </returns>
        public async Task<GetJobPlanResponse> GetJobPlanWithOptionsAsync(string JobPlanId, GetJobPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobPlan",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobPlanId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified job plan by job plan ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>This API operation retrieves the details of a job plan based on the specified job plan ID (<c>JobPlanId</c>), including but not limited to the name, type, and current step status of the job plan. Make sure the <c>JobPlanId</c> provided in the request is valid and belongs to your workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetJobPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobPlanResponse
        /// </returns>
        public GetJobPlanResponse GetJobPlan(string JobPlanId, GetJobPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobPlanWithOptions(JobPlanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified job plan by job plan ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>This API operation retrieves the details of a job plan based on the specified job plan ID (<c>JobPlanId</c>), including but not limited to the name, type, and current step status of the job plan. Make sure the <c>JobPlanId</c> provided in the request is valid and belongs to your workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetJobPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobPlanResponse
        /// </returns>
        public async Task<GetJobPlanResponse> GetJobPlanAsync(string JobPlanId, GetJobPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobPlanWithOptionsAsync(JobPlanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves summary information of distillation templates for rendering the template card list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports filtered queries by using the TemplateId, Category, and Keyword parameters.</description></item>
        /// <item><description>Pagination is controlled by the PageNumber and PageSize parameters, consistent with other paginated operations of the same service.</description></item>
        /// <item><description>Templates are public resources that do not belong to any workspace. Therefore, you do not need to specify WorkspaceId.</description></item>
        /// <item><description>All translatable fields such as TemplateName and Description are automatically parsed into the corresponding language version based on the x-acs-accept-language request header.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDistillationTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDistillationTemplatesResponse
        /// </returns>
        public ListDistillationTemplatesResponse ListDistillationTemplatesWithOptions(ListDistillationTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDistillationTemplates",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/distillationtemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDistillationTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves summary information of distillation templates for rendering the template card list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports filtered queries by using the TemplateId, Category, and Keyword parameters.</description></item>
        /// <item><description>Pagination is controlled by the PageNumber and PageSize parameters, consistent with other paginated operations of the same service.</description></item>
        /// <item><description>Templates are public resources that do not belong to any workspace. Therefore, you do not need to specify WorkspaceId.</description></item>
        /// <item><description>All translatable fields such as TemplateName and Description are automatically parsed into the corresponding language version based on the x-acs-accept-language request header.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDistillationTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDistillationTemplatesResponse
        /// </returns>
        public async Task<ListDistillationTemplatesResponse> ListDistillationTemplatesWithOptionsAsync(ListDistillationTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDistillationTemplates",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/distillationtemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDistillationTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves summary information of distillation templates for rendering the template card list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports filtered queries by using the TemplateId, Category, and Keyword parameters.</description></item>
        /// <item><description>Pagination is controlled by the PageNumber and PageSize parameters, consistent with other paginated operations of the same service.</description></item>
        /// <item><description>Templates are public resources that do not belong to any workspace. Therefore, you do not need to specify WorkspaceId.</description></item>
        /// <item><description>All translatable fields such as TemplateName and Description are automatically parsed into the corresponding language version based on the x-acs-accept-language request header.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDistillationTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDistillationTemplatesResponse
        /// </returns>
        public ListDistillationTemplatesResponse ListDistillationTemplates(ListDistillationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDistillationTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves summary information of distillation templates for rendering the template card list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports filtered queries by using the TemplateId, Category, and Keyword parameters.</description></item>
        /// <item><description>Pagination is controlled by the PageNumber and PageSize parameters, consistent with other paginated operations of the same service.</description></item>
        /// <item><description>Templates are public resources that do not belong to any workspace. Therefore, you do not need to specify WorkspaceId.</description></item>
        /// <item><description>All translatable fields such as TemplateName and Description are automatically parsed into the corresponding language version based on the x-acs-accept-language request header.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDistillationTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDistillationTemplatesResponse
        /// </returns>
        public async Task<ListDistillationTemplatesResponse> ListDistillationTemplatesAsync(ListDistillationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDistillationTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of job plans in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><c>WorkspaceId</c> is a required parameter that specifies the workspace to which the job plans belong.</description></item>
        /// <item><description>The <c>Tag</c> parameter must be encoded by using <c>EncodeURI</c> before being passed.</description></item>
        /// <item><description>If both <c>TemplateId</c> and <c>HasTemplate</c> are specified, the value of <c>TemplateId</c> takes precedence for filtering.</description></item>
        /// <item><description><c>JobPlanName</c> supports exact match. Enclose the specific name in quotation marks.</description></item>
        /// <item><description>By default, results are sorted in descending order by creation time (<c>GmtCreateTime</c>). Set the <c>Order</c> parameter to <c>ASC</c> to change the sort order.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListJobPlansRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobPlansResponse
        /// </returns>
        public ListJobPlansResponse ListJobPlansWithOptions(ListJobPlansRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobPlansShrinkRequest request = new ListJobPlansShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasTemplate))
            {
                query["HasTemplate"] = request.HasTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanName))
            {
                query["JobPlanName"] = request.JobPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanType))
            {
                query["JobPlanType"] = request.JobPlanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobPlans",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobPlansResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of job plans in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><c>WorkspaceId</c> is a required parameter that specifies the workspace to which the job plans belong.</description></item>
        /// <item><description>The <c>Tag</c> parameter must be encoded by using <c>EncodeURI</c> before being passed.</description></item>
        /// <item><description>If both <c>TemplateId</c> and <c>HasTemplate</c> are specified, the value of <c>TemplateId</c> takes precedence for filtering.</description></item>
        /// <item><description><c>JobPlanName</c> supports exact match. Enclose the specific name in quotation marks.</description></item>
        /// <item><description>By default, results are sorted in descending order by creation time (<c>GmtCreateTime</c>). Set the <c>Order</c> parameter to <c>ASC</c> to change the sort order.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListJobPlansRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobPlansResponse
        /// </returns>
        public async Task<ListJobPlansResponse> ListJobPlansWithOptionsAsync(ListJobPlansRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobPlansShrinkRequest request = new ListJobPlansShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasTemplate))
            {
                query["HasTemplate"] = request.HasTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanName))
            {
                query["JobPlanName"] = request.JobPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanType))
            {
                query["JobPlanType"] = request.JobPlanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobPlans",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of job plans in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><c>WorkspaceId</c> is a required parameter that specifies the workspace to which the job plans belong.</description></item>
        /// <item><description>The <c>Tag</c> parameter must be encoded by using <c>EncodeURI</c> before being passed.</description></item>
        /// <item><description>If both <c>TemplateId</c> and <c>HasTemplate</c> are specified, the value of <c>TemplateId</c> takes precedence for filtering.</description></item>
        /// <item><description><c>JobPlanName</c> supports exact match. Enclose the specific name in quotation marks.</description></item>
        /// <item><description>By default, results are sorted in descending order by creation time (<c>GmtCreateTime</c>). Set the <c>Order</c> parameter to <c>ASC</c> to change the sort order.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListJobPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobPlansResponse
        /// </returns>
        public ListJobPlansResponse ListJobPlans(ListJobPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobPlansWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of job plans in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><c>WorkspaceId</c> is a required parameter that specifies the workspace to which the job plans belong.</description></item>
        /// <item><description>The <c>Tag</c> parameter must be encoded by using <c>EncodeURI</c> before being passed.</description></item>
        /// <item><description>If both <c>TemplateId</c> and <c>HasTemplate</c> are specified, the value of <c>TemplateId</c> takes precedence for filtering.</description></item>
        /// <item><description><c>JobPlanName</c> supports exact match. Enclose the specific name in quotation marks.</description></item>
        /// <item><description>By default, results are sorted in descending order by creation time (<c>GmtCreateTime</c>). Set the <c>Order</c> parameter to <c>ASC</c> to change the sort order.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListJobPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobPlansResponse
        /// </returns>
        public async Task<ListJobPlansResponse> ListJobPlansAsync(ListJobPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobPlansWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of models from ModelGallery (deprecated, use the 2026-06-03 version instead).</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListModelGalleryModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelGalleryModelsResponse
        /// </returns>
        public ListModelGalleryModelsResponse ListModelGalleryModelsWithOptions(ListModelGalleryModelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelGalleryModelsShrinkRequest request = new ListModelGalleryModelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collections))
            {
                query["Collections"] = request.Collections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Compressible))
            {
                query["Compressible"] = request.Compressible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionsShrink))
            {
                query["Conditions"] = request.ConditionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeepThink))
            {
                query["DeepThink"] = request.DeepThink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Demonstrable))
            {
                query["Demonstrable"] = request.Demonstrable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deployable))
            {
                query["Deployable"] = request.Deployable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distillable))
            {
                query["Distillable"] = request.Distillable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluable))
            {
                query["Evaluable"] = request.Evaluable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionCall))
            {
                query["FunctionCall"] = request.FunctionCall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelSeries))
            {
                query["ModelSeries"] = request.ModelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedCompressionResource))
            {
                query["SupportedCompressionResource"] = request.SupportedCompressionResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedDistillationResource))
            {
                query["SupportedDistillationResource"] = request.SupportedDistillationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedEvaluationResource))
            {
                query["SupportedEvaluationResource"] = request.SupportedEvaluationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedInferenceResource))
            {
                query["SupportedInferenceResource"] = request.SupportedInferenceResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedTrainingResource))
            {
                query["SupportedTrainingResource"] = request.SupportedTrainingResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trainable))
            {
                query["Trainable"] = request.Trainable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelGalleryModels",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelgallery/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelGalleryModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of models from ModelGallery (deprecated, use the 2026-06-03 version instead).</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListModelGalleryModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelGalleryModelsResponse
        /// </returns>
        public async Task<ListModelGalleryModelsResponse> ListModelGalleryModelsWithOptionsAsync(ListModelGalleryModelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelGalleryModelsShrinkRequest request = new ListModelGalleryModelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collections))
            {
                query["Collections"] = request.Collections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Compressible))
            {
                query["Compressible"] = request.Compressible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionsShrink))
            {
                query["Conditions"] = request.ConditionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeepThink))
            {
                query["DeepThink"] = request.DeepThink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Demonstrable))
            {
                query["Demonstrable"] = request.Demonstrable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deployable))
            {
                query["Deployable"] = request.Deployable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distillable))
            {
                query["Distillable"] = request.Distillable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluable))
            {
                query["Evaluable"] = request.Evaluable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionCall))
            {
                query["FunctionCall"] = request.FunctionCall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelSeries))
            {
                query["ModelSeries"] = request.ModelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedCompressionResource))
            {
                query["SupportedCompressionResource"] = request.SupportedCompressionResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedDistillationResource))
            {
                query["SupportedDistillationResource"] = request.SupportedDistillationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedEvaluationResource))
            {
                query["SupportedEvaluationResource"] = request.SupportedEvaluationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedInferenceResource))
            {
                query["SupportedInferenceResource"] = request.SupportedInferenceResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedTrainingResource))
            {
                query["SupportedTrainingResource"] = request.SupportedTrainingResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trainable))
            {
                query["Trainable"] = request.Trainable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelGalleryModels",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelgallery/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelGalleryModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of models from ModelGallery (deprecated, use the 2026-06-03 version instead).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelGalleryModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelGalleryModelsResponse
        /// </returns>
        public ListModelGalleryModelsResponse ListModelGalleryModels(ListModelGalleryModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelGalleryModelsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of models from ModelGallery (deprecated, use the 2026-06-03 version instead).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelGalleryModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelGalleryModelsResponse
        /// </returns>
        public async Task<ListModelGalleryModelsResponse> ListModelGalleryModelsAsync(ListModelGalleryModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelGalleryModelsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the current step and tag information of a specified task plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>You can use this API operation to update the current execution step (<c>JobPlanCurrentStep</c>) and related tags (<c>Tag</c>) of a specific task plan identified by <c>JobPlanId</c>. If the request contains tag information, tags are updated or added based on the provided key-value pairs.</para>
        /// <list type="bullet">
        /// <item><description><b>JobPlanId</b> is a path parameter. You must provide a valid task plan ID.</description></item>
        /// <item><description><b>JobPlanCurrentStep</b> is an optional parameter that specifies the new current step of the task.</description></item>
        /// <item><description><b>Tag</b> is an optional parameter that specifies a list of key-value pairs used to label the task plan. Each tag consists of a <c>Key</c> and a <c>Value</c>.
        /// Note: Ensure that the <c>JobPlanId</c> you provide exists and that you have the permissions to modify it.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateJobPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobPlanResponse
        /// </returns>
        public UpdateJobPlanResponse UpdateJobPlanWithOptions(string JobPlanId, UpdateJobPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanCurrentStep))
            {
                body["JobPlanCurrentStep"] = request.JobPlanCurrentStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJobPlan",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobPlanId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the current step and tag information of a specified task plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>You can use this API operation to update the current execution step (<c>JobPlanCurrentStep</c>) and related tags (<c>Tag</c>) of a specific task plan identified by <c>JobPlanId</c>. If the request contains tag information, tags are updated or added based on the provided key-value pairs.</para>
        /// <list type="bullet">
        /// <item><description><b>JobPlanId</b> is a path parameter. You must provide a valid task plan ID.</description></item>
        /// <item><description><b>JobPlanCurrentStep</b> is an optional parameter that specifies the new current step of the task.</description></item>
        /// <item><description><b>Tag</b> is an optional parameter that specifies a list of key-value pairs used to label the task plan. Each tag consists of a <c>Key</c> and a <c>Value</c>.
        /// Note: Ensure that the <c>JobPlanId</c> you provide exists and that you have the permissions to modify it.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateJobPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobPlanResponse
        /// </returns>
        public async Task<UpdateJobPlanResponse> UpdateJobPlanWithOptionsAsync(string JobPlanId, UpdateJobPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobPlanCurrentStep))
            {
                body["JobPlanCurrentStep"] = request.JobPlanCurrentStep;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJobPlan",
                Version = "2025-06-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobplans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobPlanId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the current step and tag information of a specified task plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>You can use this API operation to update the current execution step (<c>JobPlanCurrentStep</c>) and related tags (<c>Tag</c>) of a specific task plan identified by <c>JobPlanId</c>. If the request contains tag information, tags are updated or added based on the provided key-value pairs.</para>
        /// <list type="bullet">
        /// <item><description><b>JobPlanId</b> is a path parameter. You must provide a valid task plan ID.</description></item>
        /// <item><description><b>JobPlanCurrentStep</b> is an optional parameter that specifies the new current step of the task.</description></item>
        /// <item><description><b>Tag</b> is an optional parameter that specifies a list of key-value pairs used to label the task plan. Each tag consists of a <c>Key</c> and a <c>Value</c>.
        /// Note: Ensure that the <c>JobPlanId</c> you provide exists and that you have the permissions to modify it.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateJobPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobPlanResponse
        /// </returns>
        public UpdateJobPlanResponse UpdateJobPlan(string JobPlanId, UpdateJobPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateJobPlanWithOptions(JobPlanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the current step and tag information of a specified task plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>You can use this API operation to update the current execution step (<c>JobPlanCurrentStep</c>) and related tags (<c>Tag</c>) of a specific task plan identified by <c>JobPlanId</c>. If the request contains tag information, tags are updated or added based on the provided key-value pairs.</para>
        /// <list type="bullet">
        /// <item><description><b>JobPlanId</b> is a path parameter. You must provide a valid task plan ID.</description></item>
        /// <item><description><b>JobPlanCurrentStep</b> is an optional parameter that specifies the new current step of the task.</description></item>
        /// <item><description><b>Tag</b> is an optional parameter that specifies a list of key-value pairs used to label the task plan. Each tag consists of a <c>Key</c> and a <c>Value</c>.
        /// Note: Ensure that the <c>JobPlanId</c> you provide exists and that you have the permissions to modify it.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateJobPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobPlanResponse
        /// </returns>
        public async Task<UpdateJobPlanResponse> UpdateJobPlanAsync(string JobPlanId, UpdateJobPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateJobPlanWithOptionsAsync(JobPlanId, request, headers, runtime);
        }

    }
}
