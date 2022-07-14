// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public UpdateTemplateResponseBodyTemplate Template { get; set; }
        public class UpdateTemplateResponseBodyTemplate : TeaModel {
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateAudio Audio { get; set; }
            public class UpdateTemplateResponseBodyTemplateAudio : TeaModel {
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

                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                [NameInMap("Samplerate")]
                [Validation(Required=false)]
                public string Samplerate { get; set; }

            }
            [NameInMap("Container")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateContainer Container { get; set; }
            public class UpdateTemplateResponseBodyTemplateContainer : TeaModel {
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

            }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("MuxConfig")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateMuxConfig MuxConfig { get; set; }
            public class UpdateTemplateResponseBodyTemplateMuxConfig : TeaModel {
                [NameInMap("Gif")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateMuxConfigGif Gif { get; set; }
                public class UpdateTemplateResponseBodyTemplateMuxConfigGif : TeaModel {
                    [NameInMap("DitherMode")]
                    [Validation(Required=false)]
                    public string DitherMode { get; set; }
                    [NameInMap("FinalDelay")]
                    [Validation(Required=false)]
                    public string FinalDelay { get; set; }
                    [NameInMap("IsCustomPalette")]
                    [Validation(Required=false)]
                    public string IsCustomPalette { get; set; }
                    [NameInMap("Loop")]
                    [Validation(Required=false)]
                    public string Loop { get; set; }
                };

                [NameInMap("Segment")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateMuxConfigSegment Segment { get; set; }
                public class UpdateTemplateResponseBodyTemplateMuxConfigSegment : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }
                };

                [NameInMap("Webp")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateMuxConfigWebp Webp { get; set; }
                public class UpdateTemplateResponseBodyTemplateMuxConfigWebp : TeaModel {
                    [NameInMap("Loop")]
                    [Validation(Required=false)]
                    public string Loop { get; set; }
                };

            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("TransConfig")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateTransConfig TransConfig { get; set; }
            public class UpdateTemplateResponseBodyTemplateTransConfig : TeaModel {
                [NameInMap("AdjDarMethod")]
                [Validation(Required=false)]
                public string AdjDarMethod { get; set; }

                [NameInMap("IsCheckAudioBitrate")]
                [Validation(Required=false)]
                public string IsCheckAudioBitrate { get; set; }

                [NameInMap("IsCheckAudioBitrateFail")]
                [Validation(Required=false)]
                public string IsCheckAudioBitrateFail { get; set; }

                [NameInMap("IsCheckReso")]
                [Validation(Required=false)]
                public string IsCheckReso { get; set; }

                [NameInMap("IsCheckResoFail")]
                [Validation(Required=false)]
                public string IsCheckResoFail { get; set; }

                [NameInMap("IsCheckVideoBitrate")]
                [Validation(Required=false)]
                public string IsCheckVideoBitrate { get; set; }

                [NameInMap("IsCheckVideoBitrateFail")]
                [Validation(Required=false)]
                public string IsCheckVideoBitrateFail { get; set; }

                [NameInMap("TransMode")]
                [Validation(Required=false)]
                public string TransMode { get; set; }

            }
            [NameInMap("Video")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateVideo Video { get; set; }
            public class UpdateTemplateResponseBodyTemplateVideo : TeaModel {
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("BitrateBnd")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateVideoBitrateBnd BitrateBnd { get; set; }
                public class UpdateTemplateResponseBodyTemplateVideoBitrateBnd : TeaModel {
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public string Max { get; set; }
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public string Min { get; set; }
                };

                [NameInMap("Bufsize")]
                [Validation(Required=false)]
                public string Bufsize { get; set; }

                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                [NameInMap("Crf")]
                [Validation(Required=false)]
                public string Crf { get; set; }

                [NameInMap("Crop")]
                [Validation(Required=false)]
                public string Crop { get; set; }

                [NameInMap("Degrain")]
                [Validation(Required=false)]
                public string Degrain { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("LongShortMode")]
                [Validation(Required=false)]
                public string LongShortMode { get; set; }

                [NameInMap("MaxFps")]
                [Validation(Required=false)]
                public string MaxFps { get; set; }

                [NameInMap("Maxrate")]
                [Validation(Required=false)]
                public string Maxrate { get; set; }

                [NameInMap("Pad")]
                [Validation(Required=false)]
                public string Pad { get; set; }

                [NameInMap("PixFmt")]
                [Validation(Required=false)]
                public string PixFmt { get; set; }

                [NameInMap("Preset")]
                [Validation(Required=false)]
                public string Preset { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                [NameInMap("ResoPriority")]
                [Validation(Required=false)]
                public string ResoPriority { get; set; }

                [NameInMap("ScanMode")]
                [Validation(Required=false)]
                public string ScanMode { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }
        };

    }

}
