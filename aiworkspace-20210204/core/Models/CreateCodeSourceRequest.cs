// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateCodeSourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("CodeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

        [NameInMap("CodeCommit")]
        [Validation(Required=false)]
        public string CodeCommit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://code.aliyun.com/">https://code.aliyun.com/</a>******</para>
        /// </summary>
        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>use***</para>
        /// </summary>
        [NameInMap("CodeRepoUserName")]
        [Validation(Required=false)]
        public string CodeRepoUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>code source of dlc examples</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCodeSource1</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/root/code/code-source-1</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
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
