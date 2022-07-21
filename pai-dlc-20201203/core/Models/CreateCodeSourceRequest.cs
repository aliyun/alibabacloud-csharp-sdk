// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateCodeSourceRequest : TeaModel {
        /// <summary>
        /// 代码分支
        /// </summary>
        [NameInMap("CodeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

        /// <summary>
        /// 代码仓库地址
        /// </summary>
        [NameInMap("CodeRepo")]
        [Validation(Required=false)]
        public string CodeRepo { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [NameInMap("CodeRepoAccessToken")]
        [Validation(Required=false)]
        public string CodeRepoAccessToken { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [NameInMap("CodeRepoUserName")]
        [Validation(Required=false)]
        public string CodeRepoUserName { get; set; }

        /// <summary>
        /// 代码源详细描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 代码源配置名称
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 代码本地挂载目录，默认挂载到/root/code/下
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

    }

}
