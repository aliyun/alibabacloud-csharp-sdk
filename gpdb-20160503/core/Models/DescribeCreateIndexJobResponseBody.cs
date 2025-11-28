// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeCreateIndexJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the index creation job.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public DescribeCreateIndexJobResponseBodyJob Job { get; set; }
        public class DescribeCreateIndexJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>Indicates whether the operation is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            /// <summary>
            /// <para>The job creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-08 16:52:04.864664</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message that is returned when the current operation is abnormal or fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to connect database.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231460f8-75dc-405e-a669-0c5204887e91</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The progress of the index creation job. Unit: %. A value of 100 indicates that the job is complete.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Only AnalyticDB for PostgreSQL V7.0 supports the Progress parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Success.</b></description></item>
            /// <item><description><b>Failed</b> (See the Error parameter for failure reasons).</description></item>
            /// <item><description><b>Cancelled.</b></description></item>
            /// <item><description>**Running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The job last updated time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-08 16:53:04.864664</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>.</description></item>
        /// <item><description><b>fail</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
