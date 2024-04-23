// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class QueryDedicatedBlockStorageClusterDiskThroughputStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the throughput after setting the throughput by SetDedicatedBlockStorageClusterDiskThroughput api.
        /// 
        /// - SUCCESS: The throughput has been successfully set.
        /// - RUNNING: The throughput is currently being set.
        /// - WAIT(): The throughput is waiting to be set.
        /// - FAIL(): The throughput setting has failed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
