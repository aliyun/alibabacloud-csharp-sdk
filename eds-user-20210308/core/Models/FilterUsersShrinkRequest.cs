// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of usernames to be precisely excluded.</para>
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        /// <summary>
        /// <para>The string that is used for fuzzy search. You can use usernames and email addresses to perform fuzzy search. Wildcard characters (\*) are supported for this parameter. For example, if you set this parameter to a\*m, the usernames or an email addresses that start with a or end with m are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the number of cloud desktops that are assigned to the convenience user.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDesktopCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the number of cloud desktop pools that are assigned to the convenience user.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeDesktopGroupCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopGroupCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the organization information.</para>
        /// </summary>
        [NameInMap("IncludeOrgInfo")]
        [Validation(Required=false)]
        public bool? IncludeOrgInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the supported logon types.</para>
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
        /// <para>The number of entries per page. If you set this parameter to a value greater than 100, the system resets the value to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. If not all results are returned in a query, a value is returned for the NextToken parameter. In this case, you can use the returned NextToken value to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The parameter that might affect the sorting logic.</para>
        /// </summary>
        [NameInMap("OrderParam")]
        [Validation(Required=false)]
        public string OrderParamShrink { get; set; }

        /// <summary>
        /// <para>The ID of the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-aliyun-wy-org-id</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>The activation type of the convenience account.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateFromManager: administrator-activated.</description></item>
        /// <item><description>Normal: user-activated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>The list of properties for fuzzy search.</para>
        /// </summary>
        [NameInMap("PropertyFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersShrinkRequestPropertyFilterParam> PropertyFilterParam { get; set; }
        public class FilterUsersShrinkRequestPropertyFilterParam : TeaModel {
            /// <summary>
            /// <para>The ID of the property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// <para>The IDs of the property values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PropertyValueIds")]
            [Validation(Required=false)]
            public string PropertyValueIds { get; set; }

        }

        /// <summary>
        /// <para>The list of property names and property values.</para>
        /// </summary>
        [NameInMap("PropertyKeyValueFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersShrinkRequestPropertyKeyValueFilterParam> PropertyKeyValueFilterParam { get; set; }
        public class FilterUsersShrinkRequestPropertyKeyValueFilterParam : TeaModel {
            /// <summary>
            /// <para>The property name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job</para>
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// <para>The property values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("PropertyValues")]
            [Validation(Required=false)]
            public string PropertyValues { get; set; }

        }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
