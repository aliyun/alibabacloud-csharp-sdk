// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListNodeInstanceTypeResponseBody : TeaModel {
        [NameInMap("NodeInstanceTypeModels")]
        [Validation(Required=false)]
        public List<ListNodeInstanceTypeResponseBodyNodeInstanceTypeModels> NodeInstanceTypeModels { get; set; }
        public class ListNodeInstanceTypeResponseBodyNodeInstanceTypeModels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public string Gpu { get; set; }

            /// <summary>
            /// <para>显卡内存大小，单位为MB。</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            /// <summary>
            /// <para>最大并发会话数，即单个资源可同时连接的会话数。如果同时连接的会话数过多，可能导致应用的使用体验下降。取值范围因资源规格不同而不同。各资源规格对应的取值范围分别是：</para>
            /// <list type="bullet">
            /// <item><description>appstreaming.general.4c8g：1\~2；</description></item>
            /// <item><description>appstreaming.general.8c16g：1\~4；</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4g：1\~4；</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g：1\~4；</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g：1\~6；</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public int? MaxCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu.4c8g.2g</para>
            /// </summary>
            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu</para>
            /// </summary>
            [NameInMap("NodeInstanceTypeFamily")]
            [Validation(Required=false)]
            public string NodeInstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>资源规格名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>无影-通用型_4核8G</para>
            /// </summary>
            [NameInMap("NodeTypeName")]
            [Validation(Required=false)]
            public string NodeTypeName { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
