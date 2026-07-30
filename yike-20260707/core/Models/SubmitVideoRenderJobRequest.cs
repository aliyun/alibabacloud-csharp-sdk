// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoRenderJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        /// &quot;schemaVersion&quot;:&quot;creative/v1&quot;,
        /// &quot;algoResult&quot;:{...},
        /// &quot;extraInfo&quot;:{...}
        /// }</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;VoiceoverLanguage&quot;: &quot;zh&quot;,
        ///   &quot;Resolution&quot;: &quot;1080P&quot;,
        ///   &quot;AspectRatio&quot;: &quot;9:16&quot;,
        ///   &quot;TTS&quot;: {
        ///     &quot;VoiceUrl&quot;: &quot;<a href="http://xxx.mp3">http://xxx.mp3</a>&quot;
        ///   },
        ///   &quot;WithSubtitles&quot;: true,
        ///   &quot;Bgm&quot;: &quot;<a href="http://xxx.mp3">http://xxx.mp3</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public string Settings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
