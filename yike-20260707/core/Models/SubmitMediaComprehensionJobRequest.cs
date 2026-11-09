// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitMediaComprehensionJobRequest : TeaModel {
        /// <summary>
        /// <para>The input material. It is a JSON string with the following structure:</para>
        /// <list type="bullet">
        /// <item><description>Medias (Array<Object>, required): The list of media assets. It contains 1 to 10 elements. Each element includes the following fields:<list type="bullet">
        /// <item><description>Type (String, required): The type of the media asset. Valid values: video and image. The value is not case-sensitive.</description></item>
        /// <item><description>Url (String, mutually exclusive with MediaId): The URL of the media asset. It must start with http:// or https:// and be up to 2,048 characters in length. Unregistered URLs are automatically registered as media assets.</description></item>
        /// <item><description>MediaId (String, mutually exclusive with Url): The ID of the registered media asset. If both Url and MediaId are specified, MediaId takes precedence.</description></item>
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
        /// <para>The analysis parameters. It is a JSON string with a maximum length of 65,536 characters and a maximum of 20 fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProductName&quot;:&quot;Quiet Blender Soymilk Maker&quot;,&quot;BrandName&quot;:&quot;LiangChu&quot;,&quot;SellingPoints&quot;:[&quot;Low-noise blending&quot;,&quot;One-touch self-cleaning&quot;]}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The job type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VideoBreakdown: viral video breakdown. The Medias array must contain exactly one element with Type set to video.</description></item>
        /// <item><description>ProductRecognition: product image information recognition. All elements in the Medias array must have Type set to image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VideoBreakdown</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The custom parameters. It is a JSON string that is returned as-is in the callback result, such as newsKey. NotifyAddress is a system-reserved field for the callback URL. A callback is triggered to this URL after the job is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
