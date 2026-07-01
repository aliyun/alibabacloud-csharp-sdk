// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTraceM3u8JobRequest : TeaModel {
        /// <summary>
        /// <para>The URI of the key server.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cipher.abc.com">https://cipher.abc.com</a></para>
        /// </summary>
        [NameInMap("KeyUri")]
        [Validation(Required=false)]
        public string KeyUri { get; set; }

        /// <summary>
        /// <para>The OSS destination for the output M3U8 file.</para>
        /// <remarks>
        /// <para>The OSS bucket must be in the same region as your MPS service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitTraceM3u8JobRequestOutput Output { get; set; }
        public class SubmitTraceM3u8JobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The output file path. Only OSS paths are supported. You can use one of the following formats:</para>
            /// <para>1\. <c>oss://bucket/object</c></para>
            /// <para>2\. <c>http(s)://bucket.oss-[regionId].aliyuncs.com/object</c>. In these formats, <c>bucket</c> specifies the name of an OSS bucket in the same region as your project, and <c>object</c> specifies the file path.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the output destination. Valid values:</para>
            /// <ol>
            /// <item><description><c>OSS</c>: an OSS file location.</description></item>
            /// </ol>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>A JSON string that contains parameters for the watermarking job. The following parameter is supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>m3u8Type</c>: The algorithm type. The default value is <c>v1</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>v1</c>: Generates an M3U8 file that uses an absolute path. The file can be played directly. The signature is valid for 24 hours. After expiration, you must submit a new job to get a new M3U8 file.</para>
        /// </description></item>
        /// <item><description><para><c>v2</c>: Generates an M3U8 file that uses a relative path. This file must be stored in the same directory as the TS files.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;m3u8Type&quot;:&quot;v1&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The watermark content to embed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Trace watermark test</para>
        /// </summary>
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public string Trace { get; set; }

        /// <summary>
        /// <para>The media ID of the processed A/B stream for video watermarking for tracing. This ID is returned in the response when you submit the A/B stream job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>437bd2b516ffda105d07b12a9a82****</para>
        /// </summary>
        [NameInMap("TraceMediaId")]
        [Validation(Required=false)]
        public string TraceMediaId { get; set; }

    }

}
