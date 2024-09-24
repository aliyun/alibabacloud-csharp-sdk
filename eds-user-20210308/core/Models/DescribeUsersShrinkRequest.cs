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
        /// The list of usernames that must be exactly matched.
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// The list of usernames to be exactly excluded.
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        /// <summary>
        /// The string that is used for fuzzy search. You perform fuzzy search by username (EndUserId) and email address (Email). Wildcard characters (\\*) are supported. For example, if you set this parameter to `a*m`, usernames or email addresses that start with `a` and end with `m` are returned.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("FilterWithAssignedResources")]
        [Validation(Required=false)]
        public string FilterWithAssignedResourcesShrink { get; set; }

        /// <summary>
        /// The ID of the organization in which you want to query convenience users.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// *   Valid values: 1 to 500
        /// *   Default value: 500
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.\\
        /// If not all results are returned in a query, a value is returned for the NextToken parameter. In this case, you can use the return value of NextToken to perform the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the organization in which you want to query users.
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("ShowExtras")]
        [Validation(Required=false)]
        public string ShowExtrasShrink { get; set; }

        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
