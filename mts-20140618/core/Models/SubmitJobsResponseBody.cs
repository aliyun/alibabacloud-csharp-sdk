// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitJobsResponseBody : TeaModel {
        [NameInMap("JobResultList")]
        [Validation(Required=false)]
        public SubmitJobsResponseBodyJobResultList JobResultList { get; set; }
        public class SubmitJobsResponseBodyJobResultList : TeaModel {
            [NameInMap("JobResult")]
            [Validation(Required=false)]
            public List<SubmitJobsResponseBodyJobResultListJobResult> JobResult { get; set; }
            public class SubmitJobsResponseBodyJobResultListJobResult : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Percent")]
                [Validation(Required=false)]
                public long? Percent { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Output")]
                [Validation(Required=false)]
                public SubmitJobsResponseBodyJobResultListJobResultOutput Output { get; set; }
                public class SubmitJobsResponseBodyJobResultListJobResultOutput : TeaModel {
                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputVideo Video { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputVideo : TeaModel {
                        [NameInMap("Bufsize")]
                        [Validation(Required=false)]
                        public string Bufsize { get; set; }

                        [NameInMap("Degrain")]
                        [Validation(Required=false)]
                        public string Degrain { get; set; }

                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputVideoBitrateBnd BitrateBnd { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputVideoBitrateBnd : TeaModel {
                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }
                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }
                        };

                        [NameInMap("PixFmt")]
                        [Validation(Required=false)]
                        public string PixFmt { get; set; }

                        [NameInMap("Pad")]
                        [Validation(Required=false)]
                        public string Pad { get; set; }

                        [NameInMap("Codec")]
                        [Validation(Required=false)]
                        public string Codec { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        [NameInMap("Qscale")]
                        [Validation(Required=false)]
                        public string Qscale { get; set; }

                        [NameInMap("Crop")]
                        [Validation(Required=false)]
                        public string Crop { get; set; }

                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        [NameInMap("Maxrate")]
                        [Validation(Required=false)]
                        public string Maxrate { get; set; }

                        [NameInMap("MaxFps")]
                        [Validation(Required=false)]
                        public string MaxFps { get; set; }

                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        [NameInMap("Crf")]
                        [Validation(Required=false)]
                        public string Crf { get; set; }

                        [NameInMap("Gop")]
                        [Validation(Required=false)]
                        public string Gop { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        [NameInMap("Preset")]
                        [Validation(Required=false)]
                        public string Preset { get; set; }

                        [NameInMap("ScanMode")]
                        [Validation(Required=false)]
                        public string ScanMode { get; set; }

                        [NameInMap("ResoPriority")]
                        [Validation(Required=false)]
                        public string ResoPriority { get; set; }

                    }
                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputTransConfig TransConfig { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputTransConfig : TeaModel {
                        [NameInMap("IsCheckAudioBitrate")]
                        [Validation(Required=false)]
                        public string IsCheckAudioBitrate { get; set; }

                        [NameInMap("TransMode")]
                        [Validation(Required=false)]
                        public string TransMode { get; set; }

                        [NameInMap("IsCheckReso")]
                        [Validation(Required=false)]
                        public string IsCheckReso { get; set; }

                        [NameInMap("IsCheckVideoBitrateFail")]
                        [Validation(Required=false)]
                        public string IsCheckVideoBitrateFail { get; set; }

                        [NameInMap("AdjDarMethod")]
                        [Validation(Required=false)]
                        public string AdjDarMethod { get; set; }

                        [NameInMap("IsCheckVideoBitrate")]
                        [Validation(Required=false)]
                        public string IsCheckVideoBitrate { get; set; }

                        [NameInMap("IsCheckResoFail")]
                        [Validation(Required=false)]
                        public string IsCheckResoFail { get; set; }

                        [NameInMap("IsCheckAudioBitrateFail")]
                        [Validation(Required=false)]
                        public string IsCheckAudioBitrateFail { get; set; }

                    }
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputEncryption Encryption { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputEncryption : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("KeyType")]
                        [Validation(Required=false)]
                        public string KeyType { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("KeyUri")]
                        [Validation(Required=false)]
                        public string KeyUri { get; set; }

                        [NameInMap("SkipCnt")]
                        [Validation(Required=false)]
                        public string SkipCnt { get; set; }

                    }
                    [NameInMap("WaterMarkList")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputWaterMarkList WaterMarkList { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputWaterMarkList : TeaModel {
                        [NameInMap("WaterMark")]
                        [Validation(Required=false)]
                        public List<SubmitJobsResponseBodyJobResultListJobResultOutputWaterMarkListWaterMark> WaterMark { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputWaterMarkListWaterMark : TeaModel {
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultOutputWaterMarkListWaterMarkInputFile : TeaModel {
                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }
                                [NameInMap("Location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }
                            };

                            [NameInMap("WaterMarkTemplateId")]
                            [Validation(Required=false)]
                            public string WaterMarkTemplateId { get; set; }

                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }

                        }

                    }
                    [NameInMap("WaterMarkConfigUrl")]
                    [Validation(Required=false)]
                    public string WaterMarkConfigUrl { get; set; }
                    [NameInMap("DeWatermark")]
                    [Validation(Required=false)]
                    public string DeWatermark { get; set; }
                    [NameInMap("M3U8NonStandardSupport")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputM3U8NonStandardSupport : TeaModel {
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputM3U8NonStandardSupportTS TS { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputM3U8NonStandardSupportTS : TeaModel {
                            [NameInMap("SizeSupport")]
                            [Validation(Required=false)]
                            public bool? SizeSupport { get; set; }
                            [NameInMap("Md5Support")]
                            [Validation(Required=false)]
                            public bool? Md5Support { get; set; }
                        };

                    }
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputAudio Audio { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputAudio : TeaModel {
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        [NameInMap("Codec")]
                        [Validation(Required=false)]
                        public string Codec { get; set; }

                        [NameInMap("Samplerate")]
                        [Validation(Required=false)]
                        public string Samplerate { get; set; }

                        [NameInMap("Qscale")]
                        [Validation(Required=false)]
                        public string Qscale { get; set; }

                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public string Channels { get; set; }

                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputAudioVolume Volume { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputAudioVolume : TeaModel {
                            [NameInMap("Method")]
                            [Validation(Required=false)]
                            public string Method { get; set; }
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }
                        };

                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                    }
                    [NameInMap("AudioStreamMap")]
                    [Validation(Required=false)]
                    public string AudioStreamMap { get; set; }
                    [NameInMap("MergeList")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputMergeList MergeList { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputMergeList : TeaModel {
                        [NameInMap("Merge")]
                        [Validation(Required=false)]
                        public List<SubmitJobsResponseBodyJobResultListJobResultOutputMergeListMerge> Merge { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputMergeListMerge : TeaModel {
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            [NameInMap("RoleArn")]
                            [Validation(Required=false)]
                            public string RoleArn { get; set; }

                            [NameInMap("MergeURL")]
                            [Validation(Required=false)]
                            public string MergeURL { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }

                    }
                    [NameInMap("SuperReso")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputSuperReso SuperReso { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputSuperReso : TeaModel {
                        [NameInMap("IsHalfSample")]
                        [Validation(Required=false)]
                        public string IsHalfSample { get; set; }

                    }
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }
                    [NameInMap("OutSubtitleList")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputOutSubtitleList OutSubtitleList { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputOutSubtitleList : TeaModel {
                        [NameInMap("OutSubtitle")]
                        [Validation(Required=false)]
                        public List<SubmitJobsResponseBodyJobResultListJobResultOutputOutSubtitleListOutSubtitle> OutSubtitle { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputOutSubtitleListOutSubtitle : TeaModel {
                            [NameInMap("Map")]
                            [Validation(Required=false)]
                            public string Map { get; set; }

                            [NameInMap("OutSubtitleFile")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
                                [NameInMap("RoleArn")]
                                [Validation(Required=false)]
                                public string RoleArn { get; set; }
                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }
                                [NameInMap("Location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }
                            };

                            [NameInMap("Success")]
                            [Validation(Required=false)]
                            public bool? Success { get; set; }

                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                        }

                    }
                    [NameInMap("DigiWaterMark")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputDigiWaterMark DigiWaterMark { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputDigiWaterMark : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Alpha")]
                        [Validation(Required=false)]
                        public string Alpha { get; set; }

                        [NameInMap("InputFile")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputDigiWaterMarkInputFile InputFile { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputDigiWaterMarkInputFile : TeaModel {
                            [NameInMap("Object")]
                            [Validation(Required=false)]
                            public string Object { get; set; }
                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }
                            [NameInMap("Bucket")]
                            [Validation(Required=false)]
                            public string Bucket { get; set; }
                        };

                    }
                    [NameInMap("VideoStreamMap")]
                    [Validation(Required=false)]
                    public string VideoStreamMap { get; set; }
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputOutputFile OutputFile { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputOutputFile : TeaModel {
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                    }
                    [NameInMap("AmixList")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputAmixList AmixList { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputAmixList : TeaModel {
                        [NameInMap("Amix")]
                        [Validation(Required=false)]
                        public List<SubmitJobsResponseBodyJobResultListJobResultOutputAmixListAmix> Amix { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputAmixListAmix : TeaModel {
                            [NameInMap("Map")]
                            [Validation(Required=false)]
                            public string Map { get; set; }

                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            [NameInMap("AmixURL")]
                            [Validation(Required=false)]
                            public string AmixURL { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("MixDurMode")]
                            [Validation(Required=false)]
                            public string MixDurMode { get; set; }

                        }

                    }
                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }
                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputContainer Container { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputContainer : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }
                    [NameInMap("Clip")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputClip Clip { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputClip : TeaModel {
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputClipTimeSpan TimeSpan { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputClipTimeSpan : TeaModel {
                            [NameInMap("Seek")]
                            [Validation(Required=false)]
                            public string Seek { get; set; }
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }
                        };

                    }
                    [NameInMap("MergeConfigUrl")]
                    [Validation(Required=false)]
                    public string MergeConfigUrl { get; set; }
                    [NameInMap("OpeningList")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputOpeningList OpeningList { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputOpeningList : TeaModel {
                        [NameInMap("Opening")]
                        [Validation(Required=false)]
                        public List<SubmitJobsResponseBodyJobResultListJobResultOutputOpeningListOpening> Opening { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputOpeningListOpening : TeaModel {
                            [NameInMap("openUrl")]
                            [Validation(Required=false)]
                            public string OpenUrl { get; set; }

                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                        }

                    }
                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputMuxConfig MuxConfig { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputMuxConfig : TeaModel {
                        [NameInMap("Webp")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputMuxConfigWebp Webp { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputMuxConfigWebp : TeaModel {
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }
                        };

                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputMuxConfigGif Gif { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputMuxConfigGif : TeaModel {
                            [NameInMap("FinalDelay")]
                            [Validation(Required=false)]
                            public string FinalDelay { get; set; }
                            [NameInMap("DitherMode")]
                            [Validation(Required=false)]
                            public string DitherMode { get; set; }
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }
                            [NameInMap("IsCustomPalette")]
                            [Validation(Required=false)]
                            public string IsCustomPalette { get; set; }
                        };

                        [NameInMap("Segment")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputMuxConfigSegment Segment { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputMuxConfigSegment : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }
                        };

                    }
                    [NameInMap("TailSlateList")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputTailSlateList TailSlateList { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputTailSlateList : TeaModel {
                        [NameInMap("TailSlate")]
                        [Validation(Required=false)]
                        public List<SubmitJobsResponseBodyJobResultListJobResultOutputTailSlateListTailSlate> TailSlate { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputTailSlateListTailSlate : TeaModel {
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            [NameInMap("BgColor")]
                            [Validation(Required=false)]
                            public string BgColor { get; set; }

                            [NameInMap("IsMergeAudio")]
                            [Validation(Required=false)]
                            public bool? IsMergeAudio { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("BlendDuration")]
                            [Validation(Required=false)]
                            public string BlendDuration { get; set; }

                            [NameInMap("TailUrl")]
                            [Validation(Required=false)]
                            public string TailUrl { get; set; }

                        }

                    }
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }
                    [NameInMap("SubtitleConfig")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfig SubtitleConfig { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfig : TeaModel {
                        [NameInMap("ExtSubtitleList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigExtSubtitleList : TeaModel {
                            [NameInMap("ExtSubtitle")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                public string CharEnc { get; set; }
                                public string FontName { get; set; }
                                public SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
                                    [NameInMap("Object")]
                                    [Validation(Required=false)]
                                    public string Object { get; set; }

                                    [NameInMap("Location")]
                                    [Validation(Required=false)]
                                    public string Location { get; set; }

                                    [NameInMap("Bucket")]
                                    [Validation(Required=false)]
                                    public string Bucket { get; set; }

                                }
                            }
                        };

                        [NameInMap("SubtitleList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigSubtitleList : TeaModel {
                            [NameInMap("Subtitle")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
                                public string Map { get; set; }
                            }
                        };

                    }
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultOutputProperties Properties { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultOutputProperties : TeaModel {
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        [NameInMap("FileFormat")]
                        [Validation(Required=false)]
                        public string FileFormat { get; set; }

                        [NameInMap("Streams")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreams Streams { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreams : TeaModel {
                            [NameInMap("VideoStreamList")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    [NameInMap("Timebase")]
                                    [Validation(Required=false)]
                                    public string Timebase { get; set; }

                                    [NameInMap("AvgFPS")]
                                    [Validation(Required=false)]
                                    public string AvgFPS { get; set; }

                                    [NameInMap("PixFmt")]
                                    [Validation(Required=false)]
                                    public string PixFmt { get; set; }

                                    [NameInMap("Sar")]
                                    [Validation(Required=false)]
                                    public string Sar { get; set; }

                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                    [NameInMap("CodecLongName")]
                                    [Validation(Required=false)]
                                    public string CodecLongName { get; set; }

                                    [NameInMap("Height")]
                                    [Validation(Required=false)]
                                    public string Height { get; set; }

                                    [NameInMap("NumFrames")]
                                    [Validation(Required=false)]
                                    public string NumFrames { get; set; }

                                    [NameInMap("Bitrate")]
                                    [Validation(Required=false)]
                                    public string Bitrate { get; set; }

                                    [NameInMap("CodecTagString")]
                                    [Validation(Required=false)]
                                    public string CodecTagString { get; set; }

                                    [NameInMap("HasBFrames")]
                                    [Validation(Required=false)]
                                    public string HasBFrames { get; set; }

                                    [NameInMap("Profile")]
                                    [Validation(Required=false)]
                                    public string Profile { get; set; }

                                    [NameInMap("StartTime")]
                                    [Validation(Required=false)]
                                    public string StartTime { get; set; }

                                    [NameInMap("NetworkCost")]
                                    [Validation(Required=false)]
                                    public SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                        [NameInMap("PreloadTime")]
                                        [Validation(Required=false)]
                                        public string PreloadTime { get; set; }
                                        [NameInMap("AvgBitrate")]
                                        [Validation(Required=false)]
                                        public string AvgBitrate { get; set; }
                                        [NameInMap("CostBandwidth")]
                                        [Validation(Required=false)]
                                        public string CostBandwidth { get; set; }
                                    };

                                    [NameInMap("Dar")]
                                    [Validation(Required=false)]
                                    public string Dar { get; set; }

                                    [NameInMap("CodecName")]
                                    [Validation(Required=false)]
                                    public string CodecName { get; set; }

                                    [NameInMap("Width")]
                                    [Validation(Required=false)]
                                    public string Width { get; set; }

                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    [NameInMap("Fps")]
                                    [Validation(Required=false)]
                                    public string Fps { get; set; }

                                    [NameInMap("CodecTag")]
                                    [Validation(Required=false)]
                                    public string CodecTag { get; set; }

                                    [NameInMap("CodecTimeBase")]
                                    [Validation(Required=false)]
                                    public string CodecTimeBase { get; set; }

                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }

                                }

                            }
                            [NameInMap("AudioStreamList")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsAudioStreamList : TeaModel {
                                [NameInMap("AudioStream")]
                                [Validation(Required=false)]
                                public List<SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                                    [NameInMap("Timebase")]
                                    [Validation(Required=false)]
                                    public string Timebase { get; set; }

                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    [NameInMap("SampleFmt")]
                                    [Validation(Required=false)]
                                    public string SampleFmt { get; set; }

                                    [NameInMap("ChannelLayout")]
                                    [Validation(Required=false)]
                                    public string ChannelLayout { get; set; }

                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                    [NameInMap("Samplerate")]
                                    [Validation(Required=false)]
                                    public string Samplerate { get; set; }

                                    [NameInMap("CodecLongName")]
                                    [Validation(Required=false)]
                                    public string CodecLongName { get; set; }

                                    [NameInMap("Channels")]
                                    [Validation(Required=false)]
                                    public string Channels { get; set; }

                                    [NameInMap("NumFrames")]
                                    [Validation(Required=false)]
                                    public string NumFrames { get; set; }

                                    [NameInMap("Bitrate")]
                                    [Validation(Required=false)]
                                    public string Bitrate { get; set; }

                                    [NameInMap("CodecTagString")]
                                    [Validation(Required=false)]
                                    public string CodecTagString { get; set; }

                                    [NameInMap("StartTime")]
                                    [Validation(Required=false)]
                                    public string StartTime { get; set; }

                                    [NameInMap("CodecName")]
                                    [Validation(Required=false)]
                                    public string CodecName { get; set; }

                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    [NameInMap("CodecTag")]
                                    [Validation(Required=false)]
                                    public string CodecTag { get; set; }

                                    [NameInMap("CodecTimeBase")]
                                    [Validation(Required=false)]
                                    public string CodecTimeBase { get; set; }

                                }

                            }
                            [NameInMap("SubtitleStreamList")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                [NameInMap("SubtitleStream")]
                                [Validation(Required=false)]
                                public List<SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                }

                            }
                        };

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesFormat Format { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultOutputPropertiesFormat : TeaModel {
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }
                            [NameInMap("NumPrograms")]
                            [Validation(Required=false)]
                            public string NumPrograms { get; set; }
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public string Size { get; set; }
                            [NameInMap("NumStreams")]
                            [Validation(Required=false)]
                            public string NumStreams { get; set; }
                            [NameInMap("FormatLongName")]
                            [Validation(Required=false)]
                            public string FormatLongName { get; set; }
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }
                            [NameInMap("FormatName")]
                            [Validation(Required=false)]
                            public string FormatName { get; set; }
                        };

                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                    }
                };

                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                [NameInMap("Input")]
                [Validation(Required=false)]
                public SubmitJobsResponseBodyJobResultListJobResultInput Input { get; set; }
                public class SubmitJobsResponseBodyJobResultListJobResultInput : TeaModel {
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }
                };

                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public SubmitJobsResponseBodyJobResultListJobResultMNSMessageResult MNSMessageResult { get; set; }
                public class SubmitJobsResponseBodyJobResultListJobResultMNSMessageResult : TeaModel {
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }
                };

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
