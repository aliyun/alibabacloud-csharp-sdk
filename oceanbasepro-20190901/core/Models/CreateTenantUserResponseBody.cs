// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of database accounts in the tenant.</para>
        /// </summary>
        [NameInMap("TenantUser")]
        [Validation(Required=false)]
        public CreateTenantUserResponseBodyTenantUser TenantUser { get; set; }
        public class CreateTenantUserResponseBodyTenantUser : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Encrypt,Decrypt</para>
            /// </summary>
            [NameInMap("GlobalPermissions")]
            [Validation(Required=false)]
            public string GlobalPermissions { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<CreateTenantUserResponseBodyTenantUserRoles> Roles { get; set; }
            public class CreateTenantUserResponseBodyTenantUserRoles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>db_pay1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pay_test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
