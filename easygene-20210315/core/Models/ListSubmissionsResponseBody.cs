// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListSubmissionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TestToken</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Submissions")]
        [Validation(Required=false)]
        public List<ListSubmissionsResponseBodySubmissions> Submissions { get; set; }
        public class ListSubmissionsResponseBodySubmissions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-06-16T15:09:14.378297+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-06-16T15:09:14.378297+08:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestEntityType</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("RunStats")]
            [Validation(Required=false)]
            public ListSubmissionsResponseBodySubmissionsRunStats RunStats { get; set; }
            public class ListSubmissionsResponseBodySubmissionsRunStats : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Aborted")]
                [Validation(Required=false)]
                public long? Aborted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Aborting")]
                [Validation(Required=false)]
                public long? Aborting { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Pending")]
                [Validation(Required=false)]
                public long? Pending { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Running")]
                [Validation(Required=false)]
                public long? Running { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Submitted")]
                [Validation(Required=false)]
                public long? Submitted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-06-16T15:09:14.378297+08:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sub-13BeXWnGvrOl3MC124tazcJVKaV</para>
            /// </summary>
            [NameInMap("SubmissionId")]
            [Validation(Required=false)]
            public string SubmissionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestWorkspace</para>
            /// </summary>
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
