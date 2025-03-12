// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyDatabaseUserRolesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// </summary>
        [NameInMap("TenantUser")]
        [Validation(Required=false)]
        public ModifyDatabaseUserRolesResponseBodyTenantUser TenantUser { get; set; }
        public class ModifyDatabaseUserRolesResponseBodyTenantUser : TeaModel {
            /// <summary>
            /// <para>Example 1</para>
            /// 
            /// <b>Example:</b>
            /// <para>sms_pre</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t33h8y08k****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<ModifyDatabaseUserRolesResponseBodyTenantUserUsers> Users { get; set; }
            public class ModifyDatabaseUserRolesResponseBodyTenantUserUsers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user_pay_ro</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
