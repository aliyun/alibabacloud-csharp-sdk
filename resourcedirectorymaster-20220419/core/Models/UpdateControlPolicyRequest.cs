// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class UpdateControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the access control policy.</para>
        /// <para>The description must be 1 to 1,024 characters in length. The description can contain letters, digits, underscores (_), and hyphens (-) and must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExampleControlPolicy</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The new document of the access control policy.</para>
        /// <para>The document can be a maximum of 4,096 characters in length.</para>
        /// <para>For more information about the languages of access control policies, see <a href="https://help.aliyun.com/document_detail/179096.html">Languages of access control policies</a>.</para>
        /// <para>For more information about the examples of access control policies, see <a href="https://help.aliyun.com/document_detail/181474.html">Examples of custom access control policies</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Deny&quot;,&quot;Action&quot;:[&quot;ram:UpdateRole&quot;,&quot;ram:DeleteRole&quot;,&quot;ram:AttachPolicyToRole&quot;,&quot;ram:DetachPolicyFromRole&quot;],&quot;Resource&quot;:&quot;acs:ram:<em>:</em>:role/ResourceDirectoryAccountAccessRole&quot;}]}</para>
        /// </summary>
        [NameInMap("NewPolicyDocument")]
        [Validation(Required=false)]
        public string NewPolicyDocument { get; set; }

        /// <summary>
        /// <para>The new name of the access control policy.</para>
        /// <para>The name must be 1 to 128 characters in length. The name can contain letters, digits, and hyphens (-) and must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewControlPolicy</para>
        /// </summary>
        [NameInMap("NewPolicyName")]
        [Validation(Required=false)]
        public string NewPolicyName { get; set; }

        /// <summary>
        /// <para>The ID of the access control policy.</para>
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
