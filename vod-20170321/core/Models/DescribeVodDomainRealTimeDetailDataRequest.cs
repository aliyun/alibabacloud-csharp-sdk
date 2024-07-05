// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeDetailDataRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name. You can specify a maximum of 20 accelerated domain names in each call. Separate domain names with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2019-11-30T05:40:00Z.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of data that you want to query. You can specify multiple data types and separate them with commas (,). Valid values:
        /// 
        /// qps: the number of queries per second bps: bandwidth data http_code: HTTP status codes
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The name of the Internet service provider (ISP).
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The name of the region. If you do not specify a region, data in all regions is queried.
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// Specifies whether to return a summary value. Valid values:
        /// 
        /// true false (default)
        /// </summary>
        [NameInMap("Merge")]
        [Validation(Required=false)]
        public string Merge { get; set; }

        /// <summary>
        /// Specifies whether to return a summary value. Valid values:
        /// 
        /// *   **true**: groups the results by domain name and merges the results by region and ISP.
        /// *   **false**: groups the results by domain name.
        /// 
        /// Default value: **false**.
        /// </summary>
        [NameInMap("MergeLocIsp")]
        [Validation(Required=false)]
        public string MergeLocIsp { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2019-11-30T05:33:00Z.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
