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
        /// <list type="bullet">
        /// <item><description>The qwen-image-3.0 model also supports the following values: 4:5, 5:4, 2:3, and 3:2.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4:3</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The idempotency parameter. A unique, case-sensitive, 32-character random string used to ensure that the request is completed only once. This prevents duplicate operations caused by multiple retries.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>3e761e9d11edba640c42a1b7</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The task input. Required. A JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>Prompt: the prompt. String. Required.</description></item>
        /// <item><description>Medias: the list of media files. Required when the task type is <c>image_to_image</c>. Up to 9 files.<remarks>
        /// <para>The Media structure contains the following fields: Type, the media type. String. Valid value: image. URL, the download URL of the media file. String. MediaId, the media asset ID. String.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Prompt&quot;:&quot;xxx&quot;,&quot;Medias&quot;:[{&quot;Type&quot;:&quot;image&quot;,&quot;URL&quot;:&quot;<a href="http://test.oss-cn-shanghai.aliyuncs.com/test.png%22%7D%5D%7D">http://test.oss-cn-shanghai.aliyuncs.com/test.png&quot;}]}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The task feature parameters. A JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>PromptExtend: specifies whether to optimize the prompt. Boolean. Valid values: <c>true</c> and <c>false</c>.</description></item>
        /// <item><description>PromptExtendMode: the prompt optimization mode. Valid values: <c>direct</c> (default) and <c>agent</c> (supported only for text-to-image). Only the qwen-image-3.0 model supports this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The type of the generation task. Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text_to_image: text-to-image</description></item>
        /// <item><description>image_to_image: image-to-image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text_to_image</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The name of the model. Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Wonder-Image-2.5-Pro</description></item>
        /// <item><description>Wonder-Image-2.5-Fast</description></item>
        /// <item><description>Wonder-Image-2</description></item>
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
        /// <para>The number of images to generate. Valid values: 1 to 4. Default value: 1.</para>
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
        /// <para>The scene. Valid values: <c>general</c>.</para>
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
