// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSkillRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/skill.zip">https://example.com/skill.zip</a></para>
        /// </summary>
        [NameInMap("BundleUrl")]
        [Validation(Required=false)]
        public string BundleUrl { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;appId&quot;:&quot;APP_CWJMV36CT9SAFW1QEHX7&quot;}</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-skill</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("SkillMdOverride")]
        [Validation(Required=false)]
        public string SkillMdOverride { get; set; }

        [NameInMap("VersionNote")]
        [Validation(Required=false)]
        public string VersionNote { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public CreateSkillRequestVisibilityScope VisibilityScope { get; set; }
        public class CreateSkillRequestVisibilityScope : TeaModel {
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<string> ProjectIds { get; set; }

            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
