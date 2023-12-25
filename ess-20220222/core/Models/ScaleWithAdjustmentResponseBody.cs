// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentResponseBody : TeaModel {
        /// <summary>
        /// 伸缩活动的类型。
        /// 
        /// 当ActivityType为CapacityChange时，表示返回值ScalingActivityId对应伸缩活动仅修改伸缩组期望实例数，没有立刻执行扩缩。适用范围：期望实例数类型伸缩组。
        /// </summary>
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the scaling activity.
        /// </summary>
        [NameInMap("ScalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

    }

}
