// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AgenticBAS20260630.Models;

namespace AlibabaCloud.SDK.AgenticBAS20260630
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "AgenticBAS";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("agenticbas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates penetration testing tasks for authorized assets of the current account and returns the task IDs. You can specify up to five targets at a time, and one task is created for each target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates penetration testing tasks for authorized assets of the current account and returns the task IDs. You can specify up to five targets at a time, and one task is created for each target.
        /// Before you call this operation, you must activate the AgenticBAS service or meet the validity period and quota conditions of the trial service. The target assets must meet the ownership verification requirements of the selected asset source. Business parameters are passed in OperationInput. VulnCheckItems and PentestRequirement cannot be empty at the same time. Currently, only IMMEDIATE execution is supported, and scheduled execution is not supported.
        /// A successful creation response only indicates that the tasks are created and does not wait for the scan to complete. Save the TaskId in TaskList, query the status and usage by calling DescribePentestTaskList, and then use the same TaskId to query vulnerabilities or reports. Tasks may enter a queue. If a report is not generated, the query response may not contain a download link.
        /// Credentials use an object structure of &quot;identity name -&gt; credential configuration&quot;. The following are synthetic examples. Replace them with authorized test identities in actual calls.</para>
        /// <pre><code class="language-json">{
        ///   &quot;Credentials&quot;: {
        ///     &quot;accountUser&quot;: {
        ///       &quot;account&quot;: {
        ///         &quot;username&quot;: &quot;example-user&quot;,
        ///         &quot;password&quot;: &quot;example-password&quot;
        ///       }
        ///     },
        ///     &quot;cookieUser&quot;: {
        ///       &quot;cookies&quot;: [
        ///         {
        ///           &quot;name&quot;: &quot;session&quot;,
        ///           &quot;value&quot;: &quot;example-session&quot;,
        ///           &quot;domain&quot;: &quot;example.com&quot;,
        ///           &quot;path&quot;: &quot;/&quot;,
        ///           &quot;secure&quot;: true,
        ///           &quot;httpOnly&quot;: true,
        ///           &quot;sameSite&quot;: &quot;Lax&quot;
        ///         }
        ///       ]
        ///     },
        ///     &quot;localUser&quot;: {
        ///       &quot;localStorage&quot;: {
        ///         &quot;access_token&quot;: &quot;example-local-token&quot;
        ///       }
        ///     },
        ///     &quot;sessionUser&quot;: {
        ///       &quot;sessionStorage&quot;: {
        ///         &quot;session_token&quot;: &quot;example-session-token&quot;
        ///       }
        ///     },
        ///     &quot;headerUser&quot;: {
        ///       &quot;extraHeaders&quot;: {
        ///         &quot;Authorization&quot;: &quot;Bearer example-token&quot;
        ///       }
        ///     }
        ///   }
        /// }
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePentestTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePentestTaskResponse
        /// </returns>
        public CreatePentestTaskResponse CreatePentestTaskWithOptions(CreatePentestTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePentestTaskShrinkRequest request = new CreatePentestTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationInput))
            {
                request.OperationInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationInput, "OperationInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationInputShrink))
            {
                query["OperationInput"] = request.OperationInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePentestTask",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePentestTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates penetration testing tasks for authorized assets of the current account and returns the task IDs. You can specify up to five targets at a time, and one task is created for each target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates penetration testing tasks for authorized assets of the current account and returns the task IDs. You can specify up to five targets at a time, and one task is created for each target.
        /// Before you call this operation, you must activate the AgenticBAS service or meet the validity period and quota conditions of the trial service. The target assets must meet the ownership verification requirements of the selected asset source. Business parameters are passed in OperationInput. VulnCheckItems and PentestRequirement cannot be empty at the same time. Currently, only IMMEDIATE execution is supported, and scheduled execution is not supported.
        /// A successful creation response only indicates that the tasks are created and does not wait for the scan to complete. Save the TaskId in TaskList, query the status and usage by calling DescribePentestTaskList, and then use the same TaskId to query vulnerabilities or reports. Tasks may enter a queue. If a report is not generated, the query response may not contain a download link.
        /// Credentials use an object structure of &quot;identity name -&gt; credential configuration&quot;. The following are synthetic examples. Replace them with authorized test identities in actual calls.</para>
        /// <pre><code class="language-json">{
        ///   &quot;Credentials&quot;: {
        ///     &quot;accountUser&quot;: {
        ///       &quot;account&quot;: {
        ///         &quot;username&quot;: &quot;example-user&quot;,
        ///         &quot;password&quot;: &quot;example-password&quot;
        ///       }
        ///     },
        ///     &quot;cookieUser&quot;: {
        ///       &quot;cookies&quot;: [
        ///         {
        ///           &quot;name&quot;: &quot;session&quot;,
        ///           &quot;value&quot;: &quot;example-session&quot;,
        ///           &quot;domain&quot;: &quot;example.com&quot;,
        ///           &quot;path&quot;: &quot;/&quot;,
        ///           &quot;secure&quot;: true,
        ///           &quot;httpOnly&quot;: true,
        ///           &quot;sameSite&quot;: &quot;Lax&quot;
        ///         }
        ///       ]
        ///     },
        ///     &quot;localUser&quot;: {
        ///       &quot;localStorage&quot;: {
        ///         &quot;access_token&quot;: &quot;example-local-token&quot;
        ///       }
        ///     },
        ///     &quot;sessionUser&quot;: {
        ///       &quot;sessionStorage&quot;: {
        ///         &quot;session_token&quot;: &quot;example-session-token&quot;
        ///       }
        ///     },
        ///     &quot;headerUser&quot;: {
        ///       &quot;extraHeaders&quot;: {
        ///         &quot;Authorization&quot;: &quot;Bearer example-token&quot;
        ///       }
        ///     }
        ///   }
        /// }
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePentestTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePentestTaskResponse
        /// </returns>
        public async Task<CreatePentestTaskResponse> CreatePentestTaskWithOptionsAsync(CreatePentestTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePentestTaskShrinkRequest request = new CreatePentestTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationInput))
            {
                request.OperationInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationInput, "OperationInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationInputShrink))
            {
                query["OperationInput"] = request.OperationInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePentestTask",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePentestTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates penetration testing tasks for authorized assets of the current account and returns the task IDs. You can specify up to five targets at a time, and one task is created for each target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates penetration testing tasks for authorized assets of the current account and returns the task IDs. You can specify up to five targets at a time, and one task is created for each target.
        /// Before you call this operation, you must activate the AgenticBAS service or meet the validity period and quota conditions of the trial service. The target assets must meet the ownership verification requirements of the selected asset source. Business parameters are passed in OperationInput. VulnCheckItems and PentestRequirement cannot be empty at the same time. Currently, only IMMEDIATE execution is supported, and scheduled execution is not supported.
        /// A successful creation response only indicates that the tasks are created and does not wait for the scan to complete. Save the TaskId in TaskList, query the status and usage by calling DescribePentestTaskList, and then use the same TaskId to query vulnerabilities or reports. Tasks may enter a queue. If a report is not generated, the query response may not contain a download link.
        /// Credentials use an object structure of &quot;identity name -&gt; credential configuration&quot;. The following are synthetic examples. Replace them with authorized test identities in actual calls.</para>
        /// <pre><code class="language-json">{
        ///   &quot;Credentials&quot;: {
        ///     &quot;accountUser&quot;: {
        ///       &quot;account&quot;: {
        ///         &quot;username&quot;: &quot;example-user&quot;,
        ///         &quot;password&quot;: &quot;example-password&quot;
        ///       }
        ///     },
        ///     &quot;cookieUser&quot;: {
        ///       &quot;cookies&quot;: [
        ///         {
        ///           &quot;name&quot;: &quot;session&quot;,
        ///           &quot;value&quot;: &quot;example-session&quot;,
        ///           &quot;domain&quot;: &quot;example.com&quot;,
        ///           &quot;path&quot;: &quot;/&quot;,
        ///           &quot;secure&quot;: true,
        ///           &quot;httpOnly&quot;: true,
        ///           &quot;sameSite&quot;: &quot;Lax&quot;
        ///         }
        ///       ]
        ///     },
        ///     &quot;localUser&quot;: {
        ///       &quot;localStorage&quot;: {
        ///         &quot;access_token&quot;: &quot;example-local-token&quot;
        ///       }
        ///     },
        ///     &quot;sessionUser&quot;: {
        ///       &quot;sessionStorage&quot;: {
        ///         &quot;session_token&quot;: &quot;example-session-token&quot;
        ///       }
        ///     },
        ///     &quot;headerUser&quot;: {
        ///       &quot;extraHeaders&quot;: {
        ///         &quot;Authorization&quot;: &quot;Bearer example-token&quot;
        ///       }
        ///     }
        ///   }
        /// }
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePentestTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePentestTaskResponse
        /// </returns>
        public CreatePentestTaskResponse CreatePentestTask(CreatePentestTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePentestTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates penetration testing tasks for authorized assets of the current account and returns the task IDs. You can specify up to five targets at a time, and one task is created for each target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates penetration testing tasks for authorized assets of the current account and returns the task IDs. You can specify up to five targets at a time, and one task is created for each target.
        /// Before you call this operation, you must activate the AgenticBAS service or meet the validity period and quota conditions of the trial service. The target assets must meet the ownership verification requirements of the selected asset source. Business parameters are passed in OperationInput. VulnCheckItems and PentestRequirement cannot be empty at the same time. Currently, only IMMEDIATE execution is supported, and scheduled execution is not supported.
        /// A successful creation response only indicates that the tasks are created and does not wait for the scan to complete. Save the TaskId in TaskList, query the status and usage by calling DescribePentestTaskList, and then use the same TaskId to query vulnerabilities or reports. Tasks may enter a queue. If a report is not generated, the query response may not contain a download link.
        /// Credentials use an object structure of &quot;identity name -&gt; credential configuration&quot;. The following are synthetic examples. Replace them with authorized test identities in actual calls.</para>
        /// <pre><code class="language-json">{
        ///   &quot;Credentials&quot;: {
        ///     &quot;accountUser&quot;: {
        ///       &quot;account&quot;: {
        ///         &quot;username&quot;: &quot;example-user&quot;,
        ///         &quot;password&quot;: &quot;example-password&quot;
        ///       }
        ///     },
        ///     &quot;cookieUser&quot;: {
        ///       &quot;cookies&quot;: [
        ///         {
        ///           &quot;name&quot;: &quot;session&quot;,
        ///           &quot;value&quot;: &quot;example-session&quot;,
        ///           &quot;domain&quot;: &quot;example.com&quot;,
        ///           &quot;path&quot;: &quot;/&quot;,
        ///           &quot;secure&quot;: true,
        ///           &quot;httpOnly&quot;: true,
        ///           &quot;sameSite&quot;: &quot;Lax&quot;
        ///         }
        ///       ]
        ///     },
        ///     &quot;localUser&quot;: {
        ///       &quot;localStorage&quot;: {
        ///         &quot;access_token&quot;: &quot;example-local-token&quot;
        ///       }
        ///     },
        ///     &quot;sessionUser&quot;: {
        ///       &quot;sessionStorage&quot;: {
        ///         &quot;session_token&quot;: &quot;example-session-token&quot;
        ///       }
        ///     },
        ///     &quot;headerUser&quot;: {
        ///       &quot;extraHeaders&quot;: {
        ///         &quot;Authorization&quot;: &quot;Bearer example-token&quot;
        ///       }
        ///     }
        ///   }
        /// }
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePentestTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePentestTaskResponse
        /// </returns>
        public async Task<CreatePentestTaskResponse> CreatePentestTaskAsync(CreatePentestTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePentestTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the PDF report of a specified penetration test task under the current account and returns a temporary OSS download URL and its expiration time. The report content is not returned.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribePentestReportContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestReportContentResponse
        /// </returns>
        public DescribePentestReportContentResponse DescribePentestReportContentWithOptions(DescribePentestReportContentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePentestReportContentShrinkRequest request = new DescribePentestReportContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationInput))
            {
                request.OperationInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationInput, "OperationInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationInputShrink))
            {
                query["OperationInput"] = request.OperationInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePentestReportContent",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePentestReportContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the PDF report of a specified penetration test task under the current account and returns a temporary OSS download URL and its expiration time. The report content is not returned.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribePentestReportContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestReportContentResponse
        /// </returns>
        public async Task<DescribePentestReportContentResponse> DescribePentestReportContentWithOptionsAsync(DescribePentestReportContentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePentestReportContentShrinkRequest request = new DescribePentestReportContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationInput))
            {
                request.OperationInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationInput, "OperationInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationInputShrink))
            {
                query["OperationInput"] = request.OperationInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePentestReportContent",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePentestReportContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the PDF report of a specified penetration test task under the current account and returns a temporary OSS download URL and its expiration time. The report content is not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePentestReportContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestReportContentResponse
        /// </returns>
        public DescribePentestReportContentResponse DescribePentestReportContent(DescribePentestReportContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePentestReportContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the PDF report of a specified penetration test task under the current account and returns a temporary OSS download URL and its expiration time. The report content is not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePentestReportContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestReportContentResponse
        /// </returns>
        public async Task<DescribePentestReportContentResponse> DescribePentestReportContentAsync(DescribePentestReportContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePentestReportContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the penetration testing tasks of the current account by using paging and returns the task status, execution duration, Credits usage, time, and vulnerability statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the penetration testing tasks of the current account by using paging and returns the task status, execution duration, Credits usage, time, and vulnerability statistics.
        /// Use OperationInput to specify query conditions. Paging is implemented by using CurrentPage and PageSize. By default, the first page is queried and each page contains 10 entries. You can filter tasks by task name keyword and task status.
        /// The response includes TaskList and PageInfo. Duration indicates the execution duration in seconds. CreditsUsed indicates the used Credits. Tasks that have not started may not have a start time or execution duration, and unfinished tasks may not have a completion time. UNIX timestamps uniformly use UNIX seconds. When displaying, you can convert them to the time zone of the caller.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribePentestTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestTaskListResponse
        /// </returns>
        public DescribePentestTaskListResponse DescribePentestTaskListWithOptions(DescribePentestTaskListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePentestTaskListShrinkRequest request = new DescribePentestTaskListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationInput))
            {
                request.OperationInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationInput, "OperationInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationInputShrink))
            {
                query["OperationInput"] = request.OperationInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePentestTaskList",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePentestTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the penetration testing tasks of the current account by using paging and returns the task status, execution duration, Credits usage, time, and vulnerability statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the penetration testing tasks of the current account by using paging and returns the task status, execution duration, Credits usage, time, and vulnerability statistics.
        /// Use OperationInput to specify query conditions. Paging is implemented by using CurrentPage and PageSize. By default, the first page is queried and each page contains 10 entries. You can filter tasks by task name keyword and task status.
        /// The response includes TaskList and PageInfo. Duration indicates the execution duration in seconds. CreditsUsed indicates the used Credits. Tasks that have not started may not have a start time or execution duration, and unfinished tasks may not have a completion time. UNIX timestamps uniformly use UNIX seconds. When displaying, you can convert them to the time zone of the caller.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribePentestTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestTaskListResponse
        /// </returns>
        public async Task<DescribePentestTaskListResponse> DescribePentestTaskListWithOptionsAsync(DescribePentestTaskListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePentestTaskListShrinkRequest request = new DescribePentestTaskListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationInput))
            {
                request.OperationInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationInput, "OperationInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationInputShrink))
            {
                query["OperationInput"] = request.OperationInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePentestTaskList",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePentestTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the penetration testing tasks of the current account by using paging and returns the task status, execution duration, Credits usage, time, and vulnerability statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the penetration testing tasks of the current account by using paging and returns the task status, execution duration, Credits usage, time, and vulnerability statistics.
        /// Use OperationInput to specify query conditions. Paging is implemented by using CurrentPage and PageSize. By default, the first page is queried and each page contains 10 entries. You can filter tasks by task name keyword and task status.
        /// The response includes TaskList and PageInfo. Duration indicates the execution duration in seconds. CreditsUsed indicates the used Credits. Tasks that have not started may not have a start time or execution duration, and unfinished tasks may not have a completion time. UNIX timestamps uniformly use UNIX seconds. When displaying, you can convert them to the time zone of the caller.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePentestTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestTaskListResponse
        /// </returns>
        public DescribePentestTaskListResponse DescribePentestTaskList(DescribePentestTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePentestTaskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the penetration testing tasks of the current account by using paging and returns the task status, execution duration, Credits usage, time, and vulnerability statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the penetration testing tasks of the current account by using paging and returns the task status, execution duration, Credits usage, time, and vulnerability statistics.
        /// Use OperationInput to specify query conditions. Paging is implemented by using CurrentPage and PageSize. By default, the first page is queried and each page contains 10 entries. You can filter tasks by task name keyword and task status.
        /// The response includes TaskList and PageInfo. Duration indicates the execution duration in seconds. CreditsUsed indicates the used Credits. Tasks that have not started may not have a start time or execution duration, and unfinished tasks may not have a completion time. UNIX timestamps uniformly use UNIX seconds. When displaying, you can convert them to the time zone of the caller.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePentestTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestTaskListResponse
        /// </returns>
        public async Task<DescribePentestTaskListResponse> DescribePentestTaskListAsync(DescribePentestTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePentestTaskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries penetration test vulnerabilities for the current account by task ID with paging. Returns vulnerability titles, severity levels, authentication statuses, affected URLs, and discovery times. Supports filtering by severity level.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribePentestVulnListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestVulnListResponse
        /// </returns>
        public DescribePentestVulnListResponse DescribePentestVulnListWithOptions(DescribePentestVulnListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePentestVulnListShrinkRequest request = new DescribePentestVulnListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationInput))
            {
                request.OperationInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationInput, "OperationInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationInputShrink))
            {
                query["OperationInput"] = request.OperationInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePentestVulnList",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePentestVulnListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries penetration test vulnerabilities for the current account by task ID with paging. Returns vulnerability titles, severity levels, authentication statuses, affected URLs, and discovery times. Supports filtering by severity level.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribePentestVulnListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestVulnListResponse
        /// </returns>
        public async Task<DescribePentestVulnListResponse> DescribePentestVulnListWithOptionsAsync(DescribePentestVulnListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePentestVulnListShrinkRequest request = new DescribePentestVulnListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationInput))
            {
                request.OperationInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationInput, "OperationInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationInputShrink))
            {
                query["OperationInput"] = request.OperationInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePentestVulnList",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePentestVulnListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries penetration test vulnerabilities for the current account by task ID with paging. Returns vulnerability titles, severity levels, authentication statuses, affected URLs, and discovery times. Supports filtering by severity level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePentestVulnListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestVulnListResponse
        /// </returns>
        public DescribePentestVulnListResponse DescribePentestVulnList(DescribePentestVulnListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePentestVulnListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries penetration test vulnerabilities for the current account by task ID with paging. Returns vulnerability titles, severity levels, authentication statuses, affected URLs, and discovery times. Supports filtering by severity level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePentestVulnListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestVulnListResponse
        /// </returns>
        public async Task<DescribePentestVulnListResponse> DescribePentestVulnListAsync(DescribePentestVulnListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePentestVulnListWithOptionsAsync(request, runtime);
        }

    }
}
