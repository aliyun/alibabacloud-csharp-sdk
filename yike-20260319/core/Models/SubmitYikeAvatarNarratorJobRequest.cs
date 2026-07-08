// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeAvatarNarratorJobRequest : TeaModel {
        /// <summary>
        /// <para>The task request content. The value is a JSON string that contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>SceneType: string. The common scenario type. Valid values:<list type="bullet">
        /// <item><description>creator-talk: knowledge explanation. Applicable to scenarios such as news, popular science, and financial explanation.</description></item>
        /// <item><description>avatar-broadcast: digital human broadcasting. A fixed single-shot scenario.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>TextType: int. The text type. Valid values:<list type="bullet">
        /// <item><description>1: raw script. The system automatically converts product or news information into an oral broadcast script. This value is not supported for avatar-broadcast.</description></item>
        /// <item><description>2: oral broadcast script.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>TextContent: string. The text content. Maximum length: 10,000 characters.</description></item>
        /// <item><description>UserMaterials: Array\&lt;Object\&gt;. The list of user materials. This parameter is not supported for avatar-broadcast. Fields:<list type="bullet">
        /// <item><description>MediaId: the media asset ID. The ID of an image or video uploaded to Wanjing Yike.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AvatarData: object. The digital human information.<list type="bullet">
        /// <item><description>AvatarPortrait: required. String. The URL of the portrait image.</description></item>
        /// <item><description>AvatarVoice: optional. String. The URL of an audio file for voice cloning reference, or a voice ID from the built-in voice library. For more information, see the Wanjing Yike voice library. If this parameter is not specified, the system automatically selects a voice.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>VoiceDuration: int. The expected oral broadcast duration. Set this parameter when TextType is set to 1. Unit: seconds. Default value: 60. The final video duration is slightly shorter than the expected duration.</description></item>
        /// <item><description>AspectRatio: string. The video dimensions. Valid values: 16:9, 9:16, 4:3, and 3:4.</description></item>
        /// <item><description>Resolution: string. The video resolution. Valid values: 720P and 1080P.</description></item>
        /// <item><description>WithSubtitles: bool. Specifies whether to add subtitles. Valid values:<list type="bullet">
        /// <item><description>true (default): Add subtitles.</description></item>
        /// <item><description>false: Do not add subtitles.</description></item>
        /// </list>
        /// </description></item>
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
        /// <para>The custom user parameter. The value is a JSON string that is returned as-is in the callback result, for example, newsKey.</para>
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
