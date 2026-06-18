// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUsersShrinkRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Status</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The list of usernames (EndUserId) that you want to exactly match.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The list of usernames (EndUserId) that you want to exactly exclude.</para>
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        /// <summary>
        /// <para>The ID of the user group to exclude. If specified, the query returns users who are not in this user group.</para>
        /// </summary>
        [NameInMap("ExcludeGroupId")]
        [Validation(Required=false)]
        public string ExcludeGroupId { get; set; }

        /// <summary>
        /// <para>The filter for a fuzzy search. The filter matches usernames (EndUserId) and email addresses (Email). This parameter supports the wildcard character (\*). For example, if you set this parameter to <c>a*m</c>, all results whose usernames or email addresses start with <c>a</c> and end with <c>m</c> are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a*m</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("FilterMap")]
        [Validation(Required=false)]
        public string FilterMapShrink { get; set; }

        /// <summary>
        /// <para>Filters users by whether a cloud resource is assigned.</para>
        /// </summary>
        [NameInMap("FilterWithAssignedResource")]
        [Validation(Required=false)]
        public string FilterWithAssignedResourceShrink { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available to the public.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FilterWithAssignedResources")]
        [Validation(Required=false)]
        public string FilterWithAssignedResourcesShrink { get; set; }

        /// <summary>
        /// <para>Performs an exact match by user group ID to query the list of accounts that belong to the user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ug-12341234****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Queries extended information about the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsQueryAllSubOrgs")]
        [Validation(Required=false)]
        public bool? IsQueryAllSubOrgs { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: 1 to 500.</para>
        /// </description></item>
        /// <item><description><para>Default value: 200.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query. If the number of entries returned exceeds the value of MaxResults, a token is returned. You can use this token in the next query to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Performs an exact match by organization ID to query the list of accounts that belong to the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-4mdgc1cocc59z****</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available to the public.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ShowExtras")]
        [Validation(Required=false)]
        public string ShowExtrasShrink { get; set; }

        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query users in suborganizations.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
