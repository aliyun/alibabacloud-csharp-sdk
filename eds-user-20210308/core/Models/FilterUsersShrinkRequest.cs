// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersShrinkRequest : TeaModel {
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
        /// <para>The usernames (<c>EndUserId</c>) to exclude by exact match.</para>
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        /// <summary>
        /// <para>The string for a fuzzy search on the username (<c>EndUserId</c>) and email address (<c>Email</c>). The wildcard character (<c>*</c>) is supported. For example, if you set this parameter to <c>a*m</c>, the query returns all results where the username or email address starts with <c>a</c> and ends with <c>m</c>.</para>
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
        /// <para>Specifies whether to return the number of cloud desktops that are assigned to the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDesktopCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the number of desktop groups that are assigned to the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeDesktopGroupCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopGroupCount { get; set; }

        [NameInMap("IncludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> IncludeEndUserIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to include organization information in the response.</para>
        /// </summary>
        [NameInMap("IncludeOrgInfo")]
        [Validation(Required=false)]
        public bool? IncludeOrgInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the supported logon types in the response.</para>
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
        /// <para>The number of entries per page. If you specify a value greater than 100, the system automatically sets this parameter to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. If the number of results exceeds the value of the <c>MaxResults</c> parameter, a <c>NextToken</c> is returned. You can use the <c>NextToken</c> to query the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sorting parameters.</para>
        /// </summary>
        [NameInMap("OrderParam")]
        [Validation(Required=false)]
        public string OrderParamShrink { get; set; }

        /// <summary>
        /// <para>The organization ID.</para>
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
        /// <para>The user properties for a fuzzy search.</para>
        /// </summary>
        [NameInMap("PropertyFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersShrinkRequestPropertyFilterParam> PropertyFilterParam { get; set; }
        public class FilterUsersShrinkRequestPropertyFilterParam : TeaModel {
            /// <summary>
            /// <para>The property ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>328</para>
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// <para>The property value ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1255</para>
            /// </summary>
            [NameInMap("PropertyValueIds")]
            [Validation(Required=false)]
            public string PropertyValueIds { get; set; }

        }

        /// <summary>
        /// <para>The information about property keys and property values.</para>
        /// </summary>
        [NameInMap("PropertyKeyValueFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersShrinkRequestPropertyKeyValueFilterParam> PropertyKeyValueFilterParam { get; set; }
        public class FilterUsersShrinkRequestPropertyKeyValueFilterParam : TeaModel {
            /// <summary>
            /// <para>The property key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job</para>
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// <para>The property value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("PropertyValues")]
            [Validation(Required=false)]
            public string PropertyValues { get; set; }

        }

        [NameInMap("ShowExtras")]
        [Validation(Required=false)]
        public Dictionary<string, string> ShowExtras { get; set; }

        /// <summary>
        /// <para>The user status by which to filter the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
