// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class ListSparkJobAttemptResponseBody : TeaModel {
        [NameInMap("DataResult")]
        [Validation(Required=false)]
        public ListSparkJobAttemptResponseBodyDataResult DataResult { get; set; }
        public class ListSparkJobAttemptResponseBodyDataResult : TeaModel {
            [NameInMap("JobAttemptList")]
            [Validation(Required=false)]
            public List<ListSparkJobAttemptResponseBodyDataResultJobAttemptList> JobAttemptList { get; set; }
            public class ListSparkJobAttemptResponseBodyDataResultJobAttemptList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-05-27 23:22:08</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1622128928000</para>
                /// </summary>
                [NameInMap("CreateTimeValue")]
                [Validation(Required=false)]
                public string CreateTimeValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;xxx&quot;:&quot;xxx&quot;}</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00:01:12</para>
                /// </summary>
                [NameInMap("DurationTime")]
                [Validation(Required=false)]
                public string DurationTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>72000</para>
                /// </summary>
                [NameInMap("DurationTimeValue")]
                [Validation(Required=false)]
                public string DurationTimeValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>j202105272322hangzhou5d64f1560000128-0001</para>
                /// </summary>
                [NameInMap("JobAttemptId")]
                [Validation(Required=false)]
                public string JobAttemptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>j202105272322hangzhou5d64f1560000128</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("SparkUI")]
                [Validation(Required=false)]
                public string SparkUI { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-05-27 23:23:20</para>
                /// </summary>
                [NameInMap("TerminatedTime")]
                [Validation(Required=false)]
                public string TerminatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1622129000000</para>
                /// </summary>
                [NameInMap("TerminatedTimeValue")]
                [Validation(Required=false)]
                public string TerminatedTimeValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>release-test</para>
                /// </summary>
                [NameInMap("VcName")]
                [Validation(Required=false)]
                public string VcName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4A839055-70C7-423D-A6F2-E714EA4502DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
