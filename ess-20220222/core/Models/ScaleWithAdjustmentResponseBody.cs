// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ScaleWithAdjustmentResponseBody : TeaModel {
        /// <summary>
        /// The type of the scaling activity.
        /// 
        /// If `ActivityType` is set to `CapacityChange`, only the expected number of instances is changed during the scaling activity specified by ScalingActivityId and no scale-out is triggered.
        /// 
        /// This parameter is applicable to only scaling groups that have an expected number of instances.
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
