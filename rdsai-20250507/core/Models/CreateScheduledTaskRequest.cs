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
        /// <para>Scheduled RDS instance inspection task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The inspection frequency. Separate multiple values with commas (,). Default value: DAILY. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAILY: every day.</description></item>
        /// <item><description>Monday: Monday.</description></item>
        /// <item><description>Tuesday: Tuesday.</description></item>
        /// <item><description>Wednesday: Wednesday.</description></item>
        /// <item><description>Thursday: Thursday.</description></item>
        /// <item><description>Friday: Friday.</description></item>
        /// <item><description>Saturday: Saturday.</description></item>
        /// <item><description>Sunday: Sunday.</description></item>
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
        /// <para>The list of associated instance IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze6mk259v322****,rm-2zef3b65430j0****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the scheduled inspection task. The name can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS Inspection</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The report language. Default value: zh-CN. Valid values: zh-CN, zh-TW, ja-JP, and en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        [NameInMap("ReportRegionId")]
        [Validation(Required=false)]
        public string ReportRegionId { get; set; }

        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The time to run the inspection task. Format: HH:mm:ssZ (UTC). Default value: 02:00:00Z.</para>
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
        /// <para>The time range for the inspection. Default value: the last 24 hours. Valid values: 1 to 168 (up to 7 days).</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
