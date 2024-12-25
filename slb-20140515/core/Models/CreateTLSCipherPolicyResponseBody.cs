// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateTLSCipherPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7A8875F-373A-5F48-8484-25B07A61F2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tls-bp14bb1e7dll4f****</para>
        /// </summary>
        [NameInMap("TLSCipherPolicyId")]
        [Validation(Required=false)]
        public string TLSCipherPolicyId { get; set; }

    }

}
