// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RealtimeDialogAssistResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RealtimeDialogAssistResponseBodyData Data { get; set; }
        public class RealtimeDialogAssistResponseBodyData : TeaModel {
            [NameInMap("analysisProcess")]
            [Validation(Required=false)]
            public string AnalysisProcess { get; set; }

            [NameInMap("assistScripts")]
            [Validation(Required=false)]
            public List<RealtimeDialogAssistResponseBodyDataAssistScripts> AssistScripts { get; set; }
            public class RealtimeDialogAssistResponseBodyDataAssistScripts : TeaModel {
                [NameInMap("assistScript")]
                [Validation(Required=false)]
                public string AssistScript { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1920005488515465216</para>
                /// </summary>
                [NameInMap("intentCode")]
                [Validation(Required=false)]
                public string IntentCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("intentLabels")]
                [Validation(Required=false)]
                public string IntentLabels { get; set; }

                [NameInMap("intentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                [NameInMap("isDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

            }

            [NameInMap("assistSop")]
            [Validation(Required=false)]
            public List<RealtimeDialogAssistResponseBodyDataAssistSop> AssistSop { get; set; }
            public class RealtimeDialogAssistResponseBodyDataAssistSop : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("assistSop")]
                [Validation(Required=false)]
                public string AssistSop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("intentCode")]
                [Validation(Required=false)]
                public string IntentCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("intentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                [NameInMap("isDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

            }

            [NameInMap("conversationModel")]
            [Validation(Required=false)]
            public List<RealtimeDialogAssistResponseBodyDataConversationModel> ConversationModel { get; set; }
            public class RealtimeDialogAssistResponseBodyDataConversationModel : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>98457834685635</para>
                /// </summary>
                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1374683645635</para>
                /// </summary>
                [NameInMap("customerServiceId")]
                [Validation(Required=false)]
                public string CustomerServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("customerServiceType")]
                [Validation(Required=false)]
                public string CustomerServiceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0FC6636E-380A-5369-AE01-D1C15BB9B254</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1915593248420413441</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67C7021A-D268-553D-8C15-A087B9604028</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
