// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateScheduledTaskRequest : TeaModel {
        /// <summary>
        /// <para>The description of the scheduled inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>定时RDS实例巡检任务</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The inspection frequency. Use commas (,) to separate multiple values. The default is DAILY. Valid values:</para>
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
        /// <h3>Note: DAILY overrides weekly values. For example, if you enter DAILY,Monday, the system uses DAILY as the inspection frequency.</h3>
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
        /// <para>The IDs of the instances for the task. Use commas (,) to separate multiple IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze6mk259v322****,rm-2zef3b65430j0****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the scheduled inspection task. The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS巡检</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The report language. The default value is zh-CN. Supported values: zh-CN, zh-TW, ja-JP, and en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the region where the report is stored.</para>
        /// </summary>
        [NameInMap("ReportRegionId")]
        [Validation(Required=false)]
        public string ReportRegionId { get; set; }

        /// <summary>
        /// <para>The type of the report.</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The execution time for the scheduled inspection task. Specify the time in the HH:mm:ssZ format (UTC time). The default is 02:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time range of data to inspect, in hours. Valid values are from 1 to 168 (7 days). The default is 24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
