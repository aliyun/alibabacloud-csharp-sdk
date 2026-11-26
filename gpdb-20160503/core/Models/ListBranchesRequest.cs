// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListBranchesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The cursor for the paging query. You do not need to specify this parameter for the first query. For subsequent queries, use the NextToken value returned from the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>10</description></item>
        /// <item><description>20</description></item>
        /// <item><description>50</description></item>
        /// <item><description>100</description></item>
        /// </list>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the parent branch. This parameter is used to specify the parent branch for a new branch or a query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-main</para>
        /// </summary>
        [NameInMap("ParentBranchId")]
        [Validation(Required=false)]
        public string ParentBranchId { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required when you create a primary branch. When you create a child branch, the region of the primary branch is inherited by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The search keyword. Fuzzy search by branch ID or branch name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// <para>The sorting field.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BranchName: Sort by branch name.</description></item>
        /// <item><description>CreateTime: Sort by creation time.</description></item>
        /// <item><description>LastRunTime: Sort by last run time.</description></item>
        /// </list>
        /// <para>Default value: CreateTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sorting order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: Ascending order.</description></item>
        /// <item><description>Desc: Descending order.</description></item>
        /// </list>
        /// <para>Default value: Desc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
