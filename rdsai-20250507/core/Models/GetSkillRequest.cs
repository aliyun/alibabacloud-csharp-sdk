// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetSkillRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to obtain a temporary download URL for the specified version. Default value: false.</para>
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public bool? Download { get; set; }

        /// <summary>
        /// <para>The supported language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Simplified Chinese</description></item>
        /// <item><description>zh-TW: Traditional Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// <item><description>ja-JP: Japanese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The file path within the package, such as SKILL.md. The body is in File.text, and the full Markdown is in SkillMarkdown.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SKILL.md</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The unique identifier of the skill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-44665544****</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The version UUID (Versions[].Id), not a version number such as 1.0.0. If omitted, the currently active version is read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000002</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The ContextDB workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
