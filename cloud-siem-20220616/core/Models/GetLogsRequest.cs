// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetLogsRequest : TeaModel {
        /// <summary>
        /// The time when the query starts. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 0 to 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The search statement or the analytic statement. For more information, see [Log search overview](https://help.aliyun.com/document_detail/43772.html) and [Log analysis overview](https://help.aliyun.com/document_detail/53608.html).
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to sort the results of the log query by time in minutes in descending order. Default value: true. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ReverseOrNot")]
        [Validation(Required=false)]
        public bool? ReverseOrNot { get; set; }

        /// <summary>
        /// The time when the query ends. The value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
