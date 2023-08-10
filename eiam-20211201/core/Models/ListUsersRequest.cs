// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// 账户展示名，模糊匹配
        /// </summary>
        [NameInMap("DisplayNameStartsWith")]
        [Validation(Required=false)]
        public string DisplayNameStartsWith { get; set; }

        /// <summary>
        /// The email address of the user who owns the account.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the organizational unit.
        /// </summary>
        [NameInMap("OrganizationalUnitId")]
        [Validation(Required=false)]
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The mobile number of the user who owns the account.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The country code of the mobile number. For example, the country code of China is 86 without 00 or +.
        /// </summary>
        [NameInMap("PhoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// The status of the account. Valid values:
        /// 
        /// *   enabled: The account is enabled.
        /// *   disabled: The account is disabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The external ID of the account. The external ID can be used by external data to map the data of the account in IDaaS EIAM.
        /// 
        /// For accounts with the same source type and source ID, each account has a unique external ID.
        /// </summary>
        [NameInMap("UserExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// 账户的ID集合
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// The source ID of the account.
        /// 
        /// If the account was created in IDaaS, its source ID is the ID of the IDaaS instance. If the account was imported, its source ID is the enterprise ID in the source. For example, if the account was imported from DingTalk, its source ID is the corpId value of the enterprise in DingTalk.
        /// </summary>
        [NameInMap("UserSourceId")]
        [Validation(Required=false)]
        public string UserSourceId { get; set; }

        /// <summary>
        /// The source type of the account. Valid values:
        /// 
        /// *   build_in: The account was created in IDaaS.
        /// *   ding_talk: The account was imported from DingTalk.
        /// *   ad: The account was imported from Microsoft Active Directory (AD).
        /// *   ldap: The account was imported from a Lightweight Directory Access Protocol (LDAP) service.
        /// </summary>
        [NameInMap("UserSourceType")]
        [Validation(Required=false)]
        public string UserSourceType { get; set; }

        /// <summary>
        /// 账户名，左模糊匹配
        /// </summary>
        [NameInMap("UsernameStartsWith")]
        [Validation(Required=false)]
        public string UsernameStartsWith { get; set; }

    }

}
