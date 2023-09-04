// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListPermissionPoliciesInAccessConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The policies.
        /// </summary>
        [NameInMap("PermissionPolicies")]
        [Validation(Required=false)]
        public List<ListPermissionPoliciesInAccessConfigurationResponseBodyPermissionPolicies> PermissionPolicies { get; set; }
        public class ListPermissionPoliciesInAccessConfigurationResponseBodyPermissionPolicies : TeaModel {
            /// <summary>
            /// The time when the policy was created for the access configuration.
            /// </summary>
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public string AddTime { get; set; }

            /// <summary>
            /// The configurations of the inline policy.
            /// 
            /// >  This parameter is returned only when the value of the PermissionPolicyType parameter is Inline.
            /// </summary>
            [NameInMap("PermissionPolicyDocument")]
            [Validation(Required=false)]
            public string PermissionPolicyDocument { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("PermissionPolicyName")]
            [Validation(Required=false)]
            public string PermissionPolicyName { get; set; }

            /// <summary>
            /// The type of the policy.
            /// </summary>
            [NameInMap("PermissionPolicyType")]
            [Validation(Required=false)]
            public string PermissionPolicyType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of policies.
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
