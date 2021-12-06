// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListPermissionPoliciesInAccessConfigurationResponseBody : TeaModel {
        [NameInMap("PermissionPolicies")]
        [Validation(Required=false)]
        public List<ListPermissionPoliciesInAccessConfigurationResponseBodyPermissionPolicies> PermissionPolicies { get; set; }
        public class ListPermissionPoliciesInAccessConfigurationResponseBodyPermissionPolicies : TeaModel {
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public string AddTime { get; set; }

            [NameInMap("PermissionPolicyDocument")]
            [Validation(Required=false)]
            public string PermissionPolicyDocument { get; set; }

            [NameInMap("PermissionPolicyName")]
            [Validation(Required=false)]
            public string PermissionPolicyName { get; set; }

            [NameInMap("PermissionPolicyType")]
            [Validation(Required=false)]
            public string PermissionPolicyType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
