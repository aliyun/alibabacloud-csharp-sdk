// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MaintenanceWindow : TeaModel {
        /// <summary>
        /// <para>The maintenance duration. Valid values: 1 to 24. Unit: hours.</para>
        /// <para>Default value: 3h.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3h</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the maintenance window. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enables the maintenance window.</description></item>
        /// <item><description><c>false</c>: Does not enable the maintenance window.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The list of exclusions for the maintenance window. A maximum of 10 exclusions are supported. Exclusions take precedence over the maintenance window. If an active exclusion covers an O&amp;M type, the O&amp;M operation is not performed even if the current time is within the maintenance window. If multiple exclusions are active at the same time, the union of the exclusions is applied. The total number of NoOperations and NoUpgrades exclusions cannot exceed 3. Only one-time periods are supported. Periodic configurations are not supported.</para>
        /// </summary>
        [NameInMap("exclusions")]
        [Validation(Required=false)]
        public List<MaintenanceWindowExclusions> Exclusions { get; set; }
        public class MaintenanceWindowExclusions : TeaModel {
            /// <summary>
            /// <para>The description of the exclusion. The description can be up to 128 characters in length and does not support 4-byte characters such as emojis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No changes are allowed during the change freeze period</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The end time of the exclusion. The time must be in the RFC 3339 standard format, later than the start_time, and later than the current time. Maximum duration for a single exclusion: 30 days for NoOperations, NoUpgrades, and NoCVEPatch, and 180 days for NoMinorUpgrades.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-15T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The name of the exclusion. The name must be 1 to 63 characters in length and can contain digits, underscores (_), and hyphens (-). It must start with an uppercase or lowercase letter, a Chinese character, or a digit. The name must be unique within the same maintenance window. If you do not specify this parameter, a default name in the format of exclusion-{random string} is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exclusion-holiday</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The scope of the exclusion, which specifies the proactive O&amp;M types that are prohibited during this time period. Valid values (case-sensitive):</para>
            /// <list type="bullet">
            /// <item><description>NoOperations: Prohibits all proactive O&amp;M operations, including cluster upgrades, component upgrades, CVE patching, and OS image updates.</description></item>
            /// <item><description>NoUpgrades: Prohibits cluster upgrades and component upgrades, but still allows CVE patching and responses to scheduled ECS events.</description></item>
            /// <item><description>NoMinorUpgrades: Prohibits only minor version upgrades for clusters, but still allows patch upgrades, component upgrades, and CVE patching.</description></item>
            /// <item><description>NoCVEPatch: Prohibits automatic CVE patching.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoOperations</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The start time of the exclusion. The time must be in the RFC 3339 standard format and use the same time zone offset as the end_time and maintenance_time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-01T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The start time of the maintenance window. The time must be in the RFC 3339 standard format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-15T12:31:00.000+08:00</para>
        /// </summary>
        [NameInMap("maintenance_time")]
        [Validation(Required=false)]
        public string MaintenanceTime { get; set; }

        /// <summary>
        /// <para>The recurrence rule for the maintenance window, defined by using the RFC 5545 Recurrence Rule syntax. Only FREQ=WEEKLY is supported. COUNT and UNTIL are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FREQ=WEEKLY;INTERVAL=4;BYDAY=MO,TU</para>
        /// </summary>
        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// <para>The weekly maintenance period. Separate multiple values with commas (,). Valid values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday.</para>
        /// <para>Default value: <c>Thursday</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Thursday</para>
        /// </summary>
        [NameInMap("weekly_period")]
        [Validation(Required=false)]
        public string WeeklyPeriod { get; set; }

    }

}
