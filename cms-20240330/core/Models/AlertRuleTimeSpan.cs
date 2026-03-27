// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleTimeSpan : TeaModel {
        /// <summary>
        /// <para>Day of the week.</para>
        /// </summary>
        [NameInMap("dayOfWeek")]
        [Validation(Required=false)]
        public List<int?> DayOfWeek { get; set; }

        /// <summary>
        /// <para>End time, in HH:mm format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Default time zone is Beijing Time: +0800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+0800</para>
        /// </summary>
        [NameInMap("gmtOffset")]
        [Validation(Required=false)]
        public string GmtOffset { get; set; }

        /// <summary>
        /// <para>Start time, in HH:mm format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
