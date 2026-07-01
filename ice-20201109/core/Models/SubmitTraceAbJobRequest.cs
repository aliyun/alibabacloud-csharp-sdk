// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTraceAbJobRequest : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded encryption key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qh6OdgIMcliQSI1fReOw****</para>
        /// </summary>
        [NameInMap("CipherBase64ed")]
        [Validation(Required=false)]
        public string CipherBase64ed { get; set; }

        /// <summary>
        /// <para>The input video for the A/B stream forensic watermarking job.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The Object Storage Service (OSS) file or media asset must be in the same region where Intelligent Media Services (IMS) is deployed.</para>
        /// </description></item>
        /// <item><description><para>This operation supports only videos that are three minutes or longer. Using a shorter video may cause the API call to fail or produce no output.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitTraceAbJobRequestInput Input { get; set; }
        public class SubmitTraceAbJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The location of the input file. This can be an OSS URL or a media asset ID.
            /// The supported OSS URL formats are:</para>
            /// <para>1\. <c>oss://&lt;bucket&gt;/&lt;object&gt;</c></para>
            /// <para>2\. <c>http(s)://&lt;bucket&gt;.oss-[regionId].aliyuncs.com/&lt;object&gt;</c></para>
            /// <para>In these formats, <c>&lt;bucket&gt;</c> is the name of the OSS bucket, which must be in the same region as your project, and <c>&lt;object&gt;</c> is the path to the file.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input file. Valid values:</para>
            /// <ol>
            /// <item><description><para><c>OSS</c>: The file is specified by an OSS URL.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: The file is specified by a media asset ID.</para>
            /// </description></item>
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
        /// <para>The watermark level, which specifies the embedding channel. Valid values: <c>0</c> (U channel), <c>1</c> (UV channels), and <c>2</c> (YUV channels).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// <para>The output location for the A/B stream job. This must be an OSS directory.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitTraceAbJobRequestOutput Output { get; set; }
        public class SubmitTraceAbJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The output path. Specify an OSS directory URL or a media asset ID. If you specify an OSS URL, use one of the following formats for the output directory:</para>
            /// <para>1\. <c>oss://&lt;bucket&gt;/&lt;dir&gt;/</c></para>
            /// <para>2\. <c>http(s)://&lt;bucket&gt;.oss-[regionId].aliyuncs.com/&lt;dir&gt;/</c></para>
            /// <para>In these formats, <c>&lt;bucket&gt;</c> is the name of the OSS bucket, which must be in the same region as your project, and <c>&lt;dir&gt;</c> is the output directory path.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/dir/</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the output object.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>OSS</c>: An OSS object.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: A media asset ID.</para>
            /// </description></item>
            /// </list>
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
        /// <para>The start time for watermark embedding, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The total duration for watermark embedding, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("TotalTime")]
        [Validation(Required=false)]
        public long? TotalTime { get; set; }

        /// <summary>
        /// <para>User data to include in the request. The maximum length is 1,024 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
