// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateWatermarkRequest : TeaModel {
        /// <summary>
        /// <para>The new name of the watermark template.</para>
        /// <list type="bullet">
        /// <item><description>Only Chinese characters, letters, and digits are supported.</description></item>
        /// <item><description>The name can be up to 128 bytes in length.</description></item>
        /// <item><description>UTF-8 encoding.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration information of the image and text watermark (JSON character string), including the watermark display position and watermark effect. The configuration parameters for image watermarks and text watermarks are different. For details about the parameter structure, see <a href="~~98618#section-h01-44s-2lr~~">WatermarkConfig</a>.</para>
        /// <remarks>
        /// <para>Modifying across templatetypes is not supported. You can invoke the <a href="~~GetWatermark~~">GetWatermark</a> operation to query the type of the watermark template before modifying the configuration.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Width&quot;:&quot;55&quot;,&quot;Height&quot;:&quot;55&quot;,&quot;Dx&quot;:&quot;9&quot;,&quot;Dy&quot;:&quot;9&quot;,&quot;ReferPos&quot;:&quot;BottomLeft&quot;}</para>
        /// </summary>
        [NameInMap("WatermarkConfig")]
        [Validation(Required=false)]
        public string WatermarkConfig { get; set; }

        /// <summary>
        /// <para>The ID of the image and text watermark template to modify. Only a single watermark template ID is supported. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>The ID is returned after you call the <a href="~~AddWatermark~~">AddWatermark</a> operation to add an image and text watermark template.</description></item>
        /// <item><description>The ID is returned after you call the <a href="~~ListWatermark~~">ListWatermark</a> operation to query the list of image and text watermark templates.</description></item>
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
