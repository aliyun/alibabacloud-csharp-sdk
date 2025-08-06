// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTemplateGroupConsoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateGroup")]
        [Validation(Required=false)]
        public GetTemplateGroupConsoleResponseBodyTemplateGroup TemplateGroup { get; set; }
        public class GetTemplateGroupConsoleResponseBodyTemplateGroup : TeaModel {
            [NameInMap("DefaultGroup")]
            [Validation(Required=false)]
            public string DefaultGroup { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("GroupSymbol")]
            [Validation(Required=false)]
            public string GroupSymbol { get; set; }

            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("IsLocked")]
            [Validation(Required=false)]
            public string IsLocked { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Templates")]
            [Validation(Required=false)]
            public GetTemplateGroupConsoleResponseBodyTemplateGroupTemplates Templates { get; set; }
            public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplates : TeaModel {
                [NameInMap("Template")]
                [Validation(Required=false)]
                public List<GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplate> Template { get; set; }
                public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplate : TeaModel {
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateAudio Audio { get; set; }
                    public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateAudio : TeaModel {
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

                        [NameInMap("Remove")]
                        [Validation(Required=false)]
                        public string Remove { get; set; }

                        [NameInMap("Samplerate")]
                        [Validation(Required=false)]
                        public string Samplerate { get; set; }

                    }

                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateContainer Container { get; set; }
                    public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateContainer : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    [NameInMap("Definition")]
                    [Validation(Required=false)]
                    public string Definition { get; set; }

                    [NameInMap("Encrypt")]
                    [Validation(Required=false)]
                    public string Encrypt { get; set; }

                    [NameInMap("EncryptionConfig")]
                    [Validation(Required=false)]
                    public GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateEncryptionConfig EncryptionConfig { get; set; }
                    public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateEncryptionConfig : TeaModel {
                        [NameInMap("DecryptKeyUri")]
                        [Validation(Required=false)]
                        public string DecryptKeyUri { get; set; }

                        [NameInMap("EncryptType")]
                        [Validation(Required=false)]
                        public string EncryptType { get; set; }

                        [NameInMap("KeyEncryptMethod")]
                        [Validation(Required=false)]
                        public string KeyEncryptMethod { get; set; }

                    }

                    [NameInMap("IsLocked")]
                    [Validation(Required=false)]
                    public string IsLocked { get; set; }

                    [NameInMap("MediaDefinition")]
                    [Validation(Required=false)]
                    public string MediaDefinition { get; set; }

                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateMuxConfig MuxConfig { get; set; }
                    public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateMuxConfig : TeaModel {
                        [NameInMap("Segment")]
                        [Validation(Required=false)]
                        public GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateMuxConfigSegment Segment { get; set; }
                        public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateMuxConfigSegment : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }

                    }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("NarrowBand")]
                    [Validation(Required=false)]
                    public string NarrowBand { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateTransConfig TransConfig { get; set; }
                    public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateTransConfig : TeaModel {
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

                    [NameInMap("UseWaterMark")]
                    [Validation(Required=false)]
                    public string UseWaterMark { get; set; }

                    [NameInMap("UserWaterMark")]
                    [Validation(Required=false)]
                    public string UserWaterMark { get; set; }

                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateVideo Video { get; set; }
                    public class GetTemplateGroupConsoleResponseBodyTemplateGroupTemplatesTemplateVideo : TeaModel {
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

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

                        [NameInMap("Remove")]
                        [Validation(Required=false)]
                        public string Remove { get; set; }

                        [NameInMap("ScanMode")]
                        [Validation(Required=false)]
                        public string ScanMode { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }

            }

            [NameInMap("TranscodeMode")]
            [Validation(Required=false)]
            public string TranscodeMode { get; set; }

        }

    }

}
