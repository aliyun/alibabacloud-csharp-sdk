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
        /// <para>Scheduled RDS instance inspection task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new inspection frequency. Separate multiple values with commas (,). Default value: DAILY. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAILY: every day</description></item>
        /// <item><description>Monday: Monday</description></item>
        /// <item><description>Tuesday: Tuesday</description></item>
        /// <item><description>Wednesday: Wednesday</description></item>
        /// <item><description>Thursday: Thursday</description></item>
        /// <item><description>Friday: Friday</description></item>
        /// <item><description>Saturday: Saturday</description></item>
        /// <item><description>Sunday: Sunday</description></item>
        /// </list>
        /// <h3>Note: DAILY overrides weekly values. For example, if you specify DAILY,Monday, the backend uses DAILY as the inspection frequency.</h3>
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
        /// <para>The new list of associated instances. Separate multiple values with commas (,).</para>
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
        /// <para>RDS inspection task</para>
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
        /// <para>The new time to execute the inspection task. Format: HH:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>02:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The inspection time range. Default value: the last 24 hours. Valid values: 1 to 168 (up to 7 days).</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
