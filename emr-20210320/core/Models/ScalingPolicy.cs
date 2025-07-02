// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingPolicy : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public ManagedScalingConstraints Constraints { get; set; }

        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        [NameInMap("ScalingPolicyId")]
        [Validation(Required=false)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AUTO / MANAGED</para>
        /// </summary>
        [NameInMap("ScalingPolicyType")]
        [Validation(Required=false)]
        public string ScalingPolicyType { get; set; }

        [NameInMap("ScalingRules")]
        [Validation(Required=false)]
        public List<ScalingRule> ScalingRules { get; set; }

    }

}
