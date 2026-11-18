// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitMediaComprehensionJobRequest : TeaModel {
        /// <summary>
        /// <para>The input media. The value is a JSON string with the following structure:</para>
        /// <list type="bullet">
        /// <item><description>Medias (Array<Object>, required): The list of media files. The array must contain 1 to 10 elements. Each element contains the following fields:<list type="bullet">
        /// <item><description>Type (String, required): The media type. Valid values: video and image. The value is not case-sensitive.</description></item>
        /// <item><description>Url (String, mutually exclusive with MediaId): The URL of the media file. The URL must start with http:// or https:// and be up to 2,048 characters in length. Unregistered URLs are automatically registered as media files.</description></item>
        /// <item><description>MediaId (String, mutually exclusive with Url): The ID of the registered media file. If both Url and MediaId are specified, MediaId takes precedence.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Medias&quot;: [
        ///     {
        ///       &quot;Type&quot;: &quot;video&quot;,
        ///       &quot;Url&quot;: &quot;<a href="https://example.com/source.mp4">https://example.com/source.mp4</a>&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The analysis parameters. The value is a JSON string up to 65,536 characters in length.</para>
        /// <list type="bullet">
        /// <item><description>VideoBreakdown: Supports the ResultType parameter (String, optional). Valid value: Standard (default).</description></item>
        /// <item><description>ProductRecognition: Uses parameters such as product information and prompts. The total number of fields cannot exceed 20. Example fields for product parameters include ProductName, BrandName, and SellingPoints.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;ResultType&quot;: &quot;Standard&quot;
        /// }
        /// or
        /// {
        ///   &quot;ProductName&quot;: &quot;Quiet Blender Soymilk Maker&quot;,
        ///   &quot;BrandName&quot;: &quot;LiangChu&quot;,
        ///   &quot;SellingPoints&quot;: [
        ///     &quot;Low-noise blending&quot;,
        ///     &quot;One-touch self-cleaning&quot;
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The job type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VideoBreakdown: Viral video breakdown. The Medias array must contain exactly one element with Type set to video.</description></item>
        /// <item><description>ProductRecognition: Product image information recognition. All elements in the Medias array must have Type set to image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VideoBreakdown</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The custom parameters. The value is a JSON string. The custom parameters are returned as-is in the callback result (for example, newsKey). NotifyAddress is a system-reserved field for the callback URL. A callback is triggered after the job is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;NotifyAddress&quot;: &quot;<a href="https://example.com/callback">https://example.com/callback</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
