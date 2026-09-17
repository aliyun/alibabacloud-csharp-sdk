// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ScheduleConfigUnified : TeaModel {
        /// <summary>
        /// <para>The scheduling interval in seconds. This parameter is used when type is set to FIXED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("intervalSecs")]
        [Validation(Required=false)]
        public int? IntervalSecs { get; set; }

        /// <summary>
        /// <para>The type of the scheduling configuration. FIXED indicates fixed-interval scheduling, which executes periodically based on the interval specified by intervalSecs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FIXED</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
