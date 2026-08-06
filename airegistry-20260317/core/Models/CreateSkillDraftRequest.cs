// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class CreateSkillDraftRequest : TeaModel {
        /// <summary>
        /// <para>The version to fork from. If not specified, a new Skill is created based on the latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.1</para>
        /// </summary>
        [NameInMap("BasedOnVersion")]
        [Validation(Required=false)]
        public string BasedOnVersion { get; set; }

        /// <summary>
        /// <para>The commit message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Initial version.</para>
        /// </summary>
        [NameInMap("CommitMsg")]
        [Validation(Required=false)]
        public string CommitMsg { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The Skill card JSON string that contains complete Skill information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;customer-service-skill&quot;,&quot;description&quot;:&quot;customer-skill-desc&quot;,&quot;skillMd&quot;:&quot;---\nname: customer-service-skill\ndescription: customer-skill-desc\n---\ncustomer-skill-content&quot;}</para>
        /// </summary>
        [NameInMap("SkillCard")]
        [Validation(Required=false)]
        public string SkillCard { get; set; }

        /// <summary>
        /// <para>The Skill name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer-service-skill</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The specified draft version number. If not specified, the version number is automatically incremented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.2</para>
        /// </summary>
        [NameInMap("TargetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
