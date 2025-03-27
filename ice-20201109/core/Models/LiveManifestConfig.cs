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

        [NameInMap("ManifestName")]
        [Validation(Required=false)]
        public string ManifestName { get; set; }

        [NameInMap("MaxVideoBitrate")]
        [Validation(Required=false)]
        public int? MaxVideoBitrate { get; set; }

        [NameInMap("MinBufferTime")]
        [Validation(Required=false)]
        public int? MinBufferTime { get; set; }

        [NameInMap("MinVideoBitrate")]
        [Validation(Required=false)]
        public int? MinVideoBitrate { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("SegmentNum")]
        [Validation(Required=false)]
        public int? SegmentNum { get; set; }

        [NameInMap("StreamOrder")]
        [Validation(Required=false)]
        public string StreamOrder { get; set; }

        [NameInMap("UseAudioRenditionGroups")]
        [Validation(Required=false)]
        public bool? UseAudioRenditionGroups { get; set; }

    }

}
