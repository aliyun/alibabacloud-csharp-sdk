// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetProjectMemberRequest : TeaModel {
        /// <summary>
        /// accessToken（选填），使用AK方式调用时无需填accessToken
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 代码仓库Id
        /// </summary>
        [NameInMap("repositoryId")]
        [Validation(Required=false)]
        public long? RepositoryId { get; set; }

        /// <summary>
        /// 用户阿里云PK
        /// </summary>
        [NameInMap("userAliyunPk")]
        [Validation(Required=false)]
        public string UserAliyunPk { get; set; }

    }

}
