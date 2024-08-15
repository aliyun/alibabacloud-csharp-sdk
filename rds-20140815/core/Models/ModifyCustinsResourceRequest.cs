// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyCustinsResourceRequest : TeaModel {
        /// <summary>
        /// The deadline for the modification.
        /// </summary>
        [NameInMap("AdjustDeadline")]
        [Validation(Required=false)]
        public string AdjustDeadline { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/26232.html) operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The increase rate in percentage.
        /// </summary>
        [NameInMap("IncreaseRatio")]
        [Validation(Required=false)]
        public string IncreaseRatio { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The resource type.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The original value. This parameter must be specified when the **ResourceType** parameter is set to **instance**.
        /// </summary>
        [NameInMap("RestoreOriginalSpecification")]
        [Validation(Required=false)]
        public string RestoreOriginalSpecification { get; set; }

        /// <summary>
        /// The target value. This parameter is available only if you set the ScalingRuleType parameter to TargetTrackingScalingRule or PredictiveScalingRule. The value must be greater than 0 and can contain up to three decimal places.
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public int? TargetValue { get; set; }

    }

}
