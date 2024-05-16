// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnReportRequest : TeaModel {
        /// <summary>
        /// The region. You can call the [DescribeCdnRegionAndIsp](https://help.aliyun.com/document_detail/91077.html) operation to query regions.
        /// 
        /// *   If you do not specify a region, data in all regions is queried.
        /// *   If you specify a region, data in the specified region is queried. You can specify one or more regions. If you specify multiple regions, separate the regions with commas (,).
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// The domain name that you want to query. Separate domain names with commas (,).
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**
        /// *   **3xx**
        /// *   **4xx**
        /// *   **5xx**
        /// 
        /// If you do not specify this parameter, all HTTP status codes are queried.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// Specifies whether the region is outside the Chinese mainland. Valid values:
        /// 
        /// *   **1**: outside the Chinese mainland
        /// *   **0**: inside the Chinese mainland
        /// </summary>
        [NameInMap("IsOverseas")]
        [Validation(Required=false)]
        public string IsOverseas { get; set; }

        /// <summary>
        /// The ID of the operations report that you want to query. You can specify only one ID in each request. You can call the [DescribeCdnSubList](https://help.aliyun.com/document_detail/271655.html) operation to query report IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
