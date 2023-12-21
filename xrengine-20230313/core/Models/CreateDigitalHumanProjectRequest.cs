// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class CreateDigitalHumanProjectRequest : TeaModel {
        [NameInMap("AudioId")]
        [Validation(Required=false)]
        public string AudioId { get; set; }

        [NameInMap("AudioUrl")]
        [Validation(Required=false)]
        public string AudioUrl { get; set; }

        [NameInMap("BackgroundId")]
        [Validation(Required=false)]
        public string BackgroundId { get; set; }

        [NameInMap("BackgroundUrl")]
        [Validation(Required=false)]
        public string BackgroundUrl { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ForegroundId")]
        [Validation(Required=false)]
        public string ForegroundId { get; set; }

        [NameInMap("ForegroundUrl")]
        [Validation(Required=false)]
        public string ForegroundUrl { get; set; }

        [NameInMap("HumanLayerStyle")]
        [Validation(Required=false)]
        public string HumanLayerStyle { get; set; }

        [NameInMap("Intro")]
        [Validation(Required=false)]
        public string Intro { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("TtsVoiceId")]
        [Validation(Required=false)]
        public string TtsVoiceId { get; set; }

        [NameInMap("WatermarkImageUrl")]
        [Validation(Required=false)]
        public string WatermarkImageUrl { get; set; }

        [NameInMap("WatermarkStyle")]
        [Validation(Required=false)]
        public string WatermarkStyle { get; set; }

    }

}
