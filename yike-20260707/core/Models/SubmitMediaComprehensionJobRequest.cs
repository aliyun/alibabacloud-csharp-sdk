// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitMediaComprehensionJobRequest : TeaModel {
        /// <summary>
        /// <para>The input material. JSON string with the following structure:</para>
        /// <list type="bullet">
        /// <item><description>Medias (Array<Object>, required): The list of media assets. Contains 1 to 10 elements. Each element includes the following fields:<list type="bullet">
        /// <item><description>Type (String, required): The media asset type. Valid values: video or image (case-insensitive).</description></item>
        /// <item><description>Url (String, either Url or MediaId is required): The URL of the media asset. The URL must start with http:// or https:// and cannot exceed 2048 characters in length. Unregistered URLs are automatically registered as media assets.</description></item>
        /// <item><description>MediaId (String, either Url or MediaId is required): The ID of a registered media asset. If both Url and MediaId are specified, MediaId takes precedence.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Medias&quot;:[{&quot;Type&quot;:&quot;video&quot;,&quot;Url&quot;:&quot;<a href="https://xxx.mp4%22%7D%5D%7D">https://xxx.mp4&quot;}]}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The analysis parameters. JSON string. The total length cannot exceed 65536 characters, and the total number of fields cannot exceed 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProductName&quot;:&quot;Quiet Blender Soymilk Maker&quot;,&quot;BrandName&quot;:&quot;LiangChu&quot;,&quot;SellingPoints&quot;:[&quot;Low-noise blending&quot;,&quot;One-touch self-cleaning&quot;]}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// <list type="bullet">
        /// <item><description>VideoBreakdown: viral video breakdown. Requires Medias to contain exactly 1 element with Type=video.</description></item>
        /// <item><description>ProductRecognition: product image information recognition. Requires all elements in Medias to have Type=image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VideoBreakdown</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The custom parameters. JSON string that is returned as-is in the callback result (for example, newsKey). The system reserved field NotifyAddress specifies the callback URL. The callback is triggered after the job is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
