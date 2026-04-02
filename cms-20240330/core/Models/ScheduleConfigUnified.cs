// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ScheduleConfigUnified : TeaModel {
        /// <summary>
        /// <para>调度间隔（秒），type=FIXED 时使用</para>
        /// </summary>
        [NameInMap("intervalSecs")]
        [Validation(Required=false)]
        public int? IntervalSecs { get; set; }

        /// <summary>
        /// <para>调度类型</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
