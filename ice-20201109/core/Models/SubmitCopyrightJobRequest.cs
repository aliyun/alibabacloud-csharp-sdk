// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitCopyrightJobRequest : TeaModel {
        /// <summary>
        /// <para>A description of the watermark job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input video file to be watermarked.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The OSS object or media asset must be in the same region as the service call.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example.mp4&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitCopyrightJobRequestInput Input { get; set; }
        public class SubmitCopyrightJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The input file, specified as either an OSS URL or a media asset ID. The following formats are supported for OSS URLs:</para>
            /// <para>1\. <c>oss://bucket/object</c></para>
            /// <para>2\. <c>http(s)://bucket.oss-[regionId].aliyuncs.com/object</c></para>
            /// <para>In these formats, <c>bucket</c> specifies the name of an OSS bucket in the same region as the service, and <c>object</c> specifies the file path.</para>
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
            /// <item><description><para><c>OSS</c>: The URL of an OSS object.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: The media asset ID.</para>
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
        /// <para>The watermark level, which specifies the embedding channel. Valid values are 0, 1, and 2, which correspond to the U, UV, and YUV channels, respectively.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// <para>The watermark content to embed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Copyright watermark test</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The location of the output file.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The OSS bucket must be in the same region as the service call.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example_result.mp4&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitCopyrightJobRequestOutput Output { get; set; }
        public class SubmitCopyrightJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The OSS URL for the output file. The following formats are supported:</para>
            /// <para>1\. <c>oss://bucket/object</c></para>
            /// <para>2\. <c>http(s)://bucket.oss-[regionId].aliyuncs.com/object</c><br>In these formats, <c>bucket</c> specifies the name of an OSS bucket in the same region as the service, and <c>object</c> specifies the file path.<br></para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/output.mp4</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the output file. Valid value:</para>
            /// <ol>
            /// <item><description><c>OSS</c>: The URL of an OSS object.</description></item>
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
        /// <para>The parameters for the watermark job, specified as a JSON string. The following parameter is supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>algoType</c>: The algorithm type. Defaults to <c>v1</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>v1</c>: For videos 3 minutes or longer.</para>
        /// </description></item>
        /// <item><description><para><c>v2</c>: For short videos.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;algoType&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The start time of the watermark in seconds. Defaults to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The end time of the watermark in seconds. If unspecified, the watermark is applied until the video ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalTime")]
        [Validation(Required=false)]
        public long? TotalTime { get; set; }

        /// <summary>
        /// <para>The user data. The value can be up to 1,024 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
