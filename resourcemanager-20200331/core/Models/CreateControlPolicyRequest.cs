// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The description of the control policy.</para>
        /// <para>The description must be 1 to 1024 characters in length, must start with a letter, and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExampleControlPolicy</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The effective scope of the control policy.</para>
        /// <para>Valid values: RAM, which indicates that the control policy takes effect only for Resource Access Management (RAM) users or RAM roles.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM</para>
        /// </summary>
        [NameInMap("EffectScope")]
        [Validation(Required=false)]
        public string EffectScope { get; set; }

        /// <summary>
        /// <para>The content of the control policy.</para>
        /// <para>The maximum length is 4096 characters.</para>
        /// <para>For information about the control policy language, see <a href="https://help.aliyun.com/document_detail/179096.html">Control policy language</a>.</para>
        /// <para>For examples of control policies, see <a href="https://help.aliyun.com/document_detail/181474.html">Examples of custom control policies</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Deny&quot;,&quot;Action&quot;:[&quot;ram:UpdateRole&quot;,&quot;ram:DeleteRole&quot;,&quot;ram:AttachPolicyToRole&quot;,&quot;ram:DetachPolicyFromRole&quot;],&quot;Resource&quot;:&quot;acs:ram:<em>:</em>:role/ResourceDirectoryAccountAccessRole&quot;}]}</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>Policy Name of the control policy.</para>
        /// <para>Policy Name must be 1 to 128 characters in length, must start with a letter, and can contain letters, digits, and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExampleControlPolicy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
