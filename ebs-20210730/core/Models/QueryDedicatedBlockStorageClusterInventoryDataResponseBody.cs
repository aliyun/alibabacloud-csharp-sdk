// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class QueryDedicatedBlockStorageClusterInventoryDataResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryDedicatedBlockStorageClusterInventoryDataResponseBodyData> Data { get; set; }
        public class QueryDedicatedBlockStorageClusterInventoryDataResponseBodyData : TeaModel {
            /// <summary>
            /// The returned metrics.
            /// </summary>
            [NameInMap("MonitorItems")]
            [Validation(Required=false)]
            public QueryDedicatedBlockStorageClusterInventoryDataResponseBodyDataMonitorItems MonitorItems { get; set; }
            public class QueryDedicatedBlockStorageClusterInventoryDataResponseBodyDataMonitorItems : TeaModel {
                /// <summary>
                /// Available capacity size of the dedicated block storage cluster.
                /// </summary>
                [NameInMap("AvailableSize")]
                [Validation(Required=false)]
                public long? AvailableSize { get; set; }

                /// <summary>
                /// Total capacity size of the dedicated block storage cluster.
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            /// <summary>
            /// The ID list of the resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The timestamp when the data is collected.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// The ID of the dedicated block storage cluster.
        /// </summary>
        [NameInMap("DbscId")]
        [Validation(Required=false)]
        public string DbscId { get; set; }

        /// <summary>
        /// The name of the dedicated block storage cluster.
        /// </summary>
        [NameInMap("DbscName")]
        [Validation(Required=false)]
        public string DbscName { get; set; }

        /// <summary>
        /// The type of the disk. Valid values:
        /// 
        /// *   cloud_essd: enhanced SSD (ESSD).
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
