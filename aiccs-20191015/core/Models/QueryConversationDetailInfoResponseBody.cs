// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryConversationDetailInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Access Denied</para>
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
        public QueryConversationDetailInfoResponseBodyData Data { get; set; }
        public class QueryConversationDetailInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("ConversationRecord")]
            [Validation(Required=false)]
            public string ConversationRecord { get; set; }

            [NameInMap("OutputTags")]
            [Validation(Required=false)]
            public List<QueryConversationDetailInfoResponseBodyDataOutputTags> OutputTags { get; set; }
            public class QueryConversationDetailInfoResponseBodyDataOutputTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>d7f3e92b-7947-4c20-bf37-ef66fc71007b</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("OutputTagDescription")]
                [Validation(Required=false)]
                public string OutputTagDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("OutputTagName")]
                [Validation(Required=false)]
                public string OutputTagName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("OutputTagValue")]
                [Validation(Required=false)]
                public string OutputTagValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1212131231231</para>
            /// </summary>
            [NameInMap("PickUpTime")]
            [Validation(Required=false)]
            public long? PickUpTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https://********</para>
            /// </summary>
            [NameInMap("RecordingFileDownloadUrl")]
            [Validation(Required=false)]
            public string RecordingFileDownloadUrl { get; set; }

            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<QueryConversationDetailInfoResponseBodyDataVariables> Variables { get; set; }
            public class QueryConversationDetailInfoResponseBodyDataVariables : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F2051E18-FF3F-5C08-8D24-6F150D2AF757</para>
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
