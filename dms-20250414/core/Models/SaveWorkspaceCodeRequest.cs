// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class SaveWorkspaceCodeRequest : TeaModel {
        /// <summary>
        /// <para>The content of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description: \&quot;Example template, describe instances in some status\&quot;nFormatVersion: OOS-2019-06-01nTasks:n  - Name: SleepTaskn    Action: ACS::Sleepn    Properties:n      Duration: PT1Mn</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the file if it already exists. The default value is <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Specifies whether the file is an IaC template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Iac")]
        [Validation(Required=false)]
        public bool? Iac { get; set; }

        /// <summary>
        /// <para>The modification time of the file.</para>
        /// <para>The time must be in the ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T10:11:12Z</para>
        /// </summary>
        [NameInMap("Mtime")]
        [Validation(Required=false)]
        public string Mtime { get; set; }

        /// <summary>
        /// <para>The publishing configuration, specified as a JSON string. The <c>repos</c> array specifies the target repository and branch. The <c>exclude</c> array specifies the directories to ignore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;repos&quot;:[{&quot;repo&quot;:&quot;<a href="mailto:git@xxxx.git">git@xxxx.git</a>&quot;, &quot;branch&quot;:&quot;master&quot;}], &quot;exclude&quot;:[&quot;/.dms&quot;, &quot;/username&quot;]}</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Information about the repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>computing/ecs</para>
        /// </summary>
        [NameInMap("Repo")]
        [Validation(Required=false)]
        public string Repo { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
