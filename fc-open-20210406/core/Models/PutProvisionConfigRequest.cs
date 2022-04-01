// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutProvisionConfigRequest : TeaModel {
        /// <summary>
        /// 当实例进入空闲状态时，是否继续分配CPU。
        /// </summary>
        [NameInMap("alwaysAllocateCPU")]
        [Validation(Required=false)]
        public bool? AlwaysAllocateCPU { get; set; }

        /// <summary>
        /// 定时策略配置
        /// </summary>
        [NameInMap("scheduledActions")]
        [Validation(Required=false)]
        public List<ScheduledActions> ScheduledActions { get; set; }

        /// <summary>
        /// 预留的目标资源个数
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

        /// <summary>
        /// 别名名称
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
