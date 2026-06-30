// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageAsyncModerationRequest : TeaModel {
        /// <summary>
        /// <para>The detection service supported by the enhanced image moderation feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>baselineCheck: common baseline moderation</para>
        /// </description></item>
        /// <item><description><para>baselineCheck_pro: common baseline moderation Professional Edition</para>
        /// </description></item>
        /// <item><description><para>baselineCheck_cb: common baseline moderation for services outside China</para>
        /// </description></item>
        /// <item><description><para>tonalityImprove: content administration moderation</para>
        /// </description></item>
        /// <item><description><para>aigcCheck: AIGC image moderation</para>
        /// </description></item>
        /// <item><description><para>profilePhotoCheck: profile picture moderation</para>
        /// </description></item>
        /// <item><description><para>advertisingCheck: ad material moderation</para>
        /// </description></item>
        /// <item><description><para>liveStreamCheck: video or live stream screenshot moderation</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>A set of parameters related to the content to be moderated. The value must be a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;imageUrl&quot;:&quot;<a href="https://img.alicdn.com/tfs/TB1U4r9AeH2gK0jSZJnXXaT1FXa-2880-480.png%22,%22dataId%22:%22img123****%22%7D">https://img.alicdn.com/tfs/TB1U4r9AeH2gK0jSZJnXXaT1FXa-2880-480.png&quot;,&quot;dataId&quot;:&quot;img123****&quot;}</a></para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
