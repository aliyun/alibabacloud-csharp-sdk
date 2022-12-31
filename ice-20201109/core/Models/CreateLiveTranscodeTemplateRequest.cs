// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLiveTranscodeTemplateRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public CreateLiveTranscodeTemplateRequestTemplateConfig TemplateConfig { get; set; }
        public class CreateLiveTranscodeTemplateRequestTemplateConfig : TeaModel {
            [NameInMap("AudioParams")]
            [Validation(Required=false)]
            public CreateLiveTranscodeTemplateRequestTemplateConfigAudioParams AudioParams { get; set; }
            public class CreateLiveTranscodeTemplateRequestTemplateConfigAudioParams : TeaModel {
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("Samplerate")]
                [Validation(Required=false)]
                public string Samplerate { get; set; }

            }

            [NameInMap("VideoParams")]
            [Validation(Required=false)]
            public CreateLiveTranscodeTemplateRequestTemplateConfigVideoParams VideoParams { get; set; }
            public class CreateLiveTranscodeTemplateRequestTemplateConfigVideoParams : TeaModel {
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
