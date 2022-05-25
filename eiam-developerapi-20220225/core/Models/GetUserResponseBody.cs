// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// 账户过期时间, 毫秒时间
        /// </summary>
        [NameInMap("accountExpireTime")]
        [Validation(Required=false)]
        public long? AccountExpireTime { get; set; }

        /// <summary>
        /// 创建时间, 毫秒时间
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 账号描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 显示名
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// 邮箱是否验证
        /// </summary>
        [NameInMap("emailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 锁定过期时间, 毫秒时间
        /// </summary>
        [NameInMap("lockExpireTime")]
        [Validation(Required=false)]
        public long? LockExpireTime { get; set; }

        /// <summary>
        /// 账户所属组织列表
        /// </summary>
        [NameInMap("organizationalUnits")]
        [Validation(Required=false)]
        public List<GetUserResponseBodyOrganizationalUnits> OrganizationalUnits { get; set; }
        public class GetUserResponseBodyOrganizationalUnits : TeaModel {
            /// <summary>
            /// 机构ID
            /// </summary>
            [NameInMap("organizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// 机构名称
            /// </summary>
            [NameInMap("organizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            /// <summary>
            /// 是否主机构
            /// </summary>
            [NameInMap("primary")]
            [Validation(Required=false)]
            public bool? Primary { get; set; }

        }

        /// <summary>
        /// 密码是否已设置
        /// </summary>
        [NameInMap("passwordSet")]
        [Validation(Required=false)]
        public bool? PasswordSet { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 手机号是否验证
        /// </summary>
        [NameInMap("phoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// 手机地区编号,示例：中国大陆手区号为86，不带 00 或 +
        /// </summary>
        [NameInMap("phoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// 账户主机构ID
        /// </summary>
        [NameInMap("primaryOrganizationalUnitId")]
        [Validation(Required=false)]
        public string PrimaryOrganizationalUnitId { get; set; }

        [NameInMap("registerTime")]
        [Validation(Required=false)]
        public long? RegisterTime { get; set; }

        /// <summary>
        /// 账户状态, enabled:启用,disabled:禁用
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 最近一次更新时间, 毫秒时间
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 外部ID
        /// </summary>
        [NameInMap("userExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// 账户ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        [NameInMap("userSourceId")]
        [Validation(Required=false)]
        public string UserSourceId { get; set; }

        /// <summary>
        /// 来源类型，build_in[自建],ding_talk[钉钉导入],ad[AD导入],ldap[LDAP导入]
        /// </summary>
        [NameInMap("userSourceType")]
        [Validation(Required=false)]
        public string UserSourceType { get; set; }

        /// <summary>
        /// 账户名
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
