// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUsersRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The list of usernames (EndUserId) for exact match.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The list of usernames (EndUserId) to exclude exactly.</para>
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        [NameInMap("ExcludeGroupId")]
        [Validation(Required=false)]
        public string ExcludeGroupId { get; set; }

        /// <summary>
        /// <para>The fuzzy search string that supports matching by username (EndUserId) and email (Email). This field supports wildcards (*). For example, if you set this field to <c>a*m</c>, all results whose username or email starts with <c>a</c> and ends with <c>m</c> are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a*m</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("FilterMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> FilterMap { get; set; }

        [NameInMap("FilterWithAssignedResource")]
        [Validation(Required=false)]
        public Dictionary<string, string> FilterWithAssignedResource { get; set; }

        /// <summary>
        /// <para>Filters users based on whether cloud resources are assigned.</para>
        /// </summary>
        [NameInMap("FilterWithAssignedResources")]
        [Validation(Required=false)]
        public Dictionary<string, bool?> FilterWithAssignedResources { get; set; }

        /// <summary>
        /// <para>Performs an exact match by user group ID and queries the list of accounts that belong to the specified user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ug-12341234****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query users in sub-organizations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsQueryAllSubOrgs")]
        [Validation(Required=false)]
        public bool? IsQueryAllSubOrgs { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.  </para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 500.  </description></item>
        /// <item><description>Default value: 200.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. You do not need to set this parameter for the first request. If not all results are returned in a single query, a non-empty NextToken is returned. You can pass the returned NextToken in subsequent requests to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Performs an exact match by organization ID and queries the list of accounts that belong to the specified organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-4mdgc1cocc59z****</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>Queries extended user information.</para>
        /// </summary>
        [NameInMap("ShowExtras")]
        [Validation(Required=false)]
        public Dictionary<string, object> ShowExtras { get; set; }

        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
