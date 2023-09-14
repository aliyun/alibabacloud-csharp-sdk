// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListAutoScalingActivitiesRequest : TeaModel {
        /// <summary>
        /// 集群ID。
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 查询伸缩活动创建时间的结束时间戳。单位为毫秒。
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 一次获取的最大记录数。取值范围：1~100。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 标记当前开始读取的位置，置空表示从头开始。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// 伸缩活动状态。数组元数个数N的取值范围：1~20。默认取值：
        /// - REJECTED：拒绝。
        /// - SUCCESSFUL：成功。
        /// - FAILED：失败。
        /// - IN_PROGRESS：进行中。
        /// </summary>
        [NameInMap("ScalingActivityStates")]
        [Validation(Required=false)]
        public List<string> ScalingActivityStates { get; set; }

        /// <summary>
        /// 伸缩活动类型。数组元数个数N的取值范围：1~20。取值范围：
        /// - SCALE_OUT：扩容。
        /// - SCALE_IN：缩容。
        /// </summary>
        [NameInMap("ScalingActivityType")]
        [Validation(Required=false)]
        public string ScalingActivityType { get; set; }

        /// <summary>
        /// 伸缩规则名称。
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// 查询伸缩活动创建时间的时间戳。单位为毫秒。
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
