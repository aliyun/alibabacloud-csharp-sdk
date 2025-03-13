// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetOrganizationalUnitResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the organizational unit was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652083425923</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the organizational unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The external ID of the organizational unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("organizationalUnitExternalId")]
        [Validation(Required=false)]
        public string OrganizationalUnitExternalId { get; set; }

        /// <summary>
        /// <para>The ID of the organizational unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("organizationalUnitId")]
        [Validation(Required=false)]
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// <para>The name of the organizational unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name001</para>
        /// </summary>
        [NameInMap("organizationalUnitName")]
        [Validation(Required=false)]
        public string OrganizationalUnitName { get; set; }

        /// <summary>
        /// <para>The source ID of the organizational unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("organizationalUnitSourceId")]
        [Validation(Required=false)]
        public string OrganizationalUnitSourceId { get; set; }

        /// <summary>
        /// <para>The source type of the organizational unit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>build_in: The organizational unit was created in Identity as a Service (IDaaS).</description></item>
        /// <item><description>ding_talk: The organizational unit was imported from DingTalk.</description></item>
        /// <item><description>ad: The organizational unit was imported from Microsoft Active Directory (AD).</description></item>
        /// <item><description>ldap: The organizational unit was imported from a Lightweight Directory Access Protocol (LDAP) service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>build_in</para>
        /// </summary>
        [NameInMap("organizationalUnitSourceType")]
        [Validation(Required=false)]
        public string OrganizationalUnitSourceType { get; set; }

        /// <summary>
        /// <para>The ID of the parent organizational unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The time when the organizational unit was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652083425923</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
