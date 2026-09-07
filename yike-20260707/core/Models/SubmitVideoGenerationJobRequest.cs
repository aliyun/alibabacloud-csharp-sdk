// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoGenerationJobRequest : TeaModel {
        /// <summary>
        /// <para>The aspect ratio. Valid values: 16:9 (default), 9:16, 4:3, 3:4, 1:1, and adaptive (valid only for wan3.0-video and wan3.0-video-prime).</para>
        /// 
        /// <b>Example:</b>
        /// <para>9:16</para>
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
        /// <para>The output duration. Valid values: 4 to 15 seconds. Default value: 5 seconds.</para>
        /// <list type="bullet">
        /// <item><description>For wan3.0-video and wan3.0-video-prime, the maximum value is 30 seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The task input. This parameter is required. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>Prompt: string. Required. The prompt.</description></item>
        /// <item><description>Medias: the list of media items.<list type="bullet">
        /// <item><description>If JobType is set to image_to_video, this field is required and only 1 media item is needed.</description></item>
        /// <item><description>If JobType is set to first_last_frame, this field is required and exactly 2 media items are needed.</description></item>
        /// <item><description>If JobType is set to reference_to_video, this field is required and up to 9 media items are allowed. For wan3.0-video and wan3.0-video-prime, up to 20 media items are allowed, including up to 10 images, 5 videos, and 5 audio files. The total duration of audio and video files cannot exceed 15 seconds.<remarks>
        /// <para>The Media structure contains the following fields: Type, the media type (string). Valid values: <c>image</c>, <c>video</c>, and <c>audio</c>. URL, the media download URL (string). MediaId, the media asset ID (string).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Prompt&quot;:&quot;Person 1 dunks a basketball on the court using the move shown in image 2&quot;,&quot;Medias&quot;:[{&quot;Type&quot;:&quot;image&quot;,&quot;Url&quot;:&quot;<a href="https://xxx/xxx.jpg%22%7D,%7B%22Type%22:%22image%22,%22Url%22:%22https://xxx/xxx.jpg%22%7D%5D%7D">https://xxx/xxx.jpg&quot;},{&quot;Type&quot;:&quot;image&quot;,&quot;Url&quot;:&quot;https://xxx/xxx.jpg&quot;}]}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The task parameters as a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>EnableAudio: boolean. Optional. Specifies whether to include audio in the output. Valid values: true and false.</description></item>
        /// <item><description>Watermark: boolean. Optional. Specifies whether to include a watermark. Valid values: true (an &quot;AI-generated&quot; watermark is added to the lower-right corner of the video) and false (no watermark is added).</description></item>
        /// <item><description>PromptExtend: boolean. Optional. Specifies whether to enable intelligent prompt rewriting. This parameter is valid only for wan3.0-video and wan3.0-video-prime. Valid values: true (enabled, default) and false (disabled).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The task type. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text_to_video: text-to-video.</description></item>
        /// <item><description>image_to_video: image-to-video.</description></item>
        /// <item><description>first_last_frame: first and last frame to video.</description></item>
        /// <item><description>reference_to_video: reference-to-video.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text_to_video</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The model name. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>wan3.0-video</description></item>
        /// <item><description>wan3.0-video-prime</description></item>
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
        /// <para>The output configuration as a JSON string. OssUri is an optional OSS output directory. If not specified, a signed URL for the service-generated output is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OssUri&quot;:&quot;oss://example-bucket/video-translation/output/&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The resolution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1080P</description></item>
        /// <item><description>720P: default value.</description></item>
        /// <item><description>480P: valid only for wan3.0-video and wan3.0-video-prime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The scene type. Currently, only <c>general</c> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>general</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The custom user parameters as a JSON string. These parameters are returned as-is in the callback result. The system reserved field NotifyAddress specifies the callback URL. The system sends a callback to this URL when the task is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
