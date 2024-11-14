// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class QueryDedicatedBlockStorageClusterDiskThroughputStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A37597A6-BB99-19B3-85EA-4C2B91F0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the throughput after setting the throughput by SetDedicatedBlockStorageClusterDiskThroughput api.</para>
        /// <list type="bullet">
        /// <item><description>SUCCESS: The throughput has been successfully set.</description></item>
        /// <item><description>RUNNING: The throughput is currently being set.</description></item>
        /// <item><description>WAIT(): The throughput is waiting to be set.</description></item>
        /// <item><description>FAIL(): The throughput setting has failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
