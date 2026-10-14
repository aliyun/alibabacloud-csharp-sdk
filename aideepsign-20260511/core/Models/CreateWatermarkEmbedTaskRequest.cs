// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateWatermarkEmbedTaskRequest : TeaModel {
        /// <summary>
        /// <para>A reserved idempotency field. This field is not supported. Passing a value does not cause an error, but it does not produce an idempotency effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The file type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image: image.</description></item>
        /// <item><description>video: video.</description></item>
        /// </list>
        /// <para>The value must match the actual file type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The URL of the file to be processed. Images and videos are supported. Only the HTTP and HTTPS protocols are supported. Videos must be no longer than 10 minutes and no larger than 100 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/demo.mp4">https://example.com/demo.mp4</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The embedding strength. Valid values: 0 to 5. A higher strength provides better robustness but lower visual quality.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;2&quot;</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>A reserved field. No valid values are available. Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Reserved")]
        [Validation(Required=false)]
        public string Reserved { get; set; }

        /// <summary>
        /// <para>The watermark content. The embedded content can be restored to the original text by calling the extraction operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wm-e2e-85970647</para>
        /// </summary>
        [NameInMap("WatermarkContent")]
        [Validation(Required=false)]
        public string WatermarkContent { get; set; }

    }

}
