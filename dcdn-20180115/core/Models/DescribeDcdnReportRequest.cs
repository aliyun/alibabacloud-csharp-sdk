// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnReportRequest : TeaModel {
        /// <summary>
        /// The region. You can call the [DescribeDcdnRegionAndIsp](https://help.aliyun.com/document_detail/207199.html) operation to query regions.
        /// 
        /// *   If you do not specify a region, data in all regions is queried.
        /// *   If you specify a region, data in the specified region is returned. You can specify one or more regions. Separate regions with commas (,).
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// The domain names that you want to query. Separate domain names with commas (,).
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: HTTP 2xx status codes
        /// *   **3xx**: HTTP 3xx status codes
        /// *   **4xx**: HTTP 4xx status codes
        /// *   **5xx**: HTTP 5xx status codes
        /// 
        /// If you do not specify an HTTP status code, data for all preceding HTTP status codes is queried.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// Specify whether the region is outside the Chinese mainland. Valid values:
        /// 
        /// *   **1**: outside the Chinese mainland
        /// *   **0**: inside the Chinese mainland
        /// </summary>
        [NameInMap("IsOverseas")]
        [Validation(Required=false)]
        public string IsOverseas { get; set; }

        /// <summary>
        /// The ID of the operations report that you want to query. You can enter only one ID in each call. You can call the [DescribeDcdnSubList](https://help.aliyun.com/document_detail/270075.html) operation to query report IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
