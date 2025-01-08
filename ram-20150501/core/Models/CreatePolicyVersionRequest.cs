// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreatePolicyVersionRequest : TeaModel {
        /// <summary>
        /// <para>The document of the policy. The document can be up to 6,144 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;:[{&quot;Action&quot;:[&quot;oss:<em>&quot;],&quot;Effect&quot;:&quot;Allow&quot;,&quot;Resource&quot;:[&quot;acs:oss:</em>:<em>:</em>&quot;]}],&quot;Version&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS-Administrator</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The rotation strategy of the policy. The rotation strategy can be used to delete an early policy version.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>None</c>: disables the rotation strategy.</description></item>
        /// <item><description><c>DeleteOldestNonDefaultVersionWhenLimitExceeded</c>: deletes the earliest non-active version if the number of versions exceeds the limit.</description></item>
        /// </list>
        /// <para>Default value: <c>None</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("RotateStrategy")]
        [Validation(Required=false)]
        public string RotateStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to set this policy as the default policy. Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SetAsDefault")]
        [Validation(Required=false)]
        public bool? SetAsDefault { get; set; }

    }

}
