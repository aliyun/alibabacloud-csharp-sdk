// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitComplexJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ComplexJob")]
        [Validation(Required=false)]
        public SubmitComplexJobResponseBodyComplexJob ComplexJob { get; set; }
        public class SubmitComplexJobResponseBodyComplexJob : TeaModel {
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
            [NameInMap("transcodeOutput")]
            [Validation(Required=false)]
            public SubmitComplexJobResponseBodyComplexJobTranscodeOutput TranscodeOutput { get; set; }
            public class SubmitComplexJobResponseBodyComplexJobTranscodeOutput : TeaModel {
                [NameInMap("Video")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputVideo Video { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputVideo : TeaModel {
                    [NameInMap("Bufsize")]
                    [Validation(Required=false)]
                    public string Bufsize { get; set; }
                    [NameInMap("Degrain")]
                    [Validation(Required=false)]
                    public string Degrain { get; set; }
                    [NameInMap("BitrateBnd")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputVideoBitrateBnd BitrateBnd { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputVideoBitrateBnd : TeaModel {
                        [NameInMap("Max")]
                        [Validation(Required=false)]
                        public string Max { get; set; }

                        [NameInMap("Min")]
                        [Validation(Required=false)]
                        public string Min { get; set; }

                    }
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
                };

                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputTransConfig TransConfig { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputTransConfig : TeaModel {
                    [NameInMap("IsCheckAudioBitrate")]
                    [Validation(Required=false)]
                    public string IsCheckAudioBitrate { get; set; }
                    [NameInMap("IsCheckReso")]
                    [Validation(Required=false)]
                    public string IsCheckReso { get; set; }
                    [NameInMap("TransMode")]
                    [Validation(Required=false)]
                    public string TransMode { get; set; }
                    [NameInMap("IsCheckVideoBitrateFail")]
                    [Validation(Required=false)]
                    public string IsCheckVideoBitrateFail { get; set; }
                    [NameInMap("AdjDarMethod")]
                    [Validation(Required=false)]
                    public string AdjDarMethod { get; set; }
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }
                    [NameInMap("IsCheckVideoBitrate")]
                    [Validation(Required=false)]
                    public string IsCheckVideoBitrate { get; set; }
                    [NameInMap("IsCheckResoFail")]
                    [Validation(Required=false)]
                    public string IsCheckResoFail { get; set; }
                    [NameInMap("IsCheckAudioBitrateFail")]
                    [Validation(Required=false)]
                    public string IsCheckAudioBitrateFail { get; set; }
                };

                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputEncryption Encryption { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputEncryption : TeaModel {
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
                };

                [NameInMap("WaterMarkList")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputWaterMarkList WaterMarkList { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputWaterMarkList : TeaModel {
                    [NameInMap("WaterMark")]
                    [Validation(Required=false)]
                    public List<SubmitComplexJobResponseBodyComplexJobTranscodeOutputWaterMarkListWaterMark> WaterMark { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputWaterMarkListWaterMark : TeaModel {
                        public string Type { get; set; }
                        public string ReferPos { get; set; }
                        public string Dx { get; set; }
                        public string Width { get; set; }
                        public string Height { get; set; }
                        public SubmitComplexJobResponseBodyComplexJobTranscodeOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputWaterMarkListWaterMarkInputFile : TeaModel {
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
                        public string WaterMarkTemplateId { get; set; }
                        public string Dy { get; set; }
                    }
                };

                [NameInMap("DeWatermark")]
                [Validation(Required=false)]
                public string DeWatermark { get; set; }

                [NameInMap("WaterMarkConfigUrl")]
                [Validation(Required=false)]
                public string WaterMarkConfigUrl { get; set; }

                [NameInMap("M3U8NonStandardSupport")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputM3U8NonStandardSupport : TeaModel {
                    [NameInMap("TS")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputM3U8NonStandardSupportTS TS { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputM3U8NonStandardSupportTS : TeaModel {
                        [NameInMap("SizeSupport")]
                        [Validation(Required=false)]
                        public bool? SizeSupport { get; set; }

                        [NameInMap("Md5Support")]
                        [Validation(Required=false)]
                        public bool? Md5Support { get; set; }

                    }
                };

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                [NameInMap("Audio")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputAudio Audio { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputAudio : TeaModel {
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
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputAudioVolume Volume { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputAudioVolume : TeaModel {
                        [NameInMap("Method")]
                        [Validation(Required=false)]
                        public string Method { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                    }
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }
                };

                [NameInMap("AudioStreamMap")]
                [Validation(Required=false)]
                public string AudioStreamMap { get; set; }

                [NameInMap("MergeList")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputMergeList MergeList { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputMergeList : TeaModel {
                    [NameInMap("Merge")]
                    [Validation(Required=false)]
                    public List<SubmitComplexJobResponseBodyComplexJobTranscodeOutputMergeListMerge> Merge { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputMergeListMerge : TeaModel {
                        public string Start { get; set; }
                        public string RoleArn { get; set; }
                        public string MergeURL { get; set; }
                        public string Duration { get; set; }
                    }
                };

                [NameInMap("SuperReso")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputSuperReso SuperReso { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputSuperReso : TeaModel {
                    [NameInMap("IsHalfSample")]
                    [Validation(Required=false)]
                    public string IsHalfSample { get; set; }
                };

                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

                [NameInMap("DigiWaterMark")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputDigiWaterMark DigiWaterMark { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputDigiWaterMark : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("Alpha")]
                    [Validation(Required=false)]
                    public string Alpha { get; set; }
                    [NameInMap("InputFile")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputDigiWaterMarkInputFile InputFile { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputDigiWaterMarkInputFile : TeaModel {
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
                };

                [NameInMap("VideoStreamMap")]
                [Validation(Required=false)]
                public string VideoStreamMap { get; set; }

                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputOutputFile OutputFile { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputOutputFile : TeaModel {
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

                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                [NameInMap("Container")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputContainer Container { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputContainer : TeaModel {
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }
                };

                [NameInMap("Clip")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputClip Clip { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputClip : TeaModel {
                    [NameInMap("TimeSpan")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputClipTimeSpan TimeSpan { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputClipTimeSpan : TeaModel {
                        [NameInMap("Seek")]
                        [Validation(Required=false)]
                        public string Seek { get; set; }

                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                    }
                };

                [NameInMap("MergeConfigUrl")]
                [Validation(Required=false)]
                public string MergeConfigUrl { get; set; }

                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputMuxConfig MuxConfig { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputMuxConfig : TeaModel {
                    [NameInMap("Gif")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputMuxConfigGif Gif { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputMuxConfigGif : TeaModel {
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

                    }
                    [NameInMap("Segment")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputMuxConfigSegment Segment { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputMuxConfigSegment : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                    }
                };

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("SubtitleConfig")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfig SubtitleConfig { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfig : TeaModel {
                    [NameInMap("ExtSubtitleList")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigExtSubtitleList : TeaModel {
                        [NameInMap("ExtSubtitle")]
                        [Validation(Required=false)]
                        public List<SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                            [NameInMap("CharEnc")]
                            [Validation(Required=false)]
                            public string CharEnc { get; set; }

                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }

                            [NameInMap("Input")]
                            [Validation(Required=false)]
                            public SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
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

                    }
                    [NameInMap("SubtitleList")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigSubtitleList : TeaModel {
                        [NameInMap("Subtitle")]
                        [Validation(Required=false)]
                        public List<SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
                            [NameInMap("Map")]
                            [Validation(Required=false)]
                            public string Map { get; set; }

                        }

                    }
                };

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputProperties Properties { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputProperties : TeaModel {
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
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreams Streams { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreams : TeaModel {
                        [NameInMap("VideoStreamList")]
                        [Validation(Required=false)]
                        public SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsVideoStreamList : TeaModel {
                            [NameInMap("VideoStream")]
                            [Validation(Required=false)]
                            public List<SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                                public string Index { get; set; }
                                public string Timebase { get; set; }
                                public string AvgFPS { get; set; }
                                public string PixFmt { get; set; }
                                public string Sar { get; set; }
                                public string Lang { get; set; }
                                public string CodecLongName { get; set; }
                                public string Height { get; set; }
                                public string NumFrames { get; set; }
                                public string Bitrate { get; set; }
                                public string CodecTagString { get; set; }
                                public string HasBFrames { get; set; }
                                public string Profile { get; set; }
                                public string StartTime { get; set; }
                                public SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                    [NameInMap("PreloadTime")]
                                    [Validation(Required=false)]
                                    public string PreloadTime { get; set; }

                                    [NameInMap("AvgBitrate")]
                                    [Validation(Required=false)]
                                    public string AvgBitrate { get; set; }

                                    [NameInMap("CostBandwidth")]
                                    [Validation(Required=false)]
                                    public string CostBandwidth { get; set; }

                                }
                                public string Dar { get; set; }
                                public string CodecName { get; set; }
                                public string Width { get; set; }
                                public string Duration { get; set; }
                                public string Fps { get; set; }
                                public string CodecTag { get; set; }
                                public string CodecTimeBase { get; set; }
                                public string Level { get; set; }
                            }
                        };

                        [NameInMap("AudioStreamList")]
                        [Validation(Required=false)]
                        public SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsAudioStreamList : TeaModel {
                            [NameInMap("AudioStream")]
                            [Validation(Required=false)]
                            public List<SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                                public string Timebase { get; set; }
                                public string Index { get; set; }
                                public string SampleFmt { get; set; }
                                public string ChannelLayout { get; set; }
                                public string Lang { get; set; }
                                public string Samplerate { get; set; }
                                public string CodecLongName { get; set; }
                                public string Channels { get; set; }
                                public string NumFrames { get; set; }
                                public string Bitrate { get; set; }
                                public string CodecTagString { get; set; }
                                public string StartTime { get; set; }
                                public string CodecName { get; set; }
                                public string Duration { get; set; }
                                public string CodecTag { get; set; }
                                public string CodecTimeBase { get; set; }
                            }
                        };

                        [NameInMap("SubtitleStreamList")]
                        [Validation(Required=false)]
                        public SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                            [NameInMap("SubtitleStream")]
                            [Validation(Required=false)]
                            public List<SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                public string Index { get; set; }
                                public string Lang { get; set; }
                            }
                        };

                    }
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesFormat Format { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobTranscodeOutputPropertiesFormat : TeaModel {
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

                    }
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }
                };

            }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitComplexJobResponseBodyComplexJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitComplexJobResponseBodyComplexJobMNSMessageResult : TeaModel {
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

            }
            [NameInMap("ComplexEditingConfigs")]
            [Validation(Required=false)]
            public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigs ComplexEditingConfigs { get; set; }
            public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigs : TeaModel {
                [NameInMap("ComplexEditingConfigs")]
                [Validation(Required=false)]
                public List<SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigs> ComplexEditingConfigs { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigs : TeaModel {
                    [NameInMap("Editing")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditing Editing { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditing : TeaModel {
                        [NameInMap("Timeline")]
                        [Validation(Required=false)]
                        public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimeline Timeline { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimeline : TeaModel {
                            [NameInMap("TrackList")]
                            [Validation(Required=false)]
                            public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackList TrackList { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackList : TeaModel {
                                [NameInMap("Track")]
                                [Validation(Required=false)]
                                public List<SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrack> Track { get; set; }
                                public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrack : TeaModel {
                                    public string Type { get; set; }
                                    public string Order { get; set; }
                                    public string Id { get; set; }
                                    public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClips Clips { get; set; }
                                    public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClips : TeaModel {
                                        [NameInMap("Clip")]
                                        [Validation(Required=false)]
                                        public List<SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClip> Clip { get; set; }
                                        public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClip : TeaModel {
                                            [NameInMap("ClipsConfig")]
                                            [Validation(Required=false)]
                                            public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClipClipsConfig ClipsConfig { get; set; }
                                            public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClipClipsConfig : TeaModel {
                                                [NameInMap("ClipsConfigVideo")]
                                                [Validation(Required=false)]
                                                public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClipClipsConfigClipsConfigVideo ClipsConfigVideo { get; set; }
                                                public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClipClipsConfigClipsConfigVideo : TeaModel {
                                                    [NameInMap("T")]
                                                    [Validation(Required=false)]
                                                    public string T { get; set; }

                                                    [NameInMap("L")]
                                                    [Validation(Required=false)]
                                                    public string L { get; set; }

                                                }
                                            };

                                            [NameInMap("Out")]
                                            [Validation(Required=false)]
                                            public string Out { get; set; }

                                            [NameInMap("In")]
                                            [Validation(Required=false)]
                                            public string In { get; set; }

                                            [NameInMap("clipID")]
                                            [Validation(Required=false)]
                                            public string ClipID { get; set; }

                                        }

                                    }
                                }
                            };

                            [NameInMap("TimelineConfig")]
                            [Validation(Required=false)]
                            public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfig TimelineConfig { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfig : TeaModel {
                                [NameInMap("TimelineConfigAudio")]
                                [Validation(Required=false)]
                                public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfigTimelineConfigAudio TimelineConfigAudio { get; set; }
                                public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfigTimelineConfigAudio : TeaModel {
                                    [NameInMap("ChannelLayout")]
                                    [Validation(Required=false)]
                                    public string ChannelLayout { get; set; }

                                    [NameInMap("Samplerate")]
                                    [Validation(Required=false)]
                                    public string Samplerate { get; set; }

                                    [NameInMap("Channels")]
                                    [Validation(Required=false)]
                                    public string Channels { get; set; }

                                }
                                [NameInMap("TimelineConfigVideo")]
                                [Validation(Required=false)]
                                public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfigTimelineConfigVideo TimelineConfigVideo { get; set; }
                                public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfigTimelineConfigVideo : TeaModel {
                                    [NameInMap("BgColor")]
                                    [Validation(Required=false)]
                                    public string BgColor { get; set; }

                                    [NameInMap("Width")]
                                    [Validation(Required=false)]
                                    public string Width { get; set; }

                                    [NameInMap("RenderRatio")]
                                    [Validation(Required=false)]
                                    public string RenderRatio { get; set; }

                                    [NameInMap("IsGpuData")]
                                    [Validation(Required=false)]
                                    public string IsGpuData { get; set; }

                                    [NameInMap("Height")]
                                    [Validation(Required=false)]
                                    public string Height { get; set; }

                                    [NameInMap("IsOneTrackData")]
                                    [Validation(Required=false)]
                                    public string IsOneTrackData { get; set; }

                                    [NameInMap("Fps")]
                                    [Validation(Required=false)]
                                    public string Fps { get; set; }

                                    [NameInMap("ReclosePrec")]
                                    [Validation(Required=false)]
                                    public string ReclosePrec { get; set; }

                                }
                            };

                        }
                        [NameInMap("ClipList")]
                        [Validation(Required=false)]
                        public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingClipList ClipList { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingClipList : TeaModel {
                            [NameInMap("Clip")]
                            [Validation(Required=false)]
                            public List<SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingClipListClip> Clip { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingClipListClip : TeaModel {
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                [NameInMap("SourceID")]
                                [Validation(Required=false)]
                                public string SourceID { get; set; }

                                [NameInMap("Effects")]
                                [Validation(Required=false)]
                                public SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingClipListClipEffects Effects { get; set; }
                                public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingClipListClipEffects : TeaModel {
                                    [NameInMap("Effect")]
                                    [Validation(Required=false)]
                                    public List<SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingClipListClipEffectsEffect> Effect { get; set; }
                                    public class SubmitComplexJobResponseBodyComplexJobComplexEditingConfigsComplexEditingConfigsEditingClipListClipEffectsEffect : TeaModel {
                                        public string Effect { get; set; }
                                        public string EffectConfig { get; set; }
                                    }
                                };

                                [NameInMap("SourceType")]
                                [Validation(Required=false)]
                                public string SourceType { get; set; }

                                [NameInMap("SourceStrmMap")]
                                [Validation(Required=false)]
                                public string SourceStrmMap { get; set; }

                                [NameInMap("Out")]
                                [Validation(Required=false)]
                                public string Out { get; set; }

                                [NameInMap("In")]
                                [Validation(Required=false)]
                                public string In { get; set; }

                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                            }

                        }
                    };

                }

            }
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public SubmitComplexJobResponseBodyComplexJobInputs Inputs { get; set; }
            public class SubmitComplexJobResponseBodyComplexJobInputs : TeaModel {
                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public List<SubmitComplexJobResponseBodyComplexJobInputsInputs> Inputs { get; set; }
                public class SubmitComplexJobResponseBodyComplexJobInputsInputs : TeaModel {
                    [NameInMap("EditingInputs")]
                    [Validation(Required=false)]
                    public SubmitComplexJobResponseBodyComplexJobInputsInputsEditingInputs EditingInputs { get; set; }
                    public class SubmitComplexJobResponseBodyComplexJobInputsInputsEditingInputs : TeaModel {
                        [NameInMap("EditingInput")]
                        [Validation(Required=false)]
                        public List<SubmitComplexJobResponseBodyComplexJobInputsInputsEditingInputsEditingInput> EditingInput { get; set; }
                        public class SubmitComplexJobResponseBodyComplexJobInputsInputsEditingInputsEditingInput : TeaModel {
                            public SubmitComplexJobResponseBodyComplexJobInputsInputsEditingInputsEditingInputInputFile InputFile { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobInputsInputsEditingInputsEditingInputInputFile : TeaModel {
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
                            public SubmitComplexJobResponseBodyComplexJobInputsInputsEditingInputsEditingInputInputConfig InputConfig { get; set; }
                            public class SubmitComplexJobResponseBodyComplexJobInputsInputsEditingInputsEditingInputInputConfig : TeaModel {
                                [NameInMap("IsNormalSar")]
                                [Validation(Required=false)]
                                public string IsNormalSar { get; set; }

                                [NameInMap("DeinterlaceMethod")]
                                [Validation(Required=false)]
                                public string DeinterlaceMethod { get; set; }

                            }
                            public string Id { get; set; }
                        }
                    };

                }

            }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
        };

    }

}
