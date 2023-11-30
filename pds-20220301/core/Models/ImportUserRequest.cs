// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImportUserRequest : TeaModel {
        /// <summary>
        /// The display name of the authentication type.
        /// </summary>
        [NameInMap("authentication_display_name")]
        [Validation(Required=false)]
        public string AuthenticationDisplayName { get; set; }

        /// <summary>
        /// The authentication type. Valid values:
        /// 
        /// *   mobile: mobile number.
        /// *   email: email address.
        /// *   ding: DingTalk account.
        /// *   ram: Alibaba Cloud Resource Access Management (RAM) user.
        /// *   wechat: WeCom account.
        /// *   ldap: Lightweight Directory Access Protocol (LDAP) account.
        /// *   custom: custom account.
        /// </summary>
        [NameInMap("authentication_type")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Specifies whether to automatically create a drive.
        /// </summary>
        [NameInMap("auto_create_drive")]
        [Validation(Required=false)]
        public bool? AutoCreateDrive { get; set; }

        /// <summary>
        /// The size of the drive. The value cannot be smaller than -1. A value of -1 specifies that the size is unlimited.
        /// </summary>
        [NameInMap("drive_total_size")]
        [Validation(Required=false)]
        public long? DriveTotalSize { get; set; }

        /// <summary>
        /// The additional information.
        /// 
        /// If authentication_type is set to mobile, set this parameter to a country code. If you do not specify this parameter, 86 is used by default.
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// The unique identifier.
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        /// <summary>
        /// The nickname of the user.
        /// </summary>
        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// The ID of the group to which the user is added.
        /// </summary>
        [NameInMap("parent_group_id")]
        [Validation(Required=false)]
        public string ParentGroupId { get; set; }

    }

}
