// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPoliciesResponseBody : TeaModel {
        [NameInMap("ControlPolicies")]
        [Validation(Required=false)]
        public ListControlPoliciesResponseBodyControlPolicies ControlPolicies { get; set; }
        public class ListControlPoliciesResponseBodyControlPolicies : TeaModel {
            [NameInMap("ControlPolicy")]
            [Validation(Required=false)]
            public List<ListControlPoliciesResponseBodyControlPoliciesControlPolicy> ControlPolicy { get; set; }
            public class ListControlPoliciesResponseBodyControlPoliciesControlPolicy : TeaModel {
                public string AttachmentCount { get; set; }
                public string CreateDate { get; set; }
                public string Description { get; set; }
                public string EffectScope { get; set; }
                public string PolicyId { get; set; }
                public string PolicyName { get; set; }
                public string PolicyType { get; set; }
                public string UpdateDate { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
