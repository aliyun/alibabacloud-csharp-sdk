// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// <para>The image IDs. The value can be a JSON array that consists of up to 50 image IDs. Format: <c>[&quot;xxx&quot;, &quot;yyy&quot;, … &quot;zzz&quot;]</c>. Separate multiple image IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;fe9c66133a9d4688872869726b52****&quot;, &quot;794c230fd3e64ea19f83f4d7a0ad****&quot;]</para>
        /// </summary>
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        /// <summary>
        /// <para>The type of the images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: OS images</description></item>
        /// <item><description>app: application images</description></item>
        /// <item><description>custom: custom images</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The region ID of the images. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
