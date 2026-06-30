// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageBatchModerationRequest : TeaModel {
        /// <summary>
        /// <para>The detection services supported by Image Moderation Pro. Separate multiple services with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>baselineCheck: General baseline check</para>
        /// </description></item>
        /// <item><description><para>baselineCheck_pro: General baseline check (Professional Edition)</para>
        /// </description></item>
        /// <item><description><para>tonalityImprove: Content administration check</para>
        /// </description></item>
        /// <item><description><para>aigcCheck: AIGC image check</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck,tonalityImprove</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters for the content to moderate.</para>
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
