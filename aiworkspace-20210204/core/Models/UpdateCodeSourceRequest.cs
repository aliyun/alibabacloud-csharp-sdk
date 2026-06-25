// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateCodeSourceRequest : TeaModel {
        [NameInMap("CloneType")]
        [Validation(Required=false)]
        public int? CloneType { get; set; }

        /// <summary>
        /// <para>The name of the code branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("CodeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

        /// <summary>
        /// <para>The commit ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a6*****</para>
        /// </summary>
        [NameInMap("CodeCommit")]
        [Validation(Required=false)]
        public string CodeCommit { get; set; }

        /// <summary>
        /// <para>The URL of the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://code.aliyun.com/">https://code.aliyun.com/</a>******</para>
        /// </summary>
        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        /// <summary>
        /// <para>The access token for the username.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        /// <summary>
        /// <para>The username for the code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-user</para>
        /// </summary>
        [NameInMap("CodeRepoUserName")]
        [Validation(Required=false)]
        public string CodeRepoUserName { get; set; }

        /// <summary>
        /// <para>The description of the code source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Training code for XX</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the code source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCodeSource1</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The default mount path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code/code-source-1</para>
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

    }

}
