// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeAvatarNarratorJobRequest : TeaModel {
        /// <summary>
        /// <para>The node request content. JSON string. This parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>SceneType: string. The common scenario type. Valid values: <c>creator-talk</c>: knowledge sharing, applicable to influencer sharing and explanation scenarios in industries such as finance and education.</description></item>
        /// <item><description>TextType: int. The text type. Valid values: 1: raw script (product or news information, which the system automatically converts to an oral broadcast script). 2: oral broadcast script.</description></item>
        /// <item><description>TextContent: string. The text content. Maximum length: 10000 characters.</description></item>
        /// <item><description>UserMaterials: Array\&lt;Object\&gt;. The list of user materials. Fields: MediaId: the media asset ID (image or video uploaded to Wanjing Yike).</description></item>
        /// <item><description>AvatarData: object. The digital human information. AvatarPortrait: required, string, the URL of the portrait image. AvatarVoice: optional, string, the audio URL (used as a reference for voice cloning) or a voice ID from the library (see the Wanjing Yike voice library. The system selects automatically).</description></item>
        /// <item><description>VoiceDuration: int. The expected oral broadcast duration. Settings for this field apply when TextType is 1. Unit: seconds. Default value: 60. The final video duration is slightly shorter than the expected duration.</description></item>
        /// <item><description>AspectRatio: string. The video dimensions. Valid values: 16:9, 9:16, 4:3, 3:4.</description></item>
        /// <item><description>Resolution: string. The video resolution. Valid values: 720P, 1080P.</description></item>
        /// <item><description>OutputLanguages: Array. The output video languages. Multiple values are supported. Currently, only Chinese is supported. Valid values: CN: Chinese (default). EN: English. YUE: Cantonese.</description></item>
        /// <item><description>WithSubtitles: bool. Specifies whether to include subtitles. Valid values: true: include subtitles (default). false: do not include subtitles.</description></item>
        /// </list>
        /// <para>-- The following parameters are for the vertical screen packaging template and are valid only for the creator-talk type. --</para>
        /// <list type="bullet">
        /// <item><description>TargetAspectRatio: string. The dimensions adapted for vertical screen. Valid values: <c>16:9</c>, <c>9:16</c>, <c>4:3</c>, <c>3:4</c>.</description></item>
        /// <item><description>Title: string. The main title displayed in the template.</description></item>
        /// <item><description>SubHeading: string. The subtitle displayed in the template.</description></item>
        /// <item><description>Date: string. The date displayed in the template.</description></item>
        /// <item><description>Watermark: object. The watermark displayed in the template. Fields: Text: the watermark text.</description></item>
        /// <item><description>EnabledAICover: bool. Specifies whether to use AI to generate a cover image.</description></item>
        /// <item><description>IPCharacter: Object. Specifies whether the AI-generated cover image includes an IP character. Fields: MediaId: the media asset ID. MediaUrl: a publicly accessible URL.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;JobParams&quot;: &quot;{\&quot;SceneType\&quot;:\&quot;creator-talk\&quot;,\&quot;TextType\&quot;:1,\&quot;TextContent\&quot;:\&quot;大摩点评美团业绩：无惊吓无惊喜，核心博弈点依然在市场份额与利润率回升。\&quot;,\&quot;AspectRatio\&quot;:\&quot;4:3\&quot;,\&quot;Resolution\&quot;:\&quot;720P\&quot;,\&quot;OutputLanguages\&quot;:[\&quot;CN\&quot;,\&quot;EN\&quot;,\&quot;YUE\&quot;],\&quot;VoiceDuration\&quot;:15,\&quot;UserMaterials\&quot;:[{\&quot;MediaId\&quot;:\&quot;d5a26b50<b><b>71f1bfd9e7f6d45b6302\&quot;},{\&quot;MediaId\&quot;:\&quot;4ce65730</b></b>71f1bfd9e7f6d45b6302\&quot;}],\&quot;WithSubtitles\&quot;:true,\&quot;AvatarData\&quot;:{\&quot;AvatarPortrait\&quot;:\&quot;<a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/aigc/market/cloth/avatar_image.png%5C%5C%22,%5C%5C%22AvatarVoice%5C%5C%22:%5C%5C%22sys_ElegantProperMiddleAgedWoman%5C%5C%22%7D%7D">https://example-bucket.oss-cn-shanghai.aliyuncs.com/aigc/market/cloth/avatar_image.png\\&quot;,\\&quot;AvatarVoice\\&quot;:\\&quot;sys_ElegantProperMiddleAgedWoman\\&quot;}}</a>&quot;,
        ///   &quot;UserData&quot;: &quot;{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://example.com/callback/video-task%5C%5C%22%7D">https://example.com/callback/video-task\\&quot;}</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The custom user parameter. JSON string. This parameter is returned as-is in the callback result (for example, newsKey).</para>
        /// <para>The system reserved field NotifyAddress specifies the callback URL. The system sends a callback to this URL after the task is complete. Example: {&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://cms.example.com/callback/video-task%5C%5C%22%7D">https://cms.example.com/callback/video-task\\&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
