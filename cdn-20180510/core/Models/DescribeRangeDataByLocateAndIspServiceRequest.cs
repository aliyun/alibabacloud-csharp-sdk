// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRangeDataByLocateAndIspServiceRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time. The maximum time range that can be specified is 1 hour.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the ISP. You can specify only one ISP name in each call.
        /// 
        /// You can call the [DescribeCdnRegionAndIsp](~~91077~~) operation to query ISPs.
        /// </summary>
        [NameInMap("IspNames")]
        [Validation(Required=false)]
        public string IspNames { get; set; }

        /// <summary>
        /// The names of the regions. Separate multiple region names with commas (,).
        /// 
        /// You can call the [DescribeCdnRegionAndIsp](~~91077~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("LocationNames")]
        [Validation(Required=false)]
        public string LocationNames { get; set; }

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
