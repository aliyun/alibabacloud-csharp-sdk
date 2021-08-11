// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPolicyAttachmentsForTargetResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ControlPolicyAttachments")]
        [Validation(Required=false)]
        public ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachments ControlPolicyAttachments { get; set; }
        public class ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachments : TeaModel {
            [NameInMap("ControlPolicyAttachment")]
            [Validation(Required=false)]
            public List<ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachmentsControlPolicyAttachment> ControlPolicyAttachment { get; set; }
            public class ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachmentsControlPolicyAttachment : TeaModel {
                public string Description { get; set; }
                public string EffectScope { get; set; }
                public string PolicyName { get; set; }
                public string PolicyId { get; set; }
                public string AttachDate { get; set; }
                public string PolicyType { get; set; }
            }
        };

    }

}
