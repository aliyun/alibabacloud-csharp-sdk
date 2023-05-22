// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribePolicyInstancesStatusResponseBody : TeaModel {
        /// <summary>
        /// The number of policy instances of each policy type.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public DescribePolicyInstancesStatusResponseBodyPolicies Policies { get; set; }
        public class DescribePolicyInstancesStatusResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The number of policy instances of each policy type.
            /// </summary>
            [NameInMap("PolicyInstances")]
            [Validation(Required=false)]
            public List<DescribePolicyInstancesStatusResponseBodyPoliciesPolicyInstances> PolicyInstances { get; set; }
            public class DescribePolicyInstancesStatusResponseBodyPoliciesPolicyInstances : TeaModel {
                /// <summary>
                /// The type of the policy.
                /// </summary>
                [NameInMap("PolicyCategory")]
                [Validation(Required=false)]
                public string PolicyCategory { get; set; }

                /// <summary>
                /// The associated clusters in which the policy instances are deployed.
                /// </summary>
                [NameInMap("PolicyClusters")]
                [Validation(Required=false)]
                public List<DescribePolicyInstancesStatusResponseBodyPoliciesPolicyInstancesPolicyClusters> PolicyClusters { get; set; }
                public class DescribePolicyInstancesStatusResponseBodyPoliciesPolicyInstancesPolicyClusters : TeaModel {
                    /// <summary>
                    /// The ID of the associated cluster.
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// The status of the deployment.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The description of the policy.
                /// </summary>
                [NameInMap("PolicyDescription")]
                [Validation(Required=false)]
                public string PolicyDescription { get; set; }

                /// <summary>
                /// The number of policy instances that are deployed. If this parameter is empty, no policy instance is deployed.
                /// </summary>
                [NameInMap("PolicyInstancesCount")]
                [Validation(Required=false)]
                public long? PolicyInstancesCount { get; set; }

                /// <summary>
                /// The name of the policy.
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// The severity level of the policy.
                /// </summary>
                [NameInMap("PolicySeverity")]
                [Validation(Required=false)]
                public string PolicySeverity { get; set; }

            }

            /// <summary>
            /// The number of policy instances that are deployed in the cluster.
            /// </summary>
            [NameInMap("SeverityInfo")]
            [Validation(Required=false)]
            public List<DescribePolicyInstancesStatusResponseBodyPoliciesSeverityInfo> SeverityInfo { get; set; }
            public class DescribePolicyInstancesStatusResponseBodyPoliciesSeverityInfo : TeaModel {
                /// <summary>
                /// The number of policy instances.
                /// </summary>
                [NameInMap("SeverityCount")]
                [Validation(Required=false)]
                public string SeverityCount { get; set; }

                /// <summary>
                /// The severity level.
                /// </summary>
                [NameInMap("SeverityType")]
                [Validation(Required=false)]
                public string SeverityType { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
