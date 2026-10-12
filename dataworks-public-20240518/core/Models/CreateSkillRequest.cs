// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSkillRequest : TeaModel {
        /// <summary>
        /// <para>The <b>download URL of the bundle.zip file</b> (HTTP or HTTPS). This parameter and SkillMdOverride are mutually exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/skill.zip">https://example.com/skill.zip</a></para>
        /// </summary>
        [NameInMap("BundleUrl")]
        [Validation(Required=false)]
        public string BundleUrl { get; set; }

        /// <summary>
        /// <para>The <b>skill description</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data analytics skill</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The extended metadata in key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appId&quot;:&quot;APP_CWJMV36CT9SAFW1QEHX7&quot;}</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        /// <summary>
        /// <para>The <b>skill name</b>. The name must be unique within the current account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-skill</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The content of the SKILL.md file. This parameter and BundleUrl are mutually exclusive. If you do not provide a bundle, use this parameter to create a lightweight skill that contains only the SKILL.md file.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("SkillMdOverride")]
        [Validation(Required=false)]
        public string SkillMdOverride { get; set; }

        /// <summary>
        /// <para>The <b>version note</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Initial version</para>
        /// </summary>
        [NameInMap("VersionNote")]
        [Validation(Required=false)]
        public string VersionNote { get; set; }

        /// <summary>
        /// <para>The <b>visibility level</b>. Valid values: TENANT (visible to the entire tenant), PROJECT (visible to specific projects), and USER (visible to specific users).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The visibility scope. Specify the corresponding field based on the value of Visibility.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public CreateSkillRequestVisibilityScope VisibilityScope { get; set; }
        public class CreateSkillRequestVisibilityScope : TeaModel {
            /// <summary>
            /// <para>The IDs of the visible projects. This parameter takes effect only when Visibility is set to PROJECT.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<string> ProjectIds { get; set; }

            /// <summary>
            /// <para>The IDs of the visible users. This parameter takes effect only when Visibility is set to USER.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
