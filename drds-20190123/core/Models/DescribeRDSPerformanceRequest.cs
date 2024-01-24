// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRDSPerformanceRequest : TeaModel {
        /// <summary>
        /// The type of the database engine.
        /// </summary>
        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        /// <summary>
        /// The ID of the Distributed Relational Database Service (DRDS) instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The end time of the query. Specify the time in the UNIX timestamp format. The time must be in UTC. Unit: ms.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The performance monitoring metrics. You can specify one or more metrics for a query at a time. Separate multiple metric parameters with commas (,).
        /// 
        /// >  For more information about the details of performance monitoring metrics, see [Storage monitoring](~~186705~~).
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string Keys { get; set; }

        /// <summary>
        /// The ID of the storage-layer ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("RdsInstanceId")]
        [Validation(Required=false)]
        public string RdsInstanceId { get; set; }

        /// <summary>
        /// The start time of the query. Specify the time in the UNIX timestamp format. The time must be in UTC. Unit: ms.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
