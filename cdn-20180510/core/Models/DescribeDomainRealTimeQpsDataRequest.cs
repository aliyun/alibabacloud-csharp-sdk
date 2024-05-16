// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainRealTimeQpsDataRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. Separate multiple accelerated domain names with commas (,).
        /// 
        /// > You can specify up to 500 domain names in each request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the Internet service provider (ISP).
        /// 
        /// If you do not set this parameter, data of all ISPs is queried. You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query ISP names.
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The name of the region.
        /// 
        /// If you do not set this parameter, data in all regions is queried. You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query regions.
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
