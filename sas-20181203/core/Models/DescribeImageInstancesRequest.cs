// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageInstancesRequest : TeaModel {
        /// <summary>
        /// The search condition that is used to filter the server. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **name**: the search condition
        /// 
        /// *   **name**: the value of the search condition
        /// 
        /// *   **logicalExp**: the logical relation for multiple search conditions Valid values:
        /// 
        ///     *   **OR**: The search conditions use a logical **OR**.
        ///     *   **AND**: The search conditions use a logical **AND**.
        /// 
        /// > You can call the [DescribeImageCriteria](https://help.aliyun.com/document_detail/471822.html) operation to query the supported search conditions.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The logical relationship that you want to use to evaluate multiple search conditions. Valid values:
        /// 
        /// *   **OR**: The search conditions are evaluated by using a logical **OR**.
        /// *   **AND**: The search conditions are evaluated by using a logical **AND**.
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// > : We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether the image is scanned. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Scanned")]
        [Validation(Required=false)]
        public bool? Scanned { get; set; }

    }

}
