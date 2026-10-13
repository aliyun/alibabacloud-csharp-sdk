// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateSkillShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MySQL&quot;: &quot;MySQL optimization guide...&quot;,&quot;PostgreSQL&quot;: &quot;PostgreSQL optimization guide...&quot;}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para>The list of database types.</para>
        /// </summary>
        [NameInMap("Dbtypes")]
        [Validation(Required=false)]
        public string DbtypesShrink { get; set; }

        /// <summary>
        /// <para>The description of the Skill. The description can be up to 1000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL Review Expert: Comprehensively reviews SQL for security, performance, and compliance, identifies risks, and provides optimization suggestions. Activated immediately when a user submits SQL or asks &quot;SQL review&quot;, &quot;SQL Review&quot;, &quot;any risks?&quot;, or &quot;how to optimize&quot;</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the Skill. The name can contain only lowercase letters, digits, and hyphens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sql-optimization</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Skill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8f6a2111-3828-4a9f-a3ce-51ce73c6****</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The version update note for the ContextDB Skill. Specify this parameter when confirming storage after the check passes. The note can be up to 1000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Update Skill documentation</para>
        /// </summary>
        [NameInMap("UpdateNote")]
        [Validation(Required=false)]
        public string UpdateNote { get; set; }

        /// <summary>
        /// <para>The upload session ID returned by GetUploadPolicy for ContextDB full package updates. This parameter is not required for original RDS field updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upload-example</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// <para>The upload session token paired with UploadId, used to verify ownership. This parameter is not required for original RDS field updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-example</para>
        /// </summary>
        [NameInMap("UploadToken")]
        [Validation(Required=false)]
        public string UploadToken { get; set; }

        /// <summary>
        /// <para>The ContextDB workspace ID. This parameter is not required for regular Skill calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-example</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
