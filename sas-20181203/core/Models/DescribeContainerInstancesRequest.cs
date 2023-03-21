// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerInstancesRequest : TeaModel {
        /// <summary>
        /// The search conditions that are used to filter containers. The value of this parameter is in the JSON format and is case-sensitive. The value contains the following fields:
        /// 
        /// *   **name**: the search condition.
        /// 
        /// *   **name**: the value of the search condition.
        /// 
        /// *   **logicalExp**: the logical relationship among multiple search conditions. Valid values:
        /// 
        ///     *   **OR**: Search conditions are evaluated by using a logical **OR**.
        ///     *   **AND**: Search conditions are evaluated by using a logical **AND**.
        /// 
        /// > You can use search conditions such as the container ID, cluster ID, cluster name, cluster type, risk level, and region. You can call the [DescribeContainerCriteria](~~DescribeContainerCriteria~~) operation to query the supported search conditions.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The logical operator that you want to use to evaluate multiple search conditions. Valid values:
        /// 
        /// *   **OR**: Search conditions are evaluated by using a logical **OR**.
        /// *   **AND**: Search conditions are evaluated by using a logical **AND**.
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
