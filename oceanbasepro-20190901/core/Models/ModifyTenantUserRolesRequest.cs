// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserRolesRequest : TeaModel {
        [NameInMap("GlobalPermissions")]
        [Validation(Required=false)]
        public string GlobalPermissions { get; set; }

        /// <summary>
        /// <para>The type of the privilege modification operation.<br>Valid values:<br>update: updates all privileges. This is the default value.<br>add: adds a privilege.<br>delete: deletes a privilege.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>ModifyTenantUserRoles</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob2mr3oae0****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The role of the database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pay_test</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The type of the account. Valid values:   </para>
        /// <list type="bullet">
        /// <item><description>Admin: the super administrator account.   </description></item>
        /// <item><description>Normal: a general account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Database&quot;:&quot;20210824160559&quot;,&quot;Role&quot;:&quot;readwrite&quot;}]</para>
        /// </summary>
        [NameInMap("UserRole")]
        [Validation(Required=false)]
        public string UserRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
