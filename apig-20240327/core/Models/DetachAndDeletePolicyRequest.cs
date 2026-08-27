// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DetachAndDeletePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy association ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pr-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("policyAttachmentId")]
        [Validation(Required=false)]
        public string PolicyAttachmentId { get; set; }

    }

}
