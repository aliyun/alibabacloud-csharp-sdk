// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MaintenanceWindow : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3h</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>03:00:00Z</para>
        /// </summary>
        [NameInMap("maintenance_time")]
        [Validation(Required=false)]
        public string MaintenanceTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FREQ=WEEKLY;INTERVAL=4;BYDAY=MO,TU</para>
        /// </summary>
        [NameInMap("recurrence")]
        [Validation(Required=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Monday,Thursday</para>
        /// </summary>
        [NameInMap("weekly_period")]
        [Validation(Required=false)]
        public string WeeklyPeriod { get; set; }

    }

}
