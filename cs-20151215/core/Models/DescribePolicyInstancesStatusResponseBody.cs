// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesStatusResponseBody : TeaModel {
        /// <summary>
        /// The number of policy instances that are deployed in the cluster at different severity levels.
        /// </summary>
        [NameInMap("instances_severity_count")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstancesSeverityCount { get; set; }

        /// <summary>
        /// The number of policy instances of each policy type.
        /// </summary>
        [NameInMap("policy_instances")]
        [Validation(Required=false)]
        public List<DescribePolicyInstancesStatusResponseBodyPolicyInstances> PolicyInstances { get; set; }
        public class DescribePolicyInstancesStatusResponseBodyPolicyInstances : TeaModel {
            /// <summary>
            /// The type of the policy. For more information about different types of policies and their descriptions, see [Predefined security policies of ACK](https://help.aliyun.com/document_detail/359819.html).
            /// </summary>
            [NameInMap("policy_category")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            /// <summary>
            /// The description of the policy.
            /// </summary>
            [NameInMap("policy_description")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// The number of policy instances that are deployed. If this parameter is empty, no policy instance is deployed.
            /// </summary>
            [NameInMap("policy_instances_count")]
            [Validation(Required=false)]
            public long? PolicyInstancesCount { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("policy_name")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The severity level of the policy.
            /// </summary>
            [NameInMap("policy_severity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

        }

    }

}
