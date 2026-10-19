// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInspectionScheduleReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The task data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInspectionScheduleReportsResponseBodyData Data { get; set; }
        public class DescribeInspectionScheduleReportsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task items.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInspectionScheduleReportsResponseBodyDataItems> Items { get; set; }
            public class DescribeInspectionScheduleReportsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The creation time of the task.</para>
                /// <para>The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1773211755000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The end time of the task.</para>
                /// <para>The time is displayed in the YYYY-MM-DDTHH:mm:ssZ format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-29T02:12:02Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The completion time of the task.</para>
                /// <para>The time is displayed in the ISO 8601 format with an explicit time zone offset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-16T13:52:35+08:00</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The summary of risk levels in the inspection results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;Normal\&quot;:10,\&quot;Warning\&quot;:0,\&quot;Error\&quot;:0,\&quot;Failed\&quot;:0}</para>
                /// </summary>
                [NameInMap("LevelSummary")]
                [Validation(Required=false)]
                public string LevelSummary { get; set; }

                /// <summary>
                /// <para>The language of the report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>en-US</para>
                /// </summary>
                [NameInMap("ReportLanguage")]
                [Validation(Required=false)]
                public string ReportLanguage { get; set; }

                /// <summary>
                /// <para>The start time of the task.</para>
                /// <para>The time is displayed in the YYYY-MM-DDTHH:mmZ format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-09-26T21:10Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the inspection task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-0mqomahp4o4uf3aicu</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The returned page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The page size. Default value: 25.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A057C066-C3F5-4CC9-9FE4-A8D8B0DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
