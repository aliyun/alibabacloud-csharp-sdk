// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListNodeInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource types.</para>
        /// </summary>
        [NameInMap("NodeInstanceTypeModels")]
        [Validation(Required=false)]
        public List<ListNodeInstanceTypeResponseBodyNodeInstanceTypeModels> NodeInstanceTypeModels { get; set; }
        public class ListNodeInstanceTypeResponseBodyNodeInstanceTypeModels : TeaModel {
            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public string Gpu { get; set; }

            /// <summary>
            /// <para>The GPU size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            /// <summary>
            /// <para>The maximum number of sessions to which a resource can connect at the same time. If a resource connects to a large number of sessions at the same time, user experience can be compromised. The value range varies based on the resource type. The following items describe the value ranges of different resource types:</para>
            /// <list type="bullet">
            /// <item><description>appstreaming.general.4c8g: 1 to 2</description></item>
            /// <item><description>appstreaming.general.8c16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public int? MaxCapacity { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The ID of the resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu.4c8g.2g</para>
            /// </summary>
            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            /// <summary>
            /// <para>The resource type family.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>appstreaming.general: WUYING - General</description></item>
            /// <item><description>appstreaming.vgpu: WUYING - Graphics</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu</para>
            /// </summary>
            [NameInMap("NodeInstanceTypeFamily")]
            [Validation(Required=false)]
            public string NodeInstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The name of the resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WUYING - General - 4 vCPUs 8 GB Memory</para>
            /// </summary>
            [NameInMap("NodeTypeName")]
            [Validation(Required=false)]
            public string NodeTypeName { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
