// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersShrinkRequest : TeaModel {
        /// <summary>
        /// The list of usernames to be precisely excluded.
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        /// <summary>
        /// The string that is used for fuzzy search. You can use usernames and email addresses to perform fuzzy search. Wildcard characters (\\*) are supported for this parameter. For example, if you set this parameter to a\\*m, the usernames or an email addresses that start with a or end with m are returned.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// Specifies whether to return the number of cloud desktops that are assigned to the convenience user.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("IncludeDesktopCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopCount { get; set; }

        /// <summary>
        /// Specifies whether to return the number of cloud desktop pools that are assigned to the convenience user.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("IncludeDesktopGroupCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopGroupCount { get; set; }

        /// <summary>
        /// The number of entries per page. If you set this parameter to a value greater than 100, the system resets the value to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. If not all results are returned in a query, a value is returned for the NextToken parameter. In this case, you can use the returned NextToken value to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The parameters that are used to sort query results.
        /// </summary>
        [NameInMap("OrderParam")]
        [Validation(Required=false)]
        public string OrderParamShrink { get; set; }

        /// <summary>
        /// The ID of the organization.
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// The type of the account ownership.
        /// </summary>
        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// The list of properties for fuzzy search.
        /// </summary>
        [NameInMap("PropertyFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersShrinkRequestPropertyFilterParam> PropertyFilterParam { get; set; }
        public class FilterUsersShrinkRequestPropertyFilterParam : TeaModel {
            /// <summary>
            /// The ID of the property.
            /// </summary>
            [NameInMap("PropertyId")]
            [Validation(Required=false)]
            public long? PropertyId { get; set; }

            /// <summary>
            /// The IDs of the property values.
            /// </summary>
            [NameInMap("PropertyValueIds")]
            [Validation(Required=false)]
            public string PropertyValueIds { get; set; }

        }

        /// <summary>
        /// The list of property names and property values.
        /// </summary>
        [NameInMap("PropertyKeyValueFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersShrinkRequestPropertyKeyValueFilterParam> PropertyKeyValueFilterParam { get; set; }
        public class FilterUsersShrinkRequestPropertyKeyValueFilterParam : TeaModel {
            /// <summary>
            /// The property name.
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// The property values.
            /// </summary>
            [NameInMap("PropertyValues")]
            [Validation(Required=false)]
            public string PropertyValues { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
