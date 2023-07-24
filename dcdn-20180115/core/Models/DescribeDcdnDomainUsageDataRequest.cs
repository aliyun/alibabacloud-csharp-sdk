// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainUsageDataRequest : TeaModel {
        /// <summary>
        /// The billable region. Valid values:
        /// 
        /// *   **CN**: Chinese mainland
        /// *   **OverSeas**: outside the Chinese mainland
        /// *   **AP1**: Asia Pacific 1
        /// *   **AP2**: Asia Pacific 2
        /// *   **AP3**: Asia Pacific 3
        /// *   **NA**: North America
        /// *   **SA**: South America
        /// *   **EU**: Europe
        /// *   **MEAA**: Middle East and Africa
        /// *   **all**: all the preceding billable regions
        /// 
        /// Default value: **CN**
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// The protocol by which the data is queried. Valid values:
        /// 
        /// *   **quic**: Quick UDP Internet Connections (QUIC)
        /// *   **https**: HTTPS
        /// *   **http**: HTTP
        /// *   **all**: HTTP, HTTPS, and QUIC
        /// 
        /// Default value: **all**
        /// </summary>
        [NameInMap("DataProtocol")]
        [Validation(Required=false)]
        public string DataProtocol { get; set; }

        /// <summary>
        /// The accelerated domain name. You can specify up to 100 domain names in each request. Separate multiple domain names with commas (,).
        /// 
        /// > If you do not specify this parameter, the usage data of all accelerated domain names that belong to your Alibaba Cloud account is returned.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time. The maximum time range that can be queried is 31 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of data that you want to query. Valid values:
        /// 
        /// *   **bps**: bandwidth
        /// *   **traf**: traffic
        /// *   **acc**: requests
        /// 
        /// > If the value is set to **acc**, the **Area** parameter is not supported.
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The time interval between the data entries to return. Unit: seconds.
        /// 
        /// The time interval varies with the maximum time range per query. Valid values: 300 (5 minutes), 3600 (1 hour), and 86400 (1 day). For more information, see **Usage notes**.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The minimum time granularity at which the data is queried is 5 minutes.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 请求数类型，取值：
        /// 
        /// - **static**：静态。
        /// - **dynamic**：动态。
        /// - **all**：全部。
        /// 
        /// 默认为**all**。
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
