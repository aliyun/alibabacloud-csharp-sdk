// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MaintenanceWindow : TeaModel {
        /// <summary>
        /// 是否开启维护窗口。默认值false。
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 维护起始时间。Golang标准时间格式"15:04:05Z"。
        /// </summary>
        [NameInMap("maintenance_time")]
        [Validation(Required=false)]
        public string MaintenanceTime { get; set; }

        /// <summary>
        /// 维护时长。取值范围1～24，单位为小时。 默认值：3h。
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// 维护周期。取值范围为:Monday~Sunday，多个值用逗号分隔。 默认值：Thursday。
        /// </summary>
        [NameInMap("weekly_period")]
        [Validation(Required=false)]
        public string WeeklyPeriod { get; set; }

    }

}
