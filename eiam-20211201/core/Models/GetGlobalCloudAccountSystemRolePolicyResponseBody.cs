// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetGlobalCloudAccountSystemRolePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The access policy document for the global cloud account system role (JSON character string).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[]}</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
