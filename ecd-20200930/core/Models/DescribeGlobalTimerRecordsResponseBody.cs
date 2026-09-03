// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGlobalTimerRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6mnFXZiT7NdvGNgkInJ****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63740E03-1B4B-5A18-AC27-2745A4F2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DescribeGlobalTimerRecordsResponseBodyResults> Results { get; set; }
        public class DescribeGlobalTimerRecordsResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The type of action that was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REBOOT</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The batch ID of the scheduled task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccg-0cvfvf6u1enx1****</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            /// <summary>
            /// <para>The record information during the execution of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <para>The time when the record was created.
            /// The time is in the ISO 8601 standard in UTC: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-03T08:27:29Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-0c951fy9arnk9****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DesktopName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The display result name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKIPPED</para>
            /// </summary>
            [NameInMap("DisplayResultName")]
            [Validation(Required=false)]
            public string DisplayResultName { get; set; }

            /// <summary>
            /// <para>The time when the task ended.
            /// The time follows the ISO 8601 standard in UTC: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-21T02:00:45Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource parent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-xxx</para>
            /// </summary>
            [NameInMap("ResourceParentId")]
            [Validation(Required=false)]
            public string ResourceParentId { get; set; }

            /// <summary>
            /// <para>Specifies whether the task can be retried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Retryable")]
            [Validation(Required=false)]
            public bool? Retryable { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccg-xxxx</para>
            /// </summary>
            [NameInMap("TimerGroupId")]
            [Validation(Required=false)]
            public string TimerGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-xxx</para>
            /// </summary>
            [NameInMap("TimerRecordId")]
            [Validation(Required=false)]
            public string TimerRecordId { get; set; }

            /// <summary>
            /// <para>The execution result of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("TimerResult")]
            [Validation(Required=false)]
            public string TimerResult { get; set; }

            /// <summary>
            /// <para>The type of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TimerBoot</para>
            /// </summary>
            [NameInMap("TimerType")]
            [Validation(Required=false)]
            public string TimerType { get; set; }

        }

    }

}
