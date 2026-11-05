// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateSkillDraftRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateSkillDraftRequestBody Body { get; set; }
        public class CreateSkillDraftRequestBody : TeaModel {
            /// <summary>
            /// <para>The version to fork from. If you do not specify this parameter, a new skill is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("basedOnVersion")]
            [Validation(Required=false)]
            public string BasedOnVersion { get; set; }

            /// <summary>
            /// <para>The commit message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initial version</para>
            /// </summary>
            [NameInMap("commitMsg")]
            [Validation(Required=false)]
            public string CommitMsg { get; set; }

            /// <summary>
            /// <para>The JSON string of the skill card, which contains the complete skill information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;customer-service-skill&quot;,&quot;description&quot;:&quot;...&quot;}</para>
            /// </summary>
            [NameInMap("skillCard")]
            [Validation(Required=false)]
            public string SkillCard { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer-service-skill</para>
            /// </summary>
            [NameInMap("skillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>Specifies the draft version number. If not specified, the version number automatically increments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.2</para>
            /// </summary>
            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

        }

    }

}
