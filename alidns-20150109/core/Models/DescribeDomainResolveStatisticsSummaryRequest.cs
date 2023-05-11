// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainResolveStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// The order in which you want to sort the query results. Valid values: DESC and ASC. DESC indicates that the query results are sorted in descending order. ASC indicates that the query results are sorted in ascending order.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The end time in the yyyy-MM-dd format, for example, 2023-03-13.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The keyword. The Keyword parameter must be used together with the SearchMode parameter.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The language used. Valid values: zh, en, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The search mode of the keyword. Valid values:
        /// 
        /// LIKE and EXACT. LIKE is the default value and indicates the fuzzy search mode. EXACT indicates the exact match mode.
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// The start time in the yyyy-MM-dd format, for example, 2023-03-01.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The threshold for the number of resolution requests. You can query the paid domain names at the specified quantity level of resolution requests and query the number of resolution requests. For example, if you set this parameter to 100, you can obtain data about the paid domain names with less than 100 resolution requests. If you do not specify this parameter, the data about the paid domain names that have resolution requests is obtained. If you set this parameter to a value less than 0, the data about all paid domain names is obtained. If you set this parameter to 0, the data about the paid domain names that do not have resolution requests is obtained. If you set this parameter to a value greater than 0, the data about the paid domain names whose number of resolution requests is less than or equal to the value of this parameter is obtained.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
