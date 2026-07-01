// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertMuxConfig : TeaModel {
        /// <summary>
        /// <para>Shard configuration field. For more information, see Segment details.</para>
        /// <para>This field takes effect only when Container is set to m3u8, hls-fmp4, mpd, or cmaf.</para>
        /// </summary>
        [NameInMap("Segment")]
        [Validation(Required=false)]
        public MediaConvertSegment Segment { get; set; }

    }

}
