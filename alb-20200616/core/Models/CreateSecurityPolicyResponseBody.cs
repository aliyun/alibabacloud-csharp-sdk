// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateSecurityPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scp-bp1bpn0kn9****</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

    }

}
