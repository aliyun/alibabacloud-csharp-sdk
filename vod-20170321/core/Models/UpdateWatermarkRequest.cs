// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the watermark template to which you want to change.</para>
        /// <list type="bullet">
        /// <item><description>Only letters and digits are supported.</description></item>
        /// <item><description>The name cannot exceed 128 bytes.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration information of the watermark such as the display position and special effects. The value must be a JSON string. The configuration parameters for image and text watermarks are different. For more information about the parameter structure, see <a href="~~98618#section-h01-44s-2lr~~">WatermarkConfig</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Width&quot;:&quot;55&quot;,&quot;Height&quot;:&quot;55&quot;,&quot;Dx&quot;:&quot;9&quot;,&quot;Dy&quot;:&quot;9&quot;,&quot;ReferPos&quot;:&quot;BottonLeft&quot;,&quot;Type&quot;:&quot;Image&quot;}</para>
        /// </summary>
        [NameInMap("WatermarkConfig")]
        [Validation(Required=false)]
        public string WatermarkConfig { get; set; }

        /// <summary>
        /// <para>The ID of the watermark template. You can specify only one watermark template ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Obtain the watermark template ID from the response to the <a href="~~AddWatermark~~">AddWatermark</a> operation that you call to create a watermark template.</description></item>
        /// <item><description>Obtain the watermark template ID from the response to the <a href="~~ListWatermark~~">ListWatermark</a> operation that you call to query all watermark templates within your account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af2afe4761992c*****bd947dae97337</para>
        /// </summary>
        [NameInMap("WatermarkId")]
        [Validation(Required=false)]
        public string WatermarkId { get; set; }

    }

}
