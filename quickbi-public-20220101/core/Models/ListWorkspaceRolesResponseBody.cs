// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListWorkspaceRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of workspace roles.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListWorkspaceRolesResponseBodyResult> Result { get; set; }
        public class ListWorkspaceRolesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>List of role authorization configurations.</para>
            /// </summary>
            [NameInMap("AuthConfigList")]
            [Validation(Required=false)]
            public List<ListWorkspaceRolesResponseBodyResultAuthConfigList> AuthConfigList { get; set; }
            public class ListWorkspaceRolesResponseBodyResultAuthConfigList : TeaModel {
                /// <summary>
                /// <para>Authorization scope.</para>
                /// </summary>
                [NameInMap("ActionAuthKeys")]
                [Validation(Required=false)]
                public List<string> ActionAuthKeys { get; set; }

                /// <summary>
                /// <para>Authorization type:</para>
                /// <list type="bullet">
                /// <item><description>portal_create: Data Portal</description></item>
                /// <item><description>dashboard_create: Dashboard</description></item>
                /// <item><description>report_create: Spreadsheet</description></item>
                /// <item><description>screen_create: Data Screen</description></item>
                /// <item><description>analysis: Ad-hoc Analysis</description></item>
                /// <item><description>offline_download: Self-service Data Retrieval</description></item>
                /// <item><description>data_form: Data Entry</description></item>
                /// <item><description>quick_etl: Data Preparation</description></item>
                /// <item><description>cube: Dataset</description></item>
                /// <item><description>datasource: Data Source</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>portal_create</para>
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

            }

            /// <summary>
            /// <para>Whether it is a predefined role. Value range:</para>
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
            /// <para>Workspace role ID, including predefined and custom roles:</para>
            /// <list type="bullet">
            /// <item><description>25: Workspace Administrator (predefined role)</description></item>
            /// <item><description>26: Developer (predefined role)</description></item>
            /// <item><description>27: Analyst (predefined role)</description></item>
            /// <item><description>30: Viewer (predefined role)</description></item>
            /// <item><description>Custom role: The corresponding role ID for a custom role</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// <para>Role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Space administrator</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful. </description></item>
        /// <item><description>false: The request failed.</description></item>
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
