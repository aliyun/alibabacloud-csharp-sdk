// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteMezzaninesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly delete the mezzanine file. Default value: **false**.
        /// 
        /// > If a video is delivered without transcoding or is asynchronously transcoded, the mezzanine file of the video is used for original-quality playback. By default, the mezzanine file of the video cannot be deleted. To forcibly delete the mezzanine file, set this parameter to **true**.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The list of video IDs. A maximum of 20 video IDs can be specified at a time. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("VideoIds")]
        [Validation(Required=false)]
        public string VideoIds { get; set; }

    }

}
