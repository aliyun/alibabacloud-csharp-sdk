// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MaintenanceWindow : TeaModel {
        /// <summary>
        /// <para>The duration of the cluster maintenance window. </para>
        /// <para>Valid values: 1 to 24. </para>
        /// <para>Unit: hours.</para>
        /// <para>Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3h</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the cluster maintenance window. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the cluster maintenance window.</description></item>
        /// <item><description><c>false</c>: disables the cluster maintenance window.</description></item>
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
        /// <para>The start time of the cluster maintenance window. The value follows a standard time format in Golang. Example: 15:04:05Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03:00:00Z</para>
        /// </summary>
        [NameInMap("maintenance_time")]
        [Validation(Required=false)]
        public string MaintenanceTime { get; set; }

        /// <summary>
        /// <para>Defines a maintenance window recurrence rule by using the RFC5545 recurrence rule. Currently, only FREQ=WEEKLY is supported, and you cannot specify COUNT or UNTIL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FREQ=WEEKLY;INTERVAL=4;BYDAY=MO,TU</para>
        /// </summary>
        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// <para>The day of the week when maintenance is performed. Separate multiple days with commas (,). </para>
        /// <para>Valid values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday.</para>
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
