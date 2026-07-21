// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class MetricKVPairDTO : TeaModel {
        /// <summary>
        /// <para>Metric Name.  </para>
        /// <para><b>Chat</b>  </para>
        /// <list type="bullet">
        /// <item><description><c>total_calls</c>: Number Of Calls, integer, Count  </description></item>
        /// <item><description><c>input_tokens</c>: Total input tokens, integer  </description></item>
        /// <item><description><c>output_tokens</c>: Total output tokens, integer  </description></item>
        /// <item><description><c>reasoning_tokens</c>: Reasoning tokens, integer  </description></item>
        /// <item><description><c>cached_tokens</c>: Cached input tokens (hit), integer</description></item>
        /// </list>
        /// <para><b>Vision</b>  </para>
        /// <list type="bullet">
        /// <item><description><c>total_calls</c>: Number Of Calls, integer, Count  </description></item>
        /// <item><description><c>image_count</c>: Number of generated images, integer  </description></item>
        /// <item><description><c>video_duration</c>: Generated video duration, rounded to 3 decimal places, seconds</description></item>
        /// </list>
        /// <para><b>Embedding</b>  </para>
        /// <list type="bullet">
        /// <item><description><c>total_calls</c>: Number Of Calls, integer, Count  </description></item>
        /// <item><description><c>embedding_output_tokens</c>: Embedding output tokens, integer  </description></item>
        /// <item><description><c>billing_tokens</c>: Total billing tokens, integer  </description></item>
        /// <item><description><c>image_tokens</c>: Image tokens (multimodal embedding), integer</description></item>
        /// </list>
        /// <para><b>Omni-modal (ChatFullmodal / ChatMultimodal)</b>  </para>
        /// <list type="bullet">
        /// <item><description><c>total_calls</c>: Number Of Calls, integer, Count  </description></item>
        /// <item><description><c>input_text_tokens</c>: Input text tokens, integer  </description></item>
        /// <item><description><c>input_audio_tokens</c>: Input audio tokens, integer  </description></item>
        /// <item><description><c>input_image_tokens</c>: Input image tokens, integer  </description></item>
        /// <item><description><c>input_video_tokens</c>: Input video tokens, integer  </description></item>
        /// <item><description><c>output_text_tokens</c>: Output text tokens, integer  </description></item>
        /// <item><description><c>output_audio_tokens</c>: Output audio tokens, integer</description></item>
        /// </list>
        /// <para><b>Speech (TTS / ASR)</b>  </para>
        /// <list type="bullet">
        /// <item><description><c>total_calls</c>: Number Of Calls, integer, Count  </description></item>
        /// <item><description><c>characters</c>: Characters converted to speech, integer  </description></item>
        /// <item><description><c>asr_duration</c>: Speech recognition duration, rounded to 3 decimal places, seconds</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>total_calls</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Metric value</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
