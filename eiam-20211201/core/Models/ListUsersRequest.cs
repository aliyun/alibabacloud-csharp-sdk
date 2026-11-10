// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the display name. A left-match query is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("DisplayNameStartsWith")]
        [Validation(Required=false)]
        public string DisplayNameStartsWith { get; set; }

        /// <summary>
        /// <para>The email address of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:user@example.com">user@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The organizational unit ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("OrganizationalUnitId")]
        [Validation(Required=false)]
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The phone number of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156xxxxxxx</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The phone region code. Example: 86 for the Chinese mainland, without 00 or +.</para>
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
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The external ID, which is used to map external data to IDaaS accounts.</para>
        /// <para>Note: The external ID must be unique within the same source type and source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("UserExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// <para>The list of account IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// <para>The source ID of the account.</para>
        /// <para>For the build-in type, the default value is the instance ID. For other types, the value corresponds to the enterprise ID of the source. For example, for the DingTalk source, the value is the corpId of the DingTalk enterprise.</para>
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
        /// <item><description>build_in: Built-in.</description></item>
        /// <item><description>ding_talk: Imported from DingTalk.</description></item>
        /// <item><description>ad: Imported from AD.</description></item>
        /// <item><description>ldap: Imported from LDAP.</description></item>
        /// <item><description>we_com: Imported from WeCom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>build_in</para>
        /// </summary>
        [NameInMap("UserSourceType")]
        [Validation(Required=false)]
        public string UserSourceType { get; set; }

        /// <summary>
        /// <para>The prefix of the username. A left-match query is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("UsernameStartsWith")]
        [Validation(Required=false)]
        public string UsernameStartsWith { get; set; }

    }

}
