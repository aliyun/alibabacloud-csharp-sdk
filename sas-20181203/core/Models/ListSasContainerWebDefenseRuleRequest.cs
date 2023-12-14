// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// The search conditions for assets. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **name**: the name of the search condition.
        /// 
        /// *   **value**: the value of the search condition.
        /// 
        /// *   **logicalExp**: the logical relation for multiple search conditions. Valid values:
        /// 
        ///     *   **OR**: The search conditions use a logical **OR**.
        ///     *   **AND**: The search conditions use a logical **AND**.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The logical relation for multiple search conditions. Valid values:
        /// 
        /// *   **OR**: The search conditions use a logical **OR**.
        /// *   **AND**: The search conditions use a logical **AND**.
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
