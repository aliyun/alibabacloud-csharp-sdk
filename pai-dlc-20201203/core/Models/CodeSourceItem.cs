// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CodeSourceItem : TeaModel {
        /// <summary>
        /// 代码分支
        /// </summary>
        [NameInMap("CodeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

        /// <summary>
        /// 代码Commit ID
        /// </summary>
        [NameInMap("CodeCommit")]
        [Validation(Required=false)]
        public string CodeCommit { get; set; }

        /// <summary>
        /// 代码仓库地址
        /// </summary>
        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        /// <summary>
        /// 访问代码仓库所用的AccessToken
        /// </summary>
        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        /// <summary>
        /// 访问代码仓库的用户名
        /// </summary>
        [NameInMap("CodeRepoUserName")]
        [Validation(Required=false)]
        public string CodeRepoUserName { get; set; }

        /// <summary>
        /// 代码源ID
        /// </summary>
        [NameInMap("CodeSourceId")]
        [Validation(Required=false)]
        public string CodeSourceId { get; set; }

        /// <summary>
        /// 代码源详细描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 代码源配置的名字
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// 代码源配置的用户ID
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
