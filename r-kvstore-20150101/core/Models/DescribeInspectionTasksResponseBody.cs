// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInspectionTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The task data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInspectionTasksResponseBodyData Data { get; set; }
        public class DescribeInspectionTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of tasks.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInspectionTasksResponseBodyDataItems> Items { get; set; }
            public class DescribeInspectionTasksResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The time when the task was created.</para>
                /// <para>The time is displayed in UTC time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-07-01T02:06:34Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The end time of the task.</para>
                /// <para>The time is displayed in UTC time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-09-23T00:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The completion time of the task.</para>
                /// <para>The time is displayed in UTC time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-09T02:13:01Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The specified inspection items. The following inspection items are supported:</para>
                /// <list type="bullet">
                /// <item><description>RESOURCE_USAGE</description></item>
                /// <item><description>BIGKEY</description></item>
                /// <item><description>HOTKEY</description></item>
                /// <item><description>PERFORMANCE_METRICS</description></item>
                /// <item><description>SLOWLOG</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PERFORMANCE_METRICS</para>
                /// </summary>
                [NameInMap("InspectionItems")]
                [Validation(Required=false)]
                public string InspectionItems { get; set; }

                /// <summary>
                /// <para>The list of associated instance IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-uf6ns8txov3mp9jxxx</para>
                /// </summary>
                [NameInMap("InstanceIds")]
                [Validation(Required=false)]
                public string InstanceIds { get; set; }

                /// <summary>
                /// <para>The language of the report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh-CN</para>
                /// </summary>
                [NameInMap("ReportLanguage")]
                [Validation(Required=false)]
                public string ReportLanguage { get; set; }

                /// <summary>
                /// <para>The ID of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sch-4dfb08ddf9f84855bacca35axxx</para>
                /// </summary>
                [NameInMap("ScheduleId")]
                [Validation(Required=false)]
                public string ScheduleId { get; set; }

                /// <summary>
                /// <para>The source of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scheduler|</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The start time of the task.</para>
                /// <para>The time is displayed in UTC time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-30T02:11:01Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCEEDED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tit-dca42f85c73644e0ab5c80ef641xxx</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D9F3768-EDA9-4811-943E-42C8006E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
