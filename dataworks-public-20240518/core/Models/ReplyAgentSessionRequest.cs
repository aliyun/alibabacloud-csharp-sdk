// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ReplyAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC correlation ID for the current reply request. It is returned as-is in the response and is different from PermissionRequestId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reply-rpc-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. Fixed to 2.0.</para>
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
            /// <para>The answers to ask_user_question. The key is a 0-based string index of the question, and the value is the answer text. Fill in each question one by one for multiple questions. Omit this parameter for general tool authorization or cancellation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;0&quot;:&quot;lakehouse_uat&quot;}</para>
            /// </summary>
            [NameInMap("Answers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Answers { get; set; }

            /// <summary>
            /// <para>The processing result of the user for the current interaction.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Outcome")]
            [Validation(Required=false)]
            public ReplyAgentSessionRequestParamsOutcome Outcome { get; set; }
            public class ReplyAgentSessionRequestParamsOutcome : TeaModel {
                /// <summary>
                /// <para>Required and cannot be empty when Outcome is selected. It takes the optionId of the actual option in the options of the current event (when submitting an answer, the option with kind=allow_once is usually selected). Omit this parameter when Outcome is cancelled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>option-from-event</para>
                /// </summary>
                [NameInMap("OptionId")]
                [Validation(Required=false)]
                public string OptionId { get; set; }

                /// <summary>
                /// <para>The processing type. selected indicates that an option is selected, and cancelled indicates that the user explicitly cancels the interaction.</para>
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
            /// <para>The identifier of the current permission_request. It is obtained from _qwen/notify.params.data.requestId of the original SSE, and is not ToolCallId, HTTP RequestId, or the current JSON-RPC Id. It cannot be . or ..</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>permission-001</para>
            /// </summary>
            [NameInMap("PermissionRequestId")]
            [Validation(Required=false)]
            public string PermissionRequestId { get; set; }

            /// <summary>
            /// <para>The LSP session ID. Use the SessionId returned when creating the session, not the internal session ID of the daemon.</para>
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
