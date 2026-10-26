// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryOrganizationRoleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCE45E6D-9304-4F94-86BB-5A772B1615FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the organization role configuration.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryOrganizationRoleConfigResponseBodyResult Result { get; set; }
        public class QueryOrganizationRoleConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>List of role permission configurations.</para>
            /// </summary>
            [NameInMap("AuthConfigList")]
            [Validation(Required=false)]
            public List<QueryOrganizationRoleConfigResponseBodyResultAuthConfigList> AuthConfigList { get; set; }
            public class QueryOrganizationRoleConfigResponseBodyResultAuthConfigList : TeaModel {
                /// <summary>
                /// <para>Permission type:</para>
                /// <list type="bullet">
                /// <item><description>quick_monitor: Metric Monitoring</description></item>
                /// <item><description>subscription: Subscription Management</description></item>
                /// <item><description>offline_download: Self-service Data Retrieval</description></item>
                /// <item><description>resource_package: Resource Package Management</description></item>
                /// <item><description>organization_ask: Organization Access Key/Secret (AK/SK)</description></item>
                /// <item><description>developer_openapi: OpenAPI</description></item>
                /// <item><description>data_service: Data Service</description></item>
                /// <item><description>admin_authorize3rd: Embedded Analysis</description></item>
                /// <item><description>component_manage: Custom Component</description></item>
                /// <item><description>template_open: Custom Template</description></item>
                /// <item><description>custom_driver: Custom Driver (supported only in standalone deployment)</description></item>
                /// <item><description>open_platform_custom_plugin: Custom Plugin (supported only in standalone deployment)</description></item>
                /// <item><description>enterprise_safety: Enterprise Security</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>quick_monitor</para>
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
            /// <para>Organization role ID, including predefined roles and custom roles:</para>
            /// <list type="bullet">
            /// <item><description>Organization Administrator (predefined role): 111111111</description></item>
            /// <item><description>Permission Administrator (predefined role): 111111112</description></item>
            /// <item><description>Regular User (predefined role): 111111113</description></item>
            /// <item><description>Custom Role: The corresponding role ID of the custom role</description></item>
            /// </list>
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
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful </description></item>
        /// <item><description>false: The request failed</description></item>
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
