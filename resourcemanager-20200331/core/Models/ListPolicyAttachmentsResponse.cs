// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPolicyAttachmentsResponse : TeaModel {
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

        [NameInMap("PolicyAttachments")]
        [Validation(Required=true)]
        public ListPolicyAttachmentsResponsePolicyAttachments PolicyAttachments { get; set; }
        public class ListPolicyAttachmentsResponsePolicyAttachments : TeaModel {
            [NameInMap("PolicyAttachment")]
            [Validation(Required=true)]
            public List<ListPolicyAttachmentsResponsePolicyAttachmentsPolicyAttachment> PolicyAttachment { get; set; }
            public class ListPolicyAttachmentsResponsePolicyAttachmentsPolicyAttachment : TeaModel {
                public string ResourceGroupId { get; set; }
                public string PolicyType { get; set; }
                public string PolicyName { get; set; }
                public string PrincipalType { get; set; }
                public string PrincipalName { get; set; }
                public string AttachDate { get; set; }
                public string Description { get; set; }
            }
        };

    }

}
