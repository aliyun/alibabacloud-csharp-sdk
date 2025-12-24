// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGlobalTimerRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
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
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DescribeGlobalTimerRecordsResponseBodyResults> Results { get; set; }
        public class DescribeGlobalTimerRecordsResponseBodyResults : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The ID of the batch in which the scheduled task is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccg-0cvfvf6u1enx1****</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <para>The time when the execution record was created.</para>
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
            /// <para>The cloud computer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DesktopName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("DisplayResultName")]
            [Validation(Required=false)]
            public string DisplayResultName { get; set; }

            /// <summary>
            /// <para>The time when the scheduled task ended.</para>
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
