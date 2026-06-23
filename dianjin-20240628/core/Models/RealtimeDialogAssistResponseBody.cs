// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RealtimeDialogAssistResponseBody : TeaModel {
        /// <summary>
        /// <para>Time consumed</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RealtimeDialogAssistResponseBodyData Data { get; set; }
        public class RealtimeDialogAssistResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Analysis process</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户回答的内容与提供的意图列表描述均不匹配，没有表达出对账单、还款、天气或其他服务的具体需求或问题。</para>
            /// </summary>
            [NameInMap("analysisProcess")]
            [Validation(Required=false)]
            public string AnalysisProcess { get; set; }

            /// <summary>
            /// <para>List of dialog assist results</para>
            /// </summary>
            [NameInMap("assistScripts")]
            [Validation(Required=false)]
            public List<RealtimeDialogAssistResponseBodyDataAssistScripts> AssistScripts { get; set; }
            public class RealtimeDialogAssistResponseBodyDataAssistScripts : TeaModel {
                /// <summary>
                /// <para>Recommended utterance</para>
                /// 
                /// <b>Example:</b>
                /// <para>可按照SOP流程回应。</para>
                /// </summary>
                [NameInMap("assistScript")]
                [Validation(Required=false)]
                public string AssistScript { get; set; }

                /// <summary>
                /// <para>Intent encoding</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;1920005488515465216&quot;</para>
                /// </summary>
                [NameInMap("intentCode")]
                [Validation(Required=false)]
                public string IntentCode { get; set; }

                /// <summary>
                /// <para>Intent labels</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("intentLabels")]
                [Validation(Required=false)]
                public string IntentLabels { get; set; }

                /// <summary>
                /// <para>Intent name</para>
                /// 
                /// <b>Example:</b>
                /// <para>礼貌问答</para>
                /// </summary>
                [NameInMap("intentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                /// <summary>
                /// <para>Whether intent escaped</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

            }

            /// <summary>
            /// <para>List of flow assist results</para>
            /// </summary>
            [NameInMap("assistSop")]
            [Validation(Required=false)]
            public List<RealtimeDialogAssistResponseBodyDataAssistSop> AssistSop { get; set; }
            public class RealtimeDialogAssistResponseBodyDataAssistSop : TeaModel {
                /// <summary>
                /// <para>Recommended flow</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("assistSop")]
                [Validation(Required=false)]
                public string AssistSop { get; set; }

                /// <summary>
                /// <para>Intent encoding</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("intentCode")]
                [Validation(Required=false)]
                public string IntentCode { get; set; }

                /// <summary>
                /// <para>Intent name</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("intentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                /// <summary>
                /// <para>Indicates whether the intent is to escape.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

            }

            /// <summary>
            /// <para>Current dialog content</para>
            /// </summary>
            [NameInMap("conversationModel")]
            [Validation(Required=false)]
            public List<RealtimeDialogAssistResponseBodyDataConversationModel> ConversationModel { get; set; }
            public class RealtimeDialogAssistResponseBodyDataConversationModel : TeaModel {
                /// <summary>
                /// <para>Specific content of the dialog</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Unique identity of the dialog role</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;98457834685635&quot;</para>
                /// </summary>
                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                /// <summary>
                /// <para>Customer service ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;1374683645635&quot;</para>
                /// </summary>
                [NameInMap("customerServiceId")]
                [Validation(Required=false)]
                public string CustomerServiceId { get; set; }

                /// <summary>
                /// <para>Agent type. 0: Robot, 1: Human.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;0&quot;</para>
                /// </summary>
                [NameInMap("customerServiceType")]
                [Validation(Required=false)]
                public string CustomerServiceType { get; set; }

                /// <summary>
                /// <para>Role. 0 indicates customer, 1 indicates agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;0&quot;</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>Type of dialog content</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Whether interrupted</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("interrupt")]
            [Validation(Required=false)]
            public bool? Interrupt { get; set; }

            /// <summary>
            /// <para>Unique request ID. This request ID matches the request ID in the input parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0FC6636E-380A-5369-AE01-D1C15BB9B254</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;1915593248420413441&quot;</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID. This is the system-recorded request ID. If issues arise, provide this ID to the Model Studio DianJin R\&amp;D team for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67C7021A-D268-553D-8C15-A087B9604028</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
