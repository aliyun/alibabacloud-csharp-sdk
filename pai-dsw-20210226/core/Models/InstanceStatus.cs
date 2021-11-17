// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class InstanceStatus : TeaModel {
        /// <summary>
        /// 累计运行时间（分钟）
        /// </summary>
        [NameInMap("AccumulativeRunningTimeInMinutes")]
        [Validation(Required=false)]
        public long? AccumulativeRunningTimeInMinutes { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceShutdownTimer")]
        [Validation(Required=false)]
        public InstanceShutdownTimer InstanceShutdownTimer { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus_ { get; set; }

        /// <summary>
        /// 实例消息
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// 是否允许使用定时关机
        /// </summary>
        [NameInMap("ShutdownEnabled")]
        [Validation(Required=false)]
        public bool? ShutdownEnabled { get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
