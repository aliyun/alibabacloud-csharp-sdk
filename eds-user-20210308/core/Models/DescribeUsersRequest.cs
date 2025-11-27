// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUsersRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The usernames that must be exactly matched.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The usernames that must be exactly excluded.</para>
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        [NameInMap("ExcludeGroupId")]
        [Validation(Required=false)]
        public string ExcludeGroupId { get; set; }

        /// <summary>
        /// <para>The string that is used for fuzzy search. You perform fuzzy search by username (EndUserId) and email address (Email). Wildcard characters (\*) are supported. For example, if you set this parameter to <c>a*m</c>, usernames or email addresses that start with <c>a</c> and end with <c>m</c> are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a*m</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("FilterWithAssignedResource")]
        [Validation(Required=false)]
        public Dictionary<string, string> FilterWithAssignedResource { get; set; }

        [NameInMap("FilterWithAssignedResources")]
        [Validation(Required=false)]
        public Dictionary<string, bool?> FilterWithAssignedResources { get; set; }

        /// <summary>
        /// <para>The ID of the organization in which you want to query convenience users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ug-12341234****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsQueryAllSubOrgs")]
        [Validation(Required=false)]
        public bool? IsQueryAllSubOrgs { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 500.</description></item>
        /// <item><description>Default value: 500.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.\
        /// If not all results are returned in a query, a value is returned for the NextToken parameter. In this case, you can use the return value of NextToken to perform the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the organization in which you want to query users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-4mdgc1cocc59z****</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("ShowExtras")]
        [Validation(Required=false)]
        public Dictionary<string, object> ShowExtras { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
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
