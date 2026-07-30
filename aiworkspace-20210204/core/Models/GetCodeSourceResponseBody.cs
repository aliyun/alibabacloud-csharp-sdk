// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetCodeSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the code source configuration.</para>
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
        /// <para>The code repository branch.</para>
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
        /// <para>44da10***********</para>
        /// </summary>
        [NameInMap("CodeCommit")]
        [Validation(Required=false)]
        public string CodeCommit { get; set; }

        /// <summary>
        /// <para>The code repository URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://code.aliyun.com/pai-dlc/examples.git">https://code.aliyun.com/pai-dlc/examples.git</a></para>
        /// </summary>
        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        /// <summary>
        /// <para>The access code repository token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        /// <summary>
        /// <para>The username of the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
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
        /// <para>The detailed description of the code source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my data source 1.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The code source configuration name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCodeSource1</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The creation time of the code source configuration. The time is in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T23:36:01.123Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time of the code source configuration. The time is in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T23:36:01.123Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <para>The local mount directory of the code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The creator ID of the code source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1722********</para>
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
