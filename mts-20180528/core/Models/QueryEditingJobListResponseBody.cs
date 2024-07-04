// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class QueryEditingJobListResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryEditingJobListResponseBodyJobList JobList { get; set; }
        public class QueryEditingJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryEditingJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryEditingJobListResponseBodyJobListJob : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("EditingConfig")]
                [Validation(Required=false)]
                public QueryEditingJobListResponseBodyJobListJobEditingConfig EditingConfig { get; set; }
                public class QueryEditingJobListResponseBodyJobListJobEditingConfig : TeaModel {
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigAudio Audio { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigAudio : TeaModel {
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
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigAudioVolume Volume { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigAudioVolume : TeaModel {
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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigClip Clip { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigClip : TeaModel {
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigClipTimeSpan TimeSpan { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigClipTimeSpan : TeaModel {
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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigContainer Container { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigContainer : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    [NameInMap("DeWatermark")]
                    [Validation(Required=false)]
                    public string DeWatermark { get; set; }

                    [NameInMap("DigiWaterMark")]
                    [Validation(Required=false)]
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigDigiWaterMark DigiWaterMark { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigDigiWaterMark : TeaModel {
                        [NameInMap("Alpha")]
                        [Validation(Required=false)]
                        public string Alpha { get; set; }

                        [NameInMap("InputFile")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigDigiWaterMarkInputFile InputFile { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigDigiWaterMarkInputFile : TeaModel {
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

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Editing")]
                    [Validation(Required=false)]
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigEditing Editing { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditing : TeaModel {
                        [NameInMap("ClipList")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingClipList ClipList { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingClipList : TeaModel {
                            [NameInMap("Clip")]
                            [Validation(Required=false)]
                            public List<QueryEditingJobListResponseBodyJobListJobEditingConfigEditingClipListClip> Clip { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingClipListClip : TeaModel {
                                [NameInMap("Effects")]
                                [Validation(Required=false)]
                                public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingClipListClipEffects Effects { get; set; }
                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingClipListClipEffects : TeaModel {
                                    [NameInMap("Effect")]
                                    [Validation(Required=false)]
                                    public List<QueryEditingJobListResponseBodyJobListJobEditingConfigEditingClipListClipEffectsEffect> Effect { get; set; }
                                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingClipListClipEffectsEffect : TeaModel {
                                        [NameInMap("Effect")]
                                        [Validation(Required=false)]
                                        public string Effect { get; set; }

                                        [NameInMap("EffectConfig")]
                                        [Validation(Required=false)]
                                        public string EffectConfig { get; set; }

                                    }

                                }

                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                [NameInMap("In")]
                                [Validation(Required=false)]
                                public string In { get; set; }

                                [NameInMap("Out")]
                                [Validation(Required=false)]
                                public string Out { get; set; }

                                [NameInMap("SourceID")]
                                [Validation(Required=false)]
                                public string SourceID { get; set; }

                                [NameInMap("SourceStrmMap")]
                                [Validation(Required=false)]
                                public string SourceStrmMap { get; set; }

                                [NameInMap("SourceType")]
                                [Validation(Required=false)]
                                public string SourceType { get; set; }

                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                        }

                        [NameInMap("Timeline")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimeline Timeline { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimeline : TeaModel {
                            [NameInMap("TimelineConfig")]
                            [Validation(Required=false)]
                            public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTimelineConfig TimelineConfig { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTimelineConfig : TeaModel {
                                [NameInMap("TimelineConfigAudio")]
                                [Validation(Required=false)]
                                public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTimelineConfigTimelineConfigAudio TimelineConfigAudio { get; set; }
                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTimelineConfigTimelineConfigAudio : TeaModel {
                                    [NameInMap("ChannelLayout")]
                                    [Validation(Required=false)]
                                    public string ChannelLayout { get; set; }

                                    [NameInMap("Channels")]
                                    [Validation(Required=false)]
                                    public string Channels { get; set; }

                                    [NameInMap("Samplerate")]
                                    [Validation(Required=false)]
                                    public string Samplerate { get; set; }

                                }

                                [NameInMap("TimelineConfigVideo")]
                                [Validation(Required=false)]
                                public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTimelineConfigTimelineConfigVideo TimelineConfigVideo { get; set; }
                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTimelineConfigTimelineConfigVideo : TeaModel {
                                    [NameInMap("BgColor")]
                                    [Validation(Required=false)]
                                    public string BgColor { get; set; }

                                    [NameInMap("Fps")]
                                    [Validation(Required=false)]
                                    public string Fps { get; set; }

                                    [NameInMap("Height")]
                                    [Validation(Required=false)]
                                    public string Height { get; set; }

                                    [NameInMap("IsGpuData")]
                                    [Validation(Required=false)]
                                    public string IsGpuData { get; set; }

                                    [NameInMap("IsOneTrackData")]
                                    [Validation(Required=false)]
                                    public string IsOneTrackData { get; set; }

                                    [NameInMap("ReclosePrec")]
                                    [Validation(Required=false)]
                                    public string ReclosePrec { get; set; }

                                    [NameInMap("RenderRatio")]
                                    [Validation(Required=false)]
                                    public string RenderRatio { get; set; }

                                    [NameInMap("Width")]
                                    [Validation(Required=false)]
                                    public string Width { get; set; }

                                }

                            }

                            [NameInMap("TrackList")]
                            [Validation(Required=false)]
                            public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackList TrackList { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackList : TeaModel {
                                [NameInMap("Track")]
                                [Validation(Required=false)]
                                public List<QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrack> Track { get; set; }
                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrack : TeaModel {
                                    [NameInMap("Clips")]
                                    [Validation(Required=false)]
                                    public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrackClips Clips { get; set; }
                                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrackClips : TeaModel {
                                        [NameInMap("Clip")]
                                        [Validation(Required=false)]
                                        public List<QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrackClipsClip> Clip { get; set; }
                                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrackClipsClip : TeaModel {
                                            [NameInMap("ClipsConfig")]
                                            [Validation(Required=false)]
                                            public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrackClipsClipClipsConfig ClipsConfig { get; set; }
                                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrackClipsClipClipsConfig : TeaModel {
                                                [NameInMap("ClipsConfigVideo")]
                                                [Validation(Required=false)]
                                                public QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrackClipsClipClipsConfigClipsConfigVideo ClipsConfigVideo { get; set; }
                                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigEditingTimelineTrackListTrackClipsClipClipsConfigClipsConfigVideo : TeaModel {
                                                    [NameInMap("L")]
                                                    [Validation(Required=false)]
                                                    public string L { get; set; }

                                                    [NameInMap("T")]
                                                    [Validation(Required=false)]
                                                    public string T { get; set; }

                                                }

                                            }

                                            [NameInMap("In")]
                                            [Validation(Required=false)]
                                            public string In { get; set; }

                                            [NameInMap("Out")]
                                            [Validation(Required=false)]
                                            public string Out { get; set; }

                                            [NameInMap("clipID")]
                                            [Validation(Required=false)]
                                            public string ClipID { get; set; }

                                        }

                                    }

                                    [NameInMap("Id")]
                                    [Validation(Required=false)]
                                    public string Id { get; set; }

                                    [NameInMap("Order")]
                                    [Validation(Required=false)]
                                    public string Order { get; set; }

                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }

                                }

                            }

                        }

                    }

                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigEncryption Encryption { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigEncryption : TeaModel {
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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigM3U8NonStandardSupport : TeaModel {
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigM3U8NonStandardSupportTS TS { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigM3U8NonStandardSupportTS : TeaModel {
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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigMergeList MergeList { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigMergeList : TeaModel {
                        [NameInMap("Merge")]
                        [Validation(Required=false)]
                        public List<QueryEditingJobListResponseBodyJobListJobEditingConfigMergeListMerge> Merge { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigMergeListMerge : TeaModel {
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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigMuxConfig MuxConfig { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigMuxConfig : TeaModel {
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigMuxConfigGif Gif { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigMuxConfigGif : TeaModel {
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
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigMuxConfigSegment Segment { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigMuxConfigSegment : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }

                    }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigOutputFile OutputFile { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigOutputFile : TeaModel {
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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigProperties Properties { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigProperties : TeaModel {
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
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesFormat Format { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesFormat : TeaModel {
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
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreams Streams { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreams : TeaModel {
                            [NameInMap("AudioStreamList")]
                            [Validation(Required=false)]
                            public QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsAudioStreamList : TeaModel {
                                [NameInMap("AudioStream")]
                                [Validation(Required=false)]
                                public List<QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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
                            public QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsSubtitleStreamList : TeaModel {
                                [NameInMap("SubtitleStream")]
                                [Validation(Required=false)]
                                public List<QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
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
                            public QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsVideoStreamListVideoStream : TeaModel {
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
                                    public QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfig SubtitleConfig { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfig : TeaModel {
                        [NameInMap("ExtSubtitleList")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigExtSubtitleList : TeaModel {
                            [NameInMap("ExtSubtitle")]
                            [Validation(Required=false)]
                            public List<QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                [NameInMap("CharEnc")]
                                [Validation(Required=false)]
                                public string CharEnc { get; set; }

                                [NameInMap("FontName")]
                                [Validation(Required=false)]
                                public string FontName { get; set; }

                                [NameInMap("Input")]
                                [Validation(Required=false)]
                                public QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                public class QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
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
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigSubtitleList SubtitleList { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigSubtitleList : TeaModel {
                            [NameInMap("Subtitle")]
                            [Validation(Required=false)]
                            public List<QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigSubtitleConfigSubtitleListSubtitle : TeaModel {
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                            }

                        }

                    }

                    [NameInMap("SuperReso")]
                    [Validation(Required=false)]
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigSuperReso SuperReso { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigSuperReso : TeaModel {
                        [NameInMap("IsHalfSample")]
                        [Validation(Required=false)]
                        public string IsHalfSample { get; set; }

                    }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigTransConfig TransConfig { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigTransConfig : TeaModel {
                        [NameInMap("AdjDarMethod")]
                        [Validation(Required=false)]
                        public string AdjDarMethod { get; set; }

                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigVideo Video { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigVideo : TeaModel {
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingConfigVideoBitrateBnd BitrateBnd { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigVideoBitrateBnd : TeaModel {
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
                    public QueryEditingJobListResponseBodyJobListJobEditingConfigWaterMarkList WaterMarkList { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingConfigWaterMarkList : TeaModel {
                        [NameInMap("WaterMark")]
                        [Validation(Required=false)]
                        public List<QueryEditingJobListResponseBodyJobListJobEditingConfigWaterMarkListWaterMark> WaterMark { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingConfigWaterMarkListWaterMark : TeaModel {
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
                            public QueryEditingJobListResponseBodyJobListJobEditingConfigWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class QueryEditingJobListResponseBodyJobListJobEditingConfigWaterMarkListWaterMarkInputFile : TeaModel {
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

                [NameInMap("EditingInputs")]
                [Validation(Required=false)]
                public QueryEditingJobListResponseBodyJobListJobEditingInputs EditingInputs { get; set; }
                public class QueryEditingJobListResponseBodyJobListJobEditingInputs : TeaModel {
                    [NameInMap("EditingInput")]
                    [Validation(Required=false)]
                    public List<QueryEditingJobListResponseBodyJobListJobEditingInputsEditingInput> EditingInput { get; set; }
                    public class QueryEditingJobListResponseBodyJobListJobEditingInputsEditingInput : TeaModel {
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("InputConfig")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingInputsEditingInputInputConfig InputConfig { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingInputsEditingInputInputConfig : TeaModel {
                            [NameInMap("DeinterlaceMethod")]
                            [Validation(Required=false)]
                            public string DeinterlaceMethod { get; set; }

                            [NameInMap("IsNormalSar")]
                            [Validation(Required=false)]
                            public string IsNormalSar { get; set; }

                        }

                        [NameInMap("InputFile")]
                        [Validation(Required=false)]
                        public QueryEditingJobListResponseBodyJobListJobEditingInputsEditingInputInputFile InputFile { get; set; }
                        public class QueryEditingJobListResponseBodyJobListJobEditingInputsEditingInputInputFile : TeaModel {
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

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QueryEditingJobListResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryEditingJobListResponseBodyJobListJobMNSMessageResult : TeaModel {
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

        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public QueryEditingJobListResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class QueryEditingJobListResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
