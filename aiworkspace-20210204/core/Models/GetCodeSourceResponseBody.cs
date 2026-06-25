// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetCodeSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the code configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PRIVATE: The configuration is visible only to you and the administrator in the workspace.</para>
        /// </description></item>
        /// <item><description><para>PUBLIC: The configuration is visible to everyone in the workspace.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("CloneType")]
        [Validation(Required=false)]
        public int? CloneType { get; set; }

        /// <summary>
        /// <para>The branch of the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("CodeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

        /// <summary>
        /// <para>The commit ID of the code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44da10***********</para>
        /// </summary>
        [NameInMap("CodeCommit")]
        [Validation(Required=false)]
        public string CodeCommit { get; set; }

        /// <summary>
        /// <para>The URL of the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://code.aliyun.com/pai-dlc/examples.git">https://code.aliyun.com/pai-dlc/examples.git</a></para>
        /// </summary>
        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        /// <summary>
        /// <para>The token used to access the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        /// <summary>
        /// <para>The username for the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("CodeRepoUserName")]
        [Validation(Required=false)]
        public string CodeRepoUserName { get; set; }

        /// <summary>
        /// <para>The ID of the code source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-202**********</para>
        /// </summary>
        [NameInMap("CodeSourceId")]
        [Validation(Required=false)]
        public string CodeSourceId { get; set; }

        /// <summary>
        /// <para>The detailed description of the code configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my data source 1.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the code source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCodeSource1</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The time when the code configuration was created. The time is in the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T23:36:01.123Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the code configuration was last modified. The time is in the ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T23:36:01.123Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <para>The local mount path for the code.</para>
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
        /// <para>The ID of the user who created the code source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1722********</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
