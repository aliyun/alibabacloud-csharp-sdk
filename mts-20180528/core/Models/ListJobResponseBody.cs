// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class ListJobResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public ListJobResponseBodyJobList JobList { get; set; }
        public class ListJobResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<ListJobResponseBodyJobListJob> Job { get; set; }
            public class ListJobResponseBodyJobListJob : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("Input")]
                [Validation(Required=false)]
                public ListJobResponseBodyJobListJobInput Input { get; set; }
                public class ListJobResponseBodyJobListJobInput : TeaModel {
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

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public ListJobResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class ListJobResponseBodyJobListJobMNSMessageResult : TeaModel {
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

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Output")]
                [Validation(Required=false)]
                public ListJobResponseBodyJobListJobOutput Output { get; set; }
                public class ListJobResponseBodyJobListJobOutput : TeaModel {
                    [NameInMap("AmixList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputAmixList AmixList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputAmixList : TeaModel {
                        [NameInMap("Amix")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputAmixListAmix> Amix { get; set; }
                        public class ListJobResponseBodyJobListJobOutputAmixListAmix : TeaModel {
                            [NameInMap("AmixURL")]
                            [Validation(Required=false)]
                            public string AmixURL { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("Map")]
                            [Validation(Required=false)]
                            public string Map { get; set; }

                            [NameInMap("MixDurMode")]
                            [Validation(Required=false)]
                            public string MixDurMode { get; set; }

                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                        }

                    }

                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputAudio Audio { get; set; }
                    public class ListJobResponseBodyJobListJobOutputAudio : TeaModel {
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
                        public ListJobResponseBodyJobListJobOutputAudioVolume Volume { get; set; }
                        public class ListJobResponseBodyJobListJobOutputAudioVolume : TeaModel {
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                            [NameInMap("Method")]
                            [Validation(Required=false)]
                            public string Method { get; set; }

                        }

                    }

                    [NameInMap("AudioStreamMap")]
                    [Validation(Required=false)]
                    public string AudioStreamMap { get; set; }

                    [NameInMap("Clip")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputClip Clip { get; set; }
                    public class ListJobResponseBodyJobListJobOutputClip : TeaModel {
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputClipTimeSpan TimeSpan { get; set; }
                        public class ListJobResponseBodyJobListJobOutputClipTimeSpan : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("Seek")]
                            [Validation(Required=false)]
                            public string Seek { get; set; }

                        }

                    }

                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputContainer Container { get; set; }
                    public class ListJobResponseBodyJobListJobOutputContainer : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    [NameInMap("DeWatermark")]
                    [Validation(Required=false)]
                    public string DeWatermark { get; set; }

                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputEncryption Encryption { get; set; }
                    public class ListJobResponseBodyJobListJobOutputEncryption : TeaModel {
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

                    }

                    [NameInMap("M3U8NonStandardSupport")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class ListJobResponseBodyJobListJobOutputM3U8NonStandardSupport : TeaModel {
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputM3U8NonStandardSupportTS TS { get; set; }
                        public class ListJobResponseBodyJobListJobOutputM3U8NonStandardSupportTS : TeaModel {
                            [NameInMap("Md5Support")]
                            [Validation(Required=false)]
                            public bool? Md5Support { get; set; }

                            [NameInMap("SizeSupport")]
                            [Validation(Required=false)]
                            public bool? SizeSupport { get; set; }

                        }

                    }

                    [NameInMap("MergeConfigUrl")]
                    [Validation(Required=false)]
                    public string MergeConfigUrl { get; set; }

                    [NameInMap("MergeList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputMergeList MergeList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputMergeList : TeaModel {
                        [NameInMap("Merge")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputMergeListMerge> Merge { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMergeListMerge : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("MergeURL")]
                            [Validation(Required=false)]
                            public string MergeURL { get; set; }

                            [NameInMap("RoleArn")]
                            [Validation(Required=false)]
                            public string RoleArn { get; set; }

                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                        }

                    }

                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputMuxConfig MuxConfig { get; set; }
                    public class ListJobResponseBodyJobListJobOutputMuxConfig : TeaModel {
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputMuxConfigGif Gif { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigGif : TeaModel {
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
                        public ListJobResponseBodyJobListJobOutputMuxConfigSegment Segment { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigSegment : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }

                        [NameInMap("Webp")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputMuxConfigWebp Webp { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigWebp : TeaModel {
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }

                        }

                    }

                    [NameInMap("OpeningList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputOpeningList OpeningList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOpeningList : TeaModel {
                        [NameInMap("Opening")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputOpeningListOpening> Opening { get; set; }
                        public class ListJobResponseBodyJobListJobOutputOpeningListOpening : TeaModel {
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            [NameInMap("openUrl")]
                            [Validation(Required=false)]
                            public string OpenUrl { get; set; }

                        }

                    }

                    [NameInMap("OutSubtitleList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputOutSubtitleList OutSubtitleList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOutSubtitleList : TeaModel {
                        [NameInMap("OutSubtitle")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitle> OutSubtitle { get; set; }
                        public class ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitle : TeaModel {
                            [NameInMap("Map")]
                            [Validation(Required=false)]
                            public string Map { get; set; }

                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            [NameInMap("OutSubtitleFile")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                            public class ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
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

                            [NameInMap("Success")]
                            [Validation(Required=false)]
                            public bool? Success { get; set; }

                        }

                    }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputOutputFile OutputFile { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOutputFile : TeaModel {
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

                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputProperties Properties { get; set; }
                    public class ListJobResponseBodyJobListJobOutputProperties : TeaModel {
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
                        public ListJobResponseBodyJobListJobOutputPropertiesFormat Format { get; set; }
                        public class ListJobResponseBodyJobListJobOutputPropertiesFormat : TeaModel {
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

                        [NameInMap("Streams")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputPropertiesStreams Streams { get; set; }
                        public class ListJobResponseBodyJobListJobOutputPropertiesStreams : TeaModel {
                            [NameInMap("AudioStreamList")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList : TeaModel {
                                [NameInMap("AudioStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                                    [NameInMap("Bitrate")]
                                    [Validation(Required=false)]
                                    public string Bitrate { get; set; }

                                    [NameInMap("ChannelLayout")]
                                    [Validation(Required=false)]
                                    public string ChannelLayout { get; set; }

                                    [NameInMap("Channels")]
                                    [Validation(Required=false)]
                                    public string Channels { get; set; }

                                    [NameInMap("CodecLongName")]
                                    [Validation(Required=false)]
                                    public string CodecLongName { get; set; }

                                    [NameInMap("CodecName")]
                                    [Validation(Required=false)]
                                    public string CodecName { get; set; }

                                    [NameInMap("CodecTag")]
                                    [Validation(Required=false)]
                                    public string CodecTag { get; set; }

                                    [NameInMap("CodecTagString")]
                                    [Validation(Required=false)]
                                    public string CodecTagString { get; set; }

                                    [NameInMap("CodecTimeBase")]
                                    [Validation(Required=false)]
                                    public string CodecTimeBase { get; set; }

                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                    [NameInMap("NumFrames")]
                                    [Validation(Required=false)]
                                    public string NumFrames { get; set; }

                                    [NameInMap("SampleFmt")]
                                    [Validation(Required=false)]
                                    public string SampleFmt { get; set; }

                                    [NameInMap("Samplerate")]
                                    [Validation(Required=false)]
                                    public string Samplerate { get; set; }

                                    [NameInMap("StartTime")]
                                    [Validation(Required=false)]
                                    public string StartTime { get; set; }

                                    [NameInMap("Timebase")]
                                    [Validation(Required=false)]
                                    public string Timebase { get; set; }

                                }

                            }

                            [NameInMap("SubtitleStreamList")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                [NameInMap("SubtitleStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                }

                            }

                            [NameInMap("VideoStreamList")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                                    [NameInMap("AvgFPS")]
                                    [Validation(Required=false)]
                                    public string AvgFPS { get; set; }

                                    [NameInMap("Bitrate")]
                                    [Validation(Required=false)]
                                    public string Bitrate { get; set; }

                                    [NameInMap("CodecLongName")]
                                    [Validation(Required=false)]
                                    public string CodecLongName { get; set; }

                                    [NameInMap("CodecName")]
                                    [Validation(Required=false)]
                                    public string CodecName { get; set; }

                                    [NameInMap("CodecTag")]
                                    [Validation(Required=false)]
                                    public string CodecTag { get; set; }

                                    [NameInMap("CodecTagString")]
                                    [Validation(Required=false)]
                                    public string CodecTagString { get; set; }

                                    [NameInMap("CodecTimeBase")]
                                    [Validation(Required=false)]
                                    public string CodecTimeBase { get; set; }

                                    [NameInMap("Dar")]
                                    [Validation(Required=false)]
                                    public string Dar { get; set; }

                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    [NameInMap("Fps")]
                                    [Validation(Required=false)]
                                    public string Fps { get; set; }

                                    [NameInMap("HasBFrames")]
                                    [Validation(Required=false)]
                                    public string HasBFrames { get; set; }

                                    [NameInMap("Height")]
                                    [Validation(Required=false)]
                                    public string Height { get; set; }

                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }

                                    [NameInMap("NetworkCost")]
                                    [Validation(Required=false)]
                                    public ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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

                                    [NameInMap("NumFrames")]
                                    [Validation(Required=false)]
                                    public string NumFrames { get; set; }

                                    [NameInMap("PixFmt")]
                                    [Validation(Required=false)]
                                    public string PixFmt { get; set; }

                                    [NameInMap("Profile")]
                                    [Validation(Required=false)]
                                    public string Profile { get; set; }

                                    [NameInMap("Sar")]
                                    [Validation(Required=false)]
                                    public string Sar { get; set; }

                                    [NameInMap("StartTime")]
                                    [Validation(Required=false)]
                                    public string StartTime { get; set; }

                                    [NameInMap("Timebase")]
                                    [Validation(Required=false)]
                                    public string Timebase { get; set; }

                                    [NameInMap("Width")]
                                    [Validation(Required=false)]
                                    public string Width { get; set; }

                                }

                            }

                        }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

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

                    }

                    [NameInMap("SuperReso")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputSuperReso SuperReso { get; set; }
                    public class ListJobResponseBodyJobListJobOutputSuperReso : TeaModel {
                        [NameInMap("IsHalfSample")]
                        [Validation(Required=false)]
                        public string IsHalfSample { get; set; }

                    }

                    [NameInMap("TailSlateList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputTailSlateList TailSlateList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputTailSlateList : TeaModel {
                        [NameInMap("TailSlate")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputTailSlateListTailSlate> TailSlate { get; set; }
                        public class ListJobResponseBodyJobListJobOutputTailSlateListTailSlate : TeaModel {
                            [NameInMap("BgColor")]
                            [Validation(Required=false)]
                            public string BgColor { get; set; }

                            [NameInMap("BlendDuration")]
                            [Validation(Required=false)]
                            public string BlendDuration { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("IsMergeAudio")]
                            [Validation(Required=false)]
                            public bool? IsMergeAudio { get; set; }

                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            [NameInMap("TailUrl")]
                            [Validation(Required=false)]
                            public string TailUrl { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                    }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputTransConfig TransConfig { get; set; }
                    public class ListJobResponseBodyJobListJobOutputTransConfig : TeaModel {
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

                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputVideo Video { get; set; }
                    public class ListJobResponseBodyJobListJobOutputVideo : TeaModel {
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

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

                    }

                    [NameInMap("VideoStreamMap")]
                    [Validation(Required=false)]
                    public string VideoStreamMap { get; set; }

                    [NameInMap("WaterMarkConfigUrl")]
                    [Validation(Required=false)]
                    public string WaterMarkConfigUrl { get; set; }

                    [NameInMap("WaterMarkList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputWaterMarkList WaterMarkList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputWaterMarkList : TeaModel {
                        [NameInMap("WaterMark")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputWaterMarkListWaterMark> WaterMark { get; set; }
                        public class ListJobResponseBodyJobListJobOutputWaterMarkListWaterMark : TeaModel {
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class ListJobResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
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

                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("WaterMarkTemplateId")]
                            [Validation(Required=false)]
                            public string WaterMarkTemplateId { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                    }

                }

                [NameInMap("Percent")]
                [Validation(Required=false)]
                public long? Percent { get; set; }

                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
