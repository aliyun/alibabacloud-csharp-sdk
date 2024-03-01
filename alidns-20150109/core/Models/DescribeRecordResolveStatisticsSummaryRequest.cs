// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordResolveStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// The order in which the returned entries are sorted. Valid values:
        /// 
        /// *   DESC (default): descending order
        /// *   ASC: ascending order
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The type of the domain name. The parameter value is not case-sensitive. Valid values:
        /// 
        /// *   PUBLIC (default): hosted public domain name
        /// *   CACHE: cache-accelerated domain name
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// The end date of the time range to be queried. Specify the time in the yyyy-MM-dd format, such as 2023-03-13.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The keyword. Keyword is used together with SearchMode.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The language. Valid values: zh, en, and ja.
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
        /// *   LIKE (default): fuzzy search
        /// *   EXACT: exact search
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// The start date of the time range to be queried. Specify the time in the yyyy-MM-dd format, such as 2023-03-01.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The threshold for the number of Domain Name System (DNS) requests. You can query the subdomain names at the specified quantity level of DNS requests and query the number of DNS requests for each subdomain name.
        /// 
        /// If you do not specify this parameter, the data about the subdomain names that have DNS requests is obtained.
        /// 
        /// If you set this parameter to a value less than 0, the data about all subdomain names is obtained.
        /// 
        /// If you set this parameter to 0, the data about the subdomain names that do not have DNS requests is obtained.
        /// 
        /// If you set this parameter to a value greater than 0, the data about the subdomain names whose number of DNS requests is less than or equal to the value of this parameter is obtained.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
