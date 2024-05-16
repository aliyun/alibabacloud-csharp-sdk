// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainHttpCodeDataByLayerRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify up to 500 domain names in each request. Separate multiple domain names with commas (,).
        /// 
        /// If you do not specify this parameter, data of all accelerated domain names under your account is queried.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
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
        /// The name of the Internet service provider (ISP). You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query ISP names.
        /// 
        /// If you do not specify an ISP, data of all ISPs is queried.
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The protocol by which you want to query HTTP status codes. The network layer supports **IPv4** and **IPv6**. The application layer supports **http**, **https**, and **quic**. You can also set the value to **all**.
        /// 
        /// Default value: **all**
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// The name of the region. You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query regions.
        /// 
        /// If you do not specify a region, data in all regions is queried.
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
