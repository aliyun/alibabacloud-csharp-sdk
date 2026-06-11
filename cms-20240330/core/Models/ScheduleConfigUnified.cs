// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ScheduleConfigUnified : TeaModel {
        /// <summary>
        /// <para>The interval between scheduled runs, in seconds.</para>
        /// </summary>
        [NameInMap("intervalSecs")]
        [Validation(Required=false)]
        public int? IntervalSecs { get; set; }

        /// <summary>
        /// <para>The type of the schedule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
