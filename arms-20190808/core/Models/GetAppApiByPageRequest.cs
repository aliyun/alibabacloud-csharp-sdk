// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAppApiByPageRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to `GetAppApiByPage`.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The time interval between the data shards to be queried. Unit: milliseconds. Minimum value: 60000.
        /// </summary>
        [NameInMap("IntervalMills")]
        [Validation(Required=false)]
        public int? IntervalMills { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("PId")]
        [Validation(Required=false)]
        public string PId { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The process identifier (PID) of the application. For more information about how to obtain the PID, see [Obtain the PID of an application](https://www.alibabacloud.com/help/zh/doc-detail/186100.htm?spm=a2cdw.13409063.0.0.7a72281f0bkTfx#title-imy-7gj-qhr).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The HTTP status code returned for the request. Valid values:
        /// 
        /// *   2XX: The request is successful.
        /// *   3XX: A redirection message is returned.
        /// *   4XX: The request is invalid.
        /// *   5XX: A server error occurs.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
