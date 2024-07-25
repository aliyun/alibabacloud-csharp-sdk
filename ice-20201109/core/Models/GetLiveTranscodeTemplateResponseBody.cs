// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveTranscodeTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public GetLiveTranscodeTemplateResponseBodyTemplateContent TemplateContent { get; set; }
        public class GetLiveTranscodeTemplateResponseBodyTemplateContent : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfig TemplateConfig { get; set; }
            public class GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfig : TeaModel {
                [NameInMap("AudioParams")]
                [Validation(Required=false)]
                public GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfigAudioParams AudioParams { get; set; }
                public class GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfigAudioParams : TeaModel {
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
                public GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfigVideoParams VideoParams { get; set; }
                public class GetLiveTranscodeTemplateResponseBodyTemplateContentTemplateConfigVideoParams : TeaModel {
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

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
