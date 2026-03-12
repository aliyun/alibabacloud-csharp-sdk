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
        /// <para>The number of records returned on each page.</para>
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
        /// <para>The list of scheduled inspection tasks.</para>
        /// </summary>
        [NameInMap("Schedules")]
        [Validation(Required=false)]
        public List<ListScheduledTasksResponseBodySchedules> Schedules { get; set; }
        public class ListScheduledTasksResponseBodySchedules : TeaModel {
            /// <summary>
            /// <para>The creation time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-04T06:51:24Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the inspection task.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The new inspection frequency. Separate multiple values with commas (,). Default value: DAILY. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DAILY</description></item>
            /// <item><description>Monday</description></item>
            /// <item><description>Tuesday</description></item>
            /// <item><description>Wednesday</description></item>
            /// <item><description>Thursday</description></item>
            /// <item><description>Friday</description></item>
            /// <item><description>Saturday</description></item>
            /// <item><description>Sunday</description></item>
            /// </list>
            /// <h3><a href="#daily--dailymonday--daily-"></a>Note: DAILY takes precedence over other values. For example, if you set this parameter to DAILY,Monday, the backend will use DAILY as the inspection frequency.</h3>
            /// 
            /// <b>Example:</b>
            /// <para>Monday</para>
            /// </summary>
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public string Frequency { get; set; }

            /// <summary>
            /// <para>The number of instances covered by the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ReportLanguage")]
            [Validation(Required=false)]
            public string ReportLanguage { get; set; }

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
            /// <para>The actual start time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

            /// <summary>
            /// <para>The inspection time range. The default value is the latest 24 hours. Valid values: 1 to 168. The maximum value is 7 days.</para>
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
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
