// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UnLinkAccountRequest : TeaModel {
        /// <summary>
        /// <para>Additional information for the unique account identifier. For example, when the account is a phone number, this field should be filled with the area code of the phone, such as 86 for Mainland China. If not provided, it defaults to 86.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>Unique identifier of the account, such as a phone number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****</para>
        /// </summary>
        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        /// <summary>
        /// <para>Account type</para>
        /// <para>mobile: Phone number</para>
        /// <para>email: Email address</para>
        /// <para>ding: DingTalk</para>
        /// <para>ram: Alibaba Cloud RAM User</para>
        /// <para>wechat: WeCom</para>
        /// <para>ldap: LDAP account</para>
        /// <para>custom: Custom account</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobile</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>User identifier</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid1</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
