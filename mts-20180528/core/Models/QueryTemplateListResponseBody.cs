// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class QueryTemplateListResponseBody : TeaModel {
        [NameInMap("NonExistTids")]
        [Validation(Required=false)]
        public QueryTemplateListResponseBodyNonExistTids NonExistTids { get; set; }
        public class QueryTemplateListResponseBodyNonExistTids : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateList")]
        [Validation(Required=false)]
        public QueryTemplateListResponseBodyTemplateList TemplateList { get; set; }
        public class QueryTemplateListResponseBodyTemplateList : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<QueryTemplateListResponseBodyTemplateListTemplate> Template { get; set; }
            public class QueryTemplateListResponseBodyTemplateListTemplate : TeaModel {
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public QueryTemplateListResponseBodyTemplateListTemplateAudio Audio { get; set; }
                public class QueryTemplateListResponseBodyTemplateListTemplateAudio : TeaModel {
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
                public QueryTemplateListResponseBodyTemplateListTemplateContainer Container { get; set; }
                public class QueryTemplateListResponseBodyTemplateListTemplateContainer : TeaModel {
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public QueryTemplateListResponseBodyTemplateListTemplateMuxConfig MuxConfig { get; set; }
                public class QueryTemplateListResponseBodyTemplateListTemplateMuxConfig : TeaModel {
                    [NameInMap("Gif")]
                    [Validation(Required=false)]
                    public QueryTemplateListResponseBodyTemplateListTemplateMuxConfigGif Gif { get; set; }
                    public class QueryTemplateListResponseBodyTemplateListTemplateMuxConfigGif : TeaModel {
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

                    }

                    [NameInMap("Segment")]
                    [Validation(Required=false)]
                    public QueryTemplateListResponseBodyTemplateListTemplateMuxConfigSegment Segment { get; set; }
                    public class QueryTemplateListResponseBodyTemplateListTemplateMuxConfigSegment : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                    }

                    [NameInMap("Webp")]
                    [Validation(Required=false)]
                    public QueryTemplateListResponseBodyTemplateListTemplateMuxConfigWebp Webp { get; set; }
                    public class QueryTemplateListResponseBodyTemplateListTemplateMuxConfigWebp : TeaModel {
                        [NameInMap("Loop")]
                        [Validation(Required=false)]
                        public string Loop { get; set; }

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public QueryTemplateListResponseBodyTemplateListTemplateTransConfig TransConfig { get; set; }
                public class QueryTemplateListResponseBodyTemplateListTemplateTransConfig : TeaModel {
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
                public QueryTemplateListResponseBodyTemplateListTemplateVideo Video { get; set; }
                public class QueryTemplateListResponseBodyTemplateListTemplateVideo : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("BitrateBnd")]
                    [Validation(Required=false)]
                    public QueryTemplateListResponseBodyTemplateListTemplateVideoBitrateBnd BitrateBnd { get; set; }
                    public class QueryTemplateListResponseBodyTemplateListTemplateVideoBitrateBnd : TeaModel {
                        [NameInMap("Max")]
                        [Validation(Required=false)]
                        public string Max { get; set; }

                        [NameInMap("Min")]
                        [Validation(Required=false)]
                        public string Min { get; set; }

                    }

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

            }

        }

    }

}
