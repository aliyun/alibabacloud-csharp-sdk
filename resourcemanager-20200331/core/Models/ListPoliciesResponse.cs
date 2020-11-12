// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPoliciesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Policies")]
        [Validation(Required=true)]
        public ListPoliciesResponsePolicies Policies { get; set; }
        public class ListPoliciesResponsePolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=true)]
            public List<ListPoliciesResponsePoliciesPolicy> Policy { get; set; }
            public class ListPoliciesResponsePoliciesPolicy : TeaModel {
                public string PolicyName { get; set; }
                public string PolicyType { get; set; }
                public string Description { get; set; }
                public string DefaultVersion { get; set; }
                public string CreateDate { get; set; }
                public string UpdateDate { get; set; }
                public int? AttachmentCount { get; set; }
            }
        };

    }

}
