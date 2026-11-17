// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteUsersRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>This field is not available for use. You can only set this parameter to <c>1</c> or leave it empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AssignedInfo")]
        [Validation(Required=false)]
        public string AssignedInfo { get; set; }

        /// <summary>
        /// <para>The fuzzy query string.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em>jin</em></para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only the users to which cloud desktops are assigned.</para>
        /// </summary>
        [NameInMap("IncludeAssignedUser")]
        [Validation(Required=false)]
        public bool? IncludeAssignedUser { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.    </para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100.    </description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Leave this parameter empty for the first query or when no subsequent query is required. For subsequent queries, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The specified organizational unit (OU) of the AD domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com/Domain Controllers</para>
        /// </summary>
        [NameInMap("OUPath")]
        [Validation(Required=false)]
        public string OUPath { get; set; }

        /// <summary>
        /// <para>The office network ID. Only office networks based on enterprise AD accounts are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The sorting method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

    }

}
