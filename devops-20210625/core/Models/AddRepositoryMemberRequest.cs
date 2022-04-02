/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class AddRepositoryMemberRequest : TeaModel {
        /// <summary>
        /// Codeup访问令牌，使用AK/SK方式访问可以不用填AccessToken
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 成员权限
        /// </summary>
        [NameInMap("accessLevel")]
        [Validation(Required=false)]
        public int? AccessLevel { get; set; }

        /// <summary>
        /// 需要添加为代码库成员的用户阿里云ID。支持多个，以","分割
        /// </summary>
        [NameInMap("aliyunPks")]
        [Validation(Required=false)]
        public string AliyunPks { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
