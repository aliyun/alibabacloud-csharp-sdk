// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class SaveWorkspaceCodeRequest : TeaModel {
        /// <summary>
        /// <para>The code content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>print(123)</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly overwrite the file. If set to true, the file is overwritten regardless of whether it has been modified by others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Specifies whether the file is an infrastructure as code template file. Set this parameter to true for YAML configuration files that are edited in the visual editor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Iac")]
        [Validation(Required=false)]
        public bool? Iac { get; set; }

        /// <summary>
        /// <para>The file modification time. The GetWorkspaceCode operation returns this mtime value. When you call SaveWorkspaceCode, include this mtime value to check whether the file has been changed on the server. If the mtime values do not match, the save operation fails, which indicates that the server-side version has been modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T10:11:12Z</para>
        /// </summary>
        [NameInMap("Mtime")]
        [Validation(Required=false)]
        public string Mtime { get; set; }

        /// <summary>
        /// <para>The file path to save.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/Workspace/code/test.py</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The repository information. Specify this parameter when creating a git repository directory during the save operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:git@codeup.aliyun.com">git@codeup.aliyun.com</a>:test/abc.git</para>
        /// </summary>
        [NameInMap("Repo")]
        [Validation(Required=false)]
        public string Repo { get; set; }

        /// <summary>
        /// <para>The workspace ID (numeric ID).</para>
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
