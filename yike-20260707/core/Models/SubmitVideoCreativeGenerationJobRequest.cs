// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoCreativeGenerationJobRequest : TeaModel {
        /// <summary>
        /// <para>The aspect ratio. Valid values: 16:9 (default), 9:16, 4:3, and 3:4.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4:3</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The digital human information. The value is a JSON string. This parameter is required for the <c>creator-talk</c>, <c>creator-sales</c>, and <c>avatar-broadcast</c> scenes. It includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description>AvatarPortrait: The digital human portrait. This field is required. The value is a string that represents the media asset ID of the portrait image or the image URL.</description></item>
        /// <item><description>AvatarVoice: The digital human voice. This field is optional. The value is a string that represents the voice audio ID or the audio URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;AvatarPortrait\&quot;:\&quot;xxxxxxx\&quot;,\&quot;AvatarVoice\&quot;:\&quot;<a href="https://ice-ai-saas.oss-cn-shanghai.aliyuncs.com/ice-ai-saas-prd/xxxxxxx%5C%5C%22%7D">https://ice-ai-saas.oss-cn-shanghai.aliyuncs.com/ice-ai-saas-prd/xxxxxxx\\&quot;}</a></para>
        /// </summary>
        [NameInMap("AvatarData")]
        [Validation(Required=false)]
        public string AvatarData { get; set; }

        /// <summary>
        /// <para>The job parameters. The value is a JSON string. This parameter includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description>TextType: The text type. This field is required. The value is an integer. Valid values: 1 (original draft, such as product or news information, which the system automatically converts into a voiceover script) and 2 (voiceover script).</description></item>
        /// <item><description>TextContent: The text content. This field is required. The value is a string. The maximum length is 10,000 characters.</description></item>
        /// <item><description>VoiceDuration: The expected voiceover duration. This field is optional. The value is an integer. This field is configured when TextType is set to 1. Unit: seconds. Default value: 60. The final video duration will be slightly shorter than the expected duration.</description></item>
        /// <item><description>NarrationVoiceId: The narration voice ID. This field is valid only for the <c>briefing-voiceover</c> scene.</description></item>
        /// <item><description>SceneImage: The scene image. This field is optional. This field takes effect only for the three creator marketing scenes (creator-sales, creator-talk, and product-showcase). If you specify valid fields for other scenes, an InvalidParameter error is returned. If both fields are empty (including not specified or an empty object {}), it is equivalent to not providing this parameter, and the behavior is consistent with the existing process without rejecting the job. The Prompt and BackgroundMediaId or BackgroundMediaUrl fields are both optional, can coexist, and are not mutually exclusive. If only Prompt is specified, the text mode is used to generate the scene image. If only the background image is specified, the background image mode is used to fuse based on the background image. If both are specified, the background image takes precedence. If both BackgroundMediaId and BackgroundMediaUrl are specified, BackgroundMediaUrl takes precedence. This field includes the following sub-fields:<list type="bullet">
        /// <item><description>Prompt: The text description of the scene image. This field is optional. The value is a string. The maximum length is 2,000 characters. If the length exceeds the limit, an InvalidParameter error is returned. An empty string is considered as not provided.</description></item>
        /// <item><description>BackgroundMediaId: The media asset ID of the background image. This field is optional. The value is a string. During submission, it is parsed into a URL by ice-media. If the parsing fails, the job is immediately rejected.</description></item>
        /// <item><description>BackgroundMediaUrl: The direct URL of the background image. This field is optional. The value is a string. The URL must use the HTTP or HTTPS protocol. In this case, media asset parsing is not performed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TextType&quot;:2,&quot;TextContent&quot;:&quot;Today, Beijing held a press conference to announce plans to further optimize the city\&quot;s transportation network, including adding three new subway lines within the next three years....&quot;,&quot;SceneImage&quot;:{&quot;Prompt&quot;:&quot;Real-life scene of a modern minimalist home kitchen, built-in steam oven and under-counter water purifier, warm white soft lighting, light gray marble countertop with white cabinets, clean and transparent picture with a real life atmosphere, vertical screen composition&quot;,&quot;BackgroundMediaId&quot;:&quot;<Media asset ID>&quot;,&quot;BackgroundMediaUrl&quot;:&quot;<a href="https://example.com/bg.jpg%22%7D%7D">https://example.com/bg.jpg&quot;}}</a></para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The output languages. The value is a JSON array string. Valid values: CN, EN, and YUE. The <c>avatar-broadcast</c> and <c>creator-sales</c> scenes only support Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;CN\&quot;,\&quot;EN\&quot;,\&quot;YUE\&quot;]</para>
        /// </summary>
        [NameInMap("OutputLanguages")]
        [Validation(Required=false)]
        public string OutputLanguages { get; set; }

        /// <summary>
        /// <para>The resolution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1080P</description></item>
        /// <item><description>720P (default)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The scene type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>briefing-voiceover: News broadcast (supplements video footage based on the voiceover or uses no digital human).</description></item>
        /// <item><description>creator-talk: Creator explanation (multiple shots for news, science, or finance).</description></item>
        /// <item><description>creator-sales: Creator product promotion (three-part structure for product promotion, reviews, or store visits).</description></item>
        /// <item><description>avatar-broadcast: Digital human broadcast (fixed single shot for broadcasts, announcements, or templates).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>creator-sales</para>
        /// </summary>
        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

        /// <summary>
        /// <para>The custom parameters. The value is a JSON string. The value is returned as-is in query or callback results. The maximum length is 8,192 characters. System reserved words:</para>
        /// <list type="bullet">
        /// <item><description>NotifyAddress: The callback URL. The URL must use the HTTP or HTTPS protocol. The maximum length is 2,048 characters. The callback is triggered after the node reaches the desired state.</description></item>
        /// <item><description>UserId: The UID of the actual resource ownership. If this field is missing, the system falls back to CallerUid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12374214127312673137132</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The list of user materials. The value is a JSON array string. This parameter includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description>MediaId: The media asset ID. This is the ID of the image or video uploaded to the platform.</description></item>
        /// <item><description>Type: The media type.</description></item>
        /// <item><description>Action: The method of using the material. Valid values: <c>match</c> (matches suitable clips from the video material based on the voiceover) and <c>insert</c> (inserts the video material before the CTA shot. This is intelligently analyzed after shots are generated based on the voiceover. This value is valid only for videos). Default value: <c>match</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Type\&quot;:\&quot;video\&quot;,\&quot;MediaId\&quot;:\&quot;xxxxxxxx\&quot;,\&quot;Action\&quot;:\&quot;match\&quot;}]</para>
        /// </summary>
        [NameInMap("UserMaterials")]
        [Validation(Required=false)]
        public string UserMaterials { get; set; }

        /// <summary>
        /// <para>Specifies whether to include subtitles. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithSubtitles")]
        [Validation(Required=false)]
        public bool? WithSubtitles { get; set; }

    }

}
