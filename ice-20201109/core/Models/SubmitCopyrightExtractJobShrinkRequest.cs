// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitCopyrightExtractJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The source video file from which to extract the watermark.</para>
        /// <remarks>
        /// <para>The OSS object or media asset must reside in the same region as the IMS service region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <para>Additional parameters for the watermark job, provided as a JSON string. Supported parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>algoType: The algorithm type. Defaults to v1. The extraction algorithm must match the one used for embedding.</para>
        /// <list type="bullet">
        /// <item><description>v1: Copyright watermark extraction algorithm for long videos.</description></item>
        /// <item><description>v2: Copyright watermark extraction algorithm for short videos.</description></item>
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
