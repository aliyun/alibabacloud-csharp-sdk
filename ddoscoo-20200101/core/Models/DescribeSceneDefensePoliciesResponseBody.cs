// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSceneDefensePoliciesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the configurations of the scenario-specific custom policy.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeSceneDefensePoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeSceneDefensePoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The execution status of the policy. Valid values:
            /// 
            /// *   **1**: not executed or execution completed
            /// *   **0**: being executed
            /// *   **-1**: execution failed
            /// </summary>
            [NameInMap("Done")]
            [Validation(Required=false)]
            public int? Done { get; set; }

            /// <summary>
            /// The time at which the policy expires. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of objects that are protected by the policy.
            /// </summary>
            [NameInMap("ObjectCount")]
            [Validation(Required=false)]
            public int? ObjectCount { get; set; }

            /// <summary>
            /// The ID of the policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The running rules of the policy.
            /// </summary>
            [NameInMap("RuntimePolicies")]
            [Validation(Required=false)]
            public List<DescribeSceneDefensePoliciesResponseBodyPoliciesRuntimePolicies> RuntimePolicies { get; set; }
            public class DescribeSceneDefensePoliciesResponseBodyPoliciesRuntimePolicies : TeaModel {
                /// <summary>
                /// The protection rule that is applied when the policy takes effect.
                /// 
                /// If you set **PolicyType** to **1**, the value is **{"cc_rule_enable": false }**. The value indicates that the Frequency Control policy is disabled.
                /// 
                /// If you set **PolicyType** to **2**, the value is **{"ai_rule_enable": 0}**. The value indicates that the Intelligent Protection policy is disabled.
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// The protection policy whose status is changed when the policy takes effect. Valid values:
                /// 
                /// *   **1**: indicates that the Frequency Control policy is changed.
                /// *   **2**: indicates that the Intelligent Protection policy is changed.
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public int? PolicyType { get; set; }

                /// <summary>
                /// The running status of the policy. Valid values:
                /// 
                /// *   **0**: The policy has not been issued or is restored.
                /// *   **1**: The policy is pending.
                /// *   **2**: The policy is being restored.
                /// *   **3**: The policy takes effect.
                /// *   **4**: The policy fails to take effect.
                /// *   **5**:The policy fails to be restored.
                /// *   **6**: The configurations of the protected objects for the policy does not exist because the configurations may be deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The protection rule that is applied before the policy takes effect.
                /// 
                /// If you set **PolicyType** to **1**, the value is **{"cc_rule_enable": true}**. The value indicates that the Frequency Control policy is enabled.
                /// 
                /// If you set **PolicyType** to **2**, the value is **{"ai_rule_enable": 1}**. The value indicates that the Intelligent Protection policy is enabled.
                /// </summary>
                [NameInMap("oldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

            }

            /// <summary>
            /// The time at which the policy takes effect. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the policy. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: pending enabling
            /// *   **2**: enabled
            /// *   **3**: expired
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The type of the template that is used to create the policy. Valid values:
            /// 
            /// *   **promotion**: the Important Activity template
            /// *   **bypass**: the Forward All template
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
