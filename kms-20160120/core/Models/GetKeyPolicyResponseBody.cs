// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKeyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: [&quot;kms:<em>&quot;],&quot;Effect&quot;: &quot;Allow&quot;,&quot;Principal&quot;: {&quot;RAM&quot;: [&quot;acs:ram::190325303126</em><b><em>:</em>&quot;,&quot;acs:ram::119285303511</b>**:<em>&quot;]},&quot;Resource&quot;: [&quot;</em>&quot;],&quot;Sid&quot;: &quot;kms default key policy&quot;}],&quot;Version&quot;: &quot;1&quot; }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>381D5D33-BB8F-395F-8EE4-AE3B84B523C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
