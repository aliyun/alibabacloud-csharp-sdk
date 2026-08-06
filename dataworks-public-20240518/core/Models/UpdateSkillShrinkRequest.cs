// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateSkillShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The downloadable URL (HTTP/HTTPS) of the bundle.zip file. Mutually exclusive with SkillMdOverride. If specified, the bundle is replaced.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/skill.zip">https://example.com/skill.zip</a></para>
        /// </summary>
        [NameInMap("BundleUrl")]
        [Validation(Required=false)]
        public string BundleUrl { get; set; }

        /// <summary>
        /// <para>The Skill description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据分析技能</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expected version number for optimistic locking. If not specified, the update is based on the current highest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public int? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The extended metadata (key-value pairs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;appId\&quot;:\&quot;APP_Q2SDWKIGFWNZTR68K1GQ\&quot;}</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        /// <summary>
        /// <para>The name of the Skill to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-skill</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The SKILL.md body content. Mutually exclusive with BundleUrl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>把大象放冰箱分为三步，把冰箱门打开，把大象放进去，把冰箱门关上。</para>
        /// </summary>
        [NameInMap("SkillMdOverride")]
        [Validation(Required=false)]
        public string SkillMdOverride { get; set; }

        /// <summary>
        /// <para>The version note.</para>
        /// 
        /// <b>Example:</b>
        /// <para>修订说明</para>
        /// </summary>
        [NameInMap("VersionNote")]
        [Validation(Required=false)]
        public string VersionNote { get; set; }

        /// <summary>
        /// <para>The visibility scope. The corresponding field is used based on the visibility level.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public string VisibilityScopeShrink { get; set; }

    }

}
