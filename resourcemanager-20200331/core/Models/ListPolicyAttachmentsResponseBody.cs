// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPolicyAttachmentsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PolicyAttachments")]
        [Validation(Required=false)]
        public ListPolicyAttachmentsResponseBodyPolicyAttachments PolicyAttachments { get; set; }
        public class ListPolicyAttachmentsResponseBodyPolicyAttachments : TeaModel {
            [NameInMap("PolicyAttachment")]
            [Validation(Required=false)]
            public List<ListPolicyAttachmentsResponseBodyPolicyAttachmentsPolicyAttachment> PolicyAttachment { get; set; }
            public class ListPolicyAttachmentsResponseBodyPolicyAttachmentsPolicyAttachment : TeaModel {
                public string Description { get; set; }
                public string ResourceGroupId { get; set; }
                public string PolicyName { get; set; }
                public string PrincipalName { get; set; }
                public string AttachDate { get; set; }
                public string PolicyType { get; set; }
                public string PrincipalType { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
