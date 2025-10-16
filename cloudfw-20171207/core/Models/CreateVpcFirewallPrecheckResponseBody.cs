// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateVpcFirewallPrecheckResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4197</para>
        /// </summary>
        [NameInMap("PrecheckId")]
        [Validation(Required=false)]
        public string PrecheckId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C5BE1AA4-934A-5085-89CC-9AD1CAC3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
