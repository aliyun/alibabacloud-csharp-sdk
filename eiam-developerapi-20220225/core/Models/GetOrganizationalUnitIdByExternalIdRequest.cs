// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetOrganizationalUnitIdByExternalIdRequest : TeaModel {
        /// <summary>
        /// <para>The external ID of the organizational unit. The external ID can be used to map external data to the data of the organizational unit in Employee Identity and Access Management (EIAM) of Identity as a Service (IDaaS). By default, the external ID is the organizational unit ID.</para>
        /// <para>Note: For organizational units with the same source type and source ID, each organizational unit has a unique external ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("organizationalUnitExternalId")]
        [Validation(Required=false)]
        public string OrganizationalUnitExternalId { get; set; }

        /// <summary>
        /// <para>The source ID of the organizational unit.</para>
        /// <para>If the organizational unit was created in IDaaS, its source ID is the ID of the IDaaS instance. If the organizational unit was imported, its source ID is the enterprise ID in the source. For example, if the organizational unit was imported from DingTalk, its source ID is the corpId value of the enterprise in DingTalk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("organizationalUnitSourceId")]
        [Validation(Required=false)]
        public string OrganizationalUnitSourceId { get; set; }

        /// <summary>
        /// <para>The source type of the organizational unit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>build_in: The organizational unit was created in IDaaS.</description></item>
        /// <item><description>ding_talk: The organizational unit was imported from DingTalk.</description></item>
        /// <item><description>ad: The organizational unit was imported from Microsoft Active Directory (AD).</description></item>
        /// <item><description>ldap: The organizational unit was imported from a Lightweight Directory Access Protocol (LDAP) service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>build_in</para>
        /// </summary>
        [NameInMap("organizationalUnitSourceType")]
        [Validation(Required=false)]
        public string OrganizationalUnitSourceType { get; set; }

    }

}
