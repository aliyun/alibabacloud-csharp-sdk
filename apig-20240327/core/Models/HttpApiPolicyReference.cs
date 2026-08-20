// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiPolicyReference : TeaModel {
        /// <summary>
        /// <para>The policy attachment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-3c8ayyy</para>
        /// </summary>
        [NameInMap("policyAttachmentId")]
        [Validation(Required=false)]
        public string PolicyAttachmentId { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pol-9f2exxx</para>
        /// </summary>
        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
