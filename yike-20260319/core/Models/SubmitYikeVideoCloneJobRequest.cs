// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeVideoCloneJobRequest : TeaModel {
        /// <summary>
        /// <para>The job request content. JSON string that contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description>SceneType: string. The replication scene type. Valid values: <c>variant-clone</c>: full replication, applicable to same-category content rewriting scenarios where only partial elements (person/voice/image/text) are replaced.</description></item>
        /// <item><description>OriginalVideo: object type that contains the following field: MediaId - the media asset ID (video uploaded to the platform).</description></item>
        /// <item><description>SceneConfig: JSON string type. The scene extension parameters. For the variant-clone type, the value is <c>{&quot;OldProductName&quot;:&quot;xxx&quot;,&quot;ProductName&quot;:&quot;xxx&quot;}</c>.</description></item>
        /// <item><description>UserMaterials: Array<Object> type. The list of user materials that contains the following field: MediaId - the media asset ID (image or video uploaded to the platform).</description></item>
        /// <item><description>AvatarData: object type. The digital human information. AvatarPortrait: required, string, the portrait image URL. AvatarVoice: optional, string, the audio URL (used as a reference for audio replication).</description></item>
        /// <item><description>Resolution: string type. The video resolution. Valid values: <c>720P</c>, <c>1080P</c>.</description></item>
        /// <item><description>WithSubtitles: bool type. Specifies whether to include subtitles. Valid values: true: includes subtitles (default). false: does not include subtitles.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;JobParams&quot;: &quot;{\&quot;SceneType\&quot;:\&quot;variant-clone\&quot;,\&quot;OriginalVideo\&quot;:{\&quot;MediaId\&quot;:\&quot;1d342ee<b><b>c71f18000e7f6d45b6302\&quot;},\&quot;SceneConfig\&quot;:\xxxxxxxxx\&quot;,\&quot;Resolution\&quot;:\&quot;720P\&quot;,\&quot;AvatarData\&quot;:{\&quot;AvatarPortrait\&quot;:\&quot;<a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/sucai/videoremake/0518/shuziren-005.png%5C%5C%22,%5C%5C%22AvatarVoice%5C%5C%22:%5C%5C%22xxxxxx%5C%5C%22%7D,%5C%5C%22UserMaterials%5C%5C%22:%5B%7B%5C%5C%22MediaId%5C%5C%22:%5C%5C%22e3785e10">https://example-bucket.oss-cn-shanghai.aliyuncs.com/sucai/videoremake/0518/shuziren-005.png\\&quot;,\\&quot;AvatarVoice\\&quot;:\\&quot;xxxxxx\\&quot;},\\&quot;UserMaterials\\&quot;:[{\\&quot;MediaId\\&quot;:\\&quot;e3785e10</a></b></b>71f1bfc9e7f6c6586301\&quot;}],\&quot;WithSubtitles\&quot;:true}&quot;
        /// }</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The custom user parameter. JSON string. The callback result carries this value as-is (for example, newsKey).</para>
        /// <para>System reserved field NotifyAddress: the callback URL. The system sends a callback to this URL after the task is completed. Example: {&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://cms.example.com/callback/video-task%5C%5C%22%7D">https://cms.example.com/callback/video-task\\&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
