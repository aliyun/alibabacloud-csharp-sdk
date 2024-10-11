// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRecentCallDetailRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRecentCallDetailRecordsResponseBodyData Data { get; set; }
        public class ListRecentCallDetailRecordsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRecentCallDetailRecordsResponseBodyDataList> List { get; set; }
            public class ListRecentCallDetailRecordsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentIds")]
                [Validation(Required=false)]
                public string AgentIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("CallDuration")]
                [Validation(Required=false)]
                public string CallDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1332315****</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ContactDisposition")]
                [Validation(Required=false)]
                public string ContactDisposition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-7660472242845****</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Outbound</para>
                /// </summary>
                [NameInMap("ContactType")]
                [Validation(Required=false)]
                public string ContactType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupIds")]
                [Validation(Required=false)]
                public string SkillGroupIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1532448000000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
