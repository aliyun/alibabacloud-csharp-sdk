// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreatePolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the policy.</para>
        /// <para>The description must be 1 to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Query ECS instances in a specific region</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The document of the policy.</para>
        /// <para>The document must be 1 to 6,144 characters in length.</para>
        /// <para>For more information about policy elements and sample policies, see <a href="https://help.aliyun.com/document_detail/93738.html">Policy elements</a> and <a href="https://help.aliyun.com/document_detail/210969.html">Overview of sample policies</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Effect&quot;: &quot;Allow&quot;,&quot;Action&quot;: &quot;ecs:Describe*&quot;,&quot;Resource&quot;: &quot;acs:ecs:cn-qingdao:<em>:instance/</em>&quot;}],&quot;Version&quot;: &quot;1&quot;}</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>View-ECS-instances-in-a-specific-region</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
