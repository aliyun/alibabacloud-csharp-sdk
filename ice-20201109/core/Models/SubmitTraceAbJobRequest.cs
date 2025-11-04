// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTraceAbJobRequest : TeaModel {
        /// <summary>
        /// <para>The key that is encoded by using the Base64 algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qh6OdgIMcliQSI1fReOw****</para>
        /// </summary>
        [NameInMap("CipherBase64ed")]
        [Validation(Required=false)]
        public string CipherBase64ed { get; set; }

        /// <summary>
        /// <para>The source video file for A/B watermarking.</para>
        /// <remarks>
        /// <para>OSS object or media asset must reside in the same region as the IMS service region. This API supports only videos that last at least 3 minutes. If the video is too short, the call may fail, or no output may be returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitTraceAbJobRequestInput Input { get; set; }
        public class SubmitTraceAbJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The source file. The file can be an OSS object or a media asset. You can specify the path of an OSS object in one of the following formats:</para>
            /// <para>1\. oss://bucket/object</para>
            /// <para>2\. http(s)://bucket.oss-[regionId].aliyuncs.com/object</para>
            /// <para>where bucket specifies an OSS bucket that resides in the same region as the job, and object specifies the object path in OSS.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/object</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the source file. Valid values:</para>
            /// <ol>
            /// <item><description>OSS: an OSS object.</description></item>
            /// <item><description>Media: a media asset.</description></item>
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
        /// <para>The watermark level, which specifies the channel to embed watermarks. Valid values: 0 specifies the 0u channel, 1 specifies the 1uv channel, and 2 specifies the 2yuv channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// <para>The output directory path.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitTraceAbJobRequestOutput Output { get; set; }
        public class SubmitTraceAbJobRequestOutput : TeaModel {
            /// <summary>
            /// <para>The output file. The file can be an OSS object or a media asset. OSS URL formats:</para>
            /// <para>1\. oss://bucket/dir/</para>
            /// <para>2\. http(s)://bucket.oss-[regionId].aliyuncs.com/dir/</para>
            /// <para>In the URL, bucket specifies an OSS bucket that resides in the same region as the job, and dir specifies the object path in OSS.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/dir/</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the output file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: an OSS object.</description></item>
            /// <item><description>Media: a media asset.</description></item>
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
        /// <para>The start point of watermark embedding. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The duration of the watermark embedding. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("TotalTime")]
        [Validation(Required=false)]
        public long? TotalTime { get; set; }

        /// <summary>
        /// <para>The custom data, which can be up to 1,024 bytes in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
