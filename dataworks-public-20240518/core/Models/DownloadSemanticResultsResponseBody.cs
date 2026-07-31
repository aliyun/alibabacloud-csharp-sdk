// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DownloadSemanticResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of result files for the specified node run. Multiple items are returned if a single run generates multiple files.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DownloadSemanticResultsResponseBodyData Data { get; set; }
        public class DownloadSemanticResultsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of result files. Each item contains the associated node name, the associated run ID, and a short-lived download URL.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<DownloadSemanticResultsResponseBodyDataResults> Results { get; set; }
            public class DownloadSemanticResultsResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The temporary pre-signed download URL of the result file. Download the file by using an HTTP GET request as soon as possible. Do not log, share, or treat the full URL as a long-term address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/temporary-download-url">https://example.com/temporary-download-url</a></para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>The node name to which the artifact belongs. This value is the same as the JobName value in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic-job-demo</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The run ID to which the artifact belongs. You can compare this value with the Data.JobRunId value from the RunSemanticJob response or the JobRunId value from ListSemanticJobRuns.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01H00000000000000000000000</para>
                /// </summary>
                [NameInMap("JobRunId")]
                [Validation(Required=false)]
                public string JobRunId { get; set; }

            }

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
