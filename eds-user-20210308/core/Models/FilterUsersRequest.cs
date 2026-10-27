// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersRequest : TeaModel {
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
        /// <para>The list of usernames (EndUserIds) to exclude by exact match.</para>
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        /// <summary>
        /// <para>The fuzzy search string. This parameter supports matching the username (EndUserId) and email address (Email). Wildcards (<em>) are supported. For example, if you set this parameter to a</em>m, all results where the username or email address starts with a and ends with m are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a*m</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The fuzzy match condition mapping for user information. This parameter supports fields such as the username, remarks, phone number, email address, nickname, and employee ID.</para>
        /// </summary>
        [NameInMap("FilterMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> FilterMap { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the number of cloud computers assigned to the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDesktopCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the number of cloud computer pools assigned to the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeDesktopGroupCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopGroupCount { get; set; }

        /// <summary>
        /// <para>The list of convenience account usernames to include in the query results.</para>
        /// </summary>
        [NameInMap("IncludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> IncludeEndUserIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to include organization information.</para>
        /// </summary>
        [NameInMap("IncludeOrgInfo")]
        [Validation(Required=false)]
        public bool? IncludeOrgInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the supported logon types.</para>
        /// </summary>
        [NameInMap("IncludeSupportIdps")]
        [Validation(Required=false)]
        public bool? IncludeSupportIdps { get; set; }

        /// <summary>
        /// <para>Specifies whether to query all sub-organizations.</para>
        /// </summary>
        [NameInMap("IsQueryAllSubOrgs")]
        [Validation(Required=false)]
        public bool? IsQueryAllSubOrgs { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. If the value exceeds 100, it is automatically reset to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. You do not need to specify this parameter when you call this operation for the first time. If the response does not contain all results, a non-empty NextToken is returned. You can use the returned NextToken in subsequent queries to obtain the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The supported sorting parameters.</para>
        /// </summary>
        [NameInMap("OrderParam")]
        [Validation(Required=false)]
        public FilterUsersRequestOrderParam OrderParam { get; set; }
        public class FilterUsersRequestOrderParam : TeaModel {
            /// <summary>
            /// <para>The field by which to sort.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("OrderField")]
            [Validation(Required=false)]
            public string OrderField { get; set; }

            /// <summary>
            /// <para>The sort order, which can be ascending or descending.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DESC</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the enterprise organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-aliyun-wy-org-id</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>The account activation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>The list of user attributes for fuzzy queries.</para>
        /// </summary>
        [NameInMap("PropertyFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersRequestPropertyFilterParam> PropertyFilterParam { get; set; }
        public class FilterUsersRequestPropertyFilterParam : TeaModel {
            /// <summary>
            /// <para>The ID of the attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>328</para>
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// <para>The IDs of the attribute values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1255</para>
            /// </summary>
            [NameInMap("PropertyValueIds")]
            [Validation(Required=false)]
            public string PropertyValueIds { get; set; }

        }

        /// <summary>
        /// <para>The list of attribute names and attribute values.</para>
        /// </summary>
        [NameInMap("PropertyKeyValueFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersRequestPropertyKeyValueFilterParam> PropertyKeyValueFilterParam { get; set; }
        public class FilterUsersRequestPropertyKeyValueFilterParam : TeaModel {
            /// <summary>
            /// <para>The name of the attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job</para>
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// <para>The values of the attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("PropertyValues")]
            [Validation(Required=false)]
            public string PropertyValues { get; set; }

        }

        /// <summary>
        /// <para>The switch mapping for additional response information. This parameter controls whether to include desktop policy information.</para>
        /// </summary>
        [NameInMap("ShowExtras")]
        [Validation(Required=false)]
        public Dictionary<string, string> ShowExtras { get; set; }

        /// <summary>
        /// <para>The user status used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
