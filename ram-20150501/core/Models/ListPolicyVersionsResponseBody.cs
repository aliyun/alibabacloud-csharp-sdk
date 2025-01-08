// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListPolicyVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the policy versions.</para>
        /// </summary>
        [NameInMap("PolicyVersions")]
        [Validation(Required=false)]
        public ListPolicyVersionsResponseBodyPolicyVersions PolicyVersions { get; set; }
        public class ListPolicyVersionsResponseBodyPolicyVersions : TeaModel {
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public List<ListPolicyVersionsResponseBodyPolicyVersionsPolicyVersion> PolicyVersion { get; set; }
            public class ListPolicyVersionsResponseBodyPolicyVersionsPolicyVersion : TeaModel {
                /// <summary>
                /// <para>The time when the version was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-02-26T01:25:52Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>Indicates whether the version is the default version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefaultVersion")]
                [Validation(Required=false)]
                public bool? IsDefaultVersion { get; set; }

                /// <summary>
                /// <para>The script of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;Statement&quot;: [{ &quot;Action&quot;: [&quot;oss:<em>&quot;], &quot;Effect&quot;: &quot;Allow&quot;, &quot;Resource&quot;: [&quot;acs:oss:</em>:<em>:</em>&quot;]}], &quot;Version&quot;: &quot;1&quot;}</para>
                /// </summary>
                [NameInMap("PolicyDocument")]
                [Validation(Required=false)]
                public string PolicyDocument { get; set; }

                /// <summary>
                /// <para>The ID of the version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v3</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B8A4E7D-6CFF-471D-84DF-195A7A241ECB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
