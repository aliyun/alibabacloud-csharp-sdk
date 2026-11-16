// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoRenderJobRequest : TeaModel {
        /// <summary>
        /// <para>The complete creative script confirmed or edited by the user, formatted as a JSON string. The structure must align with the JSON content in the Result file returned by the GetRemakeScriptJob API.</para>
        /// 
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
        /// <para>The rendering settings, formatted as a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><b>Resolution</b> (String, required): The resolution. Valid values: 720P and 1080P.<list type="bullet">
        /// <item><description><para><b>AspectRatio</b> (String, optional): The video aspect ratio. Valid values: 9:16, 16:9, and 1:1. Default value: 9:16.</para>
        /// </description></item>
        /// <item><description><para><b>VoiceoverLanguage</b> (String, optional): The voiceover language. Valid values: zh (Chinese), en (English), es (Spanish), pt (Portuguese), fr (French), de (German), ja (Japanese), ko (Korean), and ar (Arabic). Default value: zh.</para>
        /// </description></item>
        /// <item><description><para><b>WithSubtitles</b> (Boolean, optional): Specifies whether to generate subtitles. Default value: true.</para>
        /// </description></item>
        /// <item><description><para><b>TTS</b> (Object, optional): The text-to-speech (TTS) configuration. If you do not specify this parameter, the default voice is used. This parameter applies only to single-person and voiceover-only scenarios.</para>
        /// <list type="bullet">
        /// <item><description><b>VoiceUrl</b> (String, optional): The URL of the voice file, which must be an HTTP or HTTPS address. If specified, this voice is used for the voiceover throughout the entire video.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Bgm</b> (String, optional): The URL or 32-character media asset ID of the background music.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
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
        /// <para>The user-defined parameters, formatted as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
