// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
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
                [NameInMap("AttachmentCount")]
                [Validation(Required=false)]
                public string AttachmentCount { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EffectScope")]
                [Validation(Required=false)]
                public string EffectScope { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

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
