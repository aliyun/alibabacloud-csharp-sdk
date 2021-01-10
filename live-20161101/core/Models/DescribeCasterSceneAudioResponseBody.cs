// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterSceneAudioResponseBody : TeaModel {
        [NameInMap("MixList")]
        [Validation(Required=false)]
        public DescribeCasterSceneAudioResponseBodyMixList MixList { get; set; }
        public class DescribeCasterSceneAudioResponseBodyMixList : TeaModel {
            [NameInMap("LocationId")]
            [Validation(Required=false)]
            public List<string> LocationId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AudioLayers")]
        [Validation(Required=false)]
        public DescribeCasterSceneAudioResponseBodyAudioLayers AudioLayers { get; set; }
        public class DescribeCasterSceneAudioResponseBodyAudioLayers : TeaModel {
            [NameInMap("AudioLayer")]
            [Validation(Required=false)]
            public List<DescribeCasterSceneAudioResponseBodyAudioLayersAudioLayer> AudioLayer { get; set; }
            public class DescribeCasterSceneAudioResponseBodyAudioLayersAudioLayer : TeaModel {
                public float? VolumeRate { get; set; }
                public int? FixedDelayDuration { get; set; }
                public string ValidChannel { get; set; }
            }
        };

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("FollowEnable")]
        [Validation(Required=false)]
        public int? FollowEnable { get; set; }

    }

}
