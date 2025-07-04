// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeComputeBurstConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;cpuEnlargeThreshold&quot;: &quot;60&quot;,
        ///     &quot;memoryEnlargeThreshold&quot;: &quot;60&quot;,
        ///     &quot;scaleMaxMemory&quot;: &quot;4&quot;,
        ///     &quot;memoryShrinkThreshold&quot;: &quot;50&quot;,
        ///     &quot;scaleMaxCpus&quot;: &quot;2&quot;,
        ///     &quot;cpuShrinkThreshold&quot;: &quot;30&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("ComputeBurstConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ComputeBurstConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ComputeBurstEnabled")]
        [Validation(Required=false)]
        public bool? ComputeBurstEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>847BA085-B377-4BFA-8267-F82345ECE1D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
