// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class CreateLivePortraitProjectRequest : TeaModel {
        [NameInMap("AudioId")]
        [Validation(Required=false)]
        public string AudioId { get; set; }

        [NameInMap("AudioUrl")]
        [Validation(Required=false)]
        public string AudioUrl { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("Intro")]
        [Validation(Required=false)]
        public string Intro { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("LightModel")]
        [Validation(Required=false)]
        public bool? LightModel { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

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
