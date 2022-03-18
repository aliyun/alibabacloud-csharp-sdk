// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class TriggerRepositoryMirrorSyncRequest : TeaModel {
        /// <summary>
        /// 个人访问令牌。 使用阿里云AK+SK或使用STS临时授权方式不需要传该字段
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 远程同步库克隆账号
        /// </summary>
        [NameInMap("account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// 企业标识，也称企业id，字符串形式，可在云效访问链接中获取，如 https://devops.aliyun.com/organization/
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 远程同步库克隆令牌
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
