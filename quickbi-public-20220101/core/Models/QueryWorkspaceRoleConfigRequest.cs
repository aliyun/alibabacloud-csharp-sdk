// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorkspaceRoleConfigRequest : TeaModel {
        /// <summary>
        /// <para>Workspace role ID, including predefined roles and custom roles:</para>
        /// <list type="bullet">
        /// <item><description>25: Workspace Administrator (predefined role)</description></item>
        /// <item><description>26: Developer (predefined role)</description></item>
        /// <item><description>27: Analyst (predefined role)</description></item>
        /// <item><description>30: Viewer (predefined role)</description></item>
        /// <item><description>Custom role: The corresponding role ID for the custom role</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

    }

}
