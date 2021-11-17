// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class CreateInstanceShutdownTimerRequest : TeaModel {
        /// <summary>
        /// 定时关机时间（GMT）
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// 多少毫秒后定时关机（如果设定可以覆盖ScheduleTime）
        /// </summary>
        [NameInMap("TtlInMillis")]
        [Validation(Required=false)]
        public long? TtlInMillis { get; set; }

    }

}
