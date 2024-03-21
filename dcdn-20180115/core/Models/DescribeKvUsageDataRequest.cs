// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeKvUsageDataRequest : TeaModel {
        /// <summary>
        /// The request method. If the parameter is empty, data about all methods is returned. Valid values:
        /// 
        /// *   **get**
        /// *   **put**
        /// *   **list**
        /// *   **delete**
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The type of the request data. Set the value to **acc**.
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// The namespace ID. If the parameter is empty, data about all namespaces is returned.
        /// 
        /// You can specify a maximum number of 30 namespace IDs and separate them with commas (,).
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The type of the response data. Valid values:
        /// 
        /// *   **detail**: detailed data
        /// *   **total**: summary data
        /// 
        /// Default value: **detail**.
        /// </summary>
        [NameInMap("ResponseType")]
        [Validation(Required=false)]
        public string ResponseType { get; set; }

        /// <summary>
        /// The key that is used to group data. Valid values: **type** and **namespace**.
        /// 
        /// *   **type**: Data is grouped by time. The data in the last 5 minutes is returned.
        /// *   **namespace**: Data is grouped by namespace and is not padded with zeros.
        /// *   Default value: **type**.
        /// 
        /// If **ResponseType** is set to **total**, data to return is not grouped by **namespace** but by **type**.
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// The minimum data granularity is 1 hour. If you do not specify this parameter, the data in the last seven days is returned.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
