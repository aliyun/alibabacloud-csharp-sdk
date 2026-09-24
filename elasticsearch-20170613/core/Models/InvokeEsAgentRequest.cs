// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InvokeEsAgentRequest : TeaModel {
        /// <summary>
        /// <para>The request body in JSON-RPC 2.0 format.</para>
        /// <para>Common request parameters (all at the top level of the request body, not inside params):</para>
        /// <list type="bullet">
        /// <item><description>jsonrpc: String. Required. The JSON-RPC version. Fixed value: 2.0. Example: 2.0.</description></item>
        /// <item><description>method: String. Required. The method to call. For valid values, see the method list below. Example: session/prompt.</description></item>
        /// <item><description>id: String. Optional. The request ID specified by the caller. This value is passed through in the response. Example: 1774339902987004.</description></item>
        /// <item><description>params: Object. Optional. The parameters for the specified method. For examples, refer to the supplementary description.</description></item>
        /// <item><description>sessionCode: String. Optional. The session ID for exact match queries in session/list. Example: 49b82154-ac20-4f27-a6ec-eb5f4cfc5304.</description></item>
        /// <item><description>pageNum: Integer. Optional. The page number for session/list. Default value is handled by the server. Example: 1.</description></item>
        /// <item><description>pageSize: Integer. Optional. The number of entries per page for session/list. Default value is handled by the server. Example: 10.</description></item>
        /// </list>
        /// <para>Valid values of method:</para>
        /// <list type="bullet">
        /// <item><description>session/new: Creates a session. Returns JSON.</description></item>
        /// <item><description>session/list: Queries the session list or a specified session. Returns JSON.</description></item>
        /// <item><description>session/prompt: Sends a message. Returns SSE.</description></item>
        /// <item><description>session/load: Resumes from a breakpoint. Used only when _meta.isReload=true. Returns SSE.</description></item>
        /// <item><description>session/cancel: Cancels in-progress tasks in a session. Returns JSON.</description></item>
        /// <item><description>session/delete: Deletes a session. Returns JSON.</description></item>
        /// <item><description>session/hitlRespond: Submits a HITL user response. Returns JSON.</description></item>
        /// </list>
        /// <para>Response modes: session/prompt and session/load return an SSE event stream with Content-Type text/event-stream. Each event is in the format data: {JSON}. Other methods return a standard JSON response with Content-Type application/json.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;jsonrpc&quot;: &quot;2.0&quot;,
        ///   &quot;id&quot;: 5,
        ///   &quot;method&quot;: &quot;session/list&quot;,
        ///   &quot;params&quot;: {},
        ///   &quot;pageNum&quot;: 1,
        ///   &quot;pageSize&quot;: 10
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

    }

}
