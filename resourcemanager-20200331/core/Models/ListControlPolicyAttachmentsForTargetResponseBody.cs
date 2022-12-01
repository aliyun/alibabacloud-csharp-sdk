// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPolicyAttachmentsForTargetResponseBody : TeaModel {
        [NameInMap("ControlPolicyAttachments")]
        [Validation(Required=false)]
        public ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachments ControlPolicyAttachments { get; set; }
        public class ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachments : TeaModel {
            [NameInMap("ControlPolicyAttachment")]
            [Validation(Required=false)]
            public List<ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachmentsControlPolicyAttachment> ControlPolicyAttachment { get; set; }
            public class ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachmentsControlPolicyAttachment : TeaModel {
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

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

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
