// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddDnsFirewallPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f88dae6f-XXX-XXX-613de9ab2be8</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>71209DFE-XXX-XXX-52B4A4E9DA3B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
