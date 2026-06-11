// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EffectTimeRange : TeaModel {
        /// <summary>
        /// <para>The values 0 to 6 indicate Sunday to Saturday.</para>
        /// </summary>
        [NameInMap("dayInWeek")]
        [Validation(Required=false)]
        public List<int?> DayInWeek { get; set; }

        /// <summary>
        /// <para>The end time in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("endTimeInMinute")]
        [Validation(Required=false)]
        public int? EndTimeInMinute { get; set; }

        /// <summary>
        /// <para>The start time in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("startTimeInMinute")]
        [Validation(Required=false)]
        public int? StartTimeInMinute { get; set; }

        /// <summary>
        /// <para>The time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Asia/Shanghai&quot;</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
