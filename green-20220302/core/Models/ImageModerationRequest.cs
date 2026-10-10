// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageModerationRequest : TeaModel {
        /// <summary>
        /// <para>The detection types supported by Image Moderation Enhanced Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>baselineCheck: general baseline check</description></item>
        /// <item><description>baselineCheck_pro: general baseline check (Professional Edition)</description></item>
        /// <item><description>baselineCheck_cb: general baseline check (Overseas Edition)</description></item>
        /// <item><description>tonalityImprove: content governance detection</description></item>
        /// <item><description>aigcCheck: AIGC image detection</description></item>
        /// <item><description>aigcViolationDetection: AIGC image infringement detection</description></item>
        /// <item><description>aigcDetector: AIGC image generation determination</description></item>
        /// <item><description>profilePhotoCheck: profile picture detection</description></item>
        /// <item><description>postImageCheck: post and comment image detection</description></item>
        /// <item><description>advertisingCheck: marketing material detection</description></item>
        /// <item><description>liveStreamCheck: video or live stream screenshot detection</description></item>
        /// <item><description>generalOcr: general image and text OCR</description></item>
        /// <item><description>generalRecognition: universal image recognition</description></item>
        /// <item><description>postImageCheckByVL: image moderation service with large and small model fusion</description></item>
        /// <item><description>postImageCheckByVL_cb: image moderation service with large and small model fusion (Overseas Edition)</description></item>
        /// <item><description>baselineCheckByVL: general image moderation large model service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameter set for the content moderation object. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>imageUrl: the URL of the object to be moderated. Required.</description></item>
        /// <item><description>dataId: the data ID corresponding to the moderation object. Optional.</description></item>
        /// <item><description>referer: the Referer request header, used for scenarios such as hotlink protection. Optional.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;imageUrl&quot;:&quot;<a href="https://img.alicdn.com/tfs/TB1U4r9AeH2gK0jSZJnXXaT1FXa-2880-480.png%22,%22dataId%22:%22img1234567%22%7D">https://img.alicdn.com/tfs/TB1U4r9AeH2gK0jSZJnXXaT1FXa-2880-480.png&quot;,&quot;dataId&quot;:&quot;img1234567&quot;}</a></para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
