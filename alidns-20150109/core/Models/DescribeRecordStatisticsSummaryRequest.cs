// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the **YYYY-MM-DD** format.
        /// 
        /// The default value is the day when you perform the operation.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The keyword for searches in %KeyWord% mode. The value is not case-sensitive.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **100**. Minimum value: **1**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The search mode of the keyword. Valid values:
        /// 
        /// *   **LIKE**: fuzzy match (default).
        /// *   **EXACT**: exact match.
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the **YYYY-MM-DD** format.
        /// 
        /// You can only query DNS records of the last 90 days.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The threshold of query volume that can be obtained. You can also obtain data about a domain name with the query volume less than or equal to the threshold. For example, if you set this parameter to 100, you can query domain names with less than 100 queries.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
