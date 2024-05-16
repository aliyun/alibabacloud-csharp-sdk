// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByTimeStampRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify only one domain name in each request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The names of the Internet service providers (ISPs). Separate multiple ISPs with commas (,).
        /// 
        /// You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IspNames")]
        [Validation(Required=false)]
        public string IspNames { get; set; }

        /// <summary>
        /// The regions. Separate multiple regions with commas (,).
        /// 
        /// You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocationNames")]
        [Validation(Required=false)]
        public string LocationNames { get; set; }

        /// <summary>
        /// The point in time to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The data is collected every 5 minutes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public string TimePoint { get; set; }

    }

}
