// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserRolesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// </summary>
        [NameInMap("TenantUser")]
        [Validation(Required=false)]
        public ModifyTenantUserRolesResponseBodyTenantUser TenantUser { get; set; }
        public class ModifyTenantUserRolesResponseBodyTenantUser : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>t33h8y08k****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pay_test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The name of the database (MySQL mode) or schema (Oracle mode).</para>
            /// 
            /// <b>Example:</b>
            /// <para>账号具备的数据库权限信息列表。</para>
            /// </summary>
            [NameInMap("UserRole")]
            [Validation(Required=false)]
            public List<ModifyTenantUserRolesResponseBodyTenantUserUserRole> UserRole { get; set; }
            public class ModifyTenantUserRolesResponseBodyTenantUserUserRole : TeaModel {
                /// <summary>
                /// <pre><c>http(s)://[Endpoint]/?Action=ModifyTenantUserRoles
                /// &amp;UserName=pay_test
                /// &amp;TenantId=ob2mr3oae0****
                /// &amp;UserRole=[{&quot;Database&quot;:&quot;20210824160559&quot;,&quot;Role&quot;:&quot;readwrite&quot;}]
                /// &amp;InstanceId=ob317v4uif****
                /// &amp;ModifyType=update
                /// &amp;Common request parameters
                /// </c></pre>
                /// 
                /// <b>Example:</b>
                /// <para>db_pay1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public bool? IsSuccess { get; set; }

                /// <summary>
                /// <para>You can call this operation to modify the database privileges of a specified account in a tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tbl_pay1</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

        }

    }

}
