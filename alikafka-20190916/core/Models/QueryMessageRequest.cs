// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class QueryMessageRequest : TeaModel {
        /// <summary>
        /// The beginning of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The consumer offset of the partition.
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// The partition ID.
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// The query type. Valid values:
        /// 
        /// *   byOffset: queries messages by offset. If you select this value, you must configure Partition and Offset.
        /// *   byTimestamp: queries messages by time. If you select this value, you must configure BeginTime.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// The ID of the region where the resource resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The topic name.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
