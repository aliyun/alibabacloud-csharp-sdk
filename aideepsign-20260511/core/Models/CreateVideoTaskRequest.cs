// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateVideoTaskRequest : TeaModel {
        [NameInMap("Media")]
        [Validation(Required=false)]
        public List<CreateVideoTaskRequestMedia> Media { get; set; }
        public class CreateVideoTaskRequestMedia : TeaModel {
            /// <summary>
            /// <para>The material type for the first item. Valid values: first_frame, last_frame, reference_image, reference_video, reference_audio, file, and link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JPEG</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The material URL for the first item. The value can be a public HTTP or HTTPS URL, a temporary oss:// URL, or inline data in the data:{mime};base64,... format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Image URL</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to include an audio track. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public bool? Audio { get; set; }

        /// <summary>
        /// <para>The idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f47ac10b-58cc-4372-a567-0e02b2c3d479</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The duration of the video in seconds. Valid values: an integer from 2 to 30, -1 for intelligent duration, and 0 for the server default of 5 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The model name. Valid values: wan3.0-video (default) and wan3.0-video-prime (high-speed version).</para>
        /// 
        /// <b>Example:</b>
        /// <para>wan3.0-video</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The video description prompt. Either this parameter or Media is required. For text-to-video generation, only Prompt is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A meeting room full of cats</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable intelligent prompt rewriting. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PromptExtend")]
        [Validation(Required=false)]
        public bool? PromptExtend { get; set; }

        /// <summary>
        /// <para>The aspect ratio of the video. Valid values: adaptive, 16:9, 4:3, 1:1, 3:4, and 9:16. Default value: adaptive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adaptive</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public string Ratio { get; set; }

        /// <summary>
        /// <para>The video resolution. Valid values: 1080P, 720P, and 480P. Default value: 1080P.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080P</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The random seed. Valid values: -1 (random) or an integer from 0 to 2147483647. A value of 0 is a valid reproducible seed. If not specified, the server uses a random seed by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("Seed")]
        [Validation(Required=false)]
        public int? Seed { get; set; }

        /// <summary>
        /// <para>Specifies whether to add a Model Studio watermark. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public bool? Watermark { get; set; }

    }

}
