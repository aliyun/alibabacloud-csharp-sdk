// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitCopyrightExtractJobRequest : TeaModel {
        /// <summary>
        /// <para>The video file for watermark extraction.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The region of the Object Storage Service (OSS) file or media asset must match the region of the current Intelligent Media Service (IMS) instance.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitCopyrightExtractJobRequestInput Input { get; set; }
        public class SubmitCopyrightExtractJobRequestInput : TeaModel {
            /// <summary>
            /// <para>Specifies the URL of an Object Storage Service (OSS) object or the ID of a media asset.
            /// OSS URLs can be in the following formats:</para>
            /// <para>1\. oss\://bucket/object</para>
            /// <para>2\. http(s)://bucket.oss-[regionId].aliyuncs.com/object</para>
            /// <para>In these formats, <c>bucket</c> is the name of a bucket in the same region as your IMS instance, and <c>object</c> is the file path.</para>
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
            /// <item><description><para>OSS: The URL of a file in Object Storage Service (OSS).</para>
            /// </description></item>
            /// <item><description><para>Media: The ID of a media asset.</para>
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
        /// <para>The watermark job parameters, specified as a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para>algoType: The algorithm type. Default value: v1. The extraction algorithm type must match the algorithm type used for embedding the watermark.</para>
        /// <list type="bullet">
        /// <item><description><para>v1: The copyright extraction algorithm for long-form videos.</para>
        /// </description></item>
        /// <item><description><para>v2: The copyright extraction algorithm for short-form videos.</para>
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
        /// <para>The user-defined data. The maximum length is 1,024 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
