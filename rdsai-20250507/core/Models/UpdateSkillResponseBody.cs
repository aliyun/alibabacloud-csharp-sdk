// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>The update action performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD_VERSION</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The content digest of the Skill package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("BundleHash")]
        [Validation(Required=false)]
        public string BundleHash { get; set; }

        /// <summary>
        /// <para>The content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MySQL&quot;: &quot;MySQL optimization guide...&quot;,&quot;PostgreSQL&quot;: &quot;PostgreSQL optimization guide...&quot;}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The list of database types.</para>
        /// </summary>
        [NameInMap("Dbtypes")]
        [Validation(Required=false)]
        public List<string> Dbtypes { get; set; }

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
        /// <para>The unique identifier of the Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d1b7d639-f34e-44c7-8231-987da14d****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the Skill. The name can contain only lowercase letters, digits, and hyphens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sql-review</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the updated Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill-example</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The Skill type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("SkillType")]
        [Validation(Required=false)]
        public string SkillType { get; set; }

        /// <summary>
        /// <para>The time when the Skill was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-04T21:14:45Z</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the Skill version created in this update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version-example</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
