// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetFileLastCommitRequest : TeaModel {
        /// <summary>
        /// 个人访问令牌
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [NameInMap("filepath")]
        [Validation(Required=false)]
        public string Filepath { get; set; }

        /// <summary>
        /// 云效企业ID
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 分支名称、标签名称或Commit ID
        /// </summary>
        [NameInMap("sha")]
        [Validation(Required=false)]
        public string Sha { get; set; }

    }

}
