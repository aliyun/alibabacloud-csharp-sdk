// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryJobListResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryJobListResponseBodyJobList JobList { get; set; }
        public class QueryJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryJobListResponseBodyJobListJob : TeaModel {
                public string Code { get; set; }
                public string CreationTime { get; set; }
                public string FinishTime { get; set; }
                public QueryJobListResponseBodyJobListJobInput Input { get; set; }
                public class QueryJobListResponseBodyJobListJobInput : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }
                public string JobId { get; set; }
                public QueryJobListResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryJobListResponseBodyJobListJobMNSMessageResult : TeaModel {
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                }
                public string Message { get; set; }
                public QueryJobListResponseBodyJobListJobOutput Output { get; set; }
                public class QueryJobListResponseBodyJobListJobOutput : TeaModel {
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputAudio Audio { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputAudio : TeaModel {
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
                        [NameInMap("Samplerate")]
                        [Validation(Required=false)]
                        public string Samplerate { get; set; }
                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputAudioVolume Volume { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputAudioVolume : TeaModel {
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                            [NameInMap("Method")]
                            [Validation(Required=false)]
                            public string Method { get; set; }

                        }
                    };

                    [NameInMap("AudioStreamMap")]
                    [Validation(Required=false)]
                    public string AudioStreamMap { get; set; }

                    [NameInMap("Clip")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputClip Clip { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputClip : TeaModel {
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputClipTimeSpan TimeSpan { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputClipTimeSpan : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("Seek")]
                            [Validation(Required=false)]
                            public string Seek { get; set; }

                        }
                    };

                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputContainer Container { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputContainer : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }
                    };

                    [NameInMap("DeWatermark")]
                    [Validation(Required=false)]
                    public string DeWatermark { get; set; }

                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputEncryption Encryption { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputEncryption : TeaModel {
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }
                        [NameInMap("KeyType")]
                        [Validation(Required=false)]
                        public string KeyType { get; set; }
                        [NameInMap("KeyUri")]
                        [Validation(Required=false)]
                        public string KeyUri { get; set; }
                        [NameInMap("SkipCnt")]
                        [Validation(Required=false)]
                        public string SkipCnt { get; set; }
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }
                    };

                    /// <summary>
                    /// 扩展字段
                    /// </summary>
                    [NameInMap("ExtendData")]
                    [Validation(Required=false)]
                    public string ExtendData { get; set; }

                    [NameInMap("M3U8NonStandardSupport")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupport : TeaModel {
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupportTS TS { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupportTS : TeaModel {
                            [NameInMap("Md5Support")]
                            [Validation(Required=false)]
                            public bool? Md5Support { get; set; }

                            [NameInMap("SizeSupport")]
                            [Validation(Required=false)]
                            public bool? SizeSupport { get; set; }

                        }
                    };

                    [NameInMap("MergeConfigUrl")]
                    [Validation(Required=false)]
                    public string MergeConfigUrl { get; set; }

                    [NameInMap("MergeList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputMergeList MergeList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputMergeList : TeaModel {
                        [NameInMap("Merge")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputMergeListMerge> Merge { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMergeListMerge : TeaModel {
                            public string Duration { get; set; }
                            public string MergeURL { get; set; }
                            public string RoleArn { get; set; }
                            public string Start { get; set; }
                        }
                    };

                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputMuxConfig MuxConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputMuxConfig : TeaModel {
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigGif Gif { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigGif : TeaModel {
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
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigSegment Segment { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigSegment : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }
                        [NameInMap("Webp")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigWebp Webp { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigWebp : TeaModel {
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }

                        }
                    };

                    [NameInMap("OpeningList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputOpeningList OpeningList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputOpeningList : TeaModel {
                        [NameInMap("Opening")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputOpeningListOpening> Opening { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputOpeningListOpening : TeaModel {
                            public string Height { get; set; }
                            public string Start { get; set; }
                            public string Width { get; set; }
                            public string OpenUrl { get; set; }
                        }
                    };

                    [NameInMap("OutSubtitleList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputOutSubtitleList OutSubtitleList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputOutSubtitleList : TeaModel {
                        [NameInMap("OutSubtitle")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitle> OutSubtitle { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitle : TeaModel {
                            public string Map { get; set; }
                            public string Message { get; set; }
                            public QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }

                                [NameInMap("Location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                                [NameInMap("RoleArn")]
                                [Validation(Required=false)]
                                public string RoleArn { get; set; }

                            }
                            public bool? Success { get; set; }
                        }
                    };

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputOutputFile OutputFile { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputOutputFile : TeaModel {
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }
                    };

                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputProperties Properties { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputProperties : TeaModel {
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }
                        [NameInMap("FileFormat")]
                        [Validation(Required=false)]
                        public string FileFormat { get; set; }
                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputPropertiesFormat Format { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputPropertiesFormat : TeaModel {
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("FormatLongName")]
                            [Validation(Required=false)]
                            public string FormatLongName { get; set; }

                            [NameInMap("FormatName")]
                            [Validation(Required=false)]
                            public string FormatName { get; set; }

                            [NameInMap("NumPrograms")]
                            [Validation(Required=false)]
                            public string NumPrograms { get; set; }

                            [NameInMap("NumStreams")]
                            [Validation(Required=false)]
                            public string NumStreams { get; set; }

                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public string Size { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                        }
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }
                        [NameInMap("SourceLogos")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputPropertiesSourceLogos SourceLogos { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputPropertiesSourceLogos : TeaModel {
                            [NameInMap("SourceLogo")]
                            [Validation(Required=false)]
                            public List<QueryJobListResponseBodyJobListJobOutputPropertiesSourceLogosSourceLogo> SourceLogo { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesSourceLogosSourceLogo : TeaModel {
                                [NameInMap("Source")]
                                [Validation(Required=false)]
                                public string Source { get; set; }

                            }

                        }
                        [NameInMap("Streams")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputPropertiesStreams Streams { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputPropertiesStreams : TeaModel {
                            [NameInMap("AudioStreamList")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList : TeaModel {
                                [NameInMap("AudioStream")]
                                [Validation(Required=false)]
                                public List<QueryJobListResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                                    public string Bitrate { get; set; }
                                    public string ChannelLayout { get; set; }
                                    public string Channels { get; set; }
                                    public string CodecLongName { get; set; }
                                    public string CodecName { get; set; }
                                    public string CodecTag { get; set; }
                                    public string CodecTagString { get; set; }
                                    public string CodecTimeBase { get; set; }
                                    public string Duration { get; set; }
                                    public string Index { get; set; }
                                    public string Lang { get; set; }
                                    public string NumFrames { get; set; }
                                    public string SampleFmt { get; set; }
                                    public string Samplerate { get; set; }
                                    public string StartTime { get; set; }
                                    public string Timebase { get; set; }
                                }
                            };

                            [NameInMap("SubtitleStreamList")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                [NameInMap("SubtitleStream")]
                                [Validation(Required=false)]
                                public List<QueryJobListResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                    public string Index { get; set; }
                                    public string Lang { get; set; }
                                }
                            };

                            [NameInMap("VideoStreamList")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                                    public string AvgFPS { get; set; }
                                    public string Bitrate { get; set; }
                                    public string CodecLongName { get; set; }
                                    public string CodecName { get; set; }
                                    public string CodecTag { get; set; }
                                    public string CodecTagString { get; set; }
                                    public string CodecTimeBase { get; set; }
                                    public string Dar { get; set; }
                                    public string Duration { get; set; }
                                    public string Fps { get; set; }
                                    public string HasBFrames { get; set; }
                                    public string Height { get; set; }
                                    public string Index { get; set; }
                                    public string Lang { get; set; }
                                    public string Level { get; set; }
                                    public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                        [NameInMap("AvgBitrate")]
                                        [Validation(Required=false)]
                                        public string AvgBitrate { get; set; }

                                        [NameInMap("CostBandwidth")]
                                        [Validation(Required=false)]
                                        public string CostBandwidth { get; set; }

                                        [NameInMap("PreloadTime")]
                                        [Validation(Required=false)]
                                        public string PreloadTime { get; set; }

                                    }
                                    public string NumFrames { get; set; }
                                    public string PixFmt { get; set; }
                                    public string Profile { get; set; }
                                    public string Sar { get; set; }
                                    public string StartTime { get; set; }
                                    public string Timebase { get; set; }
                                    public string Width { get; set; }
                                    public string BitsPerRawSample { get; set; }
                                    public string ColorPrimaries { get; set; }
                                    public string ColorTransfer { get; set; }
                                }
                            };

                        }
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }
                    };

                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    [NameInMap("SubtitleConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputSubtitleConfig SubtitleConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputSubtitleConfig : TeaModel {
                        [NameInMap("ExtSubtitleList")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleList : TeaModel {
                            [NameInMap("ExtSubtitle")]
                            [Validation(Required=false)]
                            public List<QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                [NameInMap("CharEnc")]
                                [Validation(Required=false)]
                                public string CharEnc { get; set; }

                                [NameInMap("FontName")]
                                [Validation(Required=false)]
                                public string FontName { get; set; }

                                [NameInMap("Input")]
                                [Validation(Required=false)]
                                public QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
                                    [NameInMap("Bucket")]
                                    [Validation(Required=false)]
                                    public string Bucket { get; set; }
                                    [NameInMap("Location")]
                                    [Validation(Required=false)]
                                    public string Location { get; set; }
                                    [NameInMap("Object")]
                                    [Validation(Required=false)]
                                    public string Object { get; set; }
                                };

                            }

                        }
                        [NameInMap("SubtitleList")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigSubtitleList : TeaModel {
                            [NameInMap("Subtitle")]
                            [Validation(Required=false)]
                            public List<QueryJobListResponseBodyJobListJobOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                            }

                        }
                    };

                    [NameInMap("SuperReso")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputSuperReso SuperReso { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputSuperReso : TeaModel {
                        [NameInMap("IsHalfSample")]
                        [Validation(Required=false)]
                        public string IsHalfSample { get; set; }
                    };

                    [NameInMap("TailSlateList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputTailSlateList TailSlateList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputTailSlateList : TeaModel {
                        [NameInMap("TailSlate")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputTailSlateListTailSlate> TailSlate { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputTailSlateListTailSlate : TeaModel {
                            public string BgColor { get; set; }
                            public string BlendDuration { get; set; }
                            public string Height { get; set; }
                            public bool? IsMergeAudio { get; set; }
                            public string Start { get; set; }
                            public string TailUrl { get; set; }
                            public string Width { get; set; }
                        }
                    };

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputTransConfig TransConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputTransConfig : TeaModel {
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
                    };

                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputVideo Video { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputVideo : TeaModel {
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }
                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputVideoBitrateBnd BitrateBnd { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputVideoBitrateBnd : TeaModel {
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
                        [NameInMap("ResoPriority")]
                        [Validation(Required=false)]
                        public string ResoPriority { get; set; }
                        [NameInMap("ScanMode")]
                        [Validation(Required=false)]
                        public string ScanMode { get; set; }
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }
                    };

                    [NameInMap("VideoStreamMap")]
                    [Validation(Required=false)]
                    public string VideoStreamMap { get; set; }

                    [NameInMap("WaterMarkConfigUrl")]
                    [Validation(Required=false)]
                    public string WaterMarkConfigUrl { get; set; }

                    [NameInMap("WaterMarkList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputWaterMarkList WaterMarkList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputWaterMarkList : TeaModel {
                        [NameInMap("WaterMark")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMark> WaterMark { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMark : TeaModel {
                            public string Dx { get; set; }
                            public string Dy { get; set; }
                            public string Height { get; set; }
                            public QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }

                                [NameInMap("Location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }
                            public string ReferPos { get; set; }
                            public string Type { get; set; }
                            public string WaterMarkTemplateId { get; set; }
                            public string Width { get; set; }
                        }
                    };

                }
                public long? Percent { get; set; }
                public string PipelineId { get; set; }
                public string State { get; set; }
            }
        };

        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public QueryJobListResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class QueryJobListResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
