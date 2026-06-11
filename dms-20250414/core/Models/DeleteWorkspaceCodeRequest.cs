// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DeleteWorkspaceCodeRequest : TeaModel {
        /// <summary>
        /// <para>The full path of the code file or directory. The path must be prefixed with <c>/Workspace/code/</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/Workspace/code/default/test.ipynb</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The repository information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database/adb</para>
        /// </summary>
        [NameInMap("Repo")]
        [Validation(Required=false)]
        public string Repo { get; set; }

        /// <summary>
        /// <para>Specifies whether the item to delete is a symbolic link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Symlink")]
        [Validation(Required=false)]
        public bool? Symlink { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
