// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GrantUserPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The permissions that are granted to an entity. The content is a string that consists of JSON arrays. You must specify all permissions that you want to grant to an entity. You can add or remove permissions by modifying the content. Field definition of the sample code:</para>
        /// <list type="bullet">
        /// <item><description><c>IsCustom</c>: a parameter that is required by the system. Set the value to <c>true</c>.</description></item>
        /// <item><description><c>Cluster</c>: the ID of the Service Mesh (ASM) instance.</description></item>
        /// <item><description><c>RoleName</c>: the name of the permissions. Valid values: <c>istio-admin</c>, <c>istio-ops</c>, and <c>istio-readonly</c>. A value of istio-admin indicates the permissions of ASM administrators. A value of istio-ops indicates the permissions of ASM restricted users. A value of istio-readonly indicates the read-only permissions.</description></item>
        /// <item><description><c>IsRamRole</c>: the entity to which you want to grant the permissions. To grant the permissions to a RAM role, set the value to <c>true</c>. Otherwise, set the value to <c>false</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;IsCustom&quot;:true,&quot;RoleName&quot;:&quot;istio-ops&quot;,&quot;Cluster&quot;:&quot;c57b848115458460583a4260cb713****&quot;,&quot;RoleType&quot;:&quot;custom&quot;,&quot;IsRamRole&quot;:false},{&quot;IsCustom&quot;:true,&quot;RoleName&quot;:&quot;istio-ops&quot;,&quot;Cluster&quot;:&quot;c4ec191f4e12145c09286ea3e2b8f****&quot;,&quot;RoleType&quot;:&quot;custom&quot;,&quot;IsRamRole&quot;:false}]</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user or RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27852573609480****</para>
        /// </summary>
        [NameInMap("SubAccountUserId")]
        [Validation(Required=false)]
        public string SubAccountUserId { get; set; }

        /// <summary>
        /// <para>The IDs of RAM users or RAM roles. You can grant permissions to multiple users at a time.</para>
        /// </summary>
        [NameInMap("SubAccountUserIds")]
        [Validation(Required=false)]
        public List<string> SubAccountUserIds { get; set; }

    }

}
