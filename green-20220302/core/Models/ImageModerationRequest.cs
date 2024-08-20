// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageModerationRequest : TeaModel {
        /// <summary>
        /// The moderation services supported by Image Moderation 2.0. Valid values:
        /// 
        /// *   baselineCheck: common baseline moderation
        /// *   baselineCheck_pro: common baseline moderation_Professional
        /// *   baselineCheck_cb: common baseline moderation_For regions outside the Chinese mainland
        /// *   tonalityImprove: content governance moderation
        /// *   aigcCheck: AI-generated image identification
        /// *   profilePhotoCheck: avatar image moderation
        /// *   advertisingCheck: marketing material identification
        /// *   liveStreamCheck: moderation of screenshots of videos and live streams
        /// 
        /// Valid values:
        /// 
        /// *   liveStreamCheck: moderation of screenshots of videos and live streams
        /// *   baselineCheck: common baseline moderation
        /// *   aigcCheck: AI-generated image identification
        /// *   baselineCheck_pro: common baseline moderation_Professional
        /// *   advertisingCheck: marketing material identification
        /// *   baselineCheck_cb: common baseline moderation_For regions outside the Chinese mainland
        /// *   tonalityImprove: content governance moderation
        /// *   profilePhotoCheck: avatar image moderation
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// The parameters required by the moderation service. The value is a JSON string.
        /// 
        /// *   imageUrl: the URL of the object that you want to moderate. This parameter is required.
        /// *   dataId: the ID of the object that you want to moderate. This parameter is optional.
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
