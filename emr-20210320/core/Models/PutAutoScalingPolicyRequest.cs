// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class PutAutoScalingPolicyRequest : TeaModel {
        /// <summary>
        /// 集群ID。
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 最大最小值约束。
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public ScalingConstraints Constraints { get; set; }

        /// <summary>
        /// 节点组ID。节点组 Id-针对 ACK 集群，此字段为空。
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// 区域ID。
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 弹性伸缩规则描述列表。
        /// <p>
        /// </summary>
        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public List<ScalingRule> ScalingRules { get; set; }

    }

}
