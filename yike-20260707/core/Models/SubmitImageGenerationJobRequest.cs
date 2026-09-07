// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitImageGenerationJobRequest : TeaModel {
        /// <summary>
        /// <para>The aspect ratio. Valid values: 16:9 (default), 9:16, 4:3, 3:4, 1:1, and 21:9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4:3</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The idempotency token. A unique, case-sensitive string of up to 32 characters. This token ensures that the request is completed no more than once, preventing duplicate operations caused by multiple retries.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>3e761e9d11edba640c42a1b7</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The task input. This parameter is required. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>Prompt: String. Required. The prompt for image generation.</description></item>
        /// <item><description>Medias: A list of media items. Required when the task type is <c>image_to_image</c>. A maximum of 9 items are supported.<remarks>
        /// <para>The Media struct contains the following fields: Type, the media type, String, valid value: image. URL, the download URL of the media, String. MediaId, the media asset ID, String.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Prompt&quot;:&quot;xxx&quot;,&quot;Medias&quot;:[{&quot;Type&quot;:&quot;image&quot;,&quot;URL&quot;:&quot;xxx&quot;}]}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The task feature parameters. The value is a JSON string. You do not need to set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The type of the generation task. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text_to_image: text-to-image generation.</description></item>
        /// <item><description>image_to_image: image-to-image generation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text_to_image</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The model name. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>qwen-image-3.0</description></item>
        /// <item><description>qwen-image-2.0-pro</description></item>
        /// <item><description>qwen-image-2.0</description></item>
        /// <item><description>wan2.7-image</description></item>
        /// </list>
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
