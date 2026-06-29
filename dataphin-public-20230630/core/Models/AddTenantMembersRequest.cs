// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AddTenantMembersRequest : TeaModel {
        /// <summary>
        /// <para>The request command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddCommand")]
        [Validation(Required=false)]
        public AddTenantMembersRequestAddCommand AddCommand { get; set; }
        public class AddTenantMembersRequestAddCommand : TeaModel {
            /// <summary>
            /// <para>The list of members.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<AddTenantMembersRequestAddCommandUserList> UserList { get; set; }
            public class AddTenantMembersRequestAddCommandUserList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1323241</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The list of roles. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SYSTEM_ADMIN</description></item>
                /// <item><description>DATASOURCE_MANAGER</description></item>
                /// <item><description>SECURITY_ADMIN</description></item>
                /// <item><description>QUALITY_MANAGER</description></item>
                /// <item><description>EXPORT_ADMIN</description></item>
                /// <item><description>DATA_STANDARD_MANAGER</description></item>
                /// <item><description>LABELS_BUSINESS_PLANNER</description></item>
                /// <item><description>BUSINESS_MEMBER.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("RoleList")]
                [Validation(Required=false)]
                public List<string> RoleList { get; set; }

            }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
