// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetAutoScalingActivityResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingActivity")]
        [Validation(Required=false)]
        public GetAutoScalingActivityResponseBodyScalingActivity ScalingActivity { get; set; }
        public class GetAutoScalingActivityResponseBodyScalingActivity : TeaModel {
            /// <summary>
            /// 伸缩活动ID。
            /// </summary>
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// 本次伸缩活动对应的实例列表。
            /// </summary>
            [NameInMap("ActivityResults")]
            [Validation(Required=false)]
            public List<ScalingActivityResult> ActivityResults { get; set; }

            /// <summary>
            /// 伸缩活动状态。取值范围：
            /// - REJECTED：拒绝
            /// - SUCCESSFUL：成功
            /// - FAILED：失败
            /// - IN_PROGRESS：进行中
            /// </summary>
            [NameInMap("ActivityState")]
            [Validation(Required=false)]
            public string ActivityState { get; set; }

            /// <summary>
            /// 伸缩活动类型。取值范围：
            /// - SCALE_IN：缩容
            /// - SCALE_OUT：扩容
            /// </summary>
            [NameInMap("ActivityType")]
            [Validation(Required=false)]
            public string ActivityType { get; set; }

            /// <summary>
            /// 集群ID。
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// 伸缩活动描述。
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 伸缩结束时间。
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 本次扩缩数量。
            /// </summary>
            [NameInMap("ExpectNum")]
            [Validation(Required=false)]
            public int? ExpectNum { get; set; }

            /// <summary>
            /// 节点组ID。
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// 节点组名称。
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// 操作ID。
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// 伸缩规则详述。
            /// </summary>
            [NameInMap("RuleDetail")]
            [Validation(Required=false)]
            public ScalingRule RuleDetail { get; set; }

            /// <summary>
            /// 伸缩规则名称。
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// 伸缩启动时间。
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
