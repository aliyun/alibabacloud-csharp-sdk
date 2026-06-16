// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the display name. The query is performed based on the prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("DisplayNameStartsWith")]
        [Validation(Required=false)]
        public string DisplayNameStartsWith { get; set; }

        /// <summary>
        /// <para>The email address of the user.</para>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default value is 20. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The mobile number of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156xxxxxxx</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The country calling code. For example, the country calling code of China is <c>86</c>. Do not add <c>00</c> or <c>+</c> to the country calling code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("PhoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <para>The status of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>enabled</c>: The user is enabled.</para>
        /// </description></item>
        /// <item><description><para><c>disabled</c>: The user is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The external ID of the user. The external ID can be used to associate the user with a user in an external system.</para>
        /// <remarks>
        /// <para>The external ID must be unique within the same source type and source ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>id_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("UserExternalId")]
        [Validation(Required=false)]
        public string UserExternalId { get; set; }

        /// <summary>
        /// <para>The list of user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// <para>The source ID of the user.</para>
        /// <para>If the user is created in EIAM, the value of this parameter is the ID of the EIAM instance. If the user is imported from an external system, the value of this parameter is the enterprise ID of the user in the external system. For example, if the user is imported from DingTalk, the value of this parameter is the <c>corpId</c> of the enterprise in DingTalk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("UserSourceId")]
        [Validation(Required=false)]
        public string UserSourceId { get; set; }

        /// <summary>
        /// <para>The source type of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>build_in</c>: The user is created in EIAM.</para>
        /// </description></item>
        /// <item><description><para><c>ding_talk</c>: The user is imported from DingTalk.</para>
        /// </description></item>
        /// <item><description><para><c>ad</c>: The user is imported from Active Directory (AD).</para>
        /// </description></item>
        /// <item><description><para><c>ldap</c>: The user is imported from a Lightweight Directory Access Protocol (LDAP) directory.</para>
        /// </description></item>
        /// <item><description><para><c>we_com</c>: The user is imported from WeCom.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>build_in</para>
        /// </summary>
        [NameInMap("UserSourceType")]
        [Validation(Required=false)]
        public string UserSourceType { get; set; }

        /// <summary>
        /// <para>The prefix of the username. The query is performed based on the prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("UsernameStartsWith")]
        [Validation(Required=false)]
        public string UsernameStartsWith { get; set; }

    }

}
