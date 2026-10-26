// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryOrganizationWorkspaceListRequest : TeaModel {
        /// <summary>
        /// <para>The keyword for the workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Program</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The current page number of the workspace list.</para>
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
        /// <para>The number of entries per page in a paging query:</para>
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
        /// <para>The ID of the user in Quick BI. If you specify this parameter, the system queries all workspaces of the user in the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
