// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeAlertActionPoliciesResponseBody : TeaModel {
        [NameInMap("ActionPolicyList")]
        [Validation(Required=false)]
        public List<DescribeAlertActionPoliciesResponseBodyActionPolicyList> ActionPolicyList { get; set; }
        public class DescribeAlertActionPoliciesResponseBodyActionPolicyList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("PageTotal")]
        [Validation(Required=false)]
        public int? PageTotal { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
