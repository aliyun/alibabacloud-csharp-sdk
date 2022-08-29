// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListPoliciesForUserResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public ListPoliciesForUserResponseBodyPolicies Policies { get; set; }
        public class ListPoliciesForUserResponseBodyPolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public List<ListPoliciesForUserResponseBodyPoliciesPolicy> Policy { get; set; }
            public class ListPoliciesForUserResponseBodyPoliciesPolicy : TeaModel {
                public string AttachDate { get; set; }
                public string DefaultVersion { get; set; }
                public string Description { get; set; }
                public string PolicyName { get; set; }
                public string PolicyType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
