// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyNodePoolAttributeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region where the delivery group resides. For information about the supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeCapacity")]
        [Validation(Required=false)]
        public int? NodeCapacity { get; set; }

        /// <summary>
        /// <para>The auto scaling policy used by the delivery group.</para>
        /// </summary>
        [NameInMap("NodePoolStrategy")]
        [Validation(Required=false)]
        public string NodePoolStrategyShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-ew7va2g1wl3vm****</para>
        /// </summary>
        [NameInMap("PoolId")]
        [Validation(Required=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
