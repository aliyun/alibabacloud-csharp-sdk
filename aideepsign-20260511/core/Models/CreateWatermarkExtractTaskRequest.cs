// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateWatermarkExtractTaskRequest : TeaModel {
        /// <summary>
        /// <para>The reserved idempotency field. This field is not supported. Passing this field does not cause an error, but it does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The file type. Valid values: <c>image</c>, <c>video</c>, and <c>audio</c>. The value must be the same as the FileType used when the watermark was embedded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The URL of the file from which the watermark is to be extracted. Images and videos are supported. Only the HTTP and HTTPS protocols are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/demo.mp4">https://example.com/demo.mp4</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The reserved field. No valid values are available. Do not pass this field when you call the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Reserved")]
        [Validation(Required=false)]
        [Obsolete]
        public string Reserved { get; set; }

    }

}
