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
                public string Code { get; set; }
                public SubmitJobsResponseBodyJobResultListJobResultJob Job { get; set; }
                public class SubmitJobsResponseBodyJobResultListJobResultJob : TeaModel {
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
                    public SubmitJobsResponseBodyJobResultListJobResultJobInput Input { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobInput : TeaModel {
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

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("MNSMessageResult")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultJobMNSMessageResult MNSMessageResult { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobMNSMessageResult : TeaModel {
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }
                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }
                        [NameInMap("MessageId")]
                        [Validation(Required=false)]
                        public string MessageId { get; set; }
                    };

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultJobOutput Output { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutput : TeaModel {
                        [NameInMap("AmixList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputAmixList AmixList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAmixList : TeaModel {
                            [NameInMap("Amix")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputAmixListAmix> Amix { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAmixListAmix : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputAudio Audio { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAudio : TeaModel {
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputAudioVolume Volume { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAudioVolume : TeaModel {
                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }
                                [NameInMap("Method")]
                                [Validation(Required=false)]
                                public string Method { get; set; }
                            };

                        }
                        [NameInMap("AudioStreamMap")]
                        [Validation(Required=false)]
                        public string AudioStreamMap { get; set; }
                        [NameInMap("Clip")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputClip Clip { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputClip : TeaModel {
                            [NameInMap("TimeSpan")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputClipTimeSpan TimeSpan { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputClipTimeSpan : TeaModel {
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }
                                [NameInMap("Seek")]
                                [Validation(Required=false)]
                                public string Seek { get; set; }
                            };

                        }
                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputContainer Container { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputContainer : TeaModel {
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }
                        [NameInMap("DeWatermark")]
                        [Validation(Required=false)]
                        public string DeWatermark { get; set; }
                        [NameInMap("DigiWaterMark")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMark DigiWaterMark { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMark : TeaModel {
                            [NameInMap("Alpha")]
                            [Validation(Required=false)]
                            public string Alpha { get; set; }

                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMarkInputFile InputFile { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMarkInputFile : TeaModel {
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

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }
                        [NameInMap("Encryption")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputEncryption Encryption { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputEncryption : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupport : TeaModel {
                            [NameInMap("TS")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupportTS TS { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupportTS : TeaModel {
                                [NameInMap("Md5Support")]
                                [Validation(Required=false)]
                                public bool? Md5Support { get; set; }
                                [NameInMap("SizeSupport")]
                                [Validation(Required=false)]
                                public bool? SizeSupport { get; set; }
                            };

                        }
                        [NameInMap("MergeConfigUrl")]
                        [Validation(Required=false)]
                        public string MergeConfigUrl { get; set; }
                        [NameInMap("MergeList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputMergeList MergeList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMergeList : TeaModel {
                            [NameInMap("Merge")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputMergeListMerge> Merge { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMergeListMerge : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfig MuxConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfig : TeaModel {
                            [NameInMap("Gif")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigGif Gif { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigGif : TeaModel {
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigSegment Segment { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigSegment : TeaModel {
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }
                            };

                            [NameInMap("Webp")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigWebp Webp { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigWebp : TeaModel {
                                [NameInMap("Loop")]
                                [Validation(Required=false)]
                                public string Loop { get; set; }
                            };

                        }
                        [NameInMap("OpeningList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputOpeningList OpeningList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOpeningList : TeaModel {
                            [NameInMap("Opening")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputOpeningListOpening> Opening { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOpeningListOpening : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleList OutSubtitleList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleList : TeaModel {
                            [NameInMap("OutSubtitle")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitle> OutSubtitle { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitle : TeaModel {
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                                [NameInMap("Message")]
                                [Validation(Required=false)]
                                public string Message { get; set; }

                                [NameInMap("OutSubtitleFile")]
                                [Validation(Required=false)]
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
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

                                [NameInMap("Success")]
                                [Validation(Required=false)]
                                public bool? Success { get; set; }

                            }

                        }
                        [NameInMap("OutputFile")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputOutputFile OutputFile { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutputFile : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputProperties Properties { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputProperties : TeaModel {
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesFormat Format { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesFormat : TeaModel {
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
                            };

                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("Streams")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreams Streams { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreams : TeaModel {
                                [NameInMap("AudioStreamList")]
                                [Validation(Required=false)]
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsAudioStreamList : TeaModel {
                                    [NameInMap("AudioStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                    [NameInMap("SubtitleStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
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
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamList : TeaModel {
                                    [NameInMap("VideoStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
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
                                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                            [NameInMap("AvgBitrate")]
                                            [Validation(Required=false)]
                                            public string AvgBitrate { get; set; }
                                            [NameInMap("CostBandwidth")]
                                            [Validation(Required=false)]
                                            public string CostBandwidth { get; set; }
                                            [NameInMap("PreloadTime")]
                                            [Validation(Required=false)]
                                            public string PreloadTime { get; set; }
                                        };

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
                            };

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }
                        [NameInMap("Rotate")]
                        [Validation(Required=false)]
                        public string Rotate { get; set; }
                        [NameInMap("SubtitleConfig")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfig SubtitleConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfig : TeaModel {
                            [NameInMap("ExtSubtitleList")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleList : TeaModel {
                                [NameInMap("ExtSubtitle")]
                                [Validation(Required=false)]
                                public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                    public string CharEnc { get; set; }
                                    public string FontName { get; set; }
                                    public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
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
                            };

                            [NameInMap("SubtitleList")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigSubtitleList : TeaModel {
                                [NameInMap("Subtitle")]
                                [Validation(Required=false)]
                                public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
                                    public string Map { get; set; }
                                }
                            };

                        }
                        [NameInMap("SuperReso")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputSuperReso SuperReso { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSuperReso : TeaModel {
                            [NameInMap("IsHalfSample")]
                            [Validation(Required=false)]
                            public string IsHalfSample { get; set; }

                        }
                        [NameInMap("TailSlateList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputTailSlateList TailSlateList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputTailSlateList : TeaModel {
                            [NameInMap("TailSlate")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputTailSlateListTailSlate> TailSlate { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputTailSlateListTailSlate : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputTransConfig TransConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputTransConfig : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputVideo Video { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputVideo : TeaModel {
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("BitrateBnd")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputVideoBitrateBnd BitrateBnd { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputVideoBitrateBnd : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkList WaterMarkList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkList : TeaModel {
                            [NameInMap("WaterMark")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMark> WaterMark { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMark : TeaModel {
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
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
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
                    };

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
                public string Message { get; set; }
                public bool? Success { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
