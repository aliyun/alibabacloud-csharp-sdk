// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetWarehouseDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D3AE84AB-0873-5FC7-A4C4-8CF869D2FA70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return value.</para>
        /// </summary>
        [NameInMap("WarehouseDetail")]
        [Validation(Required=false)]
        public GetWarehouseDetailResponseBodyWarehouseDetail WarehouseDetail { get; set; }
        public class GetWarehouseDetailResponseBodyWarehouseDetail : TeaModel {
            /// <summary>
            /// <para>The total auto-scaling elastic compute resources of the compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("AutoElasticCpu")]
            [Validation(Required=false)]
            public string AutoElasticCpu { get; set; }

            /// <summary>
            /// <para>The unallocated compute resources. The remaining unallocated compute resources for compute groups in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("RemainingCpu")]
            [Validation(Required=false)]
            public string RemainingCpu { get; set; }

            /// <summary>
            /// <para>The reserved compute resources. The total compute resources of all running compute groups in the instance cannot exceed the reserved compute resources of the compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("ReservedCpu")]
            [Validation(Required=false)]
            public string ReservedCpu { get; set; }

            /// <summary>
            /// <para>The total time-based elastic compute resources of the compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("TimedElasticCpu")]
            [Validation(Required=false)]
            public string TimedElasticCpu { get; set; }

            /// <summary>
            /// <para>The warehouse list.</para>
            /// </summary>
            [NameInMap("WarehouseList")]
            [Validation(Required=false)]
            public List<GetWarehouseDetailResponseBodyWarehouseDetailWarehouseList> WarehouseList { get; set; }
            public class GetWarehouseDetailResponseBodyWarehouseDetailWarehouseList : TeaModel {
                /// <summary>
                /// <para>The auto-scaling type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("AutoScaleType")]
                [Validation(Required=false)]
                public string AutoScaleType { get; set; }

                /// <summary>
                /// <para>The number of clusters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ClusterCount")]
                [Validation(Required=false)]
                public string ClusterCount { get; set; }

                /// <summary>
                /// <para>The cluster specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("ClusterCpu")]
                [Validation(Required=false)]
                public string ClusterCpu { get; set; }

                /// <summary>
                /// <para>cpu</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }

                /// <summary>
                /// <para>Indicates whether the compute group is the default compute group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DefaultWarehouse")]
                [Validation(Required=false)]
                public bool? DefaultWarehouse { get; set; }

                /// <summary>
                /// <para>The elastic compute resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("ElasticCpu")]
                [Validation(Required=false)]
                public long? ElasticCpu { get; set; }

                /// <summary>
                /// <para>The elastic type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("ElasticType")]
                [Validation(Required=false)]
                public string ElasticType { get; set; }

                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The number of reserved clusters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("InitClusterCount")]
                [Validation(Required=false)]
                public string InitClusterCount { get; set; }

                /// <summary>
                /// <para>The maximum number of clusters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaxClusterCount")]
                [Validation(Required=false)]
                public string MaxClusterCount { get; set; }

                /// <summary>
                /// <para>The memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public long? Mem { get; set; }

                /// <summary>
                /// <para>The name of the compute group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyWarehouse</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of compute nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public long? NodeCount { get; set; }

                /// <summary>
                /// <para>The rebalance status of the compute group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DONE</para>
                /// </summary>
                [NameInMap("RebalanceStatus")]
                [Validation(Required=false)]
                public string RebalanceStatus { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kRunning</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
