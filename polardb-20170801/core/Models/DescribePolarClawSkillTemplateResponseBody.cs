// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawSkillTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDB3258F-B5DE-43C4-8935-CBA0CA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The skill template group.</para>
        /// </summary>
        [NameInMap("SkillTemplates")]
        [Validation(Required=false)]
        public List<DescribePolarClawSkillTemplateResponseBodySkillTemplates> SkillTemplates { get; set; }
        public class DescribePolarClawSkillTemplateResponseBodySkillTemplates : TeaModel {
            /// <summary>
            /// <para>Indicates whether the template is actually created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-21 12:00:00</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The last modification time of the parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-23 23:00:00</para>
            /// </summary>
            [NameInMap("Modified")]
            [Validation(Required=false)]
            public string Modified { get; set; }

            /// <summary>
            /// <para>The description of the skill template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill template for test</para>
            /// </summary>
            [NameInMap("SkillTemplateDesc")]
            [Validation(Required=false)]
            public string SkillTemplateDesc { get; set; }

            /// <summary>
            /// <para>The skill template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pcpg-skill-**************</para>
            /// </summary>
            [NameInMap("SkillTemplateId")]
            [Validation(Required=false)]
            public string SkillTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the skill template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-template-test</para>
            /// </summary>
            [NameInMap("SkillTemplateName")]
            [Validation(Required=false)]
            public string SkillTemplateName { get; set; }

            /// <summary>
            /// <para>The map of associated skill details. The key is the skill identifier, and the value is a JSON string that can be parsed into an array of skill details. Each array element contains skillName and version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;skill1&quot;:&quot;[{\&quot;skillName\&quot;:\&quot;example-skill\&quot;,\&quot;version\&quot;:\&quot;1.0.0\&quot;}]&quot;}</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public Dictionary<string, string> Skills { get; set; }

            /// <summary>
            /// <para>The source application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-**************</para>
            /// </summary>
            [NameInMap("SrcApplicationId")]
            [Validation(Required=false)]
            public string SrcApplicationId { get; set; }

        }

    }

}
