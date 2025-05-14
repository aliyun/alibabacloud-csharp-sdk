// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListEcsSpecsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InternalError: an internal error. All errors, except for parameter validation errors, are classified as internal errors.</description></item>
        /// <item><description>ValidationError: a parameter validation error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The specifications of the ECS instances returned on this page.</para>
        /// </summary>
        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<ListEcsSpecsResponseBodyEcsSpecs> EcsSpecs { get; set; }
        public class ListEcsSpecsResponseBodyEcsSpecs : TeaModel {
            /// <summary>
            /// <para>The accelerator type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("AcceleratorType")]
            [Validation(Required=false)]
            public string AcceleratorType { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public long? CPU { get; set; }

            /// <summary>
            /// <para>The currency unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public long? GPU { get; set; }

            [NameInMap("GPUMemorySize")]
            [Validation(Required=false)]
            public float? GPUMemorySize { get; set; }

            /// <summary>
            /// <para>The GPU type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>V100</description></item>
            /// <item><description>A100</description></item>
            /// <item><description>A10</description></item>
            /// <item><description>T4</description></item>
            /// <item><description>P100</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>v100</para>
            /// </summary>
            [NameInMap("GPUType")]
            [Validation(Required=false)]
            public string GPUType { get; set; }

            /// <summary>
            /// <para>The inbound bandwidth of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5120000</para>
            /// </summary>
            [NameInMap("InstanceBandwidthRx")]
            [Validation(Required=false)]
            public long? InstanceBandwidthRx { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.gn5-c28g1.7xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource was available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            /// <summary>
            /// <para>The labels of the ECS specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;foo\&quot;: \&quot;bar\&quot;}</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListEcsSpecsResponseBodyEcsSpecsLabels> Labels { get; set; }
            public class ListEcsSpecsResponseBodyEcsSpecsLabels : TeaModel {
                /// <summary>
                /// <para>The label key added to the ECS specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SupportResourcePackDeduction</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The label value added to the ECS specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The memory size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22.8</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            [NameInMap("SpotStockStatus")]
            [Validation(Required=false)]
            public string SpotStockStatus { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("SystemDiskCapacity")]
            [Validation(Required=false)]
            public long? SystemDiskCapacity { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>400</description></item>
        /// <item><description>404</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;XXX&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7D55162-4489-1619-AAF5-3F97D5FCA948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of ECS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
