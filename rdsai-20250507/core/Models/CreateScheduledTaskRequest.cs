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
        /// <item><description>Saturday \*Sunday</description></item>
        /// </list>
        /// <h3><a href="#daily--dailymonday--daily-"></a>Note: DAILY takes precedence over other values. For example, if you enter DAILY,Monday, the backend uses DAILY as the inspection frequency.</h3>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The IDs of the related instances. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze6mk259v322****,rm-2zef3b65430j0****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the scheduled inspection task. The name cannot exceed 64 characters in length.</para>
        /// <para>This parameter is required.</para>
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

        [NameInMap("ReportRegionId")]
        [Validation(Required=false)]
        public string ReportRegionId { get; set; }

        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The time when the inspection task is executed. Specify the time in the ISO 8601 standard in the HH:mm:ssZ format. The time must be in UTC. Default value: 02:00 AM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The inspection time range. The default value is the latest 24 hours. Valid values: 1 to 168. The maximum value is 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
