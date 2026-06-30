// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyScheduledTaskRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the inspection configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>定时RDS实例巡检任务</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new inspection frequency. Separate multiple values with a comma (,). The default value is DAILY. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DAILY: Every day</para>
        /// </description></item>
        /// <item><description><para>Monday: Every Monday</para>
        /// </description></item>
        /// <item><description><para>Tuesday: Every Tuesday</para>
        /// </description></item>
        /// <item><description><para>Wednesday: Every Wednesday</para>
        /// </description></item>
        /// <item><description><para>Thursday: Every Thursday</para>
        /// </description></item>
        /// <item><description><para>Friday: Every Friday</para>
        /// </description></item>
        /// <item><description><para>Saturday: Every Saturday</para>
        /// </description></item>
        /// <item><description><para>Sunday: Every Sunday</para>
        /// </description></item>
        /// </list>
        /// <h3>Note: <c>DAILY</c> overrides all other day-of-the-week settings. For example, if you specify <c>DAILY,Monday</c>, the system uses <c>DAILY</c> as the inspection frequency.</h3>
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
        /// <para>The new instance IDs to associate with the task. Separate multiple IDs with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze6mk259v322****,rm-2zef3b65430j0****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The new name of the inspection configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS巡检任务</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled inspection configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>847268a4-196f-416b-aa12-bfe0c115****</para>
        /// </summary>
        [NameInMap("ScheduledId")]
        [Validation(Required=false)]
        public string ScheduledId { get; set; }

        /// <summary>
        /// <para>The new time to run the inspection task. The time must be in the <c>HH:mm:ssZ</c> format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The inspection time range in hours. The default is 24, which means data from the last 24 hours is inspected. Valid values: 1 to 168. The maximum supported range is 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
