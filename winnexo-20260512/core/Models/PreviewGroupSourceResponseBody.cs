// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class PreviewGroupSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The text content. This field is used for the CONTENT preview type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample content</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Indicates whether the preview is degraded to a download, meaning the resource cannot be opened in the online previewer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The preview is degraded to a download.</description></item>
        /// <item><description>false: The resource can be previewed online.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("degraded")]
        [Validation(Required=false)]
        public bool? Degraded { get; set; }

        /// <summary>
        /// <para>The file name extension. This field is used for the OSS_IMM preview type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("fileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>The file name. This field is used for the OSS_IMM preview type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.pdf</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The preview type. Valid values: OSS_IMM, IMAGE, AUDIO, VIDEO, HTML, DING_TALK, VOICE_MEETING, and CONTENT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS_IMM</para>
        /// </summary>
        [NameInMap("previewType")]
        [Validation(Required=false)]
        public string PreviewType { get; set; }

        /// <summary>
        /// <para>The preview URL. This field is used for the OSS_IMM, DING_TALK, and VOICE_MEETING preview types.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("previewUrl")]
        [Validation(Required=false)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// <para>The public download URL of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("publicUrl")]
        [Validation(Required=false)]
        public string PublicUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E68654BD-F7BA-5837-8686-5645D739A47C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
