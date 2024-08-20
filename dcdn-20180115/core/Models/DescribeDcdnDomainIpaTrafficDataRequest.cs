// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainIpaTrafficDataRequest : TeaModel {
        /// <summary>
        /// The accelerated domain name.
        /// 
        /// Separate multiple domain names with commas (,). If you do not specify a value for this parameter, data for all accelerated domain names is queried.
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
        /// Specify whether to implement padding with zeros. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("FixTimeGap")]
        [Validation(Required=false)]
        public string FixTimeGap { get; set; }

        /// <summary>
        /// The time granularity of data entries. Unit: seconds.
        /// 
        /// The time granularity varies with the time range specified by **StartTime** and **EndTime**.
        /// 
        /// *   If the time range between StartTime and EndTime is less than 3 days, the valid values are **300**, **3600**, and **86400**. If you do not specify a value for this parameter, **300** is used.
        /// *   If the time range between StartTime and EndTime is greater than or equal to 3 days and less than 31 days, the valid values are **3600** and **86400**. Default value: **3600**.
        /// *   If the time range between StartTime and EndTime is 31 days or longer, the valid value is **86400**. Default value: **86400**.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// The name of the Internet service provider (ISP).
        /// 
        /// You can call the [DescribeDcdnRegionAndIsp](https://help.aliyun.com/document_detail/207199.html) operation to query ISPs.
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// The name of the region.
        /// 
        /// You can call the [DescribeDcdnRegionAndIsp](https://help.aliyun.com/document_detail/207199.html) operation to query regions.
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

        /// <summary>
        /// Specifies whether to automatically calculate the value of the **interval**. If the **timeMerge** parameter is set to **1**, the value of **inteval** is calculated based on **StartTime** and **EndTime**. You can set either this parameter or the **interval** parameter.
        /// </summary>
        [NameInMap("TimeMerge")]
        [Validation(Required=false)]
        public string TimeMerge { get; set; }

    }

}
