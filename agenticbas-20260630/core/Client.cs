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
        /// <para>Submits asynchronous retests in bulk for specified vulnerabilities under the current account and returns the acceptance results for each item.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits retests for existing vulnerabilities that the current account has access to. OperationInput accepts only VulnIds. The original array must contain 1 to 100 elements, and duplicate elements are counted. The original length is validated before deduplication. If the limit is exceeded, the entire request is rejected and no verification records are created. Valid vulnerability IDs are processed item by item. A single item failure does not block the remaining items or roll back accepted items. SuccessCount and Results.Success only indicate that the verification records are created and accepted, and do not mean that the vulnerabilities have been retested or passed verification. Retests are executed asynchronously and may consume credits.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// BatchVerifyPentestVulnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchVerifyPentestVulnResponse
        /// </returns>
        public BatchVerifyPentestVulnResponse BatchVerifyPentestVulnWithOptions(BatchVerifyPentestVulnRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchVerifyPentestVulnShrinkRequest request = new BatchVerifyPentestVulnShrinkRequest();
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
                Action = "BatchVerifyPentestVuln",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchVerifyPentestVulnResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits asynchronous retests in bulk for specified vulnerabilities under the current account and returns the acceptance results for each item.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits retests for existing vulnerabilities that the current account has access to. OperationInput accepts only VulnIds. The original array must contain 1 to 100 elements, and duplicate elements are counted. The original length is validated before deduplication. If the limit is exceeded, the entire request is rejected and no verification records are created. Valid vulnerability IDs are processed item by item. A single item failure does not block the remaining items or roll back accepted items. SuccessCount and Results.Success only indicate that the verification records are created and accepted, and do not mean that the vulnerabilities have been retested or passed verification. Retests are executed asynchronously and may consume credits.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// BatchVerifyPentestVulnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchVerifyPentestVulnResponse
        /// </returns>
        public async Task<BatchVerifyPentestVulnResponse> BatchVerifyPentestVulnWithOptionsAsync(BatchVerifyPentestVulnRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchVerifyPentestVulnShrinkRequest request = new BatchVerifyPentestVulnShrinkRequest();
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
                Action = "BatchVerifyPentestVuln",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchVerifyPentestVulnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits asynchronous retests in bulk for specified vulnerabilities under the current account and returns the acceptance results for each item.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits retests for existing vulnerabilities that the current account has access to. OperationInput accepts only VulnIds. The original array must contain 1 to 100 elements, and duplicate elements are counted. The original length is validated before deduplication. If the limit is exceeded, the entire request is rejected and no verification records are created. Valid vulnerability IDs are processed item by item. A single item failure does not block the remaining items or roll back accepted items. SuccessCount and Results.Success only indicate that the verification records are created and accepted, and do not mean that the vulnerabilities have been retested or passed verification. Retests are executed asynchronously and may consume credits.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchVerifyPentestVulnRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchVerifyPentestVulnResponse
        /// </returns>
        public BatchVerifyPentestVulnResponse BatchVerifyPentestVuln(BatchVerifyPentestVulnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchVerifyPentestVulnWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits asynchronous retests in bulk for specified vulnerabilities under the current account and returns the acceptance results for each item.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits retests for existing vulnerabilities that the current account has access to. OperationInput accepts only VulnIds. The original array must contain 1 to 100 elements, and duplicate elements are counted. The original length is validated before deduplication. If the limit is exceeded, the entire request is rejected and no verification records are created. Valid vulnerability IDs are processed item by item. A single item failure does not block the remaining items or roll back accepted items. SuccessCount and Results.Success only indicate that the verification records are created and accepted, and do not mean that the vulnerabilities have been retested or passed verification. Retests are executed asynchronously and may consume credits.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchVerifyPentestVulnRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchVerifyPentestVulnResponse
        /// </returns>
        public async Task<BatchVerifyPentestVulnResponse> BatchVerifyPentestVulnAsync(BatchVerifyPentestVulnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchVerifyPentestVulnWithOptionsAsync(request, runtime);
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
        /// <para>Queries the PDF report of a specified penetration test task for the current account, and returns a temporary Object Storage Service (OSS) download URL and the expiration time without returning the report content.</para>
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
        /// <para>Queries the PDF report of a specified penetration test task for the current account, and returns a temporary Object Storage Service (OSS) download URL and the expiration time without returning the report content.</para>
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
        /// <para>Queries the PDF report of a specified penetration test task for the current account, and returns a temporary Object Storage Service (OSS) download URL and the expiration time without returning the report content.</para>
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
        /// <para>Queries the PDF report of a specified penetration test task for the current account, and returns a temporary Object Storage Service (OSS) download URL and the expiration time without returning the report content.</para>
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
        /// <para>Queries the penetration testing nodes of the current account by paging and returns the node status, execution duration, Credits usage, time, and vulnerability statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the penetration testing nodes of the current account by paging and returns the node status, execution duration, Credits usage, time, and vulnerability statistics.
        /// Use OperationInput to specify query conditions. Paging is implemented by using CurrentPage and PageSize. By default, the first page is returned with 10 entries per page. You can filter nodes by node name keyword and node status.
        /// The response includes TaskList and PageInfo. Duration indicates the execution duration in seconds. CreditsUsed indicates the number of Credits used. Nodes that have not started may not have a start time or duration, and nodes that have not finished may not have a completion time. All UNIX timestamps are in UNIX seconds. You can transform them to the time zone of the invoker for display.</para>
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
        /// <para>Queries the penetration testing nodes of the current account by paging and returns the node status, execution duration, Credits usage, time, and vulnerability statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the penetration testing nodes of the current account by paging and returns the node status, execution duration, Credits usage, time, and vulnerability statistics.
        /// Use OperationInput to specify query conditions. Paging is implemented by using CurrentPage and PageSize. By default, the first page is returned with 10 entries per page. You can filter nodes by node name keyword and node status.
        /// The response includes TaskList and PageInfo. Duration indicates the execution duration in seconds. CreditsUsed indicates the number of Credits used. Nodes that have not started may not have a start time or duration, and nodes that have not finished may not have a completion time. All UNIX timestamps are in UNIX seconds. You can transform them to the time zone of the invoker for display.</para>
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
        /// <para>Queries the penetration testing nodes of the current account by paging and returns the node status, execution duration, Credits usage, time, and vulnerability statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the penetration testing nodes of the current account by paging and returns the node status, execution duration, Credits usage, time, and vulnerability statistics.
        /// Use OperationInput to specify query conditions. Paging is implemented by using CurrentPage and PageSize. By default, the first page is returned with 10 entries per page. You can filter nodes by node name keyword and node status.
        /// The response includes TaskList and PageInfo. Duration indicates the execution duration in seconds. CreditsUsed indicates the number of Credits used. Nodes that have not started may not have a start time or duration, and nodes that have not finished may not have a completion time. All UNIX timestamps are in UNIX seconds. You can transform them to the time zone of the invoker for display.</para>
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
        /// <para>Queries the penetration testing nodes of the current account by paging and returns the node status, execution duration, Credits usage, time, and vulnerability statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the penetration testing nodes of the current account by paging and returns the node status, execution duration, Credits usage, time, and vulnerability statistics.
        /// Use OperationInput to specify query conditions. Paging is implemented by using CurrentPage and PageSize. By default, the first page is returned with 10 entries per page. You can filter nodes by node name keyword and node status.
        /// The response includes TaskList and PageInfo. Duration indicates the execution duration in seconds. CreditsUsed indicates the number of Credits used. Nodes that have not started may not have a start time or duration, and nodes that have not finished may not have a completion time. All UNIX timestamps are in UNIX seconds. You can transform them to the time zone of the invoker for display.</para>
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
        /// <para>Queries the details of a single vulnerability under the current account without triggering a scan or vulnerability verification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a specified single vulnerability under the current account by using OperationInput.VulnId and returns a VulnDetail object. This operation only reads existing vulnerability data, does not create scan or verification tasks, and does not support batch queries by using TaskId or VulnIds. You can call DescribePentestVulnList to obtain vulnerability IDs and then query the details of each vulnerability. The caller identity is determined by the gateway, and you cannot specify other accounts through request parameters.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribePentestVulnDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestVulnDetailResponse
        /// </returns>
        public DescribePentestVulnDetailResponse DescribePentestVulnDetailWithOptions(DescribePentestVulnDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePentestVulnDetailShrinkRequest request = new DescribePentestVulnDetailShrinkRequest();
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
                Action = "DescribePentestVulnDetail",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePentestVulnDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a single vulnerability under the current account without triggering a scan or vulnerability verification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a specified single vulnerability under the current account by using OperationInput.VulnId and returns a VulnDetail object. This operation only reads existing vulnerability data, does not create scan or verification tasks, and does not support batch queries by using TaskId or VulnIds. You can call DescribePentestVulnList to obtain vulnerability IDs and then query the details of each vulnerability. The caller identity is determined by the gateway, and you cannot specify other accounts through request parameters.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribePentestVulnDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestVulnDetailResponse
        /// </returns>
        public async Task<DescribePentestVulnDetailResponse> DescribePentestVulnDetailWithOptionsAsync(DescribePentestVulnDetailRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePentestVulnDetailShrinkRequest request = new DescribePentestVulnDetailShrinkRequest();
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
                Action = "DescribePentestVulnDetail",
                Version = "2026-06-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePentestVulnDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a single vulnerability under the current account without triggering a scan or vulnerability verification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a specified single vulnerability under the current account by using OperationInput.VulnId and returns a VulnDetail object. This operation only reads existing vulnerability data, does not create scan or verification tasks, and does not support batch queries by using TaskId or VulnIds. You can call DescribePentestVulnList to obtain vulnerability IDs and then query the details of each vulnerability. The caller identity is determined by the gateway, and you cannot specify other accounts through request parameters.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePentestVulnDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestVulnDetailResponse
        /// </returns>
        public DescribePentestVulnDetailResponse DescribePentestVulnDetail(DescribePentestVulnDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePentestVulnDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a single vulnerability under the current account without triggering a scan or vulnerability verification.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a specified single vulnerability under the current account by using OperationInput.VulnId and returns a VulnDetail object. This operation only reads existing vulnerability data, does not create scan or verification tasks, and does not support batch queries by using TaskId or VulnIds. You can call DescribePentestVulnList to obtain vulnerability IDs and then query the details of each vulnerability. The caller identity is determined by the gateway, and you cannot specify other accounts through request parameters.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribePentestVulnDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePentestVulnDetailResponse
        /// </returns>
        public async Task<DescribePentestVulnDetailResponse> DescribePentestVulnDetailAsync(DescribePentestVulnDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePentestVulnDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the penetration testing vulnerabilities of the current account by task ID with pagination. Returns information such as the vulnerability title, severity, authentication status, affected URLs, and discovery time, and supports filtering by severity.</para>
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
        /// <para>Queries the penetration testing vulnerabilities of the current account by task ID with pagination. Returns information such as the vulnerability title, severity, authentication status, affected URLs, and discovery time, and supports filtering by severity.</para>
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
        /// <para>Queries the penetration testing vulnerabilities of the current account by task ID with pagination. Returns information such as the vulnerability title, severity, authentication status, affected URLs, and discovery time, and supports filtering by severity.</para>
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
        /// <para>Queries the penetration testing vulnerabilities of the current account by task ID with pagination. Returns information such as the vulnerability title, severity, authentication status, affected URLs, and discovery time, and supports filtering by severity.</para>
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
