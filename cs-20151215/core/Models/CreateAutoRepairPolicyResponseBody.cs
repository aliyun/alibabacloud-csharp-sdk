// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoRepairPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>r-xxxxxxx</para>
        /// </summary>
        [NameInMap("policy_id")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E368C761-F8F6-4A36-9B58-BD53D5******</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
