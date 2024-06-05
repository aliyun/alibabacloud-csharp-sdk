// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class LinkAccountRequest : TeaModel {
        /// <summary>
        /// The additional information about the unique identifier of the account. For example, if type is set to mobile, set the value of extra to a country code. For example, a value of 86 specifies a mobile number in the Chinese mainland. If you do not specify this parameter, 86 is used by default.
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// The unique identifier of the account, such as a mobile number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        /// <summary>
        /// The account type. Valid values:
        /// 
        /// *   mobile: a mobile number.
        /// *   email: an email address.
        /// *   ding: a DingTalk account.
        /// *   ram: an Alibaba Cloud Resource Access Management (RAM) user.
        /// *   wechat: a WeCom account.
        /// *   ldap: a Lightweight Directory Access Protocol (LDAP) account.
        /// *   custom: a custom account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the user with which you want to associate an account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
