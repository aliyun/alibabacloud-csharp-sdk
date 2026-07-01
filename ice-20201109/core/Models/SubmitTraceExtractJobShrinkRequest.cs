// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTraceExtractJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The input video from which to extract the watermark.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The OSS object or media asset must be in the same region as your IMS service.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>Extraction job parameters, specified as a JSON string. The following parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>m3u8Type</c>: The algorithm type. The default value is <c>v1</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>v1</c>: Extracts an m3u8 playlist with absolute paths.</para>
        /// </description></item>
        /// <item><description><para><c>v2</c>: Extracts an m3u8 playlist with relative paths.</para>
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
        /// <para>The user-defined data. Maximum length: 1,024 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
