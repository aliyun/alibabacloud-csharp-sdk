// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of excluded users.
        /// </summary>
        [NameInMap("ExcludeEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeEndUserIds { get; set; }

        /// <summary>
        /// The string that you enter for a fuzzy search. You can enter a string to match the username or email address.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// Specifies whether to return information about cloud desktops that are assigned to the convenience user.
        /// </summary>
        [NameInMap("IncludeDesktopCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopCount { get; set; }

        /// <summary>
        /// Specifies whether to return the number of desktop groups that are assigned to the user.
        /// </summary>
        [NameInMap("IncludeDesktopGroupCount")]
        [Validation(Required=false)]
        public bool? IncludeDesktopGroupCount { get; set; }

        /// <summary>
        /// The number of entries to return on each page. If you set this parameter to a value greater than 100, the system resets the value to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. You do not need to configure this parameter if you call this operation for the first time. If not all results are returned in a query, a value is returned for the NextToken parameter. In this case, you can use the returned NextToken value to perform the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The parameter that is supported to sort query results.
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
        /// Details of the user property that you want to perform fuzzy search.
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
        /// Details of the properties and property values.
        /// </summary>
        [NameInMap("PropertyKeyValueFilterParam")]
        [Validation(Required=false)]
        public List<FilterUsersShrinkRequestPropertyKeyValueFilterParam> PropertyKeyValueFilterParam { get; set; }
        public class FilterUsersShrinkRequestPropertyKeyValueFilterParam : TeaModel {
            /// <summary>
            /// The name of the property.
            /// </summary>
            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            /// <summary>
            /// The values of the property.
            /// </summary>
            [NameInMap("PropertyValues")]
            [Validation(Required=false)]
            public string PropertyValues { get; set; }

        }

    }

}
