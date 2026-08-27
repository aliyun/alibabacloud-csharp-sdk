// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetPolicyVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The version information of the access policy.</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public GetPolicyVersionResponseBodyPolicyVersion PolicyVersion { get; set; }
        public class GetPolicyVersionResponseBodyPolicyVersion : TeaModel {
            /// <summary>
            /// <para>The time when the version was created. The time is in UTC and in the format of <c>YYYY-MM-DDThh:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefaultVersion")]
            [Validation(Required=false)]
            public bool? IsDefaultVersion { get; set; }

            /// <summary>
            /// <para>The policy document of the permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;Statement&quot;: [{ &quot;Action&quot;: [&quot;oss:<em>&quot;], &quot;Effect&quot;: &quot;Allow&quot;, &quot;Resource&quot;: [&quot;acs:oss:</em>:<em>:</em>&quot;]}], &quot;Version&quot;: &quot;1&quot;}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The ID of the access policy version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v3</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B34724D-54B0-4A51-B34D-4512372FE1BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
