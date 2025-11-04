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
        /// <para>The OSS URL of the output M3U8 file.</para>
        /// <remarks>
        /// <para>The OSS bucket must reside in the same region as the service region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitTraceM3u8JobRequestOutput Output { get; set; }
        public class SubmitTraceM3u8JobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The OSS path where the output file is saved. You can specify the path in one of the following formats:</para>
            /// <para>1\. oss://bucket/object</para>
            /// <para>2\. http(s)://bucket.oss-[regionId].aliyuncs.com/object where bucket specifies an OSS bucket that resides in the same region as the job, and object specifies the object path in OSS.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the output file. Valid value:</para>
            /// <ol>
            /// <item><description>OSS: an OSS object.</description></item>
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
        /// <para>Additional parameters for the watermark job, provided as a JSON string. Supported parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>m3u8Type: The type of M3U8 to generate. Defaults to v1.</para>
        /// <list type="bullet">
        /// <item><description>v1: Generates an M3U8 with absolute paths, playable directly. The signed URL for access is valid for 24 hours. If you need to use it after expiration, you must call this API again.</description></item>
        /// <item><description>v2: Generates an M3U8 with relative paths. It must be placed in the same directory as the TS segment files to be playable.</description></item>
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
        /// <para>The specific trace watermark information.</para>
        /// </summary>
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public string Trace { get; set; }

        /// <summary>
        /// <para>The media ID for the trace watermark. You can obtain this from the response of the SubmitTraceAbJob operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>437bd2b516ffda105d07b12a9a82****</para>
        /// </summary>
        [NameInMap("TraceMediaId")]
        [Validation(Required=false)]
        public string TraceMediaId { get; set; }

    }

}
