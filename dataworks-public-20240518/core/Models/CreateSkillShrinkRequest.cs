// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSkillShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The <b>downloadable URL (HTTP/HTTPS) of the bundle.zip file</b>. This parameter is mutually exclusive with SkillMdOverride.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/skill.zip">https://example.com/skill.zip</a></para>
        /// </summary>
        [NameInMap("BundleUrl")]
        [Validation(Required=false)]
        public string BundleUrl { get; set; }

        /// <summary>
        /// <para>The <b>Skill description</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据分析技能</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The extension metadata in key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appId&quot;:&quot;APP_CWJMV36CT9SAFW1QEHX7&quot;}</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        /// <summary>
        /// <para>The <b>Skill name</b>, which must be unique within the current account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-skill</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The SKILL.md body content. This parameter is mutually exclusive with BundleUrl. If no bundle is provided, use this field to create a lightweight Skill that contains only a SKILL.md file.</para>
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
        /// <para>初版</para>
        /// </summary>
        [NameInMap("VersionNote")]
        [Validation(Required=false)]
        public string VersionNote { get; set; }

        /// <summary>
        /// <para>The <b>visibility level</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TENANT: Visible within the account.</description></item>
        /// <item><description>PROJECT: Visible to specified projects.</description></item>
        /// <item><description>USER: Visible to specified users.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The visibility scope. The corresponding field is determined by the Visibility parameter.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public string VisibilityScopeShrink { get; set; }

    }

}
