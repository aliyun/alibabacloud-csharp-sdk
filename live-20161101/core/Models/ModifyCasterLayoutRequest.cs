// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterLayoutRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("LayoutId")]
        [Validation(Required=true)]
        public string LayoutId { get; set; }

        [NameInMap("VideoLayer")]
        [Validation(Required=true)]
        public List<ModifyCasterLayoutRequestVideoLayer> VideoLayer { get; set; }
        public class ModifyCasterLayoutRequestVideoLayer : TeaModel {
            [NameInMap("FillMode")]
            [Validation(Required=false)]
            public string FillMode { get; set; }

            [NameInMap("HeightNormalized")]
            [Validation(Required=false)]
            public float? HeightNormalized { get; set; }

            [NameInMap("WidthNormalized")]
            [Validation(Required=false)]
            public float? WidthNormalized { get; set; }

            [NameInMap("PositionRefer")]
            [Validation(Required=false)]
            public string PositionRefer { get; set; }

            [NameInMap("PositionNormalized")]
            [Validation(Required=false)]
            public List<float?> PositionNormalized { get; set; }

            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

        }

        [NameInMap("AudioLayer")]
        [Validation(Required=true)]
        public List<ModifyCasterLayoutRequestAudioLayer> AudioLayer { get; set; }
        public class ModifyCasterLayoutRequestAudioLayer : TeaModel {
            [NameInMap("VolumeRate")]
            [Validation(Required=false)]
            public float? VolumeRate { get; set; }

            [NameInMap("ValidChannel")]
            [Validation(Required=false)]
            public string ValidChannel { get; set; }

            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

        }

        [NameInMap("BlendList")]
        [Validation(Required=true)]
        public List<string> BlendList { get; set; }

        [NameInMap("MixList")]
        [Validation(Required=true)]
        public List<string> MixList { get; set; }

    }

}
