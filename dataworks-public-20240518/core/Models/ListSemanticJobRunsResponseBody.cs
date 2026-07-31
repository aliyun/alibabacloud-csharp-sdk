// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSemanticJobRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated run record results. Use the JobRunId to download the results of a specific run, and use the ExecutorJobId to query details, logs, or stop a run.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSemanticJobRunsResponseBodyData Data { get; set; }
        public class ListSemanticJobRunsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of run records.</para>
            /// </summary>
            [NameInMap("JobRuns")]
            [Validation(Required=false)]
            public List<ListSemanticJobRunsResponseBodyDataJobRuns> JobRuns { get; set; }
            public class ListSemanticJobRunsResponseBodyDataJobRuns : TeaModel {
                /// <summary>
                /// <para>The executor job ID. Pass this value to the ExecutorJobId parameter of GetSemanticJobDetail, GetSemanticJobLog, or KillSemanticJob.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exec-job-demo</para>
                /// </summary>
                [NameInMap("ExecutorJobId")]
                [Validation(Required=false)]
                public string ExecutorJobId { get; set; }

                /// <summary>
                /// <para>The time when the run record was created. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1700000000000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The name of the job to which this run belongs. This value can be used to re-run the job, query run records, or download results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic-job-demo</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The semantic job run ID. Pass this value to the JobRunId parameter of DownloadSemanticResults to download the results of this run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01H00000000000000000000000</para>
                /// </summary>
                [NameInMap("JobRunId")]
                [Validation(Required=false)]
                public string JobRunId { get; set; }

                /// <summary>
                /// <para>The ID of the user who submitted this run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-demo</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The page number returned, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of run records that match the current job criteria.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676271D6-53B4-57BE-89FA-72F7AE1418DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
