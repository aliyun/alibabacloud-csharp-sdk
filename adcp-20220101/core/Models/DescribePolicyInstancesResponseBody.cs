// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribePolicyInstancesResponseBody : TeaModel {
        /// <summary>
        /// A list of policy instances.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribePolicyInstancesResponseBodyPolicies> Policies { get; set; }
        public class DescribePolicyInstancesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The ID of the associated cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the policy instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The action of the policy. Valid values:
            /// 
            /// *   deny: blocks deployments that match the policy.
            /// *   warn: generates alerts for deployments that match the policy.
            /// </summary>
            [NameInMap("PolicyAction")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

            /// <summary>
            /// The type of the policy.
            /// </summary>
            [NameInMap("PolicyCategory")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            /// <summary>
            /// The description of the policy.
            /// </summary>
            [NameInMap("PolicyDescription")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The parameters of the policy instance.
            /// </summary>
            [NameInMap("PolicyParameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> PolicyParameters { get; set; }

            /// <summary>
            /// The applicable scope of the policy instance.
            /// 
            /// A value of \\* indicates all namespaces. This is the default value.
            /// 
            /// Multiple namespaces are separated by commas (,).
            /// </summary>
            [NameInMap("PolicyScope")]
            [Validation(Required=false)]
            public string PolicyScope { get; set; }

            /// <summary>
            /// The severity level of the policy.
            /// </summary>
            [NameInMap("PolicySeverity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

            /// <summary>
            /// The total number of deployments that match the policy in the associated cluster, including the deployments that are blocked and the deployments that have triggered alerting.
            /// </summary>
            [NameInMap("TotalViolations")]
            [Validation(Required=false)]
            public long? TotalViolations { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
