// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListOrganizationRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AAB95D7-2E11-4FE2-94BC-858E4FC0C976</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the list of organization roles.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListOrganizationRolesResponseBodyResult> Result { get; set; }
        public class ListOrganizationRolesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>List of role permission configurations.</para>
            /// </summary>
            [NameInMap("AuthConfigList")]
            [Validation(Required=false)]
            public List<ListOrganizationRolesResponseBodyResultAuthConfigList> AuthConfigList { get; set; }
            public class ListOrganizationRolesResponseBodyResultAuthConfigList : TeaModel {
                /// <summary>
                /// <para>Permission type:</para>
                /// <list type="bullet">
                /// <item><description>quick_monitor: Metric monitoring</description></item>
                /// <item><description>subscription: Subscription management</description></item>
                /// <item><description>offline_download: Self-service data retrieval</description></item>
                /// <item><description>resource_package: Resource package management</description></item>
                /// <item><description>organization_ask: Organization identification code (AK/SK)</description></item>
                /// <item><description>developer_openapi: Open API</description></item>
                /// <item><description>data_service: Data service</description></item>
                /// <item><description>admin_authorize3rd: Embedded analysis</description></item>
                /// <item><description>component_manage: Custom component</description></item>
                /// <item><description>template_open: Custom template</description></item>
                /// <item><description>custom_driver: Custom driver (supported only in standalone deployment)</description></item>
                /// <item><description>open_platform_custom_plugin: Custom plugin (supported only in standalone deployment)</description></item>
                /// <item><description>enterprise_safety: Enterprise security</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enterprise_safety</para>
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

            }

            /// <summary>
            /// <para>Whether it is a predefined role. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes</description></item>
            /// <item><description>false: No</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSystemRole")]
            [Validation(Required=false)]
            public bool? IsSystemRole { get; set; }

            /// <summary>
            /// <para>Role ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111111</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// <para>Role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Organization Admin</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>是否请求成功。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>true：请求成功</description></item>
        /// <item><description>false：请求失败</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
