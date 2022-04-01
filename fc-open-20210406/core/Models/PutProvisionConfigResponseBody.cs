// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutProvisionConfigResponseBody : TeaModel {
        /// <summary>
        /// 是否始终分配CPU给函数实例。
        /// </summary>
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        /// <summary>
        /// 实际资源个数
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// 资源描述
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// 定时策略配置
        /// </summary>
        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledActions> ScheduledActions { get; set; }

        /// <summary>
        /// 目标资源个数
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

        /// <summary>
        /// 指标追踪伸缩策略配置
        /// </summary>
        [NameInMap("targetTrackingPolicies")]
        [Validation(Required=false)]
        public List<TargetTrackingPolicies> TargetTrackingPolicies { get; set; }

    }

}
