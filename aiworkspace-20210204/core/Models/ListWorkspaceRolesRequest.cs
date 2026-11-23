// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListWorkspaceRolesRequest : TeaModel {
        /// <summary>
        /// <para>The sorting order for the specified sorting field in paging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: Ascending order. Default value.</description></item>
        /// <item><description>DESC: Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of role IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>role-dhg*******</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// <para>The role name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev-test</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The role type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>custom: custom role.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>The sorting field for paging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtCreateTime: Sort by creation time. Default value.</description></item>
        /// <item><description>GmtModifiedTime: Sort by modification time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The comma-separated list of fields to return. Currently, only ModulePermissions is supported, which indicates whether to return the permission configurations of the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModulePermissions</para>
        /// </summary>
        [NameInMap("VerboseFields")]
        [Validation(Required=false)]
        public string VerboseFields { get; set; }

    }

}
