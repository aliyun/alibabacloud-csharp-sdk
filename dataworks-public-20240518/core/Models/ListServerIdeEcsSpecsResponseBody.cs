// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListServerIdeEcsSpecsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of available ECS instance types for personal development environments.</para>
        /// </summary>
        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<ListServerIdeEcsSpecsResponseBodyEcsSpecs> EcsSpecs { get; set; }
        public class ListServerIdeEcsSpecsResponseBodyEcsSpecs : TeaModel {
            /// <summary>
            /// <para>The accelerator type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CPU: uses only CPU.</description></item>
            /// <item><description>GPU: uses GPU acceleration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("AcceleratorType")]
            [Validation(Required=false)]
            public string AcceleratorType { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// <para>The number of compute units (CUs) consumed by this instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public float? Cu { get; set; }

            /// <summary>
            /// <para>The number of GPU cards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public long? Gpu { get; set; }

            /// <summary>
            /// <para>The GPU memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("GpuMemorySize")]
            [Validation(Required=false)]
            public float? GpuMemorySize { get; set; }

            /// <summary>
            /// <para>The GPU model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V100</para>
            /// </summary>
            [NameInMap("GpuType")]
            [Validation(Required=false)]
            public string GpuType { get; set; }

            /// <summary>
            /// <para>The ECS instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance type is available.</para>
            /// </summary>
            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            /// <summary>
            /// <para>The memory size, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned in this response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESG****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7D55162-4489-1619-AAF5-3F97D5FCA948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
