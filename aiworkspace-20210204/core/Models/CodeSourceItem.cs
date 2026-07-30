// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CodeSourceItem : TeaModel {
        /// <summary>
        /// <para>The visibility of the code source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The clone mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Create a new subdirectory.</description></item>
        /// <item><description>1: Tile to the current directory.</description></item>
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
        /// <para>The code commit ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44da10**********</para>
        /// </summary>
        [NameInMap("CodeCommit")]
        [Validation(Required=false)]
        public string CodeCommit { get; set; }

        /// <summary>
        /// <para>The code repository URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://code.aliyun.com/">https://code.aliyun.com/</a>****</para>
        /// </summary>
        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        /// <summary>
        /// <para>The token used as the access code for the code repository.</para>
        /// </summary>
        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        /// <summary>
        /// <para>The username used as the access code for the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("CodeRepoUserName")]
        [Validation(Required=false)]
        public string CodeRepoUserName { get; set; }

        /// <summary>
        /// <para>The code source configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-202**********</para>
        /// </summary>
        [NameInMap("CodeSourceId")]
        [Validation(Required=false)]
        public string CodeSourceId { get; set; }

        /// <summary>
        /// <para>The detailed description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code source of dlc examples</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the code source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCodeSourceName1</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-18T12:52:15Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-18T12:52:15Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <para>The local mount path of the code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code/</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// <para>The creator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1157290171663117</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
