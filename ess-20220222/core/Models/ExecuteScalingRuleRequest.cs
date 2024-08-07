// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ExecuteScalingRuleRequest : TeaModel {
        /// <summary>
        /// The threshold specified when the step scaling rule is executed. Valid values: -9.999999E18 to 9.999999E18.
        /// </summary>
        [NameInMap("BreachThreshold")]
        [Validation(Required=false)]
        public float? BreachThreshold { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/25965.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The metric value specified when the step scaling rule is executed. Valid values: -9.999999E18 to 9.999999E18.
        /// </summary>
        [NameInMap("MetricValue")]
        [Validation(Required=false)]
        public float? MetricValue { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the scaling group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The unique identifier of the scaling rule.
        /// 
        /// >  You can call this operation to execute simple scaling rules and step scaling rules. If you want to call this operation to execute a step scaling rule, you must specify `BreachThreshold` and `MetricValue`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingRuleAri")]
        [Validation(Required=false)]
        public string ScalingRuleAri { get; set; }

    }

}
