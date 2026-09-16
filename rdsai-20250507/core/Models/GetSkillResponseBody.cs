// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>The currently active version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version-example</para>
        /// </summary>
        [NameInMap("ActiveVersionId")]
        [Validation(Required=false)]
        public string ActiveVersionId { get; set; }

        /// <summary>
        /// <para>The Skill category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>productivity</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

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
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-04T02:25:43Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The list of database types.</para>
        /// </summary>
        [NameInMap("Dbtypes")]
        [Validation(Required=false)]
        public List<string> Dbtypes { get; set; }

        /// <summary>
        /// <para>The Skill description, up to 1000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL Review Expert: Comprehensively reviews SQL for security, performance, and compliance, identifies risks, and provides optimization suggestions. Activated immediately when a user submits SQL or asks about &quot;SQL review&quot;, &quot;SQL Review&quot;, &quot;any risks&quot;, or &quot;how to optimize&quot;</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The Skill display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example Skill</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The public HTTPS URL of the current icon. This value is empty if no icon is configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/skill-icon.png">https://example.com/skill-icon.png</a></para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

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
        /// <para>Indicates whether the Skill is deleted.</para>
        /// </summary>
        [NameInMap("IsDeleted")]
        [Validation(Required=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// <para>The Skill name. The name can contain only lowercase letters, digits, and hyphens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sql-optimization</para>
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
        /// <para>The visibility scope of the Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

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
        /// <para>The stable identifier of a private Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-skill</para>
        /// </summary>
        [NameInMap("Slug")]
        [Validation(Required=false)]
        public string Slug { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-04T21:14:45Z</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The list of versions visible to the current principal.</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<GetSkillResponseBodyVersions> Versions { get; set; }
        public class GetSkillResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>The activation time of the Skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("ActivatedAt")]
            [Validation(Required=false)]
            public string ActivatedAt { get; set; }

            /// <summary>
            /// <para>The creation time of the Skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Indicates whether the Skill requires a credential.</para>
            /// </summary>
            [NameInMap("CredentialRequired")]
            [Validation(Required=false)]
            public bool? CredentialRequired { get; set; }

            /// <summary>
            /// <para>The Skill version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version-example</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The Skill package size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("PackageSize")]
            [Validation(Required=false)]
            public long? PackageSize { get; set; }

            /// <summary>
            /// <para>The reason for revoking the Skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Replaced by a newer version</para>
            /// </summary>
            [NameInMap("RevokeReason")]
            [Validation(Required=false)]
            public string RevokeReason { get; set; }

            /// <summary>
            /// <para>The revocation time of the Skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-15T11:00:00Z</para>
            /// </summary>
            [NameInMap("RevokedAt")]
            [Validation(Required=false)]
            public string RevokedAt { get; set; }

            /// <summary>
            /// <para>The SHA-256 digest of the Skill package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("Sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

            /// <summary>
            /// <para>The ID of the Skill to which this version belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-example</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>The Markdown content of the Skill.</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Example Skill</h1>
            /// </summary>
            [NameInMap("SkillMarkdown")]
            [Validation(Required=false)]
            public string SkillMarkdown { get; set; }

            /// <summary>
            /// <para>The status of the Skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version number of the Skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
