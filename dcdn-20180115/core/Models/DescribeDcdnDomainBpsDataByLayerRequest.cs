// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainBpsDataByLayerRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. Separate mutiple domain names with commas (,). You can specify up to 500 domain names in each request. The query results of multiple domain names are aggregated.
        /// 
        /// If you do not specify a domain name, data of all domain names is queried.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// >  The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The time granularity of the data entries. Unit: seconds.
        /// 
        /// The time granularity varies with the maximum time range per query. Valid values: 300 (5 minutes), 3600 (1 hour), and 86400 (1 day). For more information, see **Usage notes**.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The Internet service provider (ISP) name. You can call the [DescribeDcdnRegionAndIsp](~~207199~~) operation to query the ISP name. If you do not specify this parameter, all ISPs are queried.
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The layer at which you want to query the bandwidth data. The network layer supports IPv4 and IPv6. The application layer supports http, https, and quic. You can also set the value to all.
        /// 
        /// Default value: all.
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// The region name. You can call the [DescribeDcdnRegionAndIsp](~~207199~~) operation to query regions. If you do not specify this parameter, all regions are queried.
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// The minimum data granularity is 5 minutes.
        /// 
        /// If you do not set this parameter, data in the last 24 hours is queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
