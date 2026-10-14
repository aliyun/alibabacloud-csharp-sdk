// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateWatermarkExtractTaskRequest : TeaModel {
        /// <summary>
        /// <para>A reserved idempotency field. Idempotency is not supported. Passing in a value does not cause an error, but it does not produce an idempotency effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The file type. Valid values: <c>image</c> and <c>video</c>. The value must be the same as the <c>FileType</c> used when the watermark was embedded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The URL of the file from which the watermark is to be extracted. Images and videos are supported. Only the <c>http/https</c> protocol is supported. Videos must be no longer than 10 minutes and no larger than 100 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/demo.mp4">https://example.com/demo.mp4</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>A reserved field. No valid values are available. Do not pass in this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Reserved")]
        [Validation(Required=false)]
        public string Reserved { get; set; }

    }

}
