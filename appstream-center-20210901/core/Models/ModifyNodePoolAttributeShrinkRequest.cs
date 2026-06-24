// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyNodePoolAttributeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the delivery group. For more information about supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The number of concurrent sessions, which is the number of sessions that can be simultaneously connected to a single resource. If too many sessions are connected simultaneously, the application experience may degrade. The valid values vary depending on the resource specification. The valid values for each resource specification are as follows:</para>
        /// <list type="bullet">
        /// <item><description>appstreaming.general.4c8g: 1 to 2.</description></item>
        /// <item><description>appstreaming.general.8c16g: 1 to 4.</description></item>
        /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4.</description></item>
        /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4.</description></item>
        /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeCapacity")]
        [Validation(Required=false)]
        public int? NodeCapacity { get; set; }

        /// <summary>
        /// <para>The automatic scaling policy of the delivery group.</para>
        /// </summary>
        [NameInMap("NodePoolStrategy")]
        [Validation(Required=false)]
        public string NodePoolStrategyShrink { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ew7va2g1wl3vm****</para>
        /// </summary>
        [NameInMap("PoolId")]
        [Validation(Required=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
