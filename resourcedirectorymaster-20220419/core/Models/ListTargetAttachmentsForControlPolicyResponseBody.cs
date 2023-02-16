// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListTargetAttachmentsForControlPolicyResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TargetAttachments")]
        [Validation(Required=false)]
        public ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachments TargetAttachments { get; set; }
        public class ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachments : TeaModel {
            [NameInMap("TargetAttachment")]
            [Validation(Required=false)]
            public List<ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachmentsTargetAttachment> TargetAttachment { get; set; }
            public class ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachmentsTargetAttachment : TeaModel {
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
