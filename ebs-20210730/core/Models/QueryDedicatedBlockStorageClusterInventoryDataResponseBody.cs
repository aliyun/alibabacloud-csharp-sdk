// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class QueryDedicatedBlockStorageClusterInventoryDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryDedicatedBlockStorageClusterInventoryDataResponseBodyData> Data { get; set; }
        public class QueryDedicatedBlockStorageClusterInventoryDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned metrics.</para>
            /// </summary>
            [NameInMap("MonitorItems")]
            [Validation(Required=false)]
            public QueryDedicatedBlockStorageClusterInventoryDataResponseBodyDataMonitorItems MonitorItems { get; set; }
            public class QueryDedicatedBlockStorageClusterInventoryDataResponseBodyDataMonitorItems : TeaModel {
                /// <summary>
                /// <para>Available capacity size of the dedicated block storage cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61360</para>
                /// </summary>
                [NameInMap("AvailableSize")]
                [Validation(Required=false)]
                public long? AvailableSize { get; set; }

                /// <summary>
                /// <para>Total capacity size of the dedicated block storage cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61440</para>
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            /// <summary>
            /// <para>The ID list of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbsc-xxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The timestamp when the data is collected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1606403800</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the dedicated block storage cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbsc-xxx</para>
        /// </summary>
        [NameInMap("DbscId")]
        [Validation(Required=false)]
        public string DbscId { get; set; }

        /// <summary>
        /// <para>The name of the dedicated block storage cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myDBSCCluster</para>
        /// </summary>
        [NameInMap("DbscName")]
        [Validation(Required=false)]
        public string DbscName { get; set; }

        /// <summary>
        /// <para>The type of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd: enhanced SSD (ESSD).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1A4258A-0C8C-5329-B495-BC5AD7AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
