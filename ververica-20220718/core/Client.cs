// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ververica20220718.Models;

namespace AlibabaCloud.SDK.Ververica20220718
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ververica", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>执行定时计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ApplyScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyScheduledPlanResponse
        /// </returns>
        public ApplyScheduledPlanResponse ApplyScheduledPlanWithOptions(string namespace_, string scheduledPlanId, ApplyScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scheduledPlanId) + "%3Aapply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyScheduledPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行定时计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ApplyScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyScheduledPlanResponse
        /// </returns>
        public async Task<ApplyScheduledPlanResponse> ApplyScheduledPlanWithOptionsAsync(string namespace_, string scheduledPlanId, ApplyScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scheduledPlanId) + "%3Aapply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyScheduledPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行定时计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// ApplyScheduledPlanResponse
        /// </returns>
        public ApplyScheduledPlanResponse ApplyScheduledPlan(string namespace_, string scheduledPlanId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyScheduledPlanHeaders headers = new ApplyScheduledPlanHeaders();
            return ApplyScheduledPlanWithOptions(namespace_, scheduledPlanId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行定时计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// ApplyScheduledPlanResponse
        /// </returns>
        public async Task<ApplyScheduledPlanResponse> ApplyScheduledPlanAsync(string namespace_, string scheduledPlanId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyScheduledPlanHeaders headers = new ApplyScheduledPlanHeaders();
            return await ApplyScheduledPlanWithOptionsAsync(namespace_, scheduledPlanId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelSqlPreviewRequest
        /// </param>
        /// <param name="headers">
        /// CancelSqlPreviewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelSqlPreviewResponse
        /// </returns>
        public CancelSqlPreviewResponse CancelSqlPreviewWithOptions(string namespace_, CancelSqlPreviewRequest request, CancelSqlPreviewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["queryId"] = request.QueryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterName))
            {
                query["sessionClusterName"] = request.SessionClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelSqlPreview",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-preview/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelSqlPreviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelSqlPreviewRequest
        /// </param>
        /// <param name="headers">
        /// CancelSqlPreviewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelSqlPreviewResponse
        /// </returns>
        public async Task<CancelSqlPreviewResponse> CancelSqlPreviewWithOptionsAsync(string namespace_, CancelSqlPreviewRequest request, CancelSqlPreviewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["queryId"] = request.QueryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterName))
            {
                query["sessionClusterName"] = request.SessionClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelSqlPreview",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-preview/cancel",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelSqlPreviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelSqlPreviewRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelSqlPreviewResponse
        /// </returns>
        public CancelSqlPreviewResponse CancelSqlPreview(string namespace_, CancelSqlPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelSqlPreviewHeaders headers = new CancelSqlPreviewHeaders();
            return CancelSqlPreviewWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelSqlPreviewRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelSqlPreviewResponse
        /// </returns>
        public async Task<CancelSqlPreviewResponse> CancelSqlPreviewAsync(string namespace_, CancelSqlPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelSqlPreviewHeaders headers = new CancelSqlPreviewHeaders();
            return await CancelSqlPreviewWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeploymentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentResponse
        /// </returns>
        public CreateDeploymentResponse CreateDeploymentWithOptions(string namespace_, CreateDeploymentRequest request, CreateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeploymentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentResponse
        /// </returns>
        public async Task<CreateDeploymentResponse> CreateDeploymentWithOptionsAsync(string namespace_, CreateDeploymentRequest request, CreateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentResponse
        /// </returns>
        public CreateDeploymentResponse CreateDeployment(string namespace_, CreateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentHeaders headers = new CreateDeploymentHeaders();
            return CreateDeploymentWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentResponse
        /// </returns>
        public async Task<CreateDeploymentResponse> CreateDeploymentAsync(string namespace_, CreateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentHeaders headers = new CreateDeploymentHeaders();
            return await CreateDeploymentWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentDraftRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeploymentDraftHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentDraftResponse
        /// </returns>
        public CreateDeploymentDraftResponse CreateDeploymentDraftWithOptions(string namespace_, CreateDeploymentDraftRequest request, CreateDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentDraftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentDraftRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeploymentDraftHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentDraftResponse
        /// </returns>
        public async Task<CreateDeploymentDraftResponse> CreateDeploymentDraftWithOptionsAsync(string namespace_, CreateDeploymentDraftRequest request, CreateDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentDraftResponse
        /// </returns>
        public CreateDeploymentDraftResponse CreateDeploymentDraft(string namespace_, CreateDeploymentDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentDraftHeaders headers = new CreateDeploymentDraftHeaders();
            return CreateDeploymentDraftWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentDraftResponse
        /// </returns>
        public async Task<CreateDeploymentDraftResponse> CreateDeploymentDraftAsync(string namespace_, CreateDeploymentDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentDraftHeaders headers = new CreateDeploymentDraftHeaders();
            return await CreateDeploymentDraftWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentTargetRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeploymentTargetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentTargetResponse
        /// </returns>
        public CreateDeploymentTargetResponse CreateDeploymentTargetWithOptions(string namespace_, CreateDeploymentTargetRequest request, CreateDeploymentTargetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetName))
            {
                query["deploymentTargetName"] = request.DeploymentTargetName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentTarget",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentTargetRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeploymentTargetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentTargetResponse
        /// </returns>
        public async Task<CreateDeploymentTargetResponse> CreateDeploymentTargetWithOptionsAsync(string namespace_, CreateDeploymentTargetRequest request, CreateDeploymentTargetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetName))
            {
                query["deploymentTargetName"] = request.DeploymentTargetName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentTarget",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentTargetResponse
        /// </returns>
        public CreateDeploymentTargetResponse CreateDeploymentTarget(string namespace_, CreateDeploymentTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentTargetHeaders headers = new CreateDeploymentTargetHeaders();
            return CreateDeploymentTargetWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentTargetResponse
        /// </returns>
        public async Task<CreateDeploymentTargetResponse> CreateDeploymentTargetAsync(string namespace_, CreateDeploymentTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentTargetHeaders headers = new CreateDeploymentTargetHeaders();
            return await CreateDeploymentTargetWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部署目标V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentTargetV2Request
        /// </param>
        /// <param name="headers">
        /// CreateDeploymentTargetV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentTargetV2Response
        /// </returns>
        public CreateDeploymentTargetV2Response CreateDeploymentTargetV2WithOptions(string namespace_, CreateDeploymentTargetV2Request request, CreateDeploymentTargetV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetName))
            {
                query["deploymentTargetName"] = request.DeploymentTargetName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentTargetV2",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets/support-elastic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentTargetV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部署目标V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentTargetV2Request
        /// </param>
        /// <param name="headers">
        /// CreateDeploymentTargetV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentTargetV2Response
        /// </returns>
        public async Task<CreateDeploymentTargetV2Response> CreateDeploymentTargetV2WithOptionsAsync(string namespace_, CreateDeploymentTargetV2Request request, CreateDeploymentTargetV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetName))
            {
                query["deploymentTargetName"] = request.DeploymentTargetName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeploymentTargetV2",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets/support-elastic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeploymentTargetV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部署目标V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentTargetV2Request
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentTargetV2Response
        /// </returns>
        public CreateDeploymentTargetV2Response CreateDeploymentTargetV2(string namespace_, CreateDeploymentTargetV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentTargetV2Headers headers = new CreateDeploymentTargetV2Headers();
            return CreateDeploymentTargetV2WithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部署目标V2</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeploymentTargetV2Request
        /// </param>
        /// 
        /// <returns>
        /// CreateDeploymentTargetV2Response
        /// </returns>
        public async Task<CreateDeploymentTargetV2Response> CreateDeploymentTargetV2Async(string namespace_, CreateDeploymentTargetV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeploymentTargetV2Headers headers = new CreateDeploymentTargetV2Headers();
            return await CreateDeploymentTargetV2WithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFolderRequest
        /// </param>
        /// <param name="headers">
        /// CreateFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFolderResponse
        /// </returns>
        public CreateFolderResponse CreateFolderWithOptions(string namespace_, CreateFolderRequest request, CreateFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFolderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFolderRequest
        /// </param>
        /// <param name="headers">
        /// CreateFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFolderResponse
        /// </returns>
        public async Task<CreateFolderResponse> CreateFolderWithOptionsAsync(string namespace_, CreateFolderRequest request, CreateFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFolderResponse
        /// </returns>
        public CreateFolderResponse CreateFolder(string namespace_, CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFolderHeaders headers = new CreateFolderHeaders();
            return CreateFolderWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFolderResponse
        /// </returns>
        public async Task<CreateFolderResponse> CreateFolderAsync(string namespace_, CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFolderHeaders headers = new CreateFolderHeaders();
            return await CreateFolderWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a namespace as a member and grants permissions to the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemberRequest
        /// </param>
        /// <param name="headers">
        /// CreateMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemberResponse
        /// </returns>
        public CreateMemberResponse CreateMemberWithOptions(string namespace_, CreateMemberRequest request, CreateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a namespace as a member and grants permissions to the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemberRequest
        /// </param>
        /// <param name="headers">
        /// CreateMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemberResponse
        /// </returns>
        public async Task<CreateMemberResponse> CreateMemberWithOptionsAsync(string namespace_, CreateMemberRequest request, CreateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a namespace as a member and grants permissions to the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemberResponse
        /// </returns>
        public CreateMemberResponse CreateMember(string namespace_, CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMemberHeaders headers = new CreateMemberHeaders();
            return CreateMemberWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a namespace as a member and grants permissions to the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemberResponse
        /// </returns>
        public async Task<CreateMemberResponse> CreateMemberAsync(string namespace_, CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMemberHeaders headers = new CreateMemberHeaders();
            return await CreateMemberWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a savepoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavepointRequest
        /// </param>
        /// <param name="headers">
        /// CreateSavepointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSavepointResponse
        /// </returns>
        public CreateSavepointResponse CreateSavepointWithOptions(string namespace_, CreateSavepointRequest request, CreateSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                body["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeFormat))
            {
                body["nativeFormat"] = request.NativeFormat;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSavepointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a savepoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavepointRequest
        /// </param>
        /// <param name="headers">
        /// CreateSavepointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSavepointResponse
        /// </returns>
        public async Task<CreateSavepointResponse> CreateSavepointWithOptionsAsync(string namespace_, CreateSavepointRequest request, CreateSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                body["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NativeFormat))
            {
                body["nativeFormat"] = request.NativeFormat;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a savepoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavepointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSavepointResponse
        /// </returns>
        public CreateSavepointResponse CreateSavepoint(string namespace_, CreateSavepointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSavepointHeaders headers = new CreateSavepointHeaders();
            return CreateSavepointWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a savepoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavepointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSavepointResponse
        /// </returns>
        public async Task<CreateSavepointResponse> CreateSavepointAsync(string namespace_, CreateSavepointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSavepointHeaders headers = new CreateSavepointHeaders();
            return await CreateSavepointWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPlanRequest
        /// </param>
        /// <param name="headers">
        /// CreateScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPlanResponse
        /// </returns>
        public CreateScheduledPlanResponse CreateScheduledPlanWithOptions(string namespace_, CreateScheduledPlanRequest request, CreateScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPlanRequest
        /// </param>
        /// <param name="headers">
        /// CreateScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPlanResponse
        /// </returns>
        public async Task<CreateScheduledPlanResponse> CreateScheduledPlanWithOptionsAsync(string namespace_, CreateScheduledPlanRequest request, CreateScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPlanResponse
        /// </returns>
        public CreateScheduledPlanResponse CreateScheduledPlan(string namespace_, CreateScheduledPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduledPlanHeaders headers = new CreateScheduledPlanHeaders();
            return CreateScheduledPlanWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScheduledPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledPlanResponse
        /// </returns>
        public async Task<CreateScheduledPlanResponse> CreateScheduledPlanAsync(string namespace_, CreateScheduledPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateScheduledPlanHeaders headers = new CreateScheduledPlanHeaders();
            return await CreateScheduledPlanWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建session集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// CreateSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionClusterResponse
        /// </returns>
        public CreateSessionClusterResponse CreateSessionClusterWithOptions(string namespace_, CreateSessionClusterRequest request, CreateSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建session集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// CreateSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionClusterResponse
        /// </returns>
        public async Task<CreateSessionClusterResponse> CreateSessionClusterWithOptionsAsync(string namespace_, CreateSessionClusterRequest request, CreateSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建session集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionClusterResponse
        /// </returns>
        public CreateSessionClusterResponse CreateSessionCluster(string namespace_, CreateSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSessionClusterHeaders headers = new CreateSessionClusterHeaders();
            return CreateSessionClusterWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建session集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionClusterResponse
        /// </returns>
        public async Task<CreateSessionClusterResponse> CreateSessionClusterAsync(string namespace_, CreateSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSessionClusterHeaders headers = new CreateSessionClusterHeaders();
            return await CreateSessionClusterWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses all user-defined function (UDF) methods in your JAR or Python file and creates an artifact configuration for a UDF.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUdfArtifactRequest
        /// </param>
        /// <param name="headers">
        /// CreateUdfArtifactHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUdfArtifactResponse
        /// </returns>
        public CreateUdfArtifactResponse CreateUdfArtifactWithOptions(string namespace_, CreateUdfArtifactRequest request, CreateUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUdfArtifactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses all user-defined function (UDF) methods in your JAR or Python file and creates an artifact configuration for a UDF.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUdfArtifactRequest
        /// </param>
        /// <param name="headers">
        /// CreateUdfArtifactHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUdfArtifactResponse
        /// </returns>
        public async Task<CreateUdfArtifactResponse> CreateUdfArtifactWithOptionsAsync(string namespace_, CreateUdfArtifactRequest request, CreateUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUdfArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses all user-defined function (UDF) methods in your JAR or Python file and creates an artifact configuration for a UDF.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUdfArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUdfArtifactResponse
        /// </returns>
        public CreateUdfArtifactResponse CreateUdfArtifact(string namespace_, CreateUdfArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUdfArtifactHeaders headers = new CreateUdfArtifactHeaders();
            return CreateUdfArtifactWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses all user-defined function (UDF) methods in your JAR or Python file and creates an artifact configuration for a UDF.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUdfArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUdfArtifactResponse
        /// </returns>
        public async Task<CreateUdfArtifactResponse> CreateUdfArtifactAsync(string namespace_, CreateUdfArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUdfArtifactHeaders headers = new CreateUdfArtifactHeaders();
            return await CreateUdfArtifactWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a variable.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVariableRequest
        /// </param>
        /// <param name="headers">
        /// CreateVariableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVariableResponse
        /// </returns>
        public CreateVariableResponse CreateVariableWithOptions(string namespace_, CreateVariableRequest request, CreateVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a variable.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVariableRequest
        /// </param>
        /// <param name="headers">
        /// CreateVariableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVariableResponse
        /// </returns>
        public async Task<CreateVariableResponse> CreateVariableWithOptionsAsync(string namespace_, CreateVariableRequest request, CreateVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a variable.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVariableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVariableResponse
        /// </returns>
        public CreateVariableResponse CreateVariable(string namespace_, CreateVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVariableHeaders headers = new CreateVariableHeaders();
            return CreateVariableWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a variable.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVariableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVariableResponse
        /// </returns>
        public async Task<CreateVariableResponse> CreateVariableAsync(string namespace_, CreateVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateVariableHeaders headers = new CreateVariableHeaders();
            return await CreateVariableWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a registered custom connector from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteCustomConnectorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomConnectorResponse
        /// </returns>
        public DeleteCustomConnectorResponse DeleteCustomConnectorWithOptions(string namespace_, string connectorName, DeleteCustomConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomConnector",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectorName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomConnectorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a registered custom connector from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteCustomConnectorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomConnectorResponse
        /// </returns>
        public async Task<DeleteCustomConnectorResponse> DeleteCustomConnectorWithOptionsAsync(string namespace_, string connectorName, DeleteCustomConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomConnector",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectorName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a registered custom connector from a workspace.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCustomConnectorResponse
        /// </returns>
        public DeleteCustomConnectorResponse DeleteCustomConnector(string namespace_, string connectorName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomConnectorHeaders headers = new DeleteCustomConnectorHeaders();
            return DeleteCustomConnectorWithOptions(namespace_, connectorName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a registered custom connector from a workspace.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCustomConnectorResponse
        /// </returns>
        public async Task<DeleteCustomConnectorResponse> DeleteCustomConnectorAsync(string namespace_, string connectorName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteCustomConnectorHeaders headers = new DeleteCustomConnectorHeaders();
            return await DeleteCustomConnectorWithOptionsAsync(namespace_, connectorName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a deployment based on the deployment ID.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteDeploymentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeploymentResponse
        /// </returns>
        public DeleteDeploymentResponse DeleteDeploymentWithOptions(string namespace_, string deploymentId, DeleteDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a deployment based on the deployment ID.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteDeploymentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeploymentResponse
        /// </returns>
        public async Task<DeleteDeploymentResponse> DeleteDeploymentWithOptionsAsync(string namespace_, string deploymentId, DeleteDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a deployment based on the deployment ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDeploymentResponse
        /// </returns>
        public DeleteDeploymentResponse DeleteDeployment(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentHeaders headers = new DeleteDeploymentHeaders();
            return DeleteDeploymentWithOptions(namespace_, deploymentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a deployment based on the deployment ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDeploymentResponse
        /// </returns>
        public async Task<DeleteDeploymentResponse> DeleteDeploymentAsync(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentHeaders headers = new DeleteDeploymentHeaders();
            return await DeleteDeploymentWithOptionsAsync(namespace_, deploymentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>delete a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteDeploymentDraftHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeploymentDraftResponse
        /// </returns>
        public DeleteDeploymentDraftResponse DeleteDeploymentDraftWithOptions(string namespace_, string deploymentDraftId, DeleteDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentDraftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>delete a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteDeploymentDraftHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeploymentDraftResponse
        /// </returns>
        public async Task<DeleteDeploymentDraftResponse> DeleteDeploymentDraftWithOptionsAsync(string namespace_, string deploymentDraftId, DeleteDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>delete a deploymentDraft</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDeploymentDraftResponse
        /// </returns>
        public DeleteDeploymentDraftResponse DeleteDeploymentDraft(string namespace_, string deploymentDraftId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentDraftHeaders headers = new DeleteDeploymentDraftHeaders();
            return DeleteDeploymentDraftWithOptions(namespace_, deploymentDraftId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>delete a deploymentDraft</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDeploymentDraftResponse
        /// </returns>
        public async Task<DeleteDeploymentDraftResponse> DeleteDeploymentDraftAsync(string namespace_, string deploymentDraftId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentDraftHeaders headers = new DeleteDeploymentDraftHeaders();
            return await DeleteDeploymentDraftWithOptionsAsync(namespace_, deploymentDraftId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteDeploymentTargetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeploymentTargetResponse
        /// </returns>
        public DeleteDeploymentTargetResponse DeleteDeploymentTargetWithOptions(string namespace_, string deploymentTargetName, DeleteDeploymentTargetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeploymentTarget",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentTargetName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteDeploymentTargetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDeploymentTargetResponse
        /// </returns>
        public async Task<DeleteDeploymentTargetResponse> DeleteDeploymentTargetWithOptionsAsync(string namespace_, string deploymentTargetName, DeleteDeploymentTargetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDeploymentTarget",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentTargetName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDeploymentTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除deploymentTarget</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDeploymentTargetResponse
        /// </returns>
        public DeleteDeploymentTargetResponse DeleteDeploymentTarget(string namespace_, string deploymentTargetName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentTargetHeaders headers = new DeleteDeploymentTargetHeaders();
            return DeleteDeploymentTargetWithOptions(namespace_, deploymentTargetName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除deploymentTarget</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDeploymentTargetResponse
        /// </returns>
        public async Task<DeleteDeploymentTargetResponse> DeleteDeploymentTargetAsync(string namespace_, string deploymentTargetName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDeploymentTargetHeaders headers = new DeleteDeploymentTargetHeaders();
            return await DeleteDeploymentTargetWithOptionsAsync(namespace_, deploymentTargetName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>delete a folder</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFolderResponse
        /// </returns>
        public DeleteFolderResponse DeleteFolderWithOptions(string namespace_, string folderId, DeleteFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFolderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>delete a folder</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFolderResponse
        /// </returns>
        public async Task<DeleteFolderResponse> DeleteFolderWithOptionsAsync(string namespace_, string folderId, DeleteFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>delete a folder</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteFolderResponse
        /// </returns>
        public DeleteFolderResponse DeleteFolder(string namespace_, string folderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFolderHeaders headers = new DeleteFolderHeaders();
            return DeleteFolderWithOptions(namespace_, folderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>delete a folder</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteFolderResponse
        /// </returns>
        public async Task<DeleteFolderResponse> DeleteFolderAsync(string namespace_, string folderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFolderHeaders headers = new DeleteFolderHeaders();
            return await DeleteFolderWithOptionsAsync(namespace_, folderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the information about a job that is not in the running state in a deployment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobResponse
        /// </returns>
        public DeleteJobResponse DeleteJobWithOptions(string namespace_, string jobId, DeleteJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the information about a job that is not in the running state in a deployment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobResponse
        /// </returns>
        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(string namespace_, string jobId, DeleteJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the information about a job that is not in the running state in a deployment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteJobResponse
        /// </returns>
        public DeleteJobResponse DeleteJob(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteJobHeaders headers = new DeleteJobHeaders();
            return DeleteJobWithOptions(namespace_, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the information about a job that is not in the running state in a deployment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteJobResponse
        /// </returns>
        public async Task<DeleteJobResponse> DeleteJobAsync(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteJobHeaders headers = new DeleteJobHeaders();
            return await DeleteJobWithOptionsAsync(namespace_, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes the permissions from a member.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemberResponse
        /// </returns>
        public DeleteMemberResponse DeleteMemberWithOptions(string namespace_, string member, DeleteMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes the permissions from a member.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMemberResponse
        /// </returns>
        public async Task<DeleteMemberResponse> DeleteMemberWithOptionsAsync(string namespace_, string member, DeleteMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes the permissions from a member.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMemberResponse
        /// </returns>
        public DeleteMemberResponse DeleteMember(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMemberHeaders headers = new DeleteMemberHeaders();
            return DeleteMemberWithOptions(namespace_, member, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes the permissions from a member.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMemberResponse
        /// </returns>
        public async Task<DeleteMemberResponse> DeleteMemberAsync(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMemberHeaders headers = new DeleteMemberHeaders();
            return await DeleteMemberWithOptionsAsync(namespace_, member, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a savepoint.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSavepointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSavepointResponse
        /// </returns>
        public DeleteSavepointResponse DeleteSavepointWithOptions(string namespace_, string savepointId, DeleteSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSavepointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a savepoint.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSavepointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSavepointResponse
        /// </returns>
        public async Task<DeleteSavepointResponse> DeleteSavepointWithOptionsAsync(string namespace_, string savepointId, DeleteSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a savepoint.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSavepointResponse
        /// </returns>
        public DeleteSavepointResponse DeleteSavepoint(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSavepointHeaders headers = new DeleteSavepointHeaders();
            return DeleteSavepointWithOptions(namespace_, savepointId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a savepoint.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSavepointResponse
        /// </returns>
        public async Task<DeleteSavepointResponse> DeleteSavepointAsync(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSavepointHeaders headers = new DeleteSavepointHeaders();
            return await DeleteSavepointWithOptionsAsync(namespace_, savepointId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPlanResponse
        /// </returns>
        public DeleteScheduledPlanResponse DeleteScheduledPlanWithOptions(string namespace_, string scheduledPlanId, DeleteScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scheduledPlanId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledPlanResponse
        /// </returns>
        public async Task<DeleteScheduledPlanResponse> DeleteScheduledPlanWithOptionsAsync(string namespace_, string scheduledPlanId, DeleteScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scheduledPlanId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定时执行计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteScheduledPlanResponse
        /// </returns>
        public DeleteScheduledPlanResponse DeleteScheduledPlan(string namespace_, string scheduledPlanId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteScheduledPlanHeaders headers = new DeleteScheduledPlanHeaders();
            return DeleteScheduledPlanWithOptions(namespace_, scheduledPlanId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除定时执行计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteScheduledPlanResponse
        /// </returns>
        public async Task<DeleteScheduledPlanResponse> DeleteScheduledPlanAsync(string namespace_, string scheduledPlanId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteScheduledPlanHeaders headers = new DeleteScheduledPlanHeaders();
            return await DeleteScheduledPlanWithOptionsAsync(namespace_, scheduledPlanId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionClusterResponse
        /// </returns>
        public DeleteSessionClusterResponse DeleteSessionClusterWithOptions(string namespace_, string sessionClusterName, DeleteSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionClusterResponse
        /// </returns>
        public async Task<DeleteSessionClusterResponse> DeleteSessionClusterWithOptionsAsync(string namespace_, string sessionClusterName, DeleteSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSessionClusterResponse
        /// </returns>
        public DeleteSessionClusterResponse DeleteSessionCluster(string namespace_, string sessionClusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSessionClusterHeaders headers = new DeleteSessionClusterHeaders();
            return DeleteSessionClusterWithOptions(namespace_, sessionClusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSessionClusterResponse
        /// </returns>
        public async Task<DeleteSessionClusterResponse> DeleteSessionClusterAsync(string namespace_, string sessionClusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSessionClusterHeaders headers = new DeleteSessionClusterHeaders();
            return await DeleteSessionClusterWithOptionsAsync(namespace_, sessionClusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除UdfArtifact</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteUdfArtifactHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdfArtifactResponse
        /// </returns>
        public DeleteUdfArtifactResponse DeleteUdfArtifactWithOptions(string namespace_, string udfArtifactName, DeleteUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(udfArtifactName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdfArtifactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除UdfArtifact</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteUdfArtifactHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdfArtifactResponse
        /// </returns>
        public async Task<DeleteUdfArtifactResponse> DeleteUdfArtifactWithOptionsAsync(string namespace_, string udfArtifactName, DeleteUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(udfArtifactName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdfArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除UdfArtifact</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteUdfArtifactResponse
        /// </returns>
        public DeleteUdfArtifactResponse DeleteUdfArtifact(string namespace_, string udfArtifactName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUdfArtifactHeaders headers = new DeleteUdfArtifactHeaders();
            return DeleteUdfArtifactWithOptions(namespace_, udfArtifactName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除UdfArtifact</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteUdfArtifactResponse
        /// </returns>
        public async Task<DeleteUdfArtifactResponse> DeleteUdfArtifactAsync(string namespace_, string udfArtifactName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUdfArtifactHeaders headers = new DeleteUdfArtifactHeaders();
            return await DeleteUdfArtifactWithOptionsAsync(namespace_, udfArtifactName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an existing user-defined function (UDF) from a Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdfFunctionRequest
        /// </param>
        /// <param name="headers">
        /// DeleteUdfFunctionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdfFunctionResponse
        /// </returns>
        public DeleteUdfFunctionResponse DeleteUdfFunctionWithOptions(string namespace_, string functionName, DeleteUdfFunctionRequest request, DeleteUdfFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                query["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdfFunction",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/function/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdfFunctionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an existing user-defined function (UDF) from a Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdfFunctionRequest
        /// </param>
        /// <param name="headers">
        /// DeleteUdfFunctionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdfFunctionResponse
        /// </returns>
        public async Task<DeleteUdfFunctionResponse> DeleteUdfFunctionWithOptionsAsync(string namespace_, string functionName, DeleteUdfFunctionRequest request, DeleteUdfFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                query["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdfFunction",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/function/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdfFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an existing user-defined function (UDF) from a Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdfFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdfFunctionResponse
        /// </returns>
        public DeleteUdfFunctionResponse DeleteUdfFunction(string namespace_, string functionName, DeleteUdfFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUdfFunctionHeaders headers = new DeleteUdfFunctionHeaders();
            return DeleteUdfFunctionWithOptions(namespace_, functionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an existing user-defined function (UDF) from a Realtime Compute for Apache Flink workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdfFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdfFunctionResponse
        /// </returns>
        public async Task<DeleteUdfFunctionResponse> DeleteUdfFunctionAsync(string namespace_, string functionName, DeleteUdfFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUdfFunctionHeaders headers = new DeleteUdfFunctionHeaders();
            return await DeleteUdfFunctionWithOptionsAsync(namespace_, functionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a variable.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteVariableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVariableResponse
        /// </returns>
        public DeleteVariableResponse DeleteVariableWithOptions(string namespace_, string name, DeleteVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVariableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a variable.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteVariableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVariableResponse
        /// </returns>
        public async Task<DeleteVariableResponse> DeleteVariableWithOptionsAsync(string namespace_, string name, DeleteVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVariableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a variable.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteVariableResponse
        /// </returns>
        public DeleteVariableResponse DeleteVariable(string namespace_, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVariableHeaders headers = new DeleteVariableHeaders();
            return DeleteVariableWithOptions(namespace_, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a variable.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteVariableResponse
        /// </returns>
        public async Task<DeleteVariableResponse> DeleteVariableAsync(string namespace_, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteVariableHeaders headers = new DeleteVariableHeaders();
            return await DeleteVariableWithOptionsAsync(namespace_, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>deploy deploymentDraft async</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployDeploymentDraftAsyncRequest
        /// </param>
        /// <param name="headers">
        /// DeployDeploymentDraftAsyncHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployDeploymentDraftAsyncResponse
        /// </returns>
        public DeployDeploymentDraftAsyncResponse DeployDeploymentDraftAsyncWithOptions(string namespace_, DeployDeploymentDraftAsyncRequest request, DeployDeploymentDraftAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployDeploymentDraftAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/async-deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployDeploymentDraftAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>deploy deploymentDraft async</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployDeploymentDraftAsyncRequest
        /// </param>
        /// <param name="headers">
        /// DeployDeploymentDraftAsyncHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployDeploymentDraftAsyncResponse
        /// </returns>
        public async Task<DeployDeploymentDraftAsyncResponse> DeployDeploymentDraftAsyncWithOptionsAsync(string namespace_, DeployDeploymentDraftAsyncRequest request, DeployDeploymentDraftAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployDeploymentDraftAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/async-deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployDeploymentDraftAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>deploy deploymentDraft async</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployDeploymentDraftAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployDeploymentDraftAsyncResponse
        /// </returns>
        public DeployDeploymentDraftAsyncResponse DeployDeploymentDraftAsync(string namespace_, DeployDeploymentDraftAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeployDeploymentDraftAsyncHeaders headers = new DeployDeploymentDraftAsyncHeaders();
            return DeployDeploymentDraftAsyncWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>deploy deploymentDraft async</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployDeploymentDraftAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployDeploymentDraftAsyncResponse
        /// </returns>
        public async Task<DeployDeploymentDraftAsyncResponse> DeployDeploymentDraftAsyncAsync(string namespace_, DeployDeploymentDraftAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeployDeploymentDraftAsyncHeaders headers = new DeployDeploymentDraftAsyncHeaders();
            return await DeployDeploymentDraftAsyncWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行sql语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteSqlStatementHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSqlStatementResponse
        /// </returns>
        public ExecuteSqlStatementResponse ExecuteSqlStatementWithOptions(string namespace_, ExecuteSqlStatementRequest request, ExecuteSqlStatementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSqlStatement",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-statement/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteSqlStatementResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行sql语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteSqlStatementHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSqlStatementResponse
        /// </returns>
        public async Task<ExecuteSqlStatementResponse> ExecuteSqlStatementWithOptionsAsync(string namespace_, ExecuteSqlStatementRequest request, ExecuteSqlStatementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSqlStatement",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-statement/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteSqlStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行sql语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSqlStatementResponse
        /// </returns>
        public ExecuteSqlStatementResponse ExecuteSqlStatement(string namespace_, ExecuteSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteSqlStatementHeaders headers = new ExecuteSqlStatementHeaders();
            return ExecuteSqlStatementWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行sql语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSqlStatementResponse
        /// </returns>
        public async Task<ExecuteSqlStatementResponse> ExecuteSqlStatementAsync(string namespace_, ExecuteSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteSqlStatementHeaders headers = new ExecuteSqlStatementHeaders();
            return await ExecuteSqlStatementWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取调试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchSqlPreviewResultsRequest
        /// </param>
        /// <param name="headers">
        /// FetchSqlPreviewResultsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchSqlPreviewResultsResponse
        /// </returns>
        public FetchSqlPreviewResultsResponse FetchSqlPreviewResultsWithOptions(string namespace_, FetchSqlPreviewResultsRequest request, FetchSqlPreviewResultsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["queryId"] = request.QueryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterName))
            {
                query["sessionClusterName"] = request.SessionClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchSqlPreviewResults",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-preview/fetchResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchSqlPreviewResultsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取调试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchSqlPreviewResultsRequest
        /// </param>
        /// <param name="headers">
        /// FetchSqlPreviewResultsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchSqlPreviewResultsResponse
        /// </returns>
        public async Task<FetchSqlPreviewResultsResponse> FetchSqlPreviewResultsWithOptionsAsync(string namespace_, FetchSqlPreviewResultsRequest request, FetchSqlPreviewResultsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["queryId"] = request.QueryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterName))
            {
                query["sessionClusterName"] = request.SessionClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchSqlPreviewResults",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-preview/fetchResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchSqlPreviewResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取调试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchSqlPreviewResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchSqlPreviewResultsResponse
        /// </returns>
        public FetchSqlPreviewResultsResponse FetchSqlPreviewResults(string namespace_, FetchSqlPreviewResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FetchSqlPreviewResultsHeaders headers = new FetchSqlPreviewResultsHeaders();
            return FetchSqlPreviewResultsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取调试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchSqlPreviewResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchSqlPreviewResultsResponse
        /// </returns>
        public async Task<FetchSqlPreviewResultsResponse> FetchSqlPreviewResultsAsync(string namespace_, FetchSqlPreviewResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FetchSqlPreviewResultsHeaders headers = new FetchSqlPreviewResultsHeaders();
            return await FetchSqlPreviewResultsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a Flink request proxy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FlinkApiProxyRequest
        /// </param>
        /// <param name="headers">
        /// FlinkApiProxyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FlinkApiProxyResponse
        /// </returns>
        public FlinkApiProxyResponse FlinkApiProxyWithOptions(FlinkApiProxyRequest request, FlinkApiProxyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlinkApiPath))
            {
                query["flinkApiPath"] = request.FlinkApiPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlinkApiProxy",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/flink-ui/v2/proxy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlinkApiProxyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a Flink request proxy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FlinkApiProxyRequest
        /// </param>
        /// <param name="headers">
        /// FlinkApiProxyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FlinkApiProxyResponse
        /// </returns>
        public async Task<FlinkApiProxyResponse> FlinkApiProxyWithOptionsAsync(FlinkApiProxyRequest request, FlinkApiProxyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlinkApiPath))
            {
                query["flinkApiPath"] = request.FlinkApiPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FlinkApiProxy",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/flink-ui/v2/proxy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FlinkApiProxyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a Flink request proxy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FlinkApiProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// FlinkApiProxyResponse
        /// </returns>
        public FlinkApiProxyResponse FlinkApiProxy(FlinkApiProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlinkApiProxyHeaders headers = new FlinkApiProxyHeaders();
            return FlinkApiProxyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a Flink request proxy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FlinkApiProxyRequest
        /// </param>
        /// 
        /// <returns>
        /// FlinkApiProxyResponse
        /// </returns>
        public async Task<FlinkApiProxyResponse> FlinkApiProxyAsync(FlinkApiProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FlinkApiProxyHeaders headers = new FlinkApiProxyHeaders();
            return await FlinkApiProxyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a ticket that applies for asynchronous generation of the fine-grained resources. This operation returns the ID of the ticket for you to query the asynchronous generation result.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateResourcePlanWithFlinkConfAsyncRequest
        /// </param>
        /// <param name="headers">
        /// GenerateResourcePlanWithFlinkConfAsyncHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateResourcePlanWithFlinkConfAsyncResponse
        /// </returns>
        public GenerateResourcePlanWithFlinkConfAsyncResponse GenerateResourcePlanWithFlinkConfAsyncWithOptions(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request, GenerateResourcePlanWithFlinkConfAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResourcePlanWithFlinkConfAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/resource-plan%3AasyncGenerate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResourcePlanWithFlinkConfAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a ticket that applies for asynchronous generation of the fine-grained resources. This operation returns the ID of the ticket for you to query the asynchronous generation result.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateResourcePlanWithFlinkConfAsyncRequest
        /// </param>
        /// <param name="headers">
        /// GenerateResourcePlanWithFlinkConfAsyncHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateResourcePlanWithFlinkConfAsyncResponse
        /// </returns>
        public async Task<GenerateResourcePlanWithFlinkConfAsyncResponse> GenerateResourcePlanWithFlinkConfAsyncWithOptionsAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request, GenerateResourcePlanWithFlinkConfAsyncHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResourcePlanWithFlinkConfAsync",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/resource-plan%3AasyncGenerate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResourcePlanWithFlinkConfAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a ticket that applies for asynchronous generation of the fine-grained resources. This operation returns the ID of the ticket for you to query the asynchronous generation result.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateResourcePlanWithFlinkConfAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateResourcePlanWithFlinkConfAsyncResponse
        /// </returns>
        public GenerateResourcePlanWithFlinkConfAsyncResponse GenerateResourcePlanWithFlinkConfAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateResourcePlanWithFlinkConfAsyncHeaders headers = new GenerateResourcePlanWithFlinkConfAsyncHeaders();
            return GenerateResourcePlanWithFlinkConfAsyncWithOptions(namespace_, deploymentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a ticket that applies for asynchronous generation of the fine-grained resources. This operation returns the ID of the ticket for you to query the asynchronous generation result.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateResourcePlanWithFlinkConfAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateResourcePlanWithFlinkConfAsyncResponse
        /// </returns>
        public async Task<GenerateResourcePlanWithFlinkConfAsyncResponse> GenerateResourcePlanWithFlinkConfAsyncAsync(string namespace_, string deploymentId, GenerateResourcePlanWithFlinkConfAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GenerateResourcePlanWithFlinkConfAsyncHeaders headers = new GenerateResourcePlanWithFlinkConfAsyncHeaders();
            return await GenerateResourcePlanWithFlinkConfAsyncWithOptionsAsync(namespace_, deploymentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用中的执行定时计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppliedScheduledPlanRequest
        /// </param>
        /// <param name="headers">
        /// GetAppliedScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppliedScheduledPlanResponse
        /// </returns>
        public GetAppliedScheduledPlanResponse GetAppliedScheduledPlanWithOptions(string namespace_, GetAppliedScheduledPlanRequest request, GetAppliedScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppliedScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans%3AgetExecutedScheduledPlan",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppliedScheduledPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用中的执行定时计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppliedScheduledPlanRequest
        /// </param>
        /// <param name="headers">
        /// GetAppliedScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppliedScheduledPlanResponse
        /// </returns>
        public async Task<GetAppliedScheduledPlanResponse> GetAppliedScheduledPlanWithOptionsAsync(string namespace_, GetAppliedScheduledPlanRequest request, GetAppliedScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppliedScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans%3AgetExecutedScheduledPlan",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppliedScheduledPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用中的执行定时计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppliedScheduledPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppliedScheduledPlanResponse
        /// </returns>
        public GetAppliedScheduledPlanResponse GetAppliedScheduledPlan(string namespace_, GetAppliedScheduledPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppliedScheduledPlanHeaders headers = new GetAppliedScheduledPlanHeaders();
            return GetAppliedScheduledPlanWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用中的执行定时计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppliedScheduledPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppliedScheduledPlanResponse
        /// </returns>
        public async Task<GetAppliedScheduledPlanResponse> GetAppliedScheduledPlanAsync(string namespace_, GetAppliedScheduledPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppliedScheduledPlanHeaders headers = new GetAppliedScheduledPlanHeaders();
            return await GetAppliedScheduledPlanWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取catalog</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogsRequest
        /// </param>
        /// <param name="headers">
        /// GetCatalogsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogsResponse
        /// </returns>
        public GetCatalogsResponse GetCatalogsWithOptions(string namespace_, GetCatalogsRequest request, GetCatalogsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["catalogName"] = request.CatalogName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取catalog</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogsRequest
        /// </param>
        /// <param name="headers">
        /// GetCatalogsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogsResponse
        /// </returns>
        public async Task<GetCatalogsResponse> GetCatalogsWithOptionsAsync(string namespace_, GetCatalogsRequest request, GetCatalogsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["catalogName"] = request.CatalogName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取catalog</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogsResponse
        /// </returns>
        public GetCatalogsResponse GetCatalogs(string namespace_, GetCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCatalogsHeaders headers = new GetCatalogsHeaders();
            return GetCatalogsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取catalog</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogsResponse
        /// </returns>
        public async Task<GetCatalogsResponse> GetCatalogsAsync(string namespace_, GetCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCatalogsHeaders headers = new GetCatalogsHeaders();
            return await GetCatalogsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取database</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatabasesRequest
        /// </param>
        /// <param name="headers">
        /// GetDatabasesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatabasesResponse
        /// </returns>
        public GetDatabasesResponse GetDatabasesWithOptions(string namespace_, string catalogName, GetDatabasesRequest request, GetDatabasesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["databaseName"] = request.DatabaseName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabases",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogName) + "/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取database</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatabasesRequest
        /// </param>
        /// <param name="headers">
        /// GetDatabasesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatabasesResponse
        /// </returns>
        public async Task<GetDatabasesResponse> GetDatabasesWithOptionsAsync(string namespace_, string catalogName, GetDatabasesRequest request, GetDatabasesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["databaseName"] = request.DatabaseName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabases",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogName) + "/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取database</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatabasesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatabasesResponse
        /// </returns>
        public GetDatabasesResponse GetDatabases(string namespace_, string catalogName, GetDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDatabasesHeaders headers = new GetDatabasesHeaders();
            return GetDatabasesWithOptions(namespace_, catalogName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取database</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatabasesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatabasesResponse
        /// </returns>
        public async Task<GetDatabasesResponse> GetDatabasesAsync(string namespace_, string catalogName, GetDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDatabasesHeaders headers = new GetDatabasesHeaders();
            return await GetDatabasesWithOptionsAsync(namespace_, catalogName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get deploy deploymentDraft result</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDeployDeploymentDraftResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeployDeploymentDraftResultResponse
        /// </returns>
        public GetDeployDeploymentDraftResultResponse GetDeployDeploymentDraftResultWithOptions(string namespace_, string ticketId, GetDeployDeploymentDraftResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployDeploymentDraftResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/async-deploy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeployDeploymentDraftResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get deploy deploymentDraft result</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDeployDeploymentDraftResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeployDeploymentDraftResultResponse
        /// </returns>
        public async Task<GetDeployDeploymentDraftResultResponse> GetDeployDeploymentDraftResultWithOptionsAsync(string namespace_, string ticketId, GetDeployDeploymentDraftResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployDeploymentDraftResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/async-deploy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeployDeploymentDraftResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get deploy deploymentDraft result</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDeployDeploymentDraftResultResponse
        /// </returns>
        public GetDeployDeploymentDraftResultResponse GetDeployDeploymentDraftResult(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeployDeploymentDraftResultHeaders headers = new GetDeployDeploymentDraftResultHeaders();
            return GetDeployDeploymentDraftResultWithOptions(namespace_, ticketId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get deploy deploymentDraft result</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDeployDeploymentDraftResultResponse
        /// </returns>
        public async Task<GetDeployDeploymentDraftResultResponse> GetDeployDeploymentDraftResultAsync(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeployDeploymentDraftResultHeaders headers = new GetDeployDeploymentDraftResultHeaders();
            return await GetDeployDeploymentDraftResultWithOptionsAsync(namespace_, ticketId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a deployment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDeploymentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeploymentResponse
        /// </returns>
        public GetDeploymentResponse GetDeploymentWithOptions(string namespace_, string deploymentId, GetDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a deployment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDeploymentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeploymentResponse
        /// </returns>
        public async Task<GetDeploymentResponse> GetDeploymentWithOptionsAsync(string namespace_, string deploymentId, GetDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a deployment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDeploymentResponse
        /// </returns>
        public GetDeploymentResponse GetDeployment(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentHeaders headers = new GetDeploymentHeaders();
            return GetDeploymentWithOptions(namespace_, deploymentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a deployment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDeploymentResponse
        /// </returns>
        public async Task<GetDeploymentResponse> GetDeploymentAsync(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentHeaders headers = new GetDeploymentHeaders();
            return await GetDeploymentWithOptionsAsync(namespace_, deploymentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDeploymentDraftHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeploymentDraftResponse
        /// </returns>
        public GetDeploymentDraftResponse GetDeploymentDraftWithOptions(string namespace_, string deploymentDraftId, GetDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentDraftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDeploymentDraftHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeploymentDraftResponse
        /// </returns>
        public async Task<GetDeploymentDraftResponse> GetDeploymentDraftWithOptionsAsync(string namespace_, string deploymentDraftId, GetDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get a deploymentDraft</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDeploymentDraftResponse
        /// </returns>
        public GetDeploymentDraftResponse GetDeploymentDraft(string namespace_, string deploymentDraftId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentDraftHeaders headers = new GetDeploymentDraftHeaders();
            return GetDeploymentDraftWithOptions(namespace_, deploymentDraftId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get a deploymentDraft</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDeploymentDraftResponse
        /// </returns>
        public async Task<GetDeploymentDraftResponse> GetDeploymentDraftAsync(string namespace_, string deploymentDraftId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentDraftHeaders headers = new GetDeploymentDraftHeaders();
            return await GetDeploymentDraftWithOptionsAsync(namespace_, deploymentDraftId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get deploymentDraft lock</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeploymentDraftLockRequest
        /// </param>
        /// <param name="headers">
        /// GetDeploymentDraftLockHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeploymentDraftLockResponse
        /// </returns>
        public GetDeploymentDraftLockResponse GetDeploymentDraftLockWithOptions(string namespace_, GetDeploymentDraftLockRequest request, GetDeploymentDraftLockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentDraftId))
            {
                query["deploymentDraftId"] = request.DeploymentDraftId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeploymentDraftLock",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/getLock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentDraftLockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get deploymentDraft lock</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeploymentDraftLockRequest
        /// </param>
        /// <param name="headers">
        /// GetDeploymentDraftLockHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeploymentDraftLockResponse
        /// </returns>
        public async Task<GetDeploymentDraftLockResponse> GetDeploymentDraftLockWithOptionsAsync(string namespace_, GetDeploymentDraftLockRequest request, GetDeploymentDraftLockHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentDraftId))
            {
                query["deploymentDraftId"] = request.DeploymentDraftId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeploymentDraftLock",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/getLock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeploymentDraftLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get deploymentDraft lock</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeploymentDraftLockRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeploymentDraftLockResponse
        /// </returns>
        public GetDeploymentDraftLockResponse GetDeploymentDraftLock(string namespace_, GetDeploymentDraftLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentDraftLockHeaders headers = new GetDeploymentDraftLockHeaders();
            return GetDeploymentDraftLockWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get deploymentDraft lock</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeploymentDraftLockRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeploymentDraftLockResponse
        /// </returns>
        public async Task<GetDeploymentDraftLockResponse> GetDeploymentDraftLockAsync(string namespace_, GetDeploymentDraftLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeploymentDraftLockHeaders headers = new GetDeploymentDraftLockHeaders();
            return await GetDeploymentDraftLockWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取运行事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventsRequest
        /// </param>
        /// <param name="headers">
        /// GetEventsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventsResponse
        /// </returns>
        public GetEventsResponse GetEventsWithOptions(string namespace_, GetEventsRequest request, GetEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvents",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取运行事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventsRequest
        /// </param>
        /// <param name="headers">
        /// GetEventsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventsResponse
        /// </returns>
        public async Task<GetEventsResponse> GetEventsWithOptionsAsync(string namespace_, GetEventsRequest request, GetEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvents",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取运行事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventsResponse
        /// </returns>
        public GetEventsResponse GetEvents(string namespace_, GetEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventsHeaders headers = new GetEventsHeaders();
            return GetEventsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取运行事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventsResponse
        /// </returns>
        public async Task<GetEventsResponse> GetEventsAsync(string namespace_, GetEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEventsHeaders headers = new GetEventsHeaders();
            return await GetEventsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFolderRequest
        /// </param>
        /// <param name="headers">
        /// GetFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFolderResponse
        /// </returns>
        public GetFolderResponse GetFolderWithOptions(string namespace_, GetFolderRequest request, GetFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["folderId"] = request.FolderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFolderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFolderRequest
        /// </param>
        /// <param name="headers">
        /// GetFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFolderResponse
        /// </returns>
        public async Task<GetFolderResponse> GetFolderWithOptionsAsync(string namespace_, GetFolderRequest request, GetFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["folderId"] = request.FolderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFolderResponse
        /// </returns>
        public GetFolderResponse GetFolder(string namespace_, GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFolderHeaders headers = new GetFolderHeaders();
            return GetFolderWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>get a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFolderResponse
        /// </returns>
        public async Task<GetFolderResponse> GetFolderAsync(string namespace_, GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFolderHeaders headers = new GetFolderHeaders();
            return await GetFolderWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the asynchronous generation result of fine-grained resources based on the ID of the ticket that applies for an asynchronous generation.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetGenerateResourcePlanResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGenerateResourcePlanResultResponse
        /// </returns>
        public GetGenerateResourcePlanResultResponse GetGenerateResourcePlanResultWithOptions(string namespace_, string ticketId, GetGenerateResourcePlanResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGenerateResourcePlanResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/resource-plan%3AasyncGenerate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGenerateResourcePlanResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the asynchronous generation result of fine-grained resources based on the ID of the ticket that applies for an asynchronous generation.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetGenerateResourcePlanResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGenerateResourcePlanResultResponse
        /// </returns>
        public async Task<GetGenerateResourcePlanResultResponse> GetGenerateResourcePlanResultWithOptionsAsync(string namespace_, string ticketId, GetGenerateResourcePlanResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGenerateResourcePlanResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/tickets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ticketId) + "/resource-plan%3AasyncGenerate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGenerateResourcePlanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the asynchronous generation result of fine-grained resources based on the ID of the ticket that applies for an asynchronous generation.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGenerateResourcePlanResultResponse
        /// </returns>
        public GetGenerateResourcePlanResultResponse GetGenerateResourcePlanResult(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGenerateResourcePlanResultHeaders headers = new GetGenerateResourcePlanResultHeaders();
            return GetGenerateResourcePlanResultWithOptions(namespace_, ticketId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the asynchronous generation result of fine-grained resources based on the ID of the ticket that applies for an asynchronous generation.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGenerateResourcePlanResultResponse
        /// </returns>
        public async Task<GetGenerateResourcePlanResultResponse> GetGenerateResourcePlanResultAsync(string namespace_, string ticketId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGenerateResourcePlanResultHeaders headers = new GetGenerateResourcePlanResultHeaders();
            return await GetGenerateResourcePlanResultWithOptionsAsync(namespace_, ticketId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动态更新结果</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetHotUpdateJobResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotUpdateJobResultResponse
        /// </returns>
        public GetHotUpdateJobResultResponse GetHotUpdateJobResultWithOptions(string namespace_, string jobHotUpdateId, GetHotUpdateJobResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotUpdateJobResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/hot-updates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobHotUpdateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotUpdateJobResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动态更新结果</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetHotUpdateJobResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotUpdateJobResultResponse
        /// </returns>
        public async Task<GetHotUpdateJobResultResponse> GetHotUpdateJobResultWithOptionsAsync(string namespace_, string jobHotUpdateId, GetHotUpdateJobResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotUpdateJobResult",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/hot-updates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobHotUpdateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotUpdateJobResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动态更新结果</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetHotUpdateJobResultResponse
        /// </returns>
        public GetHotUpdateJobResultResponse GetHotUpdateJobResult(string namespace_, string jobHotUpdateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotUpdateJobResultHeaders headers = new GetHotUpdateJobResultHeaders();
            return GetHotUpdateJobResultWithOptions(namespace_, jobHotUpdateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动态更新结果</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetHotUpdateJobResultResponse
        /// </returns>
        public async Task<GetHotUpdateJobResultResponse> GetHotUpdateJobResultAsync(string namespace_, string jobHotUpdateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotUpdateJobResultHeaders headers = new GetHotUpdateJobResultHeaders();
            return await GetHotUpdateJobResultWithOptionsAsync(namespace_, jobHotUpdateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a job.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public GetJobResponse GetJobWithOptions(string namespace_, string jobId, GetJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a job.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public async Task<GetJobResponse> GetJobWithOptionsAsync(string namespace_, string jobId, GetJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a job.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public GetJobResponse GetJob(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobHeaders headers = new GetJobHeaders();
            return GetJobWithOptions(namespace_, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a job.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public async Task<GetJobResponse> GetJobAsync(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobHeaders headers = new GetJobHeaders();
            return await GetJobWithOptionsAsync(namespace_, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业诊断信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetJobDiagnosisHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobDiagnosisResponse
        /// </returns>
        public GetJobDiagnosisResponse GetJobDiagnosisWithOptions(string namespace_, string deploymentId, string jobId, GetJobDiagnosisHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobDiagnosis",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/job-diagnoses/lite",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业诊断信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetJobDiagnosisHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobDiagnosisResponse
        /// </returns>
        public async Task<GetJobDiagnosisResponse> GetJobDiagnosisWithOptionsAsync(string namespace_, string deploymentId, string jobId, GetJobDiagnosisHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobDiagnosis",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/job-diagnoses/lite",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业诊断信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetJobDiagnosisResponse
        /// </returns>
        public GetJobDiagnosisResponse GetJobDiagnosis(string namespace_, string deploymentId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobDiagnosisHeaders headers = new GetJobDiagnosisHeaders();
            return GetJobDiagnosisWithOptions(namespace_, deploymentId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业诊断信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetJobDiagnosisResponse
        /// </returns>
        public async Task<GetJobDiagnosisResponse> GetJobDiagnosisAsync(string namespace_, string deploymentId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetJobDiagnosisHeaders headers = new GetJobDiagnosisHeaders();
            return await GetJobDiagnosisWithOptionsAsync(namespace_, deploymentId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the latest startup logs of a job.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetLatestJobStartLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLatestJobStartLogResponse
        /// </returns>
        public GetLatestJobStartLogResponse GetLatestJobStartLogWithOptions(string namespace_, string deploymentId, GetLatestJobStartLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLatestJobStartLog",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/latest_jobmanager_start_log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestJobStartLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the latest startup logs of a job.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetLatestJobStartLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLatestJobStartLogResponse
        /// </returns>
        public async Task<GetLatestJobStartLogResponse> GetLatestJobStartLogWithOptionsAsync(string namespace_, string deploymentId, GetLatestJobStartLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLatestJobStartLog",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId) + "/latest_jobmanager_start_log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestJobStartLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the latest startup logs of a job.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetLatestJobStartLogResponse
        /// </returns>
        public GetLatestJobStartLogResponse GetLatestJobStartLog(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestJobStartLogHeaders headers = new GetLatestJobStartLogHeaders();
            return GetLatestJobStartLogWithOptions(namespace_, deploymentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the latest startup logs of a job.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetLatestJobStartLogResponse
        /// </returns>
        public async Task<GetLatestJobStartLogResponse> GetLatestJobStartLogAsync(string namespace_, string deploymentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestJobStartLogHeaders headers = new GetLatestJobStartLogHeaders();
            return await GetLatestJobStartLogWithOptionsAsync(namespace_, deploymentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the lineage information of a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLineageInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetLineageInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLineageInfoResponse
        /// </returns>
        public GetLineageInfoResponse GetLineageInfoWithOptions(GetLineageInfoRequest request, GetLineageInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLineageInfo",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/meta/v2/lineage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLineageInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the lineage information of a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLineageInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetLineageInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLineageInfoResponse
        /// </returns>
        public async Task<GetLineageInfoResponse> GetLineageInfoWithOptionsAsync(GetLineageInfoRequest request, GetLineageInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLineageInfo",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/meta/v2/lineage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLineageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the lineage information of a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLineageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLineageInfoResponse
        /// </returns>
        public GetLineageInfoResponse GetLineageInfo(GetLineageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLineageInfoHeaders headers = new GetLineageInfoHeaders();
            return GetLineageInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the lineage information of a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLineageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLineageInfoResponse
        /// </returns>
        public async Task<GetLineageInfoResponse> GetLineageInfoAsync(GetLineageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLineageInfoHeaders headers = new GetLineageInfoHeaders();
            return await GetLineageInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions of a member.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemberResponse
        /// </returns>
        public GetMemberResponse GetMemberWithOptions(string namespace_, string member, GetMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions of a member.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemberResponse
        /// </returns>
        public async Task<GetMemberResponse> GetMemberWithOptionsAsync(string namespace_, string member, GetMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(member),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions of a member.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMemberResponse
        /// </returns>
        public GetMemberResponse GetMember(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMemberHeaders headers = new GetMemberHeaders();
            return GetMemberWithOptions(namespace_, member, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions of a member.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMemberResponse
        /// </returns>
        public async Task<GetMemberResponse> GetMemberAsync(string namespace_, string member)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMemberHeaders headers = new GetMemberHeaders();
            return await GetMemberWithOptionsAsync(namespace_, member, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传文件URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPreSignedUrlForPutObjectRequest
        /// </param>
        /// <param name="headers">
        /// GetPreSignedUrlForPutObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPreSignedUrlForPutObjectResponse
        /// </returns>
        public GetPreSignedUrlForPutObjectResponse GetPreSignedUrlForPutObjectWithOptions(string namespace_, GetPreSignedUrlForPutObjectRequest request, GetPreSignedUrlForPutObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPreSignedUrlForPutObject",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/artifacts/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/getPreSignedUrlForPutObject",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPreSignedUrlForPutObjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传文件URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPreSignedUrlForPutObjectRequest
        /// </param>
        /// <param name="headers">
        /// GetPreSignedUrlForPutObjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPreSignedUrlForPutObjectResponse
        /// </returns>
        public async Task<GetPreSignedUrlForPutObjectResponse> GetPreSignedUrlForPutObjectWithOptionsAsync(string namespace_, GetPreSignedUrlForPutObjectRequest request, GetPreSignedUrlForPutObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPreSignedUrlForPutObject",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/artifacts/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/getPreSignedUrlForPutObject",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPreSignedUrlForPutObjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传文件URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPreSignedUrlForPutObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPreSignedUrlForPutObjectResponse
        /// </returns>
        public GetPreSignedUrlForPutObjectResponse GetPreSignedUrlForPutObject(string namespace_, GetPreSignedUrlForPutObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPreSignedUrlForPutObjectHeaders headers = new GetPreSignedUrlForPutObjectHeaders();
            return GetPreSignedUrlForPutObjectWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传文件URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPreSignedUrlForPutObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPreSignedUrlForPutObjectResponse
        /// </returns>
        public async Task<GetPreSignedUrlForPutObjectResponse> GetPreSignedUrlForPutObjectAsync(string namespace_, GetPreSignedUrlForPutObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPreSignedUrlForPutObjectHeaders headers = new GetPreSignedUrlForPutObjectHeaders();
            return await GetPreSignedUrlForPutObjectWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of a savepoint and checkpoint.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSavepointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavepointResponse
        /// </returns>
        public GetSavepointResponse GetSavepointWithOptions(string namespace_, string savepointId, GetSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavepointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of a savepoint and checkpoint.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSavepointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavepointResponse
        /// </returns>
        public async Task<GetSavepointResponse> GetSavepointWithOptionsAsync(string namespace_, string savepointId, GetSavepointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavepoint",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savepointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavepointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of a savepoint and checkpoint.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSavepointResponse
        /// </returns>
        public GetSavepointResponse GetSavepoint(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSavepointHeaders headers = new GetSavepointHeaders();
            return GetSavepointWithOptions(namespace_, savepointId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details of a savepoint and checkpoint.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSavepointResponse
        /// </returns>
        public async Task<GetSavepointResponse> GetSavepointAsync(string namespace_, string savepointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSavepointHeaders headers = new GetSavepointHeaders();
            return await GetSavepointWithOptionsAsync(namespace_, savepointId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSessionClusterResponse
        /// </returns>
        public GetSessionClusterResponse GetSessionClusterWithOptions(string namespace_, string sessionClusterName, GetSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSessionClusterResponse
        /// </returns>
        public async Task<GetSessionClusterResponse> GetSessionClusterWithOptionsAsync(string namespace_, string sessionClusterName, GetSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSessionClusterResponse
        /// </returns>
        public GetSessionClusterResponse GetSessionCluster(string namespace_, string sessionClusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSessionClusterHeaders headers = new GetSessionClusterHeaders();
            return GetSessionClusterWithOptions(namespace_, sessionClusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSessionClusterResponse
        /// </returns>
        public async Task<GetSessionClusterResponse> GetSessionClusterAsync(string namespace_, string sessionClusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSessionClusterHeaders headers = new GetSessionClusterHeaders();
            return await GetSessionClusterWithOptionsAsync(namespace_, sessionClusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTablesRequest
        /// </param>
        /// <param name="headers">
        /// GetTablesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTablesResponse
        /// </returns>
        public GetTablesResponse GetTablesWithOptions(string namespace_, string catalogName, string databaseName, GetTablesRequest request, GetTablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["tableName"] = request.TableName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogName) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(databaseName) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTablesRequest
        /// </param>
        /// <param name="headers">
        /// GetTablesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTablesResponse
        /// </returns>
        public async Task<GetTablesResponse> GetTablesWithOptionsAsync(string namespace_, string catalogName, string databaseName, GetTablesRequest request, GetTablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["tableName"] = request.TableName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogName) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(databaseName) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTablesResponse
        /// </returns>
        public GetTablesResponse GetTables(string namespace_, string catalogName, string databaseName, GetTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTablesHeaders headers = new GetTablesHeaders();
            return GetTablesWithOptions(namespace_, catalogName, databaseName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTablesResponse
        /// </returns>
        public async Task<GetTablesResponse> GetTablesAsync(string namespace_, string catalogName, string databaseName, GetTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTablesHeaders headers = new GetTablesHeaders();
            return await GetTablesWithOptionsAsync(namespace_, catalogName, databaseName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the JAR or Python file that corresponds to the user-defined function (UDF) that you upload and create.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUdfArtifactsRequest
        /// </param>
        /// <param name="headers">
        /// GetUdfArtifactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUdfArtifactsResponse
        /// </returns>
        public GetUdfArtifactsResponse GetUdfArtifactsWithOptions(string namespace_, GetUdfArtifactsRequest request, GetUdfArtifactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUdfArtifacts",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUdfArtifactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the JAR or Python file that corresponds to the user-defined function (UDF) that you upload and create.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUdfArtifactsRequest
        /// </param>
        /// <param name="headers">
        /// GetUdfArtifactsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUdfArtifactsResponse
        /// </returns>
        public async Task<GetUdfArtifactsResponse> GetUdfArtifactsWithOptionsAsync(string namespace_, GetUdfArtifactsRequest request, GetUdfArtifactsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUdfArtifacts",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUdfArtifactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the JAR or Python file that corresponds to the user-defined function (UDF) that you upload and create.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUdfArtifactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUdfArtifactsResponse
        /// </returns>
        public GetUdfArtifactsResponse GetUdfArtifacts(string namespace_, GetUdfArtifactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUdfArtifactsHeaders headers = new GetUdfArtifactsHeaders();
            return GetUdfArtifactsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of the JAR or Python file that corresponds to the user-defined function (UDF) that you upload and create.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUdfArtifactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUdfArtifactsResponse
        /// </returns>
        public async Task<GetUdfArtifactsResponse> GetUdfArtifactsAsync(string namespace_, GetUdfArtifactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUdfArtifactsHeaders headers = new GetUdfArtifactsHeaders();
            return await GetUdfArtifactsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Dynamically updates parameters or resources of a deployment that is running.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// HotUpdateJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HotUpdateJobResponse
        /// </returns>
        public HotUpdateJobResponse HotUpdateJobWithOptions(string namespace_, string jobId, HotUpdateJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotUpdateJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3AhotUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotUpdateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Dynamically updates parameters or resources of a deployment that is running.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// HotUpdateJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HotUpdateJobResponse
        /// </returns>
        public async Task<HotUpdateJobResponse> HotUpdateJobWithOptionsAsync(string namespace_, string jobId, HotUpdateJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HotUpdateJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3AhotUpdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HotUpdateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Dynamically updates parameters or resources of a deployment that is running.</para>
        /// </summary>
        /// 
        /// <returns>
        /// HotUpdateJobResponse
        /// </returns>
        public HotUpdateJobResponse HotUpdateJob(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotUpdateJobHeaders headers = new HotUpdateJobHeaders();
            return HotUpdateJobWithOptions(namespace_, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Dynamically updates parameters or resources of a deployment that is running.</para>
        /// </summary>
        /// 
        /// <returns>
        /// HotUpdateJobResponse
        /// </returns>
        public async Task<HotUpdateJobResponse> HotUpdateJobAsync(string namespace_, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HotUpdateJobHeaders headers = new HotUpdateJobHeaders();
            return await HotUpdateJobWithOptionsAsync(namespace_, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of existing custom connectors.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListCustomConnectorsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomConnectorsResponse
        /// </returns>
        public ListCustomConnectorsResponse ListCustomConnectorsWithOptions(string namespace_, ListCustomConnectorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomConnectors",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomConnectorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of existing custom connectors.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListCustomConnectorsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomConnectorsResponse
        /// </returns>
        public async Task<ListCustomConnectorsResponse> ListCustomConnectorsWithOptionsAsync(string namespace_, ListCustomConnectorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomConnectors",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomConnectorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of existing custom connectors.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListCustomConnectorsResponse
        /// </returns>
        public ListCustomConnectorsResponse ListCustomConnectors(string namespace_)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomConnectorsHeaders headers = new ListCustomConnectorsHeaders();
            return ListCustomConnectorsWithOptions(namespace_, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of existing custom connectors.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListCustomConnectorsResponse
        /// </returns>
        public async Task<ListCustomConnectorsResponse> ListCustomConnectorsAsync(string namespace_)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListCustomConnectorsHeaders headers = new ListCustomConnectorsHeaders();
            return await ListCustomConnectorsWithOptionsAsync(namespace_, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list deploymentDrafts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentDraftsRequest
        /// </param>
        /// <param name="headers">
        /// ListDeploymentDraftsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentDraftsResponse
        /// </returns>
        public ListDeploymentDraftsResponse ListDeploymentDraftsWithOptions(string namespace_, ListDeploymentDraftsRequest request, ListDeploymentDraftsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentDrafts",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentDraftsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list deploymentDrafts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentDraftsRequest
        /// </param>
        /// <param name="headers">
        /// ListDeploymentDraftsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentDraftsResponse
        /// </returns>
        public async Task<ListDeploymentDraftsResponse> ListDeploymentDraftsWithOptionsAsync(string namespace_, ListDeploymentDraftsRequest request, ListDeploymentDraftsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentDrafts",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentDraftsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list deploymentDrafts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentDraftsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentDraftsResponse
        /// </returns>
        public ListDeploymentDraftsResponse ListDeploymentDrafts(string namespace_, ListDeploymentDraftsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentDraftsHeaders headers = new ListDeploymentDraftsHeaders();
            return ListDeploymentDraftsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list deploymentDrafts</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentDraftsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentDraftsResponse
        /// </returns>
        public async Task<ListDeploymentDraftsResponse> ListDeploymentDraftsAsync(string namespace_, ListDeploymentDraftsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentDraftsHeaders headers = new ListDeploymentDraftsHeaders();
            return await ListDeploymentDraftsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of clusters in which deployments can be deployed. The cluster can be a session cluster or a per-job cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentTargetsRequest
        /// </param>
        /// <param name="headers">
        /// ListDeploymentTargetsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentTargetsResponse
        /// </returns>
        public ListDeploymentTargetsResponse ListDeploymentTargetsWithOptions(string namespace_, ListDeploymentTargetsRequest request, ListDeploymentTargetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentTargets",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentTargetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of clusters in which deployments can be deployed. The cluster can be a session cluster or a per-job cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentTargetsRequest
        /// </param>
        /// <param name="headers">
        /// ListDeploymentTargetsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentTargetsResponse
        /// </returns>
        public async Task<ListDeploymentTargetsResponse> ListDeploymentTargetsWithOptionsAsync(string namespace_, ListDeploymentTargetsRequest request, ListDeploymentTargetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeploymentTargets",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of clusters in which deployments can be deployed. The cluster can be a session cluster or a per-job cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentTargetsResponse
        /// </returns>
        public ListDeploymentTargetsResponse ListDeploymentTargets(string namespace_, ListDeploymentTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentTargetsHeaders headers = new ListDeploymentTargetsHeaders();
            return ListDeploymentTargetsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of clusters in which deployments can be deployed. The cluster can be a session cluster or a per-job cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentTargetsResponse
        /// </returns>
        public async Task<ListDeploymentTargetsResponse> ListDeploymentTargetsAsync(string namespace_, ListDeploymentTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentTargetsHeaders headers = new ListDeploymentTargetsHeaders();
            return await ListDeploymentTargetsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains information about all deployments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentsRequest
        /// </param>
        /// <param name="headers">
        /// ListDeploymentsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentsResponse
        /// </returns>
        public ListDeploymentsResponse ListDeploymentsWithOptions(string namespace_, ListDeploymentsRequest request, ListDeploymentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["executionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKey))
            {
                query["labelKey"] = request.LabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelValueArray))
            {
                query["labelValueArray"] = request.LabelValueArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["sortName"] = request.SortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployments",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains information about all deployments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentsRequest
        /// </param>
        /// <param name="headers">
        /// ListDeploymentsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentsResponse
        /// </returns>
        public async Task<ListDeploymentsResponse> ListDeploymentsWithOptionsAsync(string namespace_, ListDeploymentsRequest request, ListDeploymentsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["executionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKey))
            {
                query["labelKey"] = request.LabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelValueArray))
            {
                query["labelValueArray"] = request.LabelValueArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["sortName"] = request.SortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployments",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeploymentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains information about all deployments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentsResponse
        /// </returns>
        public ListDeploymentsResponse ListDeployments(string namespace_, ListDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentsHeaders headers = new ListDeploymentsHeaders();
            return ListDeploymentsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains information about all deployments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDeploymentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDeploymentsResponse
        /// </returns>
        public async Task<ListDeploymentsResponse> ListDeploymentsAsync(string namespace_, ListDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDeploymentsHeaders headers = new ListDeploymentsHeaders();
            return await ListDeploymentsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出有编辑权限的项目空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEditableNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEditableNamespaceResponse
        /// </returns>
        public ListEditableNamespaceResponse ListEditableNamespaceWithOptions(ListEditableNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEditableNamespace",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/editable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEditableNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出有编辑权限的项目空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEditableNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEditableNamespaceResponse
        /// </returns>
        public async Task<ListEditableNamespaceResponse> ListEditableNamespaceWithOptionsAsync(ListEditableNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEditableNamespace",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/editable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEditableNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出有编辑权限的项目空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEditableNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEditableNamespaceResponse
        /// </returns>
        public ListEditableNamespaceResponse ListEditableNamespace(ListEditableNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEditableNamespaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出有编辑权限的项目空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEditableNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEditableNamespaceResponse
        /// </returns>
        public async Task<ListEditableNamespaceResponse> ListEditableNamespaceAsync(ListEditableNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEditableNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of engine versions that are supported by Realtime Compute for Apache Flink.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListEngineVersionMetadataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEngineVersionMetadataResponse
        /// </returns>
        public ListEngineVersionMetadataResponse ListEngineVersionMetadataWithOptions(ListEngineVersionMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEngineVersionMetadata",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/engine-version-meta.json",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEngineVersionMetadataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of engine versions that are supported by Realtime Compute for Apache Flink.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListEngineVersionMetadataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEngineVersionMetadataResponse
        /// </returns>
        public async Task<ListEngineVersionMetadataResponse> ListEngineVersionMetadataWithOptionsAsync(ListEngineVersionMetadataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEngineVersionMetadata",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/engine-version-meta.json",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEngineVersionMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of engine versions that are supported by Realtime Compute for Apache Flink.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListEngineVersionMetadataResponse
        /// </returns>
        public ListEngineVersionMetadataResponse ListEngineVersionMetadata()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEngineVersionMetadataHeaders headers = new ListEngineVersionMetadataHeaders();
            return ListEngineVersionMetadataWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of engine versions that are supported by Realtime Compute for Apache Flink.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListEngineVersionMetadataResponse
        /// </returns>
        public async Task<ListEngineVersionMetadataResponse> ListEngineVersionMetadataAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEngineVersionMetadataHeaders headers = new ListEngineVersionMetadataHeaders();
            return await ListEngineVersionMetadataWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all jobs in a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="headers">
        /// ListJobsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobsWithOptions(string namespace_, ListJobsRequest request, ListJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["sortName"] = request.SortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["sortOrder"] = request.SortOrder;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all jobs in a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="headers">
        /// ListJobsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(string namespace_, ListJobsRequest request, ListJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortName))
            {
                query["sortName"] = request.SortName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["sortOrder"] = request.SortOrder;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all jobs in a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobs(string namespace_, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJobsHeaders headers = new ListJobsHeaders();
            return ListJobsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all jobs in a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsAsync(string namespace_, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListJobsHeaders headers = new ListJobsHeaders();
            return await ListJobsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mappings between the ID and permissions of a member in a specific namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// <param name="headers">
        /// ListMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public ListMembersResponse ListMembersWithOptions(string namespace_, ListMembersRequest request, ListMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mappings between the ID and permissions of a member in a specific namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// <param name="headers">
        /// ListMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public async Task<ListMembersResponse> ListMembersWithOptionsAsync(string namespace_, ListMembersRequest request, ListMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mappings between the ID and permissions of a member in a specific namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public ListMembersResponse ListMembers(string namespace_, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMembersHeaders headers = new ListMembersHeaders();
            return ListMembersWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mappings between the ID and permissions of a member in a specific namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public async Task<ListMembersResponse> ListMembersAsync(string namespace_, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMembersHeaders headers = new ListMembersHeaders();
            return await ListMembersWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of savepoints or checkpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSavepointsRequest
        /// </param>
        /// <param name="headers">
        /// ListSavepointsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSavepointsResponse
        /// </returns>
        public ListSavepointsResponse ListSavepointsWithOptions(string namespace_, ListSavepointsRequest request, ListSavepointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavepoints",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSavepointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of savepoints or checkpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSavepointsRequest
        /// </param>
        /// <param name="headers">
        /// ListSavepointsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSavepointsResponse
        /// </returns>
        public async Task<ListSavepointsResponse> ListSavepointsWithOptionsAsync(string namespace_, ListSavepointsRequest request, ListSavepointsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavepoints",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/savepoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSavepointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of savepoints or checkpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSavepointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSavepointsResponse
        /// </returns>
        public ListSavepointsResponse ListSavepoints(string namespace_, ListSavepointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSavepointsHeaders headers = new ListSavepointsHeaders();
            return ListSavepointsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of savepoints or checkpoints.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSavepointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSavepointsResponse
        /// </returns>
        public async Task<ListSavepointsResponse> ListSavepointsAsync(string namespace_, ListSavepointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSavepointsHeaders headers = new ListSavepointsHeaders();
            return await ListSavepointsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPlanRequest
        /// </param>
        /// <param name="headers">
        /// ListScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPlanResponse
        /// </returns>
        public ListScheduledPlanResponse ListScheduledPlanWithOptions(string namespace_, ListScheduledPlanRequest request, ListScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPlanRequest
        /// </param>
        /// <param name="headers">
        /// ListScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPlanResponse
        /// </returns>
        public async Task<ListScheduledPlanResponse> ListScheduledPlanWithOptionsAsync(string namespace_, ListScheduledPlanRequest request, ListScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPlanResponse
        /// </returns>
        public ListScheduledPlanResponse ListScheduledPlan(string namespace_, ListScheduledPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListScheduledPlanHeaders headers = new ListScheduledPlanHeaders();
            return ListScheduledPlanWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPlanResponse
        /// </returns>
        public async Task<ListScheduledPlanResponse> ListScheduledPlanAsync(string namespace_, ListScheduledPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListScheduledPlanHeaders headers = new ListScheduledPlanHeaders();
            return await ListScheduledPlanWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业资源变更历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPlanExecutedHistoryRequest
        /// </param>
        /// <param name="headers">
        /// ListScheduledPlanExecutedHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPlanExecutedHistoryResponse
        /// </returns>
        public ListScheduledPlanExecutedHistoryResponse ListScheduledPlanExecutedHistoryWithOptions(string namespace_, ListScheduledPlanExecutedHistoryRequest request, ListScheduledPlanExecutedHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledPlanExecutedHistory",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/job-resource-upgradings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledPlanExecutedHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业资源变更历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPlanExecutedHistoryRequest
        /// </param>
        /// <param name="headers">
        /// ListScheduledPlanExecutedHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPlanExecutedHistoryResponse
        /// </returns>
        public async Task<ListScheduledPlanExecutedHistoryResponse> ListScheduledPlanExecutedHistoryWithOptionsAsync(string namespace_, ListScheduledPlanExecutedHistoryRequest request, ListScheduledPlanExecutedHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentId))
            {
                query["deploymentId"] = request.DeploymentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["origin"] = request.Origin;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledPlanExecutedHistory",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/job-resource-upgradings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledPlanExecutedHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业资源变更历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPlanExecutedHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPlanExecutedHistoryResponse
        /// </returns>
        public ListScheduledPlanExecutedHistoryResponse ListScheduledPlanExecutedHistory(string namespace_, ListScheduledPlanExecutedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListScheduledPlanExecutedHistoryHeaders headers = new ListScheduledPlanExecutedHistoryHeaders();
            return ListScheduledPlanExecutedHistoryWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业资源变更历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledPlanExecutedHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledPlanExecutedHistoryResponse
        /// </returns>
        public async Task<ListScheduledPlanExecutedHistoryResponse> ListScheduledPlanExecutedHistoryAsync(string namespace_, ListScheduledPlanExecutedHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListScheduledPlanExecutedHistoryHeaders headers = new ListScheduledPlanExecutedHistoryHeaders();
            return await ListScheduledPlanExecutedHistoryWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListSessionClustersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionClustersResponse
        /// </returns>
        public ListSessionClustersResponse ListSessionClustersWithOptions(string namespace_, ListSessionClustersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessionClusters",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionClustersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListSessionClustersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionClustersResponse
        /// </returns>
        public async Task<ListSessionClustersResponse> ListSessionClustersWithOptionsAsync(string namespace_, ListSessionClustersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessionClusters",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSessionClustersResponse
        /// </returns>
        public ListSessionClustersResponse ListSessionClusters(string namespace_)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSessionClustersHeaders headers = new ListSessionClustersHeaders();
            return ListSessionClustersWithOptions(namespace_, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSessionClustersResponse
        /// </returns>
        public async Task<ListSessionClustersResponse> ListSessionClustersAsync(string namespace_)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSessionClustersHeaders headers = new ListSessionClustersHeaders();
            return await ListSessionClustersWithOptionsAsync(namespace_, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of variables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVariablesRequest
        /// </param>
        /// <param name="headers">
        /// ListVariablesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVariablesResponse
        /// </returns>
        public ListVariablesResponse ListVariablesWithOptions(string namespace_, ListVariablesRequest request, ListVariablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVariables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of variables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVariablesRequest
        /// </param>
        /// <param name="headers">
        /// ListVariablesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVariablesResponse
        /// </returns>
        public async Task<ListVariablesResponse> ListVariablesWithOptionsAsync(string namespace_, ListVariablesRequest request, ListVariablesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVariables",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of variables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVariablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVariablesResponse
        /// </returns>
        public ListVariablesResponse ListVariables(string namespace_, ListVariablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVariablesHeaders headers = new ListVariablesHeaders();
            return ListVariablesWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of variables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVariablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVariablesResponse
        /// </returns>
        public async Task<ListVariablesResponse> ListVariablesAsync(string namespace_, ListVariablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVariablesHeaders headers = new ListVariablesHeaders();
            return await ListVariablesWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a custom connector in a namespace. The registered custom connector can be used in SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCustomConnectorRequest
        /// </param>
        /// <param name="headers">
        /// RegisterCustomConnectorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCustomConnectorResponse
        /// </returns>
        public RegisterCustomConnectorResponse RegisterCustomConnectorWithOptions(string namespace_, RegisterCustomConnectorRequest request, RegisterCustomConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarUrl))
            {
                query["jarUrl"] = request.JarUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterCustomConnector",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors%3Aregister",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCustomConnectorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a custom connector in a namespace. The registered custom connector can be used in SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCustomConnectorRequest
        /// </param>
        /// <param name="headers">
        /// RegisterCustomConnectorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCustomConnectorResponse
        /// </returns>
        public async Task<RegisterCustomConnectorResponse> RegisterCustomConnectorWithOptionsAsync(string namespace_, RegisterCustomConnectorRequest request, RegisterCustomConnectorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarUrl))
            {
                query["jarUrl"] = request.JarUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterCustomConnector",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/connectors%3Aregister",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCustomConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a custom connector in a namespace. The registered custom connector can be used in SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCustomConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCustomConnectorResponse
        /// </returns>
        public RegisterCustomConnectorResponse RegisterCustomConnector(string namespace_, RegisterCustomConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCustomConnectorHeaders headers = new RegisterCustomConnectorHeaders();
            return RegisterCustomConnectorWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a custom connector in a namespace. The registered custom connector can be used in SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCustomConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCustomConnectorResponse
        /// </returns>
        public async Task<RegisterCustomConnectorResponse> RegisterCustomConnectorAsync(string namespace_, RegisterCustomConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCustomConnectorHeaders headers = new RegisterCustomConnectorHeaders();
            return await RegisterCustomConnectorWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers specific or all of the user-defined functions (UDFs) that are parsed from the JAR files. The registered functions can be used in SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterUdfFunctionRequest
        /// </param>
        /// <param name="headers">
        /// RegisterUdfFunctionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterUdfFunctionResponse
        /// </returns>
        public RegisterUdfFunctionResponse RegisterUdfFunctionWithOptions(string namespace_, RegisterUdfFunctionRequest request, RegisterUdfFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                query["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterUdfFunction",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/function%3AregisterUdfFunction",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterUdfFunctionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers specific or all of the user-defined functions (UDFs) that are parsed from the JAR files. The registered functions can be used in SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterUdfFunctionRequest
        /// </param>
        /// <param name="headers">
        /// RegisterUdfFunctionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterUdfFunctionResponse
        /// </returns>
        public async Task<RegisterUdfFunctionResponse> RegisterUdfFunctionWithOptionsAsync(string namespace_, RegisterUdfFunctionRequest request, RegisterUdfFunctionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassName))
            {
                query["className"] = request.ClassName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["functionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdfArtifactName))
            {
                query["udfArtifactName"] = request.UdfArtifactName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterUdfFunction",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/function%3AregisterUdfFunction",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterUdfFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers specific or all of the user-defined functions (UDFs) that are parsed from the JAR files. The registered functions can be used in SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterUdfFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterUdfFunctionResponse
        /// </returns>
        public RegisterUdfFunctionResponse RegisterUdfFunction(string namespace_, RegisterUdfFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterUdfFunctionHeaders headers = new RegisterUdfFunctionHeaders();
            return RegisterUdfFunctionWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers specific or all of the user-defined functions (UDFs) that are parsed from the JAR files. The registered functions can be used in SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterUdfFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterUdfFunctionResponse
        /// </returns>
        public async Task<RegisterUdfFunctionResponse> RegisterUdfFunctionAsync(string namespace_, RegisterUdfFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterUdfFunctionHeaders headers = new RegisterUdfFunctionHeaders();
            return await RegisterUdfFunctionWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI StartJob is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRequest
        /// </param>
        /// <param name="headers">
        /// StartJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartJobResponse
        /// </returns>
        [Obsolete("OpenAPI StartJob is deprecated")]
        // Deprecated
        public StartJobResponse StartJobWithOptions(string namespace_, StartJobRequest request, StartJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI StartJob is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRequest
        /// </param>
        /// <param name="headers">
        /// StartJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartJobResponse
        /// </returns>
        [Obsolete("OpenAPI StartJob is deprecated")]
        // Deprecated
        public async Task<StartJobResponse> StartJobWithOptionsAsync(string namespace_, StartJobRequest request, StartJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI StartJob is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StartJobResponse
        /// </returns>
        [Obsolete("OpenAPI StartJob is deprecated")]
        // Deprecated
        public StartJobResponse StartJob(string namespace_, StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobHeaders headers = new StartJobHeaders();
            return StartJobWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI StartJob is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and starts a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StartJobResponse
        /// </returns>
        [Obsolete("OpenAPI StartJob is deprecated")]
        // Deprecated
        public async Task<StartJobResponse> StartJobAsync(string namespace_, StartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobHeaders headers = new StartJobHeaders();
            return await StartJobWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobWithParamsRequest
        /// </param>
        /// <param name="headers">
        /// StartJobWithParamsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartJobWithParamsResponse
        /// </returns>
        public StartJobWithParamsResponse StartJobWithParamsWithOptions(string namespace_, StartJobWithParamsRequest request, StartJobWithParamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobWithParams",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs%3Astart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobWithParamsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobWithParamsRequest
        /// </param>
        /// <param name="headers">
        /// StartJobWithParamsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartJobWithParamsResponse
        /// </returns>
        public async Task<StartJobWithParamsResponse> StartJobWithParamsWithOptionsAsync(string namespace_, StartJobWithParamsRequest request, StartJobWithParamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobWithParams",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs%3Astart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobWithParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobWithParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// StartJobWithParamsResponse
        /// </returns>
        public StartJobWithParamsResponse StartJobWithParams(string namespace_, StartJobWithParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobWithParamsHeaders headers = new StartJobWithParamsHeaders();
            return StartJobWithParamsWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartJobWithParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// StartJobWithParamsResponse
        /// </returns>
        public async Task<StartJobWithParamsResponse> StartJobWithParamsAsync(string namespace_, StartJobWithParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartJobWithParamsHeaders headers = new StartJobWithParamsHeaders();
            return await StartJobWithParamsWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// StartSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartSessionClusterResponse
        /// </returns>
        public StartSessionClusterResponse StartSessionClusterWithOptions(string namespace_, string sessionClusterName, StartSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName) + "%3Astart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// StartSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartSessionClusterResponse
        /// </returns>
        public async Task<StartSessionClusterResponse> StartSessionClusterWithOptionsAsync(string namespace_, string sessionClusterName, StartSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName) + "%3Astart",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartSessionClusterResponse
        /// </returns>
        public StartSessionClusterResponse StartSessionCluster(string namespace_, string sessionClusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartSessionClusterHeaders headers = new StartSessionClusterHeaders();
            return StartSessionClusterWithOptions(namespace_, sessionClusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartSessionClusterResponse
        /// </returns>
        public async Task<StartSessionClusterResponse> StartSessionClusterAsync(string namespace_, string sessionClusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StartSessionClusterHeaders headers = new StartSessionClusterHeaders();
            return await StartSessionClusterWithOptionsAsync(namespace_, sessionClusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止应用执行定时计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// StopApplyScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopApplyScheduledPlanResponse
        /// </returns>
        public StopApplyScheduledPlanResponse StopApplyScheduledPlanWithOptions(string namespace_, string scheduledPlanId, StopApplyScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApplyScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scheduledPlanId) + "%3Astop",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopApplyScheduledPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止应用执行定时计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// StopApplyScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopApplyScheduledPlanResponse
        /// </returns>
        public async Task<StopApplyScheduledPlanResponse> StopApplyScheduledPlanWithOptionsAsync(string namespace_, string scheduledPlanId, StopApplyScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApplyScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scheduledPlanId) + "%3Astop",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopApplyScheduledPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止应用执行定时计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopApplyScheduledPlanResponse
        /// </returns>
        public StopApplyScheduledPlanResponse StopApplyScheduledPlan(string namespace_, string scheduledPlanId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopApplyScheduledPlanHeaders headers = new StopApplyScheduledPlanHeaders();
            return StopApplyScheduledPlanWithOptions(namespace_, scheduledPlanId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止应用执行定时计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopApplyScheduledPlanResponse
        /// </returns>
        public async Task<StopApplyScheduledPlanResponse> StopApplyScheduledPlanAsync(string namespace_, string scheduledPlanId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopApplyScheduledPlanHeaders headers = new StopApplyScheduledPlanHeaders();
            return await StopApplyScheduledPlanWithOptionsAsync(namespace_, scheduledPlanId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopJobRequest
        /// </param>
        /// <param name="headers">
        /// StopJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopJobResponse
        /// </returns>
        public StopJobResponse StopJobWithOptions(string namespace_, string jobId, StopJobRequest request, StopJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3Astop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopJobRequest
        /// </param>
        /// <param name="headers">
        /// StopJobHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopJobResponse
        /// </returns>
        public async Task<StopJobResponse> StopJobWithOptionsAsync(string namespace_, string jobId, StopJobRequest request, StopJobHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "%3Astop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StopJobResponse
        /// </returns>
        public StopJobResponse StopJob(string namespace_, string jobId, StopJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopJobHeaders headers = new StopJobHeaders();
            return StopJobWithOptions(namespace_, jobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StopJobResponse
        /// </returns>
        public async Task<StopJobResponse> StopJobAsync(string namespace_, string jobId, StopJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopJobHeaders headers = new StopJobHeaders();
            return await StopJobWithOptionsAsync(namespace_, jobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// StopSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopSessionClusterResponse
        /// </returns>
        public StopSessionClusterResponse StopSessionClusterWithOptions(string namespace_, string sessionClusterName, StopSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName) + "%3Astop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止session集群</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// StopSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopSessionClusterResponse
        /// </returns>
        public async Task<StopSessionClusterResponse> StopSessionClusterWithOptionsAsync(string namespace_, string sessionClusterName, StopSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName) + "%3Astop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopSessionClusterResponse
        /// </returns>
        public StopSessionClusterResponse StopSessionCluster(string namespace_, string sessionClusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopSessionClusterHeaders headers = new StopSessionClusterHeaders();
            return StopSessionClusterWithOptions(namespace_, sessionClusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止session集群</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopSessionClusterResponse
        /// </returns>
        public async Task<StopSessionClusterResponse> StopSessionClusterAsync(string namespace_, string sessionClusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StopSessionClusterHeaders headers = new StopSessionClusterHeaders();
            return await StopSessionClusterWithOptionsAsync(namespace_, sessionClusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交sql调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitSqlPreviewRequest
        /// </param>
        /// <param name="headers">
        /// SubmitSqlPreviewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSqlPreviewResponse
        /// </returns>
        public SubmitSqlPreviewResponse SubmitSqlPreviewWithOptions(string namespace_, SubmitSqlPreviewRequest request, SubmitSqlPreviewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterName))
            {
                query["sessionClusterName"] = request.SessionClusterName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSqlPreview",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-preview/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSqlPreviewResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交sql调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitSqlPreviewRequest
        /// </param>
        /// <param name="headers">
        /// SubmitSqlPreviewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSqlPreviewResponse
        /// </returns>
        public async Task<SubmitSqlPreviewResponse> SubmitSqlPreviewWithOptionsAsync(string namespace_, SubmitSqlPreviewRequest request, SubmitSqlPreviewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionClusterName))
            {
                query["sessionClusterName"] = request.SessionClusterName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSqlPreview",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-preview/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSqlPreviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交sql调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitSqlPreviewRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSqlPreviewResponse
        /// </returns>
        public SubmitSqlPreviewResponse SubmitSqlPreview(string namespace_, SubmitSqlPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitSqlPreviewHeaders headers = new SubmitSqlPreviewHeaders();
            return SubmitSqlPreviewWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交sql调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitSqlPreviewRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSqlPreviewResponse
        /// </returns>
        public async Task<SubmitSqlPreviewResponse> SubmitSqlPreviewAsync(string namespace_, SubmitSqlPreviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitSqlPreviewHeaders headers = new SubmitSqlPreviewHeaders();
            return await SubmitSqlPreviewWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates information about a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeploymentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentResponse
        /// </returns>
        public UpdateDeploymentResponse UpdateDeploymentWithOptions(string namespace_, string deploymentId, UpdateDeploymentRequest request, UpdateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates information about a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeploymentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentResponse
        /// </returns>
        public async Task<UpdateDeploymentResponse> UpdateDeploymentWithOptionsAsync(string namespace_, string deploymentId, UpdateDeploymentRequest request, UpdateDeploymentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeployment",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates information about a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentResponse
        /// </returns>
        public UpdateDeploymentResponse UpdateDeployment(string namespace_, string deploymentId, UpdateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentHeaders headers = new UpdateDeploymentHeaders();
            return UpdateDeploymentWithOptions(namespace_, deploymentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates information about a deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentResponse
        /// </returns>
        public async Task<UpdateDeploymentResponse> UpdateDeploymentAsync(string namespace_, string deploymentId, UpdateDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentHeaders headers = new UpdateDeploymentHeaders();
            return await UpdateDeploymentWithOptionsAsync(namespace_, deploymentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>update a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentDraftRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeploymentDraftHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentDraftResponse
        /// </returns>
        public UpdateDeploymentDraftResponse UpdateDeploymentDraftWithOptions(string namespace_, string deploymentDraftId, UpdateDeploymentDraftRequest request, UpdateDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentDraftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>update a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentDraftRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeploymentDraftHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentDraftResponse
        /// </returns>
        public async Task<UpdateDeploymentDraftResponse> UpdateDeploymentDraftWithOptionsAsync(string namespace_, string deploymentDraftId, UpdateDeploymentDraftRequest request, UpdateDeploymentDraftHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentDraft",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-drafts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentDraftId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>update a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentDraftResponse
        /// </returns>
        public UpdateDeploymentDraftResponse UpdateDeploymentDraft(string namespace_, string deploymentDraftId, UpdateDeploymentDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentDraftHeaders headers = new UpdateDeploymentDraftHeaders();
            return UpdateDeploymentDraftWithOptions(namespace_, deploymentDraftId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>update a deploymentDraft</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentDraftResponse
        /// </returns>
        public async Task<UpdateDeploymentDraftResponse> UpdateDeploymentDraftAsync(string namespace_, string deploymentDraftId, UpdateDeploymentDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentDraftHeaders headers = new UpdateDeploymentDraftHeaders();
            return await UpdateDeploymentDraftWithOptionsAsync(namespace_, deploymentDraftId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentTargetRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeploymentTargetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentTargetResponse
        /// </returns>
        public UpdateDeploymentTargetResponse UpdateDeploymentTargetWithOptions(string namespace_, string deploymentTargetName, UpdateDeploymentTargetRequest request, UpdateDeploymentTargetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentTarget",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentTargetName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentTargetRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDeploymentTargetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentTargetResponse
        /// </returns>
        public async Task<UpdateDeploymentTargetResponse> UpdateDeploymentTargetWithOptionsAsync(string namespace_, string deploymentTargetName, UpdateDeploymentTargetRequest request, UpdateDeploymentTargetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentTarget",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentTargetName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentTargetResponse
        /// </returns>
        public UpdateDeploymentTargetResponse UpdateDeploymentTarget(string namespace_, string deploymentTargetName, UpdateDeploymentTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentTargetHeaders headers = new UpdateDeploymentTargetHeaders();
            return UpdateDeploymentTargetWithOptions(namespace_, deploymentTargetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改deploymentTarget</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentTargetResponse
        /// </returns>
        public async Task<UpdateDeploymentTargetResponse> UpdateDeploymentTargetAsync(string namespace_, string deploymentTargetName, UpdateDeploymentTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentTargetHeaders headers = new UpdateDeploymentTargetHeaders();
            return await UpdateDeploymentTargetWithOptionsAsync(namespace_, deploymentTargetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新部署目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentTargetV2Request
        /// </param>
        /// <param name="headers">
        /// UpdateDeploymentTargetV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentTargetV2Response
        /// </returns>
        public UpdateDeploymentTargetV2Response UpdateDeploymentTargetV2WithOptions(string namespace_, string deploymentTargetName, UpdateDeploymentTargetV2Request request, UpdateDeploymentTargetV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentTargetV2",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets/support-elastic/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentTargetName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentTargetV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新部署目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentTargetV2Request
        /// </param>
        /// <param name="headers">
        /// UpdateDeploymentTargetV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentTargetV2Response
        /// </returns>
        public async Task<UpdateDeploymentTargetV2Response> UpdateDeploymentTargetV2WithOptionsAsync(string namespace_, string deploymentTargetName, UpdateDeploymentTargetV2Request request, UpdateDeploymentTargetV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeploymentTargetV2",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/deployment-targets/support-elastic/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentTargetName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeploymentTargetV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新部署目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentTargetV2Request
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentTargetV2Response
        /// </returns>
        public UpdateDeploymentTargetV2Response UpdateDeploymentTargetV2(string namespace_, string deploymentTargetName, UpdateDeploymentTargetV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentTargetV2Headers headers = new UpdateDeploymentTargetV2Headers();
            return UpdateDeploymentTargetV2WithOptions(namespace_, deploymentTargetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新部署目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDeploymentTargetV2Request
        /// </param>
        /// 
        /// <returns>
        /// UpdateDeploymentTargetV2Response
        /// </returns>
        public async Task<UpdateDeploymentTargetV2Response> UpdateDeploymentTargetV2Async(string namespace_, string deploymentTargetName, UpdateDeploymentTargetV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDeploymentTargetV2Headers headers = new UpdateDeploymentTargetV2Headers();
            return await UpdateDeploymentTargetV2WithOptionsAsync(namespace_, deploymentTargetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>update a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFolderRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFolderResponse
        /// </returns>
        public UpdateFolderResponse UpdateFolderWithOptions(string namespace_, string folderId, UpdateFolderRequest request, UpdateFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFolderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>update a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFolderRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFolderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFolderResponse
        /// </returns>
        public async Task<UpdateFolderResponse> UpdateFolderWithOptionsAsync(string namespace_, string folderId, UpdateFolderRequest request, UpdateFolderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFolder",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/folder/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>update a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFolderResponse
        /// </returns>
        public UpdateFolderResponse UpdateFolder(string namespace_, string folderId, UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFolderHeaders headers = new UpdateFolderHeaders();
            return UpdateFolderWithOptions(namespace_, folderId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>update a folder</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFolderResponse
        /// </returns>
        public async Task<UpdateFolderResponse> UpdateFolderAsync(string namespace_, string folderId, UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFolderHeaders headers = new UpdateFolderHeaders();
            return await UpdateFolderWithOptionsAsync(namespace_, folderId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the permissions of one or more members in a specific namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberResponse
        /// </returns>
        public UpdateMemberResponse UpdateMemberWithOptions(string namespace_, UpdateMemberRequest request, UpdateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the permissions of one or more members in a specific namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberResponse
        /// </returns>
        public async Task<UpdateMemberResponse> UpdateMemberWithOptionsAsync(string namespace_, UpdateMemberRequest request, UpdateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMember",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/gateway/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the permissions of one or more members in a specific namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberResponse
        /// </returns>
        public UpdateMemberResponse UpdateMember(string namespace_, UpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberHeaders headers = new UpdateMemberHeaders();
            return UpdateMemberWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the permissions of one or more members in a specific namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberResponse
        /// </returns>
        public async Task<UpdateMemberResponse> UpdateMemberAsync(string namespace_, UpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberHeaders headers = new UpdateMemberHeaders();
            return await UpdateMemberWithOptionsAsync(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledPlanRequest
        /// </param>
        /// <param name="headers">
        /// UpdateScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledPlanResponse
        /// </returns>
        public UpdateScheduledPlanResponse UpdateScheduledPlanWithOptions(string namespace_, string scheduledPlanId, UpdateScheduledPlanRequest request, UpdateScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scheduledPlanId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduledPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledPlanRequest
        /// </param>
        /// <param name="headers">
        /// UpdateScheduledPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledPlanResponse
        /// </returns>
        public async Task<UpdateScheduledPlanResponse> UpdateScheduledPlanWithOptionsAsync(string namespace_, string scheduledPlanId, UpdateScheduledPlanRequest request, UpdateScheduledPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduledPlan",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/scheduled-plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scheduledPlanId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScheduledPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledPlanResponse
        /// </returns>
        public UpdateScheduledPlanResponse UpdateScheduledPlan(string namespace_, string scheduledPlanId, UpdateScheduledPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduledPlanHeaders headers = new UpdateScheduledPlanHeaders();
            return UpdateScheduledPlanWithOptions(namespace_, scheduledPlanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新定时执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateScheduledPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateScheduledPlanResponse
        /// </returns>
        public async Task<UpdateScheduledPlanResponse> UpdateScheduledPlanAsync(string namespace_, string scheduledPlanId, UpdateScheduledPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateScheduledPlanHeaders headers = new UpdateScheduledPlanHeaders();
            return await UpdateScheduledPlanWithOptionsAsync(namespace_, scheduledPlanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新session集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSessionClusterResponse
        /// </returns>
        public UpdateSessionClusterResponse UpdateSessionClusterWithOptions(string namespace_, string sessionClusterName, UpdateSessionClusterRequest request, UpdateSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSessionClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新session集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSessionClusterRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSessionClusterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSessionClusterResponse
        /// </returns>
        public async Task<UpdateSessionClusterResponse> UpdateSessionClusterWithOptionsAsync(string namespace_, string sessionClusterName, UpdateSessionClusterRequest request, UpdateSessionClusterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSessionCluster",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sessionclusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionClusterName),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSessionClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新session集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSessionClusterResponse
        /// </returns>
        public UpdateSessionClusterResponse UpdateSessionCluster(string namespace_, string sessionClusterName, UpdateSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSessionClusterHeaders headers = new UpdateSessionClusterHeaders();
            return UpdateSessionClusterWithOptions(namespace_, sessionClusterName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新session集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSessionClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSessionClusterResponse
        /// </returns>
        public async Task<UpdateSessionClusterResponse> UpdateSessionClusterAsync(string namespace_, string sessionClusterName, UpdateSessionClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSessionClusterHeaders headers = new UpdateSessionClusterHeaders();
            return await UpdateSessionClusterWithOptionsAsync(namespace_, sessionClusterName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the JAR file of the user-defined function (UDF) that you create.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUdfArtifactRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUdfArtifactHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUdfArtifactResponse
        /// </returns>
        public UpdateUdfArtifactResponse UpdateUdfArtifactWithOptions(string namespace_, string udfArtifactName, UpdateUdfArtifactRequest request, UpdateUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(udfArtifactName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUdfArtifactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the JAR file of the user-defined function (UDF) that you create.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUdfArtifactRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUdfArtifactHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUdfArtifactResponse
        /// </returns>
        public async Task<UpdateUdfArtifactResponse> UpdateUdfArtifactWithOptionsAsync(string namespace_, string udfArtifactName, UpdateUdfArtifactRequest request, UpdateUdfArtifactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUdfArtifact",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/udfartifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(udfArtifactName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUdfArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the JAR file of the user-defined function (UDF) that you create.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUdfArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUdfArtifactResponse
        /// </returns>
        public UpdateUdfArtifactResponse UpdateUdfArtifact(string namespace_, string udfArtifactName, UpdateUdfArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUdfArtifactHeaders headers = new UpdateUdfArtifactHeaders();
            return UpdateUdfArtifactWithOptions(namespace_, udfArtifactName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the JAR file of the user-defined function (UDF) that you create.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUdfArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUdfArtifactResponse
        /// </returns>
        public async Task<UpdateUdfArtifactResponse> UpdateUdfArtifactAsync(string namespace_, string udfArtifactName, UpdateUdfArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUdfArtifactHeaders headers = new UpdateUdfArtifactHeaders();
            return await UpdateUdfArtifactWithOptionsAsync(namespace_, udfArtifactName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新秘钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVariableRequest
        /// </param>
        /// <param name="headers">
        /// UpdateVariableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVariableResponse
        /// </returns>
        public UpdateVariableResponse UpdateVariableWithOptions(string namespace_, string name, UpdateVariableRequest request, UpdateVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVariableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新秘钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVariableRequest
        /// </param>
        /// <param name="headers">
        /// UpdateVariableHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVariableResponse
        /// </returns>
        public async Task<UpdateVariableResponse> UpdateVariableWithOptionsAsync(string namespace_, string name, UpdateVariableRequest request, UpdateVariableHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVariable",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/variables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVariableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新秘钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVariableRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVariableResponse
        /// </returns>
        public UpdateVariableResponse UpdateVariable(string namespace_, string name, UpdateVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVariableHeaders headers = new UpdateVariableHeaders();
            return UpdateVariableWithOptions(namespace_, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新秘钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVariableRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVariableResponse
        /// </returns>
        public async Task<UpdateVariableResponse> UpdateVariableAsync(string namespace_, string name, UpdateVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateVariableHeaders headers = new UpdateVariableHeaders();
            return await UpdateVariableWithOptionsAsync(namespace_, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the code of an SQL deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// ValidateSqlStatementHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateSqlStatementResponse
        /// </returns>
        public ValidateSqlStatementResponse ValidateSqlStatementWithOptions(string namespace_, ValidateSqlStatementRequest request, ValidateSqlStatementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateSqlStatement",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-statement/validate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateSqlStatementResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the code of an SQL deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateSqlStatementRequest
        /// </param>
        /// <param name="headers">
        /// ValidateSqlStatementHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateSqlStatementResponse
        /// </returns>
        public async Task<ValidateSqlStatementResponse> ValidateSqlStatementWithOptionsAsync(string namespace_, ValidateSqlStatementRequest request, ValidateSqlStatementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Workspace))
            {
                realHeaders["workspace"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Workspace);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateSqlStatement",
                Version = "2022-07-18",
                Protocol = "HTTPS",
                Pathname = "/api/v2/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/sql-statement/validate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateSqlStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the code of an SQL deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateSqlStatementResponse
        /// </returns>
        public ValidateSqlStatementResponse ValidateSqlStatement(string namespace_, ValidateSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateSqlStatementHeaders headers = new ValidateSqlStatementHeaders();
            return ValidateSqlStatementWithOptions(namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the code of an SQL deployment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateSqlStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateSqlStatementResponse
        /// </returns>
        public async Task<ValidateSqlStatementResponse> ValidateSqlStatementAsync(string namespace_, ValidateSqlStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ValidateSqlStatementHeaders headers = new ValidateSqlStatementHeaders();
            return await ValidateSqlStatementWithOptionsAsync(namespace_, request, headers, runtime);
        }

    }
}
