// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPolicyAttachmentsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PolicyAttachments")]
        [Validation(Required=false)]
        public ListPolicyAttachmentsResponseBodyPolicyAttachments PolicyAttachments { get; set; }
        public class ListPolicyAttachmentsResponseBodyPolicyAttachments : TeaModel {
            [NameInMap("PolicyAttachment")]
            [Validation(Required=false)]
            public List<ListPolicyAttachmentsResponseBodyPolicyAttachmentsPolicyAttachment> PolicyAttachment { get; set; }
            public class ListPolicyAttachmentsResponseBodyPolicyAttachmentsPolicyAttachment : TeaModel {
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                [NameInMap("PrincipalName")]
                [Validation(Required=false)]
                public string PrincipalName { get; set; }

                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
