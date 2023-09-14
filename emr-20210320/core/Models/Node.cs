// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Node : TeaModel {
        /// <summary>
        /// 节点是否自动续费。
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// 节点自动续费时长。
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// 节点自动续费时长单位。
        /// </summary>
        [NameInMap("AutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string AutoRenewDurationUnit { get; set; }

        /// <summary>
        /// 节点过期时间。
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 实例类型。
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 运维模式状态。取值范围：
        /// - ON：处于运维模式。
        /// - OFF：处于非运维模式。
        /// 
        /// 为空表示处于非运维模式。
        /// </summary>
        [NameInMap("MaintenanceStatus")]
        [Validation(Required=false)]
        public string MaintenanceStatus { get; set; }

        /// <summary>
        /// 节点组ID。
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// 节点组类型。
        /// </summary>
        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        /// <summary>
        /// 节点ID。
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// 节点名称。
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// 节点状态。取值范围：
        /// - Pending：创建中。
        /// - Starting：启动中。
        /// - Running：运行中。
        /// - Stopping：停止中。
        /// - Stopped：已停止。
        /// - Terminated：已终止。
        /// </summary>
        [NameInMap("NodeState")]
        [Validation(Required=false)]
        public string NodeState { get; set; }

        /// <summary>
        /// 私网IP。
        /// </summary>
        [NameInMap("PrivateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 公网IP。
        /// </summary>
        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 可用区ID。
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
