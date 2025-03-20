// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateConditionalAccessPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Conditional Access Policy ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp_xxxxx</para>
        /// </summary>
        [NameInMap("ConditionalAccessPolicyId")]
        [Validation(Required=false)]
        public string ConditionalAccessPolicyId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
