// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access control policy.</para>
        /// </summary>
        [NameInMap("ControlPolicy")]
        [Validation(Required=false)]
        public GetControlPolicyResponseBodyControlPolicy ControlPolicy { get; set; }
        public class GetControlPolicyResponseBodyControlPolicy : TeaModel {
            /// <summary>
            /// <para>The number of times that the access control policy is referenced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachmentCount")]
            [Validation(Required=false)]
            public string AttachmentCount { get; set; }

            /// <summary>
            /// <para>The time when the access control policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T08:51:33Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleControlPolicy</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The effective scope of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>All: The access control policy is in effect for Alibaba Cloud accounts, RAM users, and RAM roles.</description></item>
            /// <item><description>RAM: The access control policy is in effect only for RAM users and RAM roles.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("EffectScope")]
            [Validation(Required=false)]
            public string EffectScope { get; set; }

            /// <summary>
            /// <para>The document of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Version\&quot;:\&quot;1\&quot;,\&quot;Statement\&quot;:[{\&quot;Effect\&quot;:\&quot;Deny\&quot;,\&quot;Action\&quot;:[\&quot;ram:UpdateRole\&quot;,\&quot;ram:DeleteRole\&quot;,\&quot;ram:AttachPolicyToRole\&quot;,\&quot;ram:DetachPolicyFromRole\&quot;],\&quot;Resource\&quot;:\&quot;acs:ram:<em>:</em>:role/ResourceDirectoryAccountAccessRole\&quot;}]}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The ID of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-SImPt8GCEwiq****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System: system access control policy</description></item>
            /// <item><description>Custom: custom access control policy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The time when the access control policy was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T08:51:33Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AB769936-CDFA-4D52-8CE2-A3581800044A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
