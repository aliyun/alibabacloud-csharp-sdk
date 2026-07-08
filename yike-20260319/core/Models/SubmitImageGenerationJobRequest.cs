// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitImageGenerationJobRequest : TeaModel {
        /// <summary>
        /// <para>The aspect ratio. Valid values: 16:9 (default), 9:16, 4:3, 3:4, and 1:1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4:3</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>3e761e9d11edba640c42a1b7</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The task input. This is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>Prompt: String. Required. The prompt.</description></item>
        /// <item><description>Medias: the media list. Required when the task type is <c>image_to_image</c>. A maximum of 9 items are supported.<remarks>
        /// <para>The Media struct contains: Type, the media type, String, valid value: image. URL, the media download URL, String.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Bucket\&quot;:\&quot;dbj-app-prod\&quot;,\&quot;Location\&quot;:\&quot;oss-cn-hangzhou\&quot;,\&quot;Object\&quot;:\&quot;classpal/1767838045280pzmgnvwe.mp4\&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The task feature parameters. This is a JSON string. No configuration is required at this time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The type of the generation task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text_to_image: text-to-image.</description></item>
        /// <item><description>image_to_image: image-to-image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text_to_image</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wan2.7-image</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The number of images. Valid values: 1 to 4. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("N")]
        [Validation(Required=false)]
        public string N { get; set; }

        /// <summary>
        /// <para>The resolution. Valid values: 1K (default), 2K, and 4K.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The scenario. This is an enumeration type. Currently, only <c>general</c> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>general</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The user business data in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;env&quot;:&quot;prd&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
