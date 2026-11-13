// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSkillShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The downloadable URL (HTTP or HTTPS) of the bundle.zip file. This parameter and SkillMdOverride are mutually exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/skill.zip">https://example.com/skill.zip</a></para>
        /// </summary>
        [NameInMap("BundleUrl")]
        [Validation(Required=false)]
        public string BundleUrl { get; set; }

        /// <summary>
        /// <para>The description of the skill.</para>
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
        public string ExtraShrink { get; set; }

        /// <summary>
        /// <para>The name of the skill. The name must be unique within the current account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-skill</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The body of the SKILL.md file. This parameter and BundleUrl are mutually exclusive. If you do not provide a bundle, use this field to create a lightweight skill that contains only the SKILL.md file.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// <h2>name: example-skill
        /// description: Sample skill.</h2>
        /// <h1>Sample skill</h1>
        /// <para>Summarize the text provided by the user</para>
        /// </summary>
        [NameInMap("SkillMdOverride")]
        [Validation(Required=false)]
        public string SkillMdOverride { get; set; }

        /// <summary>
        /// <para>The release notes of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Initial version</para>
        /// </summary>
        [NameInMap("VersionNote")]
        [Validation(Required=false)]
        public string VersionNote { get; set; }

        /// <summary>
        /// <para>The visibility level. Valid values: TENANT: visible within the account. PROJECT: visible to specified projects. USER: visible to specified users.</para>
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
        public string VisibilityScopeShrink { get; set; }

    }

}
