// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListNodeInstanceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region where the resource resides. For information about the supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// <item><description>cn-hangzhou: China (Hangzhou)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public float? Gpu { get; set; }

        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public int? GpuMemory { get; set; }

        /// <summary>
        /// <para>The language that you want to use.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en-US: English (US)</description></item>
        /// <item><description>zh-CN: Simplified Chinese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The resource type that you want to query. If you do not configure this parameter, all resource types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.vgpu.4c8g.2g</para>
        /// </summary>
        [NameInMap("NodeInstanceType")]
        [Validation(Required=false)]
        public string NodeInstanceType { get; set; }

        [NameInMap("NodeInstanceTypeFamily")]
        [Validation(Required=false)]
        public string NodeInstanceTypeFamily { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The operating system that is supported.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Windows: the Windows operating system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

    }

}
