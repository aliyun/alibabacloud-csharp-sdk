// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoGenerationJobRequest : TeaModel {
        /// <summary>
        /// <para>The aspect ratio. Valid values: 16:9 (default), 9:16, 4:3, 3:4, and 1:1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9:16</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>3e761e9d11edba640c42a1b7</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The output duration. Valid values: 4 to 15 seconds. Default value: 5s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The task input in JSON string format. Fields include:</para>
        /// <list type="bullet">
        /// <item><description>Prompt: String. Required. The prompt.</description></item>
        /// <item><description>Medias: The list of media items.<list type="bullet">
        /// <item><description>When JobType is image_to_video, this field is required and only 1 Media item is needed.</description></item>
        /// <item><description>When JobType is first_last_frame, this field is required and exactly 2 Media items are needed.</description></item>
        /// <item><description>When JobType is reference_to_video, this field is required and up to 9 Media items are allowed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The Media structure contains: Type, the media type (String, valid values: <c>image</c>/<c>video</c>/<c>audio</c>); URL, the media download URL (String); MediaId, the media asset ID (String).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Prompt&quot;:&quot;Person in image 1 dunks a basketball on the court using image 2&quot;,&quot;Medias&quot;:[{&quot;Type&quot;:&quot;image&quot;,&quot;Url&quot;:&quot;<a href="https://xxx/xxx.jpg%22%7D,%7B%22Type%22:%22image%22,%22Url%22:%22https://xxx/xxx.jpg%22%7D%5D%7D">https://xxx/xxx.jpg&quot;},{&quot;Type&quot;:&quot;image&quot;,&quot;Url&quot;:&quot;https://xxx/xxx.jpg&quot;}]}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The task feature parameters. No configuration is required at this time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text_to_video: text-to-video</description></item>
        /// <item><description>image_to_video: image-to-video</description></item>
        /// <item><description>first_last_frame: first and last frame to video</description></item>
        /// <item><description>reference_to_video: reference-to-video</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text_to_video</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The model name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>happyhorse-1.1</description></item>
        /// <item><description>happyhorse-1.0</description></item>
        /// <item><description>wan2.7</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>happyhorse-1.1</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The number of outputs. Valid values: 1 to 4. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("N")]
        [Validation(Required=false)]
        public int? N { get; set; }

        /// <summary>
        /// <para>The resolution. Valid values: 720P (default) and 1080P.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The scene type. Currently only <c>general</c> is supported.</para>
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
