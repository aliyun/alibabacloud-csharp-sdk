// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTraceExtractJobRequest : TeaModel {
        /// <summary>
        /// <para>The source video file from which to extract the watermark.</para>
        /// <remarks>
        /// <para>The OSS object or media asset must reside in the same region as the IMS service region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitTraceExtractJobRequestInput Input { get; set; }
        public class SubmitTraceExtractJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The specific information for the source file, which can be an OSS URL or a media asset ID. OSS URL formats:</para>
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
        /// <para>Additional parameters for the watermark job, provided as a JSON string. Supported parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>m3u8Type: The extraction algorithm type. Defaults to v1.</para>
        /// <list type="bullet">
        /// <item><description>v1: Extracts from an M3U8 with absolute paths.</description></item>
        /// <item><description>v2: Extracts from an M3U8 with relative paths.</description></item>
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
