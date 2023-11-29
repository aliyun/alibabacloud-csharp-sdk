// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListLogStoresRequest : TeaModel {
        /// <summary>
        /// The name of the Logstore. Fuzzy match is supported. For example, if you enter test, Logstores whose name contains test are returned.
        /// </summary>
        [NameInMap("logstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// The type of the Logstore. Valid values: standard and query.
        /// 
        /// *   **standard**: Standard Logstore. This type of Logstore supports the log analysis feature and is suitable for scenarios such as real-time monitoring and interactive analysis. You can also use this type of Logstore to build a comprehensive observability system.
        /// *   **query**: Query Logstore. This type of Logstore supports high-performance queries. The index traffic fee of a Query Logstore is approximately half that of a Standard Logstore. Query Logstores do not support SQL analysis. Query Logstores are suitable for scenarios in which the volume of data is large, the log retention period is long, or log analysis is not required. Log retention periods of weeks or months are considered long.
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The line from which the query starts. Default value: 0.
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 500. Default value: 500.
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The type of the data that you want to query. Valid values:
        /// 
        /// *   None: logs
        /// *   Metrics: metrics
        /// </summary>
        [NameInMap("telemetryType")]
        [Validation(Required=false)]
        public string TelemetryType { get; set; }

    }

}
