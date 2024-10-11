// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class ListClustersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyData> Data { get; set; }
        public class ListClustersResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("CacheStorageSizeGiB")]
            [Validation(Required=false)]
            public int? CacheStorageSizeGiB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CloudESSD</para>
            /// </summary>
            [NameInMap("CacheStorageType")]
            [Validation(Required=false)]
            public string CacheStorageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>clickhouse_go_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18T08:14:48Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBClusterDescription")]
            [Validation(Required=false)]
            public string DBClusterDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cc-bp108z124a8o7****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBClusterStatus")]
            [Validation(Required=false)]
            public string DBClusterStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21.8</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-04-17T08:14:48Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DISK_FULL</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ObjectStoreSizeGiB")]
            [Validation(Required=false)]
            public long? ObjectStoreSizeGiB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ResourceCpuCores")]
            [Validation(Required=false)]
            public int? ResourceCpuCores { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("ResourceMemoryGiB")]
            [Validation(Required=false)]
            public int? ResourceMemoryGiB { get; set; }

            [NameInMap("VirtualWareHouses")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyDataVirtualWareHouses> VirtualWareHouses { get; set; }
            public class ListClustersResponseBodyDataVirtualWareHouses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>tcp:9000,http:8123,mysql:9004</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public string Ports { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("VirtualWareHouseCacheStorage")]
                [Validation(Required=false)]
                public int? VirtualWareHouseCacheStorage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n1.xlarge</para>
                /// </summary>
                [NameInMap("VirtualWareHouseClass")]
                [Validation(Required=false)]
                public string VirtualWareHouseClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("VirtualWareHouseDescription")]
                [Validation(Required=false)]
                public string VirtualWareHouseDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vw-uf6a499c0m3w5****</para>
                /// </summary>
                [NameInMap("VirtualWareHouseId")]
                [Validation(Required=false)]
                public string VirtualWareHouseId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("VirtualWareHouseStatus")]
                [Validation(Required=false)]
                public string VirtualWareHouseStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-bp1tg609m5j85jejq****</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zedznmtm8j7fksbc****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-bp1tg609m5j85jejq****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DDB109DC-E37D-5475-8D49-47542C57BD38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
