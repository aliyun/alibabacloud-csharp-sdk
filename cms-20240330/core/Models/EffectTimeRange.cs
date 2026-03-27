// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EffectTimeRange : TeaModel {
        [NameInMap("dayInWeek")]
        [Validation(Required=false)]
        public List<int?> DayInWeek { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("endTimeInMinute")]
        [Validation(Required=false)]
        public int? EndTimeInMinute { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("startTimeInMinute")]
        [Validation(Required=false)]
        public int? StartTimeInMinute { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Asia/Shanghai&quot;</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
