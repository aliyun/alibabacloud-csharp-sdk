// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallDetailPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiCallDetailPageResponseBodyData Data { get; set; }
        public class QueryAiCallDetailPageResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAiCallDetailPageResponseBodyDataList> List { get; set; }
            public class QueryAiCallDetailPageResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12121211111*****</para>
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public string BatchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CallResult")]
                [Validation(Required=false)]
                public string CallResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0537101****</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1748948749000</para>
                /// </summary>
                [NameInMap("CallingTime")]
                [Validation(Required=false)]
                public long? CallingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ConversationDuration")]
                [Validation(Required=false)]
                public long? ConversationDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("ConversationRecord")]
                [Validation(Required=false)]
                public string ConversationRecord { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ConversationTurnCount")]
                [Validation(Required=false)]
                public long? ConversationTurnCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12121211111*****</para>
                /// </summary>
                [NameInMap("DetailId")]
                [Validation(Required=false)]
                public string DetailId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("FailedReason")]
                [Validation(Required=false)]
                public string FailedReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1748948749000</para>
                /// </summary>
                [NameInMap("ImportedTime")]
                [Validation(Required=false)]
                public long? ImportedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("MajorIntent")]
                [Validation(Required=false)]
                public string MajorIntent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>https://*******</para>
                /// </summary>
                [NameInMap("RecordingFilePath")]
                [Validation(Required=false)]
                public string RecordingFilePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12121211111*****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A57441B2-8EB6-5B93-9F37-0A51B8E2C9F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
