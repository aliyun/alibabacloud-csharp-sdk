// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterLayoutRequest : TeaModel {
        [NameInMap("AudioLayer")]
        [Validation(Required=false)]
        public List<ModifyCasterLayoutRequestAudioLayer> AudioLayer { get; set; }
        public class ModifyCasterLayoutRequestAudioLayer : TeaModel {
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            [NameInMap("ValidChannel")]
            [Validation(Required=false)]
            public string ValidChannel { get; set; }

            [NameInMap("VolumeRate")]
            [Validation(Required=false)]
            public float? VolumeRate { get; set; }

        }

        [NameInMap("BlendList")]
        [Validation(Required=false)]
        public List<string> BlendList { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        [NameInMap("MixList")]
        [Validation(Required=false)]
        public List<string> MixList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("VideoLayer")]
        [Validation(Required=false)]
        public List<ModifyCasterLayoutRequestVideoLayer> VideoLayer { get; set; }
        public class ModifyCasterLayoutRequestVideoLayer : TeaModel {
            [NameInMap("FillMode")]
            [Validation(Required=false)]
            public string FillMode { get; set; }

            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            [NameInMap("HeightNormalized")]
            [Validation(Required=false)]
            public float? HeightNormalized { get; set; }

            [NameInMap("PositionNormalized")]
            [Validation(Required=false)]
            public List<float?> PositionNormalized { get; set; }

            [NameInMap("PositionRefer")]
            [Validation(Required=false)]
            public string PositionRefer { get; set; }

            [NameInMap("WidthNormalized")]
            [Validation(Required=false)]
            public float? WidthNormalized { get; set; }

        }

    }

}
