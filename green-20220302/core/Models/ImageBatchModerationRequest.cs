// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageBatchModerationRequest : TeaModel {
        /// <summary>
        /// <para>The detection types supported by Image Moderation Enhanced Edition. Separate multiple values with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>baselineCheck: general baseline check</description></item>
        /// <item><description>baselineCheck_pro: general baseline check professional edition</description></item>
        /// <item><description>tonalityImprove: content governance detection</description></item>
        /// <item><description>aigcCheck: AIGC image detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck,tonalityImprove</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameter set for the content moderation object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;imageUrl&quot;: &quot;<a href="https://img.alicdn.com/tfs/TB1U4r9AeH2gK0jSZJnXXaT1FXa-2880-480.png">https://img.alicdn.com/tfs/TB1U4r9AeH2gK0jSZJnXXaT1FXa-2880-480.png</a>&quot;,
        ///         &quot;dataId&quot;: &quot;img123****&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
