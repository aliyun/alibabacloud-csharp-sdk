// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>Displayname</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("DisplayNameStartsWith")]
        [Validation(Required=false)]
        public string DisplayNameStartsWith { get; set; }

        /// <summary>
        /// <para>The email address of the user who owns the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:user@example.com">user@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the organizational unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("OrganizationalUnitId")]
        [Validation(Required=false)]
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The mobile number of the user who owns the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156xxxxxxx</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The country code of the mobile number. For example, the country code of China is 86 without 00 or +.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("PhoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <para>The status of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: The account is enabled.</description></item>
        /// <item><description>disabled: The account is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The external ID of the account. The external ID can be used by external data to map the data of the account in IDaaS EIAM.</para>
        /// <para>For accounts with the same source type and source ID, each account has a unique external ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("UserExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// <para>User ID set</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// <para>The source ID of the account.</para>
        /// <para>If the account was created in IDaaS, its source ID is the ID of the IDaaS instance. If the account was imported, its source ID is the enterprise ID in the source. For example, if the account was imported from DingTalk, its source ID is the corpId value of the enterprise in DingTalk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("UserSourceId")]
        [Validation(Required=false)]
        public string UserSourceId { get; set; }

        /// <summary>
        /// <para>The source type of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>build_in: The account was created in IDaaS.</description></item>
        /// <item><description>ding_talk: The account was imported from DingTalk.</description></item>
        /// <item><description>ad: The account was imported from Microsoft Active Directory (AD).</description></item>
        /// <item><description>ldap: The account was imported from a Lightweight Directory Access Protocol (LDAP) service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>build_in</para>
        /// </summary>
        [NameInMap("UserSourceType")]
        [Validation(Required=false)]
        public string UserSourceType { get; set; }

        /// <summary>
        /// <para>Username</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("UsernameStartsWith")]
        [Validation(Required=false)]
        public string UsernameStartsWith { get; set; }

    }

}
