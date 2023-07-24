// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeDetailDataRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. Separate multiple accelerated domain names with commas (,).
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time, and the maximum time range to query is 10 minutes.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of information that you want to query. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   **qps**: queries per second (QPS)
        /// *   **bps**: bandwidth
        /// *   **http_code**: HTTP status code
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The name of the ISP. You can call the [DescribeDcdnRegionAndIsp](~~207199~~) operation to query the ISP name.
        /// 
        /// If you leave this parameter empty, all ISPs are queried.
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The name of the region. You can call the [DescribeDcdnRegionAndIsp](~~207199~~) operation to query the region name.
        /// 
        /// If you leave this parameter empty, all regions are queried.
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// Specifies whether to return a summary value. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("Merge")]
        [Validation(Required=false)]
        public string Merge { get; set; }

        /// <summary>
        /// Specifies whether to return a summary value of **LocationNameEn** and **IspNameEn**. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("MergeLocIsp")]
        [Validation(Required=false)]
        public string MergeLocIsp { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
