// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateInlinePolicyForAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00jhtfl8thteu6uj****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The name of the inline policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InlinePolicy</para>
        /// </summary>
        [NameInMap("InlinePolicyName")]
        [Validation(Required=false)]
        public string InlinePolicyName { get; set; }

        /// <summary>
        /// <para>The new configurations of the inline policy.</para>
        /// <para>The value can be up to 4,096 characters in length.</para>
        /// <para>For more information about the syntax and structure of RAM policies, see <a href="https://help.aliyun.com/document_detail/93739.html">Policy syntax and structure</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: &quot;<em>&quot;,&quot;Effect&quot;: &quot;Allow&quot;,&quot;Resource&quot;: &quot;</em>&quot;}],&quot;Version&quot;: &quot;1&quot;}</para>
        /// </summary>
        [NameInMap("NewInlinePolicyDocument")]
        [Validation(Required=false)]
        public string NewInlinePolicyDocument { get; set; }

    }

}
