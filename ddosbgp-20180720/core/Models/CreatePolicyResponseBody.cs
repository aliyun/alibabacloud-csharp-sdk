// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class CreatePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83967609-7ea5-4f6d-a6ea-380b09e****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>864FE2F4-CB2E-4024-B9EF-D59FD08A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
