// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeMachineSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance types when the resources are specified.</para>
        /// </summary>
        [NameInMap("InstanceMetas")]
        [Validation(Required=false)]
        public List<DescribeMachineSpecResponseBodyInstanceMetas> InstanceMetas { get; set; }
        public class DescribeMachineSpecResponseBodyInstanceMetas : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores in the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            /// <summary>
            /// <para>The GPU type in the instance type. If the instance type is not a GPU-based instance type, this parameter does not exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GU30</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public string GPU { get; set; }

            /// <summary>
            /// <para>The number of GPUs in the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GPUAmount")]
            [Validation(Required=false)]
            public int? GPUAmount { get; set; }

            /// <summary>
            /// <para>The GPU memory in the instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("GPUMemory")]
            [Validation(Required=false)]
            public float? GPUMemory { get; set; }

            /// <summary>
            /// <para>The name of the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ml.gu7i.c32m188.1-gu30</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance type is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            /// <summary>
            /// <para>The memory size in the instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The minimum discount that can be accepted when the preemptible instance type does not include a usage duration. 0.1 indicates one fold. If this parameter is not returned, the bidding feature is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("NonProtectSpotDiscount")]
            [Validation(Required=false)]
            public float? NonProtectSpotDiscount { get; set; }

            /// <summary>
            /// <para>The minimum discount that can be accepted when the preemptible instance type has the 1-hour protection duration. 0.1 indicates one fold. If this parameter is not returned, the bidding feature is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.12</para>
            /// </summary>
            [NameInMap("SpotDiscount")]
            [Validation(Required=false)]
            public float? SpotDiscount { get; set; }

            /// <summary>
            /// <para>The inventory status of the instance type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WithStock</description></item>
            /// <item><description>ClosedWithStock</description></item>
            /// <item><description>NoStock</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WithStock</para>
            /// </summary>
            [NameInMap("StockStatus")]
            [Validation(Required=false)]
            public string StockStatus { get; set; }

            /// <summary>
            /// <para>The source of the instance type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ECS</description></item>
            /// <item><description>BareMetal</description></item>
            /// <item><description>Lingjun</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The values that can be supported when the number of CPUs and memory size are specified for deployment.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<DescribeMachineSpecResponseBodyTypes> Types { get; set; }
        public class DescribeMachineSpecResponseBodyTypes : TeaModel {
            /// <summary>
            /// <para>Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            /// <summary>
            /// <para>The optional values for memory when CPU is set to a specific value as above.</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public List<int?> Memory { get; set; }

        }

    }

}
