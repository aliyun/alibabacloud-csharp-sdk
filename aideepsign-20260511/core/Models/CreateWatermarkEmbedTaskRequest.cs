// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateWatermarkEmbedTaskRequest : TeaModel {
        /// <summary>
        /// <para>The reserved idempotency field. This field is not supported. Passing this field does not cause an error, but it does not provide idempotency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The file type. Valid values: image, video, and audio. The value must match the actual file type. If the input is an audio file, the output is always in WAV format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The URL of the file to be processed. Images and videos are supported. Only HTTP and HTTPS protocols are supported. Videos must be shorter than 10 minutes and smaller than 100 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/demo.mp4">https://example.com/demo.mp4</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The embedding strength. Valid values: integers from 0 to 3. A higher strength indicates better robustness but lower visual quality.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;1&quot;</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The reserved field. No valid values are available. We recommend that you do not pass this field when you call the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Reserved")]
        [Validation(Required=false)]
        [Obsolete]
        public string Reserved { get; set; }

        /// <summary>
        /// <para>The watermark content. The embedded text can be restored from the output file by calling the extraction operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wm-e2e-85970647</para>
        /// </summary>
        [NameInMap("WatermarkContent")]
        [Validation(Required=false)]
        public string WatermarkContent { get; set; }

    }

}
