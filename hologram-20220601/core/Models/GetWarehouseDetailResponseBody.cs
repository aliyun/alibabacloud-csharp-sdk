// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetWarehouseDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D3AE84AB-0873-5FC7-A4C4-8CF869D2FA70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned values.</para>
        /// </summary>
        [NameInMap("WarehouseDetail")]
        [Validation(Required=false)]
        public GetWarehouseDetailResponseBodyWarehouseDetail WarehouseDetail { get; set; }
        public class GetWarehouseDetailResponseBodyWarehouseDetail : TeaModel {
            /// <summary>
            /// <para>The remaining unallocated computing resources of the virtual warehouse instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("RemainingCpu")]
            [Validation(Required=false)]
            public string RemainingCpu { get; set; }

            /// <summary>
            /// <para>The reserved computing resources. The amount of computing resources in all running virtual warehouses in an instance cannot exceed the amount of reserved computing resources in the virtual warehouses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("ReservedCpu")]
            [Validation(Required=false)]
            public string ReservedCpu { get; set; }

            [NameInMap("TimedElasticCpu")]
            [Validation(Required=false)]
            public string TimedElasticCpu { get; set; }

            /// <summary>
            /// <para>The list of virtual warehouses.</para>
            /// </summary>
            [NameInMap("WarehouseList")]
            [Validation(Required=false)]
            public List<GetWarehouseDetailResponseBodyWarehouseDetailWarehouseList> WarehouseList { get; set; }
            public class GetWarehouseDetailResponseBodyWarehouseDetailWarehouseList : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }

                [NameInMap("DefaultWarehouse")]
                [Validation(Required=false)]
                public bool? DefaultWarehouse { get; set; }

                [NameInMap("ElasticCpu")]
                [Validation(Required=false)]
                public long? ElasticCpu { get; set; }

                /// <summary>
                /// <para>The ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The memory capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>128</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public long? Mem { get; set; }

                /// <summary>
                /// <para>The name of the virtual warehouse instance.</para>
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

                [NameInMap("RebalanceStatus")]
                [Validation(Required=false)]
                public string RebalanceStatus { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>kRunning</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>kSuspended</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>kInit</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>kFailed</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>kAllocating</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
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
