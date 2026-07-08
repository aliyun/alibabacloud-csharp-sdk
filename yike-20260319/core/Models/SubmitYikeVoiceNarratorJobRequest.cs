// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeVoiceNarratorJobRequest : TeaModel {
        /// <summary>
        /// <para>The node request content. JSON string. This parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>SceneType: string. The common scenarios type. Valid values: <c>briefing-voiceover</c>: news broadcasting or financial education industry.</description></item>
        /// <item><description>TextType: int. The text type. Valid values: <c>1</c>: raw text (product or news information that is automatically converted to a voice-over script by the system). <c>2</c>: voice-over script.</description></item>
        /// <item><description>TextContent: string. The text content. Maximum length: 10,000 characters.</description></item>
        /// <item><description>UserMaterials: Array\&lt;Object\&gt;. The list of user materials. Fields: MediaId: the media asset ID (an image or video uploaded to Wanjing Yike).</description></item>
        /// <item><description>NarrationVoiceId: string. The narration voice ID. For valid values, see the documentation. Default value: <c>sys_ElegantProperMiddleAgedWoman</c>.</description></item>
        /// <item><description>VoiceDuration: int. The expected voice-over duration. Set this field when <c>TextType==1</c>. Unit: seconds. Default value: 60. The final video duration is slightly shorter than the expected duration.</description></item>
        /// <item><description>AspectRatio: string. The video aspect ratio. Valid values: <c>16:9</c>, <c>9:16</c>, <c>4:3</c>, <c>3:4</c>.</description></item>
        /// <item><description>Resolution: string. The video resolution. Valid values: <c>720P</c>, <c>1080P</c>.</description></item>
        /// <item><description>OutputLanguages: Array\&lt;String\&gt;. The output video languages. Multiple values are supported (currently only Chinese is supported). Valid values: <c>CN</c>: Chinese (default). <c>EN</c>: English. <c>YUE</c>: Cantonese.</description></item>
        /// <item><description>WithSubtitles: bool. Specifies whether to include subtitles. Valid values: true: includes subtitles (default). false: does not include subtitles.</description></item>
        /// </list>
        /// <para>-- The following parameters are for the vertical screen packaging template and are valid only for the briefing-voiceover type. --</para>
        /// <list type="bullet">
        /// <item><description>TargetAspectRatio: string. The aspect ratio adapted for vertical screens. Valid values: <c>9:16</c>, <c>3:4</c>.</description></item>
        /// <item><description>Title: string. The main title displayed in the template.</description></item>
        /// <item><description>SubHeading: string. The subtitle displayed in the template.</description></item>
        /// <item><description>Date: string. The date displayed in the template.</description></item>
        /// <item><description>Watermark: object. The watermark displayed in the template. Fields: Text: the watermark text.</description></item>
        /// <item><description>EnabledAICover: bool. Specifies whether to use AI to generate a cover image.</description></item>
        /// <item><description>IPCharacter: Object. Settings for whether the AI-generated cover image includes an IP character. Fields: MediaId: the media asset ID. MediaUrl: a publicly accessible URL.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;SceneType\&quot;:\&quot;briefing-voiceover\&quot;，&quot;TextType\&quot;:2,\&quot;TextContent\&quot;:\&quot;Today, Beijing held a press conference to announce plans to further optimize the city\&quot;s transportation network, including adding three new subway lines within the next three years....\&quot;,\&quot;AspectRatio\&quot;:\&quot;16:9\&quot;, \&quot;Resolution\&quot;:\&quot;720P\&quot;, \&quot;OutputLanguages\&quot;:[\&quot;CN\&quot;,\&quot;YUE\&quot;]&quot;}</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The custom user parameter. JSON string. The callback result carries this parameter as-is (for example, newsKey).</para>
        /// <para>System reserved field NotifyAddress: the callback URL. The system sends a callback to this URL after the task is completed.
        /// <c>{&quot;NotifyAddress&quot;: &quot;http://xxx.callback.url&quot;}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://cms.example.com/callback/video-task%5C%5C%22%7D">https://cms.example.com/callback/video-task\\&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
