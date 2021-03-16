// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryComplexJobListResponseBody : TeaModel {
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public QueryComplexJobListResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class QueryComplexJobListResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryComplexJobListResponseBodyJobList JobList { get; set; }
        public class QueryComplexJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryComplexJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryComplexJobListResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public long? Percent { get; set; }
                public string FinishTime { get; set; }
                public string State { get; set; }
                public QueryComplexJobListResponseBodyJobListJobTranscodeOutput TranscodeOutput { get; set; }
                public class QueryComplexJobListResponseBodyJobListJobTranscodeOutput : TeaModel {
                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputVideo Video { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputVideo : TeaModel {
                        [NameInMap("Bufsize")]
                        [Validation(Required=false)]
                        public string Bufsize { get; set; }
                        [NameInMap("Degrain")]
                        [Validation(Required=false)]
                        public string Degrain { get; set; }
                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputVideoBitrateBnd BitrateBnd { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputVideoBitrateBnd : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputTransConfig TransConfig { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputTransConfig : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputEncryption Encryption { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputEncryption : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputWaterMarkList WaterMarkList { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputWaterMarkList : TeaModel {
                        [NameInMap("WaterMark")]
                        [Validation(Required=false)]
                        public List<QueryComplexJobListResponseBodyJobListJobTranscodeOutputWaterMarkListWaterMark> WaterMark { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputWaterMarkListWaterMark : TeaModel {
                            public string Type { get; set; }
                            public string ReferPos { get; set; }
                            public string Dx { get; set; }
                            public string Width { get; set; }
                            public string Height { get; set; }
                            public QueryComplexJobListResponseBodyJobListJobTranscodeOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputWaterMarkListWaterMarkInputFile : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputM3U8NonStandardSupport : TeaModel {
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputM3U8NonStandardSupportTS TS { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputM3U8NonStandardSupportTS : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputAudio Audio { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputAudio : TeaModel {
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
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputAudioVolume Volume { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputAudioVolume : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputMergeList MergeList { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputMergeList : TeaModel {
                        [NameInMap("Merge")]
                        [Validation(Required=false)]
                        public List<QueryComplexJobListResponseBodyJobListJobTranscodeOutputMergeListMerge> Merge { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputMergeListMerge : TeaModel {
                            public string Start { get; set; }
                            public string RoleArn { get; set; }
                            public string MergeURL { get; set; }
                            public string Duration { get; set; }
                        }
                    };

                    [NameInMap("SuperReso")]
                    [Validation(Required=false)]
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputSuperReso SuperReso { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputSuperReso : TeaModel {
                        [NameInMap("IsHalfSample")]
                        [Validation(Required=false)]
                        public string IsHalfSample { get; set; }
                    };

                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    [NameInMap("DigiWaterMark")]
                    [Validation(Required=false)]
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputDigiWaterMark DigiWaterMark { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputDigiWaterMark : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }
                        [NameInMap("Alpha")]
                        [Validation(Required=false)]
                        public string Alpha { get; set; }
                        [NameInMap("InputFile")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputDigiWaterMarkInputFile InputFile { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputDigiWaterMarkInputFile : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputOutputFile OutputFile { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputOutputFile : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputContainer Container { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputContainer : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }
                    };

                    [NameInMap("Clip")]
                    [Validation(Required=false)]
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputClip Clip { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputClip : TeaModel {
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputClipTimeSpan TimeSpan { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputClipTimeSpan : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputMuxConfig MuxConfig { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputMuxConfig : TeaModel {
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputMuxConfigGif Gif { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputMuxConfigGif : TeaModel {
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
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputMuxConfigSegment Segment { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputMuxConfigSegment : TeaModel {
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
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfig SubtitleConfig { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfig : TeaModel {
                        [NameInMap("ExtSubtitleList")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigExtSubtitleList : TeaModel {
                            [NameInMap("ExtSubtitle")]
                            [Validation(Required=false)]
                            public List<QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                [NameInMap("CharEnc")]
                                [Validation(Required=false)]
                                public string CharEnc { get; set; }

                                [NameInMap("FontName")]
                                [Validation(Required=false)]
                                public string FontName { get; set; }

                                [NameInMap("Input")]
                                [Validation(Required=false)]
                                public QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
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
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigSubtitleList : TeaModel {
                            [NameInMap("Subtitle")]
                            [Validation(Required=false)]
                            public List<QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                            }

                        }
                    };

                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputProperties Properties { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputProperties : TeaModel {
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
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreams Streams { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreams : TeaModel {
                            [NameInMap("VideoStreamList")]
                            [Validation(Required=false)]
                            public QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
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
                                    public QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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
                            public QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsAudioStreamList : TeaModel {
                                [NameInMap("AudioStream")]
                                [Validation(Required=false)]
                                public List<QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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
                            public QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                [NameInMap("SubtitleStream")]
                                [Validation(Required=false)]
                                public List<QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                    public string Index { get; set; }
                                    public string Lang { get; set; }
                                }
                            };

                        }
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesFormat Format { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobTranscodeOutputPropertiesFormat : TeaModel {
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
                public string Message { get; set; }
                public QueryComplexJobListResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryComplexJobListResponseBodyJobListJobMNSMessageResult : TeaModel {
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
                public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigs ComplexEditingConfigs { get; set; }
                public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigs : TeaModel {
                    [NameInMap("ComplexEditingConfigs")]
                    [Validation(Required=false)]
                    public List<QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigs> ComplexEditingConfigs { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigs : TeaModel {
                        [NameInMap("Editing")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditing Editing { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditing : TeaModel {
                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimeline Timeline { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimeline : TeaModel {
                                [NameInMap("TrackList")]
                                [Validation(Required=false)]
                                public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackList TrackList { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackList : TeaModel {
                                    [NameInMap("Track")]
                                    [Validation(Required=false)]
                                    public List<QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrack> Track { get; set; }
                                    public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrack : TeaModel {
                                        public string Type { get; set; }
                                        public string Order { get; set; }
                                        public string Id { get; set; }
                                        public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClips Clips { get; set; }
                                        public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClips : TeaModel {
                                            [NameInMap("Clip")]
                                            [Validation(Required=false)]
                                            public List<QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClip> Clip { get; set; }
                                            public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClip : TeaModel {
                                                [NameInMap("ClipsConfig")]
                                                [Validation(Required=false)]
                                                public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClipClipsConfig ClipsConfig { get; set; }
                                                public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClipClipsConfig : TeaModel {
                                                    [NameInMap("ClipsConfigVideo")]
                                                    [Validation(Required=false)]
                                                    public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClipClipsConfigClipsConfigVideo ClipsConfigVideo { get; set; }
                                                    public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTrackListTrackClipsClipClipsConfigClipsConfigVideo : TeaModel {
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
                                public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfig TimelineConfig { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfig : TeaModel {
                                    [NameInMap("TimelineConfigAudio")]
                                    [Validation(Required=false)]
                                    public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfigTimelineConfigAudio TimelineConfigAudio { get; set; }
                                    public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfigTimelineConfigAudio : TeaModel {
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
                                    public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfigTimelineConfigVideo TimelineConfigVideo { get; set; }
                                    public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingTimelineTimelineConfigTimelineConfigVideo : TeaModel {
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
                            public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingClipList ClipList { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingClipList : TeaModel {
                                [NameInMap("Clip")]
                                [Validation(Required=false)]
                                public List<QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingClipListClip> Clip { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingClipListClip : TeaModel {
                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }

                                    [NameInMap("SourceID")]
                                    [Validation(Required=false)]
                                    public string SourceID { get; set; }

                                    [NameInMap("Effects")]
                                    [Validation(Required=false)]
                                    public QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingClipListClipEffects Effects { get; set; }
                                    public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingClipListClipEffects : TeaModel {
                                        [NameInMap("Effect")]
                                        [Validation(Required=false)]
                                        public List<QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingClipListClipEffectsEffect> Effect { get; set; }
                                        public class QueryComplexJobListResponseBodyJobListJobComplexEditingConfigsComplexEditingConfigsEditingClipListClipEffectsEffect : TeaModel {
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
                public QueryComplexJobListResponseBodyJobListJobInputs Inputs { get; set; }
                public class QueryComplexJobListResponseBodyJobListJobInputs : TeaModel {
                    [NameInMap("Inputs")]
                    [Validation(Required=false)]
                    public List<QueryComplexJobListResponseBodyJobListJobInputsInputs> Inputs { get; set; }
                    public class QueryComplexJobListResponseBodyJobListJobInputsInputs : TeaModel {
                        [NameInMap("EditingInputs")]
                        [Validation(Required=false)]
                        public QueryComplexJobListResponseBodyJobListJobInputsInputsEditingInputs EditingInputs { get; set; }
                        public class QueryComplexJobListResponseBodyJobListJobInputsInputsEditingInputs : TeaModel {
                            [NameInMap("EditingInput")]
                            [Validation(Required=false)]
                            public List<QueryComplexJobListResponseBodyJobListJobInputsInputsEditingInputsEditingInput> EditingInput { get; set; }
                            public class QueryComplexJobListResponseBodyJobListJobInputsInputsEditingInputsEditingInput : TeaModel {
                                public QueryComplexJobListResponseBodyJobListJobInputsInputsEditingInputsEditingInputInputFile InputFile { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobInputsInputsEditingInputsEditingInputInputFile : TeaModel {
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
                                public QueryComplexJobListResponseBodyJobListJobInputsInputsEditingInputsEditingInputInputConfig InputConfig { get; set; }
                                public class QueryComplexJobListResponseBodyJobListJobInputsInputsEditingInputsEditingInputInputConfig : TeaModel {
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
                public string JobId { get; set; }
                public string Code { get; set; }
                public string PipelineId { get; set; }
            }
        };

    }

}
