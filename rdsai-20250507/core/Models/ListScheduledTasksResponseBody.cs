// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListScheduledTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务信息查询成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of scheduled inspection tasks.</para>
        /// </summary>
        [NameInMap("Schedules")]
        [Validation(Required=false)]
        public List<ListScheduledTasksResponseBodySchedules> Schedules { get; set; }
        public class ListScheduledTasksResponseBodySchedules : TeaModel {
            /// <summary>
            /// <para>The time the task was created, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-04T06:51:24Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the inspection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>每天凌晨2点自动巡检生产环境RDS实例</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The inspection frequency. Multiple values are separated by commas. The default is DAILY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DAILY: Every day</para>
            /// </description></item>
            /// <item><description><para>Monday: Monday</para>
            /// </description></item>
            /// <item><description><para>Tuesday: Tuesday</para>
            /// </description></item>
            /// <item><description><para>Wednesday: Wednesday</para>
            /// </description></item>
            /// <item><description><para>Thursday: Thursday</para>
            /// </description></item>
            /// <item><description><para>Friday: Friday</para>
            /// </description></item>
            /// <item><description><para>Saturday: Saturday</para>
            /// </description></item>
            /// <item><description><para>Sunday: Sunday</para>
            /// </description></item>
            /// </list>
            /// <h3>Note: The DAILY setting overrides any specified days of the week. For example, if you specify DAILY,Monday, the inspection runs daily.</h3>
            /// 
            /// <b>Example:</b>
            /// <para>Monday</para>
            /// </summary>
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public string Frequency { get; set; }

            [NameInMap("InspectionItems")]
            [Validation(Required=false)]
            public string InspectionItems { get; set; }

            /// <summary>
            /// <para>The number of instances in the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>巡检测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ReportLanguage")]
            [Validation(Required=false)]
            public string ReportLanguage { get; set; }

            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled inspection configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9d246af2-a0cd-4f69-857d-3785048f****</para>
            /// </summary>
            [NameInMap("ScheduledId")]
            [Validation(Required=false)]
            public string ScheduledId { get; set; }

            /// <summary>
            /// <para>The task start time, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

            /// <summary>
            /// <para>The inspection time range in hours. Default: 24. Valid values: 1 to 168.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24小时</para>
            /// </summary>
            [NameInMap("TimeRange")]
            [Validation(Required=false)]
            public string TimeRange { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
