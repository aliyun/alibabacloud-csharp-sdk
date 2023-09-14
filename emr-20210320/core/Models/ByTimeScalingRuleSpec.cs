// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ByTimeScalingRuleSpec : TeaModel {
        /// <summary>
        /// 重复执行定时任务的结束时间戳。单位为毫秒。
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 启动时间戳。单位为毫秒。
        /// </summary>
        [NameInMap("LaunchTime")]
        [Validation(Required=false)]
        public long? LaunchTime { get; set; }

        /// <summary>
        /// 指定时间规则的执行类型。
        /// </summary>
        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// 重复执行定时任务的数值。具体取值取决于 recurrenceType 设置。
        /// </summary>
        [NameInMap("RecurrenceValue")]
        [Validation(Required=false)]
        public string RecurrenceValue { get; set; }

    }

}
