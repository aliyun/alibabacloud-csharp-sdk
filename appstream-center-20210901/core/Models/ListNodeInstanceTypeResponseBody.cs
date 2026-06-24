// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListNodeInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of resource specifications.</para>
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
            /// <para>The GPU memory size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions, which is the number of sessions that can be simultaneously connected to a single resource. If too many sessions are connected simultaneously, the application experience may degrade. The valid values vary depending on the resource specification. The valid values for each resource specification are as follows:</para>
            /// <list type="bullet">
            /// <item><description>appstreaming.general.2c4g: 1</description></item>
            /// <item><description>appstreaming.general.4c8g: 1 to 2</description></item>
            /// <item><description>appstreaming.general.8c16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 7</description></item>
            /// <item><description>appstreaming.vgpu.4c10g.2gt4: 1 to 2</description></item>
            /// <item><description>appstreaming.vgpu.4c16g.2ga10: 1 to 2</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4gt4: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c32g.4ga10: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.12c46g.11g28: 1 to 6</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 7</description></item>
            /// <item><description>appstreaming.vgpu.16c32g.8g: 1 to 8</description></item>
            /// <item><description>appstreaming.vgpu.16c62g.8ga10: 1 to 8.</description></item>
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
            /// <para>The ID of the resource specification type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu.4c8g.2g</para>
            /// </summary>
            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            /// <summary>
            /// <para>The resource specification family.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu</para>
            /// </summary>
            [NameInMap("NodeInstanceTypeFamily")]
            [Validation(Required=false)]
            public string NodeInstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The name of the resource specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无影-通用型_4核8G</para>
            /// </summary>
            [NameInMap("NodeTypeName")]
            [Validation(Required=false)]
            public string NodeTypeName { get; set; }

        }

        /// <summary>
        /// <para>The page number of the query results currently displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of query results per page.</para>
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
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
