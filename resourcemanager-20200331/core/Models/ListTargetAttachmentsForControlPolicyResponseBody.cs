// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTargetAttachmentsForControlPolicyResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TargetAttachments")]
        [Validation(Required=false)]
        public ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachments TargetAttachments { get; set; }
        public class ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachments : TeaModel {
            [NameInMap("TargetAttachment")]
            [Validation(Required=false)]
            public List<ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachmentsTargetAttachment> TargetAttachment { get; set; }
            public class ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachmentsTargetAttachment : TeaModel {
                public string TargetId { get; set; }
                public string TargetName { get; set; }
                public string AttachDate { get; set; }
                public string TargetType { get; set; }
            }
        };

    }

}
