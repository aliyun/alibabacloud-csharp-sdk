// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListWorkspaceRolesRequest : TeaModel {
        /// <summary>
        /// <para>The sort order for the specified sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ASC</c> (default): Ascending order.</para>
        /// </description></item>
        /// <item><description><para><c>DESC</c>: Descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A comma-separated list of role IDs.</para>
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
        /// <para>The role type.</para>
        /// <list type="bullet">
        /// <item><description><c>custom</c>: A custom role.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>The sort field for paginated queries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>GmtCreateTime</c> (default): Sorts by creation time.</para>
        /// </description></item>
        /// <item><description><para><c>GmtModifiedTime</c>: Sorts by modification time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Creating</c></para>
        /// </description></item>
        /// <item><description><para><c>Updating</c></para>
        /// </description></item>
        /// <item><description><para><c>Deleting</c></para>
        /// </description></item>
        /// <item><description><para><c>Succeeded</c>: A terminal state.</para>
        /// </description></item>
        /// <item><description><para><c>Failed</c>: A terminal state.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A comma-separated list of fields to return. Currently, only <c>ModulePermissions</c> is supported, which returns the permission configuration of the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModulePermissions</para>
        /// </summary>
        [NameInMap("VerboseFields")]
        [Validation(Required=false)]
        public string VerboseFields { get; set; }

    }

}
