// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The default version of the access policy.</para>
        /// </summary>
        [NameInMap("DefaultPolicyVersion")]
        [Validation(Required=false)]
        public GetPolicyResponseBodyDefaultPolicyVersion DefaultPolicyVersion { get; set; }
        public class GetPolicyResponseBodyDefaultPolicyVersion : TeaModel {
            /// <summary>
            /// <para>The time when the policy was created. The time is in UTC. Format: <c>YYYY-MM-DDThh:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The data structure returned by <c>DefaultPolicyVersion</c> is always the default version. Therefore, the value of <c>IsDefaultVersion</c> is always <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefaultVersion")]
            [Validation(Required=false)]
            public bool? IsDefaultVersion { get; set; }

            /// <summary>
            /// <para>The policy document of the access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;Statement&quot;: [{ &quot;Action&quot;: [&quot;oss:<em>&quot;], &quot;Effect&quot;: &quot;Allow&quot;, &quot;Resource&quot;: [&quot;acs:oss:</em>:<em>:</em>&quot;]}], &quot;Version&quot;: &quot;1&quot;}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The version of the access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <para>The basic information of the access policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetPolicyResponseBodyPolicy Policy { get; set; }
        public class GetPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The number of references.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachmentCount")]
            [Validation(Required=false)]
            public int? AttachmentCount { get; set; }

            /// <summary>
            /// <para>The time when the policy was created. The time is in UTC. Format: <c>YYYY-MM-DDThh:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The default version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <para>The description of the access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS administrator permissions</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The name of the access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS-Administrator</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of the access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The time when the policy was last modified. The time is in UTC. Format: <c>YYYY-MM-DDThh:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>697852FB-50D7-44D9-9774-530C31EAC572</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
