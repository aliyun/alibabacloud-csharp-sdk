// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitRemakeScriptJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ComprehensionResult&quot;: &quot;<a href="http://xxxx.json">http://xxxx.json</a>&quot;,
        ///     &quot;Product&quot;:
        ///     {
        ///         &quot;OriginalProductName&quot;: &quot;xxxx&quot;,
        ///         &quot;NewProduct&quot;:
        ///         {
        ///             &quot;ProductName&quot;: &quot;xxxx&quot;,
        ///             &quot;Description&quot;: &quot;xxxx&quot;,
        ///             &quot;ProductImages&quot;:
        ///             [
        ///                 &quot;<a href="https://xxxx.png">https://xxxx.png</a>&quot;,
        ///                 &quot;<a href="https://xxxx.png">https://xxxx.png</a>&quot;,
        ///                 &quot;<a href="https://xxxx.png">https://xxxx.png</a>&quot;
        ///             ],
        ///             &quot;ProductKnowledge&quot;: &quot;xxxx&quot;
        ///         }
        ///     },
        ///     &quot;Avatar&quot;:
        ///     {
        ///         &quot;NewAvatarImages&quot;:
        ///         [
        ///             &quot;<a href="https://xxxx.png">https://xxxx.png</a>&quot;
        ///         ],
        ///         &quot;OriginalAvatarName&quot;: &quot;xxxx&quot;
        ///     },
        ///     &quot;VoiceoverLanguage&quot;: &quot;zh&quot;
        /// }</para>
        /// </summary>
        [NameInMap("RemakeParams")]
        [Validation(Required=false)]
        public string RemakeParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>faithful-remake</para>
        /// </summary>
        [NameInMap("RemakeType")]
        [Validation(Required=false)]
        public string RemakeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
