// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListPoliciesForGroupResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public ListPoliciesForGroupResponseBodyPolicies Policies { get; set; }
        public class ListPoliciesForGroupResponseBodyPolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public List<ListPoliciesForGroupResponseBodyPoliciesPolicy> Policy { get; set; }
            public class ListPoliciesForGroupResponseBodyPoliciesPolicy : TeaModel {
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
