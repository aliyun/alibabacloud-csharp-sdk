// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetSkillResponseBody : TeaModel {
        /// <summary>
        /// <para>The current active version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version-example</para>
        /// </summary>
        [NameInMap("ActiveVersionId")]
        [Validation(Required=false)]
        public string ActiveVersionId { get; set; }

        /// <summary>
        /// <para>The content digest of the current skill bundle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("BundleHash")]
        [Validation(Required=false)]
        public string BundleHash { get; set; }

        /// <summary>
        /// <para>The size of the current skill bundle, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("BundleSizeBytes")]
        [Validation(Required=false)]
        public long? BundleSizeBytes { get; set; }

        /// <summary>
        /// <para>The skill operations that the current user can perform.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public GetSkillResponseBodyCapabilities Capabilities { get; set; }
        public class GetSkillResponseBodyCapabilities : TeaModel {
            /// <summary>
            /// <para>Indicates whether the skill can be deleted.</para>
            /// </summary>
            [NameInMap("Delete")]
            [Validation(Required=false)]
            public bool? Delete { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill bundle can be downloaded.</para>
            /// </summary>
            [NameInMap("Download")]
            [Validation(Required=false)]
            public bool? Download { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill can be edited.</para>
            /// </summary>
            [NameInMap("Edit")]
            [Validation(Required=false)]
            public bool? Edit { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill version can be rolled back.</para>
            /// </summary>
            [NameInMap("Rollback")]
            [Validation(Required=false)]
            public bool? Rollback { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill can be shared.</para>
            /// </summary>
            [NameInMap("Share")]
            [Validation(Required=false)]
            public bool? Share { get; set; }

            /// <summary>
            /// <para>Indicates whether a new version can be uploaded.</para>
            /// </summary>
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public bool? Upload { get; set; }

        }

        /// <summary>
        /// <para>The skill category.</para>
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
        /// <para>The skill description. The description can be up to 1000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL Review Expert: Comprehensively reviews SQL for security, performance, and compliance, identifies risks, and provides optimization suggestions. Activated immediately when a user submits SQL or asks about &quot;SQL review&quot;, &quot;SQL Review&quot;, &quot;any risks&quot;, or &quot;how to optimize&quot;</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example Skill</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The temporary download URL of the skill bundle.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/skill-package.zip">https://example.com/skill-package.zip</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The expiration time of the temporary download URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-15T11:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>The file in the bundle that is read based on the specified path.</para>
        /// </summary>
        [NameInMap("File")]
        [Validation(Required=false)]
        public Dictionary<string, object> File { get; set; }

        /// <summary>
        /// <para>The list of files in the current skill bundle.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Files { get; set; }

        /// <summary>
        /// <para>The metadata fields of SKILL.md.</para>
        /// </summary>
        [NameInMap("Frontmatter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Frontmatter { get; set; }

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
        /// <para>The unique identifier of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d1b7d639-f34e-44c7-8231-987da14d****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Indicates whether the skill is deleted.</para>
        /// </summary>
        [NameInMap("IsDeleted")]
        [Validation(Required=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// <para>The skill name. The name can contain only lowercase letters, digits, and hyphens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sql-optimization</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique request identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The visibility scope of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The current skill ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill-example</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The full Markdown content of SKILL.md.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Example Skill</h1>
        /// </summary>
        [NameInMap("SkillMarkdown")]
        [Validation(Required=false)]
        public string SkillMarkdown { get; set; }

        /// <summary>
        /// <para>The skill type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("SkillType")]
        [Validation(Required=false)]
        public string SkillType { get; set; }

        /// <summary>
        /// <para>The stable identifier of the private skill.</para>
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
        /// <para>The current skill version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The current skill version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version-example</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The list of versions visible to the current principal.</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<GetSkillResponseBodyVersions> Versions { get; set; }
        public class GetSkillResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>The activation time of the skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("ActivatedAt")]
            [Validation(Required=false)]
            public string ActivatedAt { get; set; }

            /// <summary>
            /// <para>The creation time of the skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill requires a credential.</para>
            /// </summary>
            [NameInMap("CredentialRequired")]
            [Validation(Required=false)]
            public bool? CredentialRequired { get; set; }

            /// <summary>
            /// <para>The number of files in the skill bundle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FileCount")]
            [Validation(Required=false)]
            public long? FileCount { get; set; }

            /// <summary>
            /// <para>The skill version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version-example</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The size of the skill bundle, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("PackageSize")]
            [Validation(Required=false)]
            public long? PackageSize { get; set; }

            /// <summary>
            /// <para>The reason for revoking the skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Replaced by a newer version</para>
            /// </summary>
            [NameInMap("RevokeReason")]
            [Validation(Required=false)]
            public string RevokeReason { get; set; }

            /// <summary>
            /// <para>The revocation time of the skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-15T11:00:00Z</para>
            /// </summary>
            [NameInMap("RevokedAt")]
            [Validation(Required=false)]
            public string RevokedAt { get; set; }

            /// <summary>
            /// <para>The SHA-256 digest of the skill package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("Sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

            /// <summary>
            /// <para>The ID of the skill to which the version belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-example</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>The Markdown content of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Example Skill</h1>
            /// </summary>
            [NameInMap("SkillMarkdown")]
            [Validation(Required=false)]
            public string SkillMarkdown { get; set; }

            /// <summary>
            /// <para>The creation source of the skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOAD</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the skill version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update note for the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Update Skill documentation</para>
            /// </summary>
            [NameInMap("UpdateNote")]
            [Validation(Required=false)]
            public string UpdateNote { get; set; }

            /// <summary>
            /// <para>The version number of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The visibility of the skill to the current user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
