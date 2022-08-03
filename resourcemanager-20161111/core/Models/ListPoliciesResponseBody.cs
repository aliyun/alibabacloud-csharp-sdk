// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class ListPoliciesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Policies")]
        [Validation(Required=false)]
        public ListPoliciesResponseBodyPolicies Policies { get; set; }
        public class ListPoliciesResponseBodyPolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public List<ListPoliciesResponseBodyPoliciesPolicy> Policy { get; set; }
            public class ListPoliciesResponseBodyPoliciesPolicy : TeaModel {
                public int? AttachmentCount { get; set; }
                public string CreateDate { get; set; }
                public string DefaultVersion { get; set; }
                public string Description { get; set; }
                public string PolicyName { get; set; }
                public string PolicyType { get; set; }
                public string UpdateDate { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
