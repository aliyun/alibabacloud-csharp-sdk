// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ReplyAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC correlation ID for this reply request. The response returns this value as-is. This is different from PermissionRequestId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reply-rpc-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. Fixed value: 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The user interaction reply parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public ReplyAgentSessionRequestParams Params { get; set; }
        public class ReplyAgentSessionRequestParams : TeaModel {
            /// <summary>
            /// <para>The answers to ask_user_question. The key is a zero-based question index string, and the value is the answer text. Specify each answer for multiple questions. Omit this parameter for regular tool authorization or cancellation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;0&quot;:&quot;lakehouse_uat&quot;}</para>
            /// </summary>
            [NameInMap("Answers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Answers { get; set; }

            /// <summary>
            /// <para>The outcome of the user interaction.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Outcome")]
            [Validation(Required=false)]
            public ReplyAgentSessionRequestParamsOutcome Outcome { get; set; }
            public class ReplyAgentSessionRequestParamsOutcome : TeaModel {
                /// <summary>
                /// <para>Required and cannot be empty when Outcome is set to selected. Set this parameter to the optionId of an actual option in the event options. To submit an answer, select the option with kind=allow_once. Omit this parameter when Outcome is set to cancelled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>option-from-event</para>
                /// </summary>
                [NameInMap("OptionId")]
                [Validation(Required=false)]
                public string OptionId { get; set; }

                /// <summary>
                /// <para>The outcome type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>selected: An option is selected.</description></item>
                /// <item><description>cancelled: The user explicitly cancels the interaction.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>selected</para>
                /// </summary>
                [NameInMap("Outcome")]
                [Validation(Required=false)]
                public string Outcome { get; set; }

            }

            /// <summary>
            /// <para>The ID of the current permission_request. Obtain this value from _qwen/notify.params.data.requestId in the original SSE. This is not a ToolCallId, HTTP RequestId, or the JSON-RPC Id of this request. The value cannot be . or ..</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>permission-001</para>
            /// </summary>
            [NameInMap("PermissionRequestId")]
            [Validation(Required=false)]
            public string PermissionRequestId { get; set; }

            /// <summary>
            /// <para>The LSP session ID. Use the SessionId returned by the create session operation, not the daemon internal session ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsp-session-001</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

    }

}
