// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateCasterSceneAudioRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("FollowEnable")]
        [Validation(Required=false)]
        public int? FollowEnable { get; set; }

        [NameInMap("AudioLayer")]
        [Validation(Required=false)]
        public List<UpdateCasterSceneAudioRequestAudioLayer> AudioLayer { get; set; }
        public class UpdateCasterSceneAudioRequestAudioLayer : TeaModel {
            [NameInMap("VolumeRate")]
            [Validation(Required=false)]
            public float? VolumeRate { get; set; }

            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            [NameInMap("ValidChannel")]
            [Validation(Required=false)]
            public string ValidChannel { get; set; }

        }

        [NameInMap("MixList")]
        [Validation(Required=false)]
        public List<string> MixList { get; set; }

    }

}
