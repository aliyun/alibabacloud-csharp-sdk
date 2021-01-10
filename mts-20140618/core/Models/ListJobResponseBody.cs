// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public ListJobResponseBodyJobList JobList { get; set; }
        public class ListJobResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<ListJobResponseBodyJobListJob> Job { get; set; }
            public class ListJobResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public long? Percent { get; set; }
                public string FinishTime { get; set; }
                public string State { get; set; }
                public string JobId { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public ListJobResponseBodyJobListJobOutput Output { get; set; }
                public class ListJobResponseBodyJobListJobOutput : TeaModel {
                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputVideo Video { get; set; }
                    public class ListJobResponseBodyJobListJobOutputVideo : TeaModel {
                        [NameInMap("Bufsize")]
                        [Validation(Required=false)]
                        public string Bufsize { get; set; }
                        [NameInMap("Degrain")]
                        [Validation(Required=false)]
                        public string Degrain { get; set; }
                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputVideoBitrateBnd BitrateBnd { get; set; }
                        public class ListJobResponseBodyJobListJobOutputVideoBitrateBnd : TeaModel {
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
                        [NameInMap("ResoPriority")]
                        [Validation(Required=false)]
                        public string ResoPriority { get; set; }
                    };

                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputTransConfig TransConfig { get; set; }
                    public class ListJobResponseBodyJobListJobOutputTransConfig : TeaModel {
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
                    };

                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputEncryption Encryption { get; set; }
                    public class ListJobResponseBodyJobListJobOutputEncryption : TeaModel {
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
                    public ListJobResponseBodyJobListJobOutputWaterMarkList WaterMarkList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputWaterMarkList : TeaModel {
                        [NameInMap("WaterMark")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputWaterMarkListWaterMark> WaterMark { get; set; }
                        public class ListJobResponseBodyJobListJobOutputWaterMarkListWaterMark : TeaModel {
                            public string Type { get; set; }
                            public string ReferPos { get; set; }
                            public string Dx { get; set; }
                            public string Width { get; set; }
                            public string Height { get; set; }
                            public ListJobResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class ListJobResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
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

                    [NameInMap("WaterMarkConfigUrl")]
                    [Validation(Required=false)]
                    public string WaterMarkConfigUrl { get; set; }

                    [NameInMap("DeWatermark")]
                    [Validation(Required=false)]
                    public string DeWatermark { get; set; }

                    [NameInMap("M3U8NonStandardSupport")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class ListJobResponseBodyJobListJobOutputM3U8NonStandardSupport : TeaModel {
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputM3U8NonStandardSupportTS TS { get; set; }
                        public class ListJobResponseBodyJobListJobOutputM3U8NonStandardSupportTS : TeaModel {
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
                    public ListJobResponseBodyJobListJobOutputAudio Audio { get; set; }
                    public class ListJobResponseBodyJobListJobOutputAudio : TeaModel {
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
                        public ListJobResponseBodyJobListJobOutputAudioVolume Volume { get; set; }
                        public class ListJobResponseBodyJobListJobOutputAudioVolume : TeaModel {
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
                    public ListJobResponseBodyJobListJobOutputMergeList MergeList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputMergeList : TeaModel {
                        [NameInMap("Merge")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputMergeListMerge> Merge { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMergeListMerge : TeaModel {
                            public string Start { get; set; }
                            public string RoleArn { get; set; }
                            public string MergeURL { get; set; }
                            public string Duration { get; set; }
                        }
                    };

                    [NameInMap("SuperReso")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputSuperReso SuperReso { get; set; }
                    public class ListJobResponseBodyJobListJobOutputSuperReso : TeaModel {
                        [NameInMap("IsHalfSample")]
                        [Validation(Required=false)]
                        public string IsHalfSample { get; set; }
                    };

                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    [NameInMap("OutSubtitleList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputOutSubtitleList OutSubtitleList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOutSubtitleList : TeaModel {
                        [NameInMap("OutSubtitle")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitle> OutSubtitle { get; set; }
                        public class ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitle : TeaModel {
                            public string Map { get; set; }
                            public ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                            public class ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
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
                            public bool? Success { get; set; }
                            public string Message { get; set; }
                        }
                    };

                    [NameInMap("VideoStreamMap")]
                    [Validation(Required=false)]
                    public string VideoStreamMap { get; set; }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputOutputFile OutputFile { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOutputFile : TeaModel {
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
                    public ListJobResponseBodyJobListJobOutputContainer Container { get; set; }
                    public class ListJobResponseBodyJobListJobOutputContainer : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }
                    };

                    [NameInMap("Clip")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputClip Clip { get; set; }
                    public class ListJobResponseBodyJobListJobOutputClip : TeaModel {
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputClipTimeSpan TimeSpan { get; set; }
                        public class ListJobResponseBodyJobListJobOutputClipTimeSpan : TeaModel {
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

                    [NameInMap("OpeningList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputOpeningList OpeningList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOpeningList : TeaModel {
                        [NameInMap("Opening")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputOpeningListOpening> Opening { get; set; }
                        public class ListJobResponseBodyJobListJobOutputOpeningListOpening : TeaModel {
                            public string OpenUrl { get; set; }
                            public string Start { get; set; }
                            public string Width { get; set; }
                            public string Height { get; set; }
                        }
                    };

                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputMuxConfig MuxConfig { get; set; }
                    public class ListJobResponseBodyJobListJobOutputMuxConfig : TeaModel {
                        [NameInMap("Webp")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputMuxConfigWebp Webp { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigWebp : TeaModel {
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }

                        }
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputMuxConfigGif Gif { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigGif : TeaModel {
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
                        public ListJobResponseBodyJobListJobOutputMuxConfigSegment Segment { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigSegment : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }
                    };

                    [NameInMap("TailSlateList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputTailSlateList TailSlateList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputTailSlateList : TeaModel {
                        [NameInMap("TailSlate")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputTailSlateListTailSlate> TailSlate { get; set; }
                        public class ListJobResponseBodyJobListJobOutputTailSlateListTailSlate : TeaModel {
                            public string Start { get; set; }
                            public string BgColor { get; set; }
                            public bool? IsMergeAudio { get; set; }
                            public string Width { get; set; }
                            public string Height { get; set; }
                            public string BlendDuration { get; set; }
                            public string TailUrl { get; set; }
                        }
                    };

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    [NameInMap("SubtitleConfig")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputSubtitleConfig SubtitleConfig { get; set; }
                    public class ListJobResponseBodyJobListJobOutputSubtitleConfig : TeaModel {
                        [NameInMap("ExtSubtitleList")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                        public class ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleList : TeaModel {
                            [NameInMap("ExtSubtitle")]
                            [Validation(Required=false)]
                            public List<ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                            public class ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                [NameInMap("CharEnc")]
                                [Validation(Required=false)]
                                public string CharEnc { get; set; }

                                [NameInMap("FontName")]
                                [Validation(Required=false)]
                                public string FontName { get; set; }

                                [NameInMap("Input")]
                                [Validation(Required=false)]
                                public ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                public class ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
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
                        public ListJobResponseBodyJobListJobOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                        public class ListJobResponseBodyJobListJobOutputSubtitleConfigSubtitleList : TeaModel {
                            [NameInMap("Subtitle")]
                            [Validation(Required=false)]
                            public List<ListJobResponseBodyJobListJobOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                            public class ListJobResponseBodyJobListJobOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                            }

                        }
                    };

                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputProperties Properties { get; set; }
                    public class ListJobResponseBodyJobListJobOutputProperties : TeaModel {
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
                        public ListJobResponseBodyJobListJobOutputPropertiesStreams Streams { get; set; }
                        public class ListJobResponseBodyJobListJobOutputPropertiesStreams : TeaModel {
                            [NameInMap("VideoStreamList")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
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
                                    public ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList : TeaModel {
                                [NameInMap("AudioStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                [NameInMap("SubtitleStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                    public string Index { get; set; }
                                    public string Lang { get; set; }
                                }
                            };

                        }
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputPropertiesFormat Format { get; set; }
                        public class ListJobResponseBodyJobListJobOutputPropertiesFormat : TeaModel {
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
                public string PipelineId { get; set; }
                public ListJobResponseBodyJobListJobInput Input { get; set; }
                public class ListJobResponseBodyJobListJobInput : TeaModel {
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
                public ListJobResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class ListJobResponseBodyJobListJobMNSMessageResult : TeaModel {
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
            }
        };

    }

}
