// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyCustinsResourceRequest : TeaModel {
        /// <summary>
        /// AdjustDeadline
        /// </summary>
        [NameInMap("AdjustDeadline")]
        [Validation(Required=false)]
        public string AdjustDeadline { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// IncreaseRatio
        /// </summary>
        [NameInMap("IncreaseRatio")]
        [Validation(Required=false)]
        public string IncreaseRatio { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the resource. Set the value to **INSTANCE**.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// RestoreOriginalSpecification
        /// </summary>
        [NameInMap("RestoreOriginalSpecification")]
        [Validation(Required=false)]
        public string RestoreOriginalSpecification { get; set; }

        /// <summary>
        /// Specifies whether to disable scale-in. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule.
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public int? TargetValue { get; set; }

    }

}
