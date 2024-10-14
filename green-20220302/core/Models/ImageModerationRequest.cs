// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageModerationRequest : TeaModel {
        /// <summary>
        /// <para>The moderation services supported by Image Moderation 2.0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>baselineCheck: common baseline moderation</description></item>
        /// <item><description>baselineCheck_pro: common baseline moderation_Professional</description></item>
        /// <item><description>baselineCheck_cb: common baseline moderation_For regions outside the Chinese mainland</description></item>
        /// <item><description>tonalityImprove: content governance moderation</description></item>
        /// <item><description>aigcCheck: AI-generated image identification</description></item>
        /// <item><description>profilePhotoCheck: avatar image moderation</description></item>
        /// <item><description>advertisingCheck: marketing material identification</description></item>
        /// <item><description>liveStreamCheck: moderation of screenshots of videos and live streams</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>liveStreamCheck: moderation of screenshots of videos and live streams</description></item>
        /// <item><description>baselineCheck: common baseline moderation</description></item>
        /// <item><description>aigcCheck: AI-generated image identification</description></item>
        /// <item><description>baselineCheck_pro: common baseline moderation_Professional</description></item>
        /// <item><description>advertisingCheck: marketing material identification</description></item>
        /// <item><description>baselineCheck_cb: common baseline moderation_For regions outside the Chinese mainland</description></item>
        /// <item><description>tonalityImprove: content governance moderation</description></item>
        /// <item><description>profilePhotoCheck: avatar image moderation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters required by the moderation service. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>imageUrl: the URL of the object that you want to moderate. This parameter is required.</description></item>
        /// <item><description>dataId: the ID of the object that you want to moderate. This parameter is optional.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;imageUrl&quot;:&quot;<a href="https://www.aliyun.com/test.jpg%22,%22dataId%22:%22img1234567%22%7D">https://www.aliyun.com/test.jpg&quot;,&quot;dataId&quot;:&quot;img1234567&quot;}</a></para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
