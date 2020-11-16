// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterSceneAudioResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("FollowEnable")]
        [Validation(Required=true)]
        public int? FollowEnable { get; set; }

        [NameInMap("AudioLayers")]
        [Validation(Required=true)]
        public DescribeCasterSceneAudioResponseAudioLayers AudioLayers { get; set; }
        public class DescribeCasterSceneAudioResponseAudioLayers : TeaModel {
            [NameInMap("AudioLayer")]
            [Validation(Required=true)]
            public List<DescribeCasterSceneAudioResponseAudioLayersAudioLayer> AudioLayer { get; set; }
            public class DescribeCasterSceneAudioResponseAudioLayersAudioLayer : TeaModel {
                public float? VolumeRate { get; set; }
                public string ValidChannel { get; set; }
                public int? FixedDelayDuration { get; set; }
            }
        };

        [NameInMap("MixList")]
        [Validation(Required=true)]
        public DescribeCasterSceneAudioResponseMixList MixList { get; set; }
        public class DescribeCasterSceneAudioResponseMixList : TeaModel {
            [NameInMap("LocationId")]
            [Validation(Required=true)]
            public List<string> LocationId { get; set; }
        };

    }

}
