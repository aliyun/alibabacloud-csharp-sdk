// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the control policy.</para>
        /// </summary>
        [NameInMap("ControlPolicy")]
        [Validation(Required=false)]
        public GetControlPolicyResponseBodyControlPolicy ControlPolicy { get; set; }
        public class GetControlPolicyResponseBodyControlPolicy : TeaModel {
            /// <summary>
            /// <para>The number of times the control policy is referenced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachmentCount")]
            [Validation(Required=false)]
            public string AttachmentCount { get; set; }

            /// <summary>
            /// <para>The time when the control policy was created. The time is displayed in UTC in RFC 3339 format, indicated by Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T08:51:33Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleControlPolicy</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The effective scope of the control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>All: The control policy takes effect for Alibaba Cloud accounts, Resource Access Management (RAM) users, and RAM roles.</description></item>
            /// <item><description>RAM: The control policy takes effect only for RAM users and RAM roles.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("EffectScope")]
            [Validation(Required=false)]
            public string EffectScope { get; set; }

            /// <summary>
            /// <para>The content of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Version\&quot;:\&quot;1\&quot;,\&quot;Statement\&quot;:[{\&quot;Effect\&quot;:\&quot;Deny\&quot;,\&quot;Action\&quot;:[\&quot;ram:UpdateRole\&quot;,\&quot;ram:DeleteRole\&quot;,\&quot;ram:AttachPolicyToRole\&quot;,\&quot;ram:DetachPolicyFromRole\&quot;],\&quot;Resource\&quot;:\&quot;acs:ram:<em>:</em>:role/ResourceDirectoryAccountAccessRole\&quot;}]}</para>
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <para>The ID of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-SImPt8GCEwiq****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The Policy Name of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of the control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System: system control policy.</description></item>
            /// <item><description>Custom: custom control policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The time when the control policy was updated. The time is displayed in UTC in RFC 3339 format, indicated by Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T08:51:33Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AB769936-CDFA-4D52-8CE2-A3581800044A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
