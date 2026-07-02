// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeVideoCloneJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;JobParams&quot;: &quot;{\&quot;SceneType\&quot;:\&quot;variant-clone\&quot;,\&quot;OriginalVideo\&quot;:{\&quot;MediaId\&quot;:\&quot;1d342ee<b><b>c71f18000e7f6d45b6302\&quot;},\&quot;SceneConfig\&quot;:\xxxxxxxxx\&quot;,\&quot;Resolution\&quot;:\&quot;720P\&quot;,\&quot;AvatarData\&quot;:{\&quot;AvatarPortrait\&quot;:\&quot;<a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/sucai/videoremake/0518/shuziren-005.png%5C%5C%22,%5C%5C%22AvatarVoice%5C%5C%22:%5C%5C%22xxxxxx%5C%5C%22%7D,%5C%5C%22UserMaterials%5C%5C%22:%5B%7B%5C%5C%22MediaId%5C%5C%22:%5C%5C%22e3785e10">https://example-bucket.oss-cn-shanghai.aliyuncs.com/sucai/videoremake/0518/shuziren-005.png\\&quot;,\\&quot;AvatarVoice\\&quot;:\\&quot;xxxxxx\\&quot;},\\&quot;UserMaterials\\&quot;:[{\\&quot;MediaId\\&quot;:\\&quot;e3785e10</a></b></b>71f1bfc9e7f6c6586301\&quot;},{\&quot;MediaId\&quot;:\&quot;e34196a05<b><b>1f1bfb0f6f7d44b6301\&quot;},{\&quot;MediaId\&quot;:\&quot;e3628c205</b></b>1f1bfc5f7f6d4496301\&quot;},{\&quot;MediaId\&quot;:\&quot;e35e1f505<b><b>1f1bfc9e7f6c6586301\&quot;},{\&quot;MediaId\&quot;:\&quot;e37bb9705</b></b>1f18000e7f6d45b6301\&quot;}],\&quot;WithSubtitles\&quot;:true,\&quot;VoiceDuration\&quot;:15}&quot;,
        ///   &quot;UserData&quot;: &quot;{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://example.com/callback/video-task%5C%5C%22%7D">https://example.com/callback/video-task\\&quot;}</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://cms.example.com/callback/video-task%5C%5C%22%7D">https://cms.example.com/callback/video-task\\&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
