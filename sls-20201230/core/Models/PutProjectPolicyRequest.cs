// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutProjectPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The project policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ 	&quot;Version&quot;: &quot;1&quot;, 	&quot;Statement&quot;: [{ 		&quot;Action&quot;: [&quot;log:PostLogStoreLogs&quot;], 		&quot;Resource&quot;: &quot;acs:log:<em>:</em>:project/exampleproject/<em>&quot;, 		&quot;Effect&quot;: &quot;Deny&quot;, 		&quot;Condition&quot;: { 			&quot;StringNotLike&quot;: { 				&quot;acs:SourceVpc&quot;: [&quot;vpc-</em>&quot;] 			} 		} 	}] }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
