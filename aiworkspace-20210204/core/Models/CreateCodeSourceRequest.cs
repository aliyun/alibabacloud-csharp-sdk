// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateCodeSourceRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the code configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The clone mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): creates a new subdirectory.</description></item>
        /// <item><description>1: tiles to the current directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CloneType")]
        [Validation(Required=false)]
        public int? CloneType { get; set; }

        /// <summary>
        /// <para>The code branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("CodeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

        /// <summary>
        /// <para>The CommitID of the code. CodeCommit takes priority over CodeBranch. If you specify CodeCommit, CodeBranch does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>171de********a9d900d</para>
        /// </summary>
        [NameInMap("CodeCommit")]
        [Validation(Required=false)]
        public string CodeCommit { get; set; }

        /// <summary>
        /// <para>The URL of the code repository. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://code.aliyun.com/">https://code.aliyun.com/</a>******</para>
        /// </summary>
        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        /// <summary>
        /// <para>The access token of the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        /// <summary>
        /// <para>The username of the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>use***</para>
        /// </summary>
        [NameInMap("CodeRepoUserName")]
        [Validation(Required=false)]
        public string CodeRepoUserName { get; set; }

        /// <summary>
        /// <para>The description of the code configuration, which helps distinguish different code configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code source of dlc examples</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the code configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCodeSource1</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The local mount directory for the code. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code/code-source-1</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// <para>The workspace ID. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
