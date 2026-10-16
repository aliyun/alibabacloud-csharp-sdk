// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the control policy.</para>
        /// <para>The description must be 1 to 1,024 characters in length, must start with a letter, and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExampleControlPolicy</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The new document of the control policy.</para>
        /// <para>The maximum length is 4,096 characters.</para>
        /// <para>For information about the control policy language, see <a href="https://help.aliyun.com/document_detail/179096.html">Control policy language</a>.</para>
        /// <para>For examples of control policies, see <a href="https://help.aliyun.com/document_detail/181474.html">Examples of custom control policies</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Deny&quot;,&quot;Action&quot;:[&quot;ram:UpdateRole&quot;,&quot;ram:DeleteRole&quot;,&quot;ram:AttachPolicyToRole&quot;,&quot;ram:DetachPolicyFromRole&quot;],&quot;Resource&quot;:&quot;acs:ram:<em>:</em>:role/ResourceDirectoryAccountAccessRole&quot;}]}</para>
        /// </summary>
        [NameInMap("NewPolicyDocument")]
        [Validation(Required=false)]
        public string NewPolicyDocument { get; set; }

        /// <summary>
        /// <para>The new Policy Name of the control policy.</para>
        /// <para>The name must be 1 to 128 characters in length, must start with a letter, and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewControlPolicy</para>
        /// </summary>
        [NameInMap("NewPolicyName")]
        [Validation(Required=false)]
        public string NewPolicyName { get; set; }

        /// <summary>
        /// <para>The ID of the control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-jExXAqIYkwHN****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
