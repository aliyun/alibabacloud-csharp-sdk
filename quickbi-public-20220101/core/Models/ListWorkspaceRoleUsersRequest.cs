// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListWorkspaceRoleUsersRequest : TeaModel {
        /// <summary>
        /// <para>Keyword for the user\&quot;s nickname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试pop用户</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Current page number for pagination:</para>
        /// <list type="bullet">
        /// <item><description>Starting value: 1</description></item>
        /// <item><description>Default value: 1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of items per page for pagination:</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10</description></item>
        /// <item><description>Maximum value: 1000</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Workspace role ID, including predefined roles and custom roles:</para>
        /// <list type="bullet">
        /// <item><description>25: Workspace Administrator (predefined role)</description></item>
        /// <item><description>26: Developer (predefined role)</description></item>
        /// <item><description>27: Analyst (predefined role)</description></item>
        /// <item><description>30: Viewer (predefined role)</description></item>
        /// <item><description>Custom roles: The corresponding role ID for custom roles</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

        /// <summary>
        /// <para>Workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>726bee5a-****-43e1-9a8e-b550f0120f35</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
