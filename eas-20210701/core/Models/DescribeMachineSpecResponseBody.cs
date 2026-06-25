// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeMachineSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of available instance types for deployment.</para>
        /// </summary>
        [NameInMap("InstanceMetas")]
        [Validation(Required=false)]
        public List<DescribeMachineSpecResponseBodyInstanceMetas> InstanceMetas { get; set; }
        public class DescribeMachineSpecResponseBodyInstanceMetas : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores of the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            /// <summary>
            /// <para>The GPU model of the instance type. This field is not returned for non-GPU instance types.</para>
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
            /// <para>The GPU memory size of the instance type, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("GPUMemory")]
            [Validation(Required=false)]
            public float? GPUMemory { get; set; }

            /// <summary>
            /// <para>The instance type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ml.gu7i.c32m188.1-gu30</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance type is currently available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            /// <summary>
            /// <para>The memory size of the instance type, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The minimum discount currently offered for a spot instance in no-protection mode. A value of 0.1 indicates a 90% discount. If this field is not returned, the instance type does not support spot instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("NonProtectSpotDiscount")]
            [Validation(Required=false)]
            public float? NonProtectSpotDiscount { get; set; }

            /// <summary>
            /// <para>The current lowest discount for a spot instance with a 1-hour protection period. A value of 0.1 indicates a 90% discount. If this field is not returned, the instance type does not support spot instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.12</para>
            /// </summary>
            [NameInMap("SpotDiscount")]
            [Validation(Required=false)]
            public float? SpotDiscount { get; set; }

            /// <summary>
            /// <para>The inventory status of the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WithStock</para>
            /// </summary>
            [NameInMap("StockStatus")]
            [Validation(Required=false)]
            public string StockStatus { get; set; }

            /// <summary>
            /// <para>The source of the instance type.</para>
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
        /// <para>The supported combinations of CPU and memory values for deployment.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<DescribeMachineSpecResponseBodyTypes> Types { get; set; }
        public class DescribeMachineSpecResponseBodyTypes : TeaModel {
            /// <summary>
            /// <para>The valid values for the number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            /// <summary>
            /// <para>The valid memory values for the specified number of CPU cores.</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public List<int?> Memory { get; set; }

        }

    }

}
