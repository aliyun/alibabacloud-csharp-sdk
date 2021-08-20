// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class GetFileLastCommitRequest : TeaModel {
        /// <summary>
        /// 个人访问令牌
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 云效企业ID
        /// </summary>
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 分支名称、标签名称或Commit ID
        /// </summary>
        [NameInMap("Sha")]
        [Validation(Required=false)]
        public string Sha { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

    }

}
