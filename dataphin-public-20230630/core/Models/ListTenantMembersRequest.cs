// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListTenantMembersRequest : TeaModel {
        /// <summary>
        /// <para>The request object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListTenantMembersRequestListQuery ListQuery { get; set; }
        public class ListTenantMembersRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The member roles:</para>
            /// <list type="bullet">
            /// <item><description>SUPER_ADMIN: Dataphin super administrator</description></item>
            /// <item><description>SYSTEM_ADMIN: system administrator</description></item>
            /// <item><description>COMMON_USER: Dataphin user</description></item>
            /// <item><description>DATA_ADMIN: Dataphin data administrator</description></item>
            /// <item><description>EXPORT_ADMIN: export administrator</description></item>
            /// <item><description>SECURITY_ADMIN: security administrator</description></item>
            /// <item><description>DATASOURCE_MANAGER: data source administrator</description></item>
            /// <item><description>QUALITY_MANAGER: asset quality manager</description></item>
            /// <item><description>DATA_STANDARD_MANAGER: data standard administrator</description></item>
            /// <item><description>LABELS_BUSINESS_PLANNER: tag business planner</description></item>
            /// <item><description>BUSINESS_MEMBER: general business user</description></item>
            /// <item><description>DATAPRO_OPERATE_SUPER_ADMIN: operations super administrator</description></item>
            /// <item><description>DATAPRO_OPERATE_ADMIN: operations administrator</description></item>
            /// <item><description>DATAPRO_OPERATE_MEMBER: operations member</description></item>
            /// <item><description>DATAPRO_BUSINESS_ANALYST: business analyst</description></item>
            /// <item><description>LABELS_BUSINESS_MEMBER: tag business member</description></item>
            /// <item><description>DATAPRO_BUSINESS_MEMBER: DATAPRO general business user</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RoleList")]
            [Validation(Required=false)]
            public List<string> RoleList { get; set; }

            /// <summary>
            /// <para>The search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("SearchText")]
            [Validation(Required=false)]
            public string SearchText { get; set; }

            /// <summary>
            /// <para>The IDs of the user groups to which the member belongs.</para>
            /// </summary>
            [NameInMap("UserGroupIdList")]
            [Validation(Required=false)]
            public List<string> UserGroupIdList { get; set; }

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
