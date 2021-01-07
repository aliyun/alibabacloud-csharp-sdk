// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListPoliciesForRoleResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public ListPoliciesForRoleResponseBodyPolicies Policies { get; set; }
        public class ListPoliciesForRoleResponseBodyPolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public List<ListPoliciesForRoleResponseBodyPoliciesPolicy> Policy { get; set; }
            public class ListPoliciesForRoleResponseBodyPoliciesPolicy : TeaModel {
                public string DefaultVersion { get; set; }
                public string Description { get; set; }
                public string PolicyName { get; set; }
                public string AttachDate { get; set; }
                public string PolicyType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
