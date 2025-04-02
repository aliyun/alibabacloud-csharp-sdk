// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class LiveManifestConfig : TeaModel {
        [NameInMap("AdMarkers")]
        [Validation(Required=false)]
        public string AdMarkers { get; set; }

        [NameInMap("DateTimeInterval")]
        [Validation(Required=false)]
        public int? DateTimeInterval { get; set; }

        [NameInMap("MaxVideoBitrate")]
        [Validation(Required=false)]
        public int? MaxVideoBitrate { get; set; }

        [NameInMap("MinBufferTime")]
        [Validation(Required=false)]
        public int? MinBufferTime { get; set; }

        [NameInMap("MinUpdatePeriod")]
        [Validation(Required=false)]
        public int? MinUpdatePeriod { get; set; }

        [NameInMap("MinVideoBitrate")]
        [Validation(Required=false)]
        public int? MinVideoBitrate { get; set; }

        [NameInMap("SegmentCount")]
        [Validation(Required=false)]
        public int? SegmentCount { get; set; }

        [NameInMap("StreamOrder")]
        [Validation(Required=false)]
        public string StreamOrder { get; set; }

    }

}
